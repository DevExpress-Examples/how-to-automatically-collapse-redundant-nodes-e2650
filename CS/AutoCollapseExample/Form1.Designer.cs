namespace AutoCollapseExample {
    partial class MainForm {
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Level 1 A"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Level 2 A"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Level 3 A"}, 1);
            this.treeList1.AppendNode(new object[] {
            "Level 2 B"}, 0);
            this.treeList1.AppendNode(new object[] {
            "Level 3 B"}, 3);
            this.treeList1.AppendNode(new object[] {
            "Level 1 B"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Level 2 C"}, 5);
            this.treeList1.AppendNode(new object[] {
            "Level 3 C"}, 6);
            this.treeList1.AppendNode(new object[] {
            "Level 2 D"}, 5);
            this.treeList1.AppendNode(new object[] {
            "Level 3 D"}, 8);
            this.treeList1.AppendNode(new object[] {
            "Level 1 C"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Level 2 E"}, 10);
            this.treeList1.AppendNode(new object[] {
            "Level 3 E"}, 11);
            this.treeList1.AppendNode(new object[] {
            "Level 2 F"}, 10);
            this.treeList1.AppendNode(new object[] {
            "Level 3 F"}, 13);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(401, 268);
            this.treeList1.TabIndex = 0;
            this.treeList1.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.OnTreeListAfterExpand);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 56;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 268);
            this.Controls.Add(this.treeList1);
            this.Name = "MainForm";
            this.Text = "Dx Sample";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}

