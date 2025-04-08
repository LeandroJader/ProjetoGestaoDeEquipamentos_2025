using ProjetoGestaoDeEquipamentos.compartilhado;
using ProjetoGestaoDeEquipamentos.moduloEquipamentos;

namespace ProjetoGestaoDeEquipamentos.ModuloFabricantes;

   public  class RepositorioFabricantes
    //a ideia dos repositorios e onde armazenamos os dados onde estanmos salvando
    {
    public Fabricante[] fabricantes = new Fabricante[100];
    public int contadorFabricantes = 0;



    public void CadastrarFabricante(Fabricante novoFabricante)
    {
       novoFabricante.Id = GeradorIds.GerarIdEquipamento();

        fabricantes[contadorFabricantes++] = novoFabricante;
    }








}

