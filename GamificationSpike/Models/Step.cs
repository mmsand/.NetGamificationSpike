using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GamificationSpike.Models
{
    public class Step
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public long numSteps { get; set; }

        public List<Item> Items { get; set; }
    }
}