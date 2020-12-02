namespace FaceDetect
{
    partial class Form1
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
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.start = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coordinateXR = new System.Windows.Forms.Label();
            this.coordinateYT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coordinateXL = new System.Windows.Forms.Label();
            this.coordinateYB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.sumX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sumY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(12, 58);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(1160, 751);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1229, 69);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(99, 23);
            this.start.TabIndex = 3;
            this.start.Text = "Start Detection";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1229, 107);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 25);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Face";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(1229, 218);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1253, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // coordinateXR
            // 
            this.coordinateXR.AutoSize = true;
            this.coordinateXR.Location = new System.Drawing.Point(1265, 261);
            this.coordinateXR.Name = "coordinateXR";
            this.coordinateXR.Size = new System.Drawing.Size(72, 13);
            this.coordinateXR.TabIndex = 7;
            this.coordinateXR.Text = "coordinateXR";
            // 
            // coordinateYT
            // 
            this.coordinateYT.AutoSize = true;
            this.coordinateYT.Location = new System.Drawing.Point(1265, 333);
            this.coordinateYT.Name = "coordinateYT";
            this.coordinateYT.Size = new System.Drawing.Size(71, 13);
            this.coordinateYT.TabIndex = 8;
            this.coordinateYT.Text = "coordinateYT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1198, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "X-Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1198, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y - Top";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1198, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X-Left";
            // 
            // coordinateXL
            // 
            this.coordinateXL.AutoSize = true;
            this.coordinateXL.Location = new System.Drawing.Point(1265, 283);
            this.coordinateXL.Name = "coordinateXL";
            this.coordinateXL.Size = new System.Drawing.Size(70, 13);
            this.coordinateXL.TabIndex = 12;
            this.coordinateXL.Text = "coordinateXL";
            // 
            // coordinateYB
            // 
            this.coordinateYB.AutoSize = true;
            this.coordinateYB.Location = new System.Drawing.Point(1264, 355);
            this.coordinateYB.Name = "coordinateYB";
            this.coordinateYB.Size = new System.Drawing.Size(71, 13);
            this.coordinateYB.TabIndex = 13;
            this.coordinateYB.Text = "coordinateYB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1198, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y - Bottom";
            // 
            // port
            // 
            this.port.PortName = "COM3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1198, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sum X";
            // 
            // sumX
            // 
            this.sumX.AutoSize = true;
            this.sumX.Location = new System.Drawing.Point(1265, 305);
            this.sumX.Name = "sumX";
            this.sumX.Size = new System.Drawing.Size(38, 13);
            this.sumX.TabIndex = 16;
            this.sumX.Text = "Sum X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1198, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sum Y";
            // 
            // sumY
            // 
            this.sumY.AutoSize = true;
            this.sumY.Location = new System.Drawing.Point(1265, 377);
            this.sumY.Name = "sumY";
            this.sumY.Size = new System.Drawing.Size(38, 13);
            this.sumY.TabIndex = 18;
            this.sumY.Text = "Sum Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 717);
            this.Controls.Add(this.sumY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sumX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coordinateYB);
            this.Controls.Add(this.coordinateXL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coordinateYT);
            this.Controls.Add(this.coordinateXR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coordinateXR;
        private System.Windows.Forms.Label coordinateYT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label coordinateXL;
        private System.Windows.Forms.Label coordinateYB;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sumX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sumY;
    }
}

