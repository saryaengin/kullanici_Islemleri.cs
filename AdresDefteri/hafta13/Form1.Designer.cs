namespace hafta13
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
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgVeriler = new System.Windows.Forms.DataGridView();
            this.btnKytEkle = new System.Windows.Forms.Button();
            this.btnKytSil = new System.Windows.Forms.Button();
            this.btnKytGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.txtTcNo, "txtTcNo");
            this.txtTcNo.Name = "txtTcNo";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.txtAd, "txtAd");
            this.txtAd.Name = "txtAd";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.txtSoyad, "txtSoyad");
            this.txtSoyad.Name = "txtSoyad";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.txtAdres, "txtAdres");
            this.txtAdres.Name = "txtAdres";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dgVeriler
            // 
            this.dgVeriler.AllowUserToAddRows = false;
            this.dgVeriler.AllowUserToDeleteRows = false;
            this.dgVeriler.AllowUserToResizeColumns = false;
            this.dgVeriler.AllowUserToResizeRows = false;
            this.dgVeriler.BackgroundColor = System.Drawing.Color.Plum;
            this.dgVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeriler.GridColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.dgVeriler, "dgVeriler");
            this.dgVeriler.Name = "dgVeriler";
            this.dgVeriler.ReadOnly = true;
            this.dgVeriler.RowTemplate.Height = 24;
            this.dgVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVeriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeriler_CellContentClick);
            this.dgVeriler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeriler_RowEnter);
            this.dgVeriler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgVeriler_MouseDoubleClick);
            // 
            // btnKytEkle
            // 
            this.btnKytEkle.BackColor = System.Drawing.Color.DarkMagenta;
            resources.ApplyResources(this.btnKytEkle, "btnKytEkle");
            this.btnKytEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKytEkle.Name = "btnKytEkle";
            this.btnKytEkle.UseVisualStyleBackColor = false;
            this.btnKytEkle.Click += new System.EventHandler(this.btnKytEkle_Click);
            // 
            // btnKytSil
            // 
            this.btnKytSil.BackColor = System.Drawing.Color.DarkMagenta;
            resources.ApplyResources(this.btnKytSil, "btnKytSil");
            this.btnKytSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKytSil.Name = "btnKytSil";
            this.btnKytSil.UseVisualStyleBackColor = false;
            this.btnKytSil.Click += new System.EventHandler(this.BtnKytSil_Click);
            // 
            // btnKytGuncelle
            // 
            this.btnKytGuncelle.BackColor = System.Drawing.Color.DarkMagenta;
            resources.ApplyResources(this.btnKytGuncelle, "btnKytGuncelle");
            this.btnKytGuncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKytGuncelle.Name = "btnKytGuncelle";
            this.btnKytGuncelle.UseVisualStyleBackColor = false;
            this.btnKytGuncelle.Click += new System.EventHandler(this.btnKytGuncelle_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.Controls.Add(this.btnKytGuncelle);
            this.Controls.Add(this.btnKytSil);
            this.Controls.Add(this.btnKytEkle);
            this.Controls.Add(this.dgVeriler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcNo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgVeriler;
        private System.Windows.Forms.Button btnKytEkle;
        private System.Windows.Forms.Button btnKytSil;
        private System.Windows.Forms.Button btnKytGuncelle;
    }
}

