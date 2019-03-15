using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace policripsysoftware
{
    class pasien
    {
        private int NoPasien;
        private string Nama;
        private DateTime TanggalLahir;
        private JenisKelamin JenisKelamin;

        public pasien(string Nama, int NoPasien,DateTime TanggalLahir,JenisKelamin JenisKelamin)
        {
            this.Nama = Nama;
            this.NoPasien = NoPasien;
            this.TanggalLahir = TanggalLahir;
            this.JenisKelamin = JenisKelamin;
        }

        public void mendaftar()
        {

        }
        public void add()
        {

        }
        public void delete()
        {

        }
    }
}