using ETicaretAPI.Domain.Entitites.Common;

namespace ETicaretAPI.Domain.Entitites
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Bir orderin birden fazla product'ı olduğunu ifade eder
        /// </summary>
        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }
    }
}
