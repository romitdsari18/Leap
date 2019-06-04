using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Leap;
using System.Drawing.Imaging;
using ZedGraph;

namespace LeapMotionCoOrdinates
{
    public partial class LeapMotionCoOrdinatesForm : Form
    {
        private Controller controller;
        GraphPane graphPane;
        Hand hand;
        Vector Leap = new Vector();
        Vector Screen = new Vector();
        Vector _OriginPoint = new Vector();
        Vector AxisX;
        Vector AxisZ;
        float[,] _orientationScreen = new float[3, 3];
        float[,] _orientationScreenTransposed = new float[3, 3];
        float[,] _transformationInverse = new float[4, 4];
        
        bool isTransformed = false;

        Vector Point1 = new Vector();
        Vector Point2 = new Vector();

        public LeapMotionCoOrdinatesForm()
        {
            InitializeComponent();
            graphPane = zedGraphControl1.GraphPane;

            DrawcartesianLines();
        }
        private void DrawcartesianLines()
        {
            graphPane.CurveList.Clear();

            zedGraphControl1.GraphPane.YAxis.MajorGrid.IsZeroLine = true;
            zedGraphControl1.GraphPane.XAxis.MajorGrid.IsZeroLine = true;
            zedGraphControl1.GraphPane.XAxis.Scale.Max = 500;
            zedGraphControl1.GraphPane.XAxis.Scale.Min = -500;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = 500;
            zedGraphControl1.GraphPane.YAxis.Scale.Min = -500;
        }
        private void cmdConnectLeapMotion_Click(object sender, EventArgs e)
        {

             controller = new Controller();

            controller.Connect += Controller_Connect;
            controller.Device += Controller_Device;
            controller.FrameReady += Controller_FrameReady;
        }

        private void Controller_FrameReady(object sender, FrameEventArgs e)
        {
            Frame frame = e.frame;

            if (frame.Hands.Count > 0)
            {
                hand = frame.Hands[0];
                if (hand.Fingers.Count > 0)
                {
                    Leap.x = Convert.ToSingle(Math.Round(hand.PalmPosition.x, 3));
                    Leap.y = Convert.ToSingle(Math.Round(hand.PalmPosition.z, 3));
                    Leap.z = Convert.ToSingle(Math.Round(hand.PalmPosition.y, 3));
                    handPosX.Text = Leap.x.ToString();
                    handPosY.Text = Leap.y.ToString();
                    handPosZ.Text = Leap.z.ToString();
                }
                if (isTransformed)
                {
                    //testing
                    //Leap.x = 0;
                    //Leap.y = 0;
                    //Leap.z = 0.275f;
                    Screen.x = _transformationInverse[0, 0] * Leap.x + _transformationInverse[1, 0] * Leap.y + _transformationInverse[2, 0] * Leap.z + _transformationInverse[3, 0];
                    Screen.y = _transformationInverse[0, 1] * Leap.x + _transformationInverse[1, 1] * Leap.y + _transformationInverse[2, 1] * Leap.z + _transformationInverse[3, 1];
                    Screen.z = _transformationInverse[0, 2] * Leap.x + _transformationInverse[1, 2] * Leap.y + _transformationInverse[2, 2] * Leap.z + _transformationInverse[3, 2];
                    PointPair pointPair = new PointPair(Screen.x, Screen.y);
                    PointPairList pointPairs = new PointPairList();
                    pointPairs.Add(pointPair);
                    LineItem line = graphPane.AddCurve("", pointPairs, Color.Black);
                    line.Line.IsVisible = false;
                    zedGraphControl1.Invalidate();
                    ScreenPosX.Text = Screen.x.ToString();
                    ScreenPosY.Text = Screen.y.ToString();
                    ScreenPosZ.Text = Screen.z.ToString();
                }
            }
            else
            {
                handPosX.Text = "NA";
                handPosY.Text = "NA";
                handPosZ.Text = "NA";
            }
        }

        private void Controller_Device(object sender, DeviceEventArgs e)
        {
            
        }

        private void Controller_Connect(object sender, ConnectionEventArgs e)
        {
            
        }

        private void cmdDisconnectLeapMotion_Click(object sender, EventArgs e)
        {
            if (controller.IsConnected)
                controller.StopConnection();
        }

        private void cmdSetOrigin_Click(object sender, EventArgs e)
        {
            _OriginPoint.x = Leap.x;
            _OriginPoint.y = Leap.y;
            _OriginPoint.z = Leap.z;

            //testing-test
            //_OriginPoint.x = 0;
            //_OriginPoint.y = 0;
            //_OriginPoint.z = 0.275F;
            OriginX.Text = _OriginPoint.x.ToString();
            OriginY.Text = _OriginPoint.y.ToString();
            OriginZ.Text = _OriginPoint.z.ToString();
        }

