using System;

namespace dzshka
{
    interface I_White_checker
    {
        void White_checker_moves();
    }

    interface I_Black_checker
    {
        void Black_checker_moves();
    }

    class C_Field
    {
        public C_Field()
        {
            black_checker_position = 20;
            white_checker_position = 1;

        }
        public C_Field(int black_checker_position_, int white_checker_position_)
        {
            black_checker_position = black_checker_position_;
            white_checker_position = white_checker_position_;
        }

        public void bc_set_pos(int black_checker_position_)
        {
            black_checker_position = black_checker_position_;
        }

        public void wc_set_pos(int white_checker_position_)
        {
            white_checker_position = white_checker_position_;
        }

        public int bc_get_pos()
        {
            return black_checker_position;
        }

        public int wc_get_pos()
        {
            return white_checker_position;
        }

        public int white_checker_position;
        public int black_checker_position;
    }

    class C_Figure : I_White_checker, I_Black_checker
    {
        public C_Figure()
        {
            black_checker = 0;
            white_checker = 0;
        }
        public C_Figure(int black_checker_, int white_checker_)
        {
            black_checker = black_checker_;
            white_checker = white_checker_;
        }

        C_Field pole1 = new C_Field();

        void I_Black_checker.Black_checker_moves()
        {
            if ((pole1.bc_get_pos() - 2) < pole1.wc_get_pos())
            {
                Console.WriteLine("Белый выиграл!");
                Environment.Exit(0);
            }
            else
            {
                pole1.bc_set_pos(pole1.bc_get_pos() - 2); // 8 6 4 2
                pole1.wc_set_pos(pole1.wc_get_pos() + 2); // 3 5 7 9
                Console.Write("Походил чёрной пешкой! - ");
                Console.WriteLine(pole1.bc_get_pos());
            }
        }

        void I_White_checker.White_checker_moves()
        {
            if ((pole1.wc_get_pos() + 2) > pole1.bc_get_pos())
            {
                Console.WriteLine("Чёрный выиграл!");
                Environment.Exit(0);
            }
            else
            {
                pole1.wc_set_pos(pole1.wc_get_pos() + 2); // 3 5 7 9
                pole1.bc_set_pos(pole1.bc_get_pos() - 2); // 8 6 4 2
                Console.Write("Походил белой пешкой! - ");
                Console.WriteLine(pole1.wc_get_pos());
            }
        }

        public int black_checker;
        public int white_checker;
    }

    class Program
    {
        static void Main(string[] args)
        {
            I_White_checker belaya_peshka1 = new C_Figure();
            I_Black_checker chernaya_peshka1 = new C_Figure();

            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
            chernaya_peshka1.Black_checker_moves();
            belaya_peshka1.White_checker_moves();
        }
    }
}