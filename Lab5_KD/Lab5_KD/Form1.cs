using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_KD
{
    public partial class Form1 : Form
    {
        // arraylist to hold graphics objects 
        private List<MyGraphic> graphicObjects = new List<MyGraphic>();

        // This flag will keep track of if this is the users's first click his second
        private bool firstClick = false;

        // These keep track of what options have been selected
        private string currDraw;
        private Pen currPen = Pens.White;
        private string currText = "";
        private Brush currBrush = Brushes.White;
        private int currPenWidth = 1;

        // The two points that determine the position of the object
        private Point pointA, pointB;

        public Form1()
        {
            InitializeComponent();
            drawPanel.Refresh();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            // Graphics object g
            Graphics g = e.Graphics;

            // Draw each graphics element
            foreach (MyGraphic graphicObjects in this.graphicObjects)
            {
                graphicObjects.Draw(g);
            }

        }

        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // Second Click processes, happens if firstClick is true
            if (firstClick) 
            {
                firstClick = false; // reset first click for next object
                pointB = new Point(e.X, e.Y);

                // update pen according to settings
                currPen = new Pen(currBrush, currPenWidth);

                // Add object based on draw option
                if (currDraw == "Line")
                {
                    // add to arraylist to be drawn
                    this.graphicObjects.Add(new Line(currPen, pointA, pointB));
                }
                else if (currDraw == "Rectangle")
                {
                    int objwidth = (pointA.X - pointA.X);
                    int objheight = (pointB.Y - pointB.X);
                    Point correctedPoint;
                    // if width is neg, flip x of pointB with x or pointA = correctedPoint
                    if (objwidth < 0)
                    {
                        correctedPoint.X = pointB.X;
                        correctedPoint.Y = pointA.Y;
                    }
                    // if height is neg, flip y of pointB with y or pointA = correctedPoint
                    else if (objheight < 0)
                    {
                        correctedPoint.X = pointA.X;
                        correctedPoint.Y = pointB.Y;
                    }
                    else
                    {
                        correctedPoint = pointA;
                    }
                    // get size of rec based on opposite corners of clicks
                    // add to arraylist to be drawn
                    this.graphicObjects.Add(new Rectangle(currPen, correctedPoint, Math.Abs(objwidth), Math.Abs(objheight)));
                }
                else if (currDraw == "Ellipse")
                {
                    int objwidth = (pointA.X - pointA.X);
                    int objheight = (pointB.Y - pointB.X);
                    // get size of ellipse based on opposite corners of clicks
                    // add to arraylist to be drawn
                    // if either height or width is negative, flip points a and b

                    this.graphicObjects.Add(new Ellipse(currPen, pointA, Math.Abs(pointB.X - pointA.X), Math.Abs(pointB.Y - pointA.Y)));

                }
                else if (currDraw == "Text")
                {
                    // add to arraylist to be drawn
                    this.graphicObjects.Add(new Text(currText, currBrush, pointA));
                }
                else
                {
                    // if no options selected, then skip
                    this.Invalidate();
                }

                this.Invalidate();
            }
            // if this is the first click, record for start pointA, set firstClick to true to draw
            else
            {
                pointA = new Point(e.X, e.Y);
                firstClick = true;
                this.Invalidate();
            }

            drawPanel.Refresh();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            // This is the event handler for all radio buttons in the group
            if (lineButton.Checked) currDraw = "Line";
            if (recButton.Checked) currDraw = "Rectangle";
            if (ellipseButton.Checked) currDraw = "Ellipse";
            if (textButton.Checked) currDraw = "Text";

            this.Invalidate();
        }

        private void penColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update brush color.
            //Black
            if (penColorList.SelectedIndex == 0)
            {
                currBrush = Brushes.Black;
            }
            // Red
            else if (penColorList.SelectedIndex == 0)
            {
                currBrush = Brushes.Red;
            }
            // Blue
            else if (penColorList.SelectedIndex == 0)
            {
                currBrush = Brushes.Blue;
            }
            // Green
            else if (penColorList.SelectedIndex == 0)
            {
                currBrush = Brushes.Green;
            }
            else
            {
                currBrush = Brushes.Black;
            }
            this.Invalidate();
        }

        private void penWidthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // width is equal to the index +1 since it start at index 0
            currPenWidth = penWidthList.SelectedIndex + 1;
            this.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            currText = richTextBox1.Text;
            this.Invalidate();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicObjects.Clear();
            drawPanel.Invalidate();
            this.Invalidate();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (graphicObjects.Count > 0)
            {
                graphicObjects.RemoveAt(graphicObjects.Count - 1);
            }
        }
    }
}
