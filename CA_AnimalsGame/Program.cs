using CA_AnimalsGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AnimalsGame
{

    class Program
    {

        /*
        Hayvanat Bahçesi Projesi
        500'e 500'lük bir alanda yaşayan 30 koyun (15 erkek,15 dişi), 10 inek (5 erkek,5 dişi), 10 tavuk,
        10 kurt (5 dişi,5 erkek) 10 horoz, 8 aslan (4 erkek, 4 dişi) ve 1 avcı bulunmaktadır.
        Hayvanlardan; 
        koyun 2 birim,
        kurt 3 birim,
        inek 2 birim,
        tavuk 1 birim,
        horoz 1 birim,
        aslan 4 birim,
        avcı 1 birim rasgele şekilde hareket etmektedir ancak alanın dışına çıkamamaktadır.
        -----------------------------------------------------------------------------------------------
        kurt kendisine 4 birim yakınındaki koyun ,tavuk ,horoz'u avlayabiliyor. 
        aslan kendisine 5 birim yakınlıktaki inek, koyun'u avlayabiliyor.
        avcıda kendisine 8 birim yakınlıktaki hayvanlardan herhangi birisini avlayabiliyor.
        aynı cins farklı cinsiyetteki hayvanlar birbirine 3 birim yakınlaştığı zaman random cinsiyetli ve aynı cins  
        bir hayvan meydana gelmektedir.
        1000 birim hareket sonunda hayvanların sayısının bulunduğu bir console application yazılması 
        beklenmektedir.
        */

        //Pointer

       

        static void Main(string[] args)
        {
            Arazi arazi = new Arazi();
            Random rnd = new Random();
            Hayvan hayvan = new Hayvan();
            Avci avci = new Avci();
            Koyun koyun = new Koyun();
            Aslan aslan = new Aslan();

            List<Koyun> koyunListesi = KoyunOlustur();
            List<Aslan> aslanListesi = AslanOlustur();
            List<Inek> inekListesi = InekOlustur();
            List<Kurt> kurtListesi = KurtOlustur();
            List<Horoz> horozListesi = HorozOlustur();
            List<Tavuk> tavukListesi = TavukOlustur();
            List<Avci> avciListesi = AvciOlustur();
            Console.WriteLine("Hayvanlar Oluşturuldu");
            Console.Read();

            int koyunSayisi = koyunListesi.Count();
            int aslanSayisi = aslanListesi.Count();
            int inekSayisi = inekListesi.Count();
            int kurtSayisi = kurtListesi.Count();
            int horozSayisi = horozListesi.Count();
            int tavukSayisi = tavukListesi.Count();    











        }

        static List<Koyun> KoyunOlustur()
        {
            List<Koyun> koyunListesi = new List<Koyun>();
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                Koyun koyun = new Koyun();
                if (i < 15)
                {
                    koyun.Cinsiyet = Cinsiyet.Dişi;
                    koyun.KonumX = rnd.Next(0, 501);
                    koyun.KonumY = rnd.Next(0, 501);
                    koyun.Birim = 2;
                }
                else
                {
                    koyun.Cinsiyet = Cinsiyet.Erkek;
                    koyun.KonumX = rnd.Next(0, 501);
                    koyun.KonumY = rnd.Next(0, 501);
                    koyun.Birim = 2;
                }
                koyunListesi.Add(koyun);
            }
            return koyunListesi;
        }
        static List<Aslan> AslanOlustur()
        {
            List<Aslan> aslanListesi = new List<Aslan>();
            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                Aslan aslan = new Aslan();
                if (i < 4)
                {
                    aslan.Cinsiyet = Cinsiyet.Dişi;
                    aslan.KonumX = rnd.Next(0, 501);
                    aslan.KonumY = rnd.Next(0, 501);
                    aslan.Birim = 4;
                }
                else
                {
                    aslan.Cinsiyet = Cinsiyet.Erkek;
                    aslan.KonumX = rnd.Next(0, 501);
                    aslan.KonumY = rnd.Next(0, 501);
                    aslan.Birim = 4;
                }
                aslanListesi.Add(aslan);
            }
            return aslanListesi;
        }
        static List<Inek> InekOlustur()
        {
            List<Inek> inekListesi = new List<Inek>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Inek inek = new Inek();
                if (i < 5)
                {
                    inek.Cinsiyet = Cinsiyet.Dişi;
                    inek.KonumX = rnd.Next(0, 501);
                    inek.KonumY = rnd.Next(0, 501);
                    inek.Birim = 2;
                }
                else
                {
                    inek.Cinsiyet = Cinsiyet.Erkek;
                    inek.KonumX = rnd.Next(0, 501);
                    inek.KonumY = rnd.Next(0, 501);
                    inek.Birim = 2;
                }
                inekListesi.Add(inek);
            }
            return inekListesi;
        }
        static List<Kurt> KurtOlustur()
        {
            List<Kurt> kurtListesi = new List<Kurt>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Kurt kurt = new Kurt();

                if (i < 5)
                {
                    kurt.Cinsiyet = Cinsiyet.Dişi;
                    kurt.KonumX = rnd.Next(0, 501);
                    kurt.KonumY = rnd.Next(0, 501);
                    kurt.Birim = 3;
                }
                else
                {
                    kurt.Cinsiyet = Cinsiyet.Erkek;
                    kurt.KonumX = rnd.Next(0, 501);
                    kurt.KonumY = rnd.Next(0, 501);
                    kurt.Birim = 3;
                }

                kurtListesi.Add(kurt);
            }
            return kurtListesi;
        }
        static List<Horoz> HorozOlustur()
        {
            List<Horoz> horozListesi = new List<Horoz>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Horoz horoz = new Horoz();

                horoz.KonumX = rnd.Next(0, 501);
                horoz.KonumY = rnd.Next(0, 501);
                horoz.Birim = 1;
                horozListesi.Add(horoz);
            }

            return horozListesi;
        }
        static List<Tavuk> TavukOlustur()
        {
            List<Tavuk> tavukListesi = new List<Tavuk>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Tavuk tavuk = new Tavuk();

                tavuk.KonumX = rnd.Next(0, 501);
                tavuk.KonumY = rnd.Next(0, 501);
                tavuk.Birim = 1;
                tavukListesi.Add(tavuk);
            }

            return tavukListesi;
        }
        static List<Avci> AvciOlustur()
        {
            List<Avci> avciListesi = new List<Avci>();
            Random rnd = new Random();

            for (int i = 0; i < 1; i++)
            {
                Avci avci = new Avci();
                avci.KonumX = rnd.Next(0, 501);
                avci.KonumY = rnd.Next(0, 501);
                avci.Birim = 1;
                avciListesi.Add(avci);
            }

            return avciListesi;


        }

    }
}
