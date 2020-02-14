namespace File_Explorer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.findPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.viewerContainer = new System.Windows.Forms.SplitContainer();
            this.treeViewer = new System.Windows.Forms.TreeView();
            this.listViewer = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifiedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.viewerContainer)).BeginInit();
            this.viewerContainer.Panel1.SuspendLayout();
            this.viewerContainer.Panel2.SuspendLayout();
            this.viewerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // findPanel
            // 
            this.findPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.findPanel.Location = new System.Drawing.Point(0, 0);
            this.findPanel.Name = "findPanel";
            this.findPanel.Size = new System.Drawing.Size(800, 32);
            this.findPanel.TabIndex = 0;
            // 
            // viewerContainer
            // 
            this.viewerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerContainer.Location = new System.Drawing.Point(0, 32);
            this.viewerContainer.Name = "viewerContainer";
            // 
            // viewerContainer.Panel1
            // 
            this.viewerContainer.Panel1.Controls.Add(this.treeViewer);
            // 
            // viewerContainer.Panel2
            // 
            this.viewerContainer.Panel2.Controls.Add(this.listViewer);
            this.viewerContainer.Size = new System.Drawing.Size(800, 454);
            this.viewerContainer.SplitterDistance = 266;
            this.viewerContainer.TabIndex = 1;
            // 
            // treeViewer
            // 
            this.treeViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewer.Location = new System.Drawing.Point(0, 0);
            this.treeViewer.Name = "treeViewer";
            this.treeViewer.Size = new System.Drawing.Size(266, 454);
            this.treeViewer.TabIndex = 0;
            this.treeViewer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewer_BeforeExpand);
            this.treeViewer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewer_AfterSelect);
            // 
            // listViewer
            // 
            this.listViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size,
            this.type,
            this.modifiedDate});
            this.listViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewer.HideSelection = false;
            this.listViewer.Location = new System.Drawing.Point(0, 0);
            this.listViewer.Name = "listViewer";
            this.listViewer.Size = new System.Drawing.Size(530, 454);
            this.listViewer.TabIndex = 0;
            this.listViewer.UseCompatibleStateImageBehavior = false;
            this.listViewer.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 150;
            // 
            // size
            // 
            this.size.Text = "크기";
            this.size.Width = 80;
            // 
            // type
            // 
            this.type.Text = "종류";
            this.type.Width = 100;
            // 
            // modifiedDate
            // 
            this.modifiedDate.Text = "수정한 날짜";
            this.modifiedDate.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.viewerContainer);
            this.Controls.Add(this.findPanel);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "File Exploerer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.viewerContainer.Panel1.ResumeLayout(false);
            this.viewerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewerContainer)).EndInit();
            this.viewerContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel findPanel;
        private System.Windows.Forms.SplitContainer viewerContainer;
        private System.Windows.Forms.TreeView treeViewer;
        private System.Windows.Forms.ListView listViewer;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader modifiedDate;
    }
}

