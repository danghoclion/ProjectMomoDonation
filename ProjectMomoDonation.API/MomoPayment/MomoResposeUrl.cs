namespace ProjectMomoDonation.API.MomoPayment
{
    public class MomoResposeUrl
    {
        public string partnerCode { get; set; }
        public string orderId { get; set; }
        public string requestId { get; set; }
        public decimal amount { get; set; }
        public decimal responseTime { get; set; }
        public string message { get; set; }
        public decimal resultCode { get; set; }
        public string payUrl { get; set; }
        public string deeplink { get; set; }
        public string deeplinkMiniApp { get; set; }
    }
}
