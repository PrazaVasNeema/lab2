class Program{
    static void Main(){
        Console.Clear();
        //Console.WriteLine("Hello, world");

        int i = 2;
        long l;
        byte b;
        uint ui; // диапазон с нуля

        l = (long)i;

        int[] array = new int[5];
        array = new int[] {0, 1, 2};

        if (i > 5){
            Console.WriteLine("true");
        }
        else{
            Console.WriteLine("false");
        }

        switch (i)
        {
            case 0: Console.WriteLine("1"); break;
            case 1: Console.WriteLine("2"); break;
            case 2: Console.WriteLine("3"); break;
            default:
                    Console.WriteLine("default");
                    break;
        }

        Console.WriteLine("WHILE \n");
        i = 0;

        // do
        // {

        // }
        // while (i == 0);

        while (i <= 5)
        {
            // действие
            Console.Write($"{i}");
            ++i;
        }
        Console.WriteLine("\n");

        // for (/*старт*/;/*условия*/;/*итерация*/)
        // {
        //     continue;
            
        //     break;
        // }

        Console.WriteLine("FOR \n");
        for (i = 0; i <= 5; ++i)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");

        Console.WriteLine($"short \t{short.MinValue} - {short.MaxValue}");
        Console.WriteLine($"int \t{int.MinValue} - {int.MaxValue}");
        Console.WriteLine($"long \t{long.MinValue} - {long.MaxValue}");
        Console.WriteLine($"float \t{float.MinValue} - {float.MaxValue}");
        Console.WriteLine($"double \t{double.MinValue} - {double.MaxValue}");

//        Console.ReadKey(true);
    }
}