using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstLibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "تصنيف الكتاب")]
        public string CategoryName { get; set; }

        [Required]
        [Display(Name ="وصف التصنيف")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Books>book{ get; set; }


    }
}