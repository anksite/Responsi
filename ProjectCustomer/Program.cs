using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("--PILIH MENU APLIKASI--");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("--TAMBAH DATA CUSTOMER--");

            Console.Write("Kode Customer: ");
            string kode = Console.ReadLine();

            Console.Write("Nama Customer: ");
            string nama = Console.ReadLine();

            Console.Write("Total Piutang: ");
            int piutang = Convert.ToInt32(Console.ReadLine());

            Customer dataCust = new Customer(kode, nama, piutang);
            dataCust.kode = kode;
            daftarCustomer.Add(dataCust);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("--HAPUS DATA CUSTOMER--");

            Console.Write("Kode Customer: ");
            string kode = Console.ReadLine();

            bool found=false;
            int i = 0, indexHapus=-1;
            foreach (Customer dataCust in daftarCustomer)
            {
                if (dataCust.kode == kode) {
                    found = true;
                    indexHapus = i;
                }
                i++;
            }

            if (found)
            {
                daftarCustomer.RemoveAt(indexHapus);
                Console.WriteLine("Data Customer Berhasil Dihapus");
            }
            else {
                Console.WriteLine("Kode Customer Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("--DATA CUSTOMER--");

            int i = 1;
            foreach (Customer dataCust in daftarCustomer) {
                Console.WriteLine("{0}. {1}, {2}, {3}", i, dataCust.kode, dataCust.nama, dataCust.piutang);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
