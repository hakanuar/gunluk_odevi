namespace siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "hakan";
            ogrenci.Soyad = "uçar";
            ogrenci.OgrenciNo = 500;
            ogrenci.Dogumtarihi = new DateTime(2003, 9, 20);
            Console.WriteLine(ogrenci.Ad);

        }
    }
    internal class Ogrenci
    {
        public  int OgrenciNo {  get; set; }

       public string Ad { get; set; }
        public string Soyad { get; set; }  
      public   DateTime Dogumtarihi { get; set; }

}