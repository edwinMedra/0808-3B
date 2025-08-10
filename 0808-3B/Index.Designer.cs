namespace _0808_3B
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            panel_index = new Panel();
            label_descripción = new Label();
            label_frase = new Label();
            pictureBox_index = new PictureBox();
            button_creditos = new Button();
            button_consultarSaldo = new Button();
            button_transferencias = new Button();
            pictureBox_menu = new PictureBox();
            button_cerrarsesion = new Button();
            pictureBox_user = new PictureBox();
            panel_index.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_index).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).BeginInit();
            SuspendLayout();
            // 
            // panel_index
            // 
            panel_index.BackColor = Color.LightBlue;
            panel_index.Controls.Add(label_descripción);
            panel_index.Controls.Add(label_frase);
            panel_index.Controls.Add(pictureBox_index);
            panel_index.Controls.Add(button_creditos);
            panel_index.Controls.Add(button_consultarSaldo);
            panel_index.Controls.Add(button_transferencias);
            panel_index.Controls.Add(pictureBox_menu);
            panel_index.Controls.Add(button_cerrarsesion);
            panel_index.Controls.Add(pictureBox_user);
            panel_index.Location = new Point(12, 12);
            panel_index.Name = "panel_index";
            panel_index.Size = new Size(776, 636);
            panel_index.TabIndex = 0;
            // 
            // label_descripción
            // 
            label_descripción.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_descripción.ForeColor = SystemColors.ControlText;
            label_descripción.Location = new Point(214, 399);
            label_descripción.Name = "label_descripción";
            label_descripción.Size = new Size(501, 115);
            label_descripción.TabIndex = 8;
            label_descripción.Text = "Bienvenido a tu plataforma digital segura y fácil de usar que te permite consultar saldos, realizar transferencias, pagar servicios y gestionar tus finanzas desde cualquier lugar y en todo momento.";
            label_descripción.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_frase
            // 
            label_frase.AutoSize = true;
            label_frase.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_frase.ForeColor = SystemColors.ControlText;
            label_frase.Location = new Point(356, 375);
            label_frase.Name = "label_frase";
            label_frase.Size = new Size(252, 46);
            label_frase.TabIndex = 7;
            label_frase.Text = "\"Tu dinero, siempre contigo.\"\n\n";
            label_frase.Click += label1_Click;
            // 
            // pictureBox_index
            // 
            pictureBox_index.BackColor = Color.Transparent;
            pictureBox_index.Image = (Image)resources.GetObject("pictureBox_index.Image");
            pictureBox_index.InitialImage = null;
            pictureBox_index.Location = new Point(214, 81);
            pictureBox_index.Margin = new Padding(9);
            pictureBox_index.Name = "pictureBox_index";
            pictureBox_index.Size = new Size(501, 285);
            pictureBox_index.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_index.TabIndex = 6;
            pictureBox_index.TabStop = false;
            // 
            // button_creditos
            // 
            button_creditos.BackColor = Color.LightBlue;
            button_creditos.Font = new Font("Sitka Banner", 12F);
            button_creditos.ForeColor = SystemColors.ControlText;
            button_creditos.Location = new Point(24, 103);
            button_creditos.Name = "button_creditos";
            button_creditos.Size = new Size(139, 28);
            button_creditos.TabIndex = 5;
            button_creditos.Text = "Créditos";
            button_creditos.UseVisualStyleBackColor = false;
            // 
            // button_consultarSaldo
            // 
            button_consultarSaldo.BackColor = Color.LightBlue;
            button_consultarSaldo.Font = new Font("Sitka Banner", 12F);
            button_consultarSaldo.ForeColor = SystemColors.ControlText;
            button_consultarSaldo.Location = new Point(24, 81);
            button_consultarSaldo.Name = "button_consultarSaldo";
            button_consultarSaldo.Size = new Size(139, 28);
            button_consultarSaldo.TabIndex = 4;
            button_consultarSaldo.Text = "Consultar Saldo";
            button_consultarSaldo.UseVisualStyleBackColor = false;
            // 
            // button_transferencias
            // 
            button_transferencias.BackColor = Color.LightBlue;
            button_transferencias.Font = new Font("Sitka Banner", 12F);
            button_transferencias.ForeColor = SystemColors.ControlText;
            button_transferencias.Location = new Point(24, 55);
            button_transferencias.Name = "button_transferencias";
            button_transferencias.Size = new Size(139, 33);
            button_transferencias.TabIndex = 3;
            button_transferencias.Text = "Transferencias";
            button_transferencias.UseVisualStyleBackColor = false;
            button_transferencias.Click += button2_Click;
            // 
            // pictureBox_menu
            // 
            pictureBox_menu.BackColor = Color.Transparent;
            pictureBox_menu.Image = (Image)resources.GetObject("pictureBox_menu.Image");
            pictureBox_menu.InitialImage = null;
            pictureBox_menu.Location = new Point(24, 13);
            pictureBox_menu.Margin = new Padding(9);
            pictureBox_menu.Name = "pictureBox_menu";
            pictureBox_menu.Size = new Size(39, 36);
            pictureBox_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_menu.TabIndex = 2;
            pictureBox_menu.TabStop = false;
            // 
            // button_cerrarsesion
            // 
            button_cerrarsesion.BackColor = Color.LightBlue;
            button_cerrarsesion.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cerrarsesion.ForeColor = SystemColors.ControlText;
            button_cerrarsesion.Location = new Point(639, 15);
            button_cerrarsesion.Name = "button_cerrarsesion";
            button_cerrarsesion.Size = new Size(128, 29);
            button_cerrarsesion.TabIndex = 1;
            button_cerrarsesion.Text = "Cerrar Sesión";
            button_cerrarsesion.UseVisualStyleBackColor = false;
            // 
            // pictureBox_user
            // 
            pictureBox_user.BackColor = Color.Transparent;
            pictureBox_user.Image = (Image)resources.GetObject("pictureBox_user.Image");
            pictureBox_user.InitialImage = null;
            pictureBox_user.Location = new Point(593, 13);
            pictureBox_user.Margin = new Padding(9);
            pictureBox_user.Name = "pictureBox_user";
            pictureBox_user.Size = new Size(39, 36);
            pictureBox_user.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_user.TabIndex = 0;
            pictureBox_user.TabStop = false;
            pictureBox_user.Click += pictureBox1_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(panel_index);
            Name = "Index";
            Text = "Index";
            panel_index.ResumeLayout(false);
            panel_index.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_index).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_index;
        private PictureBox pictureBox_user;
        private Button button_cerrarsesion;
        private Button button_transferencias;
        private PictureBox pictureBox_menu;
        private Button button_consultarSaldo;
        private Button button_creditos;
        private PictureBox pictureBox_index;
        private Label label_frase;
        private Label label_descripción;
    }
}