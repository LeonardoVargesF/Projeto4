namespace Projeto4
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem,
            this.cadastroDeProfessoresToolStripMenuItem,
            this.cadastroDeCursosToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de Alunos";
            this.cadastroDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem_Click_1);
            // 
            // cadastroDeProfessoresToolStripMenuItem
            // 
            this.cadastroDeProfessoresToolStripMenuItem.Name = "cadastroDeProfessoresToolStripMenuItem";
            this.cadastroDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeProfessoresToolStripMenuItem.Text = "Cadastro de Professores";
            this.cadastroDeProfessoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProfessoresToolStripMenuItem_Click_1);
            // 
            // cadastroDeCursosToolStripMenuItem
            // 
            this.cadastroDeCursosToolStripMenuItem.Name = "cadastroDeCursosToolStripMenuItem";
            this.cadastroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastroDeCursosToolStripMenuItem.Text = "Cadastro de Cursos";
            this.cadastroDeCursosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCursosToolStripMenuItem_Click_1);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.alunosToolStripMenuItem.Text = "Relatório de Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(822, 565);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IFSP - Sistema de Gerenciamento Acadêmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProfessoresToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCursosToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
    }
}