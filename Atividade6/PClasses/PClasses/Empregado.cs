using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula //propriedade
        {
            get { return Matricula; }
            set {matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //método são ações/ comportamentos

        public string VerificaHome() //método
        {
            if (homeOffice == 'S')
            {
                return "Empregado trabalha em home office";
            }
            else
            {
                return "Empregado NÃO trabalha em home office";
            }
        }

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(dataEntradaEmpresa);


            return (span.Days);
        }

        // deve ser implementado nas classes filhas (subclasses)

        public abstract double SalarioBruto(); // não precisa implementar
    }
}
