namespace GUI
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.xScoreLabel = new System.Windows.Forms.Label();
            this.oScoreLabel = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.redDownPictureBox = new System.Windows.Forms.PictureBox();
            this.redUpPictureBox = new System.Windows.Forms.PictureBox();
            this.blueDownPictureBox = new System.Windows.Forms.PictureBox();
            this.blueUpPictureBox = new System.Windows.Forms.PictureBox();
            this.redBotLevelLabel = new System.Windows.Forms.Label();
            this.blueBotLevelLabel = new System.Windows.Forms.Label();
            this.oBotPictureBox = new System.Windows.Forms.PictureBox();
            this.xBotPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oThirdLabel = new System.Windows.Forms.Label();
            this.oSecoundLabel = new System.Windows.Forms.Label();
            this.oFirstLabel = new System.Windows.Forms.Label();
            this.xScoreDigitPanel = new System.Windows.Forms.Panel();
            this.xThirdLabel = new System.Windows.Forms.Label();
            this.xSecoundLabel = new System.Windows.Forms.Label();
            this.xFirstLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.optionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newGamePicturebox = new System.Windows.Forms.PictureBox();
            this.resetScorePicturebox = new System.Windows.Forms.PictureBox();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.C1pictureBox = new System.Windows.Forms.PictureBox();
            this.B1pictureBox = new System.Windows.Forms.PictureBox();
            this.A1pictureBox = new System.Windows.Forms.PictureBox();
            this.C2pictureBox = new System.Windows.Forms.PictureBox();
            this.B2pictureBox = new System.Windows.Forms.PictureBox();
            this.A2pictureBox = new System.Windows.Forms.PictureBox();
            this.C3pictureBox = new System.Windows.Forms.PictureBox();
            this.B3pictureBox = new System.Windows.Forms.PictureBox();
            this.A3pictureBox = new System.Windows.Forms.PictureBox();
            this.scorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redDownPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDownPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBotPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBotPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.xScoreDigitPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newGamePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetScorePicturebox)).BeginInit();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // xScoreLabel
            // 
            this.xScoreLabel.AutoSize = true;
            this.xScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.xScoreLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.xScoreLabel.Font = new System.Drawing.Font("MicraC", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.xScoreLabel.Location = new System.Drawing.Point(0, 0);
            this.xScoreLabel.Name = "xScoreLabel";
            this.xScoreLabel.Size = new System.Drawing.Size(96, 71);
            this.xScoreLabel.TabIndex = 1;
            this.xScoreLabel.Text = "X";
            this.xScoreLabel.Click += new System.EventHandler(this.xScoreLabel_Click);
            // 
            // oScoreLabel
            // 
            this.oScoreLabel.AutoSize = true;
            this.oScoreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.oScoreLabel.Font = new System.Drawing.Font("MicraC", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.oScoreLabel.Location = new System.Drawing.Point(279, 0);
            this.oScoreLabel.Name = "oScoreLabel";
            this.oScoreLabel.Size = new System.Drawing.Size(101, 71);
            this.oScoreLabel.TabIndex = 2;
            this.oScoreLabel.Text = "O";
            this.oScoreLabel.Click += new System.EventHandler(this.oScoreLabel_Click);
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.Transparent;
            this.scorePanel.Controls.Add(this.redDownPictureBox);
            this.scorePanel.Controls.Add(this.redUpPictureBox);
            this.scorePanel.Controls.Add(this.blueDownPictureBox);
            this.scorePanel.Controls.Add(this.blueUpPictureBox);
            this.scorePanel.Controls.Add(this.redBotLevelLabel);
            this.scorePanel.Controls.Add(this.blueBotLevelLabel);
            this.scorePanel.Controls.Add(this.oBotPictureBox);
            this.scorePanel.Controls.Add(this.xBotPictureBox);
            this.scorePanel.Controls.Add(this.panel1);
            this.scorePanel.Controls.Add(this.xScoreDigitPanel);
            this.scorePanel.Controls.Add(this.xScoreLabel);
            this.scorePanel.Controls.Add(this.oScoreLabel);
            this.scorePanel.Location = new System.Drawing.Point(66, 30);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(380, 112);
            this.scorePanel.TabIndex = 3;
            // 
            // redDownPictureBox
            // 
            this.redDownPictureBox.BackgroundImage = global::GUI.Properties.Resources.redDown;
            this.redDownPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redDownPictureBox.InitialImage = null;
            this.redDownPictureBox.Location = new System.Drawing.Point(241, 19);
            this.redDownPictureBox.Name = "redDownPictureBox";
            this.redDownPictureBox.Size = new System.Drawing.Size(25, 20);
            this.redDownPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redDownPictureBox.TabIndex = 15;
            this.redDownPictureBox.TabStop = false;
            this.redDownPictureBox.Click += new System.EventHandler(this.redDownPictureBox_Click);
            // 
            // redUpPictureBox
            // 
            this.redUpPictureBox.BackgroundImage = global::GUI.Properties.Resources.redUp;
            this.redUpPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redUpPictureBox.InitialImage = null;
            this.redUpPictureBox.Location = new System.Drawing.Point(241, 0);
            this.redUpPictureBox.Name = "redUpPictureBox";
            this.redUpPictureBox.Size = new System.Drawing.Size(25, 20);
            this.redUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redUpPictureBox.TabIndex = 14;
            this.redUpPictureBox.TabStop = false;
            this.redUpPictureBox.Click += new System.EventHandler(this.redUpPictureBox_Click);
            // 
            // blueDownPictureBox
            // 
            this.blueDownPictureBox.BackgroundImage = global::GUI.Properties.Resources.blueDown;
            this.blueDownPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blueDownPictureBox.InitialImage = null;
            this.blueDownPictureBox.Location = new System.Drawing.Point(108, 19);
            this.blueDownPictureBox.Name = "blueDownPictureBox";
            this.blueDownPictureBox.Size = new System.Drawing.Size(25, 20);
            this.blueDownPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueDownPictureBox.TabIndex = 13;
            this.blueDownPictureBox.TabStop = false;
            this.blueDownPictureBox.Click += new System.EventHandler(this.blueDownPictureBox_Click);
            // 
            // blueUpPictureBox
            // 
            this.blueUpPictureBox.BackgroundImage = global::GUI.Properties.Resources.blueUp;
            this.blueUpPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blueUpPictureBox.InitialImage = null;
            this.blueUpPictureBox.Location = new System.Drawing.Point(108, 0);
            this.blueUpPictureBox.Name = "blueUpPictureBox";
            this.blueUpPictureBox.Size = new System.Drawing.Size(25, 20);
            this.blueUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueUpPictureBox.TabIndex = 12;
            this.blueUpPictureBox.TabStop = false;
            this.blueUpPictureBox.Click += new System.EventHandler(this.blueUpPictureBox_Click);
            // 
            // redBotLevelLabel
            // 
            this.redBotLevelLabel.AutoSize = true;
            this.redBotLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redBotLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.redBotLevelLabel.Location = new System.Drawing.Point(274, 34);
            this.redBotLevelLabel.Name = "redBotLevelLabel";
            this.redBotLevelLabel.Size = new System.Drawing.Size(15, 17);
            this.redBotLevelLabel.TabIndex = 17;
            this.redBotLevelLabel.Text = "9";
            // 
            // blueBotLevelLabel
            // 
            this.blueBotLevelLabel.AutoSize = true;
            this.blueBotLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueBotLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.blueBotLevelLabel.Location = new System.Drawing.Point(86, 34);
            this.blueBotLevelLabel.Name = "blueBotLevelLabel";
            this.blueBotLevelLabel.Size = new System.Drawing.Size(15, 17);
            this.blueBotLevelLabel.TabIndex = 16;
            this.blueBotLevelLabel.Text = "9";
            // 
            // oBotPictureBox
            // 
            this.oBotPictureBox.InitialImage = null;
            this.oBotPictureBox.Location = new System.Drawing.Point(266, 3);
            this.oBotPictureBox.Name = "oBotPictureBox";
            this.oBotPictureBox.Size = new System.Drawing.Size(30, 30);
            this.oBotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oBotPictureBox.TabIndex = 11;
            this.oBotPictureBox.TabStop = false;
            this.oBotPictureBox.Click += new System.EventHandler(this.oBotPictureBox_Click);
            // 
            // xBotPictureBox
            // 
            this.xBotPictureBox.InitialImage = null;
            this.xBotPictureBox.Location = new System.Drawing.Point(78, 2);
            this.xBotPictureBox.Name = "xBotPictureBox";
            this.xBotPictureBox.Size = new System.Drawing.Size(30, 30);
            this.xBotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xBotPictureBox.TabIndex = 10;
            this.xBotPictureBox.TabStop = false;
            this.xBotPictureBox.Click += new System.EventHandler(this.xBotPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.oThirdLabel);
            this.panel1.Controls.Add(this.oSecoundLabel);
            this.panel1.Controls.Add(this.oFirstLabel);
            this.panel1.Location = new System.Drawing.Point(215, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 41);
            this.panel1.TabIndex = 9;
            // 
            // oThirdLabel
            // 
            this.oThirdLabel.AutoSize = true;
            this.oThirdLabel.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oThirdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.oThirdLabel.Location = new System.Drawing.Point(70, 4);
            this.oThirdLabel.Name = "oThirdLabel";
            this.oThirdLabel.Size = new System.Drawing.Size(43, 41);
            this.oThirdLabel.TabIndex = 7;
            this.oThirdLabel.Text = "0";
            this.oThirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oSecoundLabel
            // 
            this.oSecoundLabel.AutoSize = true;
            this.oSecoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.oSecoundLabel.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oSecoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.oSecoundLabel.Location = new System.Drawing.Point(35, 4);
            this.oSecoundLabel.Name = "oSecoundLabel";
            this.oSecoundLabel.Size = new System.Drawing.Size(43, 41);
            this.oSecoundLabel.TabIndex = 6;
            this.oSecoundLabel.Text = "0";
            this.oSecoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oFirstLabel
            // 
            this.oFirstLabel.AutoSize = true;
            this.oFirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.oFirstLabel.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oFirstLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.oFirstLabel.Location = new System.Drawing.Point(0, 4);
            this.oFirstLabel.Name = "oFirstLabel";
            this.oFirstLabel.Size = new System.Drawing.Size(43, 41);
            this.oFirstLabel.TabIndex = 5;
            this.oFirstLabel.Text = "0";
            this.oFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xScoreDigitPanel
            // 
            this.xScoreDigitPanel.BackColor = System.Drawing.Color.Transparent;
            this.xScoreDigitPanel.Controls.Add(this.xThirdLabel);
            this.xScoreDigitPanel.Controls.Add(this.xSecoundLabel);
            this.xScoreDigitPanel.Controls.Add(this.xFirstLabel);
            this.xScoreDigitPanel.Location = new System.Drawing.Point(55, 62);
            this.xScoreDigitPanel.Name = "xScoreDigitPanel";
            this.xScoreDigitPanel.Size = new System.Drawing.Size(112, 41);
            this.xScoreDigitPanel.TabIndex = 8;
            // 
            // xThirdLabel
            // 
            this.xThirdLabel.AutoSize = true;
            this.xThirdLabel.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xThirdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.xThirdLabel.Location = new System.Drawing.Point(70, 4);
            this.xThirdLabel.Name = "xThirdLabel";
            this.xThirdLabel.Size = new System.Drawing.Size(43, 41);
            this.xThirdLabel.TabIndex = 7;
            this.xThirdLabel.Text = "0";
            this.xThirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xSecoundLabel
            // 
            this.xSecoundLabel.AutoSize = true;
            this.xSecoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.xSecoundLabel.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xSecoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.xSecoundLabel.Location = new System.Drawing.Point(35, 4);
            this.xSecoundLabel.Name = "xSecoundLabel";
            this.xSecoundLabel.Size = new System.Drawing.Size(43, 41);
            this.xSecoundLabel.TabIndex = 6;
            this.xSecoundLabel.Text = "0";
            this.xSecoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xFirstLabel
            // 
            this.xFirstLabel.AutoSize = true;
            this.xFirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.xFirstLabel.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xFirstLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.xFirstLabel.Location = new System.Drawing.Point(0, 4);
            this.xFirstLabel.Name = "xFirstLabel";
            this.xFirstLabel.Size = new System.Drawing.Size(43, 41);
            this.xFirstLabel.TabIndex = 5;
            this.xFirstLabel.Text = "0";
            this.xFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.newGamePicturebox);
            this.optionsPanel.Controls.Add(this.resetScorePicturebox);
            this.optionsPanel.Location = new System.Drawing.Point(7, 529);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(105, 25);
            this.optionsPanel.TabIndex = 15;
            // 
            // newGamePicturebox
            // 
            this.newGamePicturebox.BackgroundImage = global::GUI.Properties.Resources.replay;
            this.newGamePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newGamePicturebox.Location = new System.Drawing.Point(10, 0);
            this.newGamePicturebox.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.newGamePicturebox.Name = "newGamePicturebox";
            this.newGamePicturebox.Size = new System.Drawing.Size(25, 25);
            this.newGamePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newGamePicturebox.TabIndex = 14;
            this.newGamePicturebox.TabStop = false;
            this.newGamePicturebox.Click += new System.EventHandler(this.newGamePicturebox_Click);
            // 
            // resetScorePicturebox
            // 
            this.resetScorePicturebox.BackgroundImage = global::GUI.Properties.Resources.trash;
            this.resetScorePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetScorePicturebox.Location = new System.Drawing.Point(45, 0);
            this.resetScorePicturebox.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.resetScorePicturebox.Name = "resetScorePicturebox";
            this.resetScorePicturebox.Size = new System.Drawing.Size(25, 25);
            this.resetScorePicturebox.TabIndex = 10;
            this.resetScorePicturebox.TabStop = false;
            this.resetScorePicturebox.Click += new System.EventHandler(this.ResetScorePicturebox_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tablePanel.BackgroundImage")));
            this.tablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel.Controls.Add(this.C1pictureBox);
            this.tablePanel.Controls.Add(this.B1pictureBox);
            this.tablePanel.Controls.Add(this.A1pictureBox);
            this.tablePanel.Controls.Add(this.C2pictureBox);
            this.tablePanel.Controls.Add(this.B2pictureBox);
            this.tablePanel.Controls.Add(this.A2pictureBox);
            this.tablePanel.Controls.Add(this.C3pictureBox);
            this.tablePanel.Controls.Add(this.B3pictureBox);
            this.tablePanel.Controls.Add(this.A3pictureBox);
            this.tablePanel.Location = new System.Drawing.Point(101, 191);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(320, 320);
            this.tablePanel.TabIndex = 0;
            // 
            // C1pictureBox
            // 
            this.C1pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C1pictureBox.Location = new System.Drawing.Point(220, 214);
            this.C1pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.C1pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.C1pictureBox.Name = "C1pictureBox";
            this.C1pictureBox.Size = new System.Drawing.Size(70, 70);
            this.C1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1pictureBox.TabIndex = 2;
            this.C1pictureBox.TabStop = false;
            this.C1pictureBox.Click += new System.EventHandler(this.C1pictureBox_Click);
            // 
            // B1pictureBox
            // 
            this.B1pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B1pictureBox.Location = new System.Drawing.Point(125, 214);
            this.B1pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.B1pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.B1pictureBox.Name = "B1pictureBox";
            this.B1pictureBox.Size = new System.Drawing.Size(70, 70);
            this.B1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B1pictureBox.TabIndex = 4;
            this.B1pictureBox.TabStop = false;
            this.B1pictureBox.Click += new System.EventHandler(this.B1pictureBox_Click);
            // 
            // A1pictureBox
            // 
            this.A1pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.A1pictureBox.Location = new System.Drawing.Point(27, 214);
            this.A1pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.A1pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.A1pictureBox.Name = "A1pictureBox";
            this.A1pictureBox.Size = new System.Drawing.Size(70, 70);
            this.A1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1pictureBox.TabIndex = 2;
            this.A1pictureBox.TabStop = false;
            this.A1pictureBox.Click += new System.EventHandler(this.A1pictureBox_Click);
            // 
            // C2pictureBox
            // 
            this.C2pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C2pictureBox.Location = new System.Drawing.Point(220, 118);
            this.C2pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.C2pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.C2pictureBox.Name = "C2pictureBox";
            this.C2pictureBox.Size = new System.Drawing.Size(70, 70);
            this.C2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2pictureBox.TabIndex = 2;
            this.C2pictureBox.TabStop = false;
            this.C2pictureBox.Click += new System.EventHandler(this.C2pictureBox_Click);
            // 
            // B2pictureBox
            // 
            this.B2pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B2pictureBox.Location = new System.Drawing.Point(125, 118);
            this.B2pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.B2pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.B2pictureBox.Name = "B2pictureBox";
            this.B2pictureBox.Size = new System.Drawing.Size(70, 70);
            this.B2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B2pictureBox.TabIndex = 3;
            this.B2pictureBox.TabStop = false;
            this.B2pictureBox.Click += new System.EventHandler(this.B2pictureBox_Click);
            // 
            // A2pictureBox
            // 
            this.A2pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.A2pictureBox.Location = new System.Drawing.Point(27, 118);
            this.A2pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.A2pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.A2pictureBox.Name = "A2pictureBox";
            this.A2pictureBox.Size = new System.Drawing.Size(70, 70);
            this.A2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2pictureBox.TabIndex = 2;
            this.A2pictureBox.TabStop = false;
            this.A2pictureBox.Click += new System.EventHandler(this.A2pictureBox_Click);
            // 
            // C3pictureBox
            // 
            this.C3pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C3pictureBox.Location = new System.Drawing.Point(220, 26);
            this.C3pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.C3pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.C3pictureBox.Name = "C3pictureBox";
            this.C3pictureBox.Size = new System.Drawing.Size(70, 70);
            this.C3pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3pictureBox.TabIndex = 2;
            this.C3pictureBox.TabStop = false;
            this.C3pictureBox.Click += new System.EventHandler(this.C3pictureBox_Click);
            // 
            // B3pictureBox
            // 
            this.B3pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B3pictureBox.Location = new System.Drawing.Point(125, 26);
            this.B3pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.B3pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.B3pictureBox.Name = "B3pictureBox";
            this.B3pictureBox.Size = new System.Drawing.Size(70, 70);
            this.B3pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B3pictureBox.TabIndex = 2;
            this.B3pictureBox.TabStop = false;
            this.B3pictureBox.Click += new System.EventHandler(this.B3pictureBox_Click);
            // 
            // A3pictureBox
            // 
            this.A3pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A3pictureBox.InitialImage = null;
            this.A3pictureBox.Location = new System.Drawing.Point(28, 26);
            this.A3pictureBox.MaximumSize = new System.Drawing.Size(70, 70);
            this.A3pictureBox.MinimumSize = new System.Drawing.Size(70, 70);
            this.A3pictureBox.Name = "A3pictureBox";
            this.A3pictureBox.Size = new System.Drawing.Size(70, 70);
            this.A3pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A3pictureBox.TabIndex = 1;
            this.A3pictureBox.TabStop = false;
            this.A3pictureBox.Click += new System.EventHandler(this.A3pictureBox_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.tablePanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(550, 600);
            this.MinimumSize = new System.Drawing.Size(550, 600);
            this.Name = "GameForm";
            this.Text = "Tic Tac Toe";
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redDownPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDownPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBotPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBotPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xScoreDigitPanel.ResumeLayout(false);
            this.xScoreDigitPanel.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newGamePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetScorePicturebox)).EndInit();
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.PictureBox C1pictureBox;
        private System.Windows.Forms.PictureBox B1pictureBox;
        private System.Windows.Forms.PictureBox A1pictureBox;
        private System.Windows.Forms.PictureBox C2pictureBox;
        private System.Windows.Forms.PictureBox B2pictureBox;
        private System.Windows.Forms.PictureBox A2pictureBox;
        private System.Windows.Forms.PictureBox C3pictureBox;
        private System.Windows.Forms.PictureBox B3pictureBox;
        private System.Windows.Forms.PictureBox A3pictureBox;
        private System.Windows.Forms.Label xScoreLabel;
        private System.Windows.Forms.Label oScoreLabel;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label xFirstLabel;
        private System.Windows.Forms.Label xThirdLabel;
        private System.Windows.Forms.Label xSecoundLabel;
        private System.Windows.Forms.Panel xScoreDigitPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label oThirdLabel;
        private System.Windows.Forms.Label oSecoundLabel;
        private System.Windows.Forms.Label oFirstLabel;
        private System.Windows.Forms.PictureBox resetScorePicturebox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox newGamePicturebox;
        private System.Windows.Forms.FlowLayoutPanel optionsPanel;
        private System.Windows.Forms.PictureBox oBotPictureBox;
        private System.Windows.Forms.PictureBox xBotPictureBox;
        private System.Windows.Forms.PictureBox blueUpPictureBox;
        private System.Windows.Forms.PictureBox blueDownPictureBox;
        private System.Windows.Forms.PictureBox redDownPictureBox;
        private System.Windows.Forms.PictureBox redUpPictureBox;
        private System.Windows.Forms.Label blueBotLevelLabel;
        private System.Windows.Forms.Label redBotLevelLabel;
    }
}

