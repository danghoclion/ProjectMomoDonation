namespace ProjectMomoDonation.API.MomoPayment
{
    public class MomoResposeUrl
    {
        public string partnerCode { get; set; }
        public string orderId { get; set; }
        public string requestId { get; set; }
        public string amount { get; set; }
        public string responseTime { get; set; }
        public string message { get; set; }
        public string resultCode { get; set; }
        public string payUrl { get; set; }
        public string deeplink { get; set; }
        public string deeplinkMiniApp { get; set; }
    }
}
