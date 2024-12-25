namespace OnCuoiKy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhanvien")]
    public partial class Nhanvien
    {
        [Key]
        public int manv { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DisplayName("Tên")]
        [StringLength(30)]
        public string hotennv { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [DisplayName("Tuổi")]
        public int tuoi { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [DisplayName("Địa chỉ")]
        [StringLength(30)]
        public string diachi { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [DisplayName("Lương")]
        public int luongnv { get; set; }

        [DisplayName("Mã phòng")]
        public int? maphong { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DisplayName("Mật khẩu")]
        [StringLength(50)]
        public string matkhau { get; set; }

        public virtual Phongban Phongban { get; set; }
    }
}
