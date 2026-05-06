using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    public class pasienanak : pasien
    {
        public pasienanak(string nama, int umur,string keluhan) : base(nama, umur, keluhan)
        {
        }

        public void menangis()
        {
            Console.WriteLine($"pasienanak {nama} dengan keluhan {keluhan} sedang menangid");
        }

        public override void aktivitas()
        {
            Console.WriteLine($"pasienanak {nama} yang menangis karena terharu makan martabak keju coklat, redvelvet nais");
        }
    }
}
