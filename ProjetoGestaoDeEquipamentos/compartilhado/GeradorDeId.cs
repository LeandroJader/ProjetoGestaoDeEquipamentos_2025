namespace ProjetoGestaoDeEquipamentos.compartilhado;

public static class GeradorIds
{
    public static int IdEquipamentos = 0;
    public static int IdChamados = 0;

    public static int GerarIdEquipamento()
    {
        IdEquipamentos++;

        return IdEquipamentos;
    }

    public static int GerarIdChamado()
    {
        IdChamados++;

        return IdChamados;
    }
}