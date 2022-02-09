using Desafio_3.Documento.Classe;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_3
{
    class Program
    {
        static List<Pessoa> pessoas;

        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();

            Pessoa joao = new Pessoa("Leandro", 21);
            Pessoa Leandro = new Pessoa("João", 15);
            Pessoa Paulo = new Pessoa("Paulo", 17);
            Pessoa Jessica = new Pessoa("Jessica", 18);

            pessoas.Add(joao);
            pessoas.Add(Leandro);
            pessoas.Add(Paulo);
            pessoas.Add(Jessica);

            foreach (Pessoa item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Lista iniciou com {pessoas.Count()}.");

            pessoas.Remove(Leandro);
            pessoas.Remove(Paulo);

            Console.WriteLine($"Lista terminou com {pessoas.Count()}.");

            // Consulta
            var resultado = from nome in pessoas
                            where nome.Nome == "Jessica"
                            select nome;

            int maisVelho = pessoas.Max(x => x.Idade);

            var resultado1 = from nome in pessoas
                             where nome.Idade == maisVelho
                             select nome;

            foreach (var result in resultado)
            {
                Console.WriteLine($"Nome: {result.Nome}, encontrado.");
            }

            foreach (var result in resultado1)
            {
                Console.WriteLine($"O nome da pessoa mais velha é {result.Nome}.");
            }

        }
    }
}
