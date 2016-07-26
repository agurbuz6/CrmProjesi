namespace DXApplication7
{
    partial class carikartlar
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.firma = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.alinan = new DevExpress.XtraEditors.TextEdit();
            this.aciklama = new DevExpress.XtraEditors.TextEdit();
            this.verilen = new DevExpress.XtraEditors.TextEdit();
            this.islem = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.id);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.firma);
            this.groupControl1.Controls.Add(this.tarih);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.alinan);
            this.groupControl1.Controls.Add(this.aciklama);
            this.groupControl1.Controls.Add(this.verilen);
            this.groupControl1.Controls.Add(this.islem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 256);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(808, 263);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "CariKartBilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(527, 198);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(131, 66);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "CARİGUNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(303, 198);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(136, 66);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "CARİSİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(121, 197);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(134, 66);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "CARİKAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // firma
            // 
            this.firma.Location = new System.Drawing.Point(91, 76);
            this.firma.Name = "firma";
            this.firma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.firma.Size = new System.Drawing.Size(183, 20);
            this.firma.TabIndex = 13;
            // 
            // tarih
            // 
            this.tarih.EditValue = null;
            this.tarih.Location = new System.Drawing.Point(91, 42);
            this.tarih.Name = "tarih";
            this.tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarih.Size = new System.Drawing.Size(180, 20);
            this.tarih.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(367, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Aciklama";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(376, 83);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Verilen\r\n";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(376, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "alinan";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "İslem ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Firma";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tarih ";
            // 
            // alinan
            // 
            this.alinan.Location = new System.Drawing.Point(440, 42);
            this.alinan.Name = "alinan";
            this.alinan.Size = new System.Drawing.Size(180, 20);
            this.alinan.TabIndex = 5;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(440, 115);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(181, 20);
            this.aciklama.TabIndex = 4;
            // 
            // verilen
            // 
            this.verilen.Location = new System.Drawing.Point(440, 76);
            this.verilen.Name = "verilen";
            this.verilen.Size = new System.Drawing.Size(180, 20);
            this.verilen.TabIndex = 3;
            // 
            // islem
            // 
            this.islem.Location = new System.Drawing.Point(91, 111);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(180, 20);
            this.islem.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(808, 256);
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
            // id
            // 
            this.id.Location = new System.Drawing.Point(91, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 17;
            this.id.Visible = false;
            // 
            // carikartlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 519);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "carikartlar";
            this.Text = "carikartlar";
            this.Load += new System.EventHandler(this.carikartlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit firma;
        private DevExpress.XtraEditors.DateEdit tarih;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit alinan;
        private DevExpress.XtraEditors.TextEdit aciklama;
        private DevExpress.XtraEditors.TextEdit verilen;
        private DevExpress.XtraEditors.TextEdit islem;
        private DevExpress.XtraEditors.TextEdit id;
    }
}