        private void cmdSetAxis1_Click(object sender, EventArgs e)
        {
            float _Axis1X = Leap.x;
            float _Axis1Y = Leap.y;
            float _Axis1Z = Leap.z;

            //testing
            //float _Axis1X = 1;
            //float _Axis1Y = 0;
            //float _Axis1Z = 0.275f;
            AxisX = new Vector(_Axis1X - _OriginPoint.x, _Axis1Y - _OriginPoint.y, _Axis1Z - _OriginPoint.z);
            PAxisX.Text = AxisX.x.ToString();
            PAxisY.Text = AxisX.y.ToString();
            PAxisZ.Text = AxisX.z.ToString();
        }

        private void cmdSetAxis2_Click(object sender, EventArgs e)
        {
            float _Axis2X = Leap.x;
            float _Axis2Y = Leap.y;
            float _Axis2Z = Leap.z;
            //testing
            //float _Axis2X = 1;
            //float _Axis2Y = 1;
            //float _Axis2Z = 0.275f;
            Vector Axis2 = new Vector(_Axis2X - _OriginPoint.x, _Axis2Y - _OriginPoint.y, _Axis2Z - _OriginPoint.z);

            //changes
            AxisZ = AxisX.Cross(Axis2);
            //AxisZ = new Vector(AxisX.y * Axis2.z - AxisX.z * Axis2.y,
            //                        AxisX.z * Axis2.x - AxisX.x * Axis2.z,
            //                        AxisX.x * Axis2.y - AxisX.y * Axis2.x);
            Vector UnitAxisZ = AxisZ.Normalized;
            Vector UnitAxisX = AxisX.Normalized;
            
            //changes
            Vector UnitAxisY = -UnitAxisX.Cross(UnitAxisZ);
            //Vector UnitAxisY = new Vector(-(UnitAxisX.y * UnitAxisZ.z - UnitAxisX.z * UnitAxisZ.y),
            //                              -(UnitAxisX.z * UnitAxisZ.x - UnitAxisX.x * UnitAxisZ.z),
            //                              -(UnitAxisX.x * UnitAxisZ.y - UnitAxisX.y * UnitAxisZ.x));
            QAxisX.Text = UnitAxisY.x.ToString();
            QAxisY.Text = UnitAxisY.y.ToString();
            QAxisZ.Text = UnitAxisY.z.ToString();

            _orientationScreen[0, 0] = UnitAxisX.x;
            _orientationScreen[1, 0] = UnitAxisY.x;
            _orientationScreen[2, 0] = UnitAxisZ.x;

            _orientationScreen[0, 1] = UnitAxisX.y;
            _orientationScreen[1, 1] = UnitAxisY.y;
            _orientationScreen[2, 1] = UnitAxisZ.y;

            _orientationScreen[0, 2] = UnitAxisX.z;
            _orientationScreen[1, 2] = UnitAxisY.z;
            _orientationScreen[2, 2] = UnitAxisZ.z;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _orientationScreenTransposed[i, j] = _orientationScreen[j, i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _transformationInverse[i, j] = _orientationScreenTransposed[i, j];
                }
            }
            _transformationInverse[3, 0] = -(_orientationScreenTransposed[0, 0] * _OriginPoint.x + _orientationScreenTransposed[1, 0] * _OriginPoint.y + _orientationScreenTransposed[2, 0] * _OriginPoint.z);
            _transformationInverse[3, 1] = -(_orientationScreenTransposed[0, 1] * _OriginPoint.x + _orientationScreenTransposed[1, 1] * _OriginPoint.y + _orientationScreenTransposed[2, 1] * _OriginPoint.z);
            _transformationInverse[3, 2] = -(_orientationScreenTransposed[0, 2] * _OriginPoint.x + _orientationScreenTransposed[1, 2] * _OriginPoint.y + _orientationScreenTransposed[2, 2] * _OriginPoint.z);
            _transformationInverse[0, 3] = _transformationInverse[1, 3] = _transformationInverse[2, 3] = 0;
            _transformationInverse[3, 3] = 1;

            isTransformed = true;
        }

        private void CmdSetPoint2_Click(object sender, EventArgs e)
        {
            Point2.x = Leap.x;
            Point2.y = Leap.y;
            Point2.z = Leap.z;
            distance.Text = Point1.DistanceTo(Point2).ToString();
        }

        private void CmdSetPoint1_Click(object sender, EventArgs e)
        {
            Point1.x = Leap.x;
            Point1.y = Leap.y;
            Point1.z = Leap.z;
        }
    }
}
