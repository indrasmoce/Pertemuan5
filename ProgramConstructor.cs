
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
  public class Mahasiswa
    {
        public Mahasiswa()
        { }
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }
        public string Nim { get; set; }
        public string Nama { get; set; }
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            CetakHasil(mhs1);
            Console.WriteLine();

            Mahasiswa mhs2 = new Mahasiswa("12345", "Paijo");
            CetakHasil(mhs2);
            Console.ReadKey();
        }
        static void CetakHasil(Mahasiswa mhs)
        {
            Console.WriteLine("Nim : {0}", mhs.Nim);
            Console.WriteLine("Nama : {0}",mhs.Nama);
        }
    }
}
