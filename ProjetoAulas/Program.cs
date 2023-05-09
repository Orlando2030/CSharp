internal class Program
{
    private static void Main(string[] args)
    {
            //Heranca();
            //AulaClasses();
            //SomenteLeitura();
            //AulaClasseAbstrata();
            //Conversores();
            //AulaTryParse();
            //TrabalhandoComString();
            //TrabalhandoComDatas();
            //TrabalhandoComErros();
            //TrabalhandoComArquivo();
            TrabalhandoComLinq();
    }

    private static void TrabalhandoComLinq()
    {
        var trabalhandoComArquivo = new Modulo12.TrabalandoComLinq();
        trabalhandoComArquivo.AulaFirstEFirstOrDefault();

    }
private static void TrabalhandoComArquivo()
{
    var trabalhandoComArquivo = new Modulo11.TrabalandoComArquivos();
    trabalhandoComArquivo.AulaExcluidoArquivo();

}
private static void TrabalhandoComErros()
{
    var trabalhandoComErro = new Modulo10.TratamentoDeErros();
    trabalhandoComErro.AularatandoExeption();

}

private static void TrabalhandoComDatas()
{
    var trabalhandoComDatas = new Modulo9.TrabalhandoComDatas();
    trabalhandoComDatas.AulaTimeOnly();
}


private static void TrabalhandoComString()
{
    var trabalhandoComStrings = new Modulo8.TrabalhandoComString();
    //trabalhandoComStrings.ConverterParaLetrasMinusculas();
    //trabalhandoComStrings.AulaSubstring();
    //trabalhandoComStrings.AulaRanger();
    //trabalhandoComStrings.AulaContains();
    //trabalhandoComStrings.AulaTrim();
    //trabalhandoComStrings.AulaStartWithEndsWith();
    //trabalhandoComStrings.AulaReplace();
    //trabalhandoComStrings.AulaLength();
}

public static void AulaTryParse()
{
    //var numero = "111";
    var numero = "asd";

    if(int.TryParse(numero, out int numeroConvertido))
    {
        Console.WriteLine("Numero foi convertido com sucesso!");
    }

    Console.WriteLine(numeroConvertido);
}

private static void Conversores()
{
    var conversores = new Conversores.Conversor();
    conversores.ConvertAndParse();
}

    private static void AulaClasses()
        {
            var soma = Cadastro.Calculos.SomaNumero(1, 3);
            Console.WriteLine(soma);

            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado";


            Console.WriteLine("Id = " + produto.GetId());
            produto.ImprimirDescricao();
        }

    private static void SomenteLeitura()
        {
            var leitura = new Cadastro.Produto();
            //leitura.Estoque = 1; não é possivel atribuir pq é apenas leitura

            Console.WriteLine(leitura.Estoque);

        }
    
    private static void Heranca()
    {
        var pessoaFiseica = new Cadastro.PessoaFisica();
        pessoaFiseica.Cep = "07143-450";
        pessoaFiseica.Cidade = "Guarulhos";
        pessoaFiseica.Endereco = "Rua munhos melo";
        pessoaFiseica.Id = 1;

        pessoaFiseica.ImprimirDados();
    }

         private static void AulaClasseAbstrata()
         {
             var cachorro = new Cadastro.Cachorro(); 
             cachorro.Nome = "Dog"; 
             cachorro.ImprimirDados();
             
         }

         private static void AulaClasseSelada()
         {
               /*var configuracao = new Cadastro.Configuracao();
               configuracao.Host = "localhost";
               */
               var configuracao = new Cadastro.Configuracao
               {
                  Host = "localhost"
               };

               Console.WriteLine(configuracao.Host);

         }

}