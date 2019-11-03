using System;

namespace SingletonExamplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonExemplu1 = Singleton.CreareExemplu();
            Console.WriteLine("exemplu 1 de singleton este {0}", singletonExemplu1.Id);
            Singleton singletonExemplu2 = Singleton.CreareExemplu();
            Console.WriteLine("Exemplu2 de singleton este {0}", singletonExemplu2.Id);

            if (singletonExemplu1==singletonExemplu2)
            {
                Console.WriteLine("Se pare ca exeplu 1 si exemplu2 de singleton sunt identice !");
            }
            else { Console.WriteLine("Au fost create 2 exemple singleton ! "); };
            Console.ReadLine();
        }
    }
}
