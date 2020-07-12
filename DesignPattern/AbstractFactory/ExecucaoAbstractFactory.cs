using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCriador.Criar("Celta", Porte.Pequeno),
                VeiculoCriador.Criar("Jetta", Porte.Medio),
                VeiculoCriador.Criar("BMW X6", Porte.Grande),
            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}
