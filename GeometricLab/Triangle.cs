using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_2
{
    public class Triangle : Shape2D
    {
        private Vector2 point1;
        private Vector2 point2;
        private Vector2 point3;

        private Vector2 center;
        private float area;
        private float pointAToB;
        private float pointAToC;
        private float pointBToC;

        public Triangle()
        {
        }
        /// <summary>
        /// Constructor that takes three Vector2(x,y) that forms a Triangle 
        /// </summary>
        /// <param name="p0">This is point A</param>
        /// <param name="p1">This is point B</param>
        /// <param name="p2">This is point C</param>
        public Triangle(Vector2 p0, Vector2 p1, Vector2 p2)
        {
            point1 = new Vector2(p0.X, p0.Y);
            point2 = new Vector2(p1.X, p1.Y);
            point3 = new Vector2(p2.X, p2.Y); 

            CalcTriangle();
            center = new Vector2((point1.X + point2.X + point3.X) / 3.0f,(point1.Y + point2.Y + point3.Y) / 3.0f);
            // Heron's formula
            // area = 0.25 * √( (a->b + a->c + b->c) * (-a->b + a->c + b->c) * (a->b - a->c + b->c) * (a->b + a->c - b->c) )
            area = (float)Math.Sqrt((pointAToB + pointAToC + pointBToC) * (-pointAToB + pointAToC + pointBToC)
                * (pointAToB - pointAToC + pointBToC) * (pointAToB + pointAToC - pointBToC));
            area = (float)(area * 0.25);

        }
       
        /// <summary>
        /// Will calculate the circumference of the triangle and return it as float
        /// </summary>
        public override float Circumference => (pointAToB + pointAToC + pointBToC);

        /// <summary>
        /// Will return the center of the triangle as a Vector3(x,y,z)
        /// and set the x,y to their current value and set z to zero.
        /// </summary>
        public override Vector3 Center => new Vector3 (center.X,center.Y,0.0f);

        /// <summary>
        /// Will return the triangles area
        /// </summary>
        public override float Area => area;
        
        /// <summary>
        /// Will convert all the information into a text
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Console.WriteLine("Triangle @({0}, {1}): p1({2}, {3}), p2({4}, {5}), p3({6}, {7})",
                center.X, center.Y, point1.X, point1.Y, point2.X, point2.Y, point3.X, point3.Y);
            
            return "";
        }
        /// <summary>
        /// Will calculate all the points from A->B etc.
        /// </summary>
        private void CalcTriangle()
        {

            pointAToB = (float)Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X)
                + (point2.Y - point1.Y) * (point2.Y - point1.Y));

            pointAToC = (float)Math.Sqrt((point1.X - point3.X) * (point1.X - point3.X)
                + (point3.Y - point1.Y) * (point3.Y - point1.Y));

            pointBToC = (float)Math.Sqrt((point2.X - point3.X) * (point2.X - point3.X)
                + (point3.Y - point2.Y) * (point3.Y - point2.Y));

        }
    }
}
