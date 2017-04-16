namespace TeachMe
{
    partial class TeachMe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabInsert = new System.Windows.Forms.TabPage();
            this.TextDefToInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.TextWordToInsert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabTest = new System.Windows.Forms.TabPage();
            this.NumericNumOfWords = new System.Windows.Forms.NumericUpDown();
            this.LabelTotalWordsLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextDefinition = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonReveal = new System.Windows.Forms.Button();
            this.TextGuess = new System.Windows.Forms.TextBox();
            this.LabelWord = new System.Windows.Forms.Label();
            this.ButtonStartTest = new System.Windows.Forms.Button();
            this.TabRevertTest = new System.Windows.Forms.TabPage();
            this.NumericRevertNumOfWords = new System.Windows.Forms.NumericUpDown();
            this.TotalWordsLeftDef = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonDeleteWord = new System.Windows.Forms.Button();
            this.TextAnswerWord = new System.Windows.Forms.TextBox();
            this.ButtonNextDef = new System.Windows.Forms.Button();
            this.ButtonRevealWord = new System.Windows.Forms.Button();
            this.TextWordGuess = new System.Windows.Forms.TextBox();
            this.TextDefTest = new System.Windows.Forms.TextBox();
            this.ButtonStartRevertTest = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabInsert.SuspendLayout();
            this.TabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNumOfWords)).BeginInit();
            this.TabRevertTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRevertNumOfWords)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabInsert);
            this.tabControl1.Controls.Add(this.TabTest);
            this.tabControl1.Controls.Add(this.TabRevertTest);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(279, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // TabInsert
            // 
            this.TabInsert.BackColor = System.Drawing.SystemColors.Control;
            this.TabInsert.Controls.Add(this.TextDefToInsert);
            this.TabInsert.Controls.Add(this.label2);
            this.TabInsert.Controls.Add(this.ButtonInsert);
            this.TabInsert.Controls.Add(this.TextWordToInsert);
            this.TabInsert.Controls.Add(this.label1);
            this.TabInsert.Location = new System.Drawing.Point(4, 27);
            this.TabInsert.Name = "TabInsert";
            this.TabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.TabInsert.Size = new System.Drawing.Size(271, 325);
            this.TabInsert.TabIndex = 0;
            this.TabInsert.Text = "Insert";
            // 
            // TextDefToInsert
            // 
            this.TextDefToInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextDefToInsert.Location = new System.Drawing.Point(6, 64);
            this.TextDefToInsert.Multiline = true;
            this.TextDefToInsert.Name = "TextDefToInsert";
            this.TextDefToInsert.Size = new System.Drawing.Size(259, 147);
            this.TextDefToInsert.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Definition:";
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonInsert.Location = new System.Drawing.Point(6, 217);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(259, 33);
            this.ButtonInsert.TabIndex = 2;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // TextWordToInsert
            // 
            this.TextWordToInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextWordToInsert.Location = new System.Drawing.Point(67, 6);
            this.TextWordToInsert.Name = "TextWordToInsert";
            this.TextWordToInsert.Size = new System.Drawing.Size(198, 26);
            this.TextWordToInsert.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word :";
            // 
            // TabTest
            // 
            this.TabTest.BackColor = System.Drawing.SystemColors.Control;
            this.TabTest.Controls.Add(this.NumericNumOfWords);
            this.TabTest.Controls.Add(this.LabelTotalWordsLeft);
            this.TabTest.Controls.Add(this.label3);
            this.TabTest.Controls.Add(this.TextDefinition);
            this.TabTest.Controls.Add(this.ButtonDelete);
            this.TabTest.Controls.Add(this.ButtonNext);
            this.TabTest.Controls.Add(this.ButtonReveal);
            this.TabTest.Controls.Add(this.TextGuess);
            this.TabTest.Controls.Add(this.LabelWord);
            this.TabTest.Controls.Add(this.ButtonStartTest);
            this.TabTest.Location = new System.Drawing.Point(4, 27);
            this.TabTest.Name = "TabTest";
            this.TabTest.Padding = new System.Windows.Forms.Padding(3);
            this.TabTest.Size = new System.Drawing.Size(271, 325);
            this.TabTest.TabIndex = 1;
            this.TabTest.Text = "Test";
            // 
            // NumericNumOfWords
            // 
            this.NumericNumOfWords.Location = new System.Drawing.Point(219, 6);
            this.NumericNumOfWords.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericNumOfWords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericNumOfWords.Name = "NumericNumOfWords";
            this.NumericNumOfWords.Size = new System.Drawing.Size(46, 24);
            this.NumericNumOfWords.TabIndex = 9;
            this.NumericNumOfWords.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelTotalWordsLeft
            // 
            this.LabelTotalWordsLeft.AutoSize = true;
            this.LabelTotalWordsLeft.Location = new System.Drawing.Point(232, 293);
            this.LabelTotalWordsLeft.Name = "LabelTotalWordsLeft";
            this.LabelTotalWordsLeft.Size = new System.Drawing.Size(16, 18);
            this.LabelTotalWordsLeft.TabIndex = 8;
            this.LabelTotalWordsLeft.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(137, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Words Left :";
            // 
            // TextDefinition
            // 
            this.TextDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextDefinition.Location = new System.Drawing.Point(3, 205);
            this.TextDefinition.Multiline = true;
            this.TextDefinition.Name = "TextDefinition";
            this.TextDefinition.ReadOnly = true;
            this.TextDefinition.Size = new System.Drawing.Size(262, 74);
            this.TextDefinition.TabIndex = 6;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDelete.Location = new System.Drawing.Point(6, 285);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(125, 34);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete Word";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonNext.Location = new System.Drawing.Point(137, 173);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(128, 26);
            this.ButtonNext.TabIndex = 3;
            this.ButtonNext.Text = "Next Word";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonReveal
            // 
            this.ButtonReveal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonReveal.Location = new System.Drawing.Point(2, 173);
            this.ButtonReveal.Name = "ButtonReveal";
            this.ButtonReveal.Size = new System.Drawing.Size(129, 26);
            this.ButtonReveal.TabIndex = 2;
            this.ButtonReveal.Text = "Reveal";
            this.ButtonReveal.UseVisualStyleBackColor = true;
            this.ButtonReveal.Click += new System.EventHandler(this.ButtonReveal_Click);
            // 
            // TextGuess
            // 
            this.TextGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextGuess.Location = new System.Drawing.Point(6, 71);
            this.TextGuess.Multiline = true;
            this.TextGuess.Name = "TextGuess";
            this.TextGuess.Size = new System.Drawing.Size(262, 96);
            this.TextGuess.TabIndex = 1;
            // 
            // LabelWord
            // 
            this.LabelWord.AutoSize = true;
            this.LabelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelWord.Location = new System.Drawing.Point(6, 35);
            this.LabelWord.Name = "LabelWord";
            this.LabelWord.Size = new System.Drawing.Size(108, 29);
            this.LabelWord.TabIndex = 5;
            this.LabelWord.Text = "*WORD*";
            // 
            // ButtonStartTest
            // 
            this.ButtonStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonStartTest.Location = new System.Drawing.Point(6, 6);
            this.ButtonStartTest.Name = "ButtonStartTest";
            this.ButtonStartTest.Size = new System.Drawing.Size(208, 26);
            this.ButtonStartTest.TabIndex = 0;
            this.ButtonStartTest.Text = "Start Test";
            this.ButtonStartTest.UseVisualStyleBackColor = true;
            this.ButtonStartTest.Click += new System.EventHandler(this.ButtonStartTest_Click);
            // 
            // TabRevertTest
            // 
            this.TabRevertTest.BackColor = System.Drawing.SystemColors.Control;
            this.TabRevertTest.Controls.Add(this.NumericRevertNumOfWords);
            this.TabRevertTest.Controls.Add(this.TotalWordsLeftDef);
            this.TabRevertTest.Controls.Add(this.label4);
            this.TabRevertTest.Controls.Add(this.ButtonDeleteWord);
            this.TabRevertTest.Controls.Add(this.TextAnswerWord);
            this.TabRevertTest.Controls.Add(this.ButtonNextDef);
            this.TabRevertTest.Controls.Add(this.ButtonRevealWord);
            this.TabRevertTest.Controls.Add(this.TextWordGuess);
            this.TabRevertTest.Controls.Add(this.TextDefTest);
            this.TabRevertTest.Controls.Add(this.ButtonStartRevertTest);
            this.TabRevertTest.Location = new System.Drawing.Point(4, 27);
            this.TabRevertTest.Name = "TabRevertTest";
            this.TabRevertTest.Size = new System.Drawing.Size(271, 325);
            this.TabRevertTest.TabIndex = 2;
            this.TabRevertTest.Text = "Test2";
            // 
            // NumericRevertNumOfWords
            // 
            this.NumericRevertNumOfWords.Location = new System.Drawing.Point(219, 8);
            this.NumericRevertNumOfWords.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRevertNumOfWords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericRevertNumOfWords.Name = "NumericRevertNumOfWords";
            this.NumericRevertNumOfWords.Size = new System.Drawing.Size(46, 24);
            this.NumericRevertNumOfWords.TabIndex = 9;
            this.NumericRevertNumOfWords.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // TotalWordsLeftDef
            // 
            this.TotalWordsLeftDef.AutoSize = true;
            this.TotalWordsLeftDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TotalWordsLeftDef.Location = new System.Drawing.Point(233, 296);
            this.TotalWordsLeftDef.Name = "TotalWordsLeftDef";
            this.TotalWordsLeftDef.Size = new System.Drawing.Size(18, 20);
            this.TotalWordsLeftDef.TabIndex = 8;
            this.TotalWordsLeftDef.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(138, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Words Left :";
            // 
            // ButtonDeleteWord
            // 
            this.ButtonDeleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDeleteWord.Location = new System.Drawing.Point(3, 288);
            this.ButtonDeleteWord.Name = "ButtonDeleteWord";
            this.ButtonDeleteWord.Size = new System.Drawing.Size(129, 34);
            this.ButtonDeleteWord.TabIndex = 4;
            this.ButtonDeleteWord.Text = "Delete Word";
            this.ButtonDeleteWord.UseVisualStyleBackColor = true;
            this.ButtonDeleteWord.Click += new System.EventHandler(this.ButtonDeleteWord_Click);
            // 
            // TextAnswerWord
            // 
            this.TextAnswerWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextAnswerWord.Location = new System.Drawing.Point(4, 196);
            this.TextAnswerWord.Name = "TextAnswerWord";
            this.TextAnswerWord.ReadOnly = true;
            this.TextAnswerWord.Size = new System.Drawing.Size(261, 35);
            this.TextAnswerWord.TabIndex = 6;
            // 
            // ButtonNextDef
            // 
            this.ButtonNextDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonNextDef.Location = new System.Drawing.Point(138, 164);
            this.ButtonNextDef.Name = "ButtonNextDef";
            this.ButtonNextDef.Size = new System.Drawing.Size(128, 26);
            this.ButtonNextDef.TabIndex = 3;
            this.ButtonNextDef.Text = "Next Word";
            this.ButtonNextDef.UseVisualStyleBackColor = true;
            this.ButtonNextDef.Click += new System.EventHandler(this.ButtonNextDef_Click);
            // 
            // ButtonRevealWord
            // 
            this.ButtonRevealWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonRevealWord.Location = new System.Drawing.Point(4, 164);
            this.ButtonRevealWord.Name = "ButtonRevealWord";
            this.ButtonRevealWord.Size = new System.Drawing.Size(129, 26);
            this.ButtonRevealWord.TabIndex = 2;
            this.ButtonRevealWord.Text = "Reveal";
            this.ButtonRevealWord.UseVisualStyleBackColor = true;
            this.ButtonRevealWord.Click += new System.EventHandler(this.ButtonRevealWord_Click);
            // 
            // TextWordGuess
            // 
            this.TextWordGuess.Location = new System.Drawing.Point(4, 134);
            this.TextWordGuess.Name = "TextWordGuess";
            this.TextWordGuess.Size = new System.Drawing.Size(261, 24);
            this.TextWordGuess.TabIndex = 1;
            // 
            // TextDefTest
            // 
            this.TextDefTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextDefTest.Location = new System.Drawing.Point(4, 38);
            this.TextDefTest.Multiline = true;
            this.TextDefTest.Name = "TextDefTest";
            this.TextDefTest.ReadOnly = true;
            this.TextDefTest.Size = new System.Drawing.Size(262, 90);
            this.TextDefTest.TabIndex = 5;
            // 
            // ButtonStartRevertTest
            // 
            this.ButtonStartRevertTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonStartRevertTest.Location = new System.Drawing.Point(6, 6);
            this.ButtonStartRevertTest.Name = "ButtonStartRevertTest";
            this.ButtonStartRevertTest.Size = new System.Drawing.Size(208, 26);
            this.ButtonStartRevertTest.TabIndex = 0;
            this.ButtonStartRevertTest.Text = "Start Test";
            this.ButtonStartRevertTest.UseVisualStyleBackColor = true;
            this.ButtonStartRevertTest.Click += new System.EventHandler(this.ButtonStartRevertTest_Click);
            // 
            // TeachMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 365);
            this.Controls.Add(this.tabControl1);
            this.Name = "TeachMe";
            this.Text = "TeachMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachMe_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.TabInsert.ResumeLayout(false);
            this.TabInsert.PerformLayout();
            this.TabTest.ResumeLayout(false);
            this.TabTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNumOfWords)).EndInit();
            this.TabRevertTest.ResumeLayout(false);
            this.TabRevertTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRevertNumOfWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabInsert;
        private System.Windows.Forms.TabPage TabTest;
        private System.Windows.Forms.TextBox TextDefToInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.TextBox TextWordToInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.Button ButtonStartTest;
        private System.Windows.Forms.Label LabelTotalWordsLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextDefinition;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonReveal;
        private System.Windows.Forms.TextBox TextGuess;
        private System.Windows.Forms.TabPage TabRevertTest;
        private System.Windows.Forms.Label TotalWordsLeftDef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonDeleteWord;
        private System.Windows.Forms.TextBox TextAnswerWord;
        private System.Windows.Forms.Button ButtonNextDef;
        private System.Windows.Forms.Button ButtonRevealWord;
        private System.Windows.Forms.TextBox TextWordGuess;
        private System.Windows.Forms.TextBox TextDefTest;
        private System.Windows.Forms.Button ButtonStartRevertTest;
        private System.Windows.Forms.NumericUpDown NumericNumOfWords;
        private System.Windows.Forms.NumericUpDown NumericRevertNumOfWords;
    }
}

