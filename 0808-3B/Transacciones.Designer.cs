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
            txtDescri = new TextBox();
            label3 = new Label();
            txtNomDestinatario = new TextBox();
            label5 = new Label();
            lblSaldo = new Label();
            label7 = new Label();
            btnRegresar = new Button();
            btnCerrar = new Button();
            btnhistorial = new Button();
            btnConfirmar = new Button();
            txtMonto = new TextBox();
            txtNumCuenta = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtDescri);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNomDestinatario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblSaldo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnhistorial);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(txtNumCuenta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 566);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtDescri
            // 
            txtDescri.Location = new Point(358, 272);
            txtDescri.Name = "txtDescri";
            txtDescri.Size = new Size(213, 23);
            txtDescri.TabIndex = 22;
            txtDescri.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label3.Location = new Point(171, 272);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 21;
            label3.Text = "Descripción:";
            // 
            // txtNomDestinatario
            // 
            txtNomDestinatario.Location = new Point(358, 226);
            txtNomDestinatario.Name = "txtNomDestinatario";
            txtNomDestinatario.Size = new Size(213, 23);
            txtNomDestinatario.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label5.Location = new Point(171, 226);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 19;
            label5.Text = "Nombre de destinatario:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(412, 105);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(71, 30);
            lblSaldo.TabIndex = 16;
            lblSaldo.Text = "00.00";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(237, 105);
            label7.Name = "label7";
            label7.Size = new Size(179, 30);
            label7.TabIndex = 15;
            label7.Text = "Saldo disponible:";
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
            btnRegresar.Click += btnRegresar_Click;
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
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(290, 390);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(161, 41);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(358, 323);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(213, 23);
            txtMonto.TabIndex = 9;
            txtMonto.Text = "00.00";
            txtMonto.TextChanged += textBox4_TextChanged;
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.Location = new Point(358, 174);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(213, 23);
            txtNumCuenta.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label4.Location = new Point(171, 320);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 3;
            label4.Text = "Monto a Transferir:";
            label4.Click += label4_Click;
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
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtMonto;
        private TextBox txtNumCuenta;
        private Button btnConfirmar;
        private Button btnCerrar;
        private Button btnhistorial;
        private Button btnRegresar;
        private Label lblSaldo;
        private Label label7;
        private TextBox txtNomDestinatario;
        private Label label5;
        private TextBox txtDescri;
        private Label label3;
    }
}