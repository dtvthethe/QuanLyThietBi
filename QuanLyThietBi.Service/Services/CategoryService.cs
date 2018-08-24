﻿using QuanLyThietBi.Data.Infrastructure;
using QuanLyThietBi.Data.IRepositories;
using QuanLyThietBi.Model.Models;
using QuanLyThietBi.Service.IServices;
using System.Collections.Generic;

namespace QuanLyThietBi.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public Category Add(Category category)
        {
            return _categoryRepository.Add(category);
        }

        public Category Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetSingleById(id);
        }

        public Category Update(Category category)
        {
            return _categoryRepository.Update(category);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

    }
}
