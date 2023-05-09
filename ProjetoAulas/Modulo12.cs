namespace Modulo12;

public class TrabalandoComLinq
{
public void AulaWhere()
{
    //string nomeCompleto = "Orlando Santos de Oliveira";

    //var resultado = nomeCompleto.Where(p => p == 'a');

    //var resultado = from c in nomeCompleto  where c == 'e' select c;

    //foreach( var letra in resultado)
    //{
       // Console.WriteLine(letra);
    //}

    var numeros = new int[]{10,12,14,16,18,20};
    var resultado = numeros.Where(p => p > 13);

    foreach( var letra in resultado)
    {
        Console.WriteLine(letra);
    }

    }

    public void AulaOrdenacao()
    {
    //var numeros = new int[]{15,12,14,19,18,20};
    //var resultado = numeros.OrderBy(p => p);

    var strings = new string[]{"b","a","z","j"};
    var resultado = strings.OrderBy(p => p);

    foreach( var letra in resultado)
    {
        Console.WriteLine(letra);
    }
    }
    public void AulaTake()
    {

    var strings = new string[]{"b","a","z","j"};
    var resultado = strings.Where(p => p == "a").Take(2).OrderBy(p => p);

    foreach( var letra in resultado)
    {
        Console.WriteLine(letra);
    }
    }
    
    public void AulaCount()
    {

        var numeros = new int[]{10,12,14,16,18,20};

        var resultado = numeros.Count(p => p >= 16);

        Console.WriteLine(resultado);

    }

    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[]{10,12,14,16,18,20};

        var numeros_ = new int[]{};

        //var resultado = numeros.First();
        var resultado = numeros.First(P => P >15);

        Console.WriteLine(resultado);

        var resultado_ = numeros_.FirstOrDefault();

        Console.WriteLine(resultado_);

        var resultado__ = numeros.FirstOrDefault(P => P >115, -99);

        Console.WriteLine(resultado__);

    }

}