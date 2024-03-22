﻿using System;
using System.Collections.Generic;   
using System.Linq;
using System.Threading.Tasks;
using QL_BanHang.Models;

namespace QL_BanHang.Areas.Admin.Interfaces
{
    public interface IDonHangService
    {
        public List<DonHang> GetDH();
        public DonHang GetDHById(int id);
        public bool UpdateDonHang(int id, DonHang donHang);
        public bool DeleteDH(int id);
        void CreateDH(DonHang donHang);
    }
}
