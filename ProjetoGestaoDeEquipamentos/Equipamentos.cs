using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoDeEquipamentos
{
    public class Equipamento
    {
        public int Id;
        public string Nome;
        public string Fabricante;
        public decimal PrecoAquisicao;
        public DateTime DataFabricacao;




        //construtor de equipamentos
        public Equipamento(string nome, string fabricante, decimal precoaquisicao, DateTime datadefabricacao)
        {
            Nome = nome;
            Fabricante = fabricante;
            PrecoAquisicao = precoaquisicao;
            DataFabricacao = datadefabricacao;


        }
        // regra de negócio 
        public string ObterNumeroDeSerie()
        {
            string TresPrimeirosCaracteres = Nome.Substring(0,3).ToUpper(); // se os caracteres forem ABCDE ele comeca a contar do zero ate tres no caso ele vai retornar ABC

            return $"{TresPrimeirosCaracteres}-{Id}";
        }

    }
}
