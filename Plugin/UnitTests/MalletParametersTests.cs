using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class MalletParametersTests
    {
        //TODO:
        /// <summary>
        /// Объект класса с параметрами для тестов
        /// </summary>
        private MalletParameters _testMalletParameters;

        /// <summary>
        /// Словарь имён и максимальных значений параметров
        /// </summary>
        private readonly Dictionary<ParameterNames, int>
            _maxValuesOfParameterDictionary =
                new ()
                {
                    {
                        ParameterNames.HeadLength,
                        MalletParameters.MAX_HEAD_LENGTH
                    },
                    {
                        ParameterNames.HeadHeight,
                        MalletParameters.MAX_HEAD_HEIGHT
                    },
                    {
                        ParameterNames.HeadWidth,
                        MalletParameters.MAX_HEAD_WIDTH
                    },
                    {
                        ParameterNames.HandleHeight,
                        MalletParameters.MAX_HANDLE_HEIGHT
                    },
                    {
                        ParameterNames.HandleDiameter,
                        MalletParameters.MAX_HANDLE_DIAMETER
                    },
                    {
                        ParameterNames.ChamferRadius,
                        MalletParameters.MAX_CHAMFER_RADIUS
                    },
                };

        [Test(Description = "Тест метода передающий значение "
                            + "в сеттер параметра по его имени")]
        public void TestSetParameterByName()
        {
            _testMalletParameters = new MalletParameters();
        
            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                _testMalletParameters.SetParameterByName(
                    parameterMaxValue.Key, parameterMaxValue.Value);
            }
        
            int errorCounter = 0;
        
            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                if (_testMalletParameters.GetParameterValueByName(
                        parameterMaxValue.Key) != parameterMaxValue.Value)
                {
                    errorCounter++;
                }
            }
        
            Assert.Zero(errorCounter,
                "Значения не были помещены в сеттеры параметров");
        }
        
        [Test(Description = "Тест на геттер значения параметра по имени")]
        public void TestGetParameterByName()
        {
            _testMalletParameters = new MalletParameters();
        
            var newValue = (MalletParameters.MIN_HEAD_LENGTH
                            + MalletParameters.MAX_HEAD_LENGTH) / 2;
            ParameterNames testParameterName =
                ParameterNames.HeadLength;
            _testMalletParameters
                .SetParameterByName(testParameterName, newValue);
        
            Assert.AreEqual(newValue, _testMalletParameters
                    .GetParameterValueByName(testParameterName),
                "Из геттера вернулось неверное значение");
        }

        [Test(Description = "Позитивный тест на геттеры параметров")]
        public void TestParameterGet()
        {
            _testMalletParameters = new MalletParameters();

            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                _testMalletParameters.SetParameterByName(
                    parameterMaxValue.Key, parameterMaxValue.Value);
            }

            Assert.IsTrue(_testMalletParameters.HeadLength
                          == MalletParameters.MAX_HEAD_LENGTH
                          && _testMalletParameters.HeadWidth
                          == MalletParameters.MAX_HEAD_WIDTH
                          && _testMalletParameters.HandleHeight
                          == MalletParameters.MAX_HANDLE_HEIGHT
                          && _testMalletParameters.ChamferRadius
                          == MalletParameters.MAX_CHAMFER_RADIUS,
                "Возникает, если геттер вернул не то значение");
        }

        [Test(Description = "Тест на сеттер длины бойка")]
        public void TestHeadLength_Set()
        {
            _testMalletParameters = new MalletParameters();

            _testMalletParameters.HeadLength = MalletParameters.MAX_HEAD_LENGTH;
            _testMalletParameters.HeadHeight = MalletParameters.MAX_HEAD_LENGTH 
                / MalletParameters.HANDLE_LENGTH_HEIGHT_MULTIPLIER;
            _testMalletParameters.HeadLength = MalletParameters.MIN_HEAD_LENGTH;

            Assert.AreEqual(_testMalletParameters.HeadHeight,
                MalletParameters.MIN_HEAD_LENGTH
                / MalletParameters.HANDLE_LENGTH_HEIGHT_MULTIPLIER, 
                "Сеттер не поменял знаечние зависимого параметра");
        }

        [Test(Description = "Тест на сеттер ширины бойка")]
        public void TestHeadWidth_Set()
        {
            _testMalletParameters = new MalletParameters();

            _testMalletParameters.HeadWidth = MalletParameters.MAX_HEAD_WIDTH;
            _testMalletParameters.HandleDiameter = MalletParameters.MAX_HEAD_WIDTH
                                                   - MalletParameters.HANDLE_HEAD_DIFFERENCE;
            _testMalletParameters.HeadWidth = MalletParameters.MIN_HEAD_WIDTH;

            Assert.AreEqual(_testMalletParameters.HandleDiameter,
                MalletParameters.MIN_HEAD_WIDTH - MalletParameters.HANDLE_HEAD_DIFFERENCE,
                "Сеттер не поменял знаечние зависимого параметра");
        }
    }
}
