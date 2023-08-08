using System.Net;
using System.Text;
using System.Text.Json;

namespace ProjectMomoDonation.API.MomoPayment
{
    public class PaymentRequest
    {
        public PaymentRequest()
        {
        }
        public static async Task<MomoResposeUrl> sendRequest(MomoRequest request)
        {
            var client = new HttpClient();

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://test-payment.momo.vn/v2/gateway/api/create"),
                Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json")
            };
            var httpResponse = await client.SendAsync(httpRequest);
            httpResponse.EnsureSuccessStatusCode();

            var responseBody = httpResponse.Content.ReadFromJsonAsync<MomoResposeUrl>();

            return responseBody.Result;
        }
        public static string sendPaymentRequest(string endpoint, string postJsonString)
        {

            try
            {
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(endpoint);

                var postData = postJsonString;

                var data = Encoding.UTF8.GetBytes(postData);

                httpWReq.ProtocolVersion = HttpVersion.Version11;
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/json";

                httpWReq.ContentLength = data.Length;
                httpWReq.ReadWriteTimeout = 30000;
                httpWReq.Timeout = 15000;
                Stream stream = httpWReq.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                string jsonresponse = "";

                using (var reader = new StreamReader(response.GetResponseStream()))
                {

                    string temp = null;
                    while ((temp = reader.ReadLine()) != null)
                    {
                        jsonresponse += temp;
                    }
                }


                //todo parse it
                return jsonresponse;
                //return new MomoResponse(mtid, jsonresponse);

            }
            catch (WebException e)
            {
                return e.Message;
            }
        }
    }
}
