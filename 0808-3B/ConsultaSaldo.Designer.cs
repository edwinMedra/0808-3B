namespace _0808_3B
{
    partial class ConsultaSaldo
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
            label_consulta = new Label();
            label_nombre = new Label();
            label_apellido = new Label();
            label_tarjeta = new Label();
            label_CVV = new Label();
            label_fecha = new Label();
            button_consulta = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button_salir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(button_salir);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button_consulta);
            panel1.Controls.Add(label_fecha);
            panel1.Controls.Add(label_CVV);
            panel1.Controls.Add(label_tarjeta);
            panel1.Controls.Add(label_apellido);
            panel1.Controls.Add(label_nombre);
            panel1.Controls.Add(label_consulta);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 519);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label_consulta
            // 
            label_consulta.AutoSize = true;
            label_consulta.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_consulta.Location = new Point(254, 75);
            label_consulta.Name = "label_consulta";
            label_consulta.Size = new Size(236, 35);
            label_consulta.TabIndex = 0;
            label_consulta.Text = "Consulta tu saldo";
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nombre.Location = new Point(145, 167);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(81, 28);
            label_nombre.TabIndex = 1;
            label_nombre.Text = "Nombre :";
            // 
            // label_apellido
            // 
            label_apellido.AutoSize = true;
            label_apellido.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_apellido.Location = new Point(145, 208);
            label_apellido.Name = "label_apellido";
            label_apellido.Size = new Size(79, 28);
            label_apellido.TabIndex = 2;
            label_apellido.Text = "Apellido :";
            // 
            // label_tarjeta
            // 
            label_tarjeta.AutoSize = true;
            label_tarjeta.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_tarjeta.Location = new Point(145, 250);
            label_tarjeta.Name = "label_tarjeta";
            label_tarjeta.Size = new Size(112, 28);
            label_tarjeta.TabIndex = 3;
            label_tarjeta.Text = "N° de tarjeta :";
            // 
            // label_CVV
            // 
            label_CVV.AutoSize = true;
            label_CVV.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_CVV.Location = new Point(145, 291);
            label_CVV.Name = "label_CVV";
            label_CVV.Size = new Size(51, 28);
            label_CVV.TabIndex = 4;
            label_CVV.Text = "CVV :";
            // 
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fecha.Location = new Point(145, 331);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(178, 28);
            label_fecha.TabIndex = 5;
            label_fecha.Text = "Fecha de vencimiento :";
            label_fecha.Click += label5_Click;
            // 
            // button_consulta
            // 
            button_consulta.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_consulta.Location = new Point(301, 393);
            button_consulta.Name = "button_consulta";
            button_consulta.Size = new Size(150, 40);
            button_consulta.TabIndex = 6;
            button_consulta.Text = "Consultar";
            button_consulta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(341, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(341, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 336);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(257, 23);
            textBox5.TabIndex = 11;
            // 
            // button_salir
            // 
            button_salir.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_salir.Location = new Point(23, 20);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(70, 27);
            button_salir.TabIndex = 12;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            // 
            // ConsultaSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 543);
            Controls.Add(panel1);
            Name = "ConsultaSaldo";
            Text = "ConsultaSaldo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_CVV;
        private Label label_tarjeta;
        private Label label_apellido;
        private Label label_nombre;
        private Label label_consulta;
        private Label label_fecha;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button_consulta;
        private Button button_salir;
    }
}