using System;
using System.Windows.Forms;

namespace KFillDoc.UIElements
{
    /// <summary>
    /// K_Fill-Doc Application
    /// Элемент UI который отвечает за числовой информации.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    class InputNumber : UIElement, IInputTextInfo, IDisposable
    {
        /* UI элемент для ввода числовой информации. */
        private readonly TextBox TextBox = new TextBox();

        /// <summary>
        /// Конструктор - инициализация объекта.
        /// </summary>
        /// <param name="name"> Имя закладки. </param>
        public InputNumber(String name) : base(name) 
        {
            TextBox.Anchor = anchor;
            TextBox.KeyPress += KeyPress;
        }

        /// <summary>
        /// Возращает введенную пользователем информацию.
        /// </summary>
        /// <returns></returns>
        public override string GetInformation() => TextBox.Text;
        

        /// <summary>
        /// Возращает обьект типа TextBox.
        /// </summary>
        /// <returns> Возращает обьект типа TextBox. </returns>
        public TextBox GetTextBox() => TextBox;
        
        /// <summary>
        /// Описывает параметры для ввода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPress(object sender, KeyPressEventArgs e)
        { 
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        public new void Dispose()
        {
            TextBox.Dispose();
        }
    }
}
