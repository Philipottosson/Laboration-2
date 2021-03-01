using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Cuboid : Shape3D
    {
        private Vector3 center = new Vector3();
        private Vector3 size;
        private Boolean IsCube;

        /// <summary>
        /// Constructor that take two Vector3 (x,y,z) as the center, and the size of the cuboid.
        /// if the size(x,y,z) is the same it will make it a cube.
        /// </summary>
        /// <param name="center">The center of the cuboid/cube</param>
        /// <param name="size">The size of the cuboid/cube</param>
        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = new Vector3(size.X, size.Y, size.Z);
            if (size.Z == size.Y && size.X == size.Y)
            {
                IsCube = true;
            }
            else IsCube = false;
        }

        /// <summary>
        /// Constructor that take one Vector3 (x,y,z) as the center, and one float as size
        /// the size will have the same value and it makes it a cube.
        /// </summary>
        /// <param name="center">The center of the cube</param>
        /// <param name="size">The size of the cube</param>
        public Cuboid(Vector3 center, float size)
        {
            this.center = center;
            this.size = new Vector3(size, size, size);
            IsCube = true;
        }

        /// <summary>
        /// Will return the center of the shape as a Vector3(x,y,z)
        /// and set the x,y and z to their current value.
        /// </summary>
        public override Vector3 Center 
        {
            get 
            {
                return center;
            }
        }

        /// <summary>
        /// Will return the area of the shape
        /// </summary>
        public override float Area => ((size.X * size.Y) * 2 + (size.Z * size.X) * 2 + (size.Y * size.Z) * 2);

        /// <summary>
        /// Will calculate and return the volume of the shape.
        /// </summary>
        public override float GetVolume => size.X * size.Y * size.Z;


        /// <summary>
        /// Will convert all the information into a text
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            if (IsCube)
            {
                Console.WriteLine("cube @({0},{1},{2}): w = {3}, h = {4}, l = {5}",center.X,center.Y,center.Z,size.X,size.Y,size.Z);
            }
            else Console.WriteLine("cuboid @({0},{1},{2}): w = {3}, h = {4}, l = {5}", center.X, center.Y, center.Z, size.X, size.Y, size.Z);
            return "";
        }
    }
}
