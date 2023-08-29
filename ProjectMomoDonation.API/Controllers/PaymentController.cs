using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.MomoPayment;
using ProjectMomoDonation.Core.Helper;
using ProjectMomoDonation.Core.Models;
using System.Buffers.Text;
using System.Text.Json;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IUnitOfWork unitOfWork;

        public PaymentController(UserManager<IdentityUser> userManager, IUnitOfWork unitOfWork)
        {
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromQuery] string money, string userName, string programId, string urlRedirect)
        {
            //request params need to request to MoMo system
            string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
            string partnerCode = "MOMO5RGX20191128";
            string accessKey = "M8brj9K6E22vXoDB";
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = "Momo thanh toán";
            string redirectUrl = urlRedirect;
            string ipnUrl = urlRedirect;
            string requestType = "captureWallet";

            string amount = money;
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();

            JObject extra = new JObject
            {
                { "UserName", userName },
                { "ProgramId", programId },
                { "AmountDonate", money }
            };

            string extraData = extra.ToString().Base64Encode();

            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;

            //log.Debug("rawHash = " + rawHash);

            MomoSecurity crypto = new MomoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            //log.Debug("Signature = " + signature);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            //log.Debug("Json request to MoMo: " + message.ToString());
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

            var jsonResult = JsonSerializer.Deserialize<MomoResposeUrl>(responseFromMomo);
            return Ok(jsonResult);
        }

        [HttpPost]
        [Route("Response")]
        public async Task<IActionResult> RedirectUrlMomo([FromBody]MomoRequest momoRequest)
        {        
            var data = momoRequest.extraData.Base64Decode();
            JObject result = JObject.Parse(data);
            var userId = userManager.Users.Where(x => x.UserName == result["UserName"].ToString()).FirstOrDefault();
            DonateHistory donateHistory = new DonateHistory()
            {
                Id = userId.Id,
                ProgramDonationId = int.Parse(result["ProgramId"].ToString()),
                Amount = decimal.Parse(result["AmountDonate"].ToString())
            };
            await unitOfWork.DonateHistoryRepository.CreateAsync(donateHistory);
            var program = await unitOfWork.ProgramDonation.GetByIdAsync(donateHistory.ProgramDonationId);
            program.TotalDonate += donateHistory.Amount;
            return Ok();
        }
    }
}
