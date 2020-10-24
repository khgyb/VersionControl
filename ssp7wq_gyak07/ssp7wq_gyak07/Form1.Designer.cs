namespace ssp7wq_gyak07
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
            this.b_start = new System.Windows.Forms.Button();
            this.b_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LastYearnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LastYearnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_start.Location = new System.Drawing.Point(838, 12);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(139, 37);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_browse
            // 
            this.b_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_browse.Location = new System.Drawing.Point(680, 12);
            this.b_browse.Name = "b_browse";
            this.b_browse.Size = new System.Drawing.Size(139, 37);
            this.b_browse.TabIndex = 1;
            this.b_browse.Text = "Browse";
            this.b_browse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Záróév";
            // 
            // LastYearnumericUpDown
            // 
            this.LastYearnumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastYearnumericUpDown.Location = new System.Drawing.Point(77, 18);
            this.LastYearnumericUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.LastYearnumericUpDown.Name = "LastYearnumericUpDown";
            this.LastYearnumericUpDown.Size = new System.Drawing.Size(68, 26);
            this.LastYearnumericUpDown.TabIndex = 3;
            this.LastYearnumericUpDown.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Népesség fájl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastYearnumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_browse);
            this.Controls.Add(this.b_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LastYearnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LastYearnumericUpDown;
        private System.Windows.Forms.Label label2;
    }
}

