using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula4ExercicioDiscord1
{
    public class Varejo : Empresa
    {
        public override void RealizarVenda()
        {
            Console.WriteLine("Varejo vende produtos");
        }
    }
}
