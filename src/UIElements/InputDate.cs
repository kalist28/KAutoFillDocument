using System;
using System.Windows.Forms;

namespace KFillDoc.UIElements
{
    /// <summary>
    /// K_Fill-Doc Application
    /// Элемент UI который отвечает за ввод даты.
    /// 
    /// Author Dmitriy Kalistratov <kalistratov.d.m@gmail.com>
    /// </summary>
    class InputDate : UIElement , IDisposable
    {
        /* UI элемент для ввода даты. */
        private readonly DateTimePicker DateTimePicker = new DateTimePicker();

        /// <summary>
        /// Конструктор - инициализация объекта.
        /// </summary>
        /// <param name="name"> Имя закладки. </param>
        public InputDate(string name) : base(name)
        {
            DateTimePicker.Anchor = anchor;
        }

        /// <summary>
        /// Возращает обьект содержищий дату.
        /// </summary>
        /// <returns> DateTimePicker обьект. </returns>
        public DateTimePicker GetDateTimePicker() => DateTimePicker;
        
        /// <summary>
        /// Возращает число дня.
        /// </summary>
        /// <returns> Число. </returns>
        public int GetDay() => DateTimePicker.Value.Day;
        

        /// <summary>
        /// Возращает месяц в двух падежах.
        /// </summary>
        /// <param name="p"> Отвечает за родительный падеж. </param>
        /// <returns> Название месяца. </returns>
        public String GetMonth(bool p)
        {
            switch (DateTimePicker.Value.Month)
            {
                case 1:
                    if (p)
                        return "января";
                    else
                        return "январь";
                case 2:
                    if (p)
                        return "февраль";
                    else
                        return "февраля";
                case 3:
                    if (p)
                        return "март";
                    else
                        return "марта";
                case 4:
                    if (p)
                        return "апрель";
                    else
                        return "апреля";
                case 5:
                    if (p)
                        return "май";
                    else
                        return "мая";
                case 6:
                    if (p)
                        return "июнь";
                    else
                        return "июня";
                case 7:
                    if (p)
                        return "июль";
                    else
                        return "июля";
                case 8:
                    if (p)
                        return "август";
                    else
                        return "августа";
                case 9:
                    if (p)
                        return "сентябрь";
                    else
                        return "сентября";
                case 10:
                    if (p)
                        return "октябрь";
                    else
                        return "октября";
                case 11:
                    if (p)
                        return "ноябрь";
                    else
                        return "ноября";
                case 12:
                    if (p)
                        return "декабрь";
                    else
                        return "декабря";
                default:
                    return "январь";
            }
        }

        /// <summary>
        /// Возращает номер года.
        /// </summary>
        /// <returns> Номер года. </returns>
        public int GetYear() => DateTimePicker.Value.Year;

        public override string GetInformation()
        {
            return GetDay() + "." + GetMonth(true) + "." + GetYear();
        }

        public new void Dispose()
        {
            DateTimePicker.Dispose();
        }
    }
}
