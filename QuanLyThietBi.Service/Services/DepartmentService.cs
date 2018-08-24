using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Data.IRepositories;
using QuanLyThietBi.Model.Models;
using QuanLyThietBi.Service.IServices;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
        {
            _departmentRepository = departmentRepository;
            _unitOfWork = unitOfWork;
        }

        public Department Add(Department department)
        {
            return _departmentRepository.Add(department);
        }

        public Department Delete(int id)
        {
            return _departmentRepository.Delete(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetById(int id)
        {
            return _departmentRepository.GetSingleById(id);
        }

        public Department Update(Department department)
        {
            return _departmentRepository.Update(department);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

    }
}
