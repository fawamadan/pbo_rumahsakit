using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    public class dokter : tenagamedis
    {
        public dokter(string nama, int umur, string spesialis) : base(nama, umur,spesialis)
        { }

        public void diagnosa()
        {
            Console.WriteLine($"dr.{nama} spesialis {spesialis} sedang memeriksa pasien");
        }

        public override void aktivitas()
        {
            Console.WriteLine($"dr.{nama} sedang makan");
        }

        public override void infoorang()
        {
            Console.WriteLine($"nama : {nama}, umur : {umur}, spesialis : {spesialis}");
        }
    }
}
