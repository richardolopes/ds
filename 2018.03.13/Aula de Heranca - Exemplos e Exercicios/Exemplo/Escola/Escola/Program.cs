using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace escola
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string sexo;

        public void fazerAniversario()
        {
            this.idade++;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public string getSexo()
        {
            return sexo;
        }

        public void setSexo(String sexo)
        {
            this.sexo = sexo;
        }

        public override string ToString()
        {
            return "Pessoa{" + "Nome= " + nome + ", idade= " + idade + ", sexo= " + sexo + "}";
        }
    }

    // MM

    public class Aluno : Pessoa
    {
        private int matricula;
        private string curso;

        public void cancelarMatricula()
        {
            Console.WriteLine("Matricula cancelada.");
        }

        public int getMatricula()
        {
            return matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string getCurso()
        {
            return curso;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public override string ToString()
        {
            return "Aluno{" + "Matricula= " + matricula + ", curso=" + curso + "}";
        }
    }

    // MM

    public class Funcionario : Pessoa
    {
        private string setor;
        private Boolean trabalhando;

        public void mudarTrabalho()
        {
            this.trabalhando = !this.trabalhando;
        }

        public string getSetor()
        {
            return setor;
        }

        public void setSetor(String setor)
        {
            this.setor = setor;
        }

        public Boolean getTrabalhando()
        {
            return trabalhando;
        }

        public void setTrabalhando(Boolean trabalhando)
        {
            this.trabalhando = trabalhando;
        }

        public override string ToString()
        {
            return "Funcionario{" + "Setor= " + setor + ", trabalhando= " + trabalhando + "}";
        }
    }

    // MM

    public class Professor : Pessoa
    {
        private string especialidade;
        private float salario;

        public void receberAumento(float aum)
        {
            this.salario += aum;
        }

        public string getEspecialidade()
        {
            return especialidade;
        }

        public void setEspecialidade(string especialidade)
        {
            this.especialidade = especialidade;
        }

        public float getSalario()
        {
            return salario;
        }

        public void setSalario(float salario)
        {
            this.salario = salario;
        }

        public override string ToString()
        {
            return "Professor{" + "Especialidade= " + especialidade + ", salario= " + salario + ", nome= " + nome + ", idade= " + idade + ", sexo= " + sexo + "}";
        }
    }

    // MM

    class Program
    {
        static void Main(String[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Aluno pessoa2 = new Aluno();
            Professor pessoa3 = new Professor();
            Funcionario pessoa4 = new Funcionario();
            Professor pessoa5 = new Professor();
            Aluno pessoa6 = new Aluno();

            pessoa1.setNome("Luis");
            pessoa1.setIdade(30);
            pessoa2.setNome("Maria");
            pessoa2.setCurso("TI");
            //pessoa2.setIdade();
            pessoa3.setNome("Luisa");
            pessoa3.setSalario(3000.50f);
            //pessoa3.setIdade();
            pessoa4.setNome("João");
            pessoa4.setSexo("Masculino");
            pessoa4.setTrabalhando(false);
            //pessoa4.setIdade();
            pessoa5.setNome("Caio");
            pessoa5.setIdade(35);
            pessoa5.setSexo("Masculino");
            pessoa5.setEspecialidade("Word");
            pessoa5.setSalario(2500.68f);

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine(pessoa3.ToString());
            Console.WriteLine(pessoa4.ToString());
            Console.WriteLine(pessoa5.ToString());

            Console.ReadKey();
        }
    }
}
