#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Tile
{
  public partial class SizeDialogue : Form
  {
    int tilew, tileh;

    public int W
    { get { return (int)numWidth.Value; } }

    public int H
    { get { return (int)numHeight.Value; } }

    public SizeDialogue(int w, int h, int tilew, int tileh )
    {
      InitializeComponent();
      checkBox1.Checked = false;
      numWidth.Value = w;
      numHeight.Value = h;
      numCols.Value = 1;
      numRows.Value = 1;
      label5.Text = string.Format("Repeat size = {0}x{1}", tilew, tileh);
      this.tilew = tilew;
      this.tileh = tileh;
      UpdateAll();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      UpdateAll();
    }

    private void UpdateAll()
    {
      bool useMultiple = checkBox1.Checked;
      numWidth.Enabled = !useMultiple;
      numHeight.Enabled = !useMultiple;
      numRows.Enabled = useMultiple;
      numCols.Enabled = useMultiple;
      ReCalc();
    }

    private void MultChanged(object sender, EventArgs e)
    {
      ReCalc();
    }

    private void ReCalc()
    {
      if(checkBox1.Checked)
      {
        numWidth.Value = numCols.Value * tilew;
        numHeight.Value = numRows.Value * tileh;
      }
    }
  }
}