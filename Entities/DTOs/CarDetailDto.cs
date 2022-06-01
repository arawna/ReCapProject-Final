using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
