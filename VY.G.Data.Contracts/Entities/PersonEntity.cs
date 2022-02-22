using System;

namespace VY.G.Data.Contracts.Entities
{
    public class PersonEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
