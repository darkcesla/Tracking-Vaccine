using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BPOM.Models
{
    public class AkunPasien
    {
        public int id_akun { get; set; }
        public string nama { get; set; }

        public string nik { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int role { get; set; }
    }
}