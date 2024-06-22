using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal interface IEmprestavel
    {
        public abstract bool VerificarDisponibilidade();
        public abstract DateTime ObterPrazoDeDevolucao();
    }
}
