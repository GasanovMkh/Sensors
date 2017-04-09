using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MPUGyro
{
    public interface IMpuGyro
    {
        DataGridView Grid { get; set; }
        event EventHandler ClickChoose;
    }
      
    public partial class Form1 : Form, IMpuGyro
    {
        public DataGridView Grid
        {
            get
            {
                return dgw_ortog;
            }

            set
            {
                dgw_ortog = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            btn_choose.Click += Click_Choose;
        }
         
        public void Click_Choose(Object sender, EventArgs e)
        {
            ClickChoose?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ClickChoose;

    }
}
