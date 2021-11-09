using System.Collections.Generic;

namespace Curse.ContentContext
{
    public class Career : Content
    {
        public Career(IList<CareerItem> careerItem)
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count;

    }
}