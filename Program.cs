using System;

namespace dzshka
{
    interface I_Dvizheniye_beloy_peshki
    {
        void Move_belaya_peshka();
    }

    interface I_Dvizheniye_chernoy_peshki
    {
        void Move_chornaya_peshka();
    }

    class C_Pole
    {
        public C_Pole()
        {
            x_chornaya_peshka = 10;
            x_belaya_peshka = 10;

        }
        public C_Pole(int _x_chornaya_peshka, int _x_belaya_peshka)
        {
            x_chornaya_peshka = _x_chornaya_peshka;
            x_belaya_peshka = _x_belaya_peshka;
        }
        public void show()
        {
            Console.Write(x_chornaya_peshka);
            Console.Write(x_belaya_peshka);
        }

        public void setPosX_chornaya_peshka(int _x_chornaya_peshka)
        {
            x_chornaya_peshka = _x_chornaya_peshka;
        }

        public void setPosX_belaya_peshka(int _x_belaya_peshka)
        {
            x_belaya_peshka = _x_belaya_peshka;
        }

        public int getPosX_chornaya_peshka()
        {
            return x_chornaya_peshka;
        }

        public int getPosX_belaya_peshka()
        {
            return x_belaya_peshka;
        }

        public int x_belaya_peshka;
        public int x_chornaya_peshka;
    }

    class C_Figura : I_Dvizheniye_beloy_peshki, I_Dvizheniye_chernoy_peshki
    {
        public C_Figura()
        {
            chornaya_peshka = 0;
            belaya_peshka = 0;
        }
        public C_Figura(int _chornaya_peshka, int _belaya_peshka)
        {
            chornaya_peshka = _chornaya_peshka;
            belaya_peshka = _belaya_peshka;
        }
        /*public void show()
        {
            Console.Write(" ");
        }*/

        C_Pole pole = new C_Pole();

        void I_Dvizheniye_beloy_peshki.Move_belaya_peshka()
        {
            pole.setPosX_chornaya_peshka(pole.getPosX_chornaya_peshka() - 2);
            Console.WriteLine("Походил чёрной пешкой!");
            Console.WriteLine(pole.getPosX_chornaya_peshka());
        }

        public void Move_chornaya_peshka()
        {
            pole.setPosX_belaya_peshka(pole.getPosX_belaya_peshka() - 2);
            Console.WriteLine("Походил белой пешкой!");
            Console.WriteLine(pole.getPosX_belaya_peshka());
        }

        public int chornaya_peshka;
        public int belaya_peshka;
    }

    class Program
    {
        static void Main(string[] args)
        {
            C_Figura figura1 = new C_Figura();
            I_Dvizheniye_beloy_peshki belaya_peshka_1 = new C_Figura();
            I_Dvizheniye_chernoy_peshki chernaya_peshka_1 = new C_Figura();

            belaya_peshka_1.Move_belaya_peshka();
            chernaya_peshka_1.Move_chornaya_peshka();

        }
    }
}