using System;
using Curse.SharedContext;

namespace Curse.SubscritionContext
{
    public class Subscrition : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}