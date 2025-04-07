
namespace ProjetoGestaoDeEquipamentos;

    public class TelaEquipamentos
    {
        public Chamado[] EquipamentosComChamados = new Chamado[100];
       public  int contadorEquipamentosChamados = 0;

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
            Console.WriteLine("5- para registrar um chamado");
            Console.WriteLine("6- vizualizar Equipamentos Com Chamados ");
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
            novoequipamento.Id = GeradorDeId.GerarIdEquipamentos();
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
            novoequipamento.Id = GeradorDeId.GerarIdEquipamentos();


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
            Console.WriteLine("O equipamento foi editado com sucesso");

            
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
                Console.WriteLine("pressione Enter para prosseguir");
            }
            Console.ReadLine();
        }



        public void RegistrarChamado()
        {
        int idChamados = GeradorDeId.GerarIdChamados();

            Console.WriteLine("Informe o Titulo deste chamado");
            string titulo = Console.ReadLine();

            Console.WriteLine("Informe a descrição deste chamado");
            string descricaoChamado = Console.ReadLine();

            Console.WriteLine("informe a data de abertura deste chamado (dd/mm/yyyy)");
            DateTime horaAberturaChamado = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe o Id do aparelho que seseja abrir um chamado");
            int IdSelecionado = Convert.ToInt32(Console.ReadLine());

        Equipamento EquipamentoSelecionado = null;
        bool consegiuRegistrar = false;

            for (int i = 0; i< equipamentos.Length; i++)
            {
               if (equipamentos[i] != null && equipamentos[i].Id==IdSelecionado )
               {
                EquipamentoSelecionado = equipamentos[i];
                Chamado EquipamentoComChamado = new Chamado(idChamados,titulo, descricaoChamado, EquipamentoSelecionado, horaAberturaChamado);
                EquipamentosComChamados[contadorEquipamentosChamados++] = EquipamentoComChamado;
                consegiuRegistrar = true;
                break;
                }
                

            }



        }
    public void VizualizarEquipamentosComChamados()
    {

        Console.WriteLine("-----------------------");
        Console.WriteLine("gestão de Chamados");
        Console.WriteLine("-----------------------");

        Console.WriteLine("-----------------------");
        Console.WriteLine("vizualizar equipamentos Com Chamados Abertos ");
        Console.WriteLine("-----------------------");
        Console.WriteLine();
        Console.WriteLine();



        for (int i = 0; i < contadorEquipamentosChamados; i++)
        {


            Console.WriteLine(EquipamentosComChamados[i].Equipamento.Nome);



            if (EquipamentosComChamados[i] != null)
            {
                

                Chamado chamado = EquipamentosComChamados[i];

                if (chamado != null && chamado.Equipamento != null) {
                   
                    
                    Equipamento e = chamado.Equipamento;
            Console.WriteLine($"titulo do chamado:{EquipamentosComChamados[i].TituloChamdo}");
                    Console.WriteLine();
            Console.WriteLine($"Equipamento com chamado aberto: {EquipamentosComChamados[i].TituloChamdo}");

                    Console.WriteLine
              (
                  "{0,-10} | {1,-15} | {2,-11} | {3,-10}  | {4, -13} |{5, 10}",
                  "id", "nome", "num. serie", "fabricante", "preço", "data de fabricação"
                  );

                    Console.WriteLine
                   (
                    "{0,-10} | {1,-15} | {2,-11} | {3,-10}  | {4, -13} |{5, 10}",
                    e.Id, e.Nome, e.ObterNumeroDeSerie(), e.Fabricante, e.PrecoAquisicao, e.DataFabricacao
                     );
    }
                Console.WriteLine();
                    Console.WriteLine($"descrição do chamado{EquipamentosComChamados[i].DescricaoChamado}"); ;

        
                DateTime DataAtual = DateTime.Now;

                DateTime DataAberturaChamado = EquipamentosComChamados[i].DataAberturaChamado;

                TimeSpan diferanca = DataAtual.Subtract(DataAberturaChamado);

                Console.WriteLine($"O chamado esta aberto há {diferanca} diaas ");

            }

        }

                Console.ReadLine();
    }


    



}

