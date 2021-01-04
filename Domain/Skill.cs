using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wtb.Domain
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Description {get; set;}

        [ForeignKey("Demand")]
        public Guid DemandId {get;set;}
        public Demand Demand { get; set; }

        [ForeignKey("Person")]
        public Guid PersonId {get;set;}
        public Person Person { get; set; }
        
    }
}