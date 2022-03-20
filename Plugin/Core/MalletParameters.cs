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
        /// Размер фаски на бойке
        /// </summary>
        private static Parameter<int> _chamferRadius =
            new Parameter<int>(ParameterNames.ChamferRadius,
                MAX_CHAMFER_RADIUS, MIN_CHAMFER_RADIUS);

        /// <summary>
        /// Словарь содержащий пары (Имя параметра, указатель на него)
        /// </summary>
        private Dictionary<ParameterNames, Parameter<int>>
            _parametersDictionary =
                new Dictionary<ParameterNames, Parameter<int>>
                {
                    {_handleDiameter.Name, _handleDiameter},
                    {_handleHeight.Name, _handleHeight},
                    {_headHeight.Name, _headHeight},
                    {_headLength.Name, _headLength},
                    {_headWidth.Name, _headWidth},
                    {_chamferRadius.Name, _chamferRadius}
                };

        /// <summary>
        /// Конастанты минимальных и максимальных значений параметров в мм
        /// Минимальные значения являются дефолтными
        /// </summary>
        public const int MIN_HANDLE_DIAMETER = 20;
        public const int MAX_HANDLE_DIAMETER =
            MIN_HEAD_WIDTH - HANDLE_HEAD_DIFFERENCE;

        public const int MIN_HANDLE_HEIGHT = 150;
        public const int MAX_HANDLE_HEIGHT = 400;

        public const int MIN_HEAD_HEIGHT = 40;

        public const int MAX_HEAD_HEIGHT =
            MIN_HEAD_LENGTH / HANDLE_LENGTH_HEIGHT_MULTIPLIER;

        public const int MIN_HEAD_LENGTH = 100;
        public const int MAX_HEAD_LENGTH = 200;

        public const int MIN_HEAD_WIDTH = 40;
        public const int MAX_HEAD_WIDTH = 80;

        public const int MIN_CHAMFER_RADIUS = 1;
        public const int MAX_CHAMFER_RADIUS = 4;

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
            set
            {
                _headLength.Value = value;
                _headHeight.Max = value / HANDLE_LENGTH_HEIGHT_MULTIPLIER;

                if (HeadHeight > _headHeight.Max)
                {
                    HeadHeight = _headHeight.Max;
                }
            }
        }

        /// <summary>
        /// Задаёт или возвращает ширину бойка
        /// </summary>
        public int HeadWidth
        {
            get => _headWidth.Value;
            set
            {
                _headWidth.Value = value;
                _handleDiameter.Max = value - HANDLE_HEAD_DIFFERENCE;

                if (HandleDiameter > _handleDiameter.Max)
                {
                    HandleDiameter = _handleDiameter.Max;
                }
            }
        }

        /// <summary>
        /// Задаёт или возвращает размер фаски на бойке
        /// </summary>
        public int ChamferRadius
        {
            get => _chamferRadius.Value;
            set => _chamferRadius.Value = value;
        }

        /// <summary>
        /// Конструктор класса с минимальными значенми по умолчанию
        /// </summary>
        public MalletParameters()
        {
            this.HeadHeight = MIN_HEAD_HEIGHT;
            this.HandleDiameter = MIN_HANDLE_DIAMETER;
            this.HandleHeight = MIN_HANDLE_HEIGHT;
            this.HeadLength = MIN_HEAD_LENGTH;
            this.HeadWidth = MIN_HEAD_WIDTH;
            this.ChamferRadius = MIN_CHAMFER_RADIUS;
        }

        /// <summary>
        /// Метод передающй значение в сеттер параметра по имени
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <param name="value">Значение</param>
        public void SetParameterByName(ParameterNames name, int value)
        {
            if (_parametersDictionary.ContainsKey(name))
            {
                switch (name)
                {
                    case ParameterNames.HeadLength:
                        HeadLength = value;
                        break;
                    case ParameterNames.HeadWidth:
                        HeadWidth = value;
                        break;
                    default:
                        _parametersDictionary.TryGetValue(name,
                            out var parameter);
                        parameter.Value = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Метод возвращающий значение параметра по имени
        /// </summary>
        /// <param name="name">Имя</param>
        /// <returns>Значение</returns>
        public int GetParameterValueByName(ParameterNames name)
        {
            _parametersDictionary.TryGetValue(name, out var parameter);
            return parameter.Value;
        }

        /// <summary>
        /// Метод возвращающий минимальное возможное значение параметра
        /// по имени
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <returns>Значения минимума</returns>
        public int GetParameterMinByName(ParameterNames name)
        {
            _parametersDictionary.TryGetValue(name, out var parameter);
            return parameter.Min;
        }

        /// <summary>
        /// Метод возвращающий максимальное возможное значение параметра
        /// по имени
        /// </summary>
        /// <param name="name">Имя параметра</param>
        /// <returns>Значения максимума</returns>
        public int GetParameterMaxByName(ParameterNames name)
        {
            _parametersDictionary.TryGetValue(name, out var parameter);
            return parameter.Max;
        }
    }
}
