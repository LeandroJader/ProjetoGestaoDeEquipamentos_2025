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

                        telaEquipamento.cadastrarEquipamentos();


                        break;

                    case "2":



                        break;

                    case "3":



                        break;


                    case "4":

                        telaEquipamento.ExibirEquipamentos();
                        break;



                    default:
                        Console.WriteLine("saindo do programa");
                        break;
                }
            }
        }
    }
}
