namespace 打磚塊
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.label);
            this.playground.Controls.Add(this.p);
            this.playground.Controls.Add(this.score);
            this.playground.Controls.Add(this.Ball);
            this.playground.Controls.Add(this.Racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(745, 474);
            this.playground.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Hobo Std", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(233, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(223, 216);
            this.label.TabIndex = 4;
            this.label.Text = "Game Over\r\n\r\nF1-Restart\r\nEsc-Exit";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("華康儷特圓(P)", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p.Location = new System.Drawing.Point(128, 9);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(41, 33);
            this.p.TabIndex = 3;
            this.p.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("華康儷特圓(P)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(130, 30);
            this.score.TabIndex = 2;
            this.score.Text = "Score : ";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(52, 85);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Racket.Location = new System.Drawing.Point(242, 429);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(200, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 474);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label label;
    }
}

