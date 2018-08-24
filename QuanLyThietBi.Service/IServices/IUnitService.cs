﻿using QuanLyThietBi.Model.Models;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.IServices
{
    public interface IUnitService
    {
        Unit Add(Unit unit);

        Unit Update(Unit unit);

        Unit Delete(int id);

        IEnumerable<Unit> GetAll();

        Unit GetById(int id);

        void SaveChanges();
    }
}
