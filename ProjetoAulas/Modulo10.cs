namespace Modulo10;

public class TratamentoDeErros
{
    public void AulaGerandoExeption()
    {
        while(true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("Resultado: " + resultado);
        }
    }

    public void AularatandoExeption()
    {

        try
        {
            while(true)
            {
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado: " + resultado);
            }
        }
        catch(DivideByZeroException exception)
        {
                Console.WriteLine("Ocorreu um erro por divisão: " + exception.Message);
                Console.WriteLine("Ocorreu um erro por divisão: " + exception.StackTrace);
        }
                catch(Exception exception)
        {
                Console.WriteLine("Ocorreu um erro: " + exception.Message);
                Console.WriteLine("Ocorreu um erro: " + exception.StackTrace);
        }

    }
}