using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        public StatusRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
