namespace Tic_Tac_Toe
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture7 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.picture5 = new System.Windows.Forms.PictureBox();
            this.picture8 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture6 = new System.Windows.Forms.PictureBox();
            this.picture9 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerXwin = new System.Windows.Forms.Label();
            this.lblPlayerOwin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.picTurn = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnRestartScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLinkedln = new System.Windows.Forms.PictureBox();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.PicX = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTurn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTurn.Location = new System.Drawing.Point(733, 134);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(86, 28);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Player X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(731, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblWinner.Location = new System.Drawing.Point(733, 411);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(112, 28);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "in Prograss";
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.Transparent;
            this.picture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(115, 117);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(130, 124);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 4;
            this.picture1.TabStop = false;
            this.picture1.Tag = "?";
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // picture7
            // 
            this.picture7.BackColor = System.Drawing.Color.Transparent;
            this.picture7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture7.Image = ((System.Drawing.Image)(resources.GetObject("picture7.Image")));
            this.picture7.Location = new System.Drawing.Point(115, 413);
            this.picture7.Name = "picture7";
            this.picture7.Size = new System.Drawing.Size(130, 124);
            this.picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture7.TabIndex = 5;
            this.picture7.TabStop = false;
            this.picture7.Tag = "?";
            this.picture7.Click += new System.EventHandler(this.picture7_Click);
            // 
            // picture4
            // 
            this.picture4.BackColor = System.Drawing.Color.Transparent;
            this.picture4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture4.Image = ((System.Drawing.Image)(resources.GetObject("picture4.Image")));
            this.picture4.Location = new System.Drawing.Point(115, 269);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(130, 124);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture4.TabIndex = 6;
            this.picture4.TabStop = false;
            this.picture4.Tag = "?";
            this.picture4.Click += new System.EventHandler(this.picture4_Click);
            // 
            // picture5
            // 
            this.picture5.BackColor = System.Drawing.Color.Transparent;
            this.picture5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture5.Image = ((System.Drawing.Image)(resources.GetObject("picture5.Image")));
            this.picture5.Location = new System.Drawing.Point(291, 269);
            this.picture5.Name = "picture5";
            this.picture5.Size = new System.Drawing.Size(130, 124);
            this.picture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture5.TabIndex = 9;
            this.picture5.TabStop = false;
            this.picture5.Tag = "?";
            this.picture5.Click += new System.EventHandler(this.picture5_Click);
            // 
            // picture8
            // 
            this.picture8.BackColor = System.Drawing.Color.Transparent;
            this.picture8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture8.Image = ((System.Drawing.Image)(resources.GetObject("picture8.Image")));
            this.picture8.Location = new System.Drawing.Point(291, 413);
            this.picture8.Name = "picture8";
            this.picture8.Size = new System.Drawing.Size(130, 124);
            this.picture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture8.TabIndex = 8;
            this.picture8.TabStop = false;
            this.picture8.Tag = "?";
            this.picture8.Click += new System.EventHandler(this.picture8_Click);
            // 
            // picture2
            // 
            this.picture2.BackColor = System.Drawing.Color.Transparent;
            this.picture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture2.Image = ((System.Drawing.Image)(resources.GetObject("picture2.Image")));
            this.picture2.Location = new System.Drawing.Point(291, 118);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(130, 124);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 7;
            this.picture2.TabStop = false;
            this.picture2.Tag = "?";
            this.picture2.Click += new System.EventHandler(this.picture2_Click);
            // 
            // picture6
            // 
            this.picture6.BackColor = System.Drawing.Color.Transparent;
            this.picture6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture6.Image = ((System.Drawing.Image)(resources.GetObject("picture6.Image")));
            this.picture6.Location = new System.Drawing.Point(458, 269);
            this.picture6.Name = "picture6";
            this.picture6.Size = new System.Drawing.Size(130, 124);
            this.picture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture6.TabIndex = 12;
            this.picture6.TabStop = false;
            this.picture6.Tag = "?";
            this.picture6.Click += new System.EventHandler(this.picture6_Click);
            // 
            // picture9
            // 
            this.picture9.BackColor = System.Drawing.Color.Transparent;
            this.picture9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture9.Image = ((System.Drawing.Image)(resources.GetObject("picture9.Image")));
            this.picture9.Location = new System.Drawing.Point(458, 413);
            this.picture9.Name = "picture9";
            this.picture9.Size = new System.Drawing.Size(130, 124);
            this.picture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture9.TabIndex = 11;
            this.picture9.TabStop = false;
            this.picture9.Tag = "?";
            this.picture9.Click += new System.EventHandler(this.picture9_Click);
            // 
            // picture3
            // 
            this.picture3.BackColor = System.Drawing.Color.Transparent;
            this.picture3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture3.Image = ((System.Drawing.Image)(resources.GetObject("picture3.Image")));
            this.picture3.Location = new System.Drawing.Point(458, 119);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(130, 124);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture3.TabIndex = 10;
            this.picture3.TabStop = false;
            this.picture3.Tag = "?";
            this.picture3.Click += new System.EventHandler(this.picture3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(735, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Turn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(737, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(740, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Player O";
            // 
            // lblPlayerXwin
            // 
            this.lblPlayerXwin.AutoSize = true;
            this.lblPlayerXwin.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerXwin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayerXwin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPlayerXwin.Location = new System.Drawing.Point(894, 234);
            this.lblPlayerXwin.Name = "lblPlayerXwin";
            this.lblPlayerXwin.Size = new System.Drawing.Size(22, 25);
            this.lblPlayerXwin.TabIndex = 16;
            this.lblPlayerXwin.Text = "0";
            // 
            // lblPlayerOwin
            // 
            this.lblPlayerOwin.AutoSize = true;
            this.lblPlayerOwin.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOwin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPlayerOwin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlayerOwin.Location = new System.Drawing.Point(894, 321);
            this.lblPlayerOwin.Name = "lblPlayerOwin";
            this.lblPlayerOwin.Size = new System.Drawing.Size(22, 25);
            this.lblPlayerOwin.TabIndex = 17;
            this.lblPlayerOwin.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(731, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Draw";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDraw.ForeColor = System.Drawing.Color.White;
            this.lblDraw.Location = new System.Drawing.Point(893, 500);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(22, 25);
            this.lblDraw.TabIndex = 23;
            this.lblDraw.Text = "0";
            // 
            // picTurn
            // 
            this.picTurn.BackColor = System.Drawing.Color.Transparent;
            this.picTurn.Image = global::Tic_Tac_Toe.Properties.Resources.X;
            this.picTurn.Location = new System.Drawing.Point(865, 124);
            this.picTurn.Name = "picTurn";
            this.picTurn.Size = new System.Drawing.Size(53, 43);
            this.picTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTurn.TabIndex = 24;
            this.picTurn.TabStop = false;
            this.picTurn.Tag = "?";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(78, 576);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(240, 40);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRestartScore
            // 
            this.btnRestartScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRestartScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestartScore.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartScore.Location = new System.Drawing.Point(348, 576);
            this.btnRestartScore.Name = "btnRestartScore";
            this.btnRestartScore.Size = new System.Drawing.Size(240, 40);
            this.btnRestartScore.TabIndex = 26;
            this.btnRestartScore.Text = "Restart Score";
            this.btnRestartScore.UseVisualStyleBackColor = false;
            this.btnRestartScore.Click += new System.EventHandler(this.btnRestartScore_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(636, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 40);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLinkedln
            // 
            this.picLinkedln.BackColor = System.Drawing.Color.Black;
            this.picLinkedln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLinkedln.Image = global::Tic_Tac_Toe.Properties.Resources.Linked;
            this.picLinkedln.Location = new System.Drawing.Point(79, 651);
            this.picLinkedln.Name = "picLinkedln";
            this.picLinkedln.Size = new System.Drawing.Size(72, 74);
            this.picLinkedln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLinkedln.TabIndex = 28;
            this.picLinkedln.TabStop = false;
            this.picLinkedln.Tag = "?";
            this.picLinkedln.Click += new System.EventHandler(this.picLinkedln_Click);
            // 
            // picGithub
            // 
            this.picGithub.BackColor = System.Drawing.Color.Transparent;
            this.picGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGithub.Image = global::Tic_Tac_Toe.Properties.Resources.github_logo_icon_229278;
            this.picGithub.Location = new System.Drawing.Point(383, 651);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(72, 74);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGithub.TabIndex = 29;
            this.picGithub.TabStop = false;
            this.picGithub.Tag = "?";
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            // 
            // PicX
            // 
            this.PicX.BackColor = System.Drawing.Color.Transparent;
            this.PicX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicX.Image = global::Tic_Tac_Toe.Properties.Resources.X_icon_svg;
            this.PicX.Location = new System.Drawing.Point(697, 651);
            this.PicX.Name = "PicX";
            this.PicX.Size = new System.Drawing.Size(72, 74);
            this.PicX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicX.TabIndex = 30;
            this.PicX.TabStop = false;
            this.PicX.Tag = "?";
            this.PicX.Click += new System.EventHandler(this.PicX_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(194, 676);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Luai-Anwar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(795, 676);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "@7lo_ay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(501, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "@LoayCpp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.ChatGPT_Image_Jun_15__2026__09_21_22_PM;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(148, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 38);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tic Tac Toe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(149, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Challenge your friend";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Background_X_O;
            this.ClientSize = new System.Drawing.Size(963, 764);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PicX);
            this.Controls.Add(this.picGithub);
            this.Controls.Add(this.picLinkedln);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestartScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.picTurn);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPlayerOwin);
            this.Controls.Add(this.lblPlayerXwin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture6);
            this.Controls.Add(this.picture9);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture5);
            this.Controls.Add(this.picture8);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture7);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurn);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.PictureBox picture7;
        private System.Windows.Forms.PictureBox picture4;
        private System.Windows.Forms.PictureBox picture5;
        private System.Windows.Forms.PictureBox picture8;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture6;
        private System.Windows.Forms.PictureBox picture9;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerXwin;
        private System.Windows.Forms.Label lblPlayerOwin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.PictureBox picTurn;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnRestartScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLinkedln;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.PictureBox PicX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

