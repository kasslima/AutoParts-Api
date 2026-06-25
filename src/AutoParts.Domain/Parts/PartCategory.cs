using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.Domain.Parts
{
    public  class PartCategory : Shared.Entity
    {
        public string Name { get; private set; }

        public PartCategory(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 3)
                throw new ArgumentException("Name is too short.", nameof(name));
            Name = name;
        }
    }
}
