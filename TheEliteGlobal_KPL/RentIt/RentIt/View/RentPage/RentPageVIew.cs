using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.RentPage
{
    public partial class RentPageVIew : Form
    {
        public RentPageVIew()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dragfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                pictureBox4.Visible = false;
                label10.Visible = false;
            }


            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (extension == ".jpg" || extension == ".png" || extension == ".pdf"
                        || extension == ".doc" || extension == ".docx" || extension == ".zip")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        private void dragfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!dragfile.Items.Contains(Path.GetFileName(file)))
                {
                    dragfile.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void dragfile_DragLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
        }

        private void dragfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void redBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
