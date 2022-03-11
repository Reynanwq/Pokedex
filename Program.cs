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
                if (resposta == 2)
                {
                    pokedexx.ListarPokemons();
                    WriteLine("Digite o código do pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //Definir pokemon do PLAYER
                    PokemonPlus pokemonplayer = pokedexx.Pokemons[codigo];
                    //definir pokemon do PC
                    Random r = new Random();
                    codigo = r.Next(0, pokedexx.Pokemons.Count);
                    PokemonPlus pokemonPC = pokedexx.Pokemons[codigo];
                    //batalha
                    WriteLine("Dados os pokémons que irão lutar: \n");
                    WriteLine("Dados do seu pokémon: ");
                    pokemonplayer.ExibirDadosPokemonPlus();
                    WriteLine("Dados do pokémon do PC: ");
                    pokemonPC.ExibirDadosPokemonPlus();
                    if(pokemonplayer.Poder > pokemonPC.Poder)
                    {
                        WriteLine("Parabens!!! Você ganhou");
                    }
                    if (pokemonplayer.Poder < pokemonPC.Poder)
                    {
                        WriteLine("Que pena!!! Você perdeu");
                    }
                    if (pokemonplayer.Poder == pokemonPC.Poder)
                    {
                        WriteLine("Empate!!! Que batalha incrivel");
                    }
                }
                ReadKey();
                Console.Clear();
            }
        }
        static int Menu()
        {
            WriteLine("Pokémon--Jogo de Batalha");
            WriteLine("0 - Sair da Pokédex");
            WriteLine("1 - Listar todos os Pokémons da Região de Kanto");
            WriteLine("2 - Batalhar");
            WriteLine("O que deseja fazer: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            return resposta;
        }
    }    
}