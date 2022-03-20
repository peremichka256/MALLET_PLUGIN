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
        /// Свойство возвращающее новый обект класса MalletParameters
        /// </summary>
        private MalletParameters DefaultParameters =>
            new MalletParameters();

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
            var testMalletParameters = DefaultParameters;
        
            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                testMalletParameters.SetParameterByName(
                    parameterMaxValue.Key, parameterMaxValue.Value);
            }
        
            int errorCounter = 0;
        
            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                if (testMalletParameters.GetParameterValueByName(
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
            var testMalletParameters = DefaultParameters;
        
            var newValue = (MalletParameters.MIN_HEAD_LENGTH
                            + MalletParameters.MAX_HEAD_LENGTH) / 2;
            ParameterNames testParameterName =
                ParameterNames.HeadLength;
            testMalletParameters
                .SetParameterByName(testParameterName, newValue);
        
            Assert.AreEqual(newValue, testMalletParameters
                    .GetParameterValueByName(testParameterName),
                "Из геттера вернулось неверное значение");
        }

        [Test(Description = "Позитивный тест на геттеры параметров")]
        public void TestParameterGet()
        {
            var testMalletParameters = DefaultParameters;

            foreach (var parameterMaxValue
                     in _maxValuesOfParameterDictionary)
            {
                testMalletParameters.SetParameterByName(
                    parameterMaxValue.Key, parameterMaxValue.Value);
            }

            Assert.IsTrue(testMalletParameters.HeadLength
                          == MalletParameters.MAX_HEAD_LENGTH
                          && testMalletParameters.HeadWidth
                          == MalletParameters.MAX_HEAD_WIDTH
                          && testMalletParameters.HandleHeight
                          == MalletParameters.MAX_HANDLE_HEIGHT
                          && testMalletParameters.ChamferRadius
                          == MalletParameters.MAX_CHAMFER_RADIUS,
                "Возникает, если геттер вернул не то значение");
        }

        [Test(Description = "Тест на сеттер длины бойка")]
        public void TestHeadLength_Set()
        {
            var testMalletParameters = DefaultParameters;

            testMalletParameters.HeadLength = MalletParameters.MAX_HEAD_LENGTH;
            testMalletParameters.HeadHeight = MalletParameters.MAX_HEAD_LENGTH 
                / MalletParameters.HANDLE_LENGTH_HEIGHT_MULTIPLIER;
            testMalletParameters.HeadLength = MalletParameters.MIN_HEAD_LENGTH;

            Assert.AreEqual(testMalletParameters.HeadHeight,
                MalletParameters.MIN_HEAD_LENGTH
                / MalletParameters.HANDLE_LENGTH_HEIGHT_MULTIPLIER, 
                "Сеттер не поменял знаечние зависимого параметра");
        }

        [Test(Description = "Тест на сеттер ширины бойка")]
        public void TestHeadWidth_Set()
        {
            var testMalletParameters = DefaultParameters;

            testMalletParameters.HeadWidth = MalletParameters.MAX_HEAD_WIDTH;
            testMalletParameters.HandleDiameter = MalletParameters.MAX_HEAD_WIDTH
                                                   - MalletParameters.HANDLE_HEAD_DIFFERENCE;
            testMalletParameters.HeadWidth = MalletParameters.MIN_HEAD_WIDTH;

            Assert.AreEqual(testMalletParameters.HandleDiameter,
                MalletParameters.MIN_HEAD_WIDTH - MalletParameters.HANDLE_HEAD_DIFFERENCE,
                "Сеттер не поменял знаечние зависимого параметра");
        }

        [Test(Description = "Тест на геттер минимума параметра по имени")]
        public void TestGetParameterMinByName()
        {
            var testMalletParameters = DefaultParameters;
            
            ParameterNames testParameterName =
                ParameterNames.HeadLength;

            Assert.AreEqual(MalletParameters.MIN_HEAD_LENGTH, 
                testMalletParameters.GetParameterMinByName(testParameterName),
                "Из геттера вернулось неверное значение минимума");
        }

        [Test(Description = "Тест на геттер максимума параметра по имени")]
        public void TestGetParameterMaxByName()
        {
            var testMalletParameters = DefaultParameters;

            ParameterNames testParameterName =
                ParameterNames.HeadLength;

            Assert.AreEqual(MalletParameters.MAX_HEAD_LENGTH,
                testMalletParameters.GetParameterMaxByName(testParameterName),
                "Из геттера вернулось неверное значение максимума");
        }
    }
}
