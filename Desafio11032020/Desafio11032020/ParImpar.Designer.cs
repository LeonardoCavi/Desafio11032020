namespace Desafio11032020
{
    partial class ParImpar
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
            this.TxtParImpar = new System.Windows.Forms.MaskedTextBox();
            this.lblParImpar = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtParImpar
            // 
            this.TxtParImpar.Location = new System.Drawing.Point(15, 25);
            this.TxtParImpar.Mask = "0000000000";
            this.TxtParImpar.Name = "TxtParImpar";
            this.TxtParImpar.Size = new System.Drawing.Size(104, 20);
            this.TxtParImpar.TabIndex = 0;
            this.TxtParImpar.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // lblParImpar
            // 
            this.lblParImpar.AutoSize = true;
            this.lblParImpar.Location = new System.Drawing.Point(12, 9);
            this.lblParImpar.Name = "lblParImpar";
            this.lblParImpar.Size = new System.Drawing.Size(0, 13);
            this.lblParImpar.TabIndex = 1;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechar.Location = new System.Drawing.Point(93, 55);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(40, 13);
            this.lblFechar.TabIndex = 2;
            this.lblFechar.Text = "Fechar";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // ParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 69);
            this.ControlBox = false;
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.lblParImpar);
            this.Controls.Add(this.TxtParImpar);
            this.Name = "ParImpar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Par ou Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtParImpar;
        private System.Windows.Forms.Label lblParImpar;
        private System.Windows.Forms.Label lblFechar;
    }
}