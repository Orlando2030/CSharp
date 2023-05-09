namespace Cadastro
{
    public static class Calculos
    {
        public static int SomaNumero (int a, int b)
        {
            return (a+b);
        }
    }

    public class Produto
    {
        private int Id;
        public string Descricao {get; set;}

        public int Estoque {get;}

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

    }

    public class Pessoa
    {
        public int Id {get; set;}

        public string Endereco {get; set;}

        public string Cidade {get; set;}

        public string Cep {get; set;}

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Edereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }

    } 

    public class PessoaFisica : Pessoa
    {
        public string Cpf {get; set;}
    }

        public sealed class Configuracao
    {
        public string Host {get;set;}
    }


    public abstract class Animal
    {
        public string Nome {get;set;}

        public abstract string GetInformacoes();

        public virtual void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetInformacoes());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Metodo chamando dentro da classe cachorro");
        } 
    }  

}