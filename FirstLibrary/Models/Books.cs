using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FirstLibrary.Models
{
    public class Books
    {
        public int Id { get; set; }
        [DisplayName("اسم الكتاب")]
        public string BookTitle { get; set; }


        [DisplayName("وصف الكتاب")]
        public string BookContent { get; set; }


        [DisplayName("صورة الغلاف")]
        public string BookImage { get; set; }

        [DisplayName("ملف الكتاب ")]
        public string EBook { get; set; }


        [DisplayName("تصنيف الكتاب")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }


    }
}