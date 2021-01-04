using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wtb.Domain
{
    public class Organization
    {
        [Key]
        public Guid Id {get;set;}
        public Byte[] Logo { get;set; }
        public string Name { get; set;}
        public string Branch {get; set;}
        public string CompanyType { get; set; }
        public int Phonenumber { get; set;}
        public DateTime DateOfEstablishment {get;set;} 
        public List<Expertise> Expertises {get; set;}
        public List<Location> Locations {get; set;}
        public List<Demand> DemandedRequests  { get; set;}
    }
}