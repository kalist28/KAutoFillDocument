using System;

namespace KFillDoc.UIElements
{
    /// <summary>
    /// K_Fill-Doc Application
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    static class Adapter
    {
        /// <summary>
        /// Возращает заранее установленное имя документа.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static String GetNameFale(string name)
        {
            switch (name)
            {
                case "2345.docx":
                    return "Справка о пособии";
                default:
                    return name;
            }
        }

        /// <summary>
        /// Количество известных закладок, которые программа может обработать.
        /// </summary>
        /// <returns></returns>
        public static int BookmarksCount()
        {
            return 16;
        }
        /// <summary>
        /// Метот вовращает определенный элемент ПИ.
        /// </summary>
        /// <param name="name"> Имя закладки из документа. </param>
        /// <returns> Элемент пользовательского интерфейса. </returns>
        public static UIElement GetUIElement(string name)
        {
            switch(name)
            {
                case "UserFirstName":
                    return new InputField("Ваше имя");
                case "UserLastName":
                    return new InputField("Ваша фамилия");
                case "UserPatronymic":
                    return new InputField("Ваше отчество");
                case "UserPhoneNumber":
                    return new InputNumber("Ваш мобильный телефон");
                case "UserAddress":
                    return new InputNumber("Ваш адрес проживания");
                case "UserBirthday":
                    return new InputDate("Ваш день рождения");
                case "UserSatement":
                    return new InputDate("Заявление");
                case "MatherFirstName":
                    return new InputField("Имя матери");
                case "MatherLastName":
                    return new InputField("Фамилия матери");
                case "MatherPatronymic":
                    return new InputField("Отчество матери");
                case "MatherPhoneNumber":
                    return new InputNumber("Мобильный телефон матери");
                case "FatherFirstName":
                    return new InputField("Имя отца");
                case "FatherLastName":
                    return new InputField("Фамилия отца");
                case "FatherPatronymic":
                    return new InputField("Отчество отца");
                case "FatherPhoneNumber":
                    return new InputNumber("Мобильный телефон отца");
                case "DayNow":
                    return new InputDate("Выбирите дату");
                default:
                    return null;
            }
        }

        /// <summary>
        /// Метот вовращает порядковый номер элемента.
        /// </summary>
        /// <param name="name"> Имя закладки из документа. </param>
        /// <returns> Порядковый номер элемента. </returns>
        public static int GetType(string name)
        {
            switch (name)
            {
                case "UserFirstName":
                    return 1;
                case "UserLastName":
                    return 2;
                case "UserPatronymic":
                    return 3;
                case "UserPhoneNumber":
                    return 4;
                case "UserAddress":
                    return 5;
                case "UserBirthday":
                    return 6;
                case "UserSatement":
                    return 7;
                case "MatherFirstName":
                    return 8;
                case "MatherLastName":
                    return 9;
                case "MatherPatronymic":
                    return 10;
                case "MatherPhoneNumber":
                    return 11;
                case "FatherFirstName":
                    return 12;
                case "FatherLastName":
                    return 13;
                case "FatherPatronymic":
                    return 14;
                case "FatherPhoneNumber":
                    return 15;
                case "DayNow":
                    return 16;
                default:
                    return 0;
            }
        }
    }
}
