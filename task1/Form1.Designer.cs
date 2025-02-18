namespace task1
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
            InputMatrixA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            InputMatrixB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            LabelMatrixRange = new Label();
            button3 = new Button();
            TextBoxResultatMatrix = new TextBox();
            TextBoxResultatMatrixA = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            InputNumGenMatrix1 = new NumericUpDown();
            InputNumGenMatrix2 = new NumericUpDown();
            button4 = new Button();
            textBoxReport = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix2).BeginInit();
            SuspendLayout();
            // 
            // InputMatrixA
            // 
            InputMatrixA.Location = new Point(12, 47);
            InputMatrixA.Multiline = true;
            InputMatrixA.Name = "InputMatrixA";
            InputMatrixA.ScrollBars = ScrollBars.Both;
            InputMatrixA.Size = new Size(254, 241);
            InputMatrixA.TabIndex = 0;
            InputMatrixA.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Матриця А";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 15);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Матриця В";
            // 
            // InputMatrixB
            // 
            InputMatrixB.Location = new Point(284, 47);
            InputMatrixB.Multiline = true;
            InputMatrixB.Name = "InputMatrixB";
            InputMatrixB.ScrollBars = ScrollBars.Both;
            InputMatrixB.Size = new Size(132, 241);
            InputMatrixB.TabIndex = 2;
            InputMatrixB.WordWrap = false;
            // 
            // button1
            // 
            button1.Location = new Point(237, 347);
            button1.Name = "button1";
            button1.Size = new Size(219, 47);
            button1.TabIndex = 4;
            button1.Text = "Знайти обернену матрицю";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 347);
            button2.Name = "button2";
            button2.Size = new Size(219, 47);
            button2.TabIndex = 6;
            button2.Text = "Пошук ранга матриці";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 411);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 7;
            label4.Text = "Ранг матриці";
            // 
            // LabelMatrixRange
            // 
            LabelMatrixRange.AutoSize = true;
            LabelMatrixRange.Location = new Point(118, 411);
            LabelMatrixRange.Name = "LabelMatrixRange";
            LabelMatrixRange.Size = new Size(17, 20);
            LabelMatrixRange.TabIndex = 8;
            LabelMatrixRange.Text = "0";
            // 
            // button3
            // 
            button3.Location = new Point(12, 454);
            button3.Name = "button3";
            button3.Size = new Size(172, 47);
            button3.TabIndex = 9;
            button3.Text = "Обчислити СЛАУ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TextBoxResultatMatrix
            // 
            TextBoxResultatMatrix.Location = new Point(274, 444);
            TextBoxResultatMatrix.Multiline = true;
            TextBoxResultatMatrix.Name = "TextBoxResultatMatrix";
            TextBoxResultatMatrix.ScrollBars = ScrollBars.Both;
            TextBoxResultatMatrix.Size = new Size(241, 183);
            TextBoxResultatMatrix.TabIndex = 10;
            TextBoxResultatMatrix.WordWrap = false;
            // 
            // TextBoxResultatMatrixA
            // 
            TextBoxResultatMatrixA.Location = new Point(533, 444);
            TextBoxResultatMatrixA.Multiline = true;
            TextBoxResultatMatrixA.Name = "TextBoxResultatMatrixA";
            TextBoxResultatMatrixA.ScrollBars = ScrollBars.Both;
            TextBoxResultatMatrixA.Size = new Size(271, 183);
            TextBoxResultatMatrixA.TabIndex = 11;
            TextBoxResultatMatrixA.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 421);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 12;
            label5.Text = "Результат обрахунку СЛАУ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 421);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 13;
            label6.Text = "Обернена матриця";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 47);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 14;
            label3.Text = "Рядки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(533, 47);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 15;
            label7.Text = "Стовпці";
            // 
            // InputNumGenMatrix1
            // 
            InputNumGenMatrix1.Location = new Point(445, 70);
            InputNumGenMatrix1.Name = "InputNumGenMatrix1";
            InputNumGenMatrix1.Size = new Size(61, 27);
            InputNumGenMatrix1.TabIndex = 17;
            InputNumGenMatrix1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // InputNumGenMatrix2
            // 
            InputNumGenMatrix2.Location = new Point(533, 70);
            InputNumGenMatrix2.Name = "InputNumGenMatrix2";
            InputNumGenMatrix2.Size = new Size(61, 27);
            InputNumGenMatrix2.TabIndex = 18;
            InputNumGenMatrix2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // button4
            // 
            button4.Location = new Point(445, 112);
            button4.Name = "button4";
            button4.Size = new Size(173, 47);
            button4.TabIndex = 19;
            button4.Text = "Згенерувати матрицю";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxReport
            // 
            textBoxReport.Location = new Point(824, 44);
            textBoxReport.Multiline = true;
            textBoxReport.Name = "textBoxReport";
            textBoxReport.ScrollBars = ScrollBars.Both;
            textBoxReport.Size = new Size(529, 583);
            textBoxReport.TabIndex = 20;
            textBoxReport.WordWrap = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(824, 15);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 21;
            label8.Text = "Звіт";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 654);
            Controls.Add(label8);
            Controls.Add(textBoxReport);
            Controls.Add(button4);
            Controls.Add(InputNumGenMatrix2);
            Controls.Add(InputNumGenMatrix1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TextBoxResultatMatrixA);
            Controls.Add(TextBoxResultatMatrix);
            Controls.Add(button3);
            Controls.Add(LabelMatrixRange);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(InputMatrixB);
            Controls.Add(label1);
            Controls.Add(InputMatrixA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix1).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputMatrixA;
        private Label label1;
        private Label label2;
        private TextBox InputMatrixB;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label LabelMatrixRange;
        private Button button3;
        private TextBox TextBoxResultatMatrix;
        private TextBox TextBoxResultatMatrixA;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label7;
        private NumericUpDown InputNumGenMatrix1;
        private NumericUpDown InputNumGenMatrix2;
        private Button button4;
        private TextBox textBoxReport;
        private Label label8;
    }
}
