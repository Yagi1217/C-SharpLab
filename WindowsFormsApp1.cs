using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
    }
    private void Form1_Paint(object sender, PaintEventArgs e){
      Graphics g = e.Graphics;

      Bitmap bmp = new Bitmap("png.png");
      g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
      bmp.Dispose();

      //半透明の円を作成する
      g.DrawArc(new Pen(Color.FromArgb(128, Color.Blue), 6), 10, 10, 50, 50, 0, 360);
      g.DrawArc(new Pen(Color.FromArgb(128, Color.Black), 6), 65, 10, 50, 50, 0, 360);
      g.DrawArc(new Pen(Color.FromArgb(128, Color.Red), 6), 120, 10, 50, 50, 0, 360);
      g.DrawArc(new Pen(Color.FromArgb(128, Color.Yellow), 6), 38, 40, 50, 50, 0, 360);
      g.DrawArc(new Pen(Color.FromArgb(128, Color.Green), 6), 93, 40, 50, 50, 0, 360);

      //半透明の文字列を作成する
      Brush b = new SolidBrush(Color.FromArgb(128, Color.Black));
      Font f = new Font("メイリオ", 30);
      g.DrawString("Tokyo 2020", f, b, 15, 70);
      b.Dispose();
      f.Dispose();
    }
  }
}
