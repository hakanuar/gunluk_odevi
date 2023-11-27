using System.Security;

namespace backend_ödev1
{
    internal class Program
    {
        static void Main(string[] args) 
            
        {
            while (true)
            {


                Console.WriteLine("1.Yeni Kayıt Ekle");
                Console.WriteLine("2.Kayıtları listele");
                Console.WriteLine("3.Tüm Kayıtları Sil");
                Console.WriteLine("4.Çıkış Yap");
                string islem = Console.ReadLine();
                Console.Clear();
                string islem2 = Console.ReadLine();
                if (islem == "1")
                {

                    Console.Write("Öğrenci Adını Giriniz  :  ");
                    Console.ReadLine();
                    Console.Write("Öğrenci Soyadını Giriniz  :  ");
                    Console.ReadLine();
                    Console.Write("Öğrenci Nunamarasını Giriniz  :  ");
                    Console.ReadLine();
                    DateTime zaman = DateTime.Now;
                    Console.WriteLine("Kayıt İşlemi Başarılı      ");
                    Console.WriteLine("Kayıt Tarihi : " + (zaman));
                    Console.WriteLine("Günlük Kalan kayıt hakkı :  0");
                    Console.WriteLine("Ana Menüye Dönüş Yapılıyor ...");
                    Console.ReadLine();

                }

                else if (islem == "2")
                {
                    Console.WriteLine("Kayıtlar Listeleniyor...... ");
                }
                else if (islem == "4")
                {
                    Console.WriteLine("Çıkış Yapılıyor.......");
                    break;
                }

                else if (islem == "3")
                {

                    Console.WriteLine("Silme İşlemini Onaylıyor musunuz? : (8)EVET (9)HAYIR : ");
                    islem2 = Console.ReadLine();
                    DateTime zaman1 = DateTime.Now;
                    if (islem2 == "8")
                    {
                        Console.WriteLine(zaman1 + ":Tarihinde Kayıt Silindi");
                        Console.ReadLine();
                    }
                    if (islem2 == "9")
                    {
                        Console.WriteLine("ANA MENÜYE DÖNÜŞ YAPILIYOR");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız...");
                    }



                }
                else Console.WriteLine("Hatalı Tuşlama Yaptınız.....");


            }   

            
        }
    }
}