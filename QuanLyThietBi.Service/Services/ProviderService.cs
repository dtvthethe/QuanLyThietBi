using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Data.IRepositories;
using QuanLyThietBi.Model.Models;
using QuanLyThietBi.Service.IServices;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProviderService(IProviderRepository providerRepository, IUnitOfWork unitOfWork)
        {
            _providerRepository = providerRepository;
            _unitOfWork = unitOfWork;
        }

        public Provider Add(Provider provider)
        {
            return _providerRepository.Add(provider);
        }

        public Provider Delete(int id)
        {
            return _providerRepository.Delete(id);
        }

        public IEnumerable<Provider> GetAll()
        {
            return _providerRepository.GetAll();
        }

        public Provider GetById(int id)
        {
            return _providerRepository.GetSingleById(id);
        }

        public Provider Update(Provider provider)
        {
            return _providerRepository.Update(provider);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

    }
}
