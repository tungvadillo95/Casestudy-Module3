﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VATUClothesShop.Models;
using VATUClothesShop.ViewModels;

namespace VATUClothesShop.Repository
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetBrands();
        BrandViewModel GetBrand(int Id);
        int CreateBrand(BrandViewModel model);
        int EditBrand(BrandViewModel model);
        bool DeleteBrand(int Id);
    }
}
