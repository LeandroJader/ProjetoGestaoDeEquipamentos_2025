using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoDeEquipamentos
{
    public class TelaEquipamentos
    {
        public Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos = 0;
        public string ExibirMenu()
        
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("gestão de equipamentos");
           
            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("1- Cadastro de equipamenttos");     
            Console.WriteLine("2- Editar Equipamentos");
            Console.WriteLine("4- vizualização de equipamentos");
            Console.WriteLine();
            Console.WriteLine("digite uma operação válida");
            string OpcaoEscolhida = Console.ReadLine();
            return OpcaoEscolhida;
        }

        public void cadastrarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("gestão de equipamentos");
            Console.WriteLine("-----------------------");
            Console.WriteLine("cadastrando equipamento");
            Console.WriteLine("-----------------------");


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
        public void EditarEquipamentos()
        {

            Console.Clear();
            Console.Write("======================");
            Console.WriteLine("gestão de equipamentos");
        
           Console.Write("----------------------------");
            Console.WriteLine("Editando Equipamentos");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            VizualizarEquipamentos(false);

            Console.Write("Digite o Id do produto que deseja selecionar");
            int IdSelecionado = Convert.ToInt32(Console.ReadLine());

           
            Console.Write("Digite o nome do equipamento");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome da Fabricante do equipamento");
            string fabricante = Console.ReadLine();

            Console.Write("Digite o preço de aquisição do equipamento");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("digite a data de fabricação do equipamento: (dd/mm/yyyy)");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoequipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);

            bool conseguiuEditar = false;

            for (int i=0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;

                else if (equipamentos[i].Id == IdSelecionado)
                {
                    equipamentos[i].Nome = novoequipamento.Nome;
                    equipamentos[i].Fabricante = novoequipamento.Fabricante;
                    equipamentos[i].PrecoAquisicao = novoequipamento.PrecoAquisicao;
                    equipamentos[i].DataFabricacao = novoequipamento.DataFabricacao;
                }

            
            }
            if (conseguiuEditar)
                {
                    Console.WriteLine("ouve um erro durante a edição de um registro");
                return;
                }
            Console.WriteLine("O equipamento foi editado co sucesso");

            
        }

        public void ExcluirEquipamentos()
        {
 
            Console.WriteLine("----------------------");
            Console.WriteLine("Excluir Equipamentos");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Excluindo Equioamentos");
            Console.WriteLine("-----------------------");

            VizualizarEquipamentos(false);

            Console.Write("Digite o Id do produto que deseja selecionar");
            int IdSelecionado = Convert.ToInt32(Console.ReadLine());


            bool ConsegiuExcluir = false;

            for (int i=0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;
                
                else if (equipamentos[i].Id==IdSelecionado)
                {
                    equipamentos[i] = null;
                    ConsegiuExcluir = true;
                }
                if (!ConsegiuExcluir)
                {
                    Console.WriteLine("Ouve um erro durante a exclusão do produto");

                }
                

            }
            Console.WriteLine("O equipamento foi excluido com sucesso");
            Console.ReadLine();
        }
        public void VizualizarEquipamentos(bool exibirTitulo)
        {
            Console.Clear();
            if (exibirTitulo==true)
            {
           
              
                Console.WriteLine("======================");
                Console.WriteLine("gestão de equipamentos");
                Console.WriteLine("======================");

                Console.WriteLine("======================");
                Console.WriteLine("vizualizar equipamentos");
                Console.WriteLine("======================");
                Console.WriteLine();
                Console.WriteLine();


            }
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
                Console.WriteLine("precione Enter para prosseguir");
            }
            
        }


    }
}
