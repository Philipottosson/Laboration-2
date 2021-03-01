using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Circle : Shape2D
    {
        public const double PI = 3.1415926535897931;
        private Vector2 center;
        private float radius;
        
        /// <summary>
        /// Constructor that takes one Vector2(x,y) as the center fo the circle
        /// and one float as radius.
        /// </summary>
        /// <param name="center">Center</param>
        /// <param name="radius">Radius</param>
        public Circle(Vector2 center, float radius)
        {
            this.center = new Vector2(center.X *1.0f, center.Y * 1.0f);
            this.radius = radius;
        }

        /// <summary>
        /// Will calculate the circumference of the shape and return it as float
        /// </summary>
        public override float Circumference 
        {
            get { return (float)((PI *2)* radius); }
        }
        /// <summary>
        /// Will return the area of the shape
        /// </summary>
        public override float Area => (float)(PI * (radius * 2));

        /// <summary>
        /// Will return the center of the shape as a Vector3(x,y,z)
        /// and set the x,y to their current value and set z to zero.
        /// </summary>
        public override Vector3 Center => throw new NotImplementedException();


        /// <summary>
        /// Will convert all the information into a text
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Console.WriteLine("circle @({0}, {1}): r = {2}", center.X, center.Y, radius);
            return "";
        }
    }
}
