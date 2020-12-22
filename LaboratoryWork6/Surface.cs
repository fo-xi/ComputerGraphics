using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LaboratoryWork6
{
    public class Surface
    {
        const int countPoint = 3; 

        public float[,] Points = new float[countPoint, 4];

        public float[] PlaneNormalVector = new float[4];

        public float[] DirectingVectorStraight = new float[4];

        public float PlaneNormalVectorLengt;

        public float DirectingVectorStraightLengt;

        //PlaneNormalVector = вектор нормали плоскости
        public void PlaneNormalVectorCalculate()
        {
            PlaneNormalVector[0] = 0;
            PlaneNormalVector[1] = 0;
            PlaneNormalVector[2] = 0;

            //x = 0
            //y = 1
            //z = 2
            for (var i = 0; i < countPoint - 1; i++)
            {
                PlaneNormalVector[0] += (Points[i, 1] - Points[i + 1, 1]) * (Points[i, 2] - Points[i + 1, 2]);
                PlaneNormalVector[1] += (Points[i, 2] - Points[i + 1, 2]) * (Points[i, 0] - Points[i + 1, 0]);
                PlaneNormalVector[2] += (Points[i, 0] - Points[i + 1, 0]) * (Points[i, 1] - Points[i + 1, 1]);
            }

            PlaneNormalVector[0] += (Points[countPoint - 1, 1] - Points[0, 1]) * (Points[countPoint - 1, 2] - Points[0, 2]);
            PlaneNormalVector[1] += (Points[countPoint - 1, 2] - Points[0, 2]) * (Points[countPoint - 1, 0] - Points[0, 0]);
            PlaneNormalVector[2] += (Points[countPoint - 1, 0] - Points[0, 0]) * (Points[countPoint - 1, 1] - Points[0, 1]);

            PlaneNormalVectorLengt = (float)Math.Sqrt(PlaneNormalVector[0] * PlaneNormalVector[0] + 
                                                      PlaneNormalVector[1] * PlaneNormalVector[1] + 
                                                      PlaneNormalVector[2] * PlaneNormalVector[2]);
        }

        //DirectingVectorStraight = направляющий вектор прямой
        public void DirectingVectorStraightCalculate(float a, float b)
        {
            //Из градусов в радианы
            var angleA = a * (float)Math.PI / 180;
            var angleB = b * (float)Math.PI / 180;

            DirectingVectorStraight[0] = (float)Math.Sin(angleA); ;
            DirectingVectorStraight[1] = (float)(-Math.Cos(angleA) * Math.Sin(angleB));
            DirectingVectorStraight[2] = 1;
            DirectingVectorStraight[3] = 1;

            DirectingVectorStraightLengt = (float)Math.Sqrt(DirectingVectorStraight[0] * DirectingVectorStraight[0] +
                                                            DirectingVectorStraight[1] * DirectingVectorStraight[1] +
                                                            DirectingVectorStraight[2] * DirectingVectorStraight[2]);
        }

        public float CalculateAngle(float a, float b)
        {
            PlaneNormalVectorCalculate();
            DirectingVectorStraightCalculate(a, b);

            float angle = (float)Math.Acos((PlaneNormalVector[0] * DirectingVectorStraight[0] +
                                            PlaneNormalVector[1] * DirectingVectorStraight[1] +
                                            PlaneNormalVector[2] * DirectingVectorStraight[2]) /
                                           (PlaneNormalVectorLengt * DirectingVectorStraightLengt));

            return angle;
        }
    }
}
