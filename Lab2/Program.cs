using System;
using System.Numerics;


namespace Lab_2
{
    class Program
    {

        private static float circumference;
        private static float area;
        private static float volume;

        static void Main(string[] args)
        {
            //Create random shapes to the shape array
            Shape[] shape = Shape.GenerateShape();
            Shape[] shape2 = Shape.GenerateShape(new Vector3(4,5,6));

            generateShapes(shape);
            Console.WriteLine("------------------------------------------------");        

            generateShapes(shape2);
        }

        static public void generateShapes(Shape[] shape)
        {
            foreach (var i in shape)
            {
                if (i.GetType() == typeof(Triangle))
                {
                    Triangle((Triangle)i);
                }
                else if (i.GetType() == typeof(Sphere) || (i.GetType() == typeof(Cuboid)))
                {
                    ShapeIs3D((Shape3D)i);
                }
                i.ToString();
                area += i.Area;
            }
            area /= 20.0f;

            Console.WriteLine("\nThis is the average area for all the shapes: {0:0.0}", area);
            Console.WriteLine("This is the curcumference of all the triangles : {0:0.0}", circumference);
            Console.WriteLine("This is the highest volume of all the 3DShapes : {0:0.0}", volume);
        }

        /// <summary>
        /// Will add the circumference from all the triangles to one variable 
        /// </summary>
        /// <param name="i"></param>
        private static void Triangle(Triangle i)
        {
            circumference += i.Circumference;
        }
        /// <summary>
        /// Will check if the volume of the 3DShape is bigger than
        /// the old one, if so replace it in the "volume" variable.
        /// </summary>
        /// <param name="i"></param>
        private static void ShapeIs3D(Shape3D i)
        {
            if (i.GetVolume > volume)
            {
                volume = i.GetVolume;
            }
        }

    }
}
