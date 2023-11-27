namespace collectıons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = "emre";
            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //Console.WriteLine(numbers[0]);

            //List<int[]> ints = new List<int[]>();
            //ints.Add(new int[] { 1, 2, 3, 4 });
            //ints.Add(new int[] { 5, 6, 7, 8 });
            //ints.Add(new int[] { 9, 10, 11, 12 });

            //List<string> ogrenciler = new List<string>();
            //ogrenciler.Add("emre özçelikel");
            //ogrenciler.Add("ahmet çelebi");
            //ogrenciler.Add("turan kaya");

            //foreach (string s in ogrenciler)
            //    Console.WriteLine(s);

            //List<int>sayılar = new List<int>();
            //sayılar.AddRange(new int[] { 9, 4, 1, 5, 18, 21, 0, 2});
            //sayılar.Sort();

            //Console.WriteLine( "adınızı giriniz" );
            //string metin = Console.ReadLine();
            //Console.WriteLine("adınızın ters hali");
            //for (int i = metin.Length - 1; i >= 0; i--)
            //    {
            //    Console.Write(metin[i]);
            //}

           //List<string> names = new List<string>();
           // names.Add("emre");
           // names.Add("ahmet");
           // names.Add("mehmet");
            List<int> list = new List<int>();
            while (true) 
            {

                Console.WriteLine(  "bir sayı giriniz  :  ");
                int sayı =Convert.ToInt32(Console.ReadLine());
                if(sayı==0) 
                {
                    break;

                 }
                list.Add(sayı) ;
                
            }
            Console.WriteLine(  "toplam girilen sayı adedi : " List.Count);
            int toplam = 0;
            foreach(int sayı in list) 
            {
                toplam += sayı;
            }
            Console.WriteLine(  "sayıların toplamı : " +toplam);
            double.ortalama = (double)toplam / List.Count;
            Console.WriteLine("sayıların ortalaması : "+ortalama);
            int enBuyuksayı = 0;
            //en buyuk sayıyı bulalım
            foreach(int i in list)
            {
                if (i > enBuyuksayı)
                    enBuyuksayı = i;

            }
            Console.WriteLine(  "girilen en büyük sayı :  "+enBuyuksayı);
            int enKucuksayı1