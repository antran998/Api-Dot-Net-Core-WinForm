using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.CustomElement
{
    public partial class Alert : Form
    {
        private readonly string _content;
        private readonly string _image;
        public Alert(string content,string image)
        {
            _content = content;
            _image = image;
            InitializeComponent();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            alertText.Text = _content;
            alertGif.Image = Image.FromFile(_image);
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
