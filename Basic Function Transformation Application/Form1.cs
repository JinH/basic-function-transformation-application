using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //Programmed by Hao.J and Ben.S
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Initial label settings
            lblParentAnswer.Text = "No Function Selected";
            lblDomainAnswer.Text = "No Function Selected";
            lblRangeAnswer.Text = "No Function Selected";
            RBLinear.Checked = true; 
        }

        //Classes are declared
        Function myFunction = new Function(); 
        Linear myLinear = new Linear();
        Quadratic myParabola = new Quadratic();
        Absolute myAbsolute = new Absolute();
        Root myRoot = new Root();
        Cubic myCubic = new Cubic();
        Sine mySine = new Sine();
        Cosine myCosine = new Cosine();

        public class Function
        {
            //Public integer variables are declared 
            protected int a;
            protected int k;
            protected int d;
            protected int c;
            protected int Xmax;
            protected int Xmin;
            protected int Ymax;
            protected int Ymin;
            protected double Xres;
            protected double Yres;

            //Pixel and Coordinate arrays are declared
            protected PointF[] BasicPixel = new PointF[400];
            protected PointF[] TransformedPixel = new PointF[400];
            protected PointF[] BasicCoord = new PointF[400];
            protected PointF[] TransformedCoord = new PointF[400];
            
            //Basic and transformation colors are declared 
            protected Color BasicClr;
            protected Color TransformClr;

            public void Setscale()
            {
                Xres = (double)(400) / (double)(Xmax - Xmin);
                Yres = (double)(400) / (double)(Ymax - Ymin);
            }

            public Function()
            {
                //Default values are assigned 
                a = 1;
                k = 1;
                d = 0;
                c = 0;
                Xmax = 5;
                Xmin = -5;
                Ymax = 5;
                Ymin = -5;
                BasicClr = Color.Gray;
                TransformClr = Color.Red;
            }

            public Function(int avalue, int kvalue, int dvalue, int cvalue, int Xmaxvalue, int Xminvalue, int Ymaxvalue, int Yminvalue)
            {
                //left side variables are saved as inputs from the user
                a = avalue;
                k = kvalue;
                d = dvalue;
                c = cvalue;
                Xmax = Xmaxvalue;
                Xmin = Xminvalue;
                Ymax = Ymaxvalue;
                Ymin = Yminvalue;
                BasicClr = Color.LightGray;
                TransformClr = Color.Red;
            }

            //Generates Grid Lines 
            public void DrawGridLines(Graphics g)
            {

                //Color of pen and size of pen is specified 
                Pen myGridPen = new Pen(Color.Gray, 1);
                Pen myAxisPen = new Pen(Color.Black, 2);

                int y = Ymin; 

                
             
                //Horizontal Lines 
                for (y = Ymin; y < Ymax; y++)
                {
                    //if y=0
                    if (y== 0)
                    {
                        //xaxis is drawn
                        g.DrawLine(myAxisPen, 0, (int)((Ymax - y) * Yres), 400, (int)((Ymax - y) * Yres)); 
                    }

                    //Lines are drawn
                    g.DrawLine(myGridPen, 0, (int)((Ymax - y) * Yres), 400, (int)((Ymax - y) * Yres));
                    

                }

                //Vertical Lines 
                for (int x = Xmin; x < Xmax; x++)
                {
                    //if x=0
                    if (x == 0)
                    {
                        //yaxis is drawn
                        g.DrawLine(myAxisPen, (int)((Xmin*-1) * Xres), 0, (int)((Xmin*-1) * Xres), 400 );
                    }
                    //Lines are drawn
                    g.DrawLine(myGridPen, (int)((Xmax - x) * Xres), 0, (int)((Xmax - x) * Xres), 400);
                }
            }

            
            //getters and setters of parameters
            public int geta()
            {
                return a;
            }

            public int seta(int A)
            {
                a = A;
                return a;
            }
            public int getk()
            {
                return k;
            }

            public int setk(int K)
            {
                k = K;
                return k;
            }

            public int getd()
            {
                return d;
            }

            public int setd(int D)
            {
                d = D;
                return d;
            }
            public int getc()
            {
                return c;
            }

            public int setc(int C)
            {
                c = C;
                return c;
            }

            //getter for the color of the function
            public Color SetColor(Color Shade)
            {
                TransformClr = Shade;
                return TransformClr;
            }

            //getter and setter for cartesian plane boundaries
            public int getXmax()
            {
                return Xmax;
            }

            public int setXmax(int Xmaxsetter)
            {
                Xmax = Xmaxsetter;
                return Xmax;
            }

            public int getXmin()
            {
                return Xmin;
            }

            public int setXmin(int Xminsetter)
            {
                Xmin = Xminsetter;
                return Xmin;
            }

            public int getYmax()
            {
                return Ymax;
            }
            public int setYmax(int Ymaxsetter)
            {
                Ymax = Ymaxsetter;
                return Ymax;
            }

            public int getYmin()
            {
                return Ymin;
            }
            public int setYmin(int Yminsetter)
            {
                Ymin = Yminsetter;
                return Ymin;
            }

            public Color setBasicClr(Color BasicColorGetter)
            {
                BasicClr = BasicColorGetter;
                return BasicClr;
            }

            public void transform()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }

            public void draw(Graphics g)
            {
                //Pens are declared
                Pen mypenBasic = new Pen(BasicClr);
                Pen mypenTransform = new Pen(TransformClr);

                //The parent function is drawn
                for (int i = 0; i < 400; i++)
                {
                    BasicPixel[i].X = (BasicCoord[i].X - Xmin) * (float)(Xres);
                    BasicPixel[i].Y = (Ymax - BasicCoord[i].Y) * (float)(Yres);
                }

                //The transformed function is drawn
                for (int i = 0; i < 400; i++)
                {
                    TransformedPixel[i].X = (TransformedCoord[i].X - Xmin) * (float)(Xres);
                    TransformedPixel[i].Y = (Ymax - TransformedCoord[i].Y) * (float)(Yres);
                }
                
                //Basic function is drawn
                g.DrawLines(mypenBasic, BasicPixel);
                //Transformed function is drawn
                g.DrawLines(mypenTransform, TransformedPixel);
            }
        }

        public class Linear : Function
        {
            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    BasicCoord[i].Y = BasicCoord[i].X;
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }

        }

        public class Quadratic : Function
        {

            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    BasicCoord[i].Y = (float)Math.Pow(BasicCoord[i].X, 2);
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {


                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }
        }

        public class Absolute : Function
        {

            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    BasicCoord[i].Y = (float)Math.Abs(BasicCoord[i].X);
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }
        }

        public class Root : Function
        {

            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    if (BasicCoord[i].X >= 0)
                    {
                        BasicCoord[i].Y = (float)Math.Sqrt(BasicCoord[i].X);
                    }
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    if (TransformedCoord[i].X >= 0)
                    {
                        TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                    }
                }
            }
        }

        public class Cubic : Function
        {
            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    BasicCoord[i].Y = (float)Math.Pow(BasicCoord[i].X, 3);
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }
        }

        public class Sine : Function
        {

            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    BasicCoord[i].Y = (float)Math.Sin(BasicCoord[i].X);
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }
        }

        //Table of Values for transformed function
        public class Cosine : Function
        {
            //Table of values for basic function
            public void MakeTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    BasicCoord[i].X = ((float)(i) / (float)(Xres)) + Xmin;
                    BasicCoord[i].Y = (float)Math.Cos(BasicCoord[i].X);
                }
            }

            //Table of Values for transformed function
            public void TransformedTOV()
            {
                for (int i = 0; i < 400; i++)
                {
                    TransformedCoord[i].X = (BasicCoord[i].X / k) + d;
                    TransformedCoord[i].Y = (BasicCoord[i].Y * a) + c;
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                Color c = Color.Black;

                //If all or any of the scale parameters are zero 
                if (((int)NUDXmax.Value == 0) || ((int)NUDXmin.Value == 0) || ((int)NUDYmax.Value == 0) || ((int)NUDYmin.Value == 0))
                {
                    //Messagebox is displayed
                    MessageBox.Show("The scale parameters set is invalid. Please refine scale parameters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //If none of the functions are selected 
                if ((RBLinear.Checked == false) && (RBQuadratic.Checked == false) && (RBAbsolute.Checked == false) && (RBRoot.Checked == false) && (RBCubic.Checked == false) && (RBSine.Checked == false) && (RBCosine.Checked == false))
                {
                    //Messagebox is displayed 
                    MessageBox.Show("Please specify a function to be displayed.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //If the "A" parameter is set to zero 
                if ((int)NUDa.Value == 0)
                {
                    //Messagebox appears
                    MessageBox.Show("The A parameter set cannot equal to zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //If the "K" parameter is set to zero 
                else if ((int)NUDk.Value == 0)
                {
                    //Messagebox appears
                    MessageBox.Show("The K parameter set cannot equal to zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Color Dialog is displayed to user 
                ColorDialog ClrDlg = new ColorDialog();

                if (ClrDlg.ShowDialog() == DialogResult.OK)
                {
                    //Color is set as BasicClr variable
                    c = ClrDlg.Color;

                }

                //if linear radio button is selected
                if (RBLinear.Checked == true)
                {
                    //Inputs are retrieved and set 
                    myLinear.setXmax((int)NUDXmax.Value);
                    myLinear.setXmin((int)NUDXmin.Value);
                    myLinear.setYmax((int)NUDYmax.Value);
                    myLinear.setYmin((int)NUDYmin.Value);

                    myLinear.seta((int)NUDa.Value);
                    myLinear.setc((int)NUDc.Value);
                    myLinear.setd((int)NUDd.Value);
                    myLinear.setk((int)NUDk.Value);

                    myLinear.SetColor(c);
                    myLinear.Setscale();
                    myLinear.MakeTOV();
                    myLinear.TransformedTOV();
                    myLinear.transform();

                    PBFunction.Invalidate();

                    //Properties of function is stated
                    lblParentAnswer.Text = "f(x) = x";
                    lblDomainAnswer.Text = "{xE|R}";
                    lblRangeAnswer.Text = "{yE|R}";
                }

                //if quadratic radiobutton is checked
                if (RBQuadratic.Checked == true)
                {
                    //myFunction.transform(myFunction.geta(),myFunction.getk(),myFunction.getd,myFunction.getc()); 
                    //Inputs are retrieved and set 
                    myParabola.setXmax((int)NUDXmax.Value);
                    myParabola.setXmin((int)NUDXmin.Value);
                    myParabola.setYmax((int)NUDYmax.Value);
                    myParabola.setYmin((int)NUDYmin.Value);

                    myParabola.seta((int)NUDa.Value);
                    myParabola.setc((int)NUDc.Value);
                    myParabola.setd((int)NUDd.Value);
                    myParabola.setk((int)NUDk.Value);

                    myParabola.SetColor(c);
                    myParabola.Setscale();
                    myParabola.MakeTOV();
                    myParabola.TransformedTOV();
                    myParabola.transform();

                    PBFunction.Invalidate();

                    //Function properties
                    lblParentAnswer.Text = "f(x) = x^2";
                    lblDomainAnswer.Text = "{xE|R}";

                    if ((int)NUDa.Value < 0)
                    {
                        lblRangeAnswer.Text = "{yE|R| y<=" + (int)NUDc.Value + "}";
                    }

                    else if ((int)NUDa.Value > 0)
                    {
                        lblRangeAnswer.Text = "{yE|R| y>=" + (int)NUDc.Value + "}";
                    }
                }

                //if absolute radiobutton is checked
                if (RBAbsolute.Checked == true)
                {
                    //Inputs are retrieved and set 
                    myAbsolute.setXmax((int)NUDXmax.Value);
                    myAbsolute.setXmin((int)NUDXmin.Value);
                    myAbsolute.setYmax((int)NUDYmax.Value);
                    myAbsolute.setYmin((int)NUDYmin.Value);

                    myAbsolute.seta((int)NUDa.Value);
                    myAbsolute.setc((int)NUDc.Value);
                    myAbsolute.setd((int)NUDd.Value);
                    myAbsolute.setk((int)NUDk.Value);

                    myAbsolute.SetColor(c);
                    myAbsolute.Setscale();
                    myAbsolute.MakeTOV();
                    myAbsolute.TransformedTOV();
                    myAbsolute.transform();
                    PBFunction.Invalidate();

                    //Function properties
                    lblParentAnswer.Text = "f(x) = |x|";
                    lblDomainAnswer.Text = "{xE|R}";

                    if ((int)NUDa.Value < 0)
                    {
                        lblRangeAnswer.Text = "{yE|R| y<=" + (int)NUDc.Value + "}";
                    }

                    else if ((int)NUDa.Value > 0)
                    {
                        lblRangeAnswer.Text = "{yE|R| y>=" + (int)NUDc.Value + "}";
                    }
                }

                //If root radio button is selected 
                if (RBRoot.Checked == true)
                {
                    //Inputs are retrieved and set 
                    myRoot.setXmax((int)NUDXmax.Value);
                    myRoot.setXmin((int)NUDXmin.Value);
                    myRoot.setYmax((int)NUDYmax.Value);
                    myRoot.setYmin((int)NUDYmin.Value);

                    myRoot.seta((int)NUDa.Value);
                    myRoot.setc((int)NUDc.Value);
                    myRoot.setd((int)NUDd.Value);
                    myRoot.setk((int)NUDk.Value);

                    myRoot.SetColor(c);
                    myRoot.Setscale();
                    myRoot.MakeTOV();
                    myRoot.TransformedTOV();
                    myRoot.transform();

                    PBFunction.Invalidate();

                    //Function properties
                    lblParentAnswer.Text = "f(x) = x^(1/2)";
                    if ((int)NUDk.Value < 0)
                    {
                        lblDomainAnswer.Text = "{xE|R| x<=" + (int)NUDd.Value + "}";
                    }

                    else if ((int)NUDk.Value > 0)
                    {
                        lblDomainAnswer.Text = "{xE|R| x>=" + (int)NUDd.Value + "}";
                    }

                    if ((int)NUDa.Value < 0)
                    {
                        lblRangeAnswer.Text = "{yE|R| y<=" + (int)NUDc.Value + "}";
                    }

                    else if ((int)NUDa.Value > 0)
                    {
                        lblRangeAnswer.Text = "{yE|R| y>=" + (int)NUDc.Value + "}";
                    }
                }


                //if cubic radiobutton  is checked
                if (RBCubic.Checked == true)
                {
                    //Inputs are retrieved and set 
                    myCubic.setXmax((int)NUDXmax.Value);
                    myCubic.setXmin((int)NUDXmin.Value);
                    myCubic.setYmax((int)NUDYmax.Value);
                    myCubic.setYmin((int)NUDYmin.Value);

                    myCubic.seta((int)NUDa.Value);
                    myCubic.setc((int)NUDc.Value);
                    myCubic.setd((int)NUDd.Value);
                    myCubic.setk((int)NUDk.Value);

                    myCubic.SetColor(c);
                    myCubic.Setscale();
                    myCubic.MakeTOV();
                    myCubic.TransformedTOV();
                    myCubic.transform();

                    PBFunction.Invalidate();

                    //function properties
                    lblParentAnswer.Text = "f(x) = x^3";
                    lblDomainAnswer.Text = "{xE|R}";
                    lblRangeAnswer.Text = "{yE|R}";
                }

                //if sine radio button is selected 
                if (RBSine.Checked == true)
                {
                    //Inputs are retrieved and set 
                    mySine.setXmax((int)NUDXmax.Value);
                    mySine.setXmin((int)NUDXmin.Value);
                    mySine.setYmax((int)NUDYmax.Value);
                    mySine.setYmin((int)NUDYmin.Value);

                    mySine.seta((int)NUDa.Value);
                    mySine.setc((int)NUDc.Value);
                    mySine.setd((int)NUDd.Value);
                    mySine.setk((int)NUDk.Value);

                    mySine.SetColor(c);
                    mySine.Setscale();
                    mySine.MakeTOV();
                    mySine.TransformedTOV();
                    mySine.transform();

                    PBFunction.Invalidate();

                    //Function properties
                    lblParentAnswer.Text = "f(x) = sin(x)";
                    lblDomainAnswer.Text = "{xE|R}";

                    if ((int)NUDa.Value > 0)
                        lblRangeAnswer.Text = "{yE|R| " + ((int)NUDa.Value + (int)NUDc.Value) + "<= y < =" + ((((int)NUDa.Value) * (-1)) + (int)NUDc.Value) + "}";

                    else if ((int)NUDa.Value < 0)
                        lblRangeAnswer.Text = "{yE|R| " + ((((int)NUDa.Value) * (-1)) + (int)NUDc.Value) + "<= y < =" + ((int)NUDa.Value + (int)NUDc.Value) + "}";


                }

                //if cosine radio button is selected
                if (RBCosine.Checked == true)
                {
                    //Inputs are retrieved and set 
                    myCosine.setXmax((int)NUDXmax.Value);
                    myCosine.setXmin((int)NUDXmin.Value);
                    myCosine.setYmax((int)NUDYmax.Value);
                    myCosine.setYmin((int)NUDYmin.Value);

                    myCosine.seta((int)NUDa.Value);
                    myCosine.setc((int)NUDc.Value);
                    myCosine.setd((int)NUDd.Value);
                    myCosine.setk((int)NUDk.Value);

                    myCosine.SetColor(c);
                    myCosine.Setscale();
                    myCosine.MakeTOV();
                    myCosine.TransformedTOV();
                    myCosine.transform();

                    PBFunction.Invalidate();

                    //Function properties
                    lblParentAnswer.Text = "f(x) = cos(x)";
                    lblDomainAnswer.Text = "{xE|R}";

                    if ((int)NUDa.Value > 0)
                        lblRangeAnswer.Text = "{yE|R| " + ((int)NUDa.Value + (int)NUDc.Value) + "<= y < =" + ((((int)NUDa.Value) * (-1)) + (int)NUDc.Value) + "}";

                    else if ((int)NUDa.Value < 0)
                        lblRangeAnswer.Text = "{yE|R| " + ((((int)NUDa.Value) * (-1)) + (int)NUDc.Value) + "<= y < =" + ((int)NUDa.Value + (int)NUDc.Value) + "}";
                }
            }
            catch
            {
            }
        }

        private void PBFunction_Paint(object sender, PaintEventArgs e)
        {
            //if linear function is selected
            if (RBLinear.Checked == true)
            {
                //grid lines are drawn
                myLinear.DrawGridLines(e.Graphics);
                //function is drawn
                myLinear.draw(e.Graphics);
            }

            //if quadratic function is selected
            if (RBQuadratic.Checked == true)
            {
                //grid lines are drawn
                myParabola.DrawGridLines(e.Graphics);
                //function is drawn
                myParabola.draw(e.Graphics);
            }

            //if absolute function is selected
            if (RBAbsolute.Checked == true)
            {
                //grid lines are drawn
                myAbsolute.DrawGridLines(e.Graphics);
                //function is drawn
                myAbsolute.draw(e.Graphics);
            }

            //if root function is selected
            if (RBRoot.Checked == true)
            {
                //grid lines are drawn
                myRoot.DrawGridLines(e.Graphics);
                //function is drawn
                myRoot.draw(e.Graphics);
            }

            // if cubic function is selected
            if (RBCubic.Checked == true)
            {
                //grid lines are drawn
                myCubic.DrawGridLines(e.Graphics);
                //function is drawn
                myCubic.draw(e.Graphics);
            }
            
            //if sine radio button is selected
            if (RBSine.Checked == true)
            {
                //grid lines are drawn
                mySine.DrawGridLines(e.Graphics);
                //function is drawn
                mySine.draw(e.Graphics);
            }

            //if cosine radio button is selected
            if (RBCosine.Checked == true)
            {
                //grid lines are drawn
                myCosine.DrawGridLines(e.Graphics);
                //function is drawn
                myCosine.draw(e.Graphics);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(PBFunction.Handle);
            
            //Background of PBFunction is cleared
            g.Clear(Color.White);

            //default values for cartesian plane
            NUDXmax.Value = 5;
            NUDXmin.Value = -5;
            NUDYmax.Value = 5;
            NUDYmin.Value = -5;

            //default values for parameter
            NUDa.Value = 1;
            NUDk.Value = 1;
            NUDd.Value = 0;
            NUDc.Value = 0;

            //default radio button
            RBLinear.Checked = true; 

            //default function properties
            lblParentAnswer.Text = "No Function Selected";
            lblDomainAnswer.Text = "No Function Selected";
            lblRangeAnswer.Text = "No Function Selected";

            
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instructions
            MessageBox.Show("Hello user, welcome to Basic Function Transformation Application! Please follow the following instructions to learn how to pilot this program." + "\n" + "\n" +
                "1. Choose the scale for the plane. Input the max/min values that you want on your x and y axis." + "\n" + "\n" +
                "2. Select the type of graph that would like to draw. On the middle, left hand side of the user interface there are 7 basic graphs for you to choose from (linear, quadratic, absolute, root, cubic, sine, and cosine)" + "\n" + "\n" +
                "3. Input the a, k, d and c values into your graph." + "\n" + "\n" +
                "4. Draw your Graph by selected the button labelled: DRAW and watch as its transformations are implemented!" + "\n" + "\n" +
                "Enjoy!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Description of Parameter A
            MessageBox.Show("     The A value represents the vertical stretch or compression of the function." +
                            " If the A value is greater than 1 it is a vertical stretch." +
                            " If the A value is less than 1 it is a vertical compression." +
                            " If the A value is a negative number it represents that the graph is reflected over the x-axis." +
                            " (e.g. A = 4, There is a vertical stretch of 4)", "Knowing Function Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Description of Parameter K
            MessageBox.Show("     The K value represents the horizontal stretch or compression of the function." +
                            " The K value is the opposite of the A value." +
                            " If the K value is greater than 1 there is a horizontal compression." +
                            " If the K value is less than 1 the is a horizontal stretch." +
                            " If the K value is negative the graph is reflected over the y-axis." +
                            " (e.g. K = 1/4, There is a horizontal stretch of 4)", "Knowing Function Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Description of Parameter C
            MessageBox.Show("     The C value represents the the vertical shift of the function." +
                            " When the C value is positive, the graph is shifts up and when the C value is negative the graph is shifts down." +
                            " (e.g. C = 5, shifts up 5 units)", "Knowing Function Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Description of Parameter D
            MessageBox.Show("     The D value represents the horizontal shift of the function." +
                            " The D value is subtracted from the X value so when the D value is subtracted from the X value, the graph shifts to the right and when it is added to the X value, it shifts to the left." +
                            " (e.g (x-4), shifts 4 units to the right)", "Knowing Function Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
