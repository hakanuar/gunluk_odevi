namespace method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string>list = new List<string>();
            list.Add("Ahmet");
            list.Add("MEHMET");
            list.Add("Alper");
            list <string> filtrelemeisList= AilebaslayanlariGetir(list);
            foreach(string str in filtrelemeisList)
            {
                Console.WriteLine(str);
            }

        }
        static List<string>AilebaslayanlariGetir(List<string> liste)
        {
            if(liste == null && liste.Count!=0)
            {
               return liste.Where(s=>s.StartsWith("A")).ToList();
            }
            else
            {
                Console.WriteLine("boş bir liste gönderdiniz");
                return new List<string>();
            }

        }
    }
}