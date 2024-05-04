
using ClasseSimples;

Console.WriteLine("Hello, World!");


var classeSimples = new NovaClasseSimples();
	
try
{

	NovaClasseSimples copiaClasse = null;

    copiaClasse.MetodoClasseSimple();

}
catch (NullReferenceException ex)
{
	Console.WriteLine($"{ex.Message}");

}

