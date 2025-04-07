using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoDeEquipamentos;

   public static class GeradorDeId
    {
        public static int IdEquipamentos = 0;
   public static int GerarIdEquipamentos()
    {
        IdEquipamentos++;

        return IdEquipamentos;
    }

   


    }
