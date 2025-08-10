namespace _0808_3B
{
    partial class indexDeslogeado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexDeslogeado));
            panel1 = new Panel();
            imgBanco = new Panel();
            textLogo = new Label();
            label1 = new Label();
            btnIniciar = new Button();
            btnRegistrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textLogo);
            panel1.Controls.Add(imgBanco);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 551);
            panel1.TabIndex = 0;
            // 
            // imgBanco
            // 
            imgBanco.BackgroundImage = (Image)resources.GetObject("imgBanco.BackgroundImage");
            imgBanco.Location = new Point(57, 85);
            imgBanco.Name = "imgBanco";
            imgBanco.Size = new Size(587, 360);
            imgBanco.TabIndex = 0;
            imgBanco.Paint += panel2_Paint;
            // 
            // textLogo
            // 
            textLogo.AutoSize = true;
            textLogo.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textLogo.Location = new Point(273, 460);
            textLogo.Name = "textLogo";
            textLogo.Size = new Size(185, 21);
            textLogo.TabIndex = 1;
            textLogo.Text = "\"Tu dinero siempre contigo.\"";
            textLogo.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 496);
            label1.Name = "label1";
            label1.Size = new Size(614, 19);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a tu banca digital segura, antes de continuar porfavor Inicia Sesión o registrate si no tienes una cuenta.";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold);
            btnIniciar.Location = new Point(682, 16);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(84, 36);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar Sesión ";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold);
            btnRegistrar.Location = new Point(583, 16);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(93, 36);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // indexDeslogeado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(panel1);
            Name = "indexDeslogeado";
            Text = "indexDeslogeado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel imgBanco;
        private Label textLogo;
        private Label label1;
        private Button btnRegistrar;
        private Button btnIniciar;
    }
}