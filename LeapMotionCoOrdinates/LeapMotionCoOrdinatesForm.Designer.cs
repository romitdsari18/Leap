namespace LeapMotionCoOrdinates
{
    partial class LeapMotionCoOrdinatesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdConnectLeapMotion = new System.Windows.Forms.Button();
            this.handPosX = new System.Windows.Forms.TextBox();
            this.handPosY = new System.Windows.Forms.TextBox();
            this.handPosZ = new System.Windows.Forms.TextBox();
            this.cmdDisconnectLeapMotion = new System.Windows.Forms.Button();
            this.OriginZ = new System.Windows.Forms.TextBox();
            this.OriginY = new System.Windows.Forms.TextBox();
            this.OriginX = new System.Windows.Forms.TextBox();
            this.PAxisZ = new System.Windows.Forms.TextBox();
            this.PAxisY = new System.Windows.Forms.TextBox();
            this.PAxisX = new System.Windows.Forms.TextBox();
            this.QAxisZ = new System.Windows.Forms.TextBox();
            this.QAxisY = new System.Windows.Forms.TextBox();
            this.QAxisX = new System.Windows.Forms.TextBox();
            this.cmdSetOrigin = new System.Windows.Forms.Button();
            this.cmdSetAxis1 = new System.Windows.Forms.Button();
            this.cmdSetAxis2 = new System.Windows.Forms.Button();
            this.ScreenPosX = new System.Windows.Forms.TextBox();
            this.ScreenPosY = new System.Windows.Forms.TextBox();
            this.ScreenPosZ = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.distance = new System.Windows.Forms.TextBox();
            this.cmdSetPoint1 = new System.Windows.Forms.Button();
            this.cmdSetPoint2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdConnectLeapMotion
            // 
            this.cmdConnectLeapMotion.Location = new System.Drawing.Point(13, 13);
            this.cmdConnectLeapMotion.Name = "cmdConnectLeapMotion";
            this.cmdConnectLeapMotion.Size = new System.Drawing.Size(75, 23);
            this.cmdConnectLeapMotion.TabIndex = 0;
            this.cmdConnectLeapMotion.Text = "Connect";
            this.cmdConnectLeapMotion.UseVisualStyleBackColor = true;
            this.cmdConnectLeapMotion.Click += new System.EventHandler(this.cmdConnectLeapMotion_Click);
            // 
            // handPosX
            // 
            this.handPosX.Location = new System.Drawing.Point(13, 43);
            this.handPosX.Name = "handPosX";
            this.handPosX.Size = new System.Drawing.Size(100, 22);
            this.handPosX.TabIndex = 1;
            // 
            // handPosY
            // 
            this.handPosY.Location = new System.Drawing.Point(13, 72);
            this.handPosY.Name = "handPosY";
            this.handPosY.Size = new System.Drawing.Size(100, 22);
            this.handPosY.TabIndex = 2;
            // 
            // handPosZ
            // 
            this.handPosZ.Location = new System.Drawing.Point(13, 101);
            this.handPosZ.Name = "handPosZ";
            this.handPosZ.Size = new System.Drawing.Size(100, 22);
            this.handPosZ.TabIndex = 3;
            // 
            // cmdDisconnectLeapMotion
            // 
            this.cmdDisconnectLeapMotion.Location = new System.Drawing.Point(143, 12);
            this.cmdDisconnectLeapMotion.Name = "cmdDisconnectLeapMotion";
            this.cmdDisconnectLeapMotion.Size = new System.Drawing.Size(97, 23);
            this.cmdDisconnectLeapMotion.TabIndex = 4;
            this.cmdDisconnectLeapMotion.Text = "Disconnect";
            this.cmdDisconnectLeapMotion.UseVisualStyleBackColor = true;
            this.cmdDisconnectLeapMotion.Click += new System.EventHandler(this.cmdDisconnectLeapMotion_Click);
            // 
            // OriginZ
            // 
            this.OriginZ.Location = new System.Drawing.Point(13, 214);
            this.OriginZ.Name = "OriginZ";
            this.OriginZ.Size = new System.Drawing.Size(100, 22);
            this.OriginZ.TabIndex = 7;
            // 
            // OriginY
            // 
            this.OriginY.Location = new System.Drawing.Point(13, 185);
            this.OriginY.Name = "OriginY";
            this.OriginY.Size = new System.Drawing.Size(100, 22);
            this.OriginY.TabIndex = 6;
            // 
            // OriginX
            // 
            this.OriginX.Location = new System.Drawing.Point(13, 156);
            this.OriginX.Name = "OriginX";
            this.OriginX.Size = new System.Drawing.Size(100, 22);
            this.OriginX.TabIndex = 5;
            // 
            // PAxisZ
            // 
            this.PAxisZ.Location = new System.Drawing.Point(143, 214);
            this.PAxisZ.Name = "PAxisZ";
            this.PAxisZ.Size = new System.Drawing.Size(100, 22);
            this.PAxisZ.TabIndex = 10;
            // 
            // PAxisY
            // 
            this.PAxisY.Location = new System.Drawing.Point(143, 185);
            this.PAxisY.Name = "PAxisY";
            this.PAxisY.Size = new System.Drawing.Size(100, 22);
            this.PAxisY.TabIndex = 9;
            // 
            // PAxisX
            // 
            this.PAxisX.AcceptsReturn = true;
            this.PAxisX.Location = new System.Drawing.Point(143, 156);
            this.PAxisX.Name = "PAxisX";
            this.PAxisX.Size = new System.Drawing.Size(100, 22);
            this.PAxisX.TabIndex = 8;
            // 
            // QAxisZ
            // 
            this.QAxisZ.Location = new System.Drawing.Point(294, 214);
            this.QAxisZ.Name = "QAxisZ";
            this.QAxisZ.Size = new System.Drawing.Size(100, 22);
            this.QAxisZ.TabIndex = 13;
            // 
            // QAxisY
            // 
            this.QAxisY.Location = new System.Drawing.Point(294, 185);
            this.QAxisY.Name = "QAxisY";
            this.QAxisY.Size = new System.Drawing.Size(100, 22);
            this.QAxisY.TabIndex = 12;
            // 
            // QAxisX
            // 
            this.QAxisX.Location = new System.Drawing.Point(294, 156);
            this.QAxisX.Name = "QAxisX";
            this.QAxisX.Size = new System.Drawing.Size(100, 22);
            this.QAxisX.TabIndex = 11;
            // 
            // cmdSetOrigin
            // 
            this.cmdSetOrigin.Location = new System.Drawing.Point(12, 243);
            this.cmdSetOrigin.Name = "cmdSetOrigin";
            this.cmdSetOrigin.Size = new System.Drawing.Size(101, 23);
            this.cmdSetOrigin.TabIndex = 14;
            this.cmdSetOrigin.Text = "Set Origin";
            this.cmdSetOrigin.UseVisualStyleBackColor = true;
            this.cmdSetOrigin.Click += new System.EventHandler(this.cmdSetOrigin_Click);
            // 
            // cmdSetAxis1
            // 
            this.cmdSetAxis1.Location = new System.Drawing.Point(143, 243);
            this.cmdSetAxis1.Name = "cmdSetAxis1";
            this.cmdSetAxis1.Size = new System.Drawing.Size(100, 23);
            this.cmdSetAxis1.TabIndex = 15;
            this.cmdSetAxis1.Text = "Set Axis 1";
            this.cmdSetAxis1.UseVisualStyleBackColor = true;
            this.cmdSetAxis1.Click += new System.EventHandler(this.cmdSetAxis1_Click);
            // 
            // cmdSetAxis2
            // 
            this.cmdSetAxis2.Location = new System.Drawing.Point(294, 243);
            this.cmdSetAxis2.Name = "cmdSetAxis2";
            this.cmdSetAxis2.Size = new System.Drawing.Size(100, 23);
            this.cmdSetAxis2.TabIndex = 16;
            this.cmdSetAxis2.Text = "Set Axis 2";
            this.cmdSetAxis2.UseVisualStyleBackColor = true;
            this.cmdSetAxis2.Click += new System.EventHandler(this.cmdSetAxis2_Click);
            // 
            // ScreenPosX
            // 
            this.ScreenPosX.Location = new System.Drawing.Point(294, 43);
            this.ScreenPosX.Name = "ScreenPosX";
            this.ScreenPosX.Size = new System.Drawing.Size(100, 22);
            this.ScreenPosX.TabIndex = 17;
            // 
            // ScreenPosY
            // 
            this.ScreenPosY.Location = new System.Drawing.Point(294, 72);
            this.ScreenPosY.Name = "ScreenPosY";
            this.ScreenPosY.Size = new System.Drawing.Size(100, 22);
            this.ScreenPosY.TabIndex = 18;
            // 
            // ScreenPosZ
            // 
            this.ScreenPosZ.Location = new System.Drawing.Point(294, 100);
            this.ScreenPosZ.Name = "ScreenPosZ";
            this.ScreenPosZ.Size = new System.Drawing.Size(100, 22);
            this.ScreenPosZ.TabIndex = 19;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(401, 12);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(386, 354);
            this.zedGraphControl1.TabIndex = 20;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(267, 343);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(100, 22);
            this.distance.TabIndex = 22;
            // 
            // cmdSetPoint1
            // 
            this.cmdSetPoint1.Location = new System.Drawing.Point(38, 342);
            this.cmdSetPoint1.Name = "cmdSetPoint1";
            this.cmdSetPoint1.Size = new System.Drawing.Size(75, 23);
            this.cmdSetPoint1.TabIndex = 24;
            this.cmdSetPoint1.Text = "Point1";
            this.cmdSetPoint1.UseVisualStyleBackColor = true;
            this.cmdSetPoint1.Click += new System.EventHandler(this.CmdSetPoint1_Click);
            // 
            // cmdSetPoint2
            // 
            this.cmdSetPoint2.Location = new System.Drawing.Point(165, 343);
            this.cmdSetPoint2.Name = "cmdSetPoint2";
            this.cmdSetPoint2.Size = new System.Drawing.Size(75, 23);
            this.cmdSetPoint2.TabIndex = 25;
            this.cmdSetPoint2.Text = "Point2";
            this.cmdSetPoint2.UseVisualStyleBackColor = true;
            this.cmdSetPoint2.Click += new System.EventHandler(this.CmdSetPoint2_Click);
            // 
            // LeapMotionCoOrdinatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSetPoint2);
            this.Controls.Add(this.cmdSetPoint1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.ScreenPosZ);
            this.Controls.Add(this.ScreenPosY);
            this.Controls.Add(this.ScreenPosX);
            this.Controls.Add(this.cmdSetAxis2);
            this.Controls.Add(this.cmdSetAxis1);
            this.Controls.Add(this.cmdSetOrigin);
            this.Controls.Add(this.QAxisZ);
            this.Controls.Add(this.QAxisY);
            this.Controls.Add(this.QAxisX);
            this.Controls.Add(this.PAxisZ);
            this.Controls.Add(this.PAxisY);
            this.Controls.Add(this.PAxisX);
            this.Controls.Add(this.OriginZ);
            this.Controls.Add(this.OriginY);
            this.Controls.Add(this.OriginX);
            this.Controls.Add(this.cmdDisconnectLeapMotion);
            this.Controls.Add(this.handPosZ);
            this.Controls.Add(this.handPosY);
            this.Controls.Add(this.handPosX);
            this.Controls.Add(this.cmdConnectLeapMotion);
            this.Name = "LeapMotionCoOrdinatesForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConnectLeapMotion;
        private System.Windows.Forms.TextBox handPosX;
        private System.Windows.Forms.TextBox handPosY;
        private System.Windows.Forms.TextBox handPosZ;
        private System.Windows.Forms.Button cmdDisconnectLeapMotion;
        private System.Windows.Forms.TextBox OriginZ;
        private System.Windows.Forms.TextBox OriginY;
        private System.Windows.Forms.TextBox OriginX;
        private System.Windows.Forms.TextBox PAxisZ;
        private System.Windows.Forms.TextBox PAxisY;
        private System.Windows.Forms.TextBox PAxisX;
        private System.Windows.Forms.TextBox QAxisZ;
        private System.Windows.Forms.TextBox QAxisY;
        private System.Windows.Forms.TextBox QAxisX;
        private System.Windows.Forms.Button cmdSetOrigin;
        private System.Windows.Forms.Button cmdSetAxis1;
        private System.Windows.Forms.Button cmdSetAxis2;
        private System.Windows.Forms.TextBox ScreenPosX;
        private System.Windows.Forms.TextBox ScreenPosY;
        private System.Windows.Forms.TextBox ScreenPosZ;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Button cmdSetPoint1;
        private System.Windows.Forms.Button cmdSetPoint2;
    }
}

