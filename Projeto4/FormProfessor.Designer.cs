namespace Projeto4
{
    partial class FormProfessor
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
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataNasc = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtAreaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtExcluir = new ReaLTaiizor.Controls.MaterialButton();
            this.txtEditar = new ReaLTaiizor.Controls.MaterialButton();
            this.txtNovo = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(529, 499);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.txtDataNasc);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.cboTitulacao);
            this.tabPage1.Controls.Add(this.cboEstado);
            this.tabPage1.Controls.Add(this.txtAreaFormacao);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtMatricula);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "ID";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(307, 7);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(74, 48);
            this.txtId.TabIndex = 11;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.AllowPromptAsInput = true;
            this.txtDataNasc.AnimateReadOnly = false;
            this.txtDataNasc.AsciiOnly = false;
            this.txtDataNasc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataNasc.BeepOnError = false;
            this.txtDataNasc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataNasc.Depth = 0;
            this.txtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataNasc.HidePromptOnLeave = false;
            this.txtDataNasc.HideSelection = true;
            this.txtDataNasc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataNasc.LeadingIcon = null;
            this.txtDataNasc.Location = new System.Drawing.Point(194, 6);
            this.txtDataNasc.Mask = "99/99/9999";
            this.txtDataNasc.MaxLength = 32767;
            this.txtDataNasc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.PasswordChar = '\0';
            this.txtDataNasc.PrefixSuffixText = null;
            this.txtDataNasc.PromptChar = '_';
            this.txtDataNasc.ReadOnly = false;
            this.txtDataNasc.RejectInputOnFirstFailure = false;
            this.txtDataNasc.ResetOnPrompt = true;
            this.txtDataNasc.ResetOnSpace = true;
            this.txtDataNasc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataNasc.SelectedText = "";
            this.txtDataNasc.SelectionLength = 0;
            this.txtDataNasc.SelectionStart = 0;
            this.txtDataNasc.ShortcutsEnabled = true;
            this.txtDataNasc.Size = new System.Drawing.Size(105, 48);
            this.txtDataNasc.SkipLiterals = true;
            this.txtDataNasc.TabIndex = 10;
            this.txtDataNasc.TabStop = false;
            this.txtDataNasc.Text = "  /  /";
            this.txtDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataNasc.TrailingIcon = null;
            this.txtDataNasc.UseSystemPasswordChar = false;
            this.txtDataNasc.ValidatingType = null;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(307, 353);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(85, 36);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(194, 353);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(105, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboTitulacao
            // 
            this.cboTitulacao.AutoResize = false;
            this.cboTitulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTitulacao.Depth = 0;
            this.cboTitulacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTitulacao.DropDownHeight = 174;
            this.cboTitulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitulacao.DropDownWidth = 121;
            this.cboTitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTitulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTitulacao.FormattingEnabled = true;
            this.cboTitulacao.Hint = "Titulação";
            this.cboTitulacao.IntegralHeight = false;
            this.cboTitulacao.ItemHeight = 43;
            this.cboTitulacao.Items.AddRange(new object[] {
            "Graduação",
            "Especialização",
            "Mestrado",
            "Doutorado"});
            this.cboTitulacao.Location = new System.Drawing.Point(262, 277);
            this.cboTitulacao.MaxDropDownItems = 4;
            this.cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTitulacao.Name = "cboTitulacao";
            this.cboTitulacao.Size = new System.Drawing.Size(121, 49);
            this.cboTitulacao.StartIndex = 0;
            this.cboTitulacao.TabIndex = 7;
            // 
            // cboEstado
            // 
            this.cboEstado.AutoResize = false;
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEstado.Depth = 0;
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEstado.DropDownHeight = 174;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.DropDownWidth = 121;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Hint = "Estado";
            this.cboEstado.IntegralHeight = false;
            this.cboEstado.ItemHeight = 43;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(262, 222);
            this.cboEstado.MaxDropDownItems = 4;
            this.cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 49);
            this.cboEstado.StartIndex = 0;
            this.cboEstado.TabIndex = 6;
            // 
            // txtAreaFormacao
            // 
            this.txtAreaFormacao.AnimateReadOnly = false;
            this.txtAreaFormacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAreaFormacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAreaFormacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAreaFormacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAreaFormacao.Depth = 0;
            this.txtAreaFormacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAreaFormacao.HideSelection = true;
            this.txtAreaFormacao.Hint = "Área de Formação";
            this.txtAreaFormacao.LeadingIcon = null;
            this.txtAreaFormacao.Location = new System.Drawing.Point(6, 277);
            this.txtAreaFormacao.MaxLength = 32767;
            this.txtAreaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAreaFormacao.Name = "txtAreaFormacao";
            this.txtAreaFormacao.PasswordChar = '\0';
            this.txtAreaFormacao.PrefixSuffixText = null;
            this.txtAreaFormacao.ReadOnly = false;
            this.txtAreaFormacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAreaFormacao.SelectedText = "";
            this.txtAreaFormacao.SelectionLength = 0;
            this.txtAreaFormacao.SelectionStart = 0;
            this.txtAreaFormacao.ShortcutsEnabled = true;
            this.txtAreaFormacao.Size = new System.Drawing.Size(250, 48);
            this.txtAreaFormacao.TabIndex = 5;
            this.txtAreaFormacao.TabStop = false;
            this.txtAreaFormacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAreaFormacao.TrailingIcon = null;
            this.txtAreaFormacao.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.HideSelection = true;
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.Location = new System.Drawing.Point(6, 223);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.PrefixSuffixText = null;
            this.txtCidade.ReadOnly = false;
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(250, 48);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.TabStop = false;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.HideSelection = true;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.Location = new System.Drawing.Point(6, 169);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.PrefixSuffixText = null;
            this.txtBairro.ReadOnly = false;
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(377, 48);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.TabStop = false;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBairro.TrailingIcon = null;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AnimateReadOnly = false;
            this.txtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.HideSelection = true;
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(6, 115);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PrefixSuffixText = null;
            this.txtEndereco.ReadOnly = false;
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(377, 48);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.TrailingIcon = null;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(6, 61);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(377, 48);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.AnimateReadOnly = false;
            this.txtMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatricula.Depth = 0;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatricula.HideSelection = true;
            this.txtMatricula.Hint = "Matrícula";
            this.txtMatricula.LeadingIcon = null;
            this.txtMatricula.Location = new System.Drawing.Point(6, 7);
            this.txtMatricula.MaxLength = 32767;
            this.txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PasswordChar = '\0';
            this.txtMatricula.PrefixSuffixText = null;
            this.txtMatricula.ReadOnly = false;
            this.txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatricula.SelectedText = "";
            this.txtMatricula.SelectionLength = 0;
            this.txtMatricula.SelectionStart = 0;
            this.txtMatricula.ShortcutsEnabled = true;
            this.txtMatricula.Size = new System.Drawing.Size(182, 48);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TabStop = false;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatricula.TrailingIcon = null;
            this.txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtExcluir);
            this.tabPage2.Controls.Add(this.txtEditar);
            this.tabPage2.Controls.Add(this.txtNovo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // txtExcluir
            // 
            this.txtExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtExcluir.Depth = 0;
            this.txtExcluir.HighEmphasis = true;
            this.txtExcluir.Icon = null;
            this.txtExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.txtExcluir.Location = new System.Drawing.Point(425, 351);
            this.txtExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtExcluir.Size = new System.Drawing.Size(89, 36);
            this.txtExcluir.TabIndex = 3;
            this.txtExcluir.Text = "&Excluir";
            this.txtExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtExcluir.UseAccentColor = false;
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.txtExcluir_Click);
            // 
            // txtEditar
            // 
            this.txtEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtEditar.Depth = 0;
            this.txtEditar.HighEmphasis = true;
            this.txtEditar.Icon = null;
            this.txtEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.txtEditar.Location = new System.Drawing.Point(336, 351);
            this.txtEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtEditar.Size = new System.Drawing.Size(81, 36);
            this.txtEditar.TabIndex = 2;
            this.txtEditar.Text = "&Editar";
            this.txtEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtEditar.UseAccentColor = false;
            this.txtEditar.UseVisualStyleBackColor = true;
            this.txtEditar.Click += new System.EventHandler(this.txtEditar_Click);
            // 
            // txtNovo
            // 
            this.txtNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtNovo.Depth = 0;
            this.txtNovo.HighEmphasis = true;
            this.txtNovo.Icon = null;
            this.txtNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.txtNovo.Location = new System.Drawing.Point(257, 351);
            this.txtNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtNovo.Size = new System.Drawing.Size(71, 36);
            this.txtNovo.TabIndex = 1;
            this.txtNovo.Text = "&Novo";
            this.txtNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtNovo.UseAccentColor = false;
            this.txtNovo.UseVisualStyleBackColor = true;
            this.txtNovo.Click += new System.EventHandler(this.txtNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(515, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 566);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Professor";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAreaFormacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialComboBox cboTitulacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNasc;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialButton txtExcluir;
        private ReaLTaiizor.Controls.MaterialButton txtEditar;
        private ReaLTaiizor.Controls.MaterialButton txtNovo;
        private ImageList imageList1;
    }
}