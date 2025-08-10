namespace _0808_3B
{
    partial class Registro
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
            label_nombre = new Label();
            label_apellido = new Label();
            label_email = new Label();
            label_contraseña = new Label();
            label_confirmarcontra = new Label();
            label_registro = new Label();
            textBox_nombre = new TextBox();
            textBox_apellido = new TextBox();
            textBox_email = new TextBox();
            textBox_contraseña = new TextBox();
            textBox_confirmarcontra = new TextBox();
            button_registrar = new Button();
            linkLabel1 = new LinkLabel();
            panel_registro = new Panel();
            panel_registro.SuspendLayout();
            SuspendLayout();
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.BackColor = Color.LightBlue;
            label_nombre.Font = new Font("Sitka Banner", 14.2499981F);
            label_nombre.Location = new Point(95, 119);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(81, 28);
            label_nombre.TabIndex = 0;
            label_nombre.Text = "Nombre :";
            label_nombre.Click += label1_Click;
            // 
            // label_apellido
            // 
            label_apellido.AutoSize = true;
            label_apellido.BackColor = Color.LightBlue;
            label_apellido.Font = new Font("Sitka Banner", 14.2499981F);
            label_apellido.Location = new Point(95, 165);
            label_apellido.Name = "label_apellido";
            label_apellido.Size = new Size(79, 28);
            label_apellido.TabIndex = 1;
            label_apellido.Text = "Apellido :";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.BackColor = Color.LightBlue;
            label_email.Font = new Font("Sitka Banner", 14.2499981F);
            label_email.Location = new Point(95, 208);
            label_email.Name = "label_email";
            label_email.Size = new Size(63, 28);
            label_email.TabIndex = 2;
            label_email.Text = "Email :";
            // 
            // label_contraseña
            // 
            label_contraseña.AutoSize = true;
            label_contraseña.BackColor = Color.LightBlue;
            label_contraseña.Font = new Font("Sitka Banner", 14.2499981F);
            label_contraseña.Location = new Point(95, 254);
            label_contraseña.Name = "label_contraseña";
            label_contraseña.Size = new Size(104, 28);
            label_contraseña.TabIndex = 3;
            label_contraseña.Text = "Contraseña :";
            // 
            // label_confirmarcontra
            // 
            label_confirmarcontra.AutoSize = true;
            label_confirmarcontra.BackColor = Color.LightBlue;
            label_confirmarcontra.Font = new Font("Sitka Banner", 14.2499981F);
            label_confirmarcontra.Location = new Point(95, 299);
            label_confirmarcontra.Name = "label_confirmarcontra";
            label_confirmarcontra.Size = new Size(181, 28);
            label_confirmarcontra.TabIndex = 4;
            label_confirmarcontra.Text = "Confirmar contraseña :";
            label_confirmarcontra.Click += label5_Click;
            // 
            // label_registro
            // 
            label_registro.AutoSize = true;
            label_registro.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_registro.Location = new Point(241, 20);
            label_registro.Name = "label_registro";
            label_registro.Size = new Size(179, 42);
            label_registro.TabIndex = 5;
            label_registro.Text = "REGISTRO";
            label_registro.Click += label6_Click;
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(270, 114);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(280, 23);
            textBox_nombre.TabIndex = 6;
            textBox_nombre.TextChanged += textBox_nombre_TextChanged;
            // 
            // textBox_apellido
            // 
            textBox_apellido.Location = new Point(270, 158);
            textBox_apellido.Name = "textBox_apellido";
            textBox_apellido.Size = new Size(280, 23);
            textBox_apellido.TabIndex = 7;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(270, 201);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(280, 23);
            textBox_email.TabIndex = 8;
            // 
            // textBox_contraseña
            // 
            textBox_contraseña.Location = new Point(270, 247);
            textBox_contraseña.Name = "textBox_contraseña";
            textBox_contraseña.Size = new Size(280, 23);
            textBox_contraseña.TabIndex = 9;
            // 
            // textBox_confirmarcontra
            // 
            textBox_confirmarcontra.Location = new Point(282, 304);
            textBox_confirmarcontra.Name = "textBox_confirmarcontra";
            textBox_confirmarcontra.Size = new Size(280, 23);
            textBox_confirmarcontra.TabIndex = 10;
            // 
            // button_registrar
            // 
            button_registrar.BackColor = Color.Transparent;
            button_registrar.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_registrar.Location = new Point(256, 335);
            button_registrar.Name = "button_registrar";
            button_registrar.Size = new Size(121, 36);
            button_registrar.TabIndex = 11;
            button_registrar.Text = "REGISTRARSE";
            button_registrar.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(270, 381);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 23);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Iniciar Sesión";
            // 
            // panel_registro
            // 
            panel_registro.BackColor = Color.LightBlue;
            panel_registro.Controls.Add(linkLabel1);
            panel_registro.Controls.Add(textBox_contraseña);
            panel_registro.Controls.Add(label_registro);
            panel_registro.Controls.Add(textBox_email);
            panel_registro.Controls.Add(button_registrar);
            panel_registro.Controls.Add(textBox_apellido);
            panel_registro.Controls.Add(textBox_nombre);
            panel_registro.Location = new Point(12, 12);
            panel_registro.Name = "panel_registro";
            panel_registro.Size = new Size(636, 474);
            panel_registro.TabIndex = 13;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(660, 499);
            Controls.Add(textBox_confirmarcontra);
            Controls.Add(label_confirmarcontra);
            Controls.Add(label_contraseña);
            Controls.Add(label_email);
            Controls.Add(label_apellido);
            Controls.Add(label_nombre);
            Controls.Add(panel_registro);
            ForeColor = SystemColors.ControlText;
            Name = "Registro";
            Text = "Registro";
            panel_registro.ResumeLayout(false);
            panel_registro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nombre;
        private Label label_apellido;
        private Label label_email;
        private Label label_contraseña;
        private Label label_confirmarcontra;
        private Label label_registro;
        private TextBox textBox_nombre;
        private TextBox textBox_apellido;
        private TextBox textBox_email;
        private TextBox textBox_contraseña;
        private TextBox textBox_confirmarcontra;
        private Button button_registrar;
        private LinkLabel linkLabel1;
        private Panel panel_registro;
    }
}