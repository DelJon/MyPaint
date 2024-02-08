namespace MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newCanvas = new System.Windows.Forms.ToolStripButton();
            this.openImage = new System.Windows.Forms.ToolStripButton();
            this.saveImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pickColor = new System.Windows.Forms.ToolStripButton();
            this.colorPickerMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.penMode = new System.Windows.Forms.ToolStripButton();
            this.rectangleMode = new System.Windows.Forms.ToolStripButton();
            this.elipseMode = new System.Windows.Forms.ToolStripButton();
            this.lineMode = new System.Windows.Forms.ToolStripButton();
            this.bucketMode = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeTB = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCanvas,
            this.openImage,
            this.saveImage,
            this.toolStripSeparator2,
            this.pickColor,
            this.colorPickerMode,
            this.toolStripSeparator3,
            this.penMode,
            this.rectangleMode,
            this.elipseMode,
            this.lineMode,
            this.bucketMode,
            this.toolStripSeparator1,
            this.sizeTB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newCanvas
            // 
            this.newCanvas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newCanvas.Image = ((System.Drawing.Image)(resources.GetObject("newCanvas.Image")));
            this.newCanvas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newCanvas.Name = "newCanvas";
            this.newCanvas.Size = new System.Drawing.Size(23, 22);
            this.newCanvas.Text = "toolStripButton1";
            this.newCanvas.ToolTipText = "New Canvas";
            this.newCanvas.Click += new System.EventHandler(this.newCanvas_Click);
            // 
            // openImage
            // 
            this.openImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openImage.Image = ((System.Drawing.Image)(resources.GetObject("openImage.Image")));
            this.openImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(23, 22);
            this.openImage.Text = "toolStripButton2";
            this.openImage.ToolTipText = "Open File";
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveImage.Image = ((System.Drawing.Image)(resources.GetObject("saveImage.Image")));
            this.saveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(23, 22);
            this.saveImage.Text = "toolStripButton3";
            this.saveImage.ToolTipText = "Save As";
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pickColor
            // 
            this.pickColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickColor.Image = ((System.Drawing.Image)(resources.GetObject("pickColor.Image")));
            this.pickColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(23, 22);
            this.pickColor.Text = "toolStripButton6";
            this.pickColor.ToolTipText = "Pick Color";
            this.pickColor.Click += new System.EventHandler(this.pickColor_Click);
            // 
            // colorPickerMode
            // 
            this.colorPickerMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPickerMode.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerMode.Image")));
            this.colorPickerMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorPickerMode.Name = "colorPickerMode";
            this.colorPickerMode.Size = new System.Drawing.Size(23, 22);
            this.colorPickerMode.Text = "toolStripButton7";
            this.colorPickerMode.Click += new System.EventHandler(this.colorPickerMode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // penMode
            // 
            this.penMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penMode.Image = ((System.Drawing.Image)(resources.GetObject("penMode.Image")));
            this.penMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penMode.Name = "penMode";
            this.penMode.Size = new System.Drawing.Size(23, 22);
            this.penMode.Text = "toolStripButton1";
            this.penMode.Click += new System.EventHandler(this.penMode_Click);
            // 
            // rectangleMode
            // 
            this.rectangleMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleMode.Image = ((System.Drawing.Image)(resources.GetObject("rectangleMode.Image")));
            this.rectangleMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleMode.Name = "rectangleMode";
            this.rectangleMode.Size = new System.Drawing.Size(23, 22);
            this.rectangleMode.Text = "toolStripButton2";
            this.rectangleMode.Click += new System.EventHandler(this.rectangleMode_Click);
            // 
            // elipseMode
            // 
            this.elipseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elipseMode.Image = ((System.Drawing.Image)(resources.GetObject("elipseMode.Image")));
            this.elipseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.elipseMode.Name = "elipseMode";
            this.elipseMode.Size = new System.Drawing.Size(23, 22);
            this.elipseMode.Text = "toolStripButton3";
            this.elipseMode.Click += new System.EventHandler(this.elipseMode_Click);
            // 
            // lineMode
            // 
            this.lineMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineMode.Image = ((System.Drawing.Image)(resources.GetObject("lineMode.Image")));
            this.lineMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineMode.Name = "lineMode";
            this.lineMode.Size = new System.Drawing.Size(23, 22);
            this.lineMode.Text = "toolStripButton6";
            this.lineMode.Click += new System.EventHandler(this.lineMode_Click);
            // 
            // bucketMode
            // 
            this.bucketMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bucketMode.Image = ((System.Drawing.Image)(resources.GetObject("bucketMode.Image")));
            this.bucketMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bucketMode.Name = "bucketMode";
            this.bucketMode.Size = new System.Drawing.Size(23, 22);
            this.bucketMode.Text = "toolStripButton8";
            this.bucketMode.Click += new System.EventHandler(this.bucketMode_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.canvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 477);
            this.panel1.TabIndex = 1;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(3, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(503, 368);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"PNG files|*.png|JPG files|*jpg|BMP files|*.bmp*\"";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"PNG files|*.png|JPG files|*jpg|BMP files|*.bmp*\"";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sizeTB
            // 
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(100, 25);
            this.sizeTB.TextChanged += new System.EventHandler(this.sizeTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(700, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newCanvas;
        private System.Windows.Forms.ToolStripButton openImage;
        private System.Windows.Forms.ToolStripButton saveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton pickColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripButton colorPickerMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton penMode;
        private System.Windows.Forms.ToolStripButton rectangleMode;
        private System.Windows.Forms.ToolStripButton elipseMode;
        private System.Windows.Forms.ToolStripButton lineMode;
        private System.Windows.Forms.ToolStripButton bucketMode;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox sizeTB;
    }
}

