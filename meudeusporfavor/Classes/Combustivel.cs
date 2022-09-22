using meudeusporfavor.Interfaces;
namespace meudeusporfavor.Classes
{
    public abstract class Combustivel : ICombustivel
    {
        public string? Gasolina { get; set; }
        public string? Alcool {get; set; }

        public abstract float QuantidadeC(float PrecoG);
        public abstract float ValorASerPago(float PrecoC);
    }
}

