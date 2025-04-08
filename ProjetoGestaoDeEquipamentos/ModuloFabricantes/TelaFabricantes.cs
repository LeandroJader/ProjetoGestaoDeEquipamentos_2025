
using ProjetoGestaoDeEquipamentos.ModuloChamado;
using ProjetoGestaoDeEquipamentos.moduloEquipamentos;

namespace ProjetoGestaoDeEquipamentos.ModuloFabricantes
{


    public class TelaFabricante

    {

        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Controle de Fabricantes");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();
        }

        public char ApresentarMenu()
        {


            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Cadastrar Fabricante");
            Console.WriteLine("2 - Editar Fabricante");
            Console.WriteLine("3 - Excluir Fabricante");
            Console.WriteLine("4 - Visualizar Fabricante");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine()!);

            return operacaoEscolhida;
        } 

        public void CadastrarFabricante()
        {
            ExibirCabecalho();   

            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Gestão de Fabricantes");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Cadastrando Fabricante...");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();

            Fabricante  NovoFabricante = ObterdadosFabricante();
            RepositorioFabricantes.
  
        }


        public Fabricante ObterdadosFabricante()
        {
            Console.Write("Digite o nome do fabricante equipamento: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Email do Fabricante");
            string email = Console.ReadLine();

            Console.Write("Digite o email do fabricante ");
            string telefone = Console.ReadLine();

            Fabricante Fabricante = new Fabricante(nome, email, telefone);

            return Fabricante;
        }

        public void EditarFabricante()
        {

   
        
        }



        
        public void ExcluirFabricante()
        {


        }
        public bool VizualizarFabricante()
        {
            return true;
        }




    }

}
