using ProjetoGestaoDeEquipamentos.moduloEquipamentos;

namespace ProjetoGestaoDeEquipamentos.ModuloChamado      

{
    public class Chamado
    {
        public int Id;
        public string TituloChamdo;
        public string DescricaoChamado;
        public Equipamento Equipamento;
       
        public DateTime DataAberturaChamado;
       

        public Chamado(int id,string titulochamado, string descricaoChamado,Equipamento equipamento, DateTime dataAberturaChamado)
        {
            Id = id;
            TituloChamdo = titulochamado;
            DescricaoChamado = descricaoChamado;
            Equipamento = equipamento;
            DataAberturaChamado = dataAberturaChamado;
           

        }

  



    }
}
