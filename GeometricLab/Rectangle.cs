using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab_2
{
    public class Rectangle : Shape2D
    {
        private Vector2 center;
        private Vector2 size; //X == Wide, Y = Height
        private Boolean IsSquare;

        /// <summary>
        /// Constructor that takes one Vector2(x/y) as the center of the square,
        /// takes one float as the size of the square.
        /// </summary>
        /// <param name="center">The center of the square</param>
        /// <param name="size">The size of the square</param>
        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = new Vector2(center.X, center.Y);
            this.size = new Vector2(center.X, center.Y);
            
            checkSize();
        }
        /// <summary>
        /// Constructor that takes one Vector2(x/y) as the center of the square,
        /// takes one float as the size of the square.
        /// </summary>
        /// <param name="center">The center of the square</param>
        /// <param name="size">The size of the square</param>
        public Rectangle(Vector2 center, float size)
        {
            this.center = new Vector2(center.X, center.Y);
            this.size = new Vector2(size, size);
            checkSize();
        }
        /// <summary>
        /// Will check if the shape is a Square or an Rectangle.
        /// </summary>
        public void checkSize()
        {
            IsSquare = (size.X == size.Y);
        }

        /// <summary>
        /// Will calculate the circumference of the shape and return it as float
        /// </summary>
        public override float Circumference => (size.X * 2 + size.Y * 2);


        /// <summary>
        /// Will return the center of the shape as a Vector3(x,y,z)
        /// and set the x,y to their current value and set z to zero.
        /// </summary>
        public override Vector3 Center => new Vector3(center.X, center.Y, 0.0f);

        /// <summary>
        /// Will return the area of the shape
        /// </summary>
        public override float Area => (size.X * size.Y);

        /// <summary>
        /// Will convert all the information into a text
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (IsSquare)
            {
                Console.WriteLine("Square @({0}, {1}): w = {2}, h = {3}",center.X,center.Y,size.X,size.Y);
            }
            else Console.WriteLine("rectangle @({0}, {1}): w = {2}, h = {3}", center.X, center.Y, size.X, size.Y);
            
            return "";
        }
    }
}