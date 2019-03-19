using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace policripsysoftware
{
    class peg
    {
        private int no_peg;
        private string nama_peg;
        private string password;

        public peg(int no_peg, string nama_peg)
        {
            this.no_peg = no_peg;
            this.nama_peg = nama_peg;
        }
        public string namapeg
        {
            get
            {
                return this.nama_peg;
            }
            set
            {
                this.nama_peg = value;
            }
        }
        public string pass
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value ;
            }
        }

        
    }
}
