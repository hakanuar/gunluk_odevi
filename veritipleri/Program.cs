using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace veritipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dizi;
            Console.Write("lütfen bir sayı giriniz:");
            dizi = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[dizi];
            int enbuyuk = array[0];

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[1] = rnd.Next(1000, 9999);
                if (array[i] > enbuyuk)
                {
                    enbuyuk = array[i];
                }
            }
            foreach (int element in array)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("en büyük sayınız : {0}", enbuyuk);
            Console.ReadKey();
            //    int sayi1 = 5;
        }
    }
}
//    int sayi2 = 6;

//sayi1  =  sayi1 + 5;

//sayi1 += 5;



//string metin = "merhaba dünya";


//string ad = " mehmet";


//string soyad = "kaya";
//string adsoyad =ad + soyad;

////Console.WriteLine(" merhaba   :ad+ " " + soyad);
////CONCAT-ENATION
//Console.WriteLine($"merhaba {ad} {soyad}");


//kullancıya adını ve soyadını ayrı ayrı soralım ve ardından ekrana " Hoşgeldin Ad Soyad" formatıyla yazdıralım
//  Console.WriteLine("adınızı giriniz  :  ");
// string ad = Console.ReadLine();
// Console.WriteLine("soyadınızı giriniz  :  ");
// string soyad = Console.ReadLine();
// Console.WriteLine($"hoşgeldin{ad} {soyad} ");

//Console.WriteLine ($"Adınız soyadınız toplam {ad.Length + soyad.Length}arakter uzunluğundadı=;
// bool x = 1 == 1;
//Console.WriteLine(x);
//Console.WriteLine ("doğum yılınızı giriniz :  ");
//int yıl;int.Parse(Console.ReadLine ());
//int bugununyili  =    DateTime.Now.Day ToString;
//Console.WriteLine($"YAŞINIZ bugununyili-yil)");

//Console.WriteLine("doğum yılınızı giriniz   :  ");
//int yıl=int.Parse(Console.ReadLine());
//Console.WriteLine("Doğum ayınızı giriniz   :   ");
//int ay = int.Parse(Console.ReadLine());
//Console.WriteLine("doğum gününüzü giriniz    :   ");
//int gun = int.Parse(Console.ReadLine());
//DateTime doğumtarihi =new  DateTime(yıl, ay, gun) ;
//TimeSpan fark = DateTime.Now - doğumtarihi;
//Console.WriteLine($"fark.Days) gün geçmiş");
//Console.WriteLine($"gerçek yaşınız{fark.Days*1.0  / 365}");

//string meyveler = "elma , armut,kiraz,çilek";
//string[] meyveDizisi = new string[4];
//meyveDizisi[0] = "elma";
//meyveDizisi[1] = "armut";
//meyveDizisi[2] = "kiraz";
//meyveDizisi[3] = "çilek";
//string[] yeniMeyveDizisi = { "elma", "armut", "kiraz", "çilek" };

//char karakter = (char)97;  //küçük a            
//char büyükkarakter = (char)65; //büyük A
//Console.WriteLine("Bir yazı giriniz  : ");
//string metin = Console.ReadLine();
//char[] chars = metin.ToCharArray();


//int sayac = 0;  
//foreach (char karakter in chars)
//{




//    byte asciiKodu = (byte)karakter;
//    asciiKodu -= 32;
//    chars[sayac] = (char)asciiKodu;
//    sayac++;
//sayac=sayac+1;
//sayac+=1;

//}




//for (int sayac = 0; sayac <  chars.Length; sayac++)
//{
//    byte asciiKodu = (byte)chars[sayac];
//    asciiKodu -= 32;
//    chars[sayac] = (char) asciiKodu;


//}


//int sayac = 0;
//while(sayac < args.Length) {

//    byte asciikodu = (byte)chars[sayac];
//    asciikodu -= 32;
//    chars[sayac] = (char)asciikodu;
//    sayac++;



//{
//    int a = 5;
//    int b= 6;

//    if (a < b)
//        //true ise bu kısmı çalıştır
//        Console.WriteLine("a küçüktür b den");



//kullanıcıdan 2 tane sayı alalım hangisi büyükse ;büyük olan sayıyı ekrana yazalım.

//       int sayi1 = 0;
//       int sayi2 = 0;
//       int sayi3 = 0;
//       int enBuyukSayi = 0; 
//       {


//           Console.WriteLine("birinci Sayıyı giriniz: ");
//           int sayi1 = int.Parse(Console.ReadLine());
//           enBuyukSayi = sayi1; ;

//           Console.WriteLine("ikinci sayıyı giriniz : ");
//           int sayı2 = int.Parse(Console.ReadLine());
//           if (sayi2 > enBuyukSayi)
//           {
//               enBuyukSayi = sayi2;
//           }



//           Console.WriteLine("üçüncü sayıyı giriniz   : ");
//           int sayı3 = int.Parse(Console.ReadLine());








//           }



//   }



//   byte[] sayi1 = { 3 };
//   byte []sayi2 = { 6 };
//   byte[] sayi3 = { 7 };
//   byte []sayi4 = { 8 };
//   Console.WriteLine(byte sayi1 );

//Console.readline();




