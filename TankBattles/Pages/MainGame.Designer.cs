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
            this.objectCount = new System.Windows.Forms.Label();
            this.totalObjectCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 40;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // objectCount
            // 
            this.objectCount.AutoSize = true;
            this.objectCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.objectCount.Location = new System.Drawing.Point(1399, 0);
            this.objectCount.Name = "objectCount";
            this.objectCount.Size = new System.Drawing.Size(24, 25);
            this.objectCount.TabIndex = 0;
            this.objectCount.Text = "0";
            this.objectCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalObjectCount
            // 
            this.totalObjectCount.AutoSize = true;
            this.totalObjectCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalObjectCount.Location = new System.Drawing.Point(1330, 0);
            this.totalObjectCount.Name = "totalObjectCount";
            this.totalObjectCount.Size = new System.Drawing.Size(69, 25);
            this.totalObjectCount.TabIndex = 1;
            this.totalObjectCount.Text = "Count";
            this.totalObjectCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TankBattles.Properties.Resources.War2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1423, 935);
            this.Controls.Add(this.totalObjectCount);
            this.Controls.Add(this.objectCount);
            this.DoubleBuffered = true;
            this.Name = "MainGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label objectCount;
        private System.Windows.Forms.Label totalObjectCount;
    }
}

