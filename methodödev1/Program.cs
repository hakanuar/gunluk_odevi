namespace methodödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sonsoz bir döngü içerisinde kullanıcıya "0" girene kadar sayı sorduralım   
            //kullanıcının girdiği her bir sayıyı bir list<int> tipinde listeye add yapalım
            //sonra programımızda bir method yazalım ve adına "toplam" ismini verelim bu methodumuz dışarıdan parametre
            //olarak"list<int>tipinde bir liste alsın ve amacı bu listenin içerisindeki tüm sayıların toplamı
            //int olarak geriye döndürmek olsun 
            //bu method kullanıcı 0 girdiğinde sonsuz döngüden çıktığında çalışşın
            //bit method daha yazalım bunun da adı teksayılarıgetir olsun geriye bir list<int> döndürsün ve
            //parametre olarak da yine list<int>alsın


            List<int> list = new List<int>();
            int sayi = 0;
            do 
            {
                Console.WriteLine("lütfen bir sayı giriniz");
                sayi=Convert.ToInt32(Console.ReadLine());

                list.Add(sayi);

            } while (sayi!=0);
            Console.WriteLine("girilen sayıların toplamı  : " +Toplam(list) );


            static int Toplam(List<int> liste)
            {
                int toplam = 0;
                foreach (int i in liste)
                {
                    toplam += i;
                }
                return toplam;
            }
            
            
                 

           
        }
    }
}