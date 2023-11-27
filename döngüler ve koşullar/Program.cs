//namespace döngüler_ve_koşullar
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("KAÇ ELEMANLI BİR DİZİ OLUŞSUN İSTERDİNİZ ?");
//            int diziUzunluğu = Convert.ToInt32 (Console.ReadLine());
//            //int diziUzunlugu2=int.parse(Console.Readline());
//            int[] rastgeleSayilar = new int[diziUzunluğu];

//            var rnd = new Random();
//            int bulunanRastgeleSayi= rnd.Next(1, 100);
//            //rnd.shuffle(rastgeleSayilar);
//            int enBuyukSayi = 0;

//            for (int i = 0; i < diziUzunluğu; i++)
//            {
//                rastgeleSayilar[i] = rnd.Next(1000, 9999);
//                if (rastgeleSayilar[i] > enBuyukSayi[i]);
//                enBuyukSayi = rastgeleSayilar[i];

//                Console.WriteLine("en büyük sayı :" + enBuyukSayi);

//              Console.WriteLine ("Bir sayı giriniz  : ");
//              int sayi =Convert.ToInt32(Console.ReadLine());  
//               for (int i = 1; i <= sayi; i++)

//          {
//           for (int j = 1; j <= sayi; j++)  
//           Console.Write("*");
//Console.WriteLine();


//}
//Console.WriteLine("Bir sayı giriniz");
//int adet = Convert.ToInt32(Console.ReadLine()); 
//int[] rastgeleSayılar = new int[adet];
//int[] çiftsayılar = new int[adet];
//int[]  teksayılar = new int[adet];
//Random rnd = new Random();
//for (int i = 0; i < adet; i++)
//{
//    rastgeleSayılar[i] = rnd.Next(1, 100);
//}

//for (int i = 0; i < adet; i++)
//{
//    if (rastgeleSayılar[i] % 2 == 0)
//    {
//        çiftsayılar[i] = rastgeleSayılar[i];

//    }
//    else
//    {
//        teksayılar[i] = rastgeleSayılar[i];
//    }

//}
//Console.WriteLine("çiftsayılar : ");
//for (int i = 0;i < adet; i++) {
//    if (çiftsayılar[i]!=0)
//        Console.Write(çiftsayılar[i] +   )

Console.WriteLine("bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
for (int satir = 1; satir <= sayi; kolon++)
{
    if (satir == 1 || satir == sayi || kolon == || kolon == sayi satir==kolon )
        Console.Write("*");
    else
        Console.Write(" ");

}
Console.WriteLine();
