﻿using QL_BanHang.Interfaces;
using QL_BanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHang.Services
{
    public class GioHangService : IGioHangService
    {
        private readonly QL_BanHangTuiXachContext _context;
        public GioHangService(QL_BanHangTuiXachContext context)
        {
            _context = context;
        }
        public List<ThanhToan> GetListThanhToan()
        {
            return _context.ThanhToans.ToList();
        }

       
        public async Task<bool> ThanhToanNow(Cart cart, ThanhToan tt)
        {
            DonHang dh = new DonHang()
            {
                MaKh = cart.MaKH,
                MaTt = tt.MaTt,
                NgayLapHd = DateTime.Now
            };

            List<Ctdh> lt = new List<Ctdh>();

            foreach (var item in cart.Items)
            {
                lt.Add(new Ctdh()
                {
                    MaDh = dh.MaDh,
                    SoLuong = item.SoLuong,
                    MaSp = item.sanPham.MaSp
                });
            }
            dh.Ctdhs = lt;

            await _context.DonHangs.AddAsync(dh);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
