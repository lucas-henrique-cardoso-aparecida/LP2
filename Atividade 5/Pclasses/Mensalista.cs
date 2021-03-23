using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public Mensalista() // Construtor da classe Mensalista
        {
            
        }

        // Sobrecarga - uma nova versão
        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }



        //Sobreescrevend o método
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
