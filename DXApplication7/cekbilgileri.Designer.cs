namespace DXApplication7
{
    partial class cekbilgileri
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.durumu = new DevExpress.XtraEditors.TextEdit();
            this.guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.sil = new DevExpress.XtraEditors.SimpleButton();
            this.kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.aciklama = new System.Windows.Forms.RichTextBox();
            this.vadetarihi = new DevExpress.XtraEditors.DateEdit();
            this.verilistarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cekturu = new DevExpress.XtraEditors.TextEdit();
            this.tutar = new DevExpress.XtraEditors.TextEdit();
            this.ceknumarasi = new DevExpress.XtraEditors.TextEdit();
            this.banka = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vadetarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vadetarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilistarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilistarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekturu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceknumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.durumu);
            this.groupControl1.Controls.Add(this.guncelle);
            this.groupControl1.Controls.Add(this.sil);
            this.groupControl1.Controls.Add(this.kaydet);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.aciklama);
            this.groupControl1.Controls.Add(this.vadetarihi);
            this.groupControl1.Controls.Add(this.verilistarihi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cekturu);
            this.groupControl1.Controls.Add(this.tutar);
            this.groupControl1.Controls.Add(this.ceknumarasi);
            this.groupControl1.Controls.Add(this.banka);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 347);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(835, 403);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cek Bilgileri";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(107, 7);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 24;
            this.textEdit1.Visible = false;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // durumu
            // 
            this.durumu.Location = new System.Drawing.Point(391, 200);
            this.durumu.Name = "durumu";
            this.durumu.Size = new System.Drawing.Size(163, 20);
            this.durumu.TabIndex = 23;
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(424, 276);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(117, 23);
            this.guncelle.TabIndex = 22;
            this.guncelle.Text = "cekbilgileri güncelle";
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(290, 276);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(95, 23);
            this.sil.TabIndex = 21;
            this.sil.Text = "cekbilgileri sil";
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(80, 276);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(159, 23);
            this.kaydet.TabIndex = 20;
            this.kaydet.Text = "Cekbilgilerini kaydet";
            this.kaydet.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(344, 200);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Durumu";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(345, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "aciklama";
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(391, 82);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(163, 63);
            this.aciklama.TabIndex = 16;
            this.aciklama.Text = "";
            // 
            // vadetarihi
            // 
            this.vadetarihi.EditValue = null;
            this.vadetarihi.Location = new System.Drawing.Point(110, 95);
            this.vadetarihi.Name = "vadetarihi";
            this.vadetarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vadetarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vadetarihi.Size = new System.Drawing.Size(148, 20);
            this.vadetarihi.TabIndex = 15;
            // 
            // verilistarihi
            // 
            this.verilistarihi.EditValue = null;
            this.verilistarihi.Location = new System.Drawing.Point(113, 44);
            this.verilistarihi.Name = "verilistarihi";
            this.verilistarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.verilistarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.verilistarihi.Size = new System.Drawing.Size(146, 20);
            this.verilistarihi.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(345, 158);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "cektürü";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(361, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "tutar";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "ceknumarasi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 146);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "banka";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "vadetarihi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Cekverilistarihi";
            // 
            // cekturu
            // 
            this.cekturu.Location = new System.Drawing.Point(391, 155);
            this.cekturu.Name = "cekturu";
            this.cekturu.Size = new System.Drawing.Size(163, 20);
            this.cekturu.TabIndex = 5;
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(391, 40);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(163, 20);
            this.tutar.TabIndex = 4;
            // 
            // ceknumarasi
            // 
            this.ceknumarasi.Location = new System.Drawing.Point(109, 190);
            this.ceknumarasi.Name = "ceknumarasi";
            this.ceknumarasi.Size = new System.Drawing.Size(150, 20);
            this.ceknumarasi.TabIndex = 3;
            // 
            // banka
            // 
            this.banka.Location = new System.Drawing.Point(107, 139);
            this.banka.Name = "banka";
            this.banka.Size = new System.Drawing.Size(152, 20);
            this.banka.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(835, 347);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cekbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 750);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "cekbilgileri";
            this.Text = "cekbilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vadetarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vadetarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilistarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilistarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekturu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceknumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit cekturu;
        private DevExpress.XtraEditors.TextEdit tutar;
        private DevExpress.XtraEditors.TextEdit ceknumarasi;
        private DevExpress.XtraEditors.TextEdit banka;
        private DevExpress.XtraEditors.SimpleButton guncelle;
        private DevExpress.XtraEditors.SimpleButton sil;
        private DevExpress.XtraEditors.SimpleButton kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.RichTextBox aciklama;
        private DevExpress.XtraEditors.DateEdit vadetarihi;
        private DevExpress.XtraEditors.DateEdit verilistarihi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.TextEdit durumu;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}