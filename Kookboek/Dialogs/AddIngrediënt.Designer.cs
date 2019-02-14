namespace Kookboek.Dialogs
{
    partial class AddIngrediënt
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
            this.txtIngrediënt = new System.Windows.Forms.TextBox();
            this.lstIngrediënten = new System.Windows.Forms.ListBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnNieuwToevoegen = new System.Windows.Forms.Button();
            this.lstEenheden = new System.Windows.Forms.ListBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIngrediënt
            // 
            this.txtIngrediënt.Location = new System.Drawing.Point(12, 12);
            this.txtIngrediënt.Name = "txtIngrediënt";
            this.txtIngrediënt.Size = new System.Drawing.Size(234, 22);
            this.txtIngrediënt.TabIndex = 0;
            this.txtIngrediënt.TextChanged += new System.EventHandler(this.txtIngrediënt_TextChanged);
            // 
            // lstIngrediënten
            // 
            this.lstIngrediënten.FormattingEnabled = true;
            this.lstIngrediënten.ItemHeight = 16;
            this.lstIngrediënten.Location = new System.Drawing.Point(12, 40);
            this.lstIngrediënten.Name = "lstIngrediënten";
            this.lstIngrediënten.Size = new System.Drawing.Size(234, 260);
            this.lstIngrediënten.TabIndex = 1;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(252, 266);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(144, 34);
            this.btnOpslaan.TabIndex = 2;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(402, 266);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(98, 34);
            this.btnAnnuleren.TabIndex = 3;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnNieuwToevoegen
            // 
            this.btnNieuwToevoegen.Location = new System.Drawing.Point(252, 6);
            this.btnNieuwToevoegen.Name = "btnNieuwToevoegen";
            this.btnNieuwToevoegen.Size = new System.Drawing.Size(45, 35);
            this.btnNieuwToevoegen.TabIndex = 4;
            this.btnNieuwToevoegen.Text = "+";
            this.btnNieuwToevoegen.UseVisualStyleBackColor = true;
            this.btnNieuwToevoegen.Visible = false;
            this.btnNieuwToevoegen.Click += new System.EventHandler(this.btnNieuwToevoegen_Click);
            // 
            // lstEenheden
            // 
            this.lstEenheden.FormattingEnabled = true;
            this.lstEenheden.ItemHeight = 16;
            this.lstEenheden.Location = new System.Drawing.Point(378, 60);
            this.lstEenheden.Name = "lstEenheden";
            this.lstEenheden.Size = new System.Drawing.Size(122, 164);
            this.lstEenheden.TabIndex = 5;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(279, 60);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(93, 22);
            this.txtAantal.TabIndex = 6;
            // 
            // AddIngrediënt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 307);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lstEenheden);
            this.Controls.Add(this.btnNieuwToevoegen);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lstIngrediënten);
            this.Controls.Add(this.txtIngrediënt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddIngrediënt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrediënt Toevoegen";
            this.Load += new System.EventHandler(this.AddIngrediënt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngrediënt;
        private System.Windows.Forms.ListBox lstIngrediënten;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnNieuwToevoegen;
        private System.Windows.Forms.ListBox lstEenheden;
        private System.Windows.Forms.TextBox txtAantal;
    }
}