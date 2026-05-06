using System;
using System.Net.Http.Headers;
using rugas_rumahsakit;

rumahsakit umc = new rumahsakit();

dokter dr1 = new dokter("gibran", 25, "umum");
perawat pwt1 = new perawat("aiken", 23, "perawat klinis");
pasienanak pa1 = new pasienanak("dion", 9, "pilek");
pasiendewasa pd1 = new pasiendewasa("joko", 60, "TBC");
pasien p = new pasien("budi", 17, "batuk");
tenagamedis tm1 = new tenagamedis("surya", 30, "bedah");

umc.tambahorang(dr1);
umc.tambahorang(pwt1);
umc.tambahorang(pa1);
umc.tambahorang(pd1);

umc.tampilorang();

dr1.aktivitas();
pwt1.aktivitas();
pa1.aktivitas();
pd1.aktivitas();
p.aktivitas();
tm1.aktivitas();

dr1.diagnosa();
pwt1.cekpasien();
pa1.menangis();
pd1.konsultasi();
p.cekkeluhan();
tm1.cekspesialis();
