using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Para trabalhar com imagens
using Pet_As_Service; // Para as classes RacaGato, CatApiService, GerenciadorFavoritos
using System.Net.Http; // Para HttpClient


namespace Pet_As_Service
{
    public partial class FormBuscaRacas : Form
    {
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormBuscaRacas_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // FormBuscaRacas.cs (dentro da classe)

        private CatApiService _catApiService;
        private List<RacaGato> _racasDisponiveis;
        private RacaGato _racaAtualExibida; // Para guardar a raça que está sendo exibida para favoritar

        public FormBuscaRacas()
        {
            InitializeComponent();
            _catApiService = new CatApiService();
            CarregarRacasNoComboBox(); // Carrega as raças ao iniciar o formulário
            LimparDetalhesRaca(); // Limpa os campos de detalhes inicialmente
        }

        // ====================================================================
        // LÓGICA DE CARREGAMENTO E EXIBIÇÃO DE RAÇAS
        // ====================================================================

        private async void CarregarRacasNoComboBox()
        {
            try
            {
                _racasDisponiveis = await _catApiService.GetTodasRacasAsync();

                // Limpa itens antigos e adiciona as raças na ComboBox
                cbxRacas.DisplayMember = "Nome"; // Exibe o Nome da raça
                cbxRacas.ValueMember = "Id";     // Usa o Id como valor interno
                cbxRacas.DataSource = _racasDisponiveis;

                if (_racasDisponiveis.Any())
                {
                    cbxRacas.SelectedIndex = -1; // Começa sem nada selecionado (opcional)
                                                 // ou cbxRacas.SelectedIndex = 0; // Seleciona a primeira raça por padrão
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erro de conexão com a API de gatos. Verifique sua chave de API ou conexão de internet: {httpEx.Message}", "Erro de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar raças: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparDetalhesRaca()
        {
            txtNomeRaca.Text = "";
            txtOrigem.Text = "";
            txtTemperamento.Text = "";
            txtPelo.Text = ""; // Ou txtTamanhoPelo.Text
            txtCuidados.Text = "";
            pbRacaImagem.Image = null; // Limpa a imagem
            _racaAtualExibida = null; // Reseta a raça atualmente exibida
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxRacas.SelectedItem is RacaGato racaSelecionada)
            {
                _racaAtualExibida = racaSelecionada; // Armazena a raça selecionada
                ExibirDetalhesRaca(racaSelecionada);

                // Tenta carregar a imagem da raça
                try
                {
                    // Busca a URL da imagem usando o ID da raça
                    string imageUrl = await _catApiService.GetImageUrlByBreedIdAsync(racaSelecionada.Id);
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pbRacaImagem.Image = Image.FromStream(ms);
                                pbRacaImagem.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta a imagem no PictureBox
                            }
                        }
                        // Opcional: Salvar a URL da imagem na propriedade da RacaGato
                        _racaAtualExibida.CaminhoImagem = imageUrl;
                    }
                    else
                    {
                        pbRacaImagem.Image = null; // Limpa se não encontrar imagem
                        MessageBox.Show("Não foi possível encontrar uma imagem para esta raça.", "Imagem não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    pbRacaImagem.Image = null;
                    MessageBox.Show($"Erro de conexão ao carregar imagem: {httpEx.Message}. Verifique sua conexão.", "Erro de Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    pbRacaImagem.Image = null;
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}", "Erro de Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma raça para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExibirDetalhesRaca(RacaGato raca)
        {
            txtNomeRaca.Text = raca.Nome;
            txtOrigem.Text = raca.Origem;
            txtTemperamento.Text = raca.Temperamento;
            txtPelo.Text = raca.TamanhoPelo; // <<== Use o nome da sua propriedade de pelo
            txtCuidados.Text = raca.Cuidados; // <<== Use o nome da sua propriedade de cuidados
                                              // Imagem é carregada no btnBuscar_Click
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            if (_racaAtualExibida != null)
            {
                GerenciadorFavoritos.AdicionarFavorito(_racaAtualExibida);
                MessageBox.Show($"{_racaAtualExibida.Nome} adicionado aos seus favoritos!", "Favoritado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma raça para favoritar. Busque uma raça primeiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ====================================================================
        // NAVEGAÇÃO (Você já deve ter esses métodos em FormBuscaRacas.cs)
        // ====================================================================
        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 formHome = new Form1();
            formHome.Show();
            this.Hide();
        }

        private void btnBuscarRacas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na tela de busca de raças!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMeusFavoritos_Click(object sender, EventArgs e)
        {
            FormFavoritos formFavoritos = new FormFavoritos();
            formFavoritos.Show();
            this.Hide();
        }

        // ... (Outros métodos de evento, se houverem, como cbxRacas_SelectedIndexChanged)
    }
}

