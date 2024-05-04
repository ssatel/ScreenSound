using (HttpClient client = new HttpClient())
{
	try
	{

		var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

		Console.WriteLine(resposta);

	}
	catch (Exception ex)
	{
		Console.WriteLine("Houve um problema..." + ex.Message.ToString());
	}

}