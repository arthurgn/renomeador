
namespace renomeador
{
    partial class frmrenomeador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrenomeador));
            this.btnadicionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnremover = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkremoverseigual = new DevExpress.XtraEditors.CheckEdit();
            this.btndiretorio = new DevExpress.XtraEditors.SimpleButton();
            this.chkmaisculo = new DevExpress.XtraEditors.CheckEdit();
            this.chkminusculo = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbdireitorio = new System.Windows.Forms.TextBox();
            this.btnrenomear = new DevExpress.XtraEditors.SimpleButton();
            this.grdalteracoes = new DevExpress.XtraGrid.GridControl();
            this.grvalteracoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tbalteracoes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkremoverseigual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkmaisculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkminusculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdalteracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvalteracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(327, 103);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(106, 40);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(464, 103);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(106, 40);
            this.btnremover.TabIndex = 2;
            this.btnremover.Text = "remover";
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkremoverseigual);
            this.groupControl1.Controls.Add(this.btndiretorio);
            this.groupControl1.Controls.Add(this.chkmaisculo);
            this.groupControl1.Controls.Add(this.chkminusculo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.tbdireitorio);
            this.groupControl1.Controls.Add(this.btnrenomear);
            this.groupControl1.Controls.Add(this.grdalteracoes);
            this.groupControl1.Controls.Add(this.btnadicionar);
            this.groupControl1.Controls.Add(this.btnremover);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(582, 312);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // chkremoverseigual
            // 
            this.chkremoverseigual.Location = new System.Drawing.Point(330, 211);
            this.chkremoverseigual.Name = "chkremoverseigual";
            this.chkremoverseigual.Properties.Caption = "remover se igual?";
            this.chkremoverseigual.Size = new System.Drawing.Size(139, 20);
            this.chkremoverseigual.TabIndex = 10;
            // 
            // btndiretorio
            // 
            this.btndiretorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndiretorio.ImageOptions.Image")));
            this.btndiretorio.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btndiretorio.Location = new System.Drawing.Point(550, 22);
            this.btndiretorio.Name = "btndiretorio";
            this.btndiretorio.Size = new System.Drawing.Size(27, 26);
            this.btndiretorio.TabIndex = 9;
            this.btndiretorio.Click += new System.EventHandler(this.btndiretorio_Click);
            // 
            // chkmaisculo
            // 
            this.chkmaisculo.Location = new System.Drawing.Point(438, 185);
            this.chkmaisculo.Name = "chkmaisculo";
            this.chkmaisculo.Properties.Caption = "maisculo";
            this.chkmaisculo.Size = new System.Drawing.Size(103, 20);
            this.chkmaisculo.TabIndex = 8;
            this.chkmaisculo.CheckedChanged += new System.EventHandler(this.chkmaisculo_CheckedChanged);
            // 
            // chkminusculo
            // 
            this.chkminusculo.Location = new System.Drawing.Point(329, 185);
            this.chkminusculo.Name = "chkminusculo";
            this.chkminusculo.Properties.Caption = "minusculo";
            this.chkminusculo.Size = new System.Drawing.Size(103, 20);
            this.chkminusculo.TabIndex = 7;
            this.chkminusculo.CheckedChanged += new System.EventHandler(this.chkminusculo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "diretorio:";
            // 
            // tbdireitorio
            // 
            this.tbdireitorio.Location = new System.Drawing.Point(327, 25);
            this.tbdireitorio.Name = "tbdireitorio";
            this.tbdireitorio.Size = new System.Drawing.Size(221, 21);
            this.tbdireitorio.TabIndex = 5;
            // 
            // btnrenomear
            // 
            this.btnrenomear.Location = new System.Drawing.Point(327, 243);
            this.btnrenomear.Name = "btnrenomear";
            this.btnrenomear.Size = new System.Drawing.Size(243, 51);
            this.btnrenomear.TabIndex = 4;
            this.btnrenomear.Text = "renomear";
            this.btnrenomear.Click += new System.EventHandler(this.btnrenomear_Click);
            // 
            // grdalteracoes
            // 
            this.grdalteracoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdalteracoes.Location = new System.Drawing.Point(2, 2);
            this.grdalteracoes.MainView = this.grvalteracoes;
            this.grdalteracoes.Name = "grdalteracoes";
            this.grdalteracoes.Size = new System.Drawing.Size(279, 308);
            this.grdalteracoes.TabIndex = 3;
            this.grdalteracoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvalteracoes});
            // 
            // grvalteracoes
            // 
            this.grvalteracoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grvalteracoes.GridControl = this.grdalteracoes;
            this.grvalteracoes.Name = "grvalteracoes";
            this.grvalteracoes.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "antigo";
            this.gridColumn1.FieldName = "antigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "novo";
            this.gridColumn2.FieldName = "novo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tbalteracoes);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 312);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(582, 73);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "groupControl2";
            // 
            // tbalteracoes
            // 
            this.tbalteracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbalteracoes.Location = new System.Drawing.Point(2, 2);
            this.tbalteracoes.Multiline = true;
            this.tbalteracoes.Name = "tbalteracoes";
            this.tbalteracoes.ReadOnly = true;
            this.tbalteracoes.Size = new System.Drawing.Size(578, 69);
            this.tbalteracoes.TabIndex = 0;
            // 
            // frmrenomeador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 385);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrenomeador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "renomeador";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkremoverseigual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkmaisculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkminusculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdalteracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvalteracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnadicionar;
        private DevExpress.XtraEditors.SimpleButton btnremover;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdireitorio;
        private DevExpress.XtraEditors.SimpleButton btnrenomear;
        private DevExpress.XtraGrid.GridControl grdalteracoes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvalteracoes;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox tbalteracoes;
        private DevExpress.XtraEditors.CheckEdit chkmaisculo;
        private DevExpress.XtraEditors.CheckEdit chkminusculo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btndiretorio;
        private DevExpress.XtraEditors.CheckEdit chkremoverseigual;
    }
}