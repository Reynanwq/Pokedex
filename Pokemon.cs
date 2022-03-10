using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        public Pokemon(string nome, string descricao) //sobrecarga de métodos
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { string texto = value.ToUpper();
                  nome = texto;
                }
        }
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value.ToUpper(); }
        }
        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: "  + this.nome);
            Console.WriteLine("Descrição do Pokemon: " + this.descricao);
        }
        public void ExibirDadosPokemon(Boolean formatado) //sobrecarga de método
        {
            if(formatado == true)
            {
                Console.WriteLine("Pokemon " + this.Nome + ": " + this.Descricao.ToLower());
            } 
            else
            {
                Console.WriteLine("Nome do Pokemon: "  + this.nome);
                Console.WriteLine("Descrição do Pokemon: " + this.descricao);
            } 
        }
        
    }
}