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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessor));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataNasc = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            cboTitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtAreaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            txtExcluir = new ReaLTaiizor.Controls.MaterialButton();
            txtEditar = new ReaLTaiizor.Controls.MaterialButton();
            txtNovo = new ReaLTaiizor.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(457, 446);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtDataNasc);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(cboTitulacao);
            tabPage1.Controls.Add(cboEstado);
            tabPage1.Controls.Add(txtAreaFormacao);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtMatricula);
            tabPage1.ImageKey = "form.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(449, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(307, 7);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(74, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDataNasc
            // 
            txtDataNasc.AllowPromptAsInput = true;
            txtDataNasc.AnimateReadOnly = false;
            txtDataNasc.AsciiOnly = false;
            txtDataNasc.BackgroundImageLayout = ImageLayout.None;
            txtDataNasc.BeepOnError = false;
            txtDataNasc.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNasc.Depth = 0;
            txtDataNasc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNasc.HidePromptOnLeave = false;
            txtDataNasc.HideSelection = true;
            txtDataNasc.InsertKeyMode = InsertKeyMode.Default;
            txtDataNasc.LeadingIcon = null;
            txtDataNasc.Location = new Point(194, 6);
            txtDataNasc.Mask = "99/99/9999";
            txtDataNasc.MaxLength = 32767;
            txtDataNasc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.PasswordChar = '\0';
            txtDataNasc.PrefixSuffixText = null;
            txtDataNasc.PromptChar = '_';
            txtDataNasc.ReadOnly = false;
            txtDataNasc.RejectInputOnFirstFailure = false;
            txtDataNasc.ResetOnPrompt = true;
            txtDataNasc.ResetOnSpace = true;
            txtDataNasc.RightToLeft = RightToLeft.No;
            txtDataNasc.SelectedText = "";
            txtDataNasc.SelectionLength = 0;
            txtDataNasc.SelectionStart = 0;
            txtDataNasc.ShortcutsEnabled = true;
            txtDataNasc.Size = new Size(105, 48);
            txtDataNasc.SkipLiterals = true;
            txtDataNasc.TabIndex = 1;
            txtDataNasc.TabStop = false;
            txtDataNasc.Text = "  /  /";
            txtDataNasc.TextAlign = HorizontalAlignment.Left;
            txtDataNasc.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNasc.TrailingIcon = null;
            txtDataNasc.UseSystemPasswordChar = false;
            txtDataNasc.ValidatingType = null;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(307, 353);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(85, 36);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "&Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(194, 353);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
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
            cboTitulacao.Location = new Point(262, 277);
            cboTitulacao.MaxDropDownItems = 4;
            cboTitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTitulacao.Name = "cboTitulacao";
            cboTitulacao.Size = new Size(121, 49);
            cboTitulacao.StartIndex = 0;
            cboTitulacao.TabIndex = 8;
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
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(262, 222);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 6;
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
            txtAreaFormacao.Location = new Point(6, 277);
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
            txtAreaFormacao.Size = new Size(250, 48);
            txtAreaFormacao.TabIndex = 7;
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
            txtCidade.Location = new Point(6, 223);
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
            txtCidade.Size = new Size(250, 48);
            txtCidade.TabIndex = 5;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(6, 169);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(377, 48);
            txtBairro.TabIndex = 4;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(6, 115);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(377, 48);
            txtEndereco.TabIndex = 3;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 61);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(377, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(6, 7);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(182, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtExcluir);
            tabPage2.Controls.Add(txtEditar);
            tabPage2.Controls.Add(txtNovo);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.ImageKey = "search.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(449, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter_1;
            // 
            // txtExcluir
            // 
            txtExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtExcluir.Depth = 0;
            txtExcluir.HighEmphasis = true;
            txtExcluir.Icon = null;
            txtExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtExcluir.Location = new Point(344, 351);
            txtExcluir.Margin = new Padding(4, 6, 4, 6);
            txtExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtExcluir.Name = "txtExcluir";
            txtExcluir.NoAccentTextColor = Color.Empty;
            txtExcluir.Size = new Size(89, 36);
            txtExcluir.TabIndex = 3;
            txtExcluir.Text = "&Excluir";
            txtExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtExcluir.UseAccentColor = false;
            txtExcluir.UseVisualStyleBackColor = true;
            txtExcluir.Click += txtExcluir_Click_1;
            // 
            // txtEditar
            // 
            txtEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtEditar.Depth = 0;
            txtEditar.HighEmphasis = true;
            txtEditar.Icon = null;
            txtEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtEditar.Location = new Point(255, 351);
            txtEditar.Margin = new Padding(4, 6, 4, 6);
            txtEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtEditar.Name = "txtEditar";
            txtEditar.NoAccentTextColor = Color.Empty;
            txtEditar.Size = new Size(81, 36);
            txtEditar.TabIndex = 2;
            txtEditar.Text = "&Editar";
            txtEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtEditar.UseAccentColor = false;
            txtEditar.UseVisualStyleBackColor = true;
            txtEditar.Click += txtEditar_Click_1;
            // 
            // txtNovo
            // 
            txtNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtNovo.Depth = 0;
            txtNovo.HighEmphasis = true;
            txtNovo.Icon = null;
            txtNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtNovo.Location = new Point(176, 351);
            txtNovo.Margin = new Padding(4, 6, 4, 6);
            txtNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtNovo.Name = "txtNovo";
            txtNovo.NoAccentTextColor = Color.Empty;
            txtNovo.Size = new Size(71, 36);
            txtNovo.TabIndex = 1;
            txtNovo.Text = "&Novo";
            txtNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtNovo.UseAccentColor = false;
            txtNovo.UseVisualStyleBackColor = true;
            txtNovo.Click += txtNovo_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 339);
            dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 513);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FormProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Professor";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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