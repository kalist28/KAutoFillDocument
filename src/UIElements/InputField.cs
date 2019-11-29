using System;
using System.Windows.Forms;

namespace KFillDoc.UIElements
{
    /// <summary>
    /// K_Fill-Doc Application
    /// Элемент UI который отвечает за ввод текстовой информации.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    class InputField : UIElement, IInputTextInfo, IDisposable
    {
        /* UI элемент для ввода текстовой информации. */
        private readonly TextBox TextBox = new TextBox();

        /// <summary>
        /// Конструктор - инициализация объекта.
        /// </summary>
        /// <param name="name"> Имя закладки. </param>
        public InputField(string name) : base(name)
        {
            TextBox.Anchor = anchor;
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

        public new void Dispose()
        {
            TextBox.Dispose();
        }
    }
}
