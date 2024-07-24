using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Markie
{
    public partial class MNForm : Form
    {
        #region Interopt2Preload
        //Interop A-Flag
        private bool aflag = false;

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte bAlpha, int dwFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        private const int LWA_ALPHA = 0x2;
        #endregion
        #region Componets2Preload
        public MNForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.TopMost = true;
            this.KeyDown += new KeyEventHandler(SetControlV);
            this.Resize += new EventHandler(MNForm_Resize);
            this.MouseDown += new MouseEventHandler(ContextMouseTake);
            ContainBx.MouseDown += new MouseEventHandler(ContextMouseTake);
            TextCN.MouseDown += new MouseEventHandler(ContextMouseTake);
            ContainBx.SizeMode = PictureBoxSizeMode.Zoom;
            TextCN.Dock = DockStyle.Fill;
            TextCN.Visible = false;

            ContainBx.Image = Bap;
            image = Bap;
        }
        #endregion
        #region BitmapVariable
        private Bitmap Bap
        {
            get
            {
                Bitmap bmp = new Bitmap(ContainBx.Width, ContainBx.Height);
                bmp.SetPixel(0, 0, Color.FromArgb(0, 0, 0, 0));
                return bmp;
            }
        }
        #endregion
        #region Key&MouseControls
        private Image image;
        private void SetControlV(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsImage())
                {
                    image = Clipboard.GetImage();
                    ContainBx.Image = image;
                }
            }
        }
        private void ContextMouseTake(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CtxMenu.Show(this, e.Location);
            }
        }
        #endregion
        #region Containers2ImgSetScaler
        private void MNForm_Resize(object sender, EventArgs e)
        {
            //IMG Container
            ContainBx.Size = GetScaledSize(image.Size, this.ClientSize);

            if (ContainBx.Right > this.ClientSize.Width)
            {
                ContainBx.Left = this.ClientSize.Width - ContainBx.Width;
            }
            if (ContainBx.Bottom > this.ClientSize.Height)
            {
                ContainBx.Top = this.ClientSize.Height - ContainBx.Height;
            }

            //TXT Container
            TextCN.Size = this.ClientSize;
        }
        #endregion
        #region ImageSetScaler
        private Size GetScaledSize(Size imageSize, Size contSize)
        {
            double ratioX = (double)contSize.Width / imageSize.Width;
            double ratioY = (double)contSize.Height / imageSize.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(imageSize.Width * ratio);
            int newHeight = (int)(imageSize.Height * ratio);
            return new Size(newWidth, newHeight);
        }
        #endregion
        #region Context Menu
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContainBx.Visible)
            {
                if (image != null)
                {
                    Clipboard.SetData(DataFormats.Bitmap, (Object)image);
                }
                else
                {
                    MessageBox.Show("Image Container does not contain 'Image'!");
                }
            }
            else if (TextCN.Visible)
            {
                if (!String.IsNullOrEmpty(TextCN.Text))
                {
                    TextCN.SelectAll();
                    Clipboard.SetText(TextCN.Text);
                }
                else
                {
                    MessageBox.Show("Text Container does not contain 'Text'!");
                }
            }
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContainBx.Visible)
            {
                if (Clipboard.ContainsImage())
                {
                    image = Clipboard.GetImage();
                    ContainBx.Image = image;
                }
                else
                {
                    MessageBox.Show("Clipboard does not contain 'Image'!");
                }
            }
            else if (TextCN.Visible)
            {
                if (Clipboard.ContainsText())
                {
                    TextCN.Text = Clipboard.GetText();
                }
                else
                {
                    MessageBox.Show("Clipboard does not contain 'Text'!");
                }
            }
        }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContainBx.Visible)
            {
                if (image != null)
                {
                    ContainBx.Image = Bap;
                    image = Bap;
                }
            }
            else if (TextCN.Visible)
            {
                if (!String.IsNullOrEmpty(TextCN.Text))
                {
                    TextCN.Clear();
                }
            }
        }
        private void ImageModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContainBx.Visible == false)
            {
                ContainBx.Visible = true;
                TextCN.Visible = false;
            }
            else
            {
                ContainBx.Visible = false;
                TextCN.Visible = true;
            }
        }
        private void TextModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextCN.Visible == false)
            {
                TextCN.Visible = true;
                ContainBx.Visible = false;
            }
            else
            {
                TextCN.Visible = false;
                ContainBx.Visible = true;
            }
        }
        private void DarkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            TextCN.BackColor = Color.FromArgb(40, 40, 40);
            TextCN.ForeColor = Color.FromArgb(200,200,200);
        }
        private void LightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            TextCN.BackColor = SystemColors.Window;
            TextCN.ForeColor = SystemColors.WindowText;
        }
        private void InvisibleThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!aflag)
            {
                SetWindowLong(this.Handle, GWL_EXSTYLE, GetWindowLong(this.Handle, GWL_EXSTYLE) | WS_EX_LAYERED);
                SetLayeredWindowAttributes(this.Handle, 0, 150, LWA_ALPHA);
                aflag = true;
            }
            else
            {
                SetWindowLong(this.Handle, GWL_EXSTYLE, GetWindowLong(this.Handle, GWL_EXSTYLE) | WS_EX_LAYERED);
                SetLayeredWindowAttributes(this.Handle, 0, 255, LWA_ALPHA);
                aflag = false;
            }
        }
        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }
        #endregion
    }
}