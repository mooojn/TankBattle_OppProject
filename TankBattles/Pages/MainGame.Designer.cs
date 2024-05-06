namespace TankBattles
{
    partial class MainGame
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.objectCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 40;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.BackColor = System.Drawing.Color.Transparent;
            this.test.Dock = System.Windows.Forms.DockStyle.Left;
            this.test.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.SystemColors.Info;
            this.test.Location = new System.Drawing.Point(0, 0);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(172, 62);
            this.test.TabIndex = 0;
            this.test.Text = "Count";
            // 
            // objectCount
            // 
            this.objectCount.AutoSize = true;
            this.objectCount.BackColor = System.Drawing.Color.Transparent;
            this.objectCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.objectCount.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectCount.ForeColor = System.Drawing.SystemColors.Control;
            this.objectCount.Location = new System.Drawing.Point(172, 0);
            this.objectCount.Name = "objectCount";
            this.objectCount.Size = new System.Drawing.Size(56, 62);
            this.objectCount.TabIndex = 1;
            this.objectCount.Text = "0";
            this.objectCount.Click += new System.EventHandler(this.objectCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(1195, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Dock = System.Windows.Forms.DockStyle.Right;
            this.score.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.Window;
            this.score.Location = new System.Drawing.Point(1367, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(56, 62);
            this.score.TabIndex = 2;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TankBattles.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1423, 935);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.objectCount);
            this.Controls.Add(this.test);
            this.DoubleBuffered = true;
            this.Name = "MainGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label objectCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
    }
}

