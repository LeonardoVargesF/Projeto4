namespace Projeto4
{
    partial class FormRelatorioCurso
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
            groupBox3 = new GroupBox();
            cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            groupBox2 = new GroupBox();
            cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox1 = new GroupBox();
            cboTipoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboImpressora);
            groupBox3.Location = new Point(17, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 91);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            cboImpressora.AutoResize = false;
            cboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            cboImpressora.Depth = 0;
            cboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            cboImpressora.DropDownHeight = 174;
            cboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImpressora.DropDownWidth = 121;
            cboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboImpressora.FormattingEnabled = true;
            cboImpressora.Hint = "Impressora";
            cboImpressora.IntegralHeight = false;
            cboImpressora.ItemHeight = 43;
            cboImpressora.Location = new Point(6, 22);
            cboImpressora.MaxDropDownItems = 4;
            cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboImpressora.Name = "cboImpressora";
            cboImpressora.Size = new Size(375, 49);
            cboImpressora.StartIndex = 0;
            cboImpressora.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(292, 374);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(112, 36);
            btnVisualizar.TabIndex = 8;
            btnVisualizar.Text = "&Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click_1;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnImprimir.Location = new Point(187, 374);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(97, 36);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "&Imprimir";
            btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboAgrupamento);
            groupBox2.Location = new Point(17, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 90);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agrupamento";
            // 
            // cboAgrupamento
            // 
            cboAgrupamento.AutoResize = false;
            cboAgrupamento.BackColor = Color.FromArgb(255, 255, 255);
            cboAgrupamento.Depth = 0;
            cboAgrupamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboAgrupamento.DropDownHeight = 174;
            cboAgrupamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgrupamento.DropDownWidth = 121;
            cboAgrupamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAgrupamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAgrupamento.FormattingEnabled = true;
            cboAgrupamento.Hint = "Agrupamento";
            cboAgrupamento.IntegralHeight = false;
            cboAgrupamento.ItemHeight = 43;
            cboAgrupamento.Items.AddRange(new object[] { "Nenhum", "Tipo de Curso", "Nome de Curso" });
            cboAgrupamento.Location = new Point(6, 22);
            cboAgrupamento.MaxDropDownItems = 4;
            cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAgrupamento.Name = "cboAgrupamento";
            cboAgrupamento.Size = new Size(375, 49);
            cboAgrupamento.StartIndex = 0;
            cboAgrupamento.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTipoCurso);
            groupBox1.Controls.Add(txtNomeCurso);
            groupBox1.Location = new Point(17, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 88);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cboTipoCurso
            // 
            cboTipoCurso.AutoResize = false;
            cboTipoCurso.BackColor = Color.FromArgb(255, 255, 255);
            cboTipoCurso.Depth = 0;
            cboTipoCurso.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipoCurso.DropDownHeight = 174;
            cboTipoCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCurso.DropDownWidth = 121;
            cboTipoCurso.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipoCurso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipoCurso.FormattingEnabled = true;
            cboTipoCurso.Hint = "Tipo do Curso";
            cboTipoCurso.IntegralHeight = false;
            cboTipoCurso.ItemHeight = 43;
            cboTipoCurso.Items.AddRange(new object[] { "", "Técnico", "Tecnólogo", "Bacharelado", "Licenciatura" });
            cboTipoCurso.Location = new Point(262, 22);
            cboTipoCurso.MaxDropDownItems = 4;
            cboTipoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipoCurso.Name = "cboTipoCurso";
            cboTipoCurso.Size = new Size(119, 49);
            cboTipoCurso.StartIndex = 0;
            cboTipoCurso.TabIndex = 1;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.AnimateReadOnly = false;
            txtNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCurso.BackgroundImageLayout = ImageLayout.None;
            txtNomeCurso.CharacterCasing = CharacterCasing.Normal;
            txtNomeCurso.Depth = 0;
            txtNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCurso.HideSelection = true;
            txtNomeCurso.Hint = "Nome do Curso";
            txtNomeCurso.LeadingIcon = null;
            txtNomeCurso.Location = new Point(6, 22);
            txtNomeCurso.MaxLength = 32767;
            txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.PasswordChar = '\0';
            txtNomeCurso.PrefixSuffixText = null;
            txtNomeCurso.ReadOnly = false;
            txtNomeCurso.RightToLeft = RightToLeft.No;
            txtNomeCurso.SelectedText = "";
            txtNomeCurso.SelectionLength = 0;
            txtNomeCurso.SelectionStart = 0;
            txtNomeCurso.ShortcutsEnabled = true;
            txtNomeCurso.Size = new Size(250, 48);
            txtNomeCurso.TabIndex = 2;
            txtNomeCurso.TabStop = false;
            txtNomeCurso.TextAlign = HorizontalAlignment.Left;
            txtNomeCurso.TrailingIcon = null;
            txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // FormRelatorioCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 437);
            Controls.Add(groupBox3);
            Controls.Add(btnVisualizar);
            Controls.Add(btnImprimir);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormRelatorioCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de Cursos";
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipoCurso;
    }
}