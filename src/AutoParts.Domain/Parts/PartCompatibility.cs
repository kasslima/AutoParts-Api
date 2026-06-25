using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Parts
{
    public  class PartCompatibility : Shared.Entity
    {
        public Guid PartId { get; private set; }

        public Guid VehicleId { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }



        public PartCompatibility(Guid partId, Guid vehicleId)
        {
            if (partId == Guid.Empty)
                throw new ArgumentException("PartId is required.", nameof(partId));
            if (vehicleId == Guid.Empty)
                throw new ArgumentException("VehicleId is required.", nameof(vehicleId));
            PartId = partId;
            VehicleId = vehicleId;
        }
    }
}
