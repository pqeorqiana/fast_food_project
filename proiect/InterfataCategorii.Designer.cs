namespace proiect
{
    partial class InterfataCategorii
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfataCategorii));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.afisareCategorii = new System.Windows.Forms.DataGridView();
            this.txtNumeCat = new System.Windows.Forms.TextBox();
            this.linkDec3 = new System.Windows.Forms.LinkLabel();
            this.btnAdauga3 = new System.Windows.Forms.Button();
            this.btnUpdate3 = new System.Windows.Forms.Button();
            this.btnSterge3 = new System.Windows.Forms.Button();
            this.txtIdCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCat3 = new System.Windows.Forms.Button();
            this.btnProdus3 = new System.Windows.Forms.Button();
            this.btnIesire3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afisareCategorii)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.afisareCategorii);
            this.panel1.Controls.Add(this.txtNumeCat);
            this.panel1.Controls.Add(this.linkDec3);
            this.panel1.Controls.Add(this.btnAdauga3);
            this.panel1.Controls.Add(this.btnUpdate3);
            this.panel1.Controls.Add(this.btnSterge3);
            this.panel1.Controls.Add(this.txtIdCat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 355);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Location = new System.Drawing.Point(266, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 355);
            this.panel3.TabIndex = 19;
            // 
            // afisareCategorii
            // 
            this.afisareCategorii.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.afisareCategorii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.afisareCategorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afisareCategorii.Location = new System.Drawing.Point(282, 3);
            this.afisareCategorii.Name = "afisareCategorii";
            this.afisareCategorii.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisareCategorii.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.afisareCategorii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.afisareCategorii.ShowEditingIcon = false;
            this.afisareCategorii.Size = new System.Drawing.Size(454, 347);
            this.afisareCategorii.TabIndex = 10;
            this.afisareCategorii.TabStop = false;
            this.afisareCategorii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.afisareCategorii_CellContentClick);
            // 
            // txtNumeCat
            // 
            this.txtNumeCat.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtNumeCat.Location = new System.Drawing.Point(111, 88);
            this.txtNumeCat.Name = "txtNumeCat";
            this.txtNumeCat.Size = new System.Drawing.Size(148, 27);
            this.txtNumeCat.TabIndex = 7;
            // 
            // linkDec3
            // 
            this.linkDec3.AutoSize = true;
            this.linkDec3.BackColor = System.Drawing.Color.FloralWhite;
            this.linkDec3.Font = new System.Drawing.Font("MV Boli", 10F);
            this.linkDec3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkDec3.Location = new System.Drawing.Point(15, 292);
            this.linkDec3.Name = "linkDec3";
            this.linkDec3.Size = new System.Drawing.Size(86, 18);
            this.linkDec3.TabIndex = 27;
            this.linkDec3.TabStop = true;
            this.linkDec3.Text = "Deconectare";
            this.linkDec3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDec3_LinkClicked);
            // 
            // btnAdauga3
            // 
            this.btnAdauga3.BackColor = System.Drawing.Color.Tan;
            this.btnAdauga3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnAdauga3.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdauga3.Location = new System.Drawing.Point(5, 181);
            this.btnAdauga3.Name = "btnAdauga3";
            this.btnAdauga3.Size = new System.Drawing.Size(81, 35);
            this.btnAdauga3.TabIndex = 22;
            this.btnAdauga3.Text = "Adauga";
            this.btnAdauga3.UseVisualStyleBackColor = false;
            this.btnAdauga3.Click += new System.EventHandler(this.btnAdauga3_Click);
            // 
            // btnUpdate3
            // 
            this.btnUpdate3.BackColor = System.Drawing.Color.Tan;
            this.btnUpdate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnUpdate3.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate3.Location = new System.Drawing.Point(92, 181);
            this.btnUpdate3.Name = "btnUpdate3";
            this.btnUpdate3.Size = new System.Drawing.Size(81, 35);
            this.btnUpdate3.TabIndex = 25;
            this.btnUpdate3.Text = "Update";
            this.btnUpdate3.UseVisualStyleBackColor = false;
            this.btnUpdate3.Click += new System.EventHandler(this.btnUpdate3_Click);
            // 
            // btnSterge3
            // 
            this.btnSterge3.BackColor = System.Drawing.Color.Tan;
            this.btnSterge3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSterge3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnSterge3.ForeColor = System.Drawing.Color.Maroon;
            this.btnSterge3.Location = new System.Drawing.Point(179, 181);
            this.btnSterge3.Name = "btnSterge3";
            this.btnSterge3.Size = new System.Drawing.Size(81, 35);
            this.btnSterge3.TabIndex = 24;
            this.btnSterge3.Text = "Sterge";
            this.btnSterge3.UseVisualStyleBackColor = false;
            this.btnSterge3.Click += new System.EventHandler(this.btnSterge3_Click);
            // 
            // txtIdCat
            // 
            this.txtIdCat.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtIdCat.Location = new System.Drawing.Point(111, 51);
            this.txtIdCat.Name = "txtIdCat";
            this.txtIdCat.Size = new System.Drawing.Size(148, 27);
            this.txtIdCat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnCat3
            // 
            this.btnCat3.BackColor = System.Drawing.Color.Tan;
            this.btnCat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnCat3.ForeColor = System.Drawing.Color.Maroon;
            this.btnCat3.Location = new System.Drawing.Point(628, 43);
            this.btnCat3.Name = "btnCat3";
            this.btnCat3.Size = new System.Drawing.Size(125, 35);
            this.btnCat3.TabIndex = 23;
            this.btnCat3.Text = "Clienti";
            this.btnCat3.UseVisualStyleBackColor = false;
            this.btnCat3.Click += new System.EventHandler(this.btnCat3_Click);
            // 
            // btnProdus3
            // 
            this.btnProdus3.BackColor = System.Drawing.Color.Tan;
            this.btnProdus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdus3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnProdus3.ForeColor = System.Drawing.Color.Maroon;
            this.btnProdus3.Location = new System.Drawing.Point(12, 43);
            this.btnProdus3.Name = "btnProdus3";
            this.btnProdus3.Size = new System.Drawing.Size(125, 35);
            this.btnProdus3.TabIndex = 21;
            this.btnProdus3.Text = "Produse";
            this.btnProdus3.UseVisualStyleBackColor = false;
            this.btnProdus3.Click += new System.EventHandler(this.btnProdus3_Click);
            // 
            // btnIesire3
            // 
            this.btnIesire3.BackColor = System.Drawing.Color.Tan;
            this.btnIesire3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnIesire3.ForeColor = System.Drawing.Color.Maroon;
            this.btnIesire3.Location = new System.Drawing.Point(0, 0);
            this.btnIesire3.Name = "btnIesire3";
            this.btnIesire3.Size = new System.Drawing.Size(23, 33);
            this.btnIesire3.TabIndex = 26;
            this.btnIesire3.Text = "X";
            this.btnIesire3.UseVisualStyleBackColor = false;
            this.btnIesire3.Click += new System.EventHandler(this.btnIesire3_Click);
            // 
            // InterfataCategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(765, 445);
            this.Controls.Add(this.btnCat3);
            this.Controls.Add(this.btnProdus3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIesire3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfataCategorii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfataCategorii";
            this.Load += new System.EventHandler(this.InterfataCategorii_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afisareCategorii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView afisareCategorii;
        private System.Windows.Forms.TextBox txtNumeCat;
        private System.Windows.Forms.TextBox txtIdCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCat3;
        private System.Windows.Forms.Button btnProdus3;
        private System.Windows.Forms.LinkLabel linkDec3;
        private System.Windows.Forms.Button btnIesire3;
        private System.Windows.Forms.Button btnSterge3;
        private System.Windows.Forms.Button btnUpdate3;
        private System.Windows.Forms.Button btnAdauga3;
    }
}