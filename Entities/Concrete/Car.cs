using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public decimal BrandId { get; set; }
        public decimal ColorId { get; set; }
        public decimal ModelYear { get; set; }
        public int DailyPrice { get; set; }

        public string Description { get; set; }
        public string CarName { get; set; }
    }
}
