using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTaxiCallCenter
{
    public class TaxiCallMediator : ITaxiCallMediator
    {
        private Dictionary<string, ITaxi> taxis = new Dictionary<string, ITaxi>();

        public void Register(ITaxi taxi)
        {
            if (!taxis.ContainsValue(taxi))
            {
                taxis.Add(taxi.Name, taxi);
            }
        }

        public string Book(IPassenger passenger)
        {
            ITaxi closestTaxi = null;
            int minDistance = Int32.MaxValue;

            foreach (var taxi in taxis.Values.Where(c => c.IsFree))
            {
                int distance = Math.Abs(taxi.CurrentLocation - passenger.Location);
                if (distance < minDistance)
                {
                    closestTaxi = taxi;
                    minDistance = distance;
                }
            }

            string out1 = closestTaxi.Assign(passenger.Name, passenger.Address);
            string out2 = passenger.Acknowledge(closestTaxi.Name);

            return out1 + " " + out2;
        }

        public List<ITaxi> GetTaxis()
        {
            return taxis.Values.ToList();
        }

    }
}
