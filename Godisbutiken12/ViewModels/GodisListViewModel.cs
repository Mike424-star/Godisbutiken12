using Godisbutiken12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.ViewModels
{
    public class GodisListViewModel
    {
        public IEnumerable<Godis> Godisar { get; set; }
        public string CurrentCategory { get; set; }
    }
}
