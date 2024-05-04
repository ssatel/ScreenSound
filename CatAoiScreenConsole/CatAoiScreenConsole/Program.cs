using (HttpClient client = new HttpClient())
{
	try
	{
		var cats = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/583");

		Console.WriteLine(cats);

	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.ToString());
		
	}

}