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
        /// <summary> Снять заготовку</summary>
        Uninstall = 3
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
                        gcode.AddFrame(gcode.FastMove(X, Z));//ноль на торце заготовки
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
                        int ToolNumber = shoulderTurning.ToolNumber;
                        int ToolDepartureNumber = shoulderTurning.ToolDepartureNumber;

                        //Dpiece = D + 2*U + 2*ost + 2*n*h
                        int n = (int)((Dpiece - D - 2*U) / (2*h));
                        float ost = (Dpiece - D - 2 * U) - (2 * n * h);
                        float p = 0.5f; //Величина подхода

                        gcode.AddFrame(gcode.SetTheTool(ToolNumber, ToolDepartureNumber));
                        gcode.AddFrame(gcode.SetTheRotationClockwise(S) + "\n");

                        for (int i = 1; i <= n; i++)
                        {
                            gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * i, p));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(0, -(L + p), F));
                            gcode.AddFrame(gcode.FastMove(R, 0));
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * i + p, p) + "\n" + ((ost > 0.00001) ? "" : "\n"));
                        }
                        if (ost > 0.00001)
                        {
                            gcode.AddFrame(gcode.FastMove(D + 2 * U, p));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(0, -(L + p), F));
                            gcode.AddFrame(gcode.FastMove(R, 0));
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(D + 2 * U + p, p) + "\n\n");
                        }
                        /*
                        for (int i = 0; i < n; i++)
                        {
                            gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * (i + 1), 0.5f));
                            gcode.AddFrame(gcode.SetRelativeCoords());
                            gcode.AddFrame(gcode.Move(0f, -L - 0.5f, F));  // <--
                            gcode.AddFrame(gcode.FastMove(2 * R, 0));   // ^^^
                            //gcode.AddFrame(gcode.FastMove(0f, L + 0.5f));  // -->
                            gcode.AddFrame(gcode.SetAbsoluteCoords());
                            gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * (i + 1) + 0.5f, 0.5f));  // -->
                        }
                        gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * n - ost, 0.5f));
                        gcode.AddFrame(gcode.SetRelativeCoords());
                        gcode.AddFrame(gcode.Move(0f, -L - 0.5f, F));  // <--
                        gcode.AddFrame(gcode.FastMove(2 * R, 0));   // ^^^
                        gcode.AddFrame(gcode.SetAbsoluteCoords());
                        gcode.AddFrame(gcode.FastMove(Dpiece - 2 * h * n + 0.5f, 0.5f));*/
                        return true;
                    }
                default:
                    return false;
            }
        }

    }
    
}
