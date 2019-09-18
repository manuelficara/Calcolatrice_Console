using System;

namespace Calcolatrice {
    class Program {
        /// <summary>
        ///     Questo metodo è il Main, che viene eseguito quando
        ///     viene avviato il programma. E' l'unico metodo
        ///     utilizzato, in quanto non c'era bisogno di
        ///     creare metodi aggiuntivi per calcolare il risultato.
        ///     Esso infatti viene già calcolato quando è stampato.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Inserisci il primo numero:");
                if (double.TryParse(Console.ReadLine().Replace(".", ","), out double num1)) {
                    string sel = "";
                    do {
                        Console.WriteLine("Inserisci il secondo numero:");
                        if (double.TryParse(Console.ReadLine().Replace(".", ","), out double num2)) {
                            Console.WriteLine("Scegli l'operazione da effettuare (+, -, *, /, c):");
                            sel = Console.ReadLine().ToLower();
                            if (sel == "+") Console.WriteLine($"{num1} + {num2} = {num1 += num2}");
                            else if (sel == "-") Console.WriteLine($"{num1} - {num2} = {num1 -= num2}");
                            else if (sel == "*") Console.WriteLine($"{num1} * {num2} = {num1 *= num2}");
                            else if (sel == "/") Console.WriteLine($"{num1} / {num2} = {num1 /= num2}");
                        }
                    } while (sel != "c");
                }
            }
        }
    }
}