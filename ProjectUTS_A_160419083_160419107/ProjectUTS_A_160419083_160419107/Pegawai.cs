using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUTS_A_160419083_160419107
{
    public class Pegawai
    {
        private string nama;
        private string alamat;
        private string no_telepon;
        private DateTime tanggal_lahir;
        private string password;

        public Pegawai(string nama, string alamat, string no_telepon, DateTime tanggal_lahir, string password)
        {
            this.Nama = nama;
            this.Alamat = alamat;
            this.No_telepon = no_telepon;
            this.Tanggal_lahir = tanggal_lahir;
            this.Password = password;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string No_telepon { get => no_telepon; set => no_telepon = value; }
        public DateTime Tanggal_lahir { get => tanggal_lahir; set => tanggal_lahir = value; }
        public string Password { get => password; set => password = value; }


    }
}
