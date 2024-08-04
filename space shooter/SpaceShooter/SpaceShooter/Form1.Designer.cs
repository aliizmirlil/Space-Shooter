
namespace SpaceShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBigTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.level_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBigTimer
            // 
            this.MoveBigTimer.Enabled = true;
            this.MoveBigTimer.Interval = 10;
            this.MoveBigTimer.Tick += new System.EventHandler(this.MoveBigTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // MoveMunitionTimer
            // 
            this.MoveMunitionTimer.Enabled = true;
            this.MoveMunitionTimer.Interval = 20;
            this.MoveMunitionTimer.Tick += new System.EventHandler(this.MoveMunitionTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(199, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "LABEL1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 16.2F);
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(167, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Replay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(167, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // level_lbl
            // 
            this.level_lbl.AutoSize = true;
            this.level_lbl.BackColor = System.Drawing.Color.Transparent;
            this.level_lbl.Font = new System.Drawing.Font("Baskerville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.level_lbl.ForeColor = System.Drawing.Color.Gold;
            this.level_lbl.Location = new System.Drawing.Point(438, 9);
            this.level_lbl.Name = "level_lbl";
            this.level_lbl.Size = new System.Drawing.Size(97, 25);
            this.level_lbl.TabIndex = 4;
            this.level_lbl.Text = "LEVEL: ";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.score_lbl.Font = new System.Drawing.Font("Baskerville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_lbl.ForeColor = System.Drawing.Color.Gold;
            this.score_lbl.Location = new System.Drawing.Point(12, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(100, 25);
            this.score_lbl.TabIndex = 5;
            this.score_lbl.Text = "SCORE: ";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.scorelbl.ForeColor = System.Drawing.Color.Gold;
            this.scorelbl.Location = new System.Drawing.Point(102, 8);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(0, 24);
            this.scorelbl.TabIndex = 6;
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.levellbl.ForeColor = System.Drawing.Color.Gold;
            this.levellbl.Location = new System.Drawing.Point(525, 8);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(0, 24);
            this.levellbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.level_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBigTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label level_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levellbl;
    }
}

