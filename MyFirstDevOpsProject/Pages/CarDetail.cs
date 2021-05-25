using Microsoft.AspNetCore.Components;
using MyFirstDevOpsProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDevOpsProject.Pages
{
    public partial  class CarDetail
    {
        [Parameter]
        public string  CarId { get; set; }
        public Car Car { get; set; }

        public IEnumerable<Car> Cars { get; set; }

        private List<Category> Categories { get; set; }

        protected override Task OnInitializedAsync()
        {

            InitializeCategories();
            InitializeCars();

            Car = Cars.FirstOrDefault(c=>c.CarId == int.Parse(CarId));


            return base.OnInitializedAsync();
        }
        private void InitializeCategories()
        {
            Categories = new List<Category>()
            {
                new Category{CategoryId = 1, CategoryName = "Sport"},
                new Category{CategoryId = 2, CategoryName = "Coupe"},
                new Category{CategoryId = 3, CategoryName = "4*4"},
                new Category{CategoryId = 4, CategoryName = "Beetle"},
                new Category{CategoryId = 5, CategoryName = "Convertible"},
                new Category{CategoryId = 6, CategoryName = "Electric"},
                new Category{CategoryId = 7, CategoryName = "Sedan"},
                new Category{CategoryId = 8, CategoryName = "MiniVan"},
                new Category{CategoryId = 9, CategoryName = "Muscle Car"},
                new Category{CategoryId = 9, CategoryName = "Antique"},
                new Category{CategoryId = 10, CategoryName = "Micro"}
            };
        }



        private void InitializeCars()
        {
            var c1 = new Car
            {
                CarId = 1,
                Brand = "BMW",
                Name = "M3",
                Model = "335 i",
                CategoryId = 1,
                Comment = "Lorem Ipsum",
                Year = new DateTime(2015, 3, 1)
            };

            var c2 = new Car
            {
                CarId = 2,
                Brand = "Mercedes",
                Name = "SL500",
                Model = "Class s AMG",
                CategoryId = 1,
                Comment = "Lorem Ipsum",
                Year = new DateTime(2017, 12, 24)
            };
            Cars = new List<Car> { c1, c2 };
        }
    }

}

