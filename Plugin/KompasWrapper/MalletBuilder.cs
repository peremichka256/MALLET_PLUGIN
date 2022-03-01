using System;
using Core;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace KompasWrapper
{
    /// <summary>
    /// Класс осуществляющий построение детали
    /// </summary>
    public class MalletBuilder
    {
        /// <summary>
        /// Объект класса конектора для связи с КОММПАС-3D
        /// </summary>
        private KompasConnector _connector;

        /// <summary>
        /// Объект класса параметра для построение детали
        /// </summary>
        private MalletParameters _parameters;

        /// <summary>
        /// Стиль линии: основная
        /// </summary>
        private const int MainLineStyle = 1;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="parameters">Параметры киянки</param>
        /// <param name="connector">Объект для связи с КОМПАС-3D</param>
        public MalletBuilder(MalletParameters parameters,
            KompasConnector connector)
        {
            _parameters = parameters;
            _connector = connector;
        }

        /// <summary>
        /// Метод объединяющий боёк и ручку
        /// </summary>
        public void BuildMallet()
        {

            _connector.Start();
            _connector.CreateDocument3D();

            BuildMalletHandle(_parameters.HandleDiameter, _parameters.HandleHeight);
            BuildMalletHead(_parameters.HeadLength, _parameters.HeadWidth, _parameters.HeadHeight);
        }

        /// <summary>
        /// Метод осуществляющий построение бойка
        /// </summary>
        private void BuildMalletHead(int headLength, int headWidth, int headHeight)
        {
            var sketch = CreateSketch(Obj3dType.o3d_planeXOZ, null);
            var doc2d = (ksDocument2D)sketch.BeginEdit();
            doc2d.ksRectangle(DrawRectangle(-headLength/2, -headWidth/2, headWidth, headLength));

            sketch.EndEdit();
            СreateExtrusion(sketch, headHeight);
        }

        /// <summary>
        /// Метод осуществляющий построение ручки
        /// </summary>
        private void BuildMalletHandle(int handleDiameter, int handleHeight)
        {
            var sketch = CreateSketch(Obj3dType.o3d_planeXOZ, null);
            var doc2d = (ksDocument2D)sketch.BeginEdit();
            doc2d.ksCircle(0, 0, handleDiameter / 2, MainLineStyle);

            sketch.EndEdit();
            СreateExtrusion(sketch, handleHeight);
        }

        /// <summary>
        /// Метод рисования прямоугольника
        /// </summary>
        /// <param name="x">X базовой точки</param>
        /// <param name="y">Y базовой точки</param>
        /// <param name="height">Высота</param>
        /// <param name="width">Ширина</param>
        /// <returns>Переменная с параметрами прямоугольника</returns>
        private ksRectangleParam DrawRectangle(double x, double y,
            double height, double width)
        {
            var rectangleParam =
                (ksRectangleParam)_connector.Object.GetParamStruct
                    ((short)StructType2DEnum.ko_RectangleParam);
            rectangleParam.x = x;
            rectangleParam.y = y;
            rectangleParam.height = height;
            rectangleParam.width = width;
            rectangleParam.style = MainLineStyle;
            return rectangleParam;
        }

        /// <summary>
        /// Метод осущетсвляющий выдавливание
        /// </summary>
        /// <param name="sketch">Эскиз</param>
        /// <param name="depth">Расстояние выдавливания</param>
        private void СreateExtrusion(ksSketchDefinition sketch,
            double depth, bool side = true)
        {
            var extrusionEntity = (ksEntity)_connector.Part.NewEntity(
                (short)ksObj3dTypeEnum.o3d_bossExtrusion);
            var extrusionDef = (ksBossExtrusionDefinition)extrusionEntity
                .GetDefinition();

            extrusionDef.SetSideParam(side,
                (short)End_Type.etBlind, depth);
            extrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal :
                (short)Direction_Type.dtReverse;
            extrusionDef.SetSketch(sketch);

            extrusionEntity.Create();
        }

        /// <summary>
        /// Метод создающий эскиз
        /// </summary>
        /// <param name="planeType">Плоскость</param>
        /// <param name="offsetPlane">Объект смещения</param>
        /// <returns>Эскиз</returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType,
            ksEntity offsetPlane)
        {
            var plane = (ksEntity)_connector.Part
                .GetDefaultEntity((short)planeType);

            var sketch = (ksEntity)_connector.Part.
                NewEntity((short)Obj3dType.o3d_sketch);
            var ksSketch = (ksSketchDefinition)sketch.GetDefinition();

            if (offsetPlane != null)
            {
                ksSketch.SetPlane(offsetPlane);
                sketch.Create();
                return ksSketch;
            }

            ksSketch.SetPlane(plane);
            sketch.Create();
            return ksSketch;
        }
    }
}
