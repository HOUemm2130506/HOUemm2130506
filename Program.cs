using System;
// ****************************************************************************
// Koffi Emmanuel HOUNAKEY
// ****************************************************************************
namespace Labo3
{
    class Program
    {
        static void Question1()
        {
            // Début question 1


            // Fin question 1
        }

        static void Question2()
        {
            // Début question 2


            // Fin question 2
        }

        static void Question3()
        {
            // Début question 3
            int nbre, liste;
            nbre = Convert.ToInt32(Console.ReadLine());

            Console.Write("ce chiffre est composede:");

            while (nbre > 0)
            {
                liste = nbre % 10;
                nbre = nbre / 10;
                Console.Write("," + liste);

            }


            // Fin question 3
        }

        static void Question4()
        {
            // Début question 4
            int i, liste;

            Console.WriteLine("Ce programme inverse les nombres entiers");
            Console.WriteLine("Veuillez saisir un entier positif");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("En inversant ce nombre");
            while (i > 0)
            {

                liste = i % 10;
                i = i / 10;


                Console.Write(liste);

                // Fin question 4
            }

        static void Question5()
        {
                // Début question 5
                int nb;
                String trad = "I";
                String diz = "X";
                String quinz = "XV";
                String interm = "XX";
                Console.WriteLine("Bienvenue dans ce programme de traduction");
                nb = Convert.ToInt32(Console.ReadLine());
                if (nb == 1)

                {
                    Console.WriteLine("1" + "=" + "" + "I");
                }
                else
                {
                    if (nb == 5)
                    {
                        Console.WriteLine("5" + "=" + "" + "V");
                    }
                    else
                    {
                        if (nb == 10)
                        {
                            Console.WriteLine("10" + "=" + "" + "X");
                        }
                        else
                        {
                            if (nb == 50)
                            {
                                Console.WriteLine("50" + "=" + "" + "L");
                            }
                            if (nb == 100)
                            {
                                Console.WriteLine("100" + "=" + "" + "C");
                            }
                            if (nb == 500)
                            {
                                Console.WriteLine("500" + "=" + "" + "D");
                            }
                            if (nb == 1000)
                            {
                                Console.WriteLine("1000" + "=" + "" + "M");
                            }
                        }
                    }
                }
                for (nb = 2; nb < 5; nb++)
                {
                    trad += "I";
                    Console.WriteLine(nb + "=" + trad);
                }
                for (nb = 11; nb < 15; nb++)
                {
                    diz += "I";

                    Console.WriteLine(nb + "=" + diz);
                }
                Console.WriteLine("15" + "=" + quinz);
                for (nb = 16; nb < 20; nb++)
                {
                    quinz += "I";
                    Console.WriteLine(nb + "=" + quinz);
                }



                for (nb = 21; nb < 30; nb++)
                {
                    interm += "I";
                    Console.WriteLine(nb + "=" + interm);
                }
                Console.WriteLine("30" + "=" + "XXX");



                interm = "XXX";
                for (nb = 31; nb < 40; nb++)
                {
                    interm = interm + "I";

                    Console.WriteLine(nb + "=" + interm);

                }
                interm = "XXXX";
                Console.WriteLine("40" + "=" + interm);
                for (nb = 41; nb < 50; nb++)
                {
                    interm = interm + "I";
                    Console.WriteLine(nb + "=" + interm);
                }

                // Fin question 5
            }


        static void Main(string[] args)
        {
            Console.WriteLine("Début du laboratoire 3");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Question 1 ");
            Question1();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Question 2 ");
            Question2();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Question 3 ");
            Question3();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Question 4 ");
            Question4();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Question 5 ");
            Question5();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Fin du laboratoire 3");
        }
    }
}
