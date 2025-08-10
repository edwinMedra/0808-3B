namespace _0808_3B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label_Saldo = new Label();
            textBox_ImprimirSaldo = new TextBox();
            button1 = new Button();
            button_transferencias = new Button();
            button_créditos = new Button();
            label_opciones = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label_opciones);
            panel1.Controls.Add(button_créditos);
            panel1.Controls.Add(button_transferencias);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox_ImprimirSaldo);
            panel1.Controls.Add(label_Saldo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // label_Saldo
            // 
            label_Saldo.AutoSize = true;
            label_Saldo.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Saldo.Location = new Point(84, 120);
            label_Saldo.Name = "label_Saldo";
            label_Saldo.Size = new Size(254, 47);
            label_Saldo.TabIndex = 1;
            label_Saldo.Text = "Su saldo es ...";
            // 
            // textBox_ImprimirSaldo
            // 
            textBox_ImprimirSaldo.Location = new Point(377, 120);
            textBox_ImprimirSaldo.Multiline = true;
            textBox_ImprimirSaldo.Name = "textBox_ImprimirSaldo";
            textBox_ImprimirSaldo.Size = new Size(221, 47);
            textBox_ImprimirSaldo.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 21);
            button1.Name = "button1";
            button1.Size = new Size(72, 26);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_transferencias
            // 
            button_transferencias.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_transferencias.Location = new Point(221, 330);
            button_transferencias.Name = "button_transferencias";
            button_transferencias.Size = new Size(117, 35);
            button_transferencias.TabIndex = 4;
            button_transferencias.Text = "Transferencias";
            button_transferencias.UseVisualStyleBackColor = true;
            // 
            // button_créditos
            // 
            button_créditos.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_créditos.Location = new Point(443, 330);
            button_créditos.Name = "button_créditos";
            button_créditos.Size = new Size(117, 35);
            button_créditos.TabIndex = 5;
            button_créditos.Text = "Créditos";
            button_créditos.UseVisualStyleBackColor = true;
            // 
            // label_opciones
            // 
            label_opciones.AutoSize = true;
            label_opciones.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_opciones.Location = new Point(257, 276);
            label_opciones.Name = "label_opciones";
            label_opciones.Size = new Size(271, 23);
            label_opciones.TabIndex = 6;
            label_opciones.Text = "Puede realizar las siguientes operaciones :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_Saldo;
        private Button button1;
        private TextBox textBox_ImprimirSaldo;
        private Button button_créditos;
        private Button button_transferencias;
        private Label label_opciones;
    }
}
