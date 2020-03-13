namespace Desafio11032020
{
    partial class Idade
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
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.TxtIdade = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechar.Location = new System.Drawing.Point(94, 55);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(40, 13);
            this.lblFechar.TabIndex = 5;
            this.lblFechar.Text = "Fechar";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(13, 9);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(0, 13);
            this.lblIdade.TabIndex = 4;
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(16, 25);
            this.TxtIdade.Mask = "000";
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(104, 20);
            this.TxtIdade.TabIndex = 3;
            this.TxtIdade.TextChanged += new System.EventHandler(this.TxtIdade_TextChanged);
            // 
            // Idade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 69);
            this.ControlBox = false;
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.TxtIdade);
            this.Name = "Idade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.MaskedTextBox TxtIdade;
    }
}