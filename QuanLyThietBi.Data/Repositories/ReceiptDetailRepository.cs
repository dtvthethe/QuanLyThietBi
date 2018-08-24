using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class ReceiptDetailRepository : RepositoryBase<ReceiptDetail>, IReceiptDetailRepository
    {
        public ReceiptDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
