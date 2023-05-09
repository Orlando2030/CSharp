namespace Modulo11;

public class TrabalandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...:" + Random.Shared.Next(1,100));
        escrever.WriteLine("Nome.:" + nome);
        escrever.WriteLine("----------------------------------");
        escrever.Close();
    }

    public void AulaLendoArquivo()
    {
        //var conteudo = File.ReadAllText("Cadastro.txt");

        //Console.WriteLine(conteudo);

        var ler = new StreamReader("Cadastro.txt");
        
        var n = 1;

        while(!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
            Console.WriteLine("Lina " + n + ":"  + linha);
            n+=1;
        }

        ler.Close();
    }

    public void AulaExcluidoArquivo()
    {
        if(File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
        }
    }
}