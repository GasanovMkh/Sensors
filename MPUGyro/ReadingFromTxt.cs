using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MPUGyro.Models;

namespace MPUGyro
{
    class ReadingFromTxt
    {
        public OrtogSensor _view_ReadTxt()
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


            List<double> arr_kren = null;
            using (FileStream fs = new FileStream(@"Files/ortog_kren.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_kren = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_kren.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }

            List<double> arr_kurs = null;
            using (FileStream fs = new FileStream(@"Files/ortog_kurs.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_kurs = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_kurs.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }

            List<double> arr_tangazh = null;
            using (FileStream fs = new FileStream(@"Files/ortog_tangazh.txt", FileMode.Open, FileAccess.Read))
            {
                if (fs != null)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string b = sr.ReadToEnd();
                        if (b != null)
                        {
                            string[] buf = b.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                            arr_tangazh = new List<double>(buf.Length);
                            for (int i = 0; i < buf.Length; i++)
                                arr_tangazh.Add(Convert.ToDouble(buf[i]));
                        }
                        else MessageBox.Show("Этот файл пустой!!!");
                    }
                }
            }
            return new OrtogSensor
            {
                Times = arr_time,
                Kren0 = arr_kren,
                Kurs0 = arr_kurs,
                Tangazh0 = arr_tangazh
            };
        }

    }
}

