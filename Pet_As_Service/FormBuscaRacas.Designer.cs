using Pet_As_Service;
using System.Collections.Generic;

namespace Pet_As_Service
{
    partial class FormBuscaRacas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaRacas));
            this.btnMeusFavoritos = new System.Windows.Forms.Button();
            this.btnBuscarRacas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxRacas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pelo = new System.Windows.Forms.Label();
            this.btnFavoritar = new System.Windows.Forms.Button();
            this.txtNomeRaca = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtTemperamento = new System.Windows.Forms.TextBox();
            this.txtPelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuidados = new System.Windows.Forms.TextBox();
            this.pbRacaImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMeusFavoritos
            // 
            this.btnMeusFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeusFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusFavoritos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMeusFavoritos.Location = new System.Drawing.Point(557, 44);
            this.btnMeusFavoritos.Name = "btnMeusFavoritos";
            this.btnMeusFavoritos.Size = new System.Drawing.Size(134, 29);
            this.btnMeusFavoritos.TabIndex = 6;
            this.btnMeusFavoritos.Text = "Meus Favoritos";
            this.btnMeusFavoritos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarRacas
            // 
            this.btnBuscarRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRacas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarRacas.Location = new System.Drawing.Point(391, 44);
            this.btnBuscarRacas.Name = "btnBuscarRacas";
            this.btnBuscarRacas.Size = new System.Drawing.Size(134, 29);
            this.btnBuscarRacas.TabIndex = 5;
            this.btnBuscarRacas.Text = "Buscar Raças";
            this.btnBuscarRacas.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHome.Location = new System.Drawing.Point(220, 44);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 29);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(242, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual raça te encanta hoje?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnMeusFavoritos);
            this.panel1.Controls.Add(this.btnBuscarRacas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 84);
            this.panel1.TabIndex = 3;
            // 
            // cbxRacas
            // 
            this.cbxRacas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRacas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRacas.FormattingEnabled = true;
            this.cbxRacas.Location = new System.Drawing.Point(367, 179);
            this.cbxRacas.Name = "cbxRacas";
            this.cbxRacas.Size = new System.Drawing.Size(181, 21);
            this.cbxRacas.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(559, 178);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar Raça";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome da Raça: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalhes da Raça";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome da Raça: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Origem:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Temperamento:";
            // 
            // Pelo
            // 
            this.Pelo.AutoSize = true;
            this.Pelo.Location = new System.Drawing.Point(283, 429);
            this.Pelo.Name = "Pelo";
            this.Pelo.Size = new System.Drawing.Size(34, 13);
            this.Pelo.TabIndex = 12;
            this.Pelo.Text = "Pelo: ";
            this.Pelo.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.Location = new System.Drawing.Point(284, 503);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(75, 23);
            this.btnFavoritar.TabIndex = 13;
            this.btnFavoritar.Text = "Favoritar";
            this.btnFavoritar.UseVisualStyleBackColor = true;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // txtNomeRaca
            // 
            this.txtNomeRaca.Location = new System.Drawing.Point(364, 295);
            this.txtNomeRaca.Name = "txtNomeRaca";
            this.txtNomeRaca.ReadOnly = true;
            this.txtNomeRaca.Size = new System.Drawing.Size(100, 20);
            this.txtNomeRaca.TabIndex = 15;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(332, 328);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.ReadOnly = true;
            this.txtOrigem.Size = new System.Drawing.Size(134, 20);
            this.txtOrigem.TabIndex = 16;
            // 
            // txtTemperamento
            // 
            this.txtTemperamento.Location = new System.Drawing.Point(366, 358);
            this.txtTemperamento.Multiline = true;
            this.txtTemperamento.Name = "txtTemperamento";
            this.txtTemperamento.ReadOnly = true;
            this.txtTemperamento.Size = new System.Drawing.Size(100, 65);
            this.txtTemperamento.TabIndex = 17;
            // 
            // txtPelo
            // 
            this.txtPelo.Location = new System.Drawing.Point(342, 429);
            this.txtPelo.Name = "txtPelo";
            this.txtPelo.ReadOnly = true;
            this.txtPelo.Size = new System.Drawing.Size(122, 20);
            this.txtPelo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cuidados:";
            // 
            // txtCuidados
            // 
            this.txtCuidados.Location = new System.Drawing.Point(344, 459);
            this.txtCuidados.Name = "txtCuidados";
            this.txtCuidados.ReadOnly = true;
            this.txtCuidados.Size = new System.Drawing.Size(122, 20);
            this.txtCuidados.TabIndex = 20;
            // 
            // pbRacaImagem
            // 
            this.pbRacaImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbRacaImagem.Location = new System.Drawing.Point(485, 256);
            this.pbRacaImagem.Name = "pbRacaImagem";
            this.pbRacaImagem.Size = new System.Drawing.Size(206, 223);
            this.pbRacaImagem.TabIndex = 14;
            this.pbRacaImagem.TabStop = false;
            // 
            // FormBuscaRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.txtCuidados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPelo);
            this.Controls.Add(this.txtTemperamento);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.txtNomeRaca);
            this.Controls.Add(this.pbRacaImagem);
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.Pelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxRacas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscaRacas";
            this.Text = "FormBuscaRacas";
            this.Load += new System.EventHandler(this.FormBuscaRacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeusFavoritos;
        private System.Windows.Forms.Button btnBuscarRacas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxRacas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Pelo;
        private System.Windows.Forms.Button btnFavoritar;
        private System.Windows.Forms.TextBox txtNomeRaca;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtTemperamento;
        private System.Windows.Forms.TextBox txtPelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCuidados;
        private System.Windows.Forms.PictureBox pbRacaImagem;
    }
}





