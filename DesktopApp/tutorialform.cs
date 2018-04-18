using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class tutorialform : Form
    {
        public tutorialform()
        {
            InitializeComponent();
        }

        private void tutorialform_Load(object sender, EventArgs e)
        {
            fhnPicture.Image = Image.FromFile(@"C:\Project\BrainScholar\DesktopApp\Images\FHN\fhn-1.png");
            labelInfo.Text = "This is basic model";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
            
        }
    }
}
