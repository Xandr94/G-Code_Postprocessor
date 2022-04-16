using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Code_Postprocessor
{
    /// <summary>
    /// Класс G-кода
    /// </summary>
    public class Gcode
    {
        /// <summary>
        /// Кадры G-кода
        /// </summary>
        public List<string> frames = new List<string>();


        public void Init()
        {
            
        }

        /// <summary>
        /// Добавить новый кадр
        /// </summary>
        /// <param name="words">Слова кадра - G, M или другие коды</param>
        public void AddFrame(string words)
        {
            frames.Add("N" + (frames.Count+1) + words + "\n");
        }

        /// <summary>
        /// Возвращает все кадры G-кода
        /// </summary>
        /// <returns></returns>
        public string GetGcode()
        {
            string s = "";
            for (int i = 0; i < frames.Count; i++)
            {
                s += frames[i];
            }
            return s;
        }

        /// <summary>
        /// Установить инструмент
        /// </summary>
        /// <param name="T">Номер инструмента</param>
        /// <param name="D">Функция инструмента</param>
        public string SetTheTool(int T, int D)
        {
            return " T" + T + " D" + D;
        }

        /// <summary>
        /// Ускоренное перемещение – перемещение на высокой скорости в указанную координату
        /// </summary>
        public string FastMove(float X, float Y, float Z)
        {
            return " G00 X" + X + " Y" + Y + " Z" + Z;
        }

        /// <summary>
        /// Линейная рабочее перемещение – перемещение по прямой в указанную координату на рабочей подаче
        /// </summary>
        /// <param name="F">Скорость подачи</param>
        public string Move(float X, float Y, float Z, float F)
        {
            return " G01 X" + X + " Y" + Y + " Z" + Z + " F" + F;
        }

        /// <summary>
        /// Рабочая система координат (смещение)
        /// </summary>
        public enum Offset
        {
            /// <summary>
            /// Без смещения
            /// </summary>
            WithoutOffset = 53,
            ///<summary>Заданное смещение 1</summary>
            Offset1 = 54,
            ///<summary>Заданное смещение 2</summary>
            Offset2 = 55,
            ///<summary>Заданное смещение 3</summary>
            Offset3 = 56,
            ///<summary>Заданное смещение 4</summary>
            Offset4 = 57,
            ///<summary>Заданное смещение 5</summary>
            Offset5 = 58,
            ///<summary>Заданное смещение 6</summary>
            Offset6 = 59
        }

        /// <summary>
        /// Установить рабочую систему координат (смещение)
        /// </summary>
        public string SetCoordSystem(Offset offset)
        {
            return " G" + (int)offset;
        }

        /// <summary>
        /// Установить вращение шпинделя по часовой стрелке
        /// </summary>
        /// <param name="S">Частота вращения</param>
        public string SetTheRotationClockwise(float S)
        {
            return " M03 S" + S;
        }

        /// <summary>
        /// Установить вращение шпинделя по часовой стрелке
        /// </summary>
        public string SetTheRotationClockwise()
        {
            return " M03";
        }

        /// <summary>
        /// Установить вращение шпинделя против часовой стрелки
        /// </summary>
        /// <param name="S">Частота вращения</param>
        public string SetTheRotationAnticlockwise(float S)
        {
            return " M04 S" + S;
        }

        /// <summary>
        /// Установить вращение шпинделя против часовой стрелки
        /// </summary>
        public string SetTheRotationAnticlockwise()
        {
            return " M04";
        }

        /// <summary>
        /// Остановить вращение шпинделя
        /// </summary>
        public string StopTheRotation()
        {
            return " M05";
        }

        /// <summary>
        /// Установить скорость вращения шпинделя
        /// </summary>
        /// <param name="S">Частота вращения</param>
        public string SetTheRotationSpeed(float S)
        {
            return " S" + S;
        }

        /// <summary>
        /// Установить рабочую плоскость XY
        /// </summary>
        public string SetThePlaneXY()
        {
            return " G17";
        }

        /// <summary>
        /// Установить рабочую плоскость XZ
        /// </summary>
        public string SetThePlaneXZ()
        {
            return " G18";
        }

        /// <summary>
        /// Установить рабочую плоскость YZ
        /// </summary>
        public string SetThePlaneYZ()
        {
            return " G19";
        }

        /// <summary>
        /// Установить ввод координат в дюймах
        /// </summary>
        public string SetInchCoords()
        {
            return " G20";
        }

        /// <summary>
        /// Установить ввод координат в миллиметрах
        /// </summary>
        public string SetMetricCoords()
        {
            return " G21";
        }

        /// <summary>
        /// Установить ввод абсолютных координат
        /// </summary>
        public string SetAbsoluteCoords()
        {
            return " G90";
        }

        /// <summary>
        /// Установить ввод относительных координат
        /// </summary>
        public string SetRelativeCoords()
        {
            return " G91";
        }

        

    }

}
