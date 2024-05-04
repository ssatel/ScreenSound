using System.Net;
using System.Runtime.CompilerServices;

using (HttpClient client =  new HttpClient())
{
	var testeDeuBom = true;
	var endPointCorreto = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
    var endPointQuebrado = "https://guilhermeonrails.github.io/api-csharp-songs/songs.jso";
	var endPointGames = "https://www.cheapshark.com/api/1.0/deals";


    var endPoint = testeDeuBom? endPointCorreto: endPointQuebrado;

	Console.WriteLine("Entre a função:");
	string funcao = Console.ReadLine();

	if (funcao == "1")
	{
		try
		{
			string listaMusicas = await client.GetStringAsync(endPoint);
			Console.WriteLine(listaMusicas);

		}
		catch (Exception ex)
		{
			Console.WriteLine("Sinto muito deu ruim ... olha o que aconteceu ..." + ex.Message.ToString());
		}
	}

}

