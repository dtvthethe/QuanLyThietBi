using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        /// <summary>
        /// Get record by ID type of String
        /// </summary>
        /// <param name="id">Id Role</param>
        /// <returns>Record type of Role</returns>
        public Role GetById(string id)
        {
            return DbContext.Roles.Find(id);
        }
    }
}
