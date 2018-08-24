using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class UnitRepository : RepositoryBase<Unit>, IUnitRepository
    {
        public UnitRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
