namespace Calculadora
{
    partial class Calculadora
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxvalor1 = new TextBox();
            tbxvalor2 = new TextBox();
            btnsumar = new Button();
            tbxresultado = new TextBox();
            label5 = new Label();
            btnrestar = new Button();
            btnmultiplicar = new Button();
            btndividir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 0;
            label1.Text = "Actividad Núcleo 3";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 34);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Calculadora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 2;
            label3.Text = "Valor 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 3;
            label4.Text = "Valor 2";
            // 
            // tbxvalor1
            // 
            tbxvalor1.BackColor = Color.White;
            tbxvalor1.BorderStyle = BorderStyle.None;
            tbxvalor1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxvalor1.ForeColor = SystemColors.ControlDarkDark;
            tbxvalor1.Location = new Point(97, 69);
            tbxvalor1.Name = "tbxvalor1";
            tbxvalor1.Size = new Size(176, 20);
            tbxvalor1.TabIndex = 4;
            tbxvalor1.TextChanged += tbxvalor1_TextChanged;
            // 
            // tbxvalor2
            // 
            tbxvalor2.BackColor = Color.White;
            tbxvalor2.BorderStyle = BorderStyle.None;
            tbxvalor2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxvalor2.ForeColor = SystemColors.ControlDarkDark;
            tbxvalor2.Location = new Point(97, 167);
            tbxvalor2.Name = "tbxvalor2";
            tbxvalor2.Size = new Size(176, 20);
            tbxvalor2.TabIndex = 5;
            tbxvalor2.TextChanged += tbxvalor2_TextChanged;
            // 
            // btnsumar
            // 
            btnsumar.BackColor = SystemColors.MenuHighlight;
            btnsumar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnsumar.ForeColor = SystemColors.ButtonHighlight;
            btnsumar.Location = new Point(303, 69);
            btnsumar.Name = "btnsumar";
            btnsumar.Size = new Size(136, 41);
            btnsumar.TabIndex = 6;
            btnsumar.Text = "SUMAR";
            btnsumar.UseVisualStyleBackColor = false;
            btnsumar.Click += btnsumar_Click;
            // 
            // tbxresultado
            // 
            tbxresultado.BackColor = Color.White;
            tbxresultado.BorderStyle = BorderStyle.None;
            tbxresultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxresultado.ForeColor = SystemColors.ControlDarkDark;
            tbxresultado.Location = new Point(97, 268);
            tbxresultado.Name = "tbxresultado";
            tbxresultado.Size = new Size(176, 20);
            tbxresultado.TabIndex = 7;
            tbxresultado.TextChanged += tbxresultado_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 274);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 8;
            label5.Text = "Resultado";
            // 
            // btnrestar
            // 
            btnrestar.BackColor = SystemColors.MenuHighlight;
            btnrestar.ForeColor = SystemColors.ButtonHighlight;
            btnrestar.Location = new Point(303, 129);
            btnrestar.Name = "btnrestar";
            btnrestar.Size = new Size(136, 37);
            btnrestar.TabIndex = 9;
            btnrestar.Text = "RESTAR";
            btnrestar.UseVisualStyleBackColor = false;
            btnrestar.Click += btnrestar_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.BackColor = SystemColors.MenuHighlight;
            btnmultiplicar.ForeColor = SystemColors.ButtonHighlight;
            btnmultiplicar.Location = new Point(303, 193);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(136, 36);
            btnmultiplicar.TabIndex = 10;
            btnmultiplicar.Text = "MULTIPLICAR";
            btnmultiplicar.UseVisualStyleBackColor = false;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btndividir
            // 
            btndividir.BackColor = SystemColors.MenuHighlight;
            btndividir.ForeColor = SystemColors.ButtonHighlight;
            btndividir.Location = new Point(303, 259);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(136, 36);
            btndividir.TabIndex = 11;
            btndividir.Text = "DIVIDIR";
            btndividir.UseVisualStyleBackColor = false;
            btndividir.Click += btndividir_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 335);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnrestar);
            Controls.Add(label5);
            Controls.Add(tbxresultado);
            Controls.Add(btnsumar);
            Controls.Add(tbxvalor2);
            Controls.Add(tbxvalor1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxvalor1;
        private TextBox tbxvalor2;
        private Button btnsumar;
        private TextBox tbxresultado;
        private Label label5;
        private Button btnrestar;
        private Button btnmultiplicar;
        private Button btndividir;
    }
}