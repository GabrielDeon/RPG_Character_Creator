namespace CRUDBasico
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txIdade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txAltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txPeso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CRUDBasico.Database1DataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.txUF = new System.Windows.Forms.TextBox();
            this.txIDCidade = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new CRUDBasico.Database1DataSetTableAdapters.ClientesTableAdapter();
            this.cidadesTableAdapter = new CRUDBasico.Database1DataSetTableAdapters.CidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Cliente:";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(111, 55);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(56, 20);
            this.txCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(111, 92);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(235, 20);
            this.txNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Nascimento:";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(111, 130);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtNascimento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // txIdade
            // 
            this.txIdade.Location = new System.Drawing.Point(111, 169);
            this.txIdade.Name = "txIdade";
            this.txIdade.Size = new System.Drawing.Size(43, 20);
            this.txIdade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF:";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(111, 205);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(102, 20);
            this.mtxCPF.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altura:";
            // 
            // txAltura
            // 
            this.txAltura.Location = new System.Drawing.Point(111, 245);
            this.txAltura.Name = "txAltura";
            this.txAltura.Size = new System.Drawing.Size(100, 20);
            this.txAltura.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso:";
            // 
            // txPeso
            // 
            this.txPeso.Location = new System.Drawing.Point(111, 282);
            this.txPeso.Name = "txPeso";
            this.txPeso.Size = new System.Drawing.Size(100, 20);
            this.txPeso.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cidade:";
            // 
            // cbCidade
            // 
            this.cbCidade.DataSource = this.cidadesBindingSource;
            this.cbCidade.DisplayMember = "Nome";
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(111, 317);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(139, 21);
            this.cbCidade.TabIndex = 15;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "UF:";
            // 
            // txUF
            // 
            this.txUF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "UF", true));
            this.txUF.Location = new System.Drawing.Point(342, 317);
            this.txUF.Name = "txUF";
            this.txUF.Size = new System.Drawing.Size(51, 20);
            this.txUF.TabIndex = 17;
            // 
            // txIDCidade
            // 
            this.txIDCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "ID_Cidade", true));
            this.txIDCidade.Location = new System.Drawing.Point(256, 317);
            this.txIDCidade.Name = "txIDCidade";
            this.txIDCidade.Size = new System.Drawing.Size(18, 20);
            this.txIDCidade.TabIndex = 18;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(175, 52);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 19;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(425, 75);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(116, 54);
            this.btIncluir.TabIndex = 20;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(425, 151);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(116, 54);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(425, 227);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(116, 54);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.iDCidadeDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(10, 361);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(544, 150);
            this.dgvClientes.TabIndex = 23;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "Altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCidadeDataGridViewTextBoxColumn
            // 
            this.iDCidadeDataGridViewTextBoxColumn.DataPropertyName = "ID_Cidade";
            this.iDCidadeDataGridViewTextBoxColumn.HeaderText = "ID_Cidade";
            this.iDCidadeDataGridViewTextBoxColumn.Name = "iDCidadeDataGridViewTextBoxColumn";
            this.iDCidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.database1DataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 523);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txIDCidade);
            this.Controls.Add(this.txUF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txIdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txAltura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txPeso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txUF;
        private System.Windows.Forms.TextBox txIDCidade;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Database1DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private Database1DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
    }
}

