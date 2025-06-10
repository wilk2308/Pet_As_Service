// Form1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Garanta que este using exista para que você possa acessar as outras Forms
using Pet_As_Service;

namespace Pet_As_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ====================================================================
        // LÓGICA DE NAVEGAÇÃO (Com os botões RENOMEADOS)
        // ====================================================================

        // Método para o botão "Home" (na própria tela Home)
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Como já estamos na tela Home, apenas informamos o usuário.
            MessageBox.Show("Você já está na tela inicial!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para o botão "Buscar Raças"
        private void btnBuscarRacas_Click(object sender, EventArgs e)
        {
            // Abre o formulário de busca de raças
            FormBuscaRacas formBuscaRacas = new FormBuscaRacas();
            formBuscaRacas.Show(); // Exibe o formulário
            this.Hide();           // Oculta o formulário atual (Form1)
        }

        // Método para o botão "Meus Favoritos"
        private void btnMeusFavoritos_Click(object sender, EventArgs e)
        {
            // Abre o formulário de favoritos
            FormFavoritos formFavoritos = new FormFavoritos();
            formFavoritos.Show(); // Exibe o formulário
            this.Hide();           // Oculta o formulário atual (Form1)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ====================================================================
        // MÉTODOS DE EVENTOS ANTIGOS/VAZIOS (VERIFIQUE SE AINDA PRECISA DELES)
        // REMOVA SE NÃO TIVER CÓDIGO ÚTIL DENTRO OU SE FORAM CLICKS ACIDENTAIS.
        // ====================================================================

        // private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        // private void Form1_Load(object sender, EventArgs e) { }
        // private void label1_Click(object sender, EventArgs e) { }
        // private void pictureBox1_Click(object sender, EventArgs e) { }

        // Se button1_Click e button2_Click eram os antigos botões de navegação,
        // eles foram substituídos por btnBuscarRacas_Click e btnMeusFavoritos_Click.
        // Você pode remover estes métodos se não tiverem mais nenhuma utilidade.
        // private void button1_Click(object sender, EventArgs e) { }
        // private void button2_Click(object sender, EventArgs e) { }
    }
}