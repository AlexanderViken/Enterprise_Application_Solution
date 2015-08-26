using System;
using $ext_safeprojectname$.$safeprojectname$.Values;

namespace $ext_safeprojectname$.$safeprojectname$.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Money Price { get; set; }
    }
}
