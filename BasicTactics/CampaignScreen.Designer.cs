namespace BasicTactics
{
    partial class CampaignScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstLevelButton = new System.Windows.Forms.Button();
            this.soonButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.secondLevelButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLevelButton
            // 
            this.firstLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLevelButton.Location = new System.Drawing.Point(200, 71);
            this.firstLevelButton.Name = "firstLevelButton";
            this.firstLevelButton.Size = new System.Drawing.Size(100, 40);
            this.firstLevelButton.TabIndex = 3;
            this.firstLevelButton.Text = "Initiation";
            this.firstLevelButton.UseVisualStyleBackColor = true;
            this.firstLevelButton.Click += new System.EventHandler(this.firstLevelButton_Click);
            // 
            // soonButton
            // 
            this.soonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soonButton.Location = new System.Drawing.Point(200, 163);
            this.soonButton.Name = "soonButton";
            this.soonButton.Size = new System.Drawing.Size(100, 40);
            this.soonButton.TabIndex = 4;
            this.soonButton.Text = "Coming Soon...";
            this.soonButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(500, 29);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Campaign";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(306, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 40);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Time:";
            // 
            // secondLevelButton
            // 
            this.secondLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLevelButton.Location = new System.Drawing.Point(200, 117);
            this.secondLevelButton.Name = "secondLevelButton";
            this.secondLevelButton.Size = new System.Drawing.Size(100, 40);
            this.secondLevelButton.TabIndex = 7;
            this.secondLevelButton.Text = "River Danger";
            this.secondLevelButton.UseVisualStyleBackColor = true;
            this.secondLevelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(306, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 40);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Time:";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(397, 257);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CampaignScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.secondLevelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.soonButton);
            this.Controls.Add(this.firstLevelButton);
            this.Name = "CampaignScreen";
            this.Size = new System.Drawing.Size(500, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstLevelButton;
        private System.Windows.Forms.Button soonButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button secondLevelButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button exitButton;
    }
}
