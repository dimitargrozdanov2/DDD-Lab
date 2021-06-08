using Common.Domain.Enumeration;

namespace Common.Domain.Models
{
    public class Category : Enumeration<Category>
    {
        public static readonly Category Pasta = new Category(1, nameof(Pasta));
        public static readonly Category Rice = new Category(2, nameof(Rice));
        public static readonly Category Lentils = new Category(2, nameof(Lentils));
        public static readonly Category WhiteBeans = new Category(2, nameof(WhiteBeans));



        protected Category(int id, string name)
            : base(id, name)
        {
        }
    }
}
