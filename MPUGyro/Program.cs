﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPUGyro
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Form1 form = new Form1();
            DataTable dt = new DataTable(form);
            Application.Run(form);



            /*  TestForm form = new TestForm();
              MessageService service = new MessageService();
              TestManager manager = new TestManager();
              TestPresenter presenter = new TestPresenter(form, manager, service);
              Application.Run(form);*/
        }
    }
}