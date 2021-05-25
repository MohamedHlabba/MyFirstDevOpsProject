using System;

namespace MyFirstDevOpsProject.Shared
{
    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Comment { get; set; }
    }
}
