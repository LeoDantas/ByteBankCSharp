using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Diretor : FuncionarioAutenticavel {

        public Diretor(string cpf) : base(5000, cpf) {

        }

        public override void AumentarSalario() {
            Salario += (Salario * 0.15);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

    }
}
