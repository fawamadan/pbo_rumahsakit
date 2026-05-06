using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    internal class perawat : tenagamedis
    {
        public perawat(string nama, int umur, string spesialis) : base(nama, umur, spesialis)
        { }

        public void cekpasien()
        {
            Console.WriteLine($"perawat {nama} sedang memeriksa pasien");
        }

        public override void aktivitas()
        {
            Console.WriteLine($"perawat {nama} sedang makan");
        }
    }
}