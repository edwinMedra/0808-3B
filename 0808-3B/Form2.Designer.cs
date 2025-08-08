namespace _0808_3B
{
    partial class Form2
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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            buttonIniciar = new Button();
            labelContra = new TextBox();
            labelUser = new TextBox();
            label2 = new Label();
            Contraseña = new Label();
            usuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(buttonIniciar);
            panel1.Controls.Add(labelContra);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Contraseña);
            panel1.Controls.Add(usuario);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 577);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(234, 449);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(74, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrase";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonIniciar
            // 
            buttonIniciar.BackColor = Color.LightGray;
            buttonIniciar.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonIniciar.Location = new Point(196, 407);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(153, 39);
            buttonIniciar.TabIndex = 5;
            buttonIniciar.Text = "Iniciar sesión";
            buttonIniciar.UseVisualStyleBackColor = false;
            buttonIniciar.Click += button1_Click;
            // 
            // labelContra
            // 
            labelContra.Location = new Point(180, 300);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(279, 23);
            labelContra.TabIndex = 4;
            // 
            // labelUser
            // 
            labelUser.Location = new Point(147, 212);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(312, 23);
            labelUser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 92);
            label2.Name = "label2";
            label2.Size = new Size(168, 42);
            label2.TabIndex = 2;
            label2.Text = "Iniciar Sesión";
            label2.Click += label2_Click;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contraseña.Location = new Point(62, 293);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(112, 30);
            Contraseña.TabIndex = 1;
            Contraseña.Text = "Contraseña:";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuario.Location = new Point(62, 205);
            usuario.Name = "usuario";
            usuario.Size = new Size(82, 30);
            usuario.TabIndex = 0;
            usuario.Text = "Usuario:";
            usuario.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 603);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label usuario;
        private Label Contraseña;
        private Label label2;
        private TextBox labelContra;
        private TextBox labelUser;
        private Button buttonIniciar;
        private LinkLabel linkLabel1;
    }
}