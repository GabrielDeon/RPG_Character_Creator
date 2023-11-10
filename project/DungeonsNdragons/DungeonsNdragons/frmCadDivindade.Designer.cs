namespace DungeonsNdragons
{
    partial class frmCadDivindade
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
            label3 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label5 = new Label();
            edtNome = new TextBox();
            edtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            edtDominio = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 106);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 91;
            label3.Text = "Domínio";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(135, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 37);
            btnCancelar.TabIndex = 90;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(216, 160);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 37);
            btnSalvar.TabIndex = 89;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 30);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 88;
            // 
            // edtNome
            // 
            edtNome.Location = new Point(108, 62);
            edtNome.Name = "edtNome";
            edtNome.Size = new Size(183, 23);
            edtNome.TabIndex = 87;
            // 
            // edtID
            // 
            edtID.Location = new Point(108, 26);
            edtID.Name = "edtID";
            edtID.ReadOnly = true;
            edtID.Size = new Size(183, 23);
            edtID.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 85;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 84;
            label1.Text = "ID";
            // 
            // edtDominio
            // 
            edtDominio.Location = new Point(108, 103);
            edtDominio.Name = "edtDominio";
            edtDominio.Size = new Size(183, 23);
            edtDominio.TabIndex = 92;
            // 
            // frmCadDivindade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 225);
            Controls.Add(edtDominio);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(edtNome);
            Controls.Add(edtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCadDivindade";
            Text = "Cadastro de Divindade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label5;
        private TextBox edtNome;
        private TextBox edtID;
        private Label label2;
        private Label label1;
        private TextBox edtDominio;
    }
}