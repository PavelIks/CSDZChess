using System;

namespace dzshka
{
    interface I_Dvizheniye_beloy_peshki
    {
        void Move()
        {
            Console.WriteLine("Походил белой пешкой!");
        }
    }

    class C_Pole
    {
        public C_Pole()
        {

        }
        public void show()
        {
            Console.Write(" ");
        }
    }

    class C_Figura : I_Dvizheniye_beloy_peshki
    {
        public C_Figura()
        {
            chornaya_peshka = 1;
            belaya_peshka = 1;
        }
        public C_Figura(int _chornaya_peshka, int _belaya_peshka)
        {
            chornaya_peshka = _chornaya_peshka;
            belaya_peshka = _belaya_peshka;
        }
        public void show()
        {
            Console.Write(" ");
        }
        public int chornaya_peshka;
        public int belaya_peshka;
    }

    class C_Igra
    {
        public C_Igra()
        {

        }
        public void show()
        {
            Console.Write(" ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи W: ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "W":
                    I_Dvizheniye_beloy_peshki belaya_peshka_1 = new C_Figura();
                    belaya_peshka_1.Move();
                    break;
                default:
                    Console.WriteLine("404");
                    break;
            }
        }
    }
}