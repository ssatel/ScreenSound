using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SoundScreen2.Modelos
{
    public class Musica
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao {get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome da Musica: {Nome}");
            Console.WriteLine($"Duracao em segundos: {Duracao / 1000}");
        }
    }
}
