using(HttpClient client =  new HttpClient())
{
    string listaMusicas = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

    Console.WriteLine(listaMusicas);

}