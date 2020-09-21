﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VATUClothesShop.Models;

namespace VATUClothesShop.Repository
{
    public interface ICatergoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
