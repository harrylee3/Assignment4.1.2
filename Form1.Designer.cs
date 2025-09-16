namespace Assignment4._1._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            twoButton = new Button();
            divideButton = new Button();
            zeroButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            fiveButton = new Button();
            threeButton = new Button();
            sixButton = new Button();
            sevenButton = new Button();
            multiplyButton = new Button();
            addButton = new Button();
            subtractButton = new Button();
            fourButton = new Button();
            equalsButton = new Button();
            oneButton = new Button();
            resultTextBox = new TextBox();
            clearButton = new Button();
            SuspendLayout();
            // 
            // twoButton
            // 
            twoButton.Location = new Point(686, 479);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(150, 46);
            twoButton.TabIndex = 0;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += NumberButtonClicked;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(1069, 315);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(150, 46);
            divideButton.TabIndex = 1;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += OperationButtonClicked;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(686, 569);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(150, 46);
            zeroButton.TabIndex = 2;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += NumberButtonClicked;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(880, 315);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(150, 46);
            nineButton.TabIndex = 3;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += NumberButtonClicked;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(686, 315);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(150, 46);
            eightButton.TabIndex = 4;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += NumberButtonClicked;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(686, 394);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(150, 46);
            fiveButton.TabIndex = 5;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += NumberButtonClicked;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(880, 479);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(150, 46);
            threeButton.TabIndex = 6;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += NumberButtonClicked;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(880, 394);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(150, 46);
            sixButton.TabIndex = 7;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += NumberButtonClicked;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(482, 315);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(150, 46);
            sevenButton.TabIndex = 8;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += NumberButtonClicked;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(1069, 394);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(150, 46);
            multiplyButton.TabIndex = 9;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += OperationButtonClicked;
            // 
            // addButton
            // 
            addButton.Location = new Point(1069, 569);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 10;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += OperationButtonClicked;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(1069, 479);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(150, 46);
            subtractButton.TabIndex = 11;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += OperationButtonClicked;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(482, 394);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(150, 46);
            fourButton.TabIndex = 12;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += NumberButtonClicked;
            // 
            // equalsButton
            // 
            equalsButton.Location = new Point(880, 569);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(150, 46);
            equalsButton.TabIndex = 13;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += EqualsButtonClicked;
            // 
            // oneButton
            // 
            oneButton.Location = new Point(482, 479);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(150, 46);
            oneButton.TabIndex = 14;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += NumberButtonClicked;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(395, 261);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(927, 39);
            resultTextBox.TabIndex = 15;
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(482, 569);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 16;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButtonClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1669, 1371);
            Controls.Add(clearButton);
            Controls.Add(resultTextBox);
            Controls.Add(oneButton);
            Controls.Add(equalsButton);
            Controls.Add(fourButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(multiplyButton);
            Controls.Add(sevenButton);
            Controls.Add(sixButton);
            Controls.Add(threeButton);
            Controls.Add(fiveButton);
            Controls.Add(eightButton);
            Controls.Add(nineButton);
            Controls.Add(zeroButton);
            Controls.Add(divideButton);
            Controls.Add(twoButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button twoButton;
        private Button divideButton;
        private Button zeroButton;
        private Button nineButton;
        private Button eightButton;
        private Button fiveButton;
        private Button threeButton;
        private Button sixButton;
        private Button sevenButton;
        private Button multiplyButton;
        private Button addButton;
        private Button subtractButton;
        private Button fourButton;
        private Button equalsButton;
        private Button oneButton;
        private TextBox resultTextBox;
        private Button clearButton;
    }
}
