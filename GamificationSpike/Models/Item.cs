using System;
namespace GamificationSpike.Models
{
    public class Item
    { 
        public long Id { get; set; }
        public string Name { get; set; }
        public long StepId { get; set; }
        public bool IsComplete { get; set; } 
    }
}
