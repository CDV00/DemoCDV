﻿using Demo02_11.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
