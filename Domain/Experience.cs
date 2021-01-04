using System;

namespace Domain
{
    public class Experience
    {
        public Guid Id { get; set; }

        public string Omschrijving { get; set; }

        public string Bedrijf { get; set; }

        public int AantalJaar { get; set;}
    }
}