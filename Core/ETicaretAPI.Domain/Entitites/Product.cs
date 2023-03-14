using ETicaretAPI.Domain.Entitites.Common;

namespace ETicaretAPI.Domain.Entitites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }

        /// <summary>
        /// Bir productın birden fazla order'ı olduğunu ifade eder
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}
