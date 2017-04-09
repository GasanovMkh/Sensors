using System;
using System.Data;
using System.IO;

namespace MPUGyro
{
    class DataTable
    {
        private readonly IMpuGyro _view;

        public DataTable(IMpuGyro view)
        {
            _view = view;
            _view.ClickChoose += _view_ClickChoose;
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
            _view.Grid.Columns[0].Width = 48;
            _view.Grid.Columns[1].Width = 48;
            _view.Grid.Columns[2].Width = 48;
            _view.Grid.Columns[3].Width = 48;

        }
    }
}
