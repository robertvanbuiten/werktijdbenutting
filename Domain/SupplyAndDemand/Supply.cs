using System;

namespace Wtb.Domain
{
    public class Supply
    {
        public Guid Id { get; set;}

        public DateTime StartDate { get; set;} 

        public DateTime EndDate { get; set; }

        public int HoursPerWeek { get; set; }

        public int MinRate { get; set; }
        public int MaxRate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }

    public enum TypePositie {
        Vraag,
        Aanbod
    }
}
