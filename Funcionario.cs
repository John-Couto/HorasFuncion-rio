using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionário
{
    public class Funcionario 
    {
        public String ?nome; 
        public double valorPorHora;
        public int horas;

        public double total()
        {
            return valorPorHora * horas;
        }
    }
}
