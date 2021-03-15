using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071067_NguyenThanhNhan.Models
{
    public class StudentInfo
    {
       [DataMember(Name ="idStudent")]
        public String idStudent { get; set; }

        [DataMember(Name = "NameStudent")]
        public String NameStudent { get; set; }

        [DataMember(Name = "AddressStudent")]
        public String AddressStudent { get; set; }


    }
}