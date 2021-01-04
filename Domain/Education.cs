using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wtb.Domain
{
    public class Education
    {
        public Guid Id { get; set; }
        public string Omschrijving {get; set;}
        public string Duur { get; set; }
        public string Onderwijsinstelling { get; set; }
        public string Titel { get; set; }
        public bool Diploma { get; set; }
  
        [ForeignKey("Demand")]
        public Guid DemandId {get;set;}
        public Demand Demand { get; set; }


    }
}