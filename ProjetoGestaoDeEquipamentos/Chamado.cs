
namespace ProjetoGestaoDeEquipamentos        /*• Deve ter um identificador único (Id);
• Deve ter a título do chamado;
• Deve ter a descrição do chamado;
• Deve ter um equipamento;
• Deve ter uma data de abertura;*/
{
    public class Chamado
    {
        public int Id;
        public string TituloChamdo;
        public string DescricaoChamado;
        public Equipamento Equipamento;
       
        public DateTime DataAberturaChamado;
       

        public Chamado(string titulochamado, string descricaoChamado,Equipamento equipamento, DateTime dataAberturaChamado)
        {
        
            TituloChamdo = titulochamado;
            DescricaoChamado = descricaoChamado;
            Equipamento = equipamento;
            DataAberturaChamado = dataAberturaChamado;
           

        }

  



    }
}
