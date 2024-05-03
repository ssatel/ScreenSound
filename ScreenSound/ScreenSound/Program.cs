using(HttpClient client =  new HttpClient())
{
	var testeDeuBom = false;
	var endPointCorreto = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
    var endPointQuebrado = "https://guilhermeonrails.github.io/api-csharp-songs/songs.jso";

	var endPoint = testeDeuBom? endPointCorreto: endPointQuebrado;

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