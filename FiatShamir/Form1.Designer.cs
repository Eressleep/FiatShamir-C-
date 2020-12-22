namespace FiatShamir
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCheckNum = new System.Windows.Forms.TextBox();
            this.btnNewGen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNewGenS = new System.Windows.Forms.Button();
            this.resultListView = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(21, 54);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(45, 20);
            this.textBoxN.TabIndex = 0;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(84, 54);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(45, 20);
            this.textBoxS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "s";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(150, 54);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(45, 20);
            this.textBoxV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(131, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "v";
            // 
            // textBoxCheckNum
            // 
            this.textBoxCheckNum.Location = new System.Drawing.Point(46, 104);
            this.textBoxCheckNum.Name = "textBoxCheckNum";
            this.textBoxCheckNum.Size = new System.Drawing.Size(43, 20);
            this.textBoxCheckNum.TabIndex = 6;
            this.textBoxCheckNum.Text = "5";
            // 
            // btnNewGen
            // 
            this.btnNewGen.Location = new System.Drawing.Point(3, 5);
            this.btnNewGen.Name = "btnNewGen";
            this.btnNewGen.Size = new System.Drawing.Size(98, 40);
            this.btnNewGen.TabIndex = 7;
            this.btnNewGen.Text = "Генерировать \r\nзаново";
            this.btnNewGen.UseVisualStyleBackColor = true;
            this.btnNewGen.Click += new System.EventHandler(this.btnNewGen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(120, 104);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNewGenS
            // 
            this.btnNewGenS.Location = new System.Drawing.Point(103, 13);
            this.btnNewGenS.Name = "btnNewGenS";
            this.btnNewGenS.Size = new System.Drawing.Size(98, 23);
            this.btnNewGenS.TabIndex = 11;
            this.btnNewGenS.Text = "Генерировать S";
            this.btnNewGenS.UseVisualStyleBackColor = true;
            this.btnNewGenS.Click += new System.EventHandler(this.btnNewGenS_Click);
            // 
            // resultListView
            // 
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ColumnHeader,
            this.columnHeader2});
            this.resultListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(207)));
            this.resultListView.Location = new System.Drawing.Point(204, 12);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(234, 208);
            this.resultListView.TabIndex = 12;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.DisplayIndex = 0;
            this.ColumnHeader.Text = "(x * v^e) % n";
            this.ColumnHeader.Width = 78;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "y^2 % n";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Совпадение";
            this.columnHeader2.Width = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(445, 236);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.btnNewGenS);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewGen);
            this.Controls.Add(this.textBoxCheckNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Фиата-Шамира";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCheckNum;
        private System.Windows.Forms.Button btnNewGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNewGenS;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

