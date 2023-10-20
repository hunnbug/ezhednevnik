    using ezhednevnik;
namespace ezhednevnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime DayNow = DateTime.Now;
            Console.WriteLine(DayNow);
            Console.WriteLine("Заметки: ");
            Console.WriteLine("-----------------------------");
            int pos = Menu.Strelki();
            zametki zametka = new zametki();
            string desc = zametka.Description;

            DateTime date = new DateTime();
            date = zametki.Date;

            int Showzametki()
            {
                ConsoleKeyInfo key;
                int a = 0;



                return a;
            }

            Show();
            string Show()
            {

                if (pos == 3)
                {
                    desc = "1";
                }
                if (pos == 4)
                {
                    desc = "2";
                }
                if (pos == 5)
                {
                    desc = "3";
                }

                return desc;
            }
            Console.WriteLine(desc);
        }
        
    }
}