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
            button2 = new Button();
            button3 = new Button();
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Valor 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 3;
            label4.Text = "Valor 2";
            // 
            // tbxvalor1
            // 
            tbxvalor1.BackColor = Color.DodgerBlue;
            tbxvalor1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxvalor1.ForeColor = SystemColors.Window;
            tbxvalor1.Location = new Point(97, 69);
            tbxvalor1.Name = "tbxvalor1";
            tbxvalor1.Size = new Size(176, 27);
            tbxvalor1.TabIndex = 4;
            tbxvalor1.TextChanged += tbxvalor1_TextChanged;
            // 
            // tbxvalor2
            // 
            tbxvalor2.BackColor = Color.DodgerBlue;
            tbxvalor2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxvalor2.ForeColor = SystemColors.Window;
            tbxvalor2.Location = new Point(97, 167);
            tbxvalor2.Name = "tbxvalor2";
            tbxvalor2.Size = new Size(176, 27);
            tbxvalor2.TabIndex = 5;
            tbxvalor2.TextChanged += tbxvalor2_TextChanged;
            // 
            // btnsumar
            // 
            btnsumar.BackColor = Color.Yellow;
            btnsumar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            tbxresultado.BackColor = Color.DodgerBlue;
            tbxresultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxresultado.ForeColor = SystemColors.Window;
            tbxresultado.Location = new Point(97, 268);
            tbxresultado.Name = "tbxresultado";
            tbxresultado.Size = new Size(176, 27);
            tbxresultado.TabIndex = 7;
            tbxresultado.TextChanged += tbxresultado_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 274);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 8;
            label5.Text = "Resultado";
            // 
            // btnrestar
            // 
            btnrestar.Location = new Point(303, 129);
            btnrestar.Name = "btnrestar";
            btnrestar.Size = new Size(136, 37);
            btnrestar.TabIndex = 9;
            btnrestar.Text = "RESTAR";
            btnrestar.UseVisualStyleBackColor = true;
            btnrestar.Click += btnrestar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(303, 193);
            button2.Name = "button2";
            button2.Size = new Size(136, 36);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(303, 259);
            button3.Name = "button3";
            button3.Size = new Size(136, 36);
            button3.TabIndex = 11;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 335);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
    }
}