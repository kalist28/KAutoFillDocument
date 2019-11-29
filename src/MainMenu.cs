using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using KFillDoc.UIElements;

namespace KFillDoc
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Icon = new Icon("icoK.ico");
            this.StartPosition = FormStartPosition.CenterScreen;

            List<string> filesName = new List<string>();

            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory + @"\\docs");
            foreach (var item in dir.GetFiles())
            {
                filesName.Add(item.Name);
            }

            for (int i = 0; i < filesName.Count; i++)
            {
                string btmName = Adapter.GetNameFale(filesName[i]);
                string nameFile = filesName[i];
                Button b = new Button
                {
                    Name = btmName,
                    Text = btmName,
                    Size = new Size(190, 23)
                };

                b.Click += (
                    delegate
                    {
                        DocName.Text = "Загрузка";
                        mainObjectPanel.Controls.Clear();
                        mainObjectPanel.RowStyles.Clear();
                        Document mm = new Document(nameFile);
                        mm.RenderUI(mainObjectPanel);
                        DocName.Text = btmName;
                    }
                );
                
                flowLayoutPanel.Controls.Add(b);
            }
        }

    }
}
