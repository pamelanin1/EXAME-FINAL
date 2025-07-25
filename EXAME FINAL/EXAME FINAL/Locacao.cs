using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAME_FINAL
{
    internal class Locacao : Veiculo
    {


        public DateTime _DataIncio {  get; set; }
        public DateTime _DataFim { get; set; }
        public double _valorTotal { get; set; }
        public string _diasLocados { get; set; }
        public string _status { get; set; }

        public void Construtor(string placa, string marca, string modelo, string ano,
            string categoria, string nome, string cpf)
        {
            _placa = placa;
            _marca = marca;
            _modelo = modelo;
            _ano = ano;
            _categoria = categoria;
            _nome = nome;
            _cpf = cpf;

        }


       
    }
}

