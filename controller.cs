public class Sayilarlaerdogancontroller : Controller
    {
        dbase veritabanim = new dbase();

        // GET: Sayilarlaerdogancontroller
        public ActionResult Index()
        {
            List<Personel> personellistesi = veritabanim.Personel.ToList();

            ViewBag.Personellerim = personellistesi;


            List<AkademikP> akademikplist = veritabanim.AkademikP.ToList();

            //ViewBag.uzman=veritabanim.AkademikP.

            ViewBag.Akademiklerim = akademikplist;

            List<Ogrenciler> ogrencilist = veritabanim.Ogrenciler.ToList();

            ViewBag.Ogrencilerim = ogrencilist;

            List<OnlisansOgrenciSayisi> onlisansogrencilist = veritabanim.OnlisansOgrenciSayisi.ToList();

            ViewBag.OnlisansOgrenciSayilarim = onlisansogrencilist;

            List<LisanOgrenciSayisi> lisanOgrenciSayisis = veritabanim.LisanOgrenciSayisi.ToList();

            ViewBag.LisansOgrenciSayilarim = lisanOgrenciSayisis;

            List<LisansUstuSayisi> lisanustuogrenciSayisi = veritabanim.LisansUstuSayisi.ToList();

            ViewBag.LisansUstuOgrenciSayilarim = lisanustuogrenciSayisi;

            List<Fizikselimkanlar> fizikselimkanlars = veritabanim.Fizikselimkanlar.ToList();

            ViewBag.Fizikselİmkanlarinin = fizikselimkanlars;

            List<Burslar> bursimkani = veritabanim.Burslar.ToList();      

            ViewBag.bursimkanlarierdogan = bursimkani;

            List<BilimselArastirma> bilimselArastirma = veritabanim.BilimselArastirma.ToList();

            ViewBag.bilimselarastirmalar = bilimselArastirma;

            List<Kutuphane> kutuphaneVerileri = veritabanim.Kutuphane.ToList();

            ViewBag.kutuphaneverilerierdogan= kutuphaneVerileri;

            List<ProgramSayisiVeDagilimlari> programSayisiVeDagilimlaris = veritabanim.ProgramSayisiVeDagilimlari.ToList();

            ViewBag.programverileri = programSayisiVeDagilimlaris;
            //erdaldanis.com
            return View();
        }
        public string Listele()
        {
            string result = " " ;
            List < Personel > sd = veritabanim.Personel.ToList();
            foreach(Personel sayilar in sd)
            {
                result += sayilar.ToplamPersonelSayisi;
            }

            return result;
        }
