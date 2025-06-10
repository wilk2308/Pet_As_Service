namespace Pet_As_Service
{
    partial class FormFavoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFavoritos));
            this.btnMeusFavoritos = new System.Windows.Forms.Button();
            this.btnBuscarRacas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxFavoritos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btnHome.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(263, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sua lista VIP de gatinhos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // lbxFavoritos
            // 
            this.lbxFavoritos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxFavoritos.FormattingEnabled = true;
            this.lbxFavoritos.Location = new System.Drawing.Point(0, 84);
            this.lbxFavoritos.Name = "lbxFavoritos";
            this.lbxFavoritos.Size = new System.Drawing.Size(884, 527);
            this.lbxFavoritos.TabIndex = 4;
            // 
            // FormFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.lbxFavoritos);
            this.Controls.Add(this.panel1);
            this.Name = "FormFavoritos";
            this.Text = "FormFavoritos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMeusFavoritos;
        private System.Windows.Forms.Button btnBuscarRacas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxFavoritos;
    }
}