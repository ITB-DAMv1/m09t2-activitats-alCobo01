namespace Codi_M9_T2._Activitats
{
    public class Program
    {
        public static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Escriu el nombre de l'exericici que vols executar (per exemple, per fer l'exercici 1 escriu '1')");
                Console.WriteLine("Exercicis disponibles: 2, 3, 5, 6");
                Console.WriteLine("Per sortir del programa escriu '7'");
                Console.Write("Quin exercici vols executar? ");

                switch (Console.ReadLine())
                {
                    case "2":
                        Console.Clear();
                        Exercicis.Exercici2();
                        PrintAndContinue();
                        break;
                    case "3":
                        Console.Clear();
                        Exercicis.Exercici3();
                        PrintAndContinue();
                        break;
                    case "5":
                        Console.Clear();
                        Exercicis.Exercici5();
                        PrintAndContinue();
                        break;
                    case "6":
                        Console.Clear();
                        Exercicis.Exercici6();
                        PrintAndContinue();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Fins la pròxima!");
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opció invàlida. Torna a intertar-ho \n ");
                        break;

                }
            }
        }
        private static void PrintAndContinue()
        {
            Console.WriteLine("\n");
            Console.Write("Pulsa qualsevol tecla per continuar... ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
