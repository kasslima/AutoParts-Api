namespace AutoParts.Domain.Parts
{
    public class Part : Shared.Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Code { get; private set; }
        public string ManufacturerCode { get; private set; }

        public Guid BrandId { get; private set; }
        public Guid CategoryId { get; private set; }

        public decimal Price { get; private set; }
        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Part(
            string name,
            string description,
            string code,
            string manufacturerCode,
            Guid brandId,
            Guid categoryId,
            decimal price)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 3)
                throw new ArgumentException("Name is too short.", nameof(name));

            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Code is required.", nameof(code));

            if (string.IsNullOrWhiteSpace(manufacturerCode))
                throw new ArgumentException("Manufacturer code is required.", nameof(manufacturerCode));

            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.", nameof(price));

            if (brandId == Guid.Empty)
                throw new ArgumentException("Brand is required.", nameof(brandId));

            if (categoryId == Guid.Empty)
                throw new ArgumentException("Category is required.", nameof(categoryId));

            Name = name;
            Description = description;
            Code = code;
            ManufacturerCode = manufacturerCode;
            BrandId = brandId;
            CategoryId = categoryId;
            Price = price;

            IsActive = true;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void ChangePrice(decimal price)
        {
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.", nameof(price));

            Price = price;
            UpdatedAt = DateTime.UtcNow;
        }

        public void ChangeCategory(Guid categoryId)
        {
            if (categoryId == Guid.Empty)
                throw new ArgumentException("Category is required.", nameof(categoryId));

            CategoryId = categoryId;
            UpdatedAt = DateTime.UtcNow;
        }

        public void ChangeBrand(Guid brandId)
        {
            if (brandId == Guid.Empty)
                throw new ArgumentException("Brand is required.", nameof(brandId));

            BrandId = brandId;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Deactivate()
        {
            if (!IsActive)
                return;

            IsActive = false;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Activate()
        {
            if (IsActive)
                return;

            IsActive = true;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}