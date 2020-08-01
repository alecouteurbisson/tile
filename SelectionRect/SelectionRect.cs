#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

#endregion

namespace AJB.Controls
{
  public class SelectionRect : Control
  {
    private event SelectionChangedEventHandler selectionChanged;

    public event SelectionChangedEventHandler SelectionChanged
    {
      add { selectionChanged += value; }
      remove { selectionChanged -= value; }
    }

    public delegate void SelectionChangedEventHandler(object sender, EventArgs e);

    bool top;
    bool bottom;
    bool left;
    bool right;
    bool drag;
    bool refreshed;

    int cx, cy, w, h;

    public SelectionRect()
    {
      drag = false;
      DoubleBuffered = true;
      SetStyle(ControlStyles.UserPaint, true);
      SetStyle(ControlStyles.SupportsTransparentBackColor, true);
      BackColor = Color.Transparent;
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);
      if(drag)
      {
        if(!refreshed) return;
        refreshed = false;
        SetVisibleCore(false);
        if(!(left | right | top | bottom))
        {
          Left += (e.X - cx);
          Top += (e.Y - cy);
        }

        else
        {
          if(left)
          {
            Width = w -= (e.X - cx);
            Left += (e.X - cx);
          }

          if(right)
          {
            Width = w + (e.X - cx);
          }

          if(top)
          {
            Height = h -= (e.Y - cy);
            Top += (e.Y - cy);
          }

          if(bottom)
          {
            Height = h + (e.Y - cy);
          }
        }
        if(Width < 30) Width = 30;
        if(Height < 30) Height = 30;
        if(Top < 0) Top = 0;
        if(Left < 0) Left = 0;
        SetVisibleCore(true);
        SelectChanged();
      }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);
      if(e.Button == MouseButtons.Left)
      {
        cx = e.X;
        cy = e.Y;
        w = Width;
        h = Height;
        top = e.Y < 10;
        bottom = e.Y > (Height - 10);
        left = e.X < 10;
        right = e.X > (Width - 10);
        drag = true;
      }
    }

    public void JumpTo(int x, int y)
    {
      Top = y;
      Left = x;

      SelectChanged();
    }


    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);
      drag = left = right = top = bottom = false;

      SelectChanged();
    }


    protected override void OnMouseLeave(EventArgs e)
    {
      base.OnMouseLeave(e);
      top = false;
      bottom = false;
      left = false;
      right = false;
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

    }

    private void SelectChanged()
    {
      if(selectionChanged != null)
        selectionChanged(this, EventArgs.Empty);
      Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.PageUnit = GraphicsUnit.Pixel;

      g.DrawLine(top ? Pens.Red : Pens.Yellow, 0, 0, Width - 1, 0);
      g.DrawLine(left ? Pens.Red : Pens.Yellow, 0, 0, 0, Height - 1);
      g.DrawLine(bottom ? Pens.Red : Pens.Yellow, 0, Height - 1, Width - 1, Height - 1);
      g.DrawLine(right ? Pens.Red : Pens.Yellow, Width - 1, 0, Width - 1, Height - 1);

      if(!Dragging)
      {
        g.DrawLine(Pens.Yellow, 0, 10, Width - 1, 10);
        g.DrawLine(Pens.Yellow, 10, 0, 10, Height - 1);
        g.DrawLine(Pens.Yellow, 0, Height - 11, Width - 1, Height - 11);
        g.DrawLine(Pens.Yellow, Width - 11, 0, Width - 11, Height - 1);
      }
      refreshed = true;
    }
    
    public bool Dragging
    { get { return drag; } }
  }
}
