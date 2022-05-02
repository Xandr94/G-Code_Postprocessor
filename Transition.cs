using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Code_Postprocessor
{
    /// <summary> Перечисление типов перехода </summary>
    public enum TransitionType
    {
        /// <summary> Неопределён </summary>
        Undefined = 0,
        /// <summary> Установить заготовку </summary>
        Install = 1,
        /// <summary> Точить цилиндр </summary>
        ShoulderTurning = 2,
        /// <summary> Снять заготовку </summary>
        Uninstall = 3,
        /// <summary> Торцевание </summary>
        Facing = 4
    }
    public class Install
    {
        /// <summary> Диаметр заготовки </summary>
        public float D;
        /// <summary> Длинна заготовки </summary>
        public float L;

    }
    public class Uninstall
    {
        /// <summary> Диаметр заготовки </summary>
        public float D;
        /// <summary> Длинна заготовки </summary>
        public float L;
        /// <summary> Позиция резца вдоль оси X </summary>
        public float X;
        /// <summary> Позиция резца вдоль оси Z </summary>
        public float Z;
        /// <summary> Остановить шпиндель </summary>
        public bool Stop;
        /// <summary> Завершить программу </summary>
        public bool End;
    }
    public class ShoulderTurning
    {
        /// <summary> Получаемый диаметр </summary>
        public float D;
        /// <summary> Длина проточки </summary>
        public float L;
        /// <summary> Отступ от торца </summary>
        public float B;
        /// <summary> Диаметр заготовки </summary>
        public float Dpiece;
        /// <summary> Глубина резания </summary>
        public float h;
        /// <summary> Значение возврата </summary>
        public float R;
        /// <summary> Припуск на чистовую обработку </summary>
        public float U;
        /// <summary> Скорость подачи </summary>
        public float F;
        /// <summary> Скорость вращения шпинделя </summary>
        public float S;
        /// <summary> Номер инструмента </summary>
        public int ToolNumber;
        /// <summary> Номер вылета инструмента </summary>
        public int ToolDepartureNumber;
        /// <summary> Остановить станок для смены инстумента </summary>
        public bool MachinePause;
        /// <summary> Высота инструмента над зоготовкой </summary>
        public float X;
        /// <summary> Величина подвода к заготовке </summary>
        public float Z;
    }
    public class Facing
    {
        /// <summary> Получаемый диаметр заготовки </summary>
        public float D;
        /// <summary> Получаемая длинна заготовки </summary>
        public float L;
        /// <summary> Отступ от торца </summary>
        public float B;
        /// <summary> Диаметр заготовки </summary>
        public float Dpiece;
        /// <summary> Длинна заготовки </summary>
        public float Lpiece;
        /// <summary> Глубина резания </summary>
        public float h;
        /// <summary> Значение возврата </summary>
        public float R;
        /// <summary> Припуск на чистовую обработку по X </summary>
        public float U;
        /// <summary> Припуск на чистовую обработку по Z </summary>
        public float W;
        /// <summary> Скорость подачи </summary>
        public float F;
        /// <summary> Скорость вращения шпинделя </summary>
        public float S;
        /// <summary> Номер инструмента </summary>
        public int ToolNumber;
        /// <summary> Номер вылета инструмента </summary>
        public int ToolDepartureNumber;
        /// <summary> Остановить станок для смены инстумента </summary>
        public bool MachinePause;
        /// <summary> Высота инструмента над зоготовкой </summary>
        public float X;
        /// <summary> Величина подвода к заготовке </summary>
        public float Z;
    }

    /// <summary> Класс технологического перехода </summary>
    public class Transition
    {
        /// <summary> Тип перехода </summary>
        public TransitionType transitionType = 0;
        /// <summary> Описание перехода </summary>
        public string description = "Неописанный переход";
        /// <summary> G-код перехода </summary>
        public Gcode gcode = new Gcode();

        public ShoulderTurning shoulderTurning;
        public Install install;
        public Uninstall uninstall;
        public Facing facing;

        /// <summary> Инициализация перехода </summary>
        public void Init(TransitionType transitionType)
        {
            this.gcode = new Gcode();
            this.transitionType = transitionType;
            switch (transitionType)
            {
                case TransitionType.Install:
                    install = new Install();
                    description = "Установить заготовку";
                    break;
                case TransitionType.Uninstall:
                    uninstall = new Uninstall();
                    description = "Снять заготовку";
                    break;
                case TransitionType.ShoulderTurning:
                    shoulderTurning = new ShoulderTurning();
                    description = "Точить цилиндр";
                    break;
                case TransitionType.Facing:
                    facing = new Facing();
                    description = "Торцевать";
                    break;
                default:
                    break;
            }
        }

        public bool GenerateGcode(int framesCount)
        {
            gcode = new Gcode();
            gcode.framesOffset = framesCount;

            switch (transitionType)
            {
                case TransitionType.Install:
                    {
                        float D = install.D;
                        float L = install.L;

                        gcode.AddFrame(gcode.SetThePlaneXZ()
                             + gcode.SetMetricCoords()
                             + gcode.SetAbsoluteCoords()
                             + gcode.SetCoordSystem(Gcode.Offset.Offset1)); //ноль на торце заготовки
                        gcode.AddFrame(gcode.FastMove(D + 5f, 5f) + "\n\n");
                        return true;
                    }
                case TransitionType.Uninstall:
                    {
                        float D = uninstall.D;
                        float L = uninstall.L;
                        float X = uninstall.X;
                        float Z = uninstall.Z;
                        bool Stop = uninstall.Stop;
                        bool End = uninstall.End;

                        if (Stop) gcode.AddFrame(gcode.StopTheRotation());
                        gcode.AddFrame(gcode.FastMove(2*X, Z));//ноль на торце заготовки
                        if (End) gcode.frames.Add("M02");
                        return true;
                    }
                case TransitionType.ShoulderTurning:
                    {
                        float D = shoulderTurning.D;
                        float L = shoulderTurning.L;
                        float Dpiece = shoulderTurning.Dpiece;
                        float U = shoulderTurning.U;
                        float F = shoulderTurning.F;
                        float h = shoulderTurning.h;
                        float R = shoulderTurning.R;
                        float S = shoulderTurning.S;
                        float X = shoulderTurning.X;
                        float Z = shoulderTurning.Z;
                        float B = shoulderTurning.B;
                        int ToolNumber = shoulderTurning.ToolNumber;
                        int ToolDepartureNumber = shoulderTurning.ToolDepartureNumber;
                        bool MachinePause = shoulderTurning.MachinePause;

                        //Dpiece = D + 2*U + 2*ost + 2*n*h
                        int n = (int)((Dpiece - D - 2*U) / (2*h));
                        float ost = (Dpiece - D - 2 * U) - (2 * n * h);

                        if (MachinePause) gcode.AddFrame(gcode.StopWithContinuationIfNecessary());
                        gcode.AddFrame(gcode.SetTheTool(ToolNumber, ToolDepartureNumber));
                        gcode.AddFrame(gcode.SetTheRotationClockwise(S) + "\n");

                        for (int i = 1; i <= n; i++)
                        {
                            gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * i, Z - B));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(0, -(L + Z), F));
                            gcode.AddFrame(gcode.Move(R, 0, F));
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * i + 2 * X, Z - B) + "\n" 
                                + ((ost > 0.00001) ? "" : "\n"));
                        }
                        if (ost > 0.00001)
                        {
                            gcode.AddFrame(gcode.FastMove(D + 2 * U, Z - B));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(0, -(L + Z), F));
                            gcode.AddFrame(gcode.Move(R, 0, F));
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(D + 2 * U + 2 * X, Z - B) + "\n\n");
                        }
                        return true;
                    }
                case TransitionType.Facing:
                    {
                        float D = facing.D;
                        float L = facing.L;
                        float Dpiece = facing.Dpiece;
                        float Lpiece = facing.Lpiece;
                        float U = facing.U;
                        float W = facing.W;
                        float F = facing.F;
                        float h = facing.h;
                        float R = facing.R;
                        float S = facing.S;
                        float X = facing.X;
                        float Z = facing.Z;
                        float B = facing.B;
                        int ToolNumber = facing.ToolNumber;
                        int ToolDepartureNumber = facing.ToolDepartureNumber;
                        bool MachinePause = facing.MachinePause;

                        //Lpiece = L + W + ost + n*h + B
                        int n = (int)((Lpiece - L - W - B) / h);
                        float ost = Lpiece - L - W - B - (n * h);

                        //Dpiece = D + 2*U

                        if(MachinePause) gcode.AddFrame(gcode.StopWithContinuationIfNecessary());
                        gcode.AddFrame(gcode.SetTheTool(ToolNumber, ToolDepartureNumber));
                        gcode.AddFrame(gcode.SetTheRotationClockwise(S) + "\n");

                        for (int i = 1; i <= n; i++)
                        {
                            gcode.AddFrame(gcode.FastMove(Dpiece + 2 * X, -B - i * h));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(-(Dpiece + 2 * X - D - 2 * U), 0, F));
                            gcode.AddFrame(gcode.Move(0, R, F));
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(Dpiece + 2 * X, -B - i * h + Z) + "\n"
                                 + ((ost > 0.00001) ? "" : "\n"));
                        }
                        if (ost > 0.00001)
                        {
                            gcode.AddFrame(gcode.FastMove(Dpiece + 2 * X, -B - n * h - ost));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(-(Dpiece + 2 * X - D - 2 * U), 0, F));
                            gcode.AddFrame(gcode.Move(0, R, F));
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(Dpiece + 2 * X, -B - n * h + Z) + "\n\n");
                        }
                        return true;
                    }
                default:
                    return false;
            }
        }

    }
    
}
