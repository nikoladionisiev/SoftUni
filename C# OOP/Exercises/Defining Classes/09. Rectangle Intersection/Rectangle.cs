﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Rectangle_Intersection
{
    class Rectangle
    {
        // It should consist of an id, width, height and the coordinates of its top left corner (horizontal and vertical).
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        internal bool Intersect(Rectangle secondRectangle)
        {
            if (this.X + this.Width < secondRectangle.X ||
                secondRectangle.X + secondRectangle.Width < this.X ||
                this.Y + this.Height < secondRectangle.Y ||
                secondRectangle.Y + secondRectangle.Height < this.Y)
            {
                return false;
            }
            return true;
        }
    }
}
