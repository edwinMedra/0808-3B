namespace _0808_3B
{
    partial class Transacciones
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            boxCuenta = new TextBox();
            boxCVV = new TextBox();
            boxFecha = new TextBox();
            boxMonto = new TextBox();
            boxTarjeta = new TextBox();
            btnConfirmar = new Button();
            btnhistorial = new Button();
            btnCerrar = new Button();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnhistorial);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(boxTarjeta);
            panel1.Controls.Add(boxMonto);
            panel1.Controls.Add(boxFecha);
            panel1.Controls.Add(boxCVV);
            panel1.Controls.Add(boxCuenta);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 566);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 66);
            label1.Name = "label1";
            label1.Size = new Size(173, 39);
            label1.TabIndex = 0;
            label1.Text = "Transacciones";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label2.Location = new Point(171, 174);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 1;
            label2.Text = "Numero de Cuenta:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label3.Location = new Point(171, 224);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "N° de Tarjeta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label4.Location = new Point(171, 363);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 3;
            label4.Text = "Monto a Transferir:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label5.Location = new Point(171, 266);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 4;
            label5.Text = "CVV:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label6.Location = new Point(171, 316);
            label6.Name = "label6";
            label6.Size = new Size(154, 23);
            label6.TabIndex = 5;
            label6.Text = "Fecha de vencimiento:";
            label6.Click += label6_Click;
            // 
            // boxCuenta
            // 
            boxCuenta.Location = new Point(358, 174);
            boxCuenta.Name = "boxCuenta";
            boxCuenta.Size = new Size(213, 23);
            boxCuenta.TabIndex = 6;
            // 
            // boxCVV
            // 
            boxCVV.Location = new Point(358, 266);
            boxCVV.Name = "boxCVV";
            boxCVV.Size = new Size(213, 23);
            boxCVV.TabIndex = 7;
            // 
            // boxFecha
            // 
            boxFecha.Location = new Point(358, 316);
            boxFecha.Name = "boxFecha";
            boxFecha.Size = new Size(213, 23);
            boxFecha.TabIndex = 8;
            // 
            // boxMonto
            // 
            boxMonto.Location = new Point(358, 363);
            boxMonto.Name = "boxMonto";
            boxMonto.Size = new Size(213, 23);
            boxMonto.TabIndex = 9;
            boxMonto.TextChanged += textBox4_TextChanged;
            // 
            // boxTarjeta
            // 
            boxTarjeta.Location = new Point(358, 224);
            boxTarjeta.Name = "boxTarjeta";
            boxTarjeta.Size = new Size(213, 23);
            boxTarjeta.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(290, 429);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(161, 41);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnhistorial
            // 
            btnhistorial.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhistorial.Location = new Point(666, 54);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.Size = new Size(116, 34);
            btnhistorial.TabIndex = 12;
            btnhistorial.Text = "Ver Historial";
            btnhistorial.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(667, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(115, 34);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(19, 14);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(81, 34);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // Transacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 589);
            Controls.Add(panel1);
            Name = "Transacciones";
            Text = "Transacciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox boxTarjeta;
        private TextBox boxMonto;
        private TextBox boxFecha;
        private TextBox boxCVV;
        private TextBox boxCuenta;
        private Button btnConfirmar;
        private Button btnCerrar;
        private Button btnhistorial;
        private Button btnRegresar;
    }
}