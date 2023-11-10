namespace DungeonsNdragons
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dbCharacters = new DataGridView();
            btnAddCharacter = new Button();
            btnAlterCharacter = new Button();
            btnRemoveCharacter = new Button();
            btnClasses = new Button();
            btnSubClasses = new Button();
            btnDivinities = new Button();
            btnRaces = new Button();
            ((System.ComponentModel.ISupportInitialize)dbCharacters).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 25);
            label1.Name = "label1";
            label1.Size = new Size(230, 30);
            label1.TabIndex = 0;
            label1.Text = "Dungeons and Dragon ";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Character List";
            // 
            // dbCharacters
            // 
            dbCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbCharacters.Location = new Point(36, 103);
            dbCharacters.Name = "dbCharacters";
            dbCharacters.RowTemplate.Height = 25;
            dbCharacters.Size = new Size(480, 156);
            dbCharacters.TabIndex = 2;
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.Location = new Point(144, 277);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(75, 23);
            btnAddCharacter.TabIndex = 3;
            btnAddCharacter.Text = "Add";
            btnAddCharacter.UseVisualStyleBackColor = true;
            // 
            // btnAlterCharacter
            // 
            btnAlterCharacter.Location = new Point(225, 277);
            btnAlterCharacter.Name = "btnAlterCharacter";
            btnAlterCharacter.Size = new Size(75, 23);
            btnAlterCharacter.TabIndex = 4;
            btnAlterCharacter.Text = "Alter";
            btnAlterCharacter.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCharacter
            // 
            btnRemoveCharacter.Location = new Point(306, 277);
            btnRemoveCharacter.Name = "btnRemoveCharacter";
            btnRemoveCharacter.Size = new Size(75, 23);
            btnRemoveCharacter.TabIndex = 5;
            btnRemoveCharacter.Text = "Remove";
            btnRemoveCharacter.UseVisualStyleBackColor = true;
            // 
            // btnClasses
            // 
            btnClasses.Location = new Point(73, 350);
            btnClasses.Name = "btnClasses";
            btnClasses.Size = new Size(91, 30);
            btnClasses.TabIndex = 6;
            btnClasses.Text = "Classes";
            btnClasses.UseVisualStyleBackColor = true;
            // 
            // btnSubClasses
            // 
            btnSubClasses.Location = new Point(170, 350);
            btnSubClasses.Name = "btnSubClasses";
            btnSubClasses.Size = new Size(91, 30);
            btnSubClasses.TabIndex = 7;
            btnSubClasses.Text = "SubClasses";
            btnSubClasses.UseVisualStyleBackColor = true;
            // 
            // btnDivinities
            // 
            btnDivinities.Location = new Point(267, 350);
            btnDivinities.Name = "btnDivinities";
            btnDivinities.Size = new Size(91, 30);
            btnDivinities.TabIndex = 8;
            btnDivinities.Text = "Divinities";
            btnDivinities.UseVisualStyleBackColor = true;
            // 
            // btnRaces
            // 
            btnRaces.Location = new Point(364, 350);
            btnRaces.Name = "btnRaces";
            btnRaces.Size = new Size(91, 30);
            btnRaces.TabIndex = 9;
            btnRaces.Text = "Races";
            btnRaces.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(btnRaces);
            Controls.Add(btnDivinities);
            Controls.Add(btnSubClasses);
            Controls.Add(btnClasses);
            Controls.Add(btnRemoveCharacter);
            Controls.Add(btnAlterCharacter);
            Controls.Add(btnAddCharacter);
            Controls.Add(dbCharacters);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Dungens Characters";
            ((System.ComponentModel.ISupportInitialize)dbCharacters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dbCharacters;
        private Button btnAddCharacter;
        private Button btnAlterCharacter;
        private Button btnRemoveCharacter;
        private Button btnClasses;
        private Button btnSubClasses;
        private Button btnDivinities;
        private Button btnRaces;
    }
}