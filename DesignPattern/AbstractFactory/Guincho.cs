using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Guincho
    {
        public Porte TipoPorte { get; set; }

        protected Guincho(Porte tipoPorte)
        {
            TipoPorte = tipoPorte;
        }

        public abstract void Socorrer(Veiculo veiculo);

        public class GuinchoPequeno : Guincho
        {
            public GuinchoPequeno(Porte porte) : base(porte){}
            public override void Socorrer(Veiculo veiculo)
            {
                Console.WriteLine($"Socorrer carro pequeno - Modelo: {veiculo.Modelo}");
            }
        }

        public class GuinchoMedio : Guincho
        {
            public GuinchoMedio(Porte porte) : base(porte) { }
            public override void Socorrer(Veiculo veiculo)
            {
                Console.WriteLine($"Socorrer carro pequeno - Modelo: {veiculo.Modelo}");
            }
        }

        public class GuinchoGrande : Guincho
        {
            public GuinchoGrande(Porte porte) : base(porte) { }
            public override void Socorrer(Veiculo veiculo)
            {
                Console.WriteLine($"Socorrer carro pequeno - Modelo: {veiculo.Modelo}");
            }
        }

        public class GuinchoCriador
        {
            public static Guincho Criar(Porte tipoPorte)
            {
                switch (tipoPorte)
                {
                    case Porte.Pequeno:
                        return new GuinchoPequeno(tipoPorte);
                    case Porte.Medio:
                        return new GuinchoMedio(tipoPorte);
                    case Porte.Grande:
                        return new GuinchoGrande(tipoPorte);
                    default:
                        throw new ApplicationException(message: "Porte do guincho desconhecido");
                }
            }
        }
    }
}
