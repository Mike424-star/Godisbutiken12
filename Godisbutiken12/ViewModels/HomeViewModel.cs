using Godisbutiken12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Godis> CandyOnSale { get; set; }
    }
}
