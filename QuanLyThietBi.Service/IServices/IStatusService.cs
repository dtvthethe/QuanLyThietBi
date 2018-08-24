using QuanLyThietBi.Model.Models;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.IServices
{
    public interface IStatusService
    {
        Status Add(Status status);

        Status Update(Status status);

        Status Delete(int id);

        IEnumerable<Status> GetAll();

        Status GetById(int id);

        void SaveChanges();
    }
}
