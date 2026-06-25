using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Vehicles
{
    public  class VehicleCategory : Shared.Entity
    {
        public string Name { get; private set; }

        public VehicleCategory(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 2)
                throw new ArgumentException("Name is too short.", nameof(name));
            Name = name;
        }
    }
}
