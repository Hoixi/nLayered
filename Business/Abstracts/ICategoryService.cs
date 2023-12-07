﻿using Core.DataAccess.Paging;
using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<IPaginate<Category>> GetListAsync();
    Task Add(Category category);
    Task Update(Category category);
    Task Delete(Category category);
}
