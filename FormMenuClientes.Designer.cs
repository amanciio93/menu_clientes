namespace menu_clientes
{
    partial class FormMenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGerarFicha = new System.Windows.Forms.Button();
            this.btGerarPDF = new System.Windows.Forms.Button();
            this.btEditarCliente = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchAtivo = new System.Windows.Forms.RadioButton();
            this.searchInativos = new System.Windows.Forms.RadioButton();
            this.searchAll = new System.Windows.Forms.RadioButton();
            this.searchNasc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchEstadoCivil = new System.Windows.Forms.ComboBox();
            this.searchGenero = new System.Windows.Forms.ComboBox();
            this.searchNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLocalizado = new System.Windows.Forms.Label();
            this.totalAtivos = new System.Windows.Forms.Label();
            this.totalInativos = new System.Windows.Forms.Label();
            this.nadaEncontrado = new System.Windows.Forms.Label();
            this.reportFicha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btGerarFicha);
            this.groupBox1.Controls.Add(this.btGerarPDF);
            this.groupBox1.Controls.Add(this.btEditarCliente);
            this.groupBox1.Controls.Add(this.btAddCliente);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btGerarFicha
            // 
            this.btGerarFicha.BackColor = System.Drawing.Color.Transparent;
            this.btGerarFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGerarFicha.Enabled = false;
            this.btGerarFicha.FlatAppearance.BorderSize = 0;
            this.btGerarFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerarFicha.Image = ((System.Drawing.Image)(resources.GetObject("btGerarFicha.Image")));
            this.btGerarFicha.Location = new System.Drawing.Point(188, 16);
            this.btGerarFicha.Name = "btGerarFicha";
            this.btGerarFicha.Size = new System.Drawing.Size(48, 48);
            this.btGerarFicha.TabIndex = 5;
            this.btGerarFicha.UseVisualStyleBackColor = false;
            this.btGerarFicha.Click += new System.EventHandler(this.btGerarFicha_Click);
            // 
            // btGerarPDF
            // 
            this.btGerarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btGerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGerarPDF.FlatAppearance.BorderSize = 0;
            this.btGerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btGerarPDF.Image")));
            this.btGerarPDF.Location = new System.Drawing.Point(128, 16);
            this.btGerarPDF.Name = "btGerarPDF";
            this.btGerarPDF.Size = new System.Drawing.Size(48, 48);
            this.btGerarPDF.TabIndex = 4;
            this.btGerarPDF.UseVisualStyleBackColor = false;
            // 
            // btEditarCliente
            // 
            this.btEditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarCliente.Enabled = false;
            this.btEditarCliente.FlatAppearance.BorderSize = 0;
            this.btEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btEditarCliente.Image")));
            this.btEditarCliente.Location = new System.Drawing.Point(68, 16);
            this.btEditarCliente.Name = "btEditarCliente";
            this.btEditarCliente.Size = new System.Drawing.Size(48, 48);
            this.btEditarCliente.TabIndex = 3;
            this.btEditarCliente.UseVisualStyleBackColor = false;
            this.btEditarCliente.Click += new System.EventHandler(this.btEditarCliente_Click);
            // 
            // btAddCliente
            // 
            this.btAddCliente.BackColor = System.Drawing.Color.Transparent;
            this.btAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddCliente.FlatAppearance.BorderSize = 0;
            this.btAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btAddCliente.Image")));
            this.btAddCliente.Location = new System.Drawing.Point(8, 16);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(48, 48);
            this.btAddCliente.TabIndex = 2;
            this.btAddCliente.UseVisualStyleBackColor = false;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            this.dgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgLista.BackgroundColor = System.Drawing.Color.White;
            this.dgLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgLista.ColumnHeadersHeight = 35;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.foto,
            this.nome,
            this.dt_nascimento,
            this.documento,
            this.rg,
            this.estado_civil,
            this.genero,
            this.celular,
            this.email,
            this.cidade,
            this.endereco,
            this.numero,
            this.bairro,
            this.cep,
            this.estado,
            this.observacoes,
            this.situacao});
            this.dgLista.EnableHeadersVisualStyles = false;
            this.dgLista.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgLista.Location = new System.Drawing.Point(12, 89);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersVisible = false;
            this.dgLista.RowHeadersWidth = 4;
            this.dgLista.RowTemplate.Height = 30;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(1240, 530);
            this.dgLista.TabIndex = 1;
            this.dgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellClick);
            this.dgLista.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseEnter);
            this.dgLista.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseLeave);
            this.dgLista.Sorted += new System.EventHandler(this.dgLista_Sorted);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle21;
            this.id.HeaderText = "N°";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 45;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do cliente";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 325;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.DataPropertyName = "dt_nascimento";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dt_nascimento.DefaultCellStyle = dataGridViewCellStyle22;
            this.dt_nascimento.HeaderText = "Nascimento";
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.documento.DefaultCellStyle = dataGridViewCellStyle23;
            this.documento.HeaderText = "CPF/CNPJ";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 155;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rg.DefaultCellStyle = dataGridViewCellStyle24;
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 114;
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.ReadOnly = true;
            this.estado_civil.Width = 145;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 90;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.celular.DefaultCellStyle = dataGridViewCellStyle25;
            this.celular.HeaderText = "N° Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 140;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 285;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 180;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 215;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numero.DefaultCellStyle = dataGridViewCellStyle26;
            this.numero.HeaderText = "N° Casa";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 52;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 210;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 90;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 165;
            // 
            // observacoes
            // 
            this.observacoes.DataPropertyName = "observacoes";
            this.observacoes.HeaderText = "Observações";
            this.observacoes.Name = "observacoes";
            this.observacoes.ReadOnly = true;
            this.observacoes.Width = 400;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.situacao.DefaultCellStyle = dataGridViewCellStyle27;
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchAtivo);
            this.groupBox2.Controls.Add(this.searchInativos);
            this.groupBox2.Controls.Add(this.searchAll);
            this.groupBox2.Controls.Add(this.searchNasc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.searchEndereco);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchEstadoCivil);
            this.groupBox2.Controls.Add(this.searchGenero);
            this.groupBox2.Controls.Add(this.searchNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.searchId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(271, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções de consulta";
            // 
            // searchAtivo
            // 
            this.searchAtivo.AutoSize = true;
            this.searchAtivo.BackColor = System.Drawing.Color.Transparent;
            this.searchAtivo.ForeColor = System.Drawing.Color.Green;
            this.searchAtivo.Location = new System.Drawing.Point(876, 29);
            this.searchAtivo.Name = "searchAtivo";
            this.searchAtivo.Size = new System.Drawing.Size(74, 22);
            this.searchAtivo.TabIndex = 13;
            this.searchAtivo.Text = "Ativos";
            this.searchAtivo.UseVisualStyleBackColor = false;
            this.searchAtivo.CheckedChanged += new System.EventHandler(this.searchAtivo_CheckedChanged);
            // 
            // searchInativos
            // 
            this.searchInativos.AutoSize = true;
            this.searchInativos.BackColor = System.Drawing.Color.Transparent;
            this.searchInativos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchInativos.Location = new System.Drawing.Point(876, 50);
            this.searchInativos.Name = "searchInativos";
            this.searchInativos.Size = new System.Drawing.Size(90, 22);
            this.searchInativos.TabIndex = 12;
            this.searchInativos.Text = "Inativos";
            this.searchInativos.UseVisualStyleBackColor = false;
            this.searchInativos.CheckedChanged += new System.EventHandler(this.searchInativos_CheckedChanged);
            // 
            // searchAll
            // 
            this.searchAll.AutoSize = true;
            this.searchAll.BackColor = System.Drawing.Color.Transparent;
            this.searchAll.Checked = true;
            this.searchAll.Location = new System.Drawing.Point(876, 10);
            this.searchAll.Name = "searchAll";
            this.searchAll.Size = new System.Drawing.Size(66, 22);
            this.searchAll.TabIndex = 3;
            this.searchAll.TabStop = true;
            this.searchAll.Text = "Todos";
            this.searchAll.UseVisualStyleBackColor = false;
            this.searchAll.CheckedChanged += new System.EventHandler(this.searchAll_CheckedChanged);
            // 
            // searchNasc
            // 
            this.searchNasc.ForeColor = System.Drawing.Color.Black;
            this.searchNasc.Location = new System.Drawing.Point(748, 37);
            this.searchNasc.Name = "searchNasc";
            this.searchNasc.Size = new System.Drawing.Size(103, 25);
            this.searchNasc.TabIndex = 10;
            this.searchNasc.TextChanged += new System.EventHandler(this.searchId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(746, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nascimento";
            // 
            // searchEndereco
            // 
            this.searchEndereco.ForeColor = System.Drawing.Color.Black;
            this.searchEndereco.Location = new System.Drawing.Point(582, 37);
            this.searchEndereco.Name = "searchEndereco";
            this.searchEndereco.Size = new System.Drawing.Size(160, 25);
            this.searchEndereco.TabIndex = 10;
            this.searchEndereco.TextChanged += new System.EventHandler(this.searchId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(579, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Endereços gerais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(462, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(349, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genero";
            // 
            // searchEstadoCivil
            // 
            this.searchEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchEstadoCivil.DropDownHeight = 200;
            this.searchEstadoCivil.FormattingEnabled = true;
            this.searchEstadoCivil.IntegralHeight = false;
            this.searchEstadoCivil.Items.AddRange(new object[] {
            "Viuvo (a)",
            "Casado (a)",
            "Divorciado (a)",
            "Separado (a)",
            "Solteiro (a)"});
            this.searchEstadoCivil.Location = new System.Drawing.Point(465, 37);
            this.searchEstadoCivil.Name = "searchEstadoCivil";
            this.searchEstadoCivil.Size = new System.Drawing.Size(111, 26);
            this.searchEstadoCivil.TabIndex = 7;
            this.searchEstadoCivil.TextChanged += new System.EventHandler(this.searchId_TextChanged);
            // 
            // searchGenero
            // 
            this.searchGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchGenero.DropDownHeight = 200;
            this.searchGenero.FormattingEnabled = true;
            this.searchGenero.IntegralHeight = false;
            this.searchGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.searchGenero.Location = new System.Drawing.Point(352, 37);
            this.searchGenero.Name = "searchGenero";
            this.searchGenero.Size = new System.Drawing.Size(107, 26);
            this.searchGenero.TabIndex = 6;
            this.searchGenero.TextChanged += new System.EventHandler(this.searchId_TextChanged);
            // 
            // searchNome
            // 
            this.searchNome.ForeColor = System.Drawing.Color.Black;
            this.searchNome.Location = new System.Drawing.Point(73, 39);
            this.searchNome.Name = "searchNome";
            this.searchNome.Size = new System.Drawing.Size(273, 25);
            this.searchNome.TabIndex = 1;
            this.searchNome.TextChanged += new System.EventHandler(this.searchNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome / CPF ou CNPJ";
            // 
            // searchId
            // 
            this.searchId.ForeColor = System.Drawing.Color.Black;
            this.searchId.Location = new System.Drawing.Point(6, 39);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(61, 25);
            this.searchId.TabIndex = 1;
            this.searchId.TextChanged += new System.EventHandler(this.searchId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "N°";
            // 
            // totalLocalizado
            // 
            this.totalLocalizado.AutoSize = true;
            this.totalLocalizado.BackColor = System.Drawing.Color.Transparent;
            this.totalLocalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLocalizado.ForeColor = System.Drawing.Color.Black;
            this.totalLocalizado.Location = new System.Drawing.Point(17, 642);
            this.totalLocalizado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLocalizado.Name = "totalLocalizado";
            this.totalLocalizado.Size = new System.Drawing.Size(120, 18);
            this.totalLocalizado.TabIndex = 3;
            this.totalLocalizado.Text = "Total localizado: ";
            // 
            // totalAtivos
            // 
            this.totalAtivos.AutoSize = true;
            this.totalAtivos.BackColor = System.Drawing.Color.Transparent;
            this.totalAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAtivos.ForeColor = System.Drawing.Color.Black;
            this.totalAtivos.Location = new System.Drawing.Point(268, 642);
            this.totalAtivos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalAtivos.Name = "totalAtivos";
            this.totalAtivos.Size = new System.Drawing.Size(56, 18);
            this.totalAtivos.TabIndex = 3;
            this.totalAtivos.Text = "Ativos: ";
            // 
            // totalInativos
            // 
            this.totalInativos.AutoSize = true;
            this.totalInativos.BackColor = System.Drawing.Color.Transparent;
            this.totalInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInativos.ForeColor = System.Drawing.Color.Black;
            this.totalInativos.Location = new System.Drawing.Point(519, 642);
            this.totalInativos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalInativos.Name = "totalInativos";
            this.totalInativos.Size = new System.Drawing.Size(66, 18);
            this.totalInativos.TabIndex = 3;
            this.totalInativos.Text = "Inativos: ";
            // 
            // nadaEncontrado
            // 
            this.nadaEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.nadaEncontrado.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nadaEncontrado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nadaEncontrado.Location = new System.Drawing.Point(12, 122);
            this.nadaEncontrado.Name = "nadaEncontrado";
            this.nadaEncontrado.Size = new System.Drawing.Size(1240, 483);
            this.nadaEncontrado.TabIndex = 4;
            this.nadaEncontrado.Text = "Nenhum cliente encontrado...";
            this.nadaEncontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportFicha
            // 
            this.reportFicha.LocalReport.EnableExternalImages = true;
            this.reportFicha.LocalReport.ReportEmbeddedResource = "menu_clientes.fichaCadastral.rdlc";
            this.reportFicha.Location = new System.Drawing.Point(12, 89);
            this.reportFicha.Name = "reportFicha";
            this.reportFicha.ServerReport.BearerToken = null;
            this.reportFicha.Size = new System.Drawing.Size(236, 181);
            this.reportFicha.TabIndex = 5;
            this.reportFicha.Visible = false;
            // 
            // FormMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::menu_clientes.Properties.Resources.backGradiente1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.reportFicha);
            this.Controls.Add(this.nadaEncontrado);
            this.Controls.Add(this.totalInativos);
            this.Controls.Add(this.totalAtivos);
            this.Controls.Add(this.totalLocalizado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de clientes";
            this.Load += new System.EventHandler(this.FormMenuClientes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGerarFicha;
        private System.Windows.Forms.Button btGerarPDF;
        private System.Windows.Forms.Button btEditarCliente;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchEstadoCivil;
        private System.Windows.Forms.ComboBox searchGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton searchAtivo;
        private System.Windows.Forms.RadioButton searchInativos;
        private System.Windows.Forms.RadioButton searchAll;
        private System.Windows.Forms.Label totalLocalizado;
        private System.Windows.Forms.Label totalAtivos;
        private System.Windows.Forms.Label totalInativos;
        private System.Windows.Forms.Label nadaEncontrado;
        private Microsoft.Reporting.WinForms.ReportViewer reportFicha;
    }
}