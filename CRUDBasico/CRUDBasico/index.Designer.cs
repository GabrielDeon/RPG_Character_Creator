namespace CRUDBasico
{
    partial class index
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
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dbgPersonagem = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mORALIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDIVINDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRACADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLASSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSUBCLASSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONAGEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dungeonsNdragonsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dungeonsNdragonsDataSet = new CRUDBasico.DungeonsNdragonsDataSet();
            this.pERSONAGEMTableAdapter = new CRUDBasico.DungeonsNdragonsDataSetTableAdapters.PERSONAGEMTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxMoralidade = new System.Windows.Forms.ComboBox();
            this.nmrPeso = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPersonagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONAGEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonsNdragonsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonsNdragonsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(356, 419);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(116, 23);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(222, 419);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(88, 419);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // dbgPersonagem
            // 
            this.dbgPersonagem.AllowUserToAddRows = false;
            this.dbgPersonagem.AllowUserToDeleteRows = false;
            this.dbgPersonagem.AutoGenerateColumns = false;
            this.dbgPersonagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgPersonagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.pESODataGridViewTextBoxColumn,
            this.aLTURADataGridViewTextBoxColumn,
            this.sEXODataGridViewTextBoxColumn,
            this.mORALIDADEDataGridViewTextBoxColumn,
            this.iDDIVINDADEDataGridViewTextBoxColumn,
            this.iDRACADataGridViewTextBoxColumn,
            this.iDCLASSEDataGridViewTextBoxColumn,
            this.iDSUBCLASSEDataGridViewTextBoxColumn});
            this.dbgPersonagem.DataSource = this.pERSONAGEMBindingSource;
            this.dbgPersonagem.Location = new System.Drawing.Point(40, 29);
            this.dbgPersonagem.Name = "dbgPersonagem";
            this.dbgPersonagem.ReadOnly = true;
            this.dbgPersonagem.Size = new System.Drawing.Size(567, 207);
            this.dbgPersonagem.TabIndex = 23;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESODataGridViewTextBoxColumn
            // 
            this.pESODataGridViewTextBoxColumn.DataPropertyName = "PESO";
            this.pESODataGridViewTextBoxColumn.HeaderText = "PESO";
            this.pESODataGridViewTextBoxColumn.Name = "pESODataGridViewTextBoxColumn";
            this.pESODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aLTURADataGridViewTextBoxColumn
            // 
            this.aLTURADataGridViewTextBoxColumn.DataPropertyName = "ALTURA";
            this.aLTURADataGridViewTextBoxColumn.HeaderText = "ALTURA";
            this.aLTURADataGridViewTextBoxColumn.Name = "aLTURADataGridViewTextBoxColumn";
            this.aLTURADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEXODataGridViewTextBoxColumn
            // 
            this.sEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO";
            this.sEXODataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.sEXODataGridViewTextBoxColumn.Name = "sEXODataGridViewTextBoxColumn";
            this.sEXODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mORALIDADEDataGridViewTextBoxColumn
            // 
            this.mORALIDADEDataGridViewTextBoxColumn.DataPropertyName = "MORALIDADE";
            this.mORALIDADEDataGridViewTextBoxColumn.HeaderText = "MORALIDADE";
            this.mORALIDADEDataGridViewTextBoxColumn.Name = "mORALIDADEDataGridViewTextBoxColumn";
            this.mORALIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDIVINDADEDataGridViewTextBoxColumn
            // 
            this.iDDIVINDADEDataGridViewTextBoxColumn.DataPropertyName = "ID_DIVINDADE";
            this.iDDIVINDADEDataGridViewTextBoxColumn.HeaderText = "ID_DIVINDADE";
            this.iDDIVINDADEDataGridViewTextBoxColumn.Name = "iDDIVINDADEDataGridViewTextBoxColumn";
            this.iDDIVINDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDRACADataGridViewTextBoxColumn
            // 
            this.iDRACADataGridViewTextBoxColumn.DataPropertyName = "ID_RACA";
            this.iDRACADataGridViewTextBoxColumn.HeaderText = "ID_RACA";
            this.iDRACADataGridViewTextBoxColumn.Name = "iDRACADataGridViewTextBoxColumn";
            this.iDRACADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCLASSEDataGridViewTextBoxColumn
            // 
            this.iDCLASSEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLASSE";
            this.iDCLASSEDataGridViewTextBoxColumn.HeaderText = "ID_CLASSE";
            this.iDCLASSEDataGridViewTextBoxColumn.Name = "iDCLASSEDataGridViewTextBoxColumn";
            this.iDCLASSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSUBCLASSEDataGridViewTextBoxColumn
            // 
            this.iDSUBCLASSEDataGridViewTextBoxColumn.DataPropertyName = "ID_SUBCLASSE";
            this.iDSUBCLASSEDataGridViewTextBoxColumn.HeaderText = "ID_SUBCLASSE";
            this.iDSUBCLASSEDataGridViewTextBoxColumn.Name = "iDSUBCLASSEDataGridViewTextBoxColumn";
            this.iDSUBCLASSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERSONAGEMBindingSource
            // 
            this.pERSONAGEMBindingSource.DataMember = "PERSONAGEM";
            this.pERSONAGEMBindingSource.DataSource = this.dungeonsNdragonsDataSetBindingSource;
            // 
            // dungeonsNdragonsDataSetBindingSource
            // 
            this.dungeonsNdragonsDataSetBindingSource.DataSource = this.dungeonsNdragonsDataSet;
            this.dungeonsNdragonsDataSetBindingSource.Position = 0;
            // 
            // dungeonsNdragonsDataSet
            // 
            this.dungeonsNdragonsDataSet.DataSetName = "DungeonsNdragonsDataSet";
            this.dungeonsNdragonsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONAGEMTableAdapter
            // 
            this.pERSONAGEMTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // edtID
            // 
            this.edtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONAGEMBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.edtID.Enabled = false;
            this.edtID.Location = new System.Drawing.Point(34, 275);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(180, 20);
            this.edtID.TabIndex = 25;
            // 
            // edtAltura
            // 
            this.edtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONAGEMBindingSource, "ALTURA", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.edtAltura.Location = new System.Drawing.Point(34, 322);
            this.edtAltura.Name = "edtAltura";
            this.edtAltura.ReadOnly = true;
            this.edtAltura.Size = new System.Drawing.Size(180, 20);
            this.edtAltura.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Altura";
            // 
            // edtNome
            // 
            this.edtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONAGEMBindingSource, "NOME", true));
            this.edtNome.Location = new System.Drawing.Point(231, 275);
            this.edtNome.Name = "edtNome";
            this.edtNome.ReadOnly = true;
            this.edtNome.Size = new System.Drawing.Size(180, 20);
            this.edtNome.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Peso (kg)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Moralidade";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONAGEMBindingSource, "SEXO", true));
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.Enabled = false;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbxSexo.Location = new System.Drawing.Point(231, 322);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(180, 21);
            this.cbxSexo.TabIndex = 36;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // cbxMoralidade
            // 
            this.cbxMoralidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONAGEMBindingSource, "MORALIDADE", true));
            this.cbxMoralidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pERSONAGEMBindingSource, "MORALIDADE", true));
            this.cbxMoralidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoralidade.Enabled = false;
            this.cbxMoralidade.FormattingEnabled = true;
            this.cbxMoralidade.Items.AddRange(new object[] {
            "Lawful Good",
            "Lawful Neutral",
            "Lawful Evil",
            "Neutral Good",
            "Neutral ",
            "Neutral Evil",
            "Chaotic Good ",
            "Chaotic Neutral",
            "Chaotic Evil"});
            this.cbxMoralidade.Location = new System.Drawing.Point(427, 321);
            this.cbxMoralidade.Name = "cbxMoralidade";
            this.cbxMoralidade.Size = new System.Drawing.Size(180, 21);
            this.cbxMoralidade.TabIndex = 37;
            // 
            // nmrPeso
            // 
            this.nmrPeso.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pERSONAGEMBindingSource, "PESO", true));
            this.nmrPeso.Location = new System.Drawing.Point(427, 275);
            this.nmrPeso.Name = "nmrPeso";
            this.nmrPeso.ReadOnly = true;
            this.nmrPeso.Size = new System.Drawing.Size(180, 20);
            this.nmrPeso.TabIndex = 38;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(490, 419);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 23);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "ID";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(129, 374);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 23);
            this.btnConsultar.TabIndex = 42;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 482);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nmrPeso);
            this.Controls.Add(this.cbxMoralidade);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbgPersonagem);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Name = "index";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgPersonagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONAGEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonsNdragonsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonsNdragonsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        
        private System.Windows.Forms.BindingSource clientesBindingSource;
        
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.DataGridView dbgPersonagem;
        private System.Windows.Forms.BindingSource dungeonsNdragonsDataSetBindingSource;
        private DungeonsNdragonsDataSet dungeonsNdragonsDataSet;
        private System.Windows.Forms.BindingSource pERSONAGEMBindingSource;
        private DungeonsNdragonsDataSetTableAdapters.PERSONAGEMTableAdapter pERSONAGEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mORALIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDIVINDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRACADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLASSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSUBCLASSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.ComboBox cbxMoralidade;
        private System.Windows.Forms.NumericUpDown nmrPeso;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultar;
    }
}

