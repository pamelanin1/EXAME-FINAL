using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAME_FINAL
{
    internal class Cliente
    {
        public int _id {  get; set; }
        public string _nome { get; set; }
        public string _cpf { get; set; }
        public string _cnh { get; set; }
        public string _telefone { get; set; }
        public string _email { get; set; }

        
        public void Constrtor()
        {

        }

        public void Construtor(int id, string Nome, string Cpf, string Cnh,
            string Telefone, string Email)
        {
            _id = id;
            _nome = Nome;
            _cpf = Cpf;
            _cnh = Cnh;
            _telefone = Telefone;
            _email = Email;
        }

        
        





    }
}
