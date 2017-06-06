namespace US_Population_App
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.averageDisplayLabel = new System.Windows.Forms.Label();
            this.greatestDisplayLabel = new System.Windows.Forms.Label();
            this.leastDisplayLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(134, 126);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(190, 212);
            this.listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "US Population App";
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(193, 74);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 2;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average annual change in population:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year with the greatest increase in population:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year with the least increase in population:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(134, 492);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // averageDisplayLabel
            // 
            this.averageDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageDisplayLabel.Location = new System.Drawing.Point(338, 368);
            this.averageDisplayLabel.Name = "averageDisplayLabel";
            this.averageDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.averageDisplayLabel.TabIndex = 8;
            this.averageDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greatestDisplayLabel
            // 
            this.greatestDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greatestDisplayLabel.Location = new System.Drawing.Point(338, 404);
            this.greatestDisplayLabel.Name = "greatestDisplayLabel";
            this.greatestDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.greatestDisplayLabel.TabIndex = 9;
            this.greatestDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leastDisplayLabel
            // 
            this.leastDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leastDisplayLabel.Location = new System.Drawing.Point(338, 443);
            this.leastDisplayLabel.Name = "leastDisplayLabel";
            this.leastDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.leastDisplayLabel.TabIndex = 10;
            this.leastDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(275, 492);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 550);
            this.Controls.Add(this.leastDisplayLabel);
            this.Controls.Add(this.greatestDisplayLabel);
            this.Controls.Add(this.averageDisplayLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "US Population App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label averageDisplayLabel;
        private System.Windows.Forms.Label greatestDisplayLabel;
        private System.Windows.Forms.Label leastDisplayLabel;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button exitButton;
    }
}

