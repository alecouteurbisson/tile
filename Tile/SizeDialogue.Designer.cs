namespace Tile
{
  partial class SizeDialogue
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
      if(disposing && (components != null))
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
      this.numRows = new System.Windows.Forms.NumericUpDown();
      this.numCols = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.numHeight = new System.Windows.Forms.NumericUpDown();
      this.numWidth = new System.Windows.Forms.NumericUpDown();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
      this.SuspendLayout();
// 
// numRows
// 
      this.numRows.Location = new System.Drawing.Point(71, 62);
      this.numRows.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
      this.numRows.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.numRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numRows.Name = "numRows";
      this.numRows.Size = new System.Drawing.Size(78, 20);
      this.numRows.TabIndex = 0;
      this.numRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numRows.ValueChanged += new System.EventHandler(this.MultChanged);
// 
// numCols
// 
      this.numCols.Location = new System.Drawing.Point(71, 35);
      this.numCols.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.numCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numCols.Name = "numCols";
      this.numCols.Size = new System.Drawing.Size(78, 20);
      this.numCols.TabIndex = 1;
      this.numCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numCols.ValueChanged += new System.EventHandler(this.MultChanged);
// 
// label1
// 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 14);
      this.label1.TabIndex = 2;
      this.label1.Text = "Rows";
// 
// label2
// 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 14);
      this.label2.TabIndex = 3;
      this.label2.Text = "Columns";
// 
// button1
// 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(178, 100);
      this.button1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(87, 25);
      this.button1.TabIndex = 4;
      this.button1.Text = "OK";
// 
// button2
// 
      this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button2.Location = new System.Drawing.Point(272, 100);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(87, 25);
      this.button2.TabIndex = 5;
      this.button2.Text = "Cancel";
// 
// label3
// 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(178, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 14);
      this.label3.TabIndex = 9;
      this.label3.Text = "Height";
// 
// label4
// 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(178, 41);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 14);
      this.label4.TabIndex = 8;
      this.label4.Text = "Width";
// 
// numHeight
// 
      this.numHeight.Location = new System.Drawing.Point(238, 62);
      this.numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numHeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.numHeight.Name = "numHeight";
      this.numHeight.Size = new System.Drawing.Size(78, 20);
      this.numHeight.TabIndex = 7;
      this.numHeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
// 
// numWidth
// 
      this.numWidth.Location = new System.Drawing.Point(238, 35);
      this.numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numWidth.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
      this.numWidth.Name = "numWidth";
      this.numWidth.Size = new System.Drawing.Size(78, 20);
      this.numWidth.TabIndex = 6;
      this.numWidth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
// 
// checkBox1
// 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(13, 13);
      this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(126, 17);
      this.checkBox1.TabIndex = 10;
      this.checkBox1.Text = "Use tile size multipliers";
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
// 
// label5
// 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(176, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 14);
      this.label5.TabIndex = 11;
      this.label5.Text = "label5";
// 
// SizeDialogue
// 
      this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
      this.ClientSize = new System.Drawing.Size(363, 137);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numHeight);
      this.Controls.Add(this.numWidth);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numCols);
      this.Controls.Add(this.numRows);
      this.Name = "SizeDialogue";
      this.Text = "Output file size";
      ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numRows;
    private System.Windows.Forms.NumericUpDown numCols;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numHeight;
    private System.Windows.Forms.NumericUpDown numWidth;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label5;
  }
}

