namespace DXApplication7
{
    partial class Firma
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.firmaguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.firmasil = new DevExpress.XtraEditors.SimpleButton();
            this.firmakayıit = new DevExpress.XtraEditors.SimpleButton();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tel = new DevExpress.XtraEditors.TextEdit();
            this.yetkili = new DevExpress.XtraEditors.TextEdit();
            this.firmaadi = new DevExpress.XtraEditors.TextEdit();
            this.gridControlfirma = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlfirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.id);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.radioButton2);
            this.groupControl1.Controls.Add(this.radioButton1);
            this.groupControl1.Controls.Add(this.searchControl1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.firmaguncelle);
            this.groupControl1.Controls.Add(this.firmasil);
            this.groupControl1.Controls.Add(this.firmakayıit);
            this.groupControl1.Controls.Add(this.adres);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tel);
            this.groupControl1.Controls.Add(this.yetkili);
            this.groupControl1.Controls.Add(this.firmaadi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 310);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(749, 295);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "FirmaBilgiKayitSayfasi";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(101, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 17;
            this.id.Visible = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(485, 241);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "FirmaAra";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(543, 167);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yetkili";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(428, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Firmaadi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(414, 82);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(223, 20);
            this.searchControl1.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(503, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 51);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Firma Ara";
            // 
            // firmaguncelle
            // 
            this.firmaguncelle.Location = new System.Drawing.Point(178, 241);
            this.firmaguncelle.Name = "firmaguncelle";
            this.firmaguncelle.Size = new System.Drawing.Size(76, 23);
            this.firmaguncelle.TabIndex = 11;
            this.firmaguncelle.Text = "FirmaGüncelle";
            this.firmaguncelle.Click += new System.EventHandler(this.firmaguncelle_Click);
            // 
            // firmasil
            // 
            this.firmasil.Location = new System.Drawing.Point(91, 241);
            this.firmasil.Name = "firmasil";
            this.firmasil.Size = new System.Drawing.Size(67, 23);
            this.firmasil.TabIndex = 10;
            this.firmasil.Text = "Firmasil";
            this.firmasil.Click += new System.EventHandler(this.firmasil_Click);
            // 
            // firmakayıit
            // 
            this.firmakayıit.Location = new System.Drawing.Point(12, 240);
            this.firmakayıit.Name = "firmakayıit";
            this.firmakayıit.Size = new System.Drawing.Size(73, 24);
            this.firmakayıit.TabIndex = 9;
            this.firmakayıit.Text = "Firmakayit";
            this.firmakayıit.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(80, 73);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(191, 53);
            this.adres.TabIndex = 8;
            this.adres.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tel";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "yetkili";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "adresi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Firmaadi";
            // 
            // tel
            // 
            this.tel.EditValue = "";
            this.tel.Location = new System.Drawing.Point(79, 191);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(192, 20);
            this.tel.TabIndex = 3;
            // 
            // yetkili
            // 
            this.yetkili.Location = new System.Drawing.Point(79, 141);
            this.yetkili.Name = "yetkili";
            this.yetkili.Size = new System.Drawing.Size(192, 20);
            this.yetkili.TabIndex = 2;
            // 
            // firmaadi
            // 
            this.firmaadi.Location = new System.Drawing.Point(80, 35);
            this.firmaadi.Name = "firmaadi";
            this.firmaadi.Size = new System.Drawing.Size(191, 20);
            this.firmaadi.TabIndex = 0;
            // 
            // gridControlfirma
            // 
            this.gridControlfirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlfirma.Location = new System.Drawing.Point(0, 0);
            this.gridControlfirma.MainView = this.gridView1;
            this.gridControlfirma.Name = "gridControlfirma";
            this.gridControlfirma.Size = new System.Drawing.Size(749, 310);
            this.gridControlfirma.TabIndex = 1;
            this.gridControlfirma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlfirma.Click += new System.EventHandler(this.id_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlfirma;
            this.gridView1.Name = "gridView1";
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 605);
            this.Controls.Add(this.gridControlfirma);
            this.Controls.Add(this.groupControl1);
            this.Name = "Firma";
            this.Text = "Firma";
            this.Load += new System.EventHandler(this.Firma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlfirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton firmaguncelle;
        private DevExpress.XtraEditors.SimpleButton firmasil;
        private DevExpress.XtraEditors.SimpleButton firmakayıit;
        private System.Windows.Forms.RichTextBox adres;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tel;
        private DevExpress.XtraEditors.TextEdit yetkili;
        private DevExpress.XtraEditors.TextEdit firmaadi;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControlfirma;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit id;
    }
}