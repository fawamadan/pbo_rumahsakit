using System;
using System.Collections.Generic;
using System.Text;

namespace rugas_rumahsakit
{
    public class rumahsakit
    {
        private List<orang> daftarorang = new List<orang>();

        public void tambahorang(orang orang)
        {
            daftarorang.Add(orang);
            Console.WriteLine("nama berhasil ditambahkan");
        }
        public void tampilorang()
        {
            Console.WriteLine("\n----------daftar nama--------");
            foreach (var orang in daftarorang)
            {
                orang.infoorang();
                orang.aktivitas();
            }
        }
    }
}
