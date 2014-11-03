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

        // These flags will keep track if fill or outline are selected
        private bool willFill, willOutline = false;

        // These keep track of what options have been selected
        private string currDraw;
        private Pen currPen = Pens.White;
        private string currText = "";
        private Brush currBrush = Brushes.White;
        private Brush currFill = Brushes.White;
        private int currPenWidth = 1;

        // The two points that determine the position of the object
        private Point pointA, pointB;

        public Form1()
        {
            InitializeComponent();
            drawPanel.Refresh();
            penColorList.SetSelected(0, true);
            fillColorList.SetSelected(0, true);
            penWidthList.SetSelected(0, true);
            lineButton.Select();
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
            // update pen according to settings
            currPen = new Pen(currBrush, currPenWidth);

            // Second Click processes, happens if firstClick is true
            if (firstClick) 
            {
                firstClick = false; // reset first click for next object
                pointB = new Point(e.X, e.Y);


                // Add object based on draw option
                if (currDraw == "Line")
                {
                    // add to arraylist to be drawn
                    this.graphicObjects.Add(new Line(currPen, pointA, pointB));
                }
                else if (currDraw == "Rectangle")
                {
                    int rWidth = (pointB.X - pointA.X);
                    int rHeight = (pointB.Y - pointA.Y);
                    Point correctedPoint = pointA;
                    // if width is neg, flip x of pointB with x or pointA = correctedPoint
                    if (rWidth < 0)
                    {
                        correctedPoint.X = pointB.X;
                    }
                    // if height is neg, flip y of pointB with y or pointA = correctedPoint
                    if (rHeight < 0)
                    {
                        correctedPoint.Y = pointB.Y;
                    }

                    // get size of rec based on opposite corners of clicks
                    // add to arraylist to be drawn
                    this.graphicObjects.Add(new Rectangle(currPen, correctedPoint, Math.Abs(rWidth), Math.Abs(rHeight),willFill,willOutline,currFill));
                }
                else if (currDraw == "Ellipse")
                {
                    int eWidth = (pointB.X - pointA.X);
                    int eHeight = (pointB.Y - pointA.Y);
                    Point correctedPoint = pointA;
                    // if width is neg, flip x of pointB with x or pointA = correctedPoint
                    if (eWidth < 0)
                    {
                        correctedPoint.X = pointB.X;
                    }
                    // if height is neg, flip y of pointB with y or pointA = correctedPoint
                    if (eHeight < 0)
                    {
                        correctedPoint.Y = pointB.Y;
                    }


                    // get size of ellipse based on opposite corners of clicks
                    // add to arraylist to be drawn

                    this.graphicObjects.Add(new Ellipse(currPen, correctedPoint, Math.Abs(eWidth), Math.Abs(eHeight),willFill,willOutline,currFill));
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
            // Update outline color.
            //Black
            if (penColorList.SelectedIndex == 0)
            {
                currBrush = Brushes.Black;
            }
            // Red
            else if (penColorList.SelectedIndex == 1)
            {
                currBrush = Brushes.Red;
            }
            // Blue
            else if (penColorList.SelectedIndex == 2)
            {
                currBrush = Brushes.Blue;
            }
            // Green
            else if (penColorList.SelectedIndex == 3)
            {
                currBrush = Brushes.Green;
            }
            else
            {
                currBrush = Brushes.Black;
            }
            this.Invalidate();

        }

        private void fillColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update fill color.
            //White
            if (fillColorList.SelectedIndex == 0)
            {
                currFill = Brushes.White;
            }
            // Black
            else if (fillColorList.SelectedIndex == 1)
            {
                currFill = Brushes.Black;
            }
            // Red
            else if (fillColorList.SelectedIndex == 2)
            {
                currFill = Brushes.Red;
            }
            // Blue
            else if (fillColorList.SelectedIndex == 3)
            {
                currFill = Brushes.Blue;
            }
            // Green
            else if (fillColorList.SelectedIndex == 4)
            {
                currFill = Brushes.Green;
            }
            else
            {
                currFill = Brushes.White;
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
            drawPanel.Refresh();
        }

        private void fillBox_CheckedChanged(object sender, EventArgs e)
        {
            willFill = !willFill;
            this.Invalidate();
        }

        private void outlineBox_CheckedChanged(object sender, EventArgs e)
        {
            willOutline = !willOutline;
            this.Invalidate();
        }


    }
}
