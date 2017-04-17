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
        DataGridView Grid2 { get; set; }
        CheckBox ChBNx1 { get; set; }
        CheckBox ChBNy1 { get; set; }
        CheckBox ChBNz1 { get; set; }
        CheckBox ChBNx2 { get; set; }
        CheckBox ChBNy2 { get; set; }
        CheckBox ChBNz2 { get; set; }
        CheckBox ChBNx3 { get; set; }
        CheckBox ChBNy3 { get; set; }
        CheckBox ChBNz3 { get; set; }
        event EventHandler ClickChoose;
        event EventHandler ClickChBNx1;
        event EventHandler ClickChBNy1;
        event EventHandler ClickChBNz1;
        event EventHandler ClickChBNx2;
        event EventHandler ClickChBNy2;
        event EventHandler ClickChBNz2;
        event EventHandler ClickChBNx3;
        event EventHandler ClickChBNy3;
        event EventHandler ClickChBNz3;
    }

    public partial class Form1 : Form, IMpuGyro
    {
        #region Реализация свойств
        public DataGridView Grid
        {
            get { return dgw_ortog; }
            set { dgw_ortog = value; }
        }
        public DataGridView Grid2
        {
            get { return dgw_changing; }
            set { dgw_changing = value; }
        }
        public CheckBox ChBNx1
        {
            get { return ch_b_nx1; }
            set { ch_b_nx1 = value; }
        }
        public CheckBox ChBNy1
        {
            get { return ch_b_ny1; }
            set { ch_b_ny1 = value; }
        }
        public CheckBox ChBNz1
        {
            get { return ch_b_nz1; }
            set { ch_b_nz1 = value; }
        }
        public CheckBox ChBNx2
        {
            get { return ch_b_nx2; }
            set { ch_b_nx2 = value; }
        }
        public CheckBox ChBNy2
        {
            get { return ch_b_ny2; }
            set { ch_b_ny2 = value; }
        }
        public CheckBox ChBNz2
        {
            get { return ch_b_nz2; }
            set { ch_b_nz2 = value; }
        }
        public CheckBox ChBNx3
        {
            get { return ch_b_nx3; }
            set { ch_b_nx3 = value; }
        }
        public CheckBox ChBNy3
        {
            get { return ch_b_ny3; }
            set { ch_b_ny3 = value; }
        }
        public CheckBox ChBNz3
        {
            get { return ch_b_nz3; }
            set { ch_b_nz3 = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            #region Обработчики событий, переходят на методы 
            btn_choose.Click += Click_Choose;
            ch_b_nx1.Click += Click_ch_bnx1;
            ch_b_ny1.Click += Click_ch_bny1;
            ch_b_nz1.Click += Click_ch_bnz1;
            ch_b_nx2.Click += Click_ch_bnx2;
            ch_b_ny2.Click += Click_ch_bny2;
            ch_b_nz2.Click += Click_ch_bnz2;
            ch_b_nx3.Click += Click_ch_bnx3;
            ch_b_ny3.Click += Click_ch_bny3;
            ch_b_nz3.Click += Click_ch_bnz3;
            #endregion
        }
        #region Проброс событий
        public void Click_Choose(Object sender, EventArgs e)
        {
            ClickChoose?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bnx1(Object sender, EventArgs e)
        {
            ClickChBNx1?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bny1(Object sender, EventArgs e)
        {
            ClickChBNy1?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bnz1(Object sender, EventArgs e)
        {
            ClickChBNz1?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bnx2(Object sender, EventArgs e)
        {
            ClickChBNx2?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bny2(Object sender, EventArgs e)
        {
            ClickChBNy2?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bnz2(Object sender, EventArgs e)
        {
            ClickChBNz2?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bnx3(Object sender, EventArgs e)
        {
            ClickChBNx3?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bny3(Object sender, EventArgs e)
        {
            ClickChBNy3?.Invoke(this, EventArgs.Empty);
        }
        public void Click_ch_bnz3(Object sender, EventArgs e)
        {
            ClickChBNz3?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Реализация интерфейса ITestForm
        public event EventHandler ClickChoose;
        public event EventHandler ClickChBNx1;
        public event EventHandler ClickChBNy1;
        public event EventHandler ClickChBNz1;
        public event EventHandler ClickChBNx2;
        public event EventHandler ClickChBNy2;
        public event EventHandler ClickChBNz2;
        public event EventHandler ClickChBNx3;
        public event EventHandler ClickChBNy3;
        public event EventHandler ClickChBNz3;
        #endregion
    }
}
