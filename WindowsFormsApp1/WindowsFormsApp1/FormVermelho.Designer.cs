﻿namespace WindowsFormsApp1
{
    partial class FormVermelho
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirFormAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirFormAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirFormVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExibirFormAmarelo,
            this.ExibirFormAzul,
            this.ExibirFormVermelho});
            this.exibirToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // ExibirFormAmarelo
            // 
            this.ExibirFormAmarelo.Name = "ExibirFormAmarelo";
            this.ExibirFormAmarelo.Size = new System.Drawing.Size(180, 22);
            this.ExibirFormAmarelo.Text = "Form Amarelo";
            this.ExibirFormAmarelo.Click += new System.EventHandler(this.ExibirFormAmarelo_Click);
            // 
            // ExibirFormAzul
            // 
            this.ExibirFormAzul.Name = "ExibirFormAzul";
            this.ExibirFormAzul.Size = new System.Drawing.Size(180, 22);
            this.ExibirFormAzul.Text = "Form Azul";
            this.ExibirFormAzul.Click += new System.EventHandler(this.formAzulToolStripMenuItem_Click);
            // 
            // ExibirFormVermelho
            // 
            this.ExibirFormVermelho.Name = "ExibirFormVermelho";
            this.ExibirFormVermelho.Size = new System.Drawing.Size(180, 22);
            this.ExibirFormVermelho.Text = "Form Vermelho";
            this.ExibirFormVermelho.Click += new System.EventHandler(this.ExibirFormVermelho_Click);
            // 
            // FormVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormVermelho";
            this.Text = "FormVermelho";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExibirFormAmarelo;
        private System.Windows.Forms.ToolStripMenuItem ExibirFormAzul;
        private System.Windows.Forms.ToolStripMenuItem ExibirFormVermelho;
    }
}