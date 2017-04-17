using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MPUGyro.Models;

namespace MPUGyro
{
    class ReadingFromTxt
    {
        public KrenModel _view_ReadTxt()
        {
            List<double> arr_time = null;
            using (FileStream fs = new FileStream(@"Files/ortog_time.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_time = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_time.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }


            List<double> arr_kren_x = null;
            using (FileStream fs = new FileStream(@"Files/ortog_kren_x.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_kren_x = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_kren_x.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }

            List<double> arr_kren_y = null;
            using (FileStream fs = new FileStream(@"Files/ortog_kren_y.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_kren_y = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_kren_y.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }

            List<double> arr_kren_z = null;
            using (FileStream fs = new FileStream(@"Files/ortog_kren_y.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_kren_z = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_kren_z.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }
            return new KrenModel
            {
                Times = arr_time,
                KrenX = arr_kren_x,
                KrenY = arr_kren_y,
                KrenZ = arr_kren_z
            };
        }

    }
}

