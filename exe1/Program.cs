using System;
using System.IO;
using System.Collections.Generic;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path:");
            string path = Console.ReadLine();
            Dictionary<string, int> votacao = new Dictionary<string, int>();
            

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] candidato = sr.ReadLine().Split(",");

                    int voto = int.Parse(candidato[1]);

                    if (!votacao.ContainsKey(candidato[0]))
                    {
                        votacao.Add(candidato[0], voto);
                    }
                    else
                    {
                        votacao[candidato[0]] += voto; 
                    }
                }
            }

            foreach (var item in votacao)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
