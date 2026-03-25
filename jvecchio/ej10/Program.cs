List<int> pares = new List<int>();
        List<int> divisiblesPor3 = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                pares.Add(i);
            }

            if (i % 3 == 0)
            {
                divisiblesPor3.Add(i);
            }
        }

        Console.WriteLine("Números pares:");
        foreach (int num in pares)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nNúmeros divisibles por 3:");
        foreach (int num in divisiblesPor3)
        {
            Console.Write(num + " ");
        }
