using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTaxiCallCenter
{
    public interface ITaxiCallMediator
    {
        void Register(ITaxi taxi);
        string Book(IPassenger passenger);
        List<ITaxi> GetTaxis();
    }
}
