namespace proiect
{
    partial class InterfataProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfataProdus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkDec1 = new System.Windows.Forms.LinkLabel();
            this.afisareProduse = new System.Windows.Forms.DataGridView();
            this.txtPretP = new System.Windows.Forms.TextBox();
            this.txtTipP = new System.Windows.Forms.TextBox();
            this.btnSterge1 = new System.Windows.Forms.Button();
            this.txtNumeP = new System.Windows.Forms.TextBox();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.selectareCategorie = new System.Windows.Forms.ComboBox();
            this.btnAdauga1 = new System.Windows.Forms.Button();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient1 = new System.Windows.Forms.Button();
            this.btnCat1 = new System.Windows.Forms.Button();
            this.btnIesire1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afisareProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.linkDec1);
            this.panel1.Controls.Add(this.afisareProduse);
            this.panel1.Controls.Add(this.txtPretP);
            this.panel1.Controls.Add(this.txtTipP);
            this.panel1.Controls.Add(this.btnSterge1);
            this.panel1.Controls.Add(this.txtNumeP);
            this.panel1.Controls.Add(this.btnUpdate1);
            this.panel1.Controls.Add(this.selectareCategorie);
            this.panel1.Controls.Add(this.btnAdauga1);
            this.panel1.Controls.Add(this.txtIdP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 355);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Location = new System.Drawing.Point(264, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 355);
            this.panel2.TabIndex = 10;
            // 
            // linkDec1
            // 
            this.linkDec1.AutoSize = true;
            this.linkDec1.BackColor = System.Drawing.Color.FloralWhite;
            this.linkDec1.Font = new System.Drawing.Font("MV Boli", 10F);
            this.linkDec1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkDec1.Location = new System.Drawing.Point(14, 313);
            this.linkDec1.Name = "linkDec1";
            this.linkDec1.Size = new System.Drawing.Size(86, 18);
            this.linkDec1.TabIndex = 11;
            this.linkDec1.TabStop = true;
            this.linkDec1.Text = "Deconectare";
            this.linkDec1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDec1_LinkClicked);
            // 
            // afisareProduse
            // 
            this.afisareProduse.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.afisareProduse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.afisareProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afisareProduse.Location = new System.Drawing.Point(280, 2);
            this.afisareProduse.Name = "afisareProduse";
            this.afisareProduse.ReadOnly = true;
            this.afisareProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.afisareProduse.Size = new System.Drawing.Size(549, 347);
            this.afisareProduse.TabIndex = 10;
            this.afisareProduse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPretP
            // 
            this.txtPretP.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtPretP.Location = new System.Drawing.Point(110, 195);
            this.txtPretP.Name = "txtPretP";
            this.txtPretP.Size = new System.Drawing.Size(148, 27);
            this.txtPretP.TabIndex = 9;
            // 
            // txtTipP
            // 
            this.txtTipP.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtTipP.Location = new System.Drawing.Point(110, 120);
            this.txtTipP.Name = "txtTipP";
            this.txtTipP.Size = new System.Drawing.Size(148, 27);
            this.txtTipP.TabIndex = 8;
            // 
            // btnSterge1
            // 
            this.btnSterge1.BackColor = System.Drawing.Color.Tan;
            this.btnSterge1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSterge1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnSterge1.ForeColor = System.Drawing.Color.Maroon;
            this.btnSterge1.Location = new System.Drawing.Point(177, 246);
            this.btnSterge1.Name = "btnSterge1";
            this.btnSterge1.Size = new System.Drawing.Size(81, 35);
            this.btnSterge1.TabIndex = 3;
            this.btnSterge1.Text = "Sterge";
            this.btnSterge1.UseVisualStyleBackColor = false;
            this.btnSterge1.Click += new System.EventHandler(this.btnSterge1_Click);
            // 
            // txtNumeP
            // 
            this.txtNumeP.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtNumeP.Location = new System.Drawing.Point(110, 82);
            this.txtNumeP.Name = "txtNumeP";
            this.txtNumeP.Size = new System.Drawing.Size(148, 27);
            this.txtNumeP.TabIndex = 7;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.Color.Tan;
            this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnUpdate1.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate1.Location = new System.Drawing.Point(92, 246);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(81, 35);
            this.btnUpdate1.TabIndex = 3;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // selectareCategorie
            // 
            this.selectareCategorie.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectareCategorie.ForeColor = System.Drawing.Color.Tan;
            this.selectareCategorie.FormattingEnabled = true;
            this.selectareCategorie.Location = new System.Drawing.Point(110, 156);
            this.selectareCategorie.Name = "selectareCategorie";
            this.selectareCategorie.Size = new System.Drawing.Size(148, 25);
            this.selectareCategorie.TabIndex = 6;
            this.selectareCategorie.Text = "Selecteaza categorie";
            this.selectareCategorie.SelectedIndexChanged += new System.EventHandler(this.selectareCategorie_SelectedIndexChanged);
            // 
            // btnAdauga1
            // 
            this.btnAdauga1.BackColor = System.Drawing.Color.Tan;
            this.btnAdauga1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnAdauga1.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdauga1.Location = new System.Drawing.Point(5, 246);
            this.btnAdauga1.Name = "btnAdauga1";
            this.btnAdauga1.Size = new System.Drawing.Size(81, 35);
            this.btnAdauga1.TabIndex = 2;
            this.btnAdauga1.Text = "Adauga";
            this.btnAdauga1.UseVisualStyleBackColor = false;
            this.btnAdauga1.Click += new System.EventHandler(this.btnAdauga1_Click);
            // 
            // txtIdP
            // 
            this.txtIdP.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtIdP.Location = new System.Drawing.Point(110, 45);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(148, 27);
            this.txtIdP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnClient1
            // 
            this.btnClient1.BackColor = System.Drawing.Color.Tan;
            this.btnClient1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnClient1.ForeColor = System.Drawing.Color.Maroon;
            this.btnClient1.Location = new System.Drawing.Point(12, 43);
            this.btnClient1.Name = "btnClient1";
            this.btnClient1.Size = new System.Drawing.Size(125, 35);
            this.btnClient1.TabIndex = 1;
            this.btnClient1.Text = "Clienti";
            this.btnClient1.UseVisualStyleBackColor = false;
            this.btnClient1.Click += new System.EventHandler(this.btnClient1_Click);
            // 
            // btnCat1
            // 
            this.btnCat1.BackColor = System.Drawing.Color.Tan;
            this.btnCat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnCat1.ForeColor = System.Drawing.Color.Maroon;
            this.btnCat1.Location = new System.Drawing.Point(721, 43);
            this.btnCat1.Name = "btnCat1";
            this.btnCat1.Size = new System.Drawing.Size(125, 35);
            this.btnCat1.TabIndex = 2;
            this.btnCat1.Text = "Categorii";
            this.btnCat1.UseVisualStyleBackColor = false;
            this.btnCat1.Click += new System.EventHandler(this.btnCat1_Click);
            // 
            // btnIesire1
            // 
            this.btnIesire1.BackColor = System.Drawing.Color.Tan;
            this.btnIesire1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnIesire1.ForeColor = System.Drawing.Color.Maroon;
            this.btnIesire1.Location = new System.Drawing.Point(0, 0);
            this.btnIesire1.Name = "btnIesire1";
            this.btnIesire1.Size = new System.Drawing.Size(23, 33);
            this.btnIesire1.TabIndex = 4;
            this.btnIesire1.Text = "X";
            this.btnIesire1.UseVisualStyleBackColor = false;
            this.btnIesire1.Click += new System.EventHandler(this.btnIesire1_Click);
            // 
            // InterfataProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(858, 445);
            this.Controls.Add(this.btnIesire1);
            this.Controls.Add(this.btnCat1);
            this.Controls.Add(this.btnClient1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfataProdus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfataProdus";
            this.Load += new System.EventHandler(this.InterfataProdus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afisareProduse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClient1;
        private System.Windows.Forms.Button btnCat1;
        private System.Windows.Forms.Button btnAdauga1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnSterge1;
        private System.Windows.Forms.Button btnIesire1;
        private System.Windows.Forms.TextBox txtPretP;
        private System.Windows.Forms.TextBox txtTipP;
        private System.Windows.Forms.TextBox txtNumeP;
        private System.Windows.Forms.ComboBox selectareCategorie;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView afisareProduse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkDec1;
    }
}