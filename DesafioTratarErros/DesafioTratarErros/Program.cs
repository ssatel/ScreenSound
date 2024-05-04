// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe dois numeros inteiros, faremos a divisão do primeiro pelo segundo");

var primeiroNumero = new double();
var segundoNumero = new double();

try
{
    var etapa1 = true;
    while (etapa1)
    {
        Console.WriteLine("Informe o primeiro:");
        string inputPrimeiroNumero = Console.ReadLine();

        if (double.TryParse(inputPrimeiroNumero, out double doubleValue))
        {
            primeiroNumero = doubleValue;
            etapa1 = false;
        }
        else
        {
            Console.WriteLine("Informe um numero, entre 0 e 9:");
        }

    }
    var etapa2 = true;

    while (etapa2)
    {
        Console.WriteLine("Informe o segundo:");
        string inputSegundoNumero = Console.ReadLine();
        if (double.TryParse(inputSegundoNumero, out double doubleValue))
        {

            segundoNumero = doubleValue;
            if (segundoNumero == 0)
            {
                throw new DivideByZeroException("Ai não bebê");
            }
            etapa2 = false;
        }
        else
        {
            Console.WriteLine("Informe um numero inteirno, entre 0 e 9:");
        }

    }
    var resultado = primeiroNumero / segundoNumero;
    Console.WriteLine("Resultado:" + resultado);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Não deu ... " + ex.Message.ToString());
}
catch (Exception ex)
{
    Console.WriteLine("Não deu ... " + ex.Message.ToString());
}
