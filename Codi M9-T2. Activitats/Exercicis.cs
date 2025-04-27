using System.Diagnostics;
using System.Threading;

namespace Codi_M9_T2._Activitats
{
    public static class Exercicis
    {
        public static void Exercici2()
        {
            var processos = Process.GetProcesses();

            Console.WriteLine("Llistat de processos en execució:");
            foreach (var p in processos)
            {
                Console.WriteLine($"Nom: {p.ProcessName}, ID: {p.Id}");
            }
        }

        public static void Exercici3()
        {
            const string processName = "chrome";

            var processes = Process.GetProcessesByName(processName);

            Console.WriteLine($"S'han trobat {processes.Length} procés/processos amb el nom '{processName}'");

            foreach (var process in processes)
            {
                Console.WriteLine($"\nProcés: {process.ProcessName} (ID: {process.Id})");
                Console.WriteLine("Fils en execució:");

                foreach (ProcessThread thread in process.Threads)
                {
                    Console.WriteLine($"  ID: {thread.Id}, hora d'inici: {thread.StartTime}, prioritat: {thread.PriorityLevel}");
                }
            }
        }

        public static void Exercici5()
        {
            Thread threadOne = new Thread(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Hola! Soc el fil número 1");
            });

            Thread threadTwo = new Thread(() =>
            {
                Thread.Sleep(400);
                Console.WriteLine("Hola! Soc el fil número 2");
            });

            Thread threadThree = new Thread(() =>
            {
                Thread.Sleep(300);
                Console.WriteLine("Hola! Soc el fil número 3");
            });

            Thread threadFour = new Thread(() =>
            {
                Thread.Sleep(200);
                Console.WriteLine("Hola! Soc el fil número 4");
            }); 

            Thread threadFive = new Thread(() =>
            {
                Thread.Sleep(100);
                Console.WriteLine("Hola! Soc el fil número 5");
            });

            threadOne.Start();
            threadTwo.Start();
            threadThree.Start();
            threadFour.Start();
            threadFive.Start();

            threadOne.Join();
            threadTwo.Join();
            threadThree.Join();
            threadFour.Join();
            threadFive.Join();
        }

        public static void Exercici6() 
        { 
            var camells = new Thread[5];
            for (int i = 0; i < camells.Length; i++)
            {
                var camel = new Camel(i);
                camells[i] = new Thread(() =>
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.WriteLine($"Camell {camel.Id} va per la posicio {j}!");
                        Thread.Sleep(camel.SleepTime);
                    }
                    Console.WriteLine($"Camell {camel.Id} ha arribat a la meta!");
                });
            }

            foreach (var c in camells) c.Start();
            foreach (var c in camells) c.Join();
        }
    }
}
