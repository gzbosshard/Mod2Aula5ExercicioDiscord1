using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula5ExercicioDiscord1
{
    internal class Empreiteira : Empresa, IEmpresa
    {
        public void RealizarVenda()
        {
            Console.WriteLine("Empreiteira vende serviços");
        }
    }
}
