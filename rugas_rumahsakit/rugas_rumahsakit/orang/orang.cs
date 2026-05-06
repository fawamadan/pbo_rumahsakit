using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    public class orang
    {
        public string nama { get; set; }
        public int umur { get; set; }

        public orang(string nama, int umur)
            { this.nama = nama; this.umur = umur; }

        public virtual void aktivitas()
        {
            Console.WriteLine($"{nama} sedang berobat");
        }
        public virtual void infoorang()
        {
            Console.WriteLine($"nama : {nama}, umur :{umur}");
        }
    }
}
