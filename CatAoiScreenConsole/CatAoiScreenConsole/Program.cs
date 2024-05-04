using (HttpClient client = new HttpClient())
{
	try
	{
		var cats = await client.GetStringAsync("https://cataas.com/api/tags");

		Console.WriteLine(cats);

	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.ToString());
		
	}

}