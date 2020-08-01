namespace Tile
{
  partial class formMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panlSourceImage = new System.Windows.Forms.Panel();
            this.picbSource = new System.Windows.Forms.PictureBox();
            this.picbDest = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftRaftingContainer = new System.Windows.Forms.ToolStripContainer();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rightRaftingContainer = new System.Windows.Forms.ToolStripContainer();
            this.topRaftingContainer = new System.Windows.Forms.ToolStripContainer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.bottomRaftingContainer = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSourceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDestinationImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setoutputimagesizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panlSourceImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbDest)).BeginInit();
            this.leftRaftingContainer.ContentPanel.SuspendLayout();
            this.leftRaftingContainer.SuspendLayout();
            this.rightRaftingContainer.SuspendLayout();
            this.topRaftingContainer.SuspendLayout();
            this.bottomRaftingContainer.ContentPanel.SuspendLayout();
            this.bottomRaftingContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panlSourceImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picbDest);
            this.splitContainer1.Size = new System.Drawing.Size(652, 416);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // panlSourceImage
            // 
            this.panlSourceImage.AutoScroll = true;
            this.panlSourceImage.AutoSize = true;
            this.panlSourceImage.Controls.Add(this.picbSource);
            this.panlSourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panlSourceImage.Location = new System.Drawing.Point(0, 0);
            this.panlSourceImage.Name = "panlSourceImage";
            this.panlSourceImage.Size = new System.Drawing.Size(218, 416);
            this.panlSourceImage.TabIndex = 4;
            this.panlSourceImage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panlSourceImage_Scroll);
            // 
            // picbSource
            // 
            this.picbSource.Location = new System.Drawing.Point(0, 0);
            this.picbSource.Name = "picbSource";
            this.picbSource.Size = new System.Drawing.Size(108, 151);
            this.picbSource.TabIndex = 0;
            this.picbSource.TabStop = false;
            this.picbSource.Paint += new System.Windows.Forms.PaintEventHandler(this.picbSource_Paint);
            this.picbSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SourceDClick);
            // 
            // picbDest
            // 
            this.picbDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbDest.Location = new System.Drawing.Point(0, 0);
            this.picbDest.Name = "picbDest";
            this.picbDest.Size = new System.Drawing.Size(430, 416);
            this.picbDest.TabIndex = 0;
            this.picbDest.TabStop = false;
            this.picbDest.Paint += new System.Windows.Forms.PaintEventHandler(this.picbDest_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.Filter = "All  Files|*.*|JPEG files|*.jpg|Bitmap Files|*.bmp|GIF Files|*.gif|TIFF Files|*.t" +
    "iff|PNG Files|*.png";
            this.openFileDialog1.InitialDirectory = "f:\\\\Work";
            this.openFileDialog1.Title = "Load Source Image";
            // 
            // leftRaftingContainer
            // 
            this.leftRaftingContainer.BottomToolStripPanelVisible = false;
            // 
            // leftRaftingContainer.ContentPanel
            // 
            this.leftRaftingContainer.ContentPanel.Controls.Add(this.status);
            this.leftRaftingContainer.ContentPanel.Size = new System.Drawing.Size(652, 416);
            this.leftRaftingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftRaftingContainer.LeftToolStripPanelVisible = false;
            this.leftRaftingContainer.Location = new System.Drawing.Point(0, 0);
            this.leftRaftingContainer.Name = "leftRaftingContainer";
            this.leftRaftingContainer.RightToolStripPanelVisible = false;
            this.leftRaftingContainer.Size = new System.Drawing.Size(652, 416);
            this.leftRaftingContainer.TabIndex = 5;
            this.leftRaftingContainer.TopToolStripPanelVisible = false;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 394);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(652, 22);
            this.status.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // rightRaftingContainer
            // 
            this.rightRaftingContainer.BottomToolStripPanelVisible = false;
            // 
            // rightRaftingContainer.ContentPanel
            // 
            this.rightRaftingContainer.ContentPanel.Size = new System.Drawing.Size(652, 441);
            this.rightRaftingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightRaftingContainer.LeftToolStripPanelVisible = false;
            this.rightRaftingContainer.Location = new System.Drawing.Point(0, 0);
            this.rightRaftingContainer.Name = "rightRaftingContainer";
            this.rightRaftingContainer.RightToolStripPanelVisible = false;
            this.rightRaftingContainer.Size = new System.Drawing.Size(652, 441);
            this.rightRaftingContainer.TabIndex = 6;
            this.rightRaftingContainer.TopToolStripPanelVisible = false;
            // 
            // topRaftingContainer
            // 
            // 
            // topRaftingContainer.ContentPanel
            // 
            this.topRaftingContainer.ContentPanel.Size = new System.Drawing.Size(652, 416);
            this.topRaftingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRaftingContainer.Location = new System.Drawing.Point(0, 0);
            this.topRaftingContainer.Name = "topRaftingContainer";
            this.topRaftingContainer.Size = new System.Drawing.Size(652, 441);
            this.topRaftingContainer.TabIndex = 8;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "JPEG files|*.jpg|Bitmap Files|*.bmp|GIF Files|*.gif|TIFF Files|*.tiff|PNG Files|*" +
    ".png";
            this.saveFileDialog1.Title = "Save Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(200, 100);
            // 
            // bottomRaftingContainer
            // 
            this.bottomRaftingContainer.BottomToolStripPanelVisible = false;
            // 
            // bottomRaftingContainer.ContentPanel
            // 
            this.bottomRaftingContainer.ContentPanel.AutoScroll = true;
            this.bottomRaftingContainer.ContentPanel.Controls.Add(this.splitContainer1);
            this.bottomRaftingContainer.ContentPanel.Controls.Add(this.leftRaftingContainer);
            this.bottomRaftingContainer.ContentPanel.Size = new System.Drawing.Size(652, 416);
            this.bottomRaftingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRaftingContainer.LeftToolStripPanelVisible = false;
            this.bottomRaftingContainer.Location = new System.Drawing.Point(0, 0);
            this.bottomRaftingContainer.Name = "bottomRaftingContainer";
            this.bottomRaftingContainer.Size = new System.Drawing.Size(652, 441);
            this.bottomRaftingContainer.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSourceImageToolStripMenuItem,
            this.saveDestinationImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.setoutputimagesizeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSourceImageToolStripMenuItem
            // 
            this.loadSourceImageToolStripMenuItem.Name = "loadSourceImageToolStripMenuItem";
            this.loadSourceImageToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.loadSourceImageToolStripMenuItem.Text = "Load Source Image...";
            this.loadSourceImageToolStripMenuItem.Click += new System.EventHandler(this.menuLoadSource);
            // 
            // saveDestinationImageToolStripMenuItem
            // 
            this.saveDestinationImageToolStripMenuItem.Name = "saveDestinationImageToolStripMenuItem";
            this.saveDestinationImageToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveDestinationImageToolStripMenuItem.Text = "Save Image...";
            this.saveDestinationImageToolStripMenuItem.Click += new System.EventHandler(this.menuSaveImage);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // setoutputimagesizeToolStripMenuItem
            // 
            this.setoutputimagesizeToolStripMenuItem.Name = "setoutputimagesizeToolStripMenuItem";
            this.setoutputimagesizeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.setoutputimagesizeToolStripMenuItem.Text = "Set output image size...";
            this.setoutputimagesizeToolStripMenuItem.Click += new System.EventHandler(this.SetImageFileSize);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bottomRaftingContainer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.topRaftingContainer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rightRaftingContainer);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(652, 441);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(652, 465);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(652, 465);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "formMain";
            this.Text = "Tesselator  -  AJB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panlSourceImage.ResumeLayout(false);
            this.panlSourceImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbDest)).EndInit();
            this.leftRaftingContainer.ContentPanel.ResumeLayout(false);
            this.leftRaftingContainer.ContentPanel.PerformLayout();
            this.leftRaftingContainer.ResumeLayout(false);
            this.leftRaftingContainer.PerformLayout();
            this.rightRaftingContainer.ResumeLayout(false);
            this.rightRaftingContainer.PerformLayout();
            this.topRaftingContainer.ResumeLayout(false);
            this.topRaftingContainer.PerformLayout();
            this.bottomRaftingContainer.ContentPanel.ResumeLayout(false);
            this.bottomRaftingContainer.ResumeLayout(false);
            this.bottomRaftingContainer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panlSourceImage;
    private System.Windows.Forms.PictureBox picbSource;
    private System.Windows.Forms.PictureBox picbDest;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripContainer leftRaftingContainer;
    private System.Windows.Forms.ToolStripContainer rightRaftingContainer;
    private System.Windows.Forms.ToolStripContainer topRaftingContainer;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripContainer bottomRaftingContainer;
    private System.Windows.Forms.StatusStrip status;
    //private System.Windows.Forms.StatusStripPanel status1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
    private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
    private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
    private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
    private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadSourceImageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveDestinationImageToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem setoutputimagesizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
  }
}

