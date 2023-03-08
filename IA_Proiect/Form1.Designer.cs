
namespace IA_Proiect
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
            this.textBoxEcuatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNrPopulatie = new System.Windows.Forms.TextBox();
            this.textBoxNrGeneratiilor = new System.Windows.Forms.TextBox();
            this.textBoxNrGene = new System.Windows.Forms.TextBox();
            this.Calculeaza = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxEcuatie
            // 
            this.textBoxEcuatie.BackColor = System.Drawing.Color.White;
            this.textBoxEcuatie.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEcuatie.ForeColor = System.Drawing.Color.Black;
            this.textBoxEcuatie.Location = new System.Drawing.Point(28, 200);
            this.textBoxEcuatie.Name = "textBoxEcuatie";
            this.textBoxEcuatie.Size = new System.Drawing.Size(455, 26);
            this.textBoxEcuatie.TabIndex = 1;
            this.textBoxEcuatie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezultat:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduceti Ecuatia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezolvarea Ecuatiilor de Gradul X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(524, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numarul Populatiei:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(524, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numarul Generatiilor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(524, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numarul de gene:";
            // 
            // textBoxNrPopulatie
            // 
            this.textBoxNrPopulatie.BackColor = System.Drawing.Color.White;
            this.textBoxNrPopulatie.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNrPopulatie.Location = new System.Drawing.Point(588, 200);
            this.textBoxNrPopulatie.Name = "textBoxNrPopulatie";
            this.textBoxNrPopulatie.Size = new System.Drawing.Size(91, 30);
            this.textBoxNrPopulatie.TabIndex = 11;
            this.textBoxNrPopulatie.TextChanged += new System.EventHandler(this.textBoxNrPopulatie_TextChanged);
            // 
            // textBoxNrGeneratiilor
            // 
            this.textBoxNrGeneratiilor.BackColor = System.Drawing.Color.White;
            this.textBoxNrGeneratiilor.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNrGeneratiilor.Location = new System.Drawing.Point(588, 333);
            this.textBoxNrGeneratiilor.Name = "textBoxNrGeneratiilor";
            this.textBoxNrGeneratiilor.Size = new System.Drawing.Size(91, 30);
            this.textBoxNrGeneratiilor.TabIndex = 12;
            // 
            // textBoxNrGene
            // 
            this.textBoxNrGene.BackColor = System.Drawing.Color.White;
            this.textBoxNrGene.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNrGene.Location = new System.Drawing.Point(588, 459);
            this.textBoxNrGene.Name = "textBoxNrGene";
            this.textBoxNrGene.Size = new System.Drawing.Size(91, 30);
            this.textBoxNrGene.TabIndex = 13;
            this.textBoxNrGene.TextChanged += new System.EventHandler(this.textBoxNrGene_TextChanged);
            // 
            // Calculeaza
            // 
            this.Calculeaza.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculeaza.Location = new System.Drawing.Point(148, 520);
            this.Calculeaza.Name = "Calculeaza";
            this.Calculeaza.Size = new System.Drawing.Size(174, 44);
            this.Calculeaza.TabIndex = 20;
            this.Calculeaza.Text = "Calculeaza";
            this.Calculeaza.UseVisualStyleBackColor = true;
            this.Calculeaza.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRezultat.Location = new System.Drawing.Point(28, 313);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(455, 176);
            this.textBoxRezultat.TabIndex = 21;
            this.textBoxRezultat.TextChanged += new System.EventHandler(this.textBoxRezultat_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(798, 590);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.Calculeaza);
            this.Controls.Add(this.textBoxNrGene);
            this.Controls.Add(this.textBoxNrGeneratiilor);
            this.Controls.Add(this.textBoxNrPopulatie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEcuatie);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "   Rezolvarea Ecuațiilor de Gradul X";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEcuatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNrPopulatie;
        private System.Windows.Forms.TextBox textBoxNrGeneratiilor;
        private System.Windows.Forms.TextBox textBoxNrGene;
        private System.Windows.Forms.Button Calculeaza;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}

