using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Code_Postprocessor
{
    /// <summary> Класс заготовки </summary>
    public class WorkPiece
    {
        /// <summary> Длина заготовки </summary>
        public float l;

        /// <summary> Вылет из кулачков </summary>
        public float z;
    }

    /// <summary> Класс заготовки круглого сечения </summary>
    public class CirclePiece : WorkPiece
    {
        /// <summary> Диаметр заготовки </summary>
        public float d;
        public void Init(float Z, float L, float D)
        {
            this.z = Z;
            this.l = L;
            this.d = D;
        }
    }
}
