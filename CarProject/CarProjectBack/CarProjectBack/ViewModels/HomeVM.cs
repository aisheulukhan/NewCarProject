using CarProjectBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProjectBack.ViewModels
{
    public class HomeVM
    {
        public List<Car> Cars { get; set; }
        public List<Category> Categories { get; set; }
    }
}
