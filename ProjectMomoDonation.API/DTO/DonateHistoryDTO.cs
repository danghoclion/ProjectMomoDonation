﻿namespace ProjectMomoDonation.API.DTO
{
    public class DonateHistoryDTO
    {
        public string Id { get; set; }
        public string NameProgram { get; set; }
        public decimal Amount { get; set; }
        public DateTime Time { get; set; }
    }
}
