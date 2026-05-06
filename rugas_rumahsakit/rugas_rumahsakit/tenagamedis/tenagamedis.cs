using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    public class tenagamedis : orang
    {
        public string spesialis { get; set; }

        public tenagamedis(string nama, int umur, string spesialis) : base(nama,umur)
        {
            this.spesialis = spesialis;
        }

        public void cekspesialis()
        {
            Console.WriteLine($"tenaga medis {nama}, spesialisasi {spesialis}");
        }
        public override void aktivitas()
        {
            Console.WriteLine($"tenaga medis {nama} sedang makan");
        }
    }
}
