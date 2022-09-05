using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Funcionarios
{
    //abstract -> modelo para criar outras classes -> não é possível criar objetos dela
    public abstract class Funcionario
    {

        public string Nome { get; set; }
        public string Cpf { get; private set; }

        //protected -> set é executado na propria classe e nas que derivam dela 
        public double Salario { get; protected set; }

        //static -> para definir que o método é da classe e não do objeto
        public static  int totalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            totalFuncionarios++;
        }

        //abstract no método -> obria as classes filhas a criarem o método da classe mãe
        //só existem dentro de classes abstratas
        public abstract void AumentarSalario();
        //virtual -> permite q a classe filha consiga sobreescrever o método
        public abstract double GetBonificacao();
    }
}
