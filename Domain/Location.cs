using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wtb.Domain
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Description { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set;} 

        public string City { get; set; }

        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set;}
        public Organization Organization { get; set; }
    }
}