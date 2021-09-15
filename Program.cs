using System;

namespace dzshka
{
    interface I_Dvizheniye_beloy_peshki
    {
        void Move()
        {
            C_Pole pole;
            pole.setPosX(pole.getPosX() - 1);
            Console.WriteLine("Походил белой пешкой!");
            Console.WriteLine(pole.getPosX());
        }
    }

    interface I_Dvizheniye_chernoy_peshki
    {
        void Move()
        {
            C_Pole pole;
            pole.setPosY(pole.getPosY() + 1);
            Console.WriteLine("Походил чёрной пешкой!");
            Console.WriteLine(pole.getPosY());
        }
    }

    class C_Pole
    {
        public C_Pole()
        {
            x = 10;
            y = 10;
        }
        public C_Pole(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void show()
        {
            Console.Write(x + " : " + y);
        }

        public void setPosX(int _x)
        {
            x = _x;
        }
        public void setPosY(int _y)
        {
            x = _y;
        }

        public int getPosY()
        {
            return y;
        }

        public int getPosX()
        {
            return x;
        }
        public int x;
        public int y;
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
        public int chornaya_peshka;
        public int belaya_peshka;
    }

    /*class C_Igra
    {
        public C_Igra()
        {

        }
        public void show()
        {
            Console.Write(" ");
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            I_Dvizheniye_beloy_peshki belaya_peshka_1 = new C_Figura();
            I_Dvizheniye_chernoy_peshki chernaya_peshka_1 = new C_Figura();

            belaya_peshka_1.Move();
            chernaya_peshka_1.Move();
        }
    }
}