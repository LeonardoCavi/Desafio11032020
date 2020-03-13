namespace Desafio11032020
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnParImpar = new System.Windows.Forms.Button();
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.BtnIdade = new System.Windows.Forms.Button();
            this.BtnTxt = new System.Windows.Forms.Button();
            this.BtnIMC = new System.Windows.Forms.Button();
            this.lblfechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnParImpar
            // 
            this.BtnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParImpar.Location = new System.Drawing.Point(12, 12);
            this.BtnParImpar.Name = "BtnParImpar";
            this.BtnParImpar.Size = new System.Drawing.Size(129, 44);
            this.BtnParImpar.TabIndex = 0;
            this.BtnParImpar.Text = "1. PAR OU IMPAR";
            this.BtnParImpar.UseVisualStyleBackColor = true;
            this.BtnParImpar.Click += new System.EventHandler(this.BtnParImpar_Click);
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculadora.Location = new System.Drawing.Point(13, 62);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Size = new System.Drawing.Size(129, 44);
            this.BtnCalculadora.TabIndex = 1;
            this.BtnCalculadora.Text = "2. CALCULADORA";
            this.BtnCalculadora.UseVisualStyleBackColor = true;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // BtnIdade
            // 
            this.BtnIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIdade.Location = new System.Drawing.Point(13, 112);
            this.BtnIdade.Name = "BtnIdade";
            this.BtnIdade.Size = new System.Drawing.Size(129, 44);
            this.BtnIdade.TabIndex = 2;
            this.BtnIdade.Text = "3. IDADE";
            this.BtnIdade.UseVisualStyleBackColor = true;
            this.BtnIdade.Click += new System.EventHandler(this.BtnIdade_Click);
            // 
            // BtnTxt
            // 
            this.BtnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTxt.Location = new System.Drawing.Point(13, 162);
            this.BtnTxt.Name = "BtnTxt";
            this.BtnTxt.Size = new System.Drawing.Size(129, 44);
            this.BtnTxt.TabIndex = 3;
            this.BtnTxt.Text = "4. PERSISTÊNCIA TXT";
            this.BtnTxt.UseVisualStyleBackColor = true;
            this.BtnTxt.Click += new System.EventHandler(this.BtnTxt_Click);
            // 
            // BtnIMC
            // 
            this.BtnIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIMC.Location = new System.Drawing.Point(13, 212);
            this.BtnIMC.Name = "BtnIMC";
            this.BtnIMC.Size = new System.Drawing.Size(129, 44);
            this.BtnIMC.TabIndex = 4;
            this.BtnIMC.Text = "5. IMC";
            this.BtnIMC.UseVisualStyleBackColor = true;
            this.BtnIMC.Click += new System.EventHandler(this.BtnIMC_Click);
            // 
            // lblfechar
            // 
            this.lblfechar.AutoSize = true;
            this.lblfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechar.Location = new System.Drawing.Point(102, 266);
            this.lblfechar.Name = "lblfechar";
            this.lblfechar.Size = new System.Drawing.Size(40, 13);
            this.lblfechar.TabIndex = 10;
            this.lblfechar.Text = "Fechar";
            this.lblfechar.Click += new System.EventHandler(this.lblfechar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 288);
            this.ControlBox = false;
            this.Controls.Add(this.lblfechar);
            this.Controls.Add(this.BtnIMC);
            this.Controls.Add(this.BtnTxt);
            this.Controls.Add(this.BtnIdade);
            this.Controls.Add(this.BtnCalculadora);
            this.Controls.Add(this.BtnParImpar);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnParImpar;
        private System.Windows.Forms.Button BtnCalculadora;
        private System.Windows.Forms.Button BtnIdade;
        private System.Windows.Forms.Button BtnTxt;
        private System.Windows.Forms.Button BtnIMC;
        private System.Windows.Forms.Label lblfechar;
    }
}

