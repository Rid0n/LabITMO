using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
namespace Lab1
{
    class Triangle
    {
        private double[][] vertices = new double[3][];
        public Triangle(double[] vertex1, double[] vertex2, double[] vertex3)
        {
            vertices[0] = vertex1;
            vertices[1] = vertex2;
            vertices[2] = vertex3;
        }
        public void offsetOnePoint(int index,double value)
        {
            vertices[index][0] += value;
            vertices[index][1] += value;
        }
        public void offset(double value)
        {
            foreach (double[] item in vertices)
            {
                item[0] += value;
                item[1] += value;
            }
        }
        public void rotate(double angle)
        {
            foreach (var item in vertices)
            {
                item[0] = item[0] * Cos(angle) + item[1] * Sin(angle);
                item[1] = -item[0] * Sin(angle) + item[1] * Cos(angle);
            }
        }
        public double calcSideLength(int index1,int index2)
        {
            return Sqrt(Pow(vertices[index1][0] - vertices[index2][0], 2) + Pow(vertices[index1][1] - vertices[index2][1], 2));
        }
        public string getVertex(int index)
        {
            return vertices[index][0].ToString() + ", " + vertices[index][1].ToString();
        }
        public void setVertex(int index,double[] vertex)
        {
            vertices[index] = vertex;
        }
    }
}
