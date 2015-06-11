using System;
using $safeprojectname$.Values;

namespace $safeprojectname$.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Money Price { get; set; }
    }
}
