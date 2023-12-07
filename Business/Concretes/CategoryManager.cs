﻿using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public async Task Add(Category category)
    {
        await _categoryDal.AddAsync(category);
    }

    public async Task Update(Category category)
    {
        await _categoryDal.UpdateAsync(category);
    }

    public async Task Delete(Category category)
    {
        await _categoryDal.DeleteAsync(category);
    }

    public async Task<IPaginate<Category>> GetListAsync()
    {
        return await _categoryDal.GetListAsync();
    }
}
