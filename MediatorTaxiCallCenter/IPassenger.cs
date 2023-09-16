using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTaxiCallCenter
{
    public interface IPassenger
    {
        string Name { get; }
        string Address { get; }
        int Location { get; }
        string Acknowledge(string name);
    }
}
