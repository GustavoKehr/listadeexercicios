using meudeusporfavor.Interfaces;

namespace meudeusporfavor.Classes

{
    public class Gasolina : Combustivel, IGasolina
    {
        public float PrecoG { get; set; }

        public override float QuantidadeC(float PrecoG)
        {
            double litroG = 5.30f;
            
            if (litroG <= 20)
            {
                return PrecoG * 0.212f;
            }
            else if (litroG > 20)
            {
                return PrecoG *
            }
            
        }

        public override float ValorASerPago(float PrecoC)
        {
            double litroG = 5.30f;
            switch (litroG)
            {
                case 1: Console.WriteLine($"Deve pagar 5.30, com desconto de 4% por litro fica ");
                
                    break;
                default:
                    break;
            }
            
        }
    }

    
}