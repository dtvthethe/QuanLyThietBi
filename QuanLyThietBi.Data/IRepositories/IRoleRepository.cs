using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Model.Models;

namespace QuanLyThietBi.Data.IRepositories
{
    public interface IRoleRepository : IRepository<Role>
    {

        Role GetById(string id);

    }
}
