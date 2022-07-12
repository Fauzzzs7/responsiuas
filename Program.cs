using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();

            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");

            

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Penjualan penjual = new Penjualan();
            Console.Write("Nota: ");
            penjual.Nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            penjual.Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            penjual.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K] ");
            penjual.Jenis = Console.ReadLine();
            Console.Write("Total Nota: ");
            penjual.Total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            int no = 0;
            Console.WriteLine("Data Penjualan");
            foreach (Penjualan penjual in daftarPenjualan)
            {
                no++;
                string jenis;
                if (penjual.Jenis == "T")
                {
                    jenis = "Tunai";
                }
                else if (penjual.Jenis == "K")
                {
                    jenis = "Kredit";
                }
                else
                {
                    jenis = "Jenis tidak diketahui";
                }
                Console.WriteLine(no + ". " + penjual.Nota + ", " + penjual.Tanggal + ", " + penjual.Customer + ", " + jenis + ", " + penjual.Total);
            }
            if (no < 1)
            {
                Console.WriteLine("Data Penjualan Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
