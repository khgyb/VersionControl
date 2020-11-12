namespace ssp7wq_gyak08
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_car = new System.Windows.Forms.Button();
            this.btn_ball = new System.Windows.Forms.Button();
            this.lbl_next = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btn_color);
            this.mainPanel.Controls.Add(this.lbl_next);
            this.mainPanel.Controls.Add(this.btn_ball);
            this.mainPanel.Controls.Add(this.btn_car);
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(793, 442);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_car
            // 
            this.btn_car.Location = new System.Drawing.Point(36, 23);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(96, 50);
            this.btn_car.TabIndex = 0;
            this.btn_car.Text = "CAR";
            this.btn_car.UseVisualStyleBackColor = true;
            this.btn_car.Click += new System.EventHandler(this.btn_car_Click);
            // 
            // btn_ball
            // 
            this.btn_ball.Location = new System.Drawing.Point(182, 23);
            this.btn_ball.Name = "btn_ball";
            this.btn_ball.Size = new System.Drawing.Size(96, 50);
            this.btn_ball.TabIndex = 1;
            this.btn_ball.Text = "BALL";
            this.btn_ball.UseVisualStyleBackColor = true;
            this.btn_ball.Click += new System.EventHandler(this.btn_ball_Click);
            // 
            // lbl_next
            // 
            this.lbl_next.AutoSize = true;
            this.lbl_next.Location = new System.Drawing.Point(390, 40);
            this.lbl_next.Name = "lbl_next";
            this.lbl_next.Size = new System.Drawing.Size(89, 17);
            this.lbl_next.TabIndex = 2;
            this.lbl_next.Text = "Coming next:";
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Red;
            this.btn_color.Location = new System.Drawing.Point(182, 79);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(96, 23);
            this.btn_color.TabIndex = 3;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lbl_next;
        private System.Windows.Forms.Button btn_ball;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.Button btn_color;
    }
}

