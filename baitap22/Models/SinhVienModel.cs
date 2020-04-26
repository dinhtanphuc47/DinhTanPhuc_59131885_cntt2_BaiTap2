using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace baitap22.Models
{

    public class StudentModel
    {
        [DisplayName("Mã số sinh viên: ")]
        public String ID { get; set; }
        [DisplayName("Họ tên: ")]
        public String Name { get; set; }
        [DisplayName("Điểm: ")]
        public double Marks { get; set; }
    }

}