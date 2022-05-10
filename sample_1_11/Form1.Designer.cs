namespace sample_1_11 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.grid = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.navigator = new DevExpress.XtraEditors.DataNavigator();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.nameEdit = new DevExpress.XtraEditors.TextEdit();
      this.ageEdit = new DevExpress.XtraEditors.TextEdit();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ageEdit.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // grid
      // 
      this.grid.Location = new System.Drawing.Point(13, 13);
      this.grid.MainView = this.gridView1;
      this.grid.Name = "grid";
      this.grid.Size = new System.Drawing.Size(400, 283);
      this.grid.TabIndex = 0;
      this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.GridControl = this.grid;
      this.gridView1.Name = "gridView1";
      // 
      // navigator
      // 
      this.navigator.Location = new System.Drawing.Point(13, 302);
      this.navigator.Name = "navigator";
      this.navigator.Size = new System.Drawing.Size(400, 24);
      this.navigator.TabIndex = 1;
      this.navigator.Text = "dataNavigator1";
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(447, 13);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(27, 13);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Name";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(447, 71);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(19, 13);
      this.labelControl2.TabIndex = 3;
      this.labelControl2.Text = "Age";
      // 
      // nameEdit
      // 
      this.nameEdit.Location = new System.Drawing.Point(447, 33);
      this.nameEdit.Name = "nameEdit";
      this.nameEdit.Size = new System.Drawing.Size(164, 20);
      this.nameEdit.TabIndex = 4;
      // 
      // ageEdit
      // 
      this.ageEdit.Location = new System.Drawing.Point(447, 91);
      this.ageEdit.Name = "ageEdit";
      this.ageEdit.Size = new System.Drawing.Size(164, 20);
      this.ageEdit.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 336);
      this.Controls.Add(this.ageEdit);
      this.Controls.Add(this.nameEdit);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.navigator);
      this.Controls.Add(this.grid);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ageEdit.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraGrid.GridControl grid;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraEditors.DataNavigator navigator;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.TextEdit nameEdit;
    private DevExpress.XtraEditors.TextEdit ageEdit;
  }
}

