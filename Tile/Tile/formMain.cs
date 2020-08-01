#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AJB.Controls;
using System.IO;
#endregion

namespace Tile
{
  partial class formMain : Form
  {
    Bitmap sourceImage;
    SelectionRect srect;
    Rectangle sel;
    Bitmap imageTile;
    Size imgSize;

    int outWidth, outHeight;

    object widget = 1; // lock target

    public formMain()
    {
      InitializeComponent();

      outWidth = 1024;
      outHeight = 768;

      LoadSource();

      srect = new SelectionRect();
      this.Controls.Add(srect); 
      srect.Width = 100;
      srect.Height = 100;
      srect.Left = 100;
      srect.Top = 100;
      srect.Parent = picbSource;
      sel = srect.Bounds;

      srect.SelectionChanged +=new SelectionRect.SelectionChangedEventHandler(srect_SelectionChanged);
      SetStatus();
    }

    private void picbSource_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.PageUnit = GraphicsUnit.Pixel;
      e.Graphics.DrawImage(sourceImage, 0, 0);
    }


    void srect_SelectionChanged(object sender, EventArgs e)
    {
      SelectionRect sr = sender as SelectionRect;
      SetStatus();
      sel = new Rectangle(sr.Left, sr.Top, sr.Width, sr.Height);
      picbDest.Invalidate();
    }
    private void SetStatus()
    {
      //status1.Text = string.Format("Top = {0}, Left = {1}, Width = {2}, Height = {3}  Output Size = {4}x{5}",
      //                             srect.Top, srect.Left, srect.Width, srect.Height, outWidth, outHeight);
    }

    private void picbDest_Paint(object sender, PaintEventArgs e)
    {
      RenderTiles(e.Graphics, picbDest.Width, picbDest.Height);
    }

    private void RenderTiles(Graphics g, int width, int height)
    {
      lock(widget)
      {
        g.PageUnit = GraphicsUnit.Pixel;
        Rectangle dest;
        Rectangle sr = new Rectangle(0, 0, 2 * sel.Width, 2 * sel.Height);
        imageTile = new Bitmap(2 * sel.Width, 2 * sel.Height, g);
        Graphics gb = Graphics.FromImage(imageTile);
        gb.PageUnit = GraphicsUnit.Pixel;
        dest = new Rectangle(0, 0, sel.Width, sel.Height);
        gb.DrawImage(sourceImage, dest, sel.Left, sel.Top, sel.Width, sel.Height, GraphicsUnit.Pixel);

        dest = new Rectangle(sel.Width, 0, sel.Width, sel.Height);
        gb.DrawImage(sourceImage, dest, sel.Left + sel.Width, sel.Top, -sel.Width, sel.Height, GraphicsUnit.Pixel);

        dest = new Rectangle(0, sel.Height, sel.Width, sel.Height);
        gb.DrawImage(sourceImage, dest, sel.Left, sel.Top + sel.Height, sel.Width, -sel.Height, GraphicsUnit.Pixel);

        dest = new Rectangle(sel.Width, sel.Height, sel.Width, sel.Height);
        gb.DrawImage(sourceImage, dest, sel.Left + sel.Width, sel.Top + sel.Height, -sel.Width, -sel.Height, GraphicsUnit.Pixel);

        Brush tex = new TextureBrush(imageTile);
        g.FillRectangle(tex, g.ClipBounds);
        imageTile.Dispose();
      }
    }

    private void panlSourceImage_Scroll(object sender, ScrollEventArgs e)
    {
      picbSource.Invalidate();
    }

    private void LoadSource()
    {
      if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
        return;
      sourceImage = new Bitmap(openFileDialog1.FileName, false);
      sourceImage.SetResolution(96, 96);
      imgSize = new Size(sourceImage.Width, sourceImage.Height);
      picbSource.Size = imgSize;
      picbSource.Invalidate();
      picbDest.Invalidate();
    }

    private void SaveImage()
    {
      int svwidth;
      int svheight;

      saveFileDialog1.Title = "Save image file";
      svwidth = outWidth;
      svheight = outHeight;


      if(saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        return;

      ImageFormat fmt = null;
      switch(Path.GetExtension(saveFileDialog1.FileName).ToLower())
      {
        case ".bmp":
          fmt = ImageFormat.Bmp; break;
        case ".jpg":
        case ".jpeg":
          fmt = ImageFormat.Jpeg; break;
        case ".gif":
          fmt = ImageFormat.Gif; break;
        case ".png":
          fmt = ImageFormat.Png; break;
        case ".tiff":
          fmt = ImageFormat.Tiff; break;
        default:
          MessageBox.Show("Please use one of the file extension listed in the dialogue", "Tile - Unknown extension");
          break;
      }
      Bitmap SaveImage = new Bitmap(svwidth, svheight, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
      RenderTiles(Graphics.FromImage(SaveImage), svwidth, svheight);
      SaveImage.Save(saveFileDialog1.FileName, fmt);
      SaveImage.Dispose();
    }

    private void Exit(object sender, EventArgs e)
    {
      Close();
    }

    private void menuLoadSource(object sender, EventArgs e)
    {
      LoadSource();
    }

    private void menuSaveImage(object sender, EventArgs e)
    {
      SaveImage();
    }

    private void SourceDClick(object sender, MouseEventArgs e)
    {
      if(e.Button == MouseButtons.Left)
        srect.JumpTo(e.X, e.Y);
    }

    private void SetImageFileSize(object sender, EventArgs e)
    {
      SizeDialogue dlg = new SizeDialogue(outWidth, outHeight, srect.Width * 2, srect.Height * 2);
      if(dlg.ShowDialog() == DialogResult.Cancel)
        return;

      outWidth = dlg.W;
      outHeight = dlg.H;
    }
  }
}