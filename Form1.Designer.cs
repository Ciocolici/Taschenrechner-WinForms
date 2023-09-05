namespace Taschenrechner_V2
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
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEqual = new Button();
            buttonComma = new Button();
            buttonZero = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonFive = new Button();
            buttonOne = new Button();
            buttonSix = new Button();
            buttonSeven = new Button();
            buttonFour = new Button();
            fieldOutput = new TextBox();
            fieldInput = new RichTextBox();
            buttonSpecial = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            SuspendLayout();
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = SystemColors.ControlText;
            buttonPlus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus.ForeColor = Color.Cornsilk;
            buttonPlus.ImageAlign = ContentAlignment.MiddleRight;
            buttonPlus.Location = new Point(263, 458);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(73, 83);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+";
            buttonPlus.TextAlign = ContentAlignment.TopCenter;
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += button1_Click_1;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.ControlText;
            buttonMinus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus.ForeColor = Color.Cornsilk;
            buttonMinus.ImageAlign = ContentAlignment.MiddleRight;
            buttonMinus.Location = new Point(263, 369);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(73, 83);
            buttonMinus.TabIndex = 3;
            buttonMinus.Text = "-";
            buttonMinus.TextAlign = ContentAlignment.TopCenter;
            buttonMinus.UseVisualStyleBackColor = false;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ControlText;
            buttonMultiply.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.ForeColor = Color.Cornsilk;
            buttonMultiply.ImageAlign = ContentAlignment.MiddleRight;
            buttonMultiply.Location = new Point(263, 276);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(73, 83);
            buttonMultiply.TabIndex = 4;
            buttonMultiply.Text = "x";
            buttonMultiply.TextAlign = ContentAlignment.TopCenter;
            buttonMultiply.UseVisualStyleBackColor = false;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ControlText;
            buttonDivide.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.ForeColor = Color.Cornsilk;
            buttonDivide.ImageAlign = ContentAlignment.MiddleRight;
            buttonDivide.Location = new Point(263, 187);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(73, 83);
            buttonDivide.TabIndex = 5;
            buttonDivide.Text = ":";
            buttonDivide.TextAlign = ContentAlignment.TopCenter;
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += button5_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.WindowFrame;
            buttonEqual.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqual.ForeColor = Color.Cornsilk;
            buttonEqual.ImageAlign = ContentAlignment.MiddleRight;
            buttonEqual.Location = new Point(170, 458);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(73, 83);
            buttonEqual.TabIndex = 6;
            buttonEqual.Text = "=";
            buttonEqual.TextAlign = ContentAlignment.TopCenter;
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += button6_Click;
            // 
            // buttonComma
            // 
            buttonComma.BackColor = SystemColors.ControlLight;
            buttonComma.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComma.ForeColor = Color.Black;
            buttonComma.ImageAlign = ContentAlignment.MiddleRight;
            buttonComma.Location = new Point(12, 458);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(73, 83);
            buttonComma.TabIndex = 7;
            buttonComma.Text = ".";
            buttonComma.TextAlign = ContentAlignment.TopCenter;
            buttonComma.UseVisualStyleBackColor = false;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = SystemColors.ControlLight;
            buttonZero.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZero.ForeColor = Color.Black;
            buttonZero.ImageAlign = ContentAlignment.MiddleRight;
            buttonZero.Location = new Point(91, 458);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(73, 83);
            buttonZero.TabIndex = 8;
            buttonZero.Text = "0";
            buttonZero.TextAlign = ContentAlignment.TopCenter;
            buttonZero.UseVisualStyleBackColor = false;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = SystemColors.ControlLight;
            buttonThree.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThree.ForeColor = Color.Black;
            buttonThree.ImageAlign = ContentAlignment.MiddleRight;
            buttonThree.Location = new Point(170, 369);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(73, 83);
            buttonThree.TabIndex = 18;
            buttonThree.Text = "3";
            buttonThree.TextAlign = ContentAlignment.TopCenter;
            buttonThree.UseVisualStyleBackColor = false;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = SystemColors.ControlLight;
            buttonTwo.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTwo.ForeColor = Color.Black;
            buttonTwo.ImageAlign = ContentAlignment.MiddleRight;
            buttonTwo.Location = new Point(91, 369);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(73, 83);
            buttonTwo.TabIndex = 19;
            buttonTwo.Text = "2";
            buttonTwo.TextAlign = ContentAlignment.TopCenter;
            buttonTwo.UseVisualStyleBackColor = false;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = SystemColors.ControlLight;
            buttonNine.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNine.ForeColor = Color.Black;
            buttonNine.ImageAlign = ContentAlignment.MiddleRight;
            buttonNine.Location = new Point(170, 187);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(73, 83);
            buttonNine.TabIndex = 20;
            buttonNine.Text = "9";
            buttonNine.TextAlign = ContentAlignment.TopCenter;
            buttonNine.UseVisualStyleBackColor = false;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = SystemColors.ControlLight;
            buttonEight.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEight.ForeColor = Color.Black;
            buttonEight.ImageAlign = ContentAlignment.MiddleRight;
            buttonEight.Location = new Point(91, 187);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(73, 83);
            buttonEight.TabIndex = 21;
            buttonEight.Text = "8";
            buttonEight.TextAlign = ContentAlignment.TopCenter;
            buttonEight.UseVisualStyleBackColor = false;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = SystemColors.ControlLight;
            buttonFive.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFive.ForeColor = Color.Black;
            buttonFive.ImageAlign = ContentAlignment.MiddleRight;
            buttonFive.Location = new Point(91, 276);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(73, 83);
            buttonFive.TabIndex = 22;
            buttonFive.Text = "5";
            buttonFive.TextAlign = ContentAlignment.TopCenter;
            buttonFive.UseVisualStyleBackColor = false;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = SystemColors.ControlLight;
            buttonOne.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOne.ForeColor = Color.Black;
            buttonOne.ImageAlign = ContentAlignment.MiddleRight;
            buttonOne.Location = new Point(12, 369);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(73, 83);
            buttonOne.TabIndex = 23;
            buttonOne.Text = "1";
            buttonOne.TextAlign = ContentAlignment.TopCenter;
            buttonOne.UseVisualStyleBackColor = false;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = SystemColors.ControlLight;
            buttonSix.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSix.ForeColor = Color.Black;
            buttonSix.ImageAlign = ContentAlignment.MiddleRight;
            buttonSix.Location = new Point(170, 276);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(73, 83);
            buttonSix.TabIndex = 24;
            buttonSix.Text = "6";
            buttonSix.TextAlign = ContentAlignment.TopCenter;
            buttonSix.UseVisualStyleBackColor = false;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = SystemColors.ControlLight;
            buttonSeven.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeven.ForeColor = Color.Black;
            buttonSeven.ImageAlign = ContentAlignment.MiddleRight;
            buttonSeven.Location = new Point(12, 187);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(73, 83);
            buttonSeven.TabIndex = 25;
            buttonSeven.Text = "7";
            buttonSeven.TextAlign = ContentAlignment.TopCenter;
            buttonSeven.UseVisualStyleBackColor = false;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = SystemColors.ControlLight;
            buttonFour.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFour.ForeColor = Color.Black;
            buttonFour.ImageAlign = ContentAlignment.MiddleRight;
            buttonFour.Location = new Point(12, 276);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(73, 83);
            buttonFour.TabIndex = 26;
            buttonFour.Text = "4";
            buttonFour.TextAlign = ContentAlignment.TopCenter;
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += button15_Click;
            // 
            // fieldOutput
            // 
            fieldOutput.Location = new Point(12, 12);
            fieldOutput.Name = "fieldOutput";
            fieldOutput.ReadOnly = true;
            fieldOutput.Size = new Size(324, 23);
            fieldOutput.TabIndex = 27;
            fieldOutput.TextChanged += textBox1_TextChanged;
            // 
            // fieldInput
            // 
            fieldInput.Location = new Point(12, 41);
            fieldInput.Name = "fieldInput";
            fieldInput.ReadOnly = true;
            fieldInput.Size = new Size(324, 51);
            fieldInput.TabIndex = 28;
            fieldInput.Text = "";
            // 
            // buttonSpecial
            // 
            buttonSpecial.BackColor = SystemColors.ControlLight;
            buttonSpecial.Font = new Font("Yu Gothic Medium", 25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSpecial.ForeColor = Color.Black;
            buttonSpecial.ImageAlign = ContentAlignment.MiddleRight;
            buttonSpecial.Location = new Point(12, 132);
            buttonSpecial.Name = "buttonSpecial";
            buttonSpecial.Size = new Size(73, 49);
            buttonSpecial.TabIndex = 29;
            buttonSpecial.Text = "%";
            buttonSpecial.TextAlign = ContentAlignment.TopCenter;
            buttonSpecial.UseVisualStyleBackColor = false;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = SystemColors.ControlLight;
            buttonCE.Font = new Font("Yu Gothic Medium", 25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCE.ForeColor = Color.Black;
            buttonCE.ImageAlign = ContentAlignment.MiddleRight;
            buttonCE.Location = new Point(91, 132);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(73, 49);
            buttonCE.TabIndex = 30;
            buttonCE.Text = "CE";
            buttonCE.TextAlign = ContentAlignment.TopCenter;
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += button18_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = SystemColors.ControlLight;
            buttonC.Font = new Font("Yu Gothic Medium", 25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.ForeColor = Color.Black;
            buttonC.ImageAlign = ContentAlignment.MiddleRight;
            buttonC.Location = new Point(170, 132);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(73, 49);
            buttonC.TabIndex = 31;
            buttonC.Text = "C";
            buttonC.TextAlign = ContentAlignment.TopCenter;
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(351, 553);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(buttonSpecial);
            Controls.Add(fieldInput);
            Controls.Add(fieldOutput);
            Controls.Add(buttonFour);
            Controls.Add(buttonSeven);
            Controls.Add(buttonSix);
            Controls.Add(buttonOne);
            Controls.Add(buttonFive);
            Controls.Add(buttonEight);
            Controls.Add(buttonNine);
            Controls.Add(buttonTwo);
            Controls.Add(buttonThree);
            Controls.Add(buttonZero);
            Controls.Add(buttonComma);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEqual;
        private Button buttonComma;
        private Button buttonZero;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonFive;
        private Button buttonOne;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonFour;
        private TextBox fieldOutput;
        private RichTextBox fieldInput;
        private Button buttonSpecial;
        private Button buttonCE;
        private Button buttonC;
    }
}