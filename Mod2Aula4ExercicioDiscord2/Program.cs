namespace Mod2Aula5ExercicioDiscord1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEmpresa> listaEmpresas = new List<IEmpresa>();

            // Objetos

            IEmpresa varejo = new Varejo(true)
            {
                NomeEmpresa = "Varejista",
                QuantidadeFuncionarios = 10
            };


            IEmpresa empreiteira = new Empreiteira()
            {
                NomeEmpresa = "Empreiteira",
                QuantidadeFuncionarios = 100
            };


            // Adicionando Informações à lista

            listaEmpresas.Add(varejo);
            listaEmpresas.Add(empreiteira);

            // Chamando os Métodos

            foreach (IEmpresa objeto in listaEmpresas)
            {
                Console.WriteLine($"----- Informações da Empresa -----{Environment.NewLine}");
                objeto.ImprimirInfosEmpresa();
                objeto.RealizarVenda();
                Console.WriteLine();

            }
        }
    }
}