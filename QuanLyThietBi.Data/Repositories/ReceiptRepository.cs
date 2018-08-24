using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class ReceiptRepository : RepositoryBase<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
