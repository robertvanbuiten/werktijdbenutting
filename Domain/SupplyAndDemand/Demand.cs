using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wtb.Domain
{
    public class Demand
    {
        public Guid Id { get; set; }
        public string Description {get; set;}
        public string Location { get; set; }
        public List<Education> DemandedEducations { get; set; }
        public List<Skill> DemandedSkills { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinRate { get; set; }
        public int MaxRate { get; set; }
        public int HoursPerWeek { get; set; }

        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set;}
        public Organization Organization { get; set; }
    }
}