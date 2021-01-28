
namespace Projeto_Hotel
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarQuartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarClientesToolStripMenuItem,
            this.gerenciarToolStripMenuItem,
            this.gerenciarQuartosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarClientesToolStripMenuItem
            // 
            this.gerenciarClientesToolStripMenuItem.Name = "gerenciarClientesToolStripMenuItem";
            this.gerenciarClientesToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.gerenciarClientesToolStripMenuItem.Text = "Gerenciar Clientes";
            this.gerenciarClientesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarClientesToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar Reservas";
            // 
            // gerenciarQuartosToolStripMenuItem
            // 
            this.gerenciarQuartosToolStripMenuItem.Name = "gerenciarQuartosToolStripMenuItem";
            this.gerenciarQuartosToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.gerenciarQuartosToolStripMenuItem.Text = "Gerenciar Quartos";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarQuartosToolStripMenuItem;
    }
}