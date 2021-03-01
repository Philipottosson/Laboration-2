using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Sphere : Shape3D
    {
        public const double PI = 3.1415926535897931;
        private Vector3 center;
        private float radius;

        /// <summary>
        /// Constructor that takes one Vector 3(x,y,z)as the center of the sphere
        /// and one float as the radius.
        /// </summary>
        /// <param name="center">Center</param>
        /// <param name="radius">Radius</param>
        public Sphere(Vector3 center, float radius)
        {
            this.center = new Vector3(center.X,center.Y,center.Z);
            this.radius = radius;
        }

        /// <summary>
        /// Will return the center of the shape as a Vector3(x,y,z)
        /// and set the x,y and z to their current value.
        /// </summary>
        public override Vector3 Center => center;

        /// <summary>
        /// Will return the area of the shape.
        /// </summary>
        public override float Area => (float)(4*PI *(radius*radius)); //4πr^2

        /// <summary>
        /// Will calculate and return the volume of the shape.
        /// </summary>
        public override float GetVolume => (float)((4 / 3) * PI * (radius * radius * radius)); //(4/3) × π × r
        
        /// <summary>
        /// Will convert all the information into a text.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Console.WriteLine("sphere @({0}, {1}, {2}): r = {3}",center.X,center.Y,center.Z, radius);
            return "";
        }
    }
}
