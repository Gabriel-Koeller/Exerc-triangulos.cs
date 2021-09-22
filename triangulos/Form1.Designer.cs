
namespace triangulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lado1 = new System.Windows.Forms.TextBox();
            this.lado2 = new System.Windows.Forms.TextBox();
            this.lado3 = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado 3";
            // 
            // lado1
            // 
            this.lado1.Location = new System.Drawing.Point(34, 75);
            this.lado1.Name = "lado1";
            this.lado1.Size = new System.Drawing.Size(201, 23);
            this.lado1.TabIndex = 3;
            this.lado1.TextChanged += new System.EventHandler(this.lado1_TextChanged);
            // 
            // lado2
            // 
            this.lado2.Location = new System.Drawing.Point(34, 125);
            this.lado2.Name = "lado2";
            this.lado2.Size = new System.Drawing.Size(201, 23);
            this.lado2.TabIndex = 4;
            // 
            // lado3
            // 
            this.lado3.Location = new System.Drawing.Point(34, 179);
            this.lado3.Name = "lado3";
            this.lado3.Size = new System.Drawing.Size(201, 23);
            this.lado3.TabIndex = 5;
            // 
            // verificar
            // 
            this.verificar.BackColor = System.Drawing.Color.MintCream;
            this.verificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verificar.Location = new System.Drawing.Point(34, 223);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(201, 34);
            this.verificar.TabIndex = 6;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = false;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // resposta
            // 
            this.resposta.AutoSize = true;
            this.resposta.BackColor = System.Drawing.Color.Linen;
            this.resposta.Location = new System.Drawing.Point(34, 278);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(54, 15);
            this.resposta.TabIndex = 7;
            this.resposta.Text = "Resposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 398);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.lado3);
            this.Controls.Add(this.lado2);
            this.Controls.Add(this.lado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lado1;
        private System.Windows.Forms.TextBox lado2;
        private System.Windows.Forms.TextBox lado3;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Label resposta;
    }
}

