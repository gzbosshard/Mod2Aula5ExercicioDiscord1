using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula4ExercicioDiscord1
{
    public abstract class Empresa
    {
        public string NomeEmpresa { get; set; }
        public int QuantidadeFuncionarios { get; set; }

        public void ImprimirInfosEmpresa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nome da Empresa: {NomeEmpresa}");
            sb.AppendLine($"Quantidade de Funcionários: {QuantidadeFuncionarios}");

            Console.WriteLine(sb.ToString());
        }

        public abstract void RealizarVenda();
    }

    
}
