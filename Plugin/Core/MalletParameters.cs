using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KompasPlugin;

namespace Core
{

    /// <summary>
    /// Класс хранящий параметры киянки
    /// </summary>
    public class MalletParameters
    {
        /// <summary>
        /// Диаметр ручки
        /// </summary>
        private static Parameter<int> _handleDiameter =
            new Parameter<int>(ParameterNames.HandleDiameter,
                MAX_HANDLE_DIAMETER, MIN_HANDLE_DIAMETER);

        /// <summary>
        /// Высота ручки
        /// </summary>
        private static Parameter<int> _handleHeight =
            new Parameter<int>(ParameterNames.HandleHeight,
                MAX_HANDLE_HEIGHT, MIN_HANDLE_HEIGHT);

        /// <summary>
        /// Высота бойка
        /// </summary>
        private static Parameter<int> _headHeight =
            new Parameter<int>(ParameterNames.HeadHeight,
                MAX_HEAD_HEIGHT, MIN_HEAD_HEIGHT);

        /// <summary>
        /// Длина бойка
        /// </summary>
        private static Parameter<int> _headLength =
            new Parameter<int>(ParameterNames.HeadLength,
                MAX_HEAD_LENGTH, MIN_HEAD_LENGTH);

        /// <summary>
        /// Ширина бойка
        /// </summary>
        private static Parameter<int> _headWidth =
            new Parameter<int>(ParameterNames.HeadWidth,
                MAX_HEAD_WIDTH, MIN_HEAD_WIDTH);

        /// <summary>
        /// Конастанты минимальных и максимальных значений параметров в мм
        /// Минимальные значения являются дефолтными
        /// </summary>
        public const int MIN_HANDLE_DIAMETER = 20;
        public const int MAX_HANDLE_DIAMETER =
            MAX_HEAD_WIDTH - HANDLE_HEAD_DIFFERENCE;

        public const int MIN_HANDLE_HEIGHT = 150;
        public const int MAX_HANDLE_HEIGHT = 400;

        public const int MIN_HEAD_HEIGHT = 40;
        public const int MAX_HEAD_HEIGHT = 
            MAX_HEAD_LENGTH / HANDLE_LENGTH_HEIGHT_MULTIPLIER;

        public const int MIN_HEAD_LENGTH = 100;
        public const int MAX_HEAD_LENGTH = 200;

        public const int MIN_HEAD_WIDTH = 40;
        public const int MAX_HEAD_WIDTH = 80;

        /// <summary>
        /// Константы ограничений для параметров
        /// </summary>
        public const int HANDLE_HEAD_DIFFERENCE = 10;
        public const int HANDLE_LENGTH_HEIGHT_MULTIPLIER = 2;

        /// <summary>
        /// Задаёт или возвращает диаметр ручки
        /// </summary>
        public int HandleDiameter
        {
            get => _handleDiameter.Value;
            set => _handleDiameter.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает высоту ручки
        /// </summary>
        public int HandleHeight
        {
            get => _handleHeight.Value;
            set => _handleHeight.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает ввысоту бойка
        /// </summary>
        public int HeadHeight
        {
            get => _headHeight.Value;
            set => _headHeight.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает длину бойка
        /// </summary>
        public int HeadLength
        {
            get => _headLength.Value;
            set => _headLength.Value = value;
        }

        /// <summary>
        /// Задаёт или возвращает ширину бойка
        /// </summary>
        public int HeadWidth
        {
            get => _headWidth.Value;
            set => _headWidth.Value = value;
        }
    }
}
