using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_2019._11._18
{
    public partial class KuponOyna : Form
    {
        List<string> kupon = new List<string>();
        public KuponOyna()
        {

        }
        public KuponOyna(Enum isimAt, ArrayList isimArray)
        {
            InitializeComponent();
        }

        private void KuponOyna_Load(object sender, EventArgs e)
        {

        }
    }
}
