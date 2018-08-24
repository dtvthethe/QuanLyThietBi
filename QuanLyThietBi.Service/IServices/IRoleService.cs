using QuanLyThietBi.Model.Models;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.IServices
{
    public interface IRoleService
    {
        Role Add(Role role);

        Role Update(Role role);

        Role Delete(Role role);

        IEnumerable<Role> GetAll();

        Role GetById(string id);

        void SaveChanges();
    }
}
