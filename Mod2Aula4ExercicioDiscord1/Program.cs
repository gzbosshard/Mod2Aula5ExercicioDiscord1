namespace Mod2Aula4ExercicioDiscord1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varejo varejo = new()
            {
                NomeEmpresa = "Varejista",
                QuantidadeFuncionarios = 10
            };

            varejo.ImprimirInfosEmpresa();

            Empreiteira empreiteira = new()
            {
                NomeEmpresa = "Empreiteira",
                QuantidadeFuncionarios = 100

            };

            empreiteira.ImprimirInfosEmpresa();


        }
    }
}