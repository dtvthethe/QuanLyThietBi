﻿using QuanLyThietBi.Model.Models;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.IServices
{
    public interface ICategoryService
    {
        Category Add(Category category);

        Category Update(Category category);

        Category Delete(int id);

        IEnumerable<Category> GetAll();

        Category GetById(int id);

        void SaveChanges();
    }
}
