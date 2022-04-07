using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Models
{
    public interface IGodisRepository
    {
        IEnumerable<Godis> GetAllGodis { get; }
        IEnumerable<Godis> GetGodisOnSale { get; }
        Godis GetGodisById(int GodisId);

    }
}
