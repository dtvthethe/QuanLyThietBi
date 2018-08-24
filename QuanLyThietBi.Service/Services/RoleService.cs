using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Data.IRepositories;
using QuanLyThietBi.Model.Models;
using QuanLyThietBi.Service.IServices;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public Role Add(Role role)
        {
            return _roleRepository.Add(role);
        }

        public Role Delete(Role role)
        {
            return _roleRepository.Delete(role);
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public Role GetById(string id)
        {
            return _roleRepository.GetById(id);
        }

        public Role Update(Role role)
        {
            return _roleRepository.Update(role);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

    }
}
