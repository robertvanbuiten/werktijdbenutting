using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wtb.Domain
{
    public class Expertise
    {
        public Guid Id { get; set; }
        public string Description {get; set;}
         [ForeignKey("Organization")]
        public Guid OrganizationId { get; set;}
        public Organization Organization { get; set; }
       
    }
}