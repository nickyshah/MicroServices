﻿namespace Mango.Services.RewardAPI.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public DateTime RewardsDate { get; set; }
        public int RewardsActivity { get; set; }
        public int OrderId { get; set; }
    }
}
