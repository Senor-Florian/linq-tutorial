using System;

namespace LINQ_Tutorial.MockData
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
        public string Settlement { get; set; }
        public string StreetAddress { get; set; }
    }
}
