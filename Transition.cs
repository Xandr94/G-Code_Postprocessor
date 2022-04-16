using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Code_Postprocessor
{
    /// <summary> Класс инструмента </summary>
    public class Tool
    {
        /// <summary> Номер инструмента </summary>
        public int num = 1;

        /// <summary> the Amount of Tool Departure (величина вылета инструмента) </summary>
        public float atd = 0;
    }

    
    /// <summary> Класс технологического перехода </summary>
    public class Transition
    {
        /// <summary> Перечисление типов перехода </summary>
        public enum TransitionType
        {
            /// <summary> Неопределён </summary>
            Undefined = 0,
            /// <summary> Установить </summary>
            Install = 1,
            /// <summary> Точить цилиндр </summary>
            ShoulderTurning = 2
        }
        /// <summary> Тип перехода </summary>
        public TransitionType transitionType = 0;
        /// <summary> Описание перехода </summary>
        public string text = "Неописанный переход";
        /// <summary> G-код перехода </summary>
        public Gcode gcode = new Gcode();

        /// <summary> Инициализация перехода </summary>
        public Transition Init(TransitionType transitionType, string text)
        {
            Transition t = new Transition();
            t.transitionType = transitionType;
            t.text = text;
            return t;
        }
        /// <summary> Инициализация перехода Установить </summary>
        public void InitInstall(CirclePiece circlePiece)
        {
            gcode = new Gcode();

            gcode.AddFrame(gcode.SetThePlaneXZ()
                         + gcode.SetMetricCoords()
                         + gcode.SetAbsoluteCoords()
                         + gcode.SetCoordSystem(Gcode.Offset.Offset1)); //ноль на торце заготовки
            gcode.AddFrame(gcode.FastMove(circlePiece.d + 5f, 0, 5f));
        }
        /// <summary> Инициализация перехода Точить цилиндр </summary>
        public void InitShoulderTurning(float D, float L, int ToolNumber)
        {
            gcode = new Gcode();

            gcode.AddFrame(gcode.SetTheTool(ToolNumber, 1));
        }

    }
}
