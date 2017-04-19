using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MPUGyro
{
    class DataTable
    {
        private readonly IMpuGyro _view;
        
        ReadingFromTxt rft = new ReadingFromTxt();
        ShowNewForm snf = new ShowNewForm();
     
        public DataTable(IMpuGyro view)
        {
            _view = view;
            _view.ClickChoose += _view_ClickChoose;
            _view.ClickChBNx1 += _view_ClickChBNx1;
            _view.ClickBtnKr0 += _view_ClickBtnKr0;
        }

        public void _view_ClickChoose(Object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //создаем временную таблицу
            ds.Tables.Add("Temp");

            //путь к текстовому файлу
            string path = @"Files/ortog.txt";
            StreamReader sr = new StreamReader(path);

            /*создаем колонки в таблице и заполняем их названиями*/
            //считываем первую строку из файла, в ней названия столбцов
            string firstLine = sr.ReadLine();
            //массив имен колонок из файла
            string[] arraNameColumn = System.Text.RegularExpressions.Regex.Split(firstLine, " ");
            for (int i = 0; i < arraNameColumn.Length; i++)
            {
                ds.Tables[0].Columns.Add(arraNameColumn[i]);
            }

            /*заполняем строки в таблице*/
            string Line = sr.ReadLine();
            while (Line != null)
            {
                string[] arraCell = System.Text.RegularExpressions.Regex.Split(Line, " ");
                ds.Tables[0].Rows.Add(arraCell);
                Line = sr.ReadLine();
            }

            //привязываем dataGridView к таблице
            _view.Grid.DataSource = ds.Tables[0];
            _view.Grid.Columns[0].Width = 50;
            _view.Grid.Columns[1].Width = 50;
            _view.Grid.Columns[2].Width = 50;
            _view.Grid.Columns[3].Width = 50;
            
            var krenModel = rft._view_ReadTxt();
            var graphics = new Graphics(_view);
            graphics.DrowGraphics(krenModel);            
        }
        public void _view_ClickBtnKr0(Object sender, EventArgs e)
        {
            snf.CheckPressShowBtnKr0();
            
        }
        public void _view_ClickChBNx1(Object sender, EventArgs e)
        {
            if (_view.ChBNx1.Checked == true)
            {
                _view.ChBNx2.Checked = false;
                _view.ChBNx3.Checked = false;
                DataSet ds = new DataSet();
                ds.Tables.Add("Temp");
                string path = @"Files/nx1.txt";
                StreamReader sr = new StreamReader(path);
                string firstLine = sr.ReadLine();
                string[] arraNameColumn = System.Text.RegularExpressions.Regex.Split(firstLine, " ");
                for (int i = 0; i < arraNameColumn.Length; i++)
                {
                    ds.Tables[0].Columns.Add(arraNameColumn[i]);
                }
                string Line = sr.ReadLine();
                while (Line != null)
                {
                    string[] arraCell = System.Text.RegularExpressions.Regex.Split(Line, " ");
                    ds.Tables[0].Rows.Add(arraCell);
                    Line = sr.ReadLine();
                }
                _view.Grid2.DataSource = ds.Tables[0];
                _view.Grid2.Columns[0].Width = 50;
                _view.Grid2.Columns[1].Width = 50;
                _view.Grid2.Columns[2].Width = 50;
                _view.Grid2.Columns[3].Width = 50;
            }
            else
            {
                _view.Grid2.ClearSelection();
            }
            /* if (_view.ChBNx1.Checked == true && _view.ChBNx2.Checked == true || _view.ChBNx1.Checked == true && _view.ChBNx3.Checked == true || _view.ChBNx2.Checked == true && _view.ChBNx3.Checked == true)
             {
                 MessageBox.Show("Нельзя выбирать несколько данных по одной оси!");
             }*/
        }
    }
}
