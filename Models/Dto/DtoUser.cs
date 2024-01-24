﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Xproduct.Models.Dto
{
    public class DtoUser
    {
        public int idUser { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Vui lòng nhập tên đầy đủ")]
        public string FullName { get; set; }



        [StringLength(100)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string Email { get; set; }


        //[StringLength(10)]
        //[RegularExpression(@"^0\d{9}$")]
        //[Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string Sdt { get; set; }


        [StringLength(50)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Vui lòng nhập Password")]
        public string Password { get; set; }



        //[StringLength(50)]
        //[DataType(DataType.Password)]
        //[Compare("Password")]
        //[Required(ErrorMessage = "Thông tin Confirm Passwork sai")]
        //public string ConfirmPassword { get; set; }
        public string LoginErrorMessage { get; set; }

        [StringLength(50)]
        public string CCCD { get; set; }


        public int? IdChucVu { get; set; }
        public int? IdPhongBan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        public virtual ChucVu ChucVu { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}