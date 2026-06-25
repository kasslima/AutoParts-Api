using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Vehicle
{
    public class Vehicle : Shared.Entity
    {
        public string Model { get; private set; }
        public Guid BrandId { get; private set; }
        public string Brand { get; private set; }
        public string YearStart { get; private set; }
        public string YearEnd { get; private set; }
        public string Engine { get; private set; }
        public string Transmission { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Vehicle(
            string model,
            Guid brandId,
            string yearStart,
            string yearEnd,
            string engine,
            string transmission)
        {
            if (string.IsNullOrWhiteSpace(model) || model.Length <= 2)
                throw new ArgumentException("Model is too short.", nameof(model));
            if (brandId == Guid.Empty)
                throw new ArgumentException("Brand is required.", nameof(brandId));
            if (string.IsNullOrWhiteSpace(yearStart))
                throw new ArgumentException("Year start is required.", nameof(yearStart));
            if (string.IsNullOrWhiteSpace(yearEnd))
                throw new ArgumentException("Year end is required.", nameof(yearEnd));
            if (string.IsNullOrWhiteSpace(engine))
                throw new ArgumentException("Engine is required.", nameof(engine));
            if (string.IsNullOrWhiteSpace(transmission))
                throw new ArgumentException("Transmission is required.", nameof(transmission));
            Model = model;
            BrandId = brandId;
            YearStart = yearStart;
            YearEnd = yearEnd;
            Engine = engine;
            Transmission = transmission;

        }


    }
}
