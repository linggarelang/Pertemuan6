using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Pegawai pegawai1 = new Pegawai(4849, "Linggar Elang Pratama", "Direktur", "081297901664");
            Console.WriteLine(pegawai1.ID + "\n" + pegawai1.Nama + "\n" + pegawai1.Jabatan + "\n" + pegawai1.Nohp + "\n");

            Pegawai pegawai2 = new Pegawai();
            pegawai2.setPegawai(4849, "Linggar Elang Pratama", "081297901664");
            pegawai2.setJabatan("HRD");
            Console.WriteLine(pegawai2);

        }
    }
}