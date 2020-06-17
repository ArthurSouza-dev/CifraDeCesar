using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "", txt2 = "";
            int numCar = 0, num = 0, escolha;
            Console.WriteLine("Escolha a quantidade de casas que quer pular");
            Console.WriteLine("Digite 1 para criptografar!");
            Console.WriteLine("Digite 2 para descriptografar!");
            Console.WriteLine("Digite 3 para encerrar a aplicação!");
            escolha = Convert.ToInt16(Console.ReadLine());
            


            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Digite o texto que deseja criptografar!");
                    txt1 = Console.ReadLine();
                    numCar = txt1.Length;
                        for(int i = 0 ; i < numCar; i++)
                        {
                            num = Convert.ToInt16(txt1[i]) + 3;
                            txt2 += Convert.ToChar(num);

                        }
                        Console.WriteLine("{0}", txt2);
                        Console.ReadKey();
                        break;

                case 2: 
                      Console.WriteLine("Digite o texto que deseja descriptografar!");
                    txt1 = Console.ReadLine();
                    numCar = txt1.Length;
                        for(int i = 0 ; i < numCar; i++)
                        {
                            num = Convert.ToInt16(txt1[i]) - 3;
                            txt2 += Convert.ToChar(num);

                        }
                        Console.WriteLine("{0}", txt2);
                        Console.ReadKey();
                        break;

                case 3: Console.Clear();
                        Console.WriteLine("Pressione ENTER para encerrar a aplicação.");
                        break;


            }

            Console.ReadKey();
        }
    }
}