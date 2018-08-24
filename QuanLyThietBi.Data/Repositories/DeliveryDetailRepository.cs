using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class DeliveryDetailRepository : RepositoryBase<DeliveryDetail>, IDeliveryDetailRepository
    {
        public DeliveryDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
