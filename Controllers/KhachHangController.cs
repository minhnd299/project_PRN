﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QL_BanHang.Interfaces;
using QL_BanHang.Models;


namespace QL_BanHang.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly IKhachHangService _khachHangService;

        public KhachHangController(IKhachHangService khachHangService)
        {
            _khachHangService = khachHangService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //GET: Admin/SanPham/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var khachHang = _khachHangService.GetKHById(id);
            return View(khachHang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, KhachHang khachHang)
        {
            var result = _khachHangService.UpdateKhachHang(id, khachHang);
            if (result)
            {
                return Redirect("/");
            }
            ModelState.AddModelError("", "Có lỗi xảy ra khi chỉnh sửa nhân viên. Vui lòng thử lại sau");
            return View(_khachHangService.GetKHById(id));
        }


    }
}
