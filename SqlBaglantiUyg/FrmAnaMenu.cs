using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlBaglantiUyg
{
    public partial class FrmAnaMenu : Form
    {

        List<Control> shadowControls = new List<Control>();
        Bitmap shadowBmp = null;
        public FrmAnaMenu()
        {
            InitializeComponent();
            shadowControls.Add(kullanicilarButon);
            shadowControls.Add(ButonOgr);
            shadowControls.Add(StoklarButon);
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeText.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            Utils.OvalKenar_PictureBox(StoklarButon, 75);
            Utils.OvalKenar_PictureBox(ButonOgr, 75);
            Utils.OvalKenar_PictureBox(kullanicilarButon, 75);
            TimeText.Text = DateTime.Now.ToString("HH:mm:ss");
            kullaniciTextBox.Text = Utils.KullaniciAdi;
            versionText.Text = "version : " + GetVersionS();
           

        }

        private void ButonOgr_Click(object sender, EventArgs e)
        {
            FrmOgrenci ogr = new FrmOgrenci();
            this.Hide();            
            ogr.ShowDialog();
            this.Show();
        }

        // Uygulamamızın version numarasını alıyor
        private string GetVersionS()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }

        private void kullanicilarButon_Click(object sender, EventArgs e)
        {
            if (kullaniciTextBox.Text == "admin")
            {
                FrmKullanicilar frmKullanicilar = new FrmKullanicilar();
                frmKullanicilar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sadece Admin Giriş Yapabilir!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

           
        }

        private void StoklarButon_Click(object sender, EventArgs e)
        {
            Hide();
            FrmStok frmStok = new FrmStok();
            frmStok.ShowDialog();
            Show();
        }
       

        private void FrmAnaMenu_Paint(object sender, PaintEventArgs e)
        {
            if (shadowBmp == null || shadowBmp.Size != this.Size)
            {
                shadowBmp?.Dispose();
                shadowBmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            foreach (Control control in shadowControls)
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddRectangle(new Rectangle(control.Location.X, control.Location.Y, control.Size.Width, control.Size.Height));
                    Utils.DrawShadowSmooth(gp, 100, 60, shadowBmp);
                }
                e.Graphics.DrawImage(shadowBmp, new Point(0, 0));                
            }
        }
    }
}
