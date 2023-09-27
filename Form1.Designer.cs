namespace Taschenrechner_V2
{
    partial class Taschenrechner
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
            buttonPlus.Location = new Point(249, 426);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(73, 83);
            buttonPlus.TabIndex = 2;
            buttonPlus.Text = "+";
            buttonPlus.TextAlign = ContentAlignment.TopCenter;
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.ControlText;
            buttonMinus.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus.ForeColor = Color.Cornsilk;
            buttonMinus.ImageAlign = ContentAlignment.MiddleRight;
            buttonMinus.Location = new Point(249, 337);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(73, 83);
            buttonMinus.TabIndex = 3;
            buttonMinus.Text = "-";
            buttonMinus.TextAlign = ContentAlignment.TopCenter;
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ControlText;
            buttonMultiply.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.ForeColor = Color.Cornsilk;
            buttonMultiply.ImageAlign = ContentAlignment.MiddleRight;
            buttonMultiply.Location = new Point(249, 248);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(73, 83);
            buttonMultiply.TabIndex = 4;
            buttonMultiply.Text = "x";
            buttonMultiply.TextAlign = ContentAlignment.TopCenter;
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ControlText;
            buttonDivide.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.ForeColor = Color.Cornsilk;
            buttonDivide.ImageAlign = ContentAlignment.MiddleRight;
            buttonDivide.Location = new Point(249, 159);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(73, 83);
            buttonDivide.TabIndex = 5;
            buttonDivide.Text = ":";
            buttonDivide.TextAlign = ContentAlignment.TopCenter;
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.WindowFrame;
            buttonEqual.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqual.ForeColor = Color.Cornsilk;
            buttonEqual.ImageAlign = ContentAlignment.MiddleRight;
            buttonEqual.Location = new Point(170, 426);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(73, 83);
            buttonEqual.TabIndex = 6;
            buttonEqual.Text = "=";
            buttonEqual.TextAlign = ContentAlignment.TopCenter;
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonComma
            // 
            buttonComma.BackColor = SystemColors.ControlLight;
            buttonComma.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComma.ForeColor = Color.Black;
            buttonComma.ImageAlign = ContentAlignment.MiddleRight;
            buttonComma.Location = new Point(12, 426);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(73, 83);
            buttonComma.TabIndex = 7;
            buttonComma.Text = ",";
            buttonComma.TextAlign = ContentAlignment.TopCenter;
            buttonComma.UseVisualStyleBackColor = false;
            buttonComma.Click += buttonComma_Click;
            // 
            // buttonZero
            // 
            buttonZero.BackColor = SystemColors.ControlLight;
            buttonZero.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZero.ForeColor = Color.Black;
            buttonZero.ImageAlign = ContentAlignment.MiddleRight;
            buttonZero.Location = new Point(91, 426);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(73, 83);
            buttonZero.TabIndex = 8;
            buttonZero.Text = "0";
            buttonZero.TextAlign = ContentAlignment.TopCenter;
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += buttonNumber_Click;
            // 
            // buttonThree
            // 
            buttonThree.BackColor = SystemColors.ControlLight;
            buttonThree.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThree.ForeColor = Color.Black;
            buttonThree.ImageAlign = ContentAlignment.MiddleRight;
            buttonThree.Location = new Point(170, 337);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(73, 83);
            buttonThree.TabIndex = 18;
            buttonThree.Text = "3";
            buttonThree.TextAlign = ContentAlignment.TopCenter;
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += buttonNumber_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.BackColor = SystemColors.ControlLight;
            buttonTwo.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTwo.ForeColor = Color.Black;
            buttonTwo.ImageAlign = ContentAlignment.MiddleRight;
            buttonTwo.Location = new Point(91, 337);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(73, 83);
            buttonTwo.TabIndex = 19;
            buttonTwo.Text = "2";
            buttonTwo.TextAlign = ContentAlignment.TopCenter;
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += buttonNumber_Click;
            // 
            // buttonNine
            // 
            buttonNine.BackColor = SystemColors.ControlLight;
            buttonNine.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNine.ForeColor = Color.Black;
            buttonNine.ImageAlign = ContentAlignment.MiddleRight;
            buttonNine.Location = new Point(170, 159);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(73, 83);
            buttonNine.TabIndex = 20;
            buttonNine.Text = "9";
            buttonNine.TextAlign = ContentAlignment.TopCenter;
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += buttonNumber_Click;
            // 
            // buttonEight
            // 
            buttonEight.BackColor = SystemColors.ControlLight;
            buttonEight.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEight.ForeColor = Color.Black;
            buttonEight.ImageAlign = ContentAlignment.MiddleRight;
            buttonEight.Location = new Point(91, 159);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(73, 83);
            buttonEight.TabIndex = 21;
            buttonEight.Text = "8";
            buttonEight.TextAlign = ContentAlignment.TopCenter;
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += buttonNumber_Click;
            // 
            // buttonFive
            // 
            buttonFive.BackColor = SystemColors.ControlLight;
            buttonFive.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFive.ForeColor = Color.Black;
            buttonFive.ImageAlign = ContentAlignment.MiddleRight;
            buttonFive.Location = new Point(91, 248);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(73, 83);
            buttonFive.TabIndex = 22;
            buttonFive.Text = "5";
            buttonFive.TextAlign = ContentAlignment.TopCenter;
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += buttonNumber_Click;
            // 
            // buttonOne
            // 
            buttonOne.BackColor = SystemColors.ControlLight;
            buttonOne.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOne.ForeColor = Color.Black;
            buttonOne.ImageAlign = ContentAlignment.MiddleRight;
            buttonOne.Location = new Point(12, 337);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(73, 83);
            buttonOne.TabIndex = 23;
            buttonOne.Text = "1";
            buttonOne.TextAlign = ContentAlignment.TopCenter;
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonNumber_Click;
            // 
            // buttonSix
            // 
            buttonSix.BackColor = SystemColors.ControlLight;
            buttonSix.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSix.ForeColor = Color.Black;
            buttonSix.ImageAlign = ContentAlignment.MiddleRight;
            buttonSix.Location = new Point(170, 248);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(73, 83);
            buttonSix.TabIndex = 24;
            buttonSix.Text = "6";
            buttonSix.TextAlign = ContentAlignment.TopCenter;
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += buttonNumber_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.BackColor = SystemColors.ControlLight;
            buttonSeven.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeven.ForeColor = Color.Black;
            buttonSeven.ImageAlign = ContentAlignment.MiddleRight;
            buttonSeven.Location = new Point(12, 159);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(73, 83);
            buttonSeven.TabIndex = 25;
            buttonSeven.Text = "7";
            buttonSeven.TextAlign = ContentAlignment.TopCenter;
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += buttonNumber_Click;
            // 
            // buttonFour
            // 
            buttonFour.BackColor = SystemColors.ControlLight;
            buttonFour.Font = new Font("Yu Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFour.ForeColor = Color.Black;
            buttonFour.ImageAlign = ContentAlignment.MiddleRight;
            buttonFour.Location = new Point(12, 248);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(73, 83);
            buttonFour.TabIndex = 26;
            buttonFour.Text = "4";
            buttonFour.TextAlign = ContentAlignment.TopCenter;
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += buttonNumber_Click;
            // 
            // fieldOutput
            // 
            fieldOutput.Enabled = false;
            fieldOutput.Location = new Point(12, 12);
            fieldOutput.Name = "fieldOutput";
            fieldOutput.ReadOnly = true;
            fieldOutput.Size = new Size(310, 23);
            fieldOutput.TabIndex = 27;
            fieldOutput.TextChanged += fieldOutput_TextChanged;
            // 
            // fieldInput
            // 
            fieldInput.Enabled = false;
            fieldInput.Location = new Point(12, 41);
            fieldInput.Name = "fieldInput";
            fieldInput.ReadOnly = true;
            fieldInput.Size = new Size(310, 51);
            fieldInput.TabIndex = 28;
            fieldInput.Text = "";
            fieldInput.TextChanged += fieldInput_TextChanged;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCE.ForeColor = Color.Black;
            buttonCE.Location = new Point(12, 113);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(152, 40);
            buttonCE.TabIndex = 29;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.ForeColor = Color.Black;
            buttonC.Location = new Point(170, 113);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(152, 40);
            buttonC.TabIndex = 30;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // Taschenrechner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(337, 521);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
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
            Name = "Taschenrechner";
            Text = "Taschenrechner";
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
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonFive;
        private Button buttonOne;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonFour;
        private TextBox fieldOutput;
        private RichTextBox fieldInput;
        private Button buttonTwo;
        private Button buttonCE;
        private Button buttonC;
    }
}