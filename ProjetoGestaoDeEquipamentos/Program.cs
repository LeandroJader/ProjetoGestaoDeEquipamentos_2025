using ProjetoGestaoDeEquipamentos.moduloEquipamentos;

namespace ProjetoGestaoDeEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)

        
        {
            TelaEquipamentos telaEquipamento = new TelaEquipamentos();
           
            while (true) {
           
               string OpcaoEscolhida= telaEquipamento.ExibirMenu();
                switch (OpcaoEscolhida)


                //gestão de equipamentos
                {
                    case "1":
                        Console.Clear();
                        telaEquipamento.cadastrarEquipamentos();


                        break;

                    case "2":
                        Console.Clear();

                        telaEquipamento.EditarEquipamentos();

                        break;

                    case "3":
                        Console.Clear();
                        telaEquipamento.ExcluirEquipamentos();

                        break;


                    case "4":
                        Console.Clear();
                        telaEquipamento.VizualizarEquipamentos(true);
                        break;

                        case "5":
                        Console.Clear();
                        telaEquipamento.RegistrarChamado();
                        break;


                    case "6":
                        Console.Clear();
                        telaEquipamento.VizualizarEquipamentosComChamados();
                        break;

                        

                    default:
                        Console.WriteLine("saindo do programa");
                        break;
                }
            }
        }
    }
}
