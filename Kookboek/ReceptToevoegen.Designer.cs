namespace Kookboek
{
    partial class ReceptToevoegen
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
            this.picRecept = new System.Windows.Forms.PictureBox();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAantalPersonen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDuur = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddIngrediënt = new System.Windows.Forms.Button();
            this.lstIngrediënten = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBereiding = new System.Windows.Forms.Button();
            this.lstBereiding = new System.Windows.Forms.ListBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalPersonen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuur)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRecept
            // 
            this.picRecept.Location = new System.Drawing.Point(538, 9);
            this.picRecept.Name = "picRecept";
            this.picRecept.Size = new System.Drawing.Size(368, 226);
            this.picRecept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecept.TabIndex = 1;
            this.picRecept.TabStop = false;
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(609, 245);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(297, 22);
            this.txtImageUrl.TabIndex = 2;
            this.txtImageUrl.Leave += new System.EventHandler(this.txtImageUrl_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // txtTitel
            // 
            this.txtTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(115, 9);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(417, 36);
            this.txtTitel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Omschrijving";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(115, 53);
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(417, 97);
            this.txtOmschrijving.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aantal Personen";
            // 
            // nudAantalPersonen
            // 
            this.nudAantalPersonen.Location = new System.Drawing.Point(133, 162);
            this.nudAantalPersonen.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAantalPersonen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAantalPersonen.Name = "nudAantalPersonen";
            this.nudAantalPersonen.Size = new System.Drawing.Size(58, 22);
            this.nudAantalPersonen.TabIndex = 9;
            this.nudAantalPersonen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duur";
            // 
            // nudDuur
            // 
            this.nudDuur.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDuur.Location = new System.Drawing.Point(337, 162);
            this.nudDuur.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuur.Name = "nudDuur";
            this.nudDuur.ReadOnly = true;
            this.nudDuur.Size = new System.Drawing.Size(58, 22);
            this.nudDuur.TabIndex = 11;
            this.nudDuur.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "min.";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(538, 662);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(135, 36);
            this.btnAnnuleren.TabIndex = 14;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Foto URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddIngrediënt);
            this.groupBox1.Controls.Add(this.lstIngrediënten);
            this.groupBox1.Location = new System.Drawing.Point(538, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 383);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrediënten";
            // 
            // btnAddIngrediënt
            // 
            this.btnAddIngrediënt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngrediënt.Location = new System.Drawing.Point(329, 13);
            this.btnAddIngrediënt.Name = "btnAddIngrediënt";
            this.btnAddIngrediënt.Size = new System.Drawing.Size(33, 26);
            this.btnAddIngrediënt.TabIndex = 1;
            this.btnAddIngrediënt.Text = "+";
            this.btnAddIngrediënt.UseVisualStyleBackColor = true;
            this.btnAddIngrediënt.Click += new System.EventHandler(this.btnAddIngrediënt_Click);
            // 
            // lstIngrediënten
            // 
            this.lstIngrediënten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIngrediënten.FormattingEnabled = true;
            this.lstIngrediënten.ItemHeight = 25;
            this.lstIngrediënten.Location = new System.Drawing.Point(9, 21);
            this.lstIngrediënten.Name = "lstIngrediënten";
            this.lstIngrediënten.Size = new System.Drawing.Size(345, 354);
            this.lstIngrediënten.TabIndex = 4;
            this.lstIngrediënten.DoubleClick += new System.EventHandler(this.lstIngrediënten_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBereiding);
            this.groupBox2.Controls.Add(this.lstBereiding);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 480);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bereiding";
            // 
            // btnAddBereiding
            // 
            this.btnAddBereiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBereiding.Location = new System.Drawing.Point(481, 13);
            this.btnAddBereiding.Name = "btnAddBereiding";
            this.btnAddBereiding.Size = new System.Drawing.Size(33, 26);
            this.btnAddBereiding.TabIndex = 2;
            this.btnAddBereiding.Text = "+";
            this.btnAddBereiding.UseVisualStyleBackColor = true;
            this.btnAddBereiding.Click += new System.EventHandler(this.btnAddBereiding_Click);
            // 
            // lstBereiding
            // 
            this.lstBereiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBereiding.FormattingEnabled = true;
            this.lstBereiding.ItemHeight = 25;
            this.lstBereiding.Location = new System.Drawing.Point(15, 30);
            this.lstBereiding.Name = "lstBereiding";
            this.lstBereiding.Size = new System.Drawing.Size(488, 429);
            this.lstBereiding.TabIndex = 3;
            this.lstBereiding.DoubleClick += new System.EventHandler(this.lstBereiding_DoubleClick);
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(54, 190);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(478, 22);
            this.txtTags.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tags";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(721, 662);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(185, 36);
            this.btnOpslaan.TabIndex = 13;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.BackgroundImage = global::Kookboek.Properties.Resources.delete_737_475058;
            this.btnVerwijder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerwijder.Location = new System.Drawing.Point(679, 662);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(36, 36);
            this.btnVerwijder.TabIndex = 20;
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // ReceptToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 710);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.nudDuur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAantalPersonen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.picRecept);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "ReceptToevoegen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recept Toevoegen";
            this.Load += new System.EventHandler(this.ReceptToevoegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalPersonen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRecept;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAantalPersonen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDuur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddIngrediënt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBereiding;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListBox lstIngrediënten;
        private System.Windows.Forms.ListBox lstBereiding;
    }
}