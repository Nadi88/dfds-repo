using DFDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFDS.Interfaces
{
    public interface ITruckPlan
    {
        TruckPlan GetTruckPlan(int id);
    }
}
