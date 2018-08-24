using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
