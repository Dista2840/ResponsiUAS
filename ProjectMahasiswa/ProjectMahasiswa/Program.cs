using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data Mahasiswa\n");
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Write("NIM: ");
            Mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama : ");
            Mahasiswa.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin[L/P]: ");
            Mahasiswa.JenisKelamin = Convert.ToDouble(Console.ReadLine());
            Console.Write("IPK : ");
            Mahasiswa.IPK = Convert.ToDouble(Console.ReadLine());

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM: ");
            string nim = Console.ReadLine();
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                no++;
                if (mahasiswa.NIM == nim)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarMahasiswa.RemoveAt(hapus);
                Console.WriteLine("\nData Mahasiswa Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\n NIM tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();


            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            int noUrut = 0;
            Console.WriteLine("Data Mahasiswa\n");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}, {4:N0}", noUrut, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.IPK);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Mahasiswa Kosong");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

