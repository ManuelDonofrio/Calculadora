using Entidades;
namespace FrmCalculadora

{
    partial class FrmCalculadora
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
            btnLimpiar = new Button();
            btnOperar = new Button();
            btnCerrar = new Button();
            cmbOperacion = new ComboBox();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            groupBox1 = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(317, 408);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 30);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(44, 408);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(180, 30);
            btnOperar.TabIndex = 1;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(580, 408);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(180, 30);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(317, 334);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(180, 23);
            cmbOperacion.TabIndex = 3;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(44, 334);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(180, 23);
            txtPrimerOperador.TabIndex = 4;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(580, 334);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(180, 23);
            txtSegundoOperador.TabIndex = 5;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbBinario);
            groupBox1.Controls.Add(rdbDecimal);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(281, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 67);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            rdbBinario.Location = new Point(119, 28);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 17);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(19, 28);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(66, 17);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 307);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 7;
            label1.Text = "Primer operador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(580, 307);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 8;
            label2.Text = "Segundo operador:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(317, 306);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 9;
            label3.Text = "Operacion:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(49, 112);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(159, 37);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado: ";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(cmbOperacion);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Controls.Add(btnLimpiar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora de D'onofrio Puente Manuel";
            FormClosing += FrmCalculadora_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnOperar;
        private Button btnCerrar;
        private ComboBox cmbOperacion;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
    }
}