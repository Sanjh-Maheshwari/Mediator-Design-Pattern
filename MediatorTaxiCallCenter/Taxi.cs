using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTaxiCallCenter
{
    public class Taxi : ITaxi
    {
        private string _name;
        private int _location;
        private bool _free;

        public Taxi(string name, int location, bool free)
        {
            _name = name;
            _location = location;
            _free = free;
        }

        public string Name => _name;
        public int CurrentLocation => _location;
        public bool IsFree => _free;

        public string Assign(string name, string address)
        {
            return $"The taxi {this.Name} is assigned to passanger {name} and address {address}";
        }
    }
}
