namespace Kookboek
{
    partial class ReceptBekijken
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAantalPersonen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.picRecept = new System.Windows.Forms.PictureBox();
            this.lblDuur = new System.Windows.Forms.Label();
            this.grpTags = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblBereiding = new System.Windows.Forms.TextBox();
            this.lblIngrediënten = new System.Windows.Forms.TextBox();
            this.btnBewerk = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalPersonen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecept)).BeginInit();
            this.grpTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBereiding);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 457);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bereiding";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIngrediënten);
            this.groupBox1.Location = new System.Drawing.Point(538, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 415);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrediënten";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(691, 659);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(215, 36);
            this.btnOpslaan.TabIndex = 31;
            this.btnOpslaan.Text = "Sluiten";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Duur";
            // 
            // nudAantalPersonen
            // 
            this.nudAantalPersonen.Location = new System.Drawing.Point(133, 159);
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
            this.nudAantalPersonen.TabIndex = 27;
            this.nudAantalPersonen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAantalPersonen.ValueChanged += new System.EventHandler(this.nudAantalPersonen_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Aantal Personen";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOmschrijving.Location = new System.Drawing.Point(14, 53);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(518, 103);
            this.lblOmschrijving.TabIndex = 24;
            this.lblOmschrijving.Text = "Omschrijving";
            // 
            // lblNaam
            // 
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(12, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(520, 29);
            this.lblNaam.TabIndex = 22;
            this.lblNaam.Text = "Naam";
            // 
            // picRecept
            // 
            this.picRecept.Location = new System.Drawing.Point(538, 6);
            this.picRecept.Name = "picRecept";
            this.picRecept.Size = new System.Drawing.Size(368, 226);
            this.picRecept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecept.TabIndex = 20;
            this.picRecept.TabStop = false;
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Location = new System.Drawing.Point(337, 161);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(34, 17);
            this.lblDuur.TabIndex = 30;
            this.lblDuur.Text = "min.";
            // 
            // grpTags
            // 
            this.grpTags.Controls.Add(this.linkLabel1);
            this.grpTags.Location = new System.Drawing.Point(12, 187);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(520, 45);
            this.grpTags.TabIndex = 36;
            this.grpTags.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // lblBereiding
            // 
            this.lblBereiding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBereiding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBereiding.Location = new System.Drawing.Point(15, 27);
            this.lblBereiding.Multiline = true;
            this.lblBereiding.Name = "lblBereiding";
            this.lblBereiding.ReadOnly = true;
            this.lblBereiding.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblBereiding.Size = new System.Drawing.Size(499, 424);
            this.lblBereiding.TabIndex = 0;
            // 
            // lblIngrediënten
            // 
            this.lblIngrediënten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblIngrediënten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediënten.Location = new System.Drawing.Point(18, 27);
            this.lblIngrediënten.Multiline = true;
            this.lblIngrediënten.Name = "lblIngrediënten";
            this.lblIngrediënten.ReadOnly = true;
            this.lblIngrediënten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblIngrediënten.Size = new System.Drawing.Size(343, 388);
            this.lblIngrediënten.TabIndex = 1;
            // 
            // btnBewerk
            // 
            this.btnBewerk.Location = new System.Drawing.Point(538, 659);
            this.btnBewerk.Name = "btnBewerk";
            this.btnBewerk.Size = new System.Drawing.Size(147, 36);
            this.btnBewerk.TabIndex = 38;
            this.btnBewerk.Text = "Bewerk";
            this.btnBewerk.UseVisualStyleBackColor = true;
            this.btnBewerk.Click += new System.EventHandler(this.btnBewerk_Click);
            // 
            // ReceptBekijken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 710);
            this.Controls.Add(this.btnBewerk);
            this.Controls.Add(this.grpTags);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAantalPersonen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.picRecept);
            this.Controls.Add(this.lblDuur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceptBekijken";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recept Bekijken";
            this.Load += new System.EventHandler(this.ReceptBekijken_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalPersonen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecept)).EndInit();
            this.grpTags.ResumeLayout(false);
            this.grpTags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAantalPersonen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.PictureBox picRecept;
        private System.Windows.Forms.Label lblDuur;
        private System.Windows.Forms.GroupBox grpTags;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox lblBereiding;
        private System.Windows.Forms.TextBox lblIngrediënten;
        private System.Windows.Forms.Button btnBewerk;
    }
}