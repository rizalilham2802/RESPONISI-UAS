using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

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
                        TambahMahasiswa();
                        string jenis;
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
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
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar\n");
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Write("NIM :");
            mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama :");
            mahasiswa.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P] :");
            string jenis = Console.ReadLine();
            mahasiswa.Kelamin = (jenis == "L"  || jenis == "P" )? "Laki-Laki" : "Perempuan";
            Console.Write("IPK :");
            mahasiswa.IPK = Console.ReadLine();
            daftarMahasiswa.Add(mahasiswa);

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            int dat = -1, hapus = -1;
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM :");
            string nim = Console.ReadLine();
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                dat++;
                if (mahasiswa.NIM == nim) ;
                {
                    hapus = dat;
                }
            }
            if (hapus != -1)
            {
                daftarMahasiswa.RemoveAt(hapus);
                Console.WriteLine("Data mahasiswa berhasil di hapus");
            }
            else
            {
                Console.WriteLine("NIM tidak di temukan");
                Console.ReadKey();
            }
            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {

            Console.Clear();
            int noNim = 0;
            Console.WriteLine("Data Mahasiswa");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                noNim++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noNim, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.Kelamin, mahasiswa.IPK);
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
