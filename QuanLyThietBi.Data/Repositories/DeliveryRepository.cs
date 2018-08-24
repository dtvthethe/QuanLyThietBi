using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class DeliveryRepository : RepositoryBase<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
