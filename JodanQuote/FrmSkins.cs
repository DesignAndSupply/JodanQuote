using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JodanQuote
{
    public partial class FrmSkins : Form
    {
        public FrmSkins()
        {
            InitializeComponent();
            dataGridView1.DataSource = function.Functionsclass.dt_skins;
        }
    }
}
