using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAME_FINAL
{
    internal class Veiculo : Cliente
    {
        public string _placa {  get; set; }
        public string _modelo { get; set; }
        public string _marca { get; set; }
        public string _ano { get; set; }
        public string _categoria { get; set; }
        public double _valorDiaria { get; set; }
        public string _statusDisponivel { get; set; }
        public string _tipoCombustivel { get; set; }
        




        

        public void _VeiculoCarga(double valor)
        {
            
            if(valor > 0)
            {
                double v = valor * 0.20;
            }

        }


        public void CalcularValorDiario(double valor)
        {
            if(valor < 0)
            {
                _valorDiaria = valor;
            }
            return;
        }

        public void valorDiaria(double valor)
        {
            if(_valorDiaria > 0)
            {
                _valorDiaria = valor;
            }
            else
            {
                Console.WriteLine("Valor de diária inválido");
            }
        }





    }
}
