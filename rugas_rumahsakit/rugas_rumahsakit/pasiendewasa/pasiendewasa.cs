using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
   public class pasiendewasa : pasien
    {
        public pasiendewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {
        }

        public void konsultasi()
        {
            Console.WriteLine($"pasien dewasa {nama} dengan keluhan {keluhan} sedang konsultasi");
        }

        public override void aktivitas()
        {
            Console.WriteLine($"pasien dewasa {nama} sedang makan setelah konsultasi ");
        }
    }
}
