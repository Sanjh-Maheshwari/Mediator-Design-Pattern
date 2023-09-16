using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTaxiCallCenter
{
    public interface ITaxi
    {
        string Name { get; }
        int CurrentLocation { get; }
        bool IsFree { get; }
        string Assign(string name, string address);
    }
}
