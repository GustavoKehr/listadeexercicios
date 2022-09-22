using condicionais.Interfaces;

namespace condicionais.Classes
{
    public class Eleitor : IEleitor
    {
        public string? Nome { get; set;}
        public string? Cpf { get; set;}
        public DateTime DataNasc { get; set; }
        public Endereco? Endereco { get; set;}

        public bool ValidarDataNasc(DateTime datanasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - datanasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            return false;
        }
    }
}