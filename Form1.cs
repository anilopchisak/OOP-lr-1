using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //пространство имен

namespace ооп_лаба_1
{
    public partial class Form1 : Form
    {
        string buffer; //for context menu strip
        public Form1()
        {
            InitializeComponent();
            Rtxtbx.ContextMenuStrip = CMSrbtxt; //ассоциируем 
            tabControl2_SelectedIndexChanged(null, null);
            //this.ShowInTaskbar = false;
        }

        private void txtIN_TextChanged(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN.Text;
        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            txtIN.Text = "";
        }

        private void txtIN_KeyDown(object sender, KeyEventArgs e)
        {
            txtCode.Text = e.KeyValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LBpink.Items.Add(txtList.Text);
            txtList.Text = "";
        }

        private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbMonth.Text = String.Format("The date is {0}", mtxtDate.Text);
                mtxtDate.Text = "";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordX.Text = e.X.ToString();
            lbCoordY.Text = e.Y.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.PictureBox picbx = new System.Windows.Forms.PictureBox();

            picbx.Image = global::ооп_лаба_1.Properties.Resources.unnamed;
            picbx.Location = new System.Drawing.Point(e.X - picbx.Size.Width / 2, e.Y - picbx.Size.Height / 2);
            picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picbx.TabIndex = 15;
            picbx.TabStop = false;

            this.Controls.Add(picbx);
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                congrMsg.Visible = true;
                //MessageBox.Show("Congrats! You have 10 hedgehogs!", "Achievement", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
        }

        private void cbRainbow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ItemSelected = cbRainbow.SelectedItem.ToString();
            if (ItemSelected == "red") this.BackColor = Color.Red;
            else if (ItemSelected == "orange") this.BackColor = Color.Orange;
            else if (ItemSelected == "yellow") this.BackColor = Color.Yellow;
            else if (ItemSelected == "green") this.BackColor = Color.Green;
            else if (ItemSelected == "light blue") this.BackColor = Color.LightBlue;
            else if (ItemSelected == "blue") this.BackColor = Color.Blue;
            else if (ItemSelected == "purple") this.BackColor = Color.Purple;
            else if (ItemSelected == "white") this.BackColor = SystemColors.Control;
        }

        private void rbtnBold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBold.Checked == true) Rtxtbx.Font = new Font(Rtxtbx.Font, FontStyle.Bold);
            else Rtxtbx.Font = DefaultFont;
        }

        private void rbtnItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnItalic.Checked == true) Rtxtbx.Font = new Font(Rtxtbx.Font, FontStyle.Italic);
            else Rtxtbx.Font = DefaultFont;
        }

        private void rbtnUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUnderline.Checked == true) Rtxtbx.Font = new Font(Rtxtbx.Font, FontStyle.Underline);
            else Rtxtbx.Font = DefaultFont;
        }

        private void rbtnStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnStrikeout.Checked == true) Rtxtbx.Font = new Font(Rtxtbx.Font, FontStyle.Strikeout);
            else Rtxtbx.Font = DefaultFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
        }

        private void lbWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.Navigate(lbWiki.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btnTimerOn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnTimerOff_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            LBpink.Items.Remove(LBpink.SelectedItem);
        }

        private void treeViewSweets_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch ((e.Action))
            {
                case TreeViewAction.ByKeyboard:
                    lbInteract.Text = "By the keyboard";
                    break;
                case TreeViewAction.ByMouse:
                    lbInteract.Text = "By the mouse";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbData.Text = String.Format("It's {0}", e.Start.ToLongDateString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbData.Text = String.Format("It's {0}", dateTimePicker1.Text);
        }

        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSlbChosenButton.Text = buttonsToolStripMenuItem.Text;
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSlbChosenButton.Text = doneToolStripMenuItem.Text;
        }

        private void addToTheListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSlbChosenButton.Text = addToTheListToolStripMenuItem.Text;
        }

        private void okToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSlbChosenButton.Text = okToolStripMenuItem.Text;
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            buffer = Rtxtbx.SelectedText;
            lbBuffer.Text = buffer;
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            Rtxtbx.Text += buffer;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            string FormSize = this.Size.ToString();
            ToolstripLBSize.Text = FormSize;
        }

        private void picboxPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Create a local version of the graphics object for the PictureBox.
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawString("Text", new Font("Times New Roman", 20), new SolidBrush(Color.Black), this.DisplayRectangle);
            g.DrawLine(System.Drawing.Pens.Red, picboxPaint.Left, picboxPaint.Top, picboxPaint.Right, picboxPaint.Bottom);
            g.DrawRectangle(System.Drawing.Pens.Black, 78, 20, 30, 30);
            g.DrawEllipse(System.Drawing.Pens.Blue, 30, 30, 30, 30);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
                comboBox1.SelectedIndex = 1;
            if (tabControl2.SelectedIndex == 0)
                comboBox1.SelectedIndex = 0;
        }
    }
}
