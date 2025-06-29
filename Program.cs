 Console.WriteLine("--- Esperto Contra Sabido ---\n");

        Console.Write("Quantos alimentos serão distribuídos? ");
        int total = Convert.ToInt32(Console.ReadLine());

        if (total <= 0) return;

        Console.WriteLine();

        int restantes = total;
        int picaPau = 0, raposinha = 0;

        int contadorParaVoce = 0;

        while (restantes > 0)
        {
            contadorParaVoce++;
            
            // Pica-pau recebe 1 alimento por rodada
            if (restantes > 0)
            {
                picaPau++;
                restantes--;
                Console.Write($"{contadorParaVoce} para você. ");
            }

            // Raposinha recebe a mesma quantidade da rodada
            int contadorParaMim = 0;
            while (restantes > 0 && contadorParaMim < contadorParaVoce)
            {
                contadorParaMim++;
                raposinha++;
                restantes--;

                Console.Write($"{contadorParaMim}");
                if (contadorParaMim < contadorParaVoce && restantes > 0)
                    Console.Write(", ");
            }

            if (contadorParaMim > 0)
            {
                Console.WriteLine(" para mim.");
            }
            else
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
        Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");
    