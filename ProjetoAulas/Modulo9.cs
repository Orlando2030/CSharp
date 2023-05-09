namespace Modulo9;

public class TrabalhandoComDatas
{
    public void aulaDateTime()
    {
        var data1 = new DateTime(2012, 12, 02, 19,22,23);
        var data2 = DateTime.Parse("2012/12/02 19:22:23");
        var data3 = DateTime.Now;
        var data4 = DateTime.Today;

        Console.WriteLine(data1);
        Console.WriteLine(data2);
        Console.WriteLine(data3);
        Console.WriteLine(data4);

        Console.WriteLine(data1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);

    }

    public void AulaSubtraindoData()
    {
        var data1 = DateTime.Now;
        var date2 = DateTime.Parse("2023/01/01");

        var ddFif = data1 - date2;
        Console.WriteLine((int)ddFif.TotalDays);
        Console.WriteLine((int)ddFif.TotalHours);
        Console.WriteLine((int)ddFif.TotalMinutes);
    }

    public void AulaAddDiaMesAno()
    {
        var data1 = DateTime.Now;

        Console.WriteLine(data1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(data1.AddYears(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(data1.AddMonths(3).ToString("dd-MM-yyyy HH:mm:ss"));

    }

    public void AulaAddHoraMinutoSegudo()
    {
        var data1 = DateTime.Now;

        Console.WriteLine(data1.AddHours(3).ToString("HH:mm:ss"));
        Console.WriteLine(data1.AddMinutes(3).ToString("HH:mm:ss"));
        Console.WriteLine(data1.AddSeconds(3).ToString("HH:mm:ss"));

    }

    public void AulaDiaDaSemana()
    {
        var data1 = DateTime.Now;

        Console.WriteLine(data1.DayOfWeek);
    }

     public void AulaDAteOnly()
    {
        var data1 = DateOnly.Parse("2023/05/09");

        Console.WriteLine(data1);
        Console.WriteLine(data1.ToString("dd-MM-yy"));
    }

     public void AulaTimeOnly()
    {
        var hora = TimeOnly.Parse("23:03:22");

        Console.WriteLine(hora);
        Console.WriteLine(hora.ToString("HH-mm-ss"));
    }

}