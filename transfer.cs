using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMLibary
{
    public partial class transfer : Form
    {
        public transfer()
        {
            InitializeComponent();
        }

        private void btn_select_current_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                tb_current_folder.Text = browser.SelectedPath;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            Anime serie = new Anime("bleach");
            serie.SetupInformation();
            string test = serie.studio;

            MessageBox.Show(test);
        }
    }
}

//@"C:\Users\Toricima\Desktop\test envirment\anime-devilishly.xml"