// GerenciadorFavoritos.cs
using System.Collections.Generic;
using System.Linq; // Para usar .Any() e .FirstOrDefault()
// Para salvar/carregar, você pode usar System.IO e Newtonsoft.Json (opcional)

namespace Pet_As_Service
{
    public static class GerenciadorFavoritos
    {
        public static List<RacaGato> Favoritos { get; private set; }

        static GerenciadorFavoritos()
        {
            Favoritos = new List<RacaGato>();
            // Opcional: LoadFavoritos(); // Carregar favoritos de um arquivo aqui ao iniciar
        }

        public static void AdicionarFavorito(RacaGato raca)
        {
            // Verifica se a raça já está na lista para evitar duplicatas, usando o Id
            if (raca != null && !Favoritos.Any(f => f.Id == raca.Id))
            {
                Favoritos.Add(raca);
                // Opcional: SaveFavoritos(); // Salvar favoritos em arquivo após adicionar
            }
        }

        public static void RemoverFavorito(string racaId)
        {
            Favoritos.RemoveAll(f => f.Id == racaId);
            // Opcional: SaveFavoritos(); // Salvar favoritos em arquivo após remover
        }

        public static bool IsFavorito(string racaId)
        {
            return Favoritos.Any(f => f.Id == racaId);
        }

        // Métodos para Salvar/Carregar (Opcionais para persistência, requerem Newtonsoft.Json)
        /*
        private static void SaveFavoritos()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(Favoritos);
            System.IO.File.WriteAllText("favoritos.json", json);
        }

        private static void LoadFavoritos()
        {
            if (System.IO.File.Exists("favoritos.json"))
            {
                string json = System.IO.JsonConvert.DeserializeObject<List<RacaGato>>(System.IO.File.ReadAllText("favoritos.json"));
                Favoritos = json ?? new List<RacaGato>();
            }
        }
        */
    }
}