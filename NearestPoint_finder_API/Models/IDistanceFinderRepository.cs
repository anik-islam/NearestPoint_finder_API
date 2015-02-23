using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestPoint_finder_API.Models
{
    public interface IDistanceFinderRepository
    {
        IEnumerable<DistanceFinder> Find_Values();
        DistanceFinder Find_Value(string id);
        DistanceFinder Insert_Values(DistanceFinder values);
    }
}
