using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Pokedex
{
    class Program
    {
        static void Main (string[] args)
        {
            Pokedexx pokedexx = new Pokedexx();
            int resposta = 300;
            while (resposta != 0)
            {
                resposta = Menu();
                if (resposta == 1)
                {
                    pokedexx.ListarPokemons();
                }
            ReadKey();
            Console.Clear();
            }
        }
        static int Menu()
        {
            WriteLine("Pokédex----Agenda Pokémon");
            WriteLine("0 - Sair da Pokédex");
            WriteLine("1 - Listar todos os Pokémons da Região de Kanto");
            WriteLine("O que deseja fazer: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            return resposta;
        }
    }    
}