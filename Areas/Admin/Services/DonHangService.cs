﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QL_BanHang.Areas.Admin.Interfaces;
using QL_BanHang.Models;

namespace QL_BanHang.Areas.Admin.Services
{
    public class DonHangService: IDonHangService
    {
        private readonly QL_BanHangTuiXachContext _context;
        public DonHangService (QL_BanHangTuiXachContext context)
        {
            _context = context;
        }
        public List<DonHang> GetDH()
        {
            return _context.DonHangs.ToList();
        }
        public DonHang GetDHById(int id)
        {
            return _context.DonHangs.Find(id);
        }
        // create
        public void CreateDH(DonHang donHang)
        {       
            _context.DonHangs.Add(donHang);
            _context.SaveChanges();

        }

        public bool UpdateDonHang(int id, DonHang donHang)
        {
            try
            {
                var dh = _context.DonHangs.Find(id);
                if (dh == null) return false;
                dh.Ctdhs = donHang.Ctdhs;
                dh.NgayGh = donHang.NgayGh;
                dh.NgayLapHd = donHang.NgayLapHd;
                dh.MaTt = donHang.MaTt;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDH(int id)
        {
            try
            {
                var dh = _context.DonHangs.Find(id);
                _context.DonHangs.Remove(dh);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
