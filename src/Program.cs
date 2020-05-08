using KFillDoc.UIElements;
using System;
using System.IO;
using System.Windows.Forms;

namespace KFillDoc
{
    /// <summary>
    /// K_Fill-Doc Application
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Путь для хранения временных файлов.
        /// </summary>
        private const string DIR_CASH = "C:\\K_FillDoc";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(DIR_CASH))
            {
                Directory.CreateDirectory(DIR_CASH);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(DIR_CASH);

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
