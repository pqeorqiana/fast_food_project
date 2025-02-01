namespace proiect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.selectareRol = new System.Windows.Forms.ComboBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnLogare = new System.Windows.Forms.Button();
            this.linkG = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnIesire4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(171, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";
            // 
            // selectareRol
            // 
            this.selectareRol.Font = new System.Drawing.Font("MV Boli", 10F);
            this.selectareRol.ForeColor = System.Drawing.Color.Tan;
            this.selectareRol.FormattingEnabled = true;
            this.selectareRol.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.selectareRol.Location = new System.Drawing.Point(244, 271);
            this.selectareRol.Name = "selectareRol";
            this.selectareRol.Size = new System.Drawing.Size(173, 25);
            this.selectareRol.TabIndex = 1;
            this.selectareRol.TabStop = false;
            this.selectareRol.Text = "Selecteaza rolul";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtNume.Location = new System.Drawing.Point(244, 315);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(173, 27);
            this.txtNume.TabIndex = 2;
            // 
            // btnLogare
            // 
            this.btnLogare.BackColor = System.Drawing.Color.Tan;
            this.btnLogare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogare.Font = new System.Drawing.Font("MV Boli", 14F);
            this.btnLogare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogare.Location = new System.Drawing.Point(244, 412);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(173, 37);
            this.btnLogare.TabIndex = 3;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = false;
            this.btnLogare.Click += new System.EventHandler(this.btnLogare_Click);
            // 
            // linkG
            // 
            this.linkG.AutoSize = true;
            this.linkG.BackColor = System.Drawing.Color.White;
            this.linkG.Font = new System.Drawing.Font("MV Boli", 14F);
            this.linkG.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkG.Location = new System.Drawing.Point(117, 418);
            this.linkG.Name = "linkG";
            this.linkG.Size = new System.Drawing.Size(112, 25);
            this.linkG.TabIndex = 4;
            this.linkG.TabStop = true;
            this.linkG.Text = "Inregistrare";
            this.linkG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkG_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(171, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(171, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parola";
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("MV Boli", 9F);
            this.txtParola.Location = new System.Drawing.Point(244, 362);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(173, 27);
            this.txtParola.TabIndex = 7;
            // 
            // btnIesire4
            // 
            this.btnIesire4.BackColor = System.Drawing.Color.Tan;
            this.btnIesire4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire4.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnIesire4.ForeColor = System.Drawing.Color.Maroon;
            this.btnIesire4.Location = new System.Drawing.Point(546, 559);
            this.btnIesire4.Name = "btnIesire4";
            this.btnIesire4.Size = new System.Drawing.Size(23, 33);
            this.btnIesire4.TabIndex = 18;
            this.btnIesire4.Text = "X";
            this.btnIesire4.UseVisualStyleBackColor = false;
            this.btnIesire4.Click += new System.EventHandler(this.btnIesire4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(619, 604);
            this.Controls.Add(this.btnIesire4);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkG);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.selectareRol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectareRol;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.LinkLabel linkG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnIesire4;
    }
}

