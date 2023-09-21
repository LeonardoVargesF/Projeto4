namespace Projeto4
{
    partial class FormRelatorioProfessor
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
            groupBox1 = new GroupBox();
            cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtAreaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox3 = new GroupBox();
            cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTitulacao);
            groupBox1.Controls.Add(txtAreaFormacao);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(cboEstado);
            groupBox1.Location = new Point(16, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cboTitulacao
            // 
            cboTitulacao.AutoResize = false;
            cboTitulacao.BackColor = Color.FromArgb(255, 255, 255);
            cboTitulacao.Depth = 0;
            cboTitulacao.DrawMode = DrawMode.OwnerDrawVariable;
            cboTitulacao.DropDownHeight = 174;
            cboTitulacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitulacao.DropDownWidth = 121;
            cboTitulacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTitulacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTitulacao.FormattingEnabled = true;
            cboTitulacao.Hint = "Titulação";
            cboTitulacao.IntegralHeight = false;
            cboTitulacao.ItemHeight = 43;
            cboTitulacao.Items.AddRange(new object[] { "", "Graduação", "Especialização", "Mestrado", "Doutorado" });
            cboTitulacao.Location = new Point(272, 76);
            cboTitulacao.MaxDropDownItems = 4;
            cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTitulacao.Name = "cboTitulacao";
            cboTitulacao.Size = new Size(116, 49);
            cboTitulacao.StartIndex = 0;
            cboTitulacao.TabIndex = 4;
            // 
            // txtAreaFormacao
            // 
            txtAreaFormacao.AnimateReadOnly = false;
            txtAreaFormacao.AutoCompleteMode = AutoCompleteMode.None;
            txtAreaFormacao.AutoCompleteSource = AutoCompleteSource.None;
            txtAreaFormacao.BackgroundImageLayout = ImageLayout.None;
            txtAreaFormacao.CharacterCasing = CharacterCasing.Normal;
            txtAreaFormacao.Depth = 0;
            txtAreaFormacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAreaFormacao.HideSelection = true;
            txtAreaFormacao.Hint = "Área de Formação";
            txtAreaFormacao.LeadingIcon = null;
            txtAreaFormacao.Location = new Point(6, 76);
            txtAreaFormacao.MaxLength = 32767;
            txtAreaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAreaFormacao.Name = "txtAreaFormacao";
            txtAreaFormacao.PasswordChar = '\0';
            txtAreaFormacao.PrefixSuffixText = null;
            txtAreaFormacao.ReadOnly = false;
            txtAreaFormacao.RightToLeft = RightToLeft.No;
            txtAreaFormacao.SelectedText = "";
            txtAreaFormacao.SelectionLength = 0;
            txtAreaFormacao.SelectionStart = 0;
            txtAreaFormacao.ShortcutsEnabled = true;
            txtAreaFormacao.Size = new Size(260, 48);
            txtAreaFormacao.TabIndex = 3;
            txtAreaFormacao.TabStop = false;
            txtAreaFormacao.TextAlign = HorizontalAlignment.Left;
            txtAreaFormacao.TrailingIcon = null;
            txtAreaFormacao.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(6, 22);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(260, 48);
            txtCidade.TabIndex = 2;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(272, 21);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(116, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboAgrupamento);
            groupBox2.Location = new Point(16, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 92);
            groupBox2.TabIndex = 1;
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
            cboAgrupamento.Items.AddRange(new object[] { "Nenhum", "Cidade", "Estado", "Titulação", "Area de Formação" });
            cboAgrupamento.Location = new Point(6, 22);
            cboAgrupamento.MaxDropDownItems = 4;
            cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAgrupamento.Name = "cboAgrupamento";
            cboAgrupamento.Size = new Size(382, 49);
            cboAgrupamento.StartIndex = 0;
            cboAgrupamento.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboImpressora);
            groupBox3.Location = new Point(16, 318);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 85);
            groupBox3.TabIndex = 1;
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
            cboImpressora.Size = new Size(382, 49);
            cboImpressora.StartIndex = 0;
            cboImpressora.TabIndex = 1;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnImprimir.Location = new Point(193, 412);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(97, 36);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "&Imprimir";
            btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(298, 412);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(112, 36);
            btnVisualizar.TabIndex = 3;
            btnVisualizar.Text = "&Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click_1;
            // 
            // FormRelatorioProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 473);
            Controls.Add(btnVisualizar);
            Controls.Add(btnImprimir);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormRelatorioProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de Professor";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAreaFormacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboTitulacao;
    }
}