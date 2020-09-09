using System;
using System.Collections.Generic;

namespace PruebaEntrevista
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABCDEFGHIJKLMNOPQRSTUVWXYZ
            //ANA = NAN
            Console.Write("Escriba una palabra para encriptar: ");
            string palabra = Console.ReadLine();
            string encrypt = "";
            List<string> _abcedario = new List<string> {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
            
            for (int i = 0; i < palabra.Length; i++)
            {
                int position = 0;
                string Word = palabra[i].ToString();
                position = _abcedario.IndexOf(Word);

                position += 12;

                if (_abcedario.Count > position)
                {
                    encrypt = encrypt + "A";
                }
                else
                {
                    encrypt = encrypt + _abcedario[position];
                }
                
            }
            Console.WriteLine($"Palabra encriptada: {encrypt}");
            Console.ReadKey();
        }
    }
}
