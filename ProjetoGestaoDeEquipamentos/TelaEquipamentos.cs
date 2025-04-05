using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoDeEquipamentos
{
   public class TelaEquipamentos
    {
       public Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos = 0;
        public  string ExibirMenu()
        {

            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("gestão de equipamentos");
            Console.WriteLine("======================");

            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("1- Cadastro de equipamenttos");
            Console.WriteLine("4- vizualização de equipamentos");

            Console.WriteLine("digite uma operação válida");
            string OpcaoEscolhida = Console.ReadLine();
            return OpcaoEscolhida;
        }
        public void cadastrarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("gestão de equipamentos");
            Console.WriteLine("======================");

            Console.WriteLine("======================");
            Console.WriteLine("cadastrando equipamento");
            Console.WriteLine("======================");

            Console.WriteLine("Digite o nome do equipamento");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o nome da Fabricante do equipamento");
            string fabricante = Console.ReadLine();

            Console.WriteLine("Digite o preço de aquisição do equipamento");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("digite a data de fabricação do equipamento: (dd/mm/yyyy)");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoequipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);
            equipamentos[contadorEquipamentos++] = novoequipamento;


        }
        public void ExibirEquipamentos()
        {


            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("gestão de equipamentos");
            Console.WriteLine("======================");

            Console.WriteLine("======================");
            Console.WriteLine("vizualizar equipamentos");
            Console.WriteLine("======================");

            Console.WriteLine
                (
                 "{0,-10} | {1,-15} | {2,-11} | {3,-10}  | {4, -13} |{5, 10}",
                  "id", "nome", "num. serie", "fabricante", "preço", "data de fabricação"
                  );



            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null) continue;
                Console.WriteLine
                (
                 "{0,-10} | {1,-15} | {2,-11} | {3,-10}  | {4, -13} |{5, 10}",
                  e.Id, e.Nome, e.ObterNumeroDeSerie(), e.Fabricante, e.PrecoAquisicao.ToString("c2"), e.DataFabricacao.ToShortTimeString()
                  );

            }
        }
    }
}
