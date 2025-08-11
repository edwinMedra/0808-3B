namespace _0808_3B
{
    partial class Registro
    {
        // asisnar variables


        //





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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtConfirmarContra = new TextBox();
            btnRegistrar = new Button();
            linkLabel1 = new LinkLabel();
            panel_registro = new Panel();
            label1 = new Label();
            txtNumDui = new TextBox();
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
            label_contraseña.Location = new Point(83, 276);
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
            label_confirmarcontra.Location = new Point(83, 316);
            label_confirmarcontra.Name = "label_confirmarcontra";
            label_confirmarcontra.Size = new Size(181, 28);
            label_confirmarcontra.TabIndex = 4;
            label_confirmarcontra.Text = "Confirmar contraseña :";
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
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(270, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(270, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(280, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(270, 201);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(270, 276);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(280, 23);
            txtContrasena.TabIndex = 9;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(270, 321);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(280, 23);
            txtConfirmarContra.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(241, 376);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(121, 36);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRARSE";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(255, 422);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 23);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Iniciar Sesión";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel_registro
            // 
            panel_registro.BackColor = Color.LightBlue;
            panel_registro.Controls.Add(label1);
            panel_registro.Controls.Add(txtNumDui);
            panel_registro.Controls.Add(label_contraseña);
            panel_registro.Controls.Add(txtConfirmarContra);
            panel_registro.Controls.Add(label_confirmarcontra);
            panel_registro.Controls.Add(linkLabel1);
            panel_registro.Controls.Add(txtContrasena);
            panel_registro.Controls.Add(label_registro);
            panel_registro.Controls.Add(txtEmail);
            panel_registro.Controls.Add(btnRegistrar);
            panel_registro.Controls.Add(txtApellido);
            panel_registro.Controls.Add(txtNombre);
            panel_registro.Location = new Point(12, 12);
            panel_registro.Name = "panel_registro";
            panel_registro.Size = new Size(636, 474);
            panel_registro.TabIndex = 13;
            panel_registro.Paint += panel_registro_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Sitka Banner", 14.2499981F);
            label1.Location = new Point(83, 234);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 14;
            label1.Text = "Número de DUI:";
            // 
            // txtNumDui
            // 
            txtNumDui.Location = new Point(270, 239);
            txtNumDui.Name = "txtNumDui";
            txtNumDui.Size = new Size(280, 23);
            txtNumDui.TabIndex = 13;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(660, 499);
            Controls.Add(label_email);
            Controls.Add(label_apellido);
            Controls.Add(label_nombre);
            Controls.Add(panel_registro);
            ForeColor = SystemColors.ControlText;
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
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
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtConfirmarContra;
        private Button btnRegistrar;
        private LinkLabel linkLabel1;
        private Panel panel_registro;
        private Label label1;
        private TextBox txtNumDui;
    }
}