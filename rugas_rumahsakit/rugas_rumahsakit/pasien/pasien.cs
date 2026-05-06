using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    public class pasien : orang
    {
        public string keluhan {  get; set; }

        public pasien(string nama, int umur, string keluhan) : base(nama, umur)
        { 
            this.keluhan = keluhan; 
        }

        public void cekkeluhan()
        {
            Console.WriteLine($"nama : {nama}, keluhan : {keluhan}");
        }
        public override void aktivitas()
        {
            Console.WriteLine($"pasien {nama} sedang makan");
        }
    }
}
