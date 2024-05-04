// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Lista de Inteiros");

var listainteiros = new List<int>()
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
};

try
{

    Console.WriteLine("Mostrar o item: ");
    var inputNumero = Console.ReadLine();

    var numeroItem = 0;

    if (int.TryParse(inputNumero, out int result))
    {
        numeroItem = result;
    }

    var itemLista = listainteiros.IndexOf(numeroItem);

    if (itemLista != -1)
    {
        Console.WriteLine(itemLista.ToString());
    }
    else
    {
        throw new Exception("Errou!!!");
    }



}
catch (Exception ex)
{
    Console.WriteLine("Não foi ..." + ex.Message.ToString());
}

foreach (var item in listainteiros)
{
    Console.WriteLine(item);
}
