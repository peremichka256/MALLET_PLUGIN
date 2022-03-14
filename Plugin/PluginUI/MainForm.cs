using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using KompasWrapper;
using Microsoft.VisualBasic.Devices;

namespace PluginUI
{
    /// <summary>
    /// Класс хранящий и обрабатывающий пользовательский интерфейс плагина
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса построителя
        /// </summary>
        private MalletBuilder _malletBuilder;

        /// <summary>
        /// Объект класса с параметрами
        /// </summary>
        private MalletParameters _malletParameters =
            new MalletParameters();

        /// <summary>
        /// Словарь содержащий пары (Текстбоксы, имя параметра)
        /// </summary>
        private Dictionary<TextBox, ParameterNames> _textBoxesDictionary;

        /// <summary>
        /// Конструктор главной формы с необходимыми инициализациями
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _textBoxesDictionary = new Dictionary<TextBox, ParameterNames>
            {
                {HeadWidthTextBox, ParameterNames.HeadWidth},
                {HandleHeightTextBox, ParameterNames.HandleHeight},
                {HeadLengthTextBox, ParameterNames.HeadLength},
                {HeadHeightTextBox, ParameterNames.HeadHeight},
                {HandleDiameterTextBox, ParameterNames.HandleDiameter},
                {RadiusCrossTieTextBox, ParameterNames.RadiusCrossTie}
            };

            foreach (var textBox in _textBoxesDictionary)
            {
                textBox.Key.Text = _malletParameters
                    .GetParameterValueByName(textBox.Value).ToString();
            }
        }

        /// <summary>
        /// Устанавливает стиль для проверенного значения
        /// </summary>
        /// <param name="sender">Текстбокс</param>
        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                BuildButton.Enabled = true;
                textBox.BackColor = Color.White;
                toolTip.Active = false;
            }
        }

        /// <summary>
        /// Общий метод валидации текстбокса
        /// </summary>
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!(sender is TextBox textBox)) return;

            try
            {
                _textBoxesDictionary.TryGetValue(textBox,
                    out var parameterInTextBoxName);
                _malletParameters.SetParameterByName(parameterInTextBoxName,
                    int.Parse(textBox.Text));

                if (textBox == HeadWidthTextBox)
                {
                    HandleDiameterTextBox.Text =
                        _malletParameters.HandleDiameter.ToString();
                    HandleDiameterLabel.Text =$"(от " +
                        $"{MalletParameters.MIN_HANDLE_DIAMETER} до " +
                        $@"{ _malletParameters.HeadWidth 
                            - MalletParameters.HANDLE_HEAD_DIFFERENCE} мм)";
                    HandleDiameterLabel.Refresh();
                }
                else if (textBox == HeadLengthTextBox)
                {
                    HeadHeightTextBox.Text =
                        _malletParameters.HeadHeight.ToString(); 
                    HeadHeightLabel.Text = $"(от " +
                        $"{MalletParameters.MIN_HEAD_HEIGHT} до " +
                        $@"{ _malletParameters.HeadLength 
                            / MalletParameters.HANDLE_LENGTH_HEIGHT_MULTIPLIER}" +
                        "мм)";
                    HeadHeightLabel.Refresh();
                }
            }
            catch (Exception exception)
            {
                BuildButton.Enabled = false;
                textBox.BackColor = Color.LightSalmon;
                toolTip.Active = true;
                toolTip.SetToolTip(textBox, exception.Message);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Построить"
        /// </summary>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            var connector = new KompasConnector();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            _malletBuilder =
                new MalletBuilder(_malletParameters, connector);

            int countModel = 0;
            using (StreamWriter writter = new StreamWriter("D:\\Рабочий стол\\log.txt", true))
            {
                while (true)
                {
                    _malletBuilder.BuildMallet();
                    var computerInfo = new ComputerInfo();
                    var usedMemory = computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory;
                    countModel++;
                    writter.WriteLineAsync($"{countModel}\t{stopWatch.ElapsedMilliseconds}\t{usedMemory}");
                    writter.Flush();
                }
            }

        }
    }
}
