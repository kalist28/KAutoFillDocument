using System;

namespace KFillDoc.UIElements
{
    /// <summary>
    /// K_Fill-Doc Application
    /// Элемент UI который отвечает за отображения имени закладки и поля для ввода.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    class ElementBox
    {
        /* Имя закладки. */
        public String NameBookmark;

        /* Обьект отвечающий за ввод. */
        public UIElement Element;

        /// <summary>
        /// Конструктор - Инициализация обьекта.
        /// </summary>
        /// <param name="nameBookmark"> Имя закладки. </param>
        public ElementBox(string nameBookmark)
        {
            this.NameBookmark = nameBookmark;
            Initialize();
        }

        /// <summary>
        /// Инициализация обьекта.
        /// </summary>
        private void Initialize()
        {
            Element = Adapter.GetUIElement(NameBookmark);
        }
    }
}
