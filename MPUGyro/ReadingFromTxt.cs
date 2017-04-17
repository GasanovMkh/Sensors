using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MPUGyro
{
    class ReadingFromTxt
    {
        private readonly IMpuGyro _view;

        public ReadingFromTxt(IMpuGyro view)
        {
            _view = view;
            _view.ClickChoose += _view_ReadTxt;
        }
        public void _view_ReadTxt(Object sender, EventArgs e)
        {
            int[] arr;
            FileStream fs = new FileStream(@"Files/ortog.txt", FileMode.Open, FileAccess.Read);
            if (fs != null)
            {

                StreamReader sr = new StreamReader(fs);

                string b = sr.ReadLine();
                if (b != null)
                {
                    string[] buf = b.Split(' ');
                    arr = new int[buf.Length];
                    for (int i = 0; i < buf.Length; i++)
                        arr[i] = Convert.ToInt32(buf[i]);
                }
                else MessageBox.Show("Этот файл пустой!!!");
                sr.Close();
                fs.Close();
            }
        }
    }
}
