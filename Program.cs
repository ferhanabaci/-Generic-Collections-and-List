using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class  bu namespace altında gelmesi bize kolaylık saglıyor
            // System.Collections.Generic
            // T bu t nesne türündedir. listenin içerindeki ki tipi belirtiyor

            List<int> sayilistesi = new List<int>();

            sayilistesi.Add(23);
            sayilistesi.Add (10);
            sayilistesi.Add(4);
            sayilistesi.Add(5);
            sayilistesi.Add(92);
            sayilistesi.Add(34);
            
            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // listeler içerisinde kaç tabne eleman var ?
            //Count
            Console.WriteLine(renkListesi.Count);// bu listede kaç tane eleman var onu getirir.
            Console.WriteLine(sayilistesi.Count);
            // foreach dongüsünde collectionların elemanları üzerinde işlemler yapmak için kullanırız
            //Foreach ve list.ForEach ile elemanlara erişim 
            foreach( var sayi in sayilistesi){
                Console.WriteLine(sayi);
               }
            foreach(var renk in renkListesi){
                    Console.WriteLine(renk);
                }

            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));// sayi üzerindeki her bir elemanı ekrana yazdırabilirim 
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

             // Listenen eleman cıkarma 
             sayilistesi.Remove(4);
             renkListesi.Remove("yesil");
             // elemana göre degil de indexe göre cıkarmak istiyorsak?
             sayilistesi.RemoveAt(0);
             renkListesi.RemoveAt(1);

            //liste icerisinde arama
            if(sayilistesi.Contains(10)){
                Console.WriteLine("10 liste icerisinde bulundu!");
                
            }

            // Eleman ile indexe erişme 
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            // Diziyi Listeye Cevirme 
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanlarListesi.Clear();
            //peki ben class tipinde bir nesne atamak istiyorsam listeye
            //List icerisinde nesne tutmak
            // simdi classımı tutan elemanlarını bir liste  yapıyoruz
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            // kulanıcı atayabilimem icin kullanıclar ınıfın nesnelerine ihtiyacım var 
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim= "Abacı";
            kullanıcı1.Yas= 62;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();

            kullanıcı2.Isim = "Ferhan";
            kullanıcı2.Soyisim= "Abacı";
            kullanıcı2.Yas= 25;

            // olusturugumuz kullanıcı nesnelerini atıcaz 
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            // pekki listeye kullanıcı atama işlemini baska nasıl yaparım ? 
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim="Arda",
                Yas =24

            });
            // kullanıcılar sınıfın elemanına nasıl erişim saglıcam ? foreach
            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soya"+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Yas);
            }
            //yukardaki listeyi temizlemek istiyorum 
            yeniListe.Clear();







        }
        public class Kullanıcılar{
             private string isim;
            private string soyisim;

           private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }

            // bu sekilde bir yapıda get i kapatabilirim yada o bana get i nesne cagırırken ismi degistirebilirim oyle bir konytrol saglıyor bize 

        }
    }
}
