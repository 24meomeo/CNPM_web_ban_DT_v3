//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnQuanLyTapHoa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public int MaCTDH { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> MaDH { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> TongTienSP { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
