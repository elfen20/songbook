using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongBook
{
    public partial class FSongbook : Form
    {
        public FSongbook()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Key mykey = default;
            tbInfo.Text = mykey.ToString();
        }
    }
}
