using System;
using System.Windows.Forms;

namespace KFillDoc.UIElements
{
    /// <summary>
    /// K_Fill-Doc Application
    /// Интерфейс обьекта который отвечает за ввод текстовой информации.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    interface IInputTextInfo
    {
        /* Возращает обьект типа Label. */
        Label GetLabel();

        /* Возращает обьект типа TextBox. */
        TextBox GetTextBox();

    }

    /// <summary>
    /// K_Fill-Doc Application
    /// Родительский класс обьекта который отвечает за ввод информации.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    abstract class UIElement : IDisposable
    {
        /* Текстовый элемент. Информация о вводе . */
        public readonly Label Label = new Label();
        public abstract string GetInformation();

        public AnchorStyles anchor = AnchorStyles.Top
                                   | AnchorStyles.Bottom
                                   | AnchorStyles.Left
                                   | AnchorStyles.Right;

        /// <summary>
        /// Конструктор - инициализация обьекта.
        /// </summary>
        /// <param name="name"> Имя закладки. </param>
        public UIElement(String name)
        {
            Label.Text = name + ": ";
            Label.Anchor = anchor;
            Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }

        /// <summary>
        /// Возращает обьект типа Label.
        /// </summary>
        /// <returns> Возращает обьект типа Label. </returns>
        public Label GetLabel() => Label;
        

        public void Dispose()
        {
            Label.Dispose();
        }
    }
}
