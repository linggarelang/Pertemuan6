using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Pegawai
    {
        // Field
        private int id;
        private string nama, jabatan, nohp;

        // Property
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Nama
        {
            get
            {
                return this.nama;
            }
            set
            {
                this.nama = value;
            }
        }
        public string Jabatan
        {
            get
            {
                return this.jabatan;
            }
            set
            {
                this.jabatan = value;
            }
        }
        public string Nohp
        {
            get
            {
                return this.nohp;
            }
            set
            {
                this.nohp = value;
            }
        }

        // Constructor
        public Pegawai(int id, string nama, string jabatan, string nohp)
        {
            this.ID = id;
            this.Nama = nama;
            this.Jabatan = jabatan;
            this.Nohp = nohp;
        }

        public Pegawai()
        {

        }


        // Method
        public void setPegawai(int id, string nama, string nohp)
        {
            this.id = id;
            this.nama = nama;
            this.nohp = nohp;

            Console.WriteLine("ID      : {0}", this.id);
            Console.WriteLine("Nama    : {0}", this.nama);
            Console.WriteLine("No HP   : {0}", this.nohp);
        }

        public void setJabatan(string jabatan)
        {
            this.jabatan = jabatan;

            Console.WriteLine("Jabatan : {0}", this.jabatan);
        }
    }
}