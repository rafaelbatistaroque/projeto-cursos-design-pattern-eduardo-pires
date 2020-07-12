using System;

namespace AbstractFactory
{
    public abstract class Veiculo
    {
        public string Modelo { get; private set; }
        public Porte TipoPorte { get; private set; }

        protected Veiculo(string modelo, Porte tipoPorte)
        {
            Modelo = modelo;
            TipoPorte = tipoPorte;
        }
    }

    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte) { }
    }

    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte) { }
    }
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte) { }
    }

    public class VeiculoCriador
    {
        public static Veiculo Criar(string modelo, Porte tipoPorte)
        {
            switch (tipoPorte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo, tipoPorte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, tipoPorte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, tipoPorte);
                default:
                    throw new ApplicationException(message: "Porte do veículo desconhecido");
            }
        }

    }

    public enum Porte
    {
        Pequeno,
        Medio,
        Grande
    }
}