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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietDonHang = new HashSet<ChiTietDonHang>();
            this.NhapHang = new HashSet<NhapHang>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string HinhSP { get; set; }
        public string MoTaSP { get; set; }
        public Nullable<int> GiaSP { get; set; }
        public Nullable<int> SoLuongSP { get; set; }
        public string MaLoai { get; set; }
        public string MaNSX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHang { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapHang> NhapHang { get; set; }
    }
}
