namespace WindowsFormsApplication1
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
            this.PBFunction = new System.Windows.Forms.PictureBox();
            this.GBFunction = new System.Windows.Forms.GroupBox();
            this.RBCosine = new System.Windows.Forms.RadioButton();
            this.RBSine = new System.Windows.Forms.RadioButton();
            this.RBCubic = new System.Windows.Forms.RadioButton();
            this.RBAbsolute = new System.Windows.Forms.RadioButton();
            this.RBRoot = new System.Windows.Forms.RadioButton();
            this.RBQuadratic = new System.Windows.Forms.RadioButton();
            this.RBLinear = new System.Windows.Forms.RadioButton();
            this.GBParameters = new System.Windows.Forms.GroupBox();
            this.NUDc = new System.Windows.Forms.NumericUpDown();
            this.lblC = new System.Windows.Forms.Label();
            this.NUDd = new System.Windows.Forms.NumericUpDown();
            this.lblA = new System.Windows.Forms.Label();
            this.NUDk = new System.Windows.Forms.NumericUpDown();
            this.lblD = new System.Windows.Forms.Label();
            this.NUDa = new System.Windows.Forms.NumericUpDown();
            this.lblK = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knowingFunctionParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttLinear = new System.Windows.Forms.ToolTip(this.components);
            this.ttQuadratic = new System.Windows.Forms.ToolTip(this.components);
            this.ttAbsolute = new System.Windows.Forms.ToolTip(this.components);
            this.ttRoot = new System.Windows.Forms.ToolTip(this.components);
            this.ttA = new System.Windows.Forms.ToolTip(this.components);
            this.ttK = new System.Windows.Forms.ToolTip(this.components);
            this.ttD = new System.Windows.Forms.ToolTip(this.components);
            this.ttC = new System.Windows.Forms.ToolTip(this.components);
            this.ttXmin = new System.Windows.Forms.ToolTip(this.components);
            this.NUDXmin = new System.Windows.Forms.NumericUpDown();
            this.GBScale = new System.Windows.Forms.GroupBox();
            this.NUDYmin = new System.Windows.Forms.NumericUpDown();
            this.NUDYmax = new System.Windows.Forms.NumericUpDown();
            this.lblYmin = new System.Windows.Forms.Label();
            this.NUDXmax = new System.Windows.Forms.NumericUpDown();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblYmax = new System.Windows.Forms.Label();
            this.lblXmin = new System.Windows.Forms.Label();
            this.ttXmax = new System.Windows.Forms.ToolTip(this.components);
            this.ttYmax = new System.Windows.Forms.ToolTip(this.components);
            this.ttYmin = new System.Windows.Forms.ToolTip(this.components);
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ttDraw = new System.Windows.Forms.ToolTip(this.components);
            this.ttReset = new System.Windows.Forms.ToolTip(this.components);
            this.CDLineColor = new System.Windows.Forms.ColorDialog();
            this.ttSine = new System.Windows.Forms.ToolTip(this.components);
            this.ttCosine = new System.Windows.Forms.ToolTip(this.components);
            this.ttCubic = new System.Windows.Forms.ToolTip(this.components);
            this.ttProperties = new System.Windows.Forms.ToolTip(this.components);
            this.GBProperties = new System.Windows.Forms.GroupBox();
            this.lblRangeAnswer = new System.Windows.Forms.Label();
            this.lblDomainAnswer = new System.Windows.Forms.Label();
            this.lblParentAnswer = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBFunction)).BeginInit();
            this.GBFunction.SuspendLayout();
            this.GBParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDXmin)).BeginInit();
            this.GBScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDYmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDXmax)).BeginInit();
            this.GBProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBFunction
            // 
            this.PBFunction.BackColor = System.Drawing.Color.White;
            this.PBFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBFunction.Location = new System.Drawing.Point(146, 39);
            this.PBFunction.Name = "PBFunction";
            this.PBFunction.Size = new System.Drawing.Size(400, 400);
            this.PBFunction.TabIndex = 0;
            this.PBFunction.TabStop = false;
            this.PBFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.PBFunction_Paint);
            // 
            // GBFunction
            // 
            this.GBFunction.Controls.Add(this.RBCosine);
            this.GBFunction.Controls.Add(this.RBSine);
            this.GBFunction.Controls.Add(this.RBCubic);
            this.GBFunction.Controls.Add(this.RBAbsolute);
            this.GBFunction.Controls.Add(this.RBRoot);
            this.GBFunction.Controls.Add(this.RBQuadratic);
            this.GBFunction.Controls.Add(this.RBLinear);
            this.GBFunction.Location = new System.Drawing.Point(12, 149);
            this.GBFunction.Name = "GBFunction";
            this.GBFunction.Size = new System.Drawing.Size(127, 182);
            this.GBFunction.TabIndex = 5;
            this.GBFunction.TabStop = false;
            this.GBFunction.Text = "Functions";
            // 
            // RBCosine
            // 
            this.RBCosine.AutoSize = true;
            this.RBCosine.Location = new System.Drawing.Point(6, 157);
            this.RBCosine.Name = "RBCosine";
            this.RBCosine.Size = new System.Drawing.Size(57, 17);
            this.RBCosine.TabIndex = 12;
            this.RBCosine.TabStop = true;
            this.RBCosine.Text = "Cosine";
            this.ttCosine.SetToolTip(this.RBCosine, "Select to display a cosine function. ");
            this.RBCosine.UseVisualStyleBackColor = true;
            // 
            // RBSine
            // 
            this.RBSine.AutoSize = true;
            this.RBSine.Location = new System.Drawing.Point(6, 134);
            this.RBSine.Name = "RBSine";
            this.RBSine.Size = new System.Drawing.Size(46, 17);
            this.RBSine.TabIndex = 11;
            this.RBSine.TabStop = true;
            this.RBSine.Text = "Sine";
            this.ttSine.SetToolTip(this.RBSine, "Select to display a sine function. ");
            this.RBSine.UseVisualStyleBackColor = true;
            // 
            // RBCubic
            // 
            this.RBCubic.AutoSize = true;
            this.RBCubic.Location = new System.Drawing.Point(6, 111);
            this.RBCubic.Name = "RBCubic";
            this.RBCubic.Size = new System.Drawing.Size(52, 17);
            this.RBCubic.TabIndex = 10;
            this.RBCubic.TabStop = true;
            this.RBCubic.Text = "Cubic";
            this.ttCubic.SetToolTip(this.RBCubic, "Select to display a cubic function. ");
            this.RBCubic.UseVisualStyleBackColor = true;
            // 
            // RBAbsolute
            // 
            this.RBAbsolute.AutoSize = true;
            this.RBAbsolute.Location = new System.Drawing.Point(6, 65);
            this.RBAbsolute.Name = "RBAbsolute";
            this.RBAbsolute.Size = new System.Drawing.Size(66, 17);
            this.RBAbsolute.TabIndex = 8;
            this.RBAbsolute.TabStop = true;
            this.RBAbsolute.Text = "Absolute";
            this.ttAbsolute.SetToolTip(this.RBAbsolute, "Select to display an absolute function. ");
            this.RBAbsolute.UseVisualStyleBackColor = true;
            // 
            // RBRoot
            // 
            this.RBRoot.AutoSize = true;
            this.RBRoot.Location = new System.Drawing.Point(6, 88);
            this.RBRoot.Name = "RBRoot";
            this.RBRoot.Size = new System.Drawing.Size(48, 17);
            this.RBRoot.TabIndex = 9;
            this.RBRoot.TabStop = true;
            this.RBRoot.Text = "Root";
            this.ttRoot.SetToolTip(this.RBRoot, "Select to display a square-root function. ");
            this.RBRoot.UseVisualStyleBackColor = true;
            // 
            // RBQuadratic
            // 
            this.RBQuadratic.AutoSize = true;
            this.RBQuadratic.Location = new System.Drawing.Point(6, 42);
            this.RBQuadratic.Name = "RBQuadratic";
            this.RBQuadratic.Size = new System.Drawing.Size(71, 17);
            this.RBQuadratic.TabIndex = 7;
            this.RBQuadratic.TabStop = true;
            this.RBQuadratic.Text = "Quadratic";
            this.ttQuadratic.SetToolTip(this.RBQuadratic, "Select to display a quadratic function. ");
            this.RBQuadratic.UseVisualStyleBackColor = true;
            // 
            // RBLinear
            // 
            this.RBLinear.AutoSize = true;
            this.RBLinear.Location = new System.Drawing.Point(6, 19);
            this.RBLinear.Name = "RBLinear";
            this.RBLinear.Size = new System.Drawing.Size(54, 17);
            this.RBLinear.TabIndex = 6;
            this.RBLinear.TabStop = true;
            this.RBLinear.Text = "Linear";
            this.ttLinear.SetToolTip(this.RBLinear, "Select to display a linear function.");
            this.RBLinear.UseVisualStyleBackColor = true;
            // 
            // GBParameters
            // 
            this.GBParameters.Controls.Add(this.NUDc);
            this.GBParameters.Controls.Add(this.lblC);
            this.GBParameters.Controls.Add(this.NUDd);
            this.GBParameters.Controls.Add(this.lblA);
            this.GBParameters.Controls.Add(this.NUDk);
            this.GBParameters.Controls.Add(this.lblD);
            this.GBParameters.Controls.Add(this.NUDa);
            this.GBParameters.Controls.Add(this.lblK);
            this.GBParameters.Location = new System.Drawing.Point(12, 337);
            this.GBParameters.Name = "GBParameters";
            this.GBParameters.Size = new System.Drawing.Size(127, 146);
            this.GBParameters.TabIndex = 13;
            this.GBParameters.TabStop = false;
            this.GBParameters.Text = "Function Parameters";
            // 
            // NUDc
            // 
            this.NUDc.Location = new System.Drawing.Point(22, 114);
            this.NUDc.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDc.Name = "NUDc";
            this.NUDc.Size = new System.Drawing.Size(99, 20);
            this.NUDc.TabIndex = 17;
            this.ttC.SetToolTip(this.NUDc, "Select a \"C\" parameter. ");
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(3, 121);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(13, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "c";
            // 
            // NUDd
            // 
            this.NUDd.Location = new System.Drawing.Point(22, 82);
            this.NUDd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDd.Name = "NUDd";
            this.NUDd.Size = new System.Drawing.Size(99, 20);
            this.NUDd.TabIndex = 16;
            this.ttD.SetToolTip(this.NUDd, "Select a \"D\" parameter. ");
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(3, 23);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a";
            // 
            // NUDk
            // 
            this.NUDk.Location = new System.Drawing.Point(22, 49);
            this.NUDk.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDk.Name = "NUDk";
            this.NUDk.Size = new System.Drawing.Size(99, 20);
            this.NUDk.TabIndex = 15;
            this.ttK.SetToolTip(this.NUDk, "Specify a \"K\" parameter. ");
            this.NUDk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(3, 89);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(13, 13);
            this.lblD.TabIndex = 5;
            this.lblD.Text = "d";
            // 
            // NUDa
            // 
            this.NUDa.Location = new System.Drawing.Point(22, 16);
            this.NUDa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDa.Name = "NUDa";
            this.NUDa.Size = new System.Drawing.Size(99, 20);
            this.NUDa.TabIndex = 14;
            this.ttA.SetToolTip(this.NUDa, "Specify an \"A\" parameter.");
            this.NUDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(3, 56);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(13, 13);
            this.lblK.TabIndex = 4;
            this.lblK.Text = "k";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.knowingFunctionParametersToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // knowingFunctionParametersToolStripMenuItem
            // 
            this.knowingFunctionParametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aParameterToolStripMenuItem,
            this.kParameterToolStripMenuItem,
            this.cParameterToolStripMenuItem,
            this.dParameterToolStripMenuItem});
            this.knowingFunctionParametersToolStripMenuItem.Name = "knowingFunctionParametersToolStripMenuItem";
            this.knowingFunctionParametersToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.knowingFunctionParametersToolStripMenuItem.Text = "Knowing Function Parameters";
            // 
            // aParameterToolStripMenuItem
            // 
            this.aParameterToolStripMenuItem.Name = "aParameterToolStripMenuItem";
            this.aParameterToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aParameterToolStripMenuItem.Text = "\"A\" Parameter";
            this.aParameterToolStripMenuItem.Click += new System.EventHandler(this.aParameterToolStripMenuItem_Click);
            // 
            // kParameterToolStripMenuItem
            // 
            this.kParameterToolStripMenuItem.Name = "kParameterToolStripMenuItem";
            this.kParameterToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kParameterToolStripMenuItem.Text = "\"K\" Parameter";
            this.kParameterToolStripMenuItem.Click += new System.EventHandler(this.kParameterToolStripMenuItem_Click);
            // 
            // cParameterToolStripMenuItem
            // 
            this.cParameterToolStripMenuItem.Name = "cParameterToolStripMenuItem";
            this.cParameterToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cParameterToolStripMenuItem.Text = "\"C\" Parameter";
            this.cParameterToolStripMenuItem.Click += new System.EventHandler(this.cParameterToolStripMenuItem_Click);
            // 
            // dParameterToolStripMenuItem
            // 
            this.dParameterToolStripMenuItem.Name = "dParameterToolStripMenuItem";
            this.dParameterToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dParameterToolStripMenuItem.Text = "\"D\" Parameter";
            this.dParameterToolStripMenuItem.Click += new System.EventHandler(this.dParameterToolStripMenuItem_Click);
            // 
            // ttLinear
            // 
            this.ttLinear.IsBalloon = true;
            // 
            // ttQuadratic
            // 
            this.ttQuadratic.IsBalloon = true;
            // 
            // ttAbsolute
            // 
            this.ttAbsolute.IsBalloon = true;
            // 
            // ttRoot
            // 
            this.ttRoot.IsBalloon = true;
            // 
            // ttA
            // 
            this.ttA.IsBalloon = true;
            // 
            // ttK
            // 
            this.ttK.IsBalloon = true;
            // 
            // ttD
            // 
            this.ttD.IsBalloon = true;
            // 
            // ttC
            // 
            this.ttC.IsBalloon = true;
            // 
            // ttXmin
            // 
            this.ttXmin.IsBalloon = true;
            // 
            // NUDXmin
            // 
            this.NUDXmin.Location = new System.Drawing.Point(48, 35);
            this.NUDXmin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NUDXmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDXmin.Name = "NUDXmin";
            this.NUDXmin.Size = new System.Drawing.Size(74, 20);
            this.NUDXmin.TabIndex = 2;
            this.ttXmin.SetToolTip(this.NUDXmin, "Specify the minimum X value. ");
            this.NUDXmin.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // GBScale
            // 
            this.GBScale.Controls.Add(this.NUDYmin);
            this.GBScale.Controls.Add(this.NUDXmin);
            this.GBScale.Controls.Add(this.NUDYmax);
            this.GBScale.Controls.Add(this.lblYmin);
            this.GBScale.Controls.Add(this.NUDXmax);
            this.GBScale.Controls.Add(this.lblXmax);
            this.GBScale.Controls.Add(this.lblYmax);
            this.GBScale.Controls.Add(this.lblXmin);
            this.GBScale.Location = new System.Drawing.Point(12, 36);
            this.GBScale.Name = "GBScale";
            this.GBScale.Size = new System.Drawing.Size(128, 107);
            this.GBScale.TabIndex = 0;
            this.GBScale.TabStop = false;
            this.GBScale.Text = "Scale";
            // 
            // NUDYmin
            // 
            this.NUDYmin.Location = new System.Drawing.Point(48, 79);
            this.NUDYmin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NUDYmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUDYmin.Name = "NUDYmin";
            this.NUDYmin.Size = new System.Drawing.Size(74, 20);
            this.NUDYmin.TabIndex = 4;
            this.ttYmin.SetToolTip(this.NUDYmin, "Specify the minimum Y value. ");
            this.NUDYmin.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // NUDYmax
            // 
            this.NUDYmax.Location = new System.Drawing.Point(48, 58);
            this.NUDYmax.Name = "NUDYmax";
            this.NUDYmax.Size = new System.Drawing.Size(74, 20);
            this.NUDYmax.TabIndex = 3;
            this.ttYmax.SetToolTip(this.NUDYmax, "Specify the maximum Y value. ");
            this.NUDYmax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblYmin
            // 
            this.lblYmin.AutoSize = true;
            this.lblYmin.Location = new System.Drawing.Point(6, 86);
            this.lblYmin.Name = "lblYmin";
            this.lblYmin.Size = new System.Drawing.Size(36, 13);
            this.lblYmin.TabIndex = 13;
            this.lblYmin.Text = "Y min ";
            // 
            // NUDXmax
            // 
            this.NUDXmax.Location = new System.Drawing.Point(48, 13);
            this.NUDXmax.Name = "NUDXmax";
            this.NUDXmax.Size = new System.Drawing.Size(74, 20);
            this.NUDXmax.TabIndex = 1;
            this.ttXmax.SetToolTip(this.NUDXmax, "Specify the maximum X value. ");
            this.NUDXmax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblXmax
            // 
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(6, 20);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(36, 13);
            this.lblXmax.TabIndex = 10;
            this.lblXmax.Text = "X max";
            // 
            // lblYmax
            // 
            this.lblYmax.AutoSize = true;
            this.lblYmax.Location = new System.Drawing.Point(6, 65);
            this.lblYmax.Name = "lblYmax";
            this.lblYmax.Size = new System.Drawing.Size(36, 13);
            this.lblYmax.TabIndex = 12;
            this.lblYmax.Text = "Y max";
            // 
            // lblXmin
            // 
            this.lblXmin.AutoSize = true;
            this.lblXmin.Location = new System.Drawing.Point(6, 42);
            this.lblXmin.Name = "lblXmin";
            this.lblXmin.Size = new System.Drawing.Size(33, 13);
            this.lblXmin.TabIndex = 11;
            this.lblXmin.Text = "X min";
            // 
            // ttXmax
            // 
            this.ttXmax.IsBalloon = true;
            // 
            // ttYmax
            // 
            this.ttYmax.IsBalloon = true;
            // 
            // ttYmin
            // 
            this.ttYmin.IsBalloon = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 489);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(128, 23);
            this.btnDraw.TabIndex = 18;
            this.btnDraw.Text = "Draw";
            this.ttDraw.SetToolTip(this.btnDraw, "Click to draw the function. ");
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 518);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.ttReset.SetToolTip(this.btnReset, "Click to clear the Cartesian plane. ");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ttDraw
            // 
            this.ttDraw.IsBalloon = true;
            // 
            // ttReset
            // 
            this.ttReset.IsBalloon = true;
            // 
            // ttSine
            // 
            this.ttSine.IsBalloon = true;
            // 
            // ttCosine
            // 
            this.ttCosine.IsBalloon = true;
            // 
            // ttCubic
            // 
            this.ttCubic.IsBalloon = true;
            // 
            // ttProperties
            // 
            this.ttProperties.IsBalloon = true;
            // 
            // GBProperties
            // 
            this.GBProperties.Controls.Add(this.lblRangeAnswer);
            this.GBProperties.Controls.Add(this.lblDomainAnswer);
            this.GBProperties.Controls.Add(this.lblParentAnswer);
            this.GBProperties.Controls.Add(this.lblRange);
            this.GBProperties.Controls.Add(this.lblDomain);
            this.GBProperties.Controls.Add(this.lblParent);
            this.GBProperties.Location = new System.Drawing.Point(146, 445);
            this.GBProperties.Name = "GBProperties";
            this.GBProperties.Size = new System.Drawing.Size(400, 96);
            this.GBProperties.TabIndex = 18;
            this.GBProperties.TabStop = false;
            this.GBProperties.Text = "Properties";
            // 
            // lblRangeAnswer
            // 
            this.lblRangeAnswer.AutoSize = true;
            this.lblRangeAnswer.Location = new System.Drawing.Point(56, 66);
            this.lblRangeAnswer.Name = "lblRangeAnswer";
            this.lblRangeAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblRangeAnswer.TabIndex = 5;
            // 
            // lblDomainAnswer
            // 
            this.lblDomainAnswer.AutoSize = true;
            this.lblDomainAnswer.Location = new System.Drawing.Point(56, 45);
            this.lblDomainAnswer.Name = "lblDomainAnswer";
            this.lblDomainAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblDomainAnswer.TabIndex = 4;
            // 
            // lblParentAnswer
            // 
            this.lblParentAnswer.AutoSize = true;
            this.lblParentAnswer.Location = new System.Drawing.Point(91, 25);
            this.lblParentAnswer.Name = "lblParentAnswer";
            this.lblParentAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblParentAnswer.TabIndex = 3;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(6, 66);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(45, 13);
            this.lblRange.TabIndex = 2;
            this.lblRange.Text = "Range: ";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(6, 45);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(49, 13);
            this.lblDomain.TabIndex = 1;
            this.lblDomain.Text = "Domain: ";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(6, 25);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(88, 13);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "Parent Function: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 558);
            this.Controls.Add(this.GBProperties);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.GBScale);
            this.Controls.Add(this.GBParameters);
            this.Controls.Add(this.GBFunction);
            this.Controls.Add(this.PBFunction);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Function Application ";
            ((System.ComponentModel.ISupportInitialize)(this.PBFunction)).EndInit();
            this.GBFunction.ResumeLayout(false);
            this.GBFunction.PerformLayout();
            this.GBParameters.ResumeLayout(false);
            this.GBParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDXmin)).EndInit();
            this.GBScale.ResumeLayout(false);
            this.GBScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDYmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDXmax)).EndInit();
            this.GBProperties.ResumeLayout(false);
            this.GBProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBFunction;
        private System.Windows.Forms.GroupBox GBFunction;
        private System.Windows.Forms.RadioButton RBAbsolute;
        private System.Windows.Forms.RadioButton RBRoot;
        private System.Windows.Forms.RadioButton RBQuadratic;
        private System.Windows.Forms.RadioButton RBLinear;
        private System.Windows.Forms.GroupBox GBParameters;
        private System.Windows.Forms.NumericUpDown NUDc;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.NumericUpDown NUDd;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.NumericUpDown NUDk;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.NumericUpDown NUDa;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.ToolTip ttAbsolute;
        private System.Windows.Forms.ToolTip ttRoot;
        private System.Windows.Forms.ToolTip ttQuadratic;
        private System.Windows.Forms.ToolTip ttLinear;
        private System.Windows.Forms.ToolTip ttC;
        private System.Windows.Forms.ToolTip ttD;
        private System.Windows.Forms.ToolTip ttK;
        private System.Windows.Forms.ToolTip ttA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttXmin;
        private System.Windows.Forms.GroupBox GBScale;
        private System.Windows.Forms.NumericUpDown NUDYmin;
        private System.Windows.Forms.NumericUpDown NUDXmin;
        private System.Windows.Forms.NumericUpDown NUDYmax;
        private System.Windows.Forms.Label lblYmin;
        private System.Windows.Forms.NumericUpDown NUDXmax;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.Label lblYmax;
        private System.Windows.Forms.Label lblXmin;
        private System.Windows.Forms.ToolTip ttXmax;
        private System.Windows.Forms.ToolTip ttYmax;
        private System.Windows.Forms.ToolTip ttYmin;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ToolTip ttDraw;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip ttReset;
        private System.Windows.Forms.ColorDialog CDLineColor;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knowingFunctionParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dParameterToolStripMenuItem;
        private System.Windows.Forms.RadioButton RBCubic;
        private System.Windows.Forms.RadioButton RBSine;
        private System.Windows.Forms.RadioButton RBCosine;
        private System.Windows.Forms.ToolTip ttSine;
        private System.Windows.Forms.ToolTip ttCosine;
        private System.Windows.Forms.ToolTip ttCubic;
        private System.Windows.Forms.ToolTip ttProperties;
        private System.Windows.Forms.GroupBox GBProperties;
        private System.Windows.Forms.Label lblRangeAnswer;
        private System.Windows.Forms.Label lblDomainAnswer;
        private System.Windows.Forms.Label lblParentAnswer;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblParent;
    }
}

