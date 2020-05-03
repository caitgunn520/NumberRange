namespace NumberRange
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
            this.title = new System.Windows.Forms.Label();
            this.inputLabelA = new System.Windows.Forms.Label();
            this.inputLabelB = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startNumInput = new System.Windows.Forms.TextBox();
            this.endNumInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(173, 57);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(167, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Number Range";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputLabelA
            // 
            this.inputLabelA.Location = new System.Drawing.Point(134, 150);
            this.inputLabelA.Name = "inputLabelA";
            this.inputLabelA.Size = new System.Drawing.Size(130, 23);
            this.inputLabelA.TabIndex = 1;
            this.inputLabelA.Text = "Enter starting number: ";
            // 
            // inputLabelB
            // 
            this.inputLabelB.Location = new System.Drawing.Point(134, 197);
            this.inputLabelB.Name = "inputLabelB";
            this.inputLabelB.Size = new System.Drawing.Size(130, 23);
            this.inputLabelB.TabIndex = 2;
            this.inputLabelB.Text = "Enter ending number:";
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(93, 345);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(327, 23);
            this.outputLabel.TabIndex = 3;
            // 
            // startNumInput
            // 
            this.startNumInput.Location = new System.Drawing.Point(279, 147);
            this.startNumInput.Name = "startNumInput";
            this.startNumInput.Size = new System.Drawing.Size(100, 20);
            this.startNumInput.TabIndex = 4;
            // 
            // endNumInput
            // 
            this.endNumInput.Location = new System.Drawing.Point(279, 194);
            this.endNumInput.Name = "endNumInput";
            this.endNumInput.Size = new System.Drawing.Size(100, 20);
            this.endNumInput.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(279, 240);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Show Values";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endNumInput);
            this.Controls.Add(this.startNumInput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabelB);
            this.Controls.Add(this.inputLabelA);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Number Range";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label inputLabelA;
        private System.Windows.Forms.Label inputLabelB;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox startNumInput;
        private System.Windows.Forms.TextBox endNumInput;
        private System.Windows.Forms.Button startButton;
    }
}

