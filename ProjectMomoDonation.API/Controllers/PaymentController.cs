using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ProjectMomoDonation.API.MomoPayment;
using System.Text.Json;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreatePayment()
        {
            //request params need to request to MoMo system
            string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
            string partnerCode = "MOMO5RGX20191128";
            string accessKey = "M8brj9K6E22vXoDB";
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = "Momo thanh toán";
            string redirectUrl = "Youtube.com";
            string ipnUrl = "youtube.com";
            string requestType = "captureWallet";

            string amount = 150000.ToString();
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

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

            MomoRequest requestTest = new MomoRequest()
            {
                partnerCode = partnerCode,
                partnerName = "test",
                storeId = Guid.NewGuid().ToString(),
                signature = signature,
                requestId= requestId,
                orderId=orderId,
                amount=amount,
                orderInfo =orderInfo,
                redirectUrl=redirectUrl,
                ipnUrl=ipnUrl,
                lang ="en",
                extraData= extraData,
                requestType = requestType,
            };
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

            var responetest = PaymentRequest.sendRequest(requestTest);
            JObject jmessage = JObject.Parse(responseFromMomo);

            //var jsonResult = JsonSerializer.Deserialize<MomoResposeUrl>(jmessage.ToString());
            return Ok(jmessage);
        }
    }
}
