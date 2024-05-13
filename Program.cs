double Totalmg;

Console.WriteLine("-- -- -- Exame De Glicemia -- -- --");

Console.Write("digite seu mg/dl...: ");
Totalmg = Convert.ToDouble(Console.ReadLine());

if(Totalmg < 92 )
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
else
{
    if(Totalmg < 126)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Compatível com Diabetes Gestacional");
    }
    else
    {
        if(Totalmg > 126)
        {
        Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Diabetes Mellitus na Gravidez");
        }
    }
}
Console.ResetColor();