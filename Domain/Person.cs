using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wtb.Domain
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        public string Name {get;set;}

        public string LastName { get; set;}

        public string Place { get; set;}

        public string Email {get; set;}

        public int PhoneNumber { get; set; }

         public List<Skill> Skills { get; set; }
    }
}