using Curse.SharedContext;

namespace Curse.SubscritionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}