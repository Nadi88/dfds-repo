using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFDS.Interfaces
{
    public interface ILocation
    {
        string GetCountry(double latitude, double longitude);
    }
}
