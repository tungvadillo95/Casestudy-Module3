﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VATUClothesShop.Models;

namespace VATUClothesShop.ViewModels
{
    public class CreateProductViewModel
    {
        public CreateProductViewModel()
        {
            Categories = new List<Category>();
            Brands = new List<Brand>();
        }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        [Required(ErrorMessage ="Bạn chưa nhập tên sản phẩm")]
        [Display(Name ="Tên sản phẩm")]
        [MaxLength(200)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn loại sản phẩm")]
        [Display(Name = "Loại sản phẩm")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn nhãn hiệu sản phẩm")]
        [Display(Name = "Nhãn hiệu")]
        public int BrandingId { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập giá sản phẩm")]
        [Display(Name = "Giá")]
        [Range(1, int.MaxValue, ErrorMessage = "Giá tiền nhập vào không đúng")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số lượng sản phẩm")]
        [Display(Name = "Số lượng")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng nhập vào không đúng")]
        public int Inventory { get; set; }
        [Display(Name = "Mô tả sản phẩm")]
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bạn chưa chọn hình ảnh sản phẩm")]
        public IFormFile Image { get; set; }
        [MaxLength(100)]
        public string ImagePath { get; set; }
    }
}
