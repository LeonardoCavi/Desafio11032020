namespace Desafio11032020
{
    partial class Calculadora
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
            this.TxtCalculadora1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtCalculadora2 = new System.Windows.Forms.MaskedTextBox();
            this.LblValor1 = new System.Windows.Forms.Label();
            this.LblValor2 = new System.Windows.Forms.Label();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCalculadora1
            // 
            this.TxtCalculadora1.Location = new System.Drawing.Point(61, 6);
            this.TxtCalculadora1.Mask = "0000000000";
            this.TxtCalculadora1.Name = "TxtCalculadora1";
            this.TxtCalculadora1.Size = new System.Drawing.Size(125, 20);
            this.TxtCalculadora1.TabIndex = 0;
            // 
            // TxtCalculadora2
            // 
            this.TxtCalculadora2.Location = new System.Drawing.Point(61, 32);
            this.TxtCalculadora2.Mask = "0000000000";
            this.TxtCalculadora2.Name = "TxtCalculadora2";
            this.TxtCalculadora2.Size = new System.Drawing.Size(125, 20);
            this.TxtCalculadora2.TabIndex = 1;
            // 
            // LblValor1
            // 
            this.LblValor1.AutoSize = true;
            this.LblValor1.Location = new System.Drawing.Point(12, 9);
            this.LblValor1.Name = "LblValor1";
            this.LblValor1.Size = new System.Drawing.Size(43, 13);
            this.LblValor1.TabIndex = 2;
            this.LblValor1.Text = "Valor 1:";
            // 
            // LblValor2
            // 
            this.LblValor2.AutoSize = true;
            this.LblValor2.Location = new System.Drawing.Point(12, 35);
            this.LblValor2.Name = "LblValor2";
            this.LblValor2.Size = new System.Drawing.Size(43, 13);
            this.LblValor2.TabIndex = 3;
            this.LblValor2.Text = "Valor 2:";
            // 
            // BtnSoma
            // 
            this.BtnSoma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoma.Location = new System.Drawing.Point(12, 64);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(39, 39);
            this.BtnSoma.TabIndex = 4;
            this.BtnSoma.Text = "+";
            this.BtnSoma.UseVisualStyleBackColor = true;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(57, 64);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(39, 39);
            this.BtnSub.TabIndex = 5;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(102, 64);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(39, 39);
            this.BtnDiv.TabIndex = 6;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(147, 64);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(39, 39);
            this.BtnMult.TabIndex = 7;
            this.BtnMult.Text = "x";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(12, 116);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 13);
            this.LblResultado.TabIndex = 8;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechar.Location = new System.Drawing.Point(160, 157);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(40, 13);
            this.lblFechar.TabIndex = 9;
            this.lblFechar.Text = "Fechar";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 172);
            this.ControlBox = false;
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.LblValor2);
            this.Controls.Add(this.LblValor1);
            this.Controls.Add(this.TxtCalculadora2);
            this.Controls.Add(this.TxtCalculadora1);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtCalculadora1;
        private System.Windows.Forms.MaskedTextBox TxtCalculadora2;
        private System.Windows.Forms.Label LblValor1;
        private System.Windows.Forms.Label LblValor2;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label lblFechar;
    }
}