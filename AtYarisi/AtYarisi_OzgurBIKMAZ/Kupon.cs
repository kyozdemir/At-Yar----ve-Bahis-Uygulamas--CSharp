using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Kupon : Form
    {
        List<List<string>> kuponlar = new List<List<string>>();
        public Kupon(List<List<string>> kuponlar)
        {
            InitializeComponent();
            this.kuponlar = kuponlar;
        }

        private void Kupon_Load(object sender, EventArgs e)
        {
            foreach (var item in kuponlar)
            {
                dataKuponlar.Rows.Add(item.ToArray());
            }
            
        }


    }
}
