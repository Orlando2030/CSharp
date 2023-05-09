namespace Modulo8;

public class TrabalhandoComString
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Por favor digite alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.Write("Por favor digite alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(2,3));
    }

    public void AulaRanger()
    {
        string arquivoTXT = "2023_05_09_arquivo.txt";
        var ano = arquivoTXT[..4];
        var extensao = arquivoTXT[^3..];
        var nome = arquivoTXT[11..^4];

        Console.WriteLine(ano);
        Console.WriteLine(extensao);
        Console.WriteLine(nome);
    }

    public void AulaContains()
    {
        string arquivoTXT = "2023_05_09_arquivo.txt";

        Console.WriteLine("Contem a palavra aquivo: " + arquivoTXT.Contains("arquivo"));

    }

    public void AulaTrim()
    {
        string texto = "** Orlando Santos de Oliveira **";

        Console.WriteLine("Tratando string com trim Total: " + texto.Trim('*'));
        Console.WriteLine("Tratando string com trim Start: " + texto.TrimStart('*'));
        Console.WriteLine("Tratando string com trim Fim: " + texto.TrimEnd('*'));
    }

    public void AulaStartWithEndsWith()
    {
        string texto = "Curso CSharp";

        Console.WriteLine("Inicio: " + texto.StartsWith("Curso"));
        Console.WriteLine("Final: " + texto.EndsWith("Sharpy"));
    }

    public void AulaReplace()
    {
        string texto = "Curso CSharp";

        Console.WriteLine(texto.Replace("Curso", "Cursos de"));
    }

    public void AulaLength()
    {
        string texto = "Curso";

        Console.WriteLine("A qtde de caracter que a palavra " + " " + texto + " possui é " + texto.Length);
    }
}