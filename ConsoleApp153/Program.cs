using System;
class HelloWorld
{
    static void Main()
    {
        int a, b;

        Console.Write("İlk sayı :  ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayı :  ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 100; i++)
        {
            a = i % sayi1;
            b = i % sayi2;
            if (a == 0 && b == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}
