using System;

namespace Common.Domain.Models
{
    public class ProductEntity : Entity<int>
    {
        public ProductEntity()
        {
        }
        public byte[] Image { get; private set; }

        public string Name { get; private set; }

        public string Calories { get; private set; }

        public Ingredients Ingredients { get; private set; }

        public string BarCode { get; private set; }

        public DateTime ExpiryDate { get; private set; }

        public bool HasEggs { get; private set; }
        public Category Category { get; }
    }
}
