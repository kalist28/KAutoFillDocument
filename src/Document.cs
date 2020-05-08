using System;
using System.IO;
using KFillDoc.UIElements;
using System.Windows.Forms;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;

namespace KFillDoc
{
    /// <summary>
    /// K_Fill-Doc Application
    /// Класс для анализа документа и автоматического создания UI.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    class Document
    {
       
        /* Позиция на панеле - #1. */
        private const int P_FIRST = 0;

        /* Позиция на панеле - #2. */
        private const int P_SECOND = 1;

        /* Исходное имя файла. */
        private string FileName;

        /* Начальное имя файла. */
        private readonly string FirstFileName;

        /* Содержит текст для предварительного просомтра документа. */
        private string CheckDocText;

        /* Обьект документа. */
        private Word.Document wDocument;

        /* Колекция UI обьектов для ввода данных. */
        private readonly List<ElementBox> Elements = new List<ElementBox>();

        /// <summary>
        /// Конструктор - инициализация обьекта.
        /// </summary>
        public Document()
        {
            
        }
        /// <summary>
        /// Конструктор - инициализация обьекта.
        /// </summary>
        /// <param name="nameDoc"> Имя файла. </param>
        public Document(string nameDoc)
        {
            FirstFileName = nameDoc;
        }


        /// <summary>
        /// Создание кэш-копии документа для работы.
        /// </summary>
        void CreateDocument()
        {
            String fileNewName = FirstFileName + "_"
                + DateTime.Now.ToString("HH-mm-ss_dd-mm-yyyy")
                + ".docx";
            File.Copy(Environment.CurrentDirectory + "\\docs\\" + FirstFileName,
                @"C:\K_FillDoc\" + fileNewName);
            FileName = fileNewName;
        }

        /// <summary>
        /// Получение всех закладок из документа.
        /// </summary>
        /// <returns> Возращает коллекцию с закладками,
        /// Элементы отсортированны по уникальному номеру закладки. </returns>
        public List<String> GetBookmarks()
        {
            List<String> list = new List<string>();

            Word.Application app = new Word.Application();
            wDocument = app.Documents.Open(@"C:\\K_FillDoc\\" + FileName);

            Word.Bookmarks bookmarks = wDocument.Bookmarks;

            foreach (Word.Bookmark mark in bookmarks)
            {
                list.Add(mark.Name);
                Console.WriteLine(mark.Name);
            }
            wDocument.Close();
            return SortBookmarks(list);
        }

        /// <summary>
        /// Возращает элементы отсортированны по уникальному номеру закладки.
        /// </summary>
        /// <param name="list"></param>
        /// <returns> Элементы отсортированны по уникальному номеру закладки. </returns>
        private List<string> SortBookmarks(List<string> list)
        {
            List<string> sortList = new List<string>();
            int count = 1;
            
            while (count <= Adapter.BookmarksCount())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Adapter.GetType(list[i]) == count)
                    {
                        sortList.Add(list[i]);
                        list.Remove(list[i]);
                    }
                }
                count++;
            }
            return sortList;
        }

        /// <summary>
        /// Заполнение коллекции обьектами ElementBox.
        /// </summary>
        private void FillElements()
        {
            Console.WriteLine(3);
            List<String> list = GetBookmarks();

            for (int i = 0; i < list.Count; i++)
            {
                Elements.Add(new ElementBox(list[i]));
            }

        }

        /// <summary>
        /// Создание пользовательсколго интерфейса.
        /// Заполнение панель обьектами.
        /// </summary>
        /// <param name="panel"></param>
        public void RenderUI(TableLayoutPanel panel)
        {
            Console.WriteLine(1);
            CreateDocument();
            FillElements();

            var pCntls = panel.Controls;
            for (int i = 0; i < Elements.Count; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
                var obj = Elements[i];
                if (obj.Element is IInputTextInfo)
                {
                    var o = (IInputTextInfo)obj.Element;
                    pCntls.Add(o.GetLabel(), P_FIRST, i);
                    pCntls.Add(o.GetTextBox(), P_SECOND, i);
                }
                if (obj.Element is InputDate)
                {
                    var o = (InputDate) obj.Element;
                    pCntls.Add(o.GetLabel(), P_FIRST, i);
                    pCntls.Add(o.GetDateTimePicker(), P_SECOND, i);
                }
            }

            if (Elements.Count == 0) return;

            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            Button btnSave = new Button
            {
                Text = "Сохранить"
            };

            Button btnCheck = new Button
            {
                Text = "Проверить"
            };

            btnCheck.Click += delegate
            {
                Save();
                CheckForm form = new CheckForm(CheckDocText);
                form.Show();
            };

            btnSave.Click += delegate
            {
                Save();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                File.Copy(@"C:\K_FillDoc\" + FileName,
                    path + "\\" + FileName);
                System.Diagnostics.Process.Start(@"C:\K_FillDoc\" + FileName);
            };

            pCntls.Add(btnSave, P_FIRST, Elements.Count + 1);
            pCntls.Add(btnCheck, P_SECOND, Elements.Count + 1);
        }

        /// <summary>
        /// Сохранение результата на рабочем столе.
        /// </summary>
        public void Save()
        {
            CreateDocument();
            Word.Document doc = null;

            try
            {
                Word.Application app = new Word.Application();
                doc = app.Documents.Open(@"C:\K_FillDoc\" + FileName);

                Word.Bookmarks bookmarks = doc.Bookmarks;
                Word.Range range = null;


                foreach (Word.Bookmark mark in bookmarks)
                {
                    for (int i = 0; i < Elements.Count; i++)
                    {
                        var obj = Elements[i];
                        string s = obj.NameBookmark;
                        if (s.Equals(mark.Name))
                        {
                            range = mark.Range;
                            range.Text = obj.Element.GetInformation();
                            break;
                        }
                    }
                }
                CreateCheckText(doc);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Во время выполнения произошла ошибка! :" + ex.ToString());
            }

            doc.Close();
            doc = null;
        }

        /// <summary>
        /// Создание текста предворительного просомтра.
        /// </summary>
        /// <param name="doc"></param>
        private void CreateCheckText(Word.Document doc)
        {
            CheckDocText = doc.Content.Text;
           //CheckDocText = "";
           //for (int i = 1; i < doc.Paragraphs.Count; i++)
           //{
           //    string parText = doc.Paragraphs[i].Range.Text;
           //    CheckDocText += parText + "\n";
           //}
        }
        
    }
}
