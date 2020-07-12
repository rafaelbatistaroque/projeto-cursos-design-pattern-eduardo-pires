using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactory.Guincho;

namespace AbstractFactory
{
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCriador.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte tipoPorte)
        {
            return VeiculoCriador.Criar(modelo, tipoPorte);
        }
    }
}
