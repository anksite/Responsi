using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    public class Customer
    {
        // TODO: lengkapi property class Customer
        public string kode { get; set; }
        public string nama { get; set; }
        public int piutang { get; set; }

        public Customer(string kode, string nama, int piutang) {
            this.kode    = kode;
            this.nama    = nama;
            this.piutang = piutang;
        }
    }
}
