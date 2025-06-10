// RacaGato.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_As_Service
{
    public class RacaGato
    {
        public string Id { get; set; } // <<== IMPORTANTE: Adicione esta propriedade para o ID da API
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Temperamento { get; set; }
        public string TamanhoPelo { get; set; } // Seu nome original
        public string Cuidados { get; set; } // Seu nome original
        public string CaminhoImagem { get; set; } // Seu nome original - para a URL da imagem

        // Opcional: Para exibir o nome da raça diretamente em ComboBoxes ou ListBoxes
        public override string ToString()
        {
            return Nome;
        }

        // Adicione outras propriedades que você julgar importantes, como:
        // public int ExpectativaVidaAnos { get; set; }
        // public string NivelAtividade { get; set; }
        // public string Socializacao { get; set; }
    }
}