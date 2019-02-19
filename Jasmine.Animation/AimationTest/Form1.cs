
using Jasmine.Animation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AimateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TimeAnimator animator = new TimeAnimator();

            label1.BackColor = Color.Blue;
            var size= new SizeHandler(new Size(10, 400), new Size(300, 250), x => label1.Size = x);
            var color = new ColorHandler(Color.Brown, Color.Blue, x => label1.BackColor = x);
            var location = new PositionHandler(new Point(0, 200), new Point(1200, 200), x => label1.Location = x);

            animator.Animate(1000, 100,new AnimateHandlerGroup(new IAnimateHandler[] {color,location,size }),null,AnimateFunctionType.CubicEaseInOut);

        }


        private class printer : IAnimateHandler
        {
            public printer(TextBox box)
            {
                _box = box;
            }
            private TextBox _box;
            public void OnAnimate(float t)
            {
                _box.AppendText($"value  ：{t}\r\n ");
            }
        }
    }
}
