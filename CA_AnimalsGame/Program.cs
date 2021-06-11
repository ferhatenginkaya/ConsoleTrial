using CA_AnimalsGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
        bir hayvan meydana gelmektedir. // yapılamadı.
        1000 birim hareket sonunda hayvanların sayısının bulunduğu bir console application yazılması 
        beklenmektedir.
        */
        static void Main(string[] args)

        {
            #region ornekAlma
            Arazi arazi = new Arazi();
            Random rnd = new Random();
            

            #endregion

            #region Listeleme
            List<Koyun> koyunListesi = KoyunOlustur();
            List<Aslan> aslanListesi = AslanOlustur();
            List<Inek> inekListesi = InekOlustur();
            List<Kurt> kurtListesi = KurtOlustur();
            List<Horoz> horozListesi = HorozOlustur();
            List<Tavuk> tavukListesi = TavukOlustur();
            List<Avci> avciListesi = AvciOlustur();
            #endregion

            #region toplam
            int koyunSayisi = koyunListesi.Count();
            int aslanSayisi = aslanListesi.Count();
            int inekSayisi = inekListesi.Count();
            int kurtSayisi = kurtListesi.Count();
            int horozSayisi = horozListesi.Count();
            int tavukSayisi = tavukListesi.Count();
            #endregion

            #region HayvanAraziEkleme
            foreach (var k in koyunListesi)
            {
                arazi.Hayvanlar.Add(k);
            }
            foreach (var a in aslanListesi)
            {
                arazi.Hayvanlar.Add(a);
            }
            foreach (var i in inekListesi)
            {
                arazi.Hayvanlar.Add(i);
            }
            foreach (var ku in kurtListesi)
            {
                arazi.Hayvanlar.Add(ku);
            }
            foreach (var h in horozListesi)
            {
                arazi.Hayvanlar.Add(h);
            }
            foreach (var t in tavukListesi)
            {
                arazi.Hayvanlar.Add(t);
            }
            #endregion


            foreach (var h in arazi.Hayvanlar)
            {
             

                //Avci konum verecek,
                int araziRandomGenislik = rnd.Next(0, arazi.En);
                int araziRandomYukseklik = rnd.Next(0, arazi.Boy);

                Avci avci = new Avci();
                avci.KonumX = araziRandomGenislik;
                avci.KonumY = araziRandomYukseklik;
                Koyun koyun = new Koyun();
                Aslan aslan = new Aslan();
                Kurt kurt = new Kurt();
                Horoz horoz = new Horoz();
                Tavuk tavuk = new Tavuk();
                Inek inek = new Inek();

                //        koyun 2 birim,++
                //kurt 3 birim,+
                //inek 2 birim,
                //tavuk 1 birim,+
                //horoz 1 birim,+
                //aslan 4 birim,+

                //kurt'un bir konumu olmalı (x,y)
                //koyun, tavuk, horoz konum tanımlanmalı (x,y)
                //kurt'ın x değeri koyun'un x'ine eşit ve 


                for (int i = 0; i < 1000; i++)
                {
                    //Kurt Konum verecek,              
                    int kurtKonumGenislik = rnd.Next(0, arazi.En);
                    int kurtKonumYukseklik = rnd.Next(0, arazi.Boy);
                    kurt.KonumX = kurtKonumGenislik;
                    kurt.KonumY = kurtKonumYukseklik;
                    //Koyun konum verecek,                
                    int koyunKonumGenislik = rnd.Next(0, arazi.En);
                    int koyunKonumYukseklik = rnd.Next(0, arazi.Boy);
                    koyun.KonumX = koyunKonumGenislik;
                    koyun.KonumY = koyunKonumYukseklik;
                    //Tavuk konum verecek
                    int tavukKonumGenislik = rnd.Next(0, arazi.En);
                    int tavukKonumYukseklik = rnd.Next(0, arazi.Boy);
                    tavuk.KonumX = tavukKonumGenislik;
                    tavuk.KonumY = tavukKonumYukseklik;
                    //Horoz konum verecek,
                    int horozKonumGenislik = rnd.Next(0, arazi.En);
                    int horozKonumYukseklik = rnd.Next(0, arazi.Boy);
                    horoz.KonumX = horozKonumGenislik;
                    horoz.KonumY = horozKonumYukseklik;
                    //Aslan konum verecek,
                    int aslanKonumGenislik = rnd.Next(0, arazi.En);
                    int aslanKonumYukseklik = rnd.Next(0, arazi.Boy);
                    aslan.KonumX = aslanKonumGenislik;
                    aslan.KonumY = aslanKonumYukseklik;
                    //Inek konum verecek,
                    int inekKonumGenislik = rnd.Next(0, arazi.En);
                    int inekKonumYukseklik = rnd.Next(0, arazi.Boy);
                    inek.KonumX = inekKonumGenislik;
                    inek.KonumY = inekKonumYukseklik;



                    if (kurt.KonumX == koyun.KonumX && koyunSayisi != 0) koyunSayisi--;
                    if (kurt.KonumY == koyun.KonumY && koyunSayisi != 0) koyunSayisi--;
                    if (kurt.KonumX == horoz.KonumX && horozSayisi != 0) horozSayisi--;
                    if (kurt.KonumY == horoz.KonumY && horozSayisi != 0) horozSayisi--;
                    if (kurt.KonumX == tavuk.KonumX && tavukSayisi != 0) tavukSayisi--;
                    if (kurt.KonumY == tavuk.KonumY && tavukSayisi != 0) tavukSayisi--;
                    if (aslan.KonumX == inek.KonumX && inekSayisi != 0) inekSayisi--;
                    if (aslan.KonumY == inek.KonumY && inekSayisi != 0) inekSayisi--;
                    if (aslan.KonumX == koyun.KonumX && koyunSayisi != 0) koyunSayisi--;
                    if (aslan.KonumY == koyun.KonumY && koyunSayisi != 0) koyunSayisi--;
                    if (avci.KonumX == kurt.KonumX && kurtSayisi != 0) kurtSayisi--;
                    if (avci.KonumY == kurt.KonumY && kurtSayisi != 0) kurtSayisi--;
                    if (avci.KonumX == koyun.KonumX && koyunSayisi != 0) koyunSayisi--;
                    if (avci.KonumY == koyun.KonumY && koyunSayisi != 0) koyunSayisi--;
                    if (avci.KonumX == inek.KonumX && inekSayisi != 0) inekSayisi--;
                    if (avci.KonumY == inek.KonumY && inekSayisi != 0) inekSayisi--;
                    if (avci.KonumX == tavuk.KonumX && tavukSayisi != 0) tavukSayisi--;
                    if (avci.KonumY == tavuk.KonumY && tavukSayisi != 0) tavukSayisi--;
                    if (avci.KonumX == horoz.KonumX && horozSayisi != 0) horozSayisi--;
                    if (avci.KonumY == horoz.KonumY && horozSayisi != 0) horozSayisi--;


                    
                    


                }

                Console.WriteLine("Kalan Koyun Sayisi =" + " " + koyunSayisi);
                Console.WriteLine("Kalan Tavuk Sayisi =" + " " + tavukSayisi);
                Console.WriteLine("Kalan Horoz Sayisi =" + " " + horozSayisi);
                Console.WriteLine("Kalan Inek Sayisi =" + " " + inekSayisi);
                Console.WriteLine("Kalan Aslan Sayisi =" + " " + aslanSayisi);
                Console.WriteLine("Kalan Kurt Sayisi =" + " " + kurtSayisi);


                Console.Read();
            }

        }
        #region OlusturmaMetot
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
        #endregion

    }






}

