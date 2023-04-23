using System;
namespace A
{
    class Aswitch

    {
        static void Main(string[] args)
        {
            char ch;int i = 1;
            for (i=1; i < 5; i++) {

                Console.WriteLine(" Enter cahracter -> ");

                ch = Convert.ToChar(Console.ReadLine());
                switch (char.ToLower(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("vovels" + ch);
                        break;
                    default:
                        Console.WriteLine("not vovels");
                        break;
                }

            }
           
        }
    }
}
   
