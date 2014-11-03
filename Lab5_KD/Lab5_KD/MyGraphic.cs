﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Lab5_KD
{
    class MyGraphic
    {
        // Parent class for every graphic object (public so it can be inherited)
        public Point position = new Point();
        public Color fillColor;
        public Pen myPen;

        public MyGraphic()
        {

        }
        // this will depend on which 'child' of MyGraphic the users selects, rectangle, line, etc
        public virtual void Draw(Graphics g)
        {

        }
    }

    class Line : MyGraphic
    {
        public Point pointA, pointB;

        public Line(Pen penIn, Point currA, Point currB)
        {
            this.pointA = currA;
            this.pointB = currB;
            this.myPen = penIn;
        }
        // override parent draw class with one specific to Line object
        public override void Draw(Graphics g)
        {
            g.DrawLine(myPen, pointA, pointB);    
        }
    }

    class Rectangle : MyGraphic
    {
         public int width, height;

        public Rectangle(Pen penIn, Point currPos, int currWidth, int currHeight)
        {
            this.width = currWidth;
            this.height = currHeight;
            this.myPen = penIn;
            this.position = currPos;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(myPen, position.X, position.Y, width, height);
        }
    }
    class Ellipse : MyGraphic
    {
        public int width, height;

        public Ellipse(Pen penIn, Point currPos, int currWidth, int currHeight)
        {
            this.position = currPos;
            this.myPen = penIn; 
            this.width = currWidth;
            this.height = currHeight;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(myPen, position.X, position.Y, width, height);
        }
    }

    class Text : MyGraphic
    {
        public string text;
        public Brush bColor;

        public Text(string currText, Brush currBrush, Point currPos)
        {
            this.text = currText;
            this.bColor = currBrush;
            this.position = currPos;
        }

        public override void Draw(Graphics g)
        {
            //default Font
            Font font = new Font("Arial", 12, FontStyle.Regular);

            g.DrawString(text, font, bColor, position);
        }
    }
}