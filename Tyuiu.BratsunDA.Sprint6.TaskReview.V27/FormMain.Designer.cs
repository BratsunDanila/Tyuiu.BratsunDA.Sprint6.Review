
namespace Tyuiu.BratsunDA.Sprint6.TaskReview.V27
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonGenerate_BDA = new System.Windows.Forms.Button();
            this.dataGridViewMtrx_BDA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTask_BDA = new System.Windows.Forms.GroupBox();
            this.textBoxTaskInfo_BDA = new System.Windows.Forms.TextBox();
            this.panelInput_BDA = new System.Windows.Forms.Panel();
            this.groupBoxInput_BDA = new System.Windows.Forms.GroupBox();
            this.LabelRangeIDK_BDA = new System.Windows.Forms.Label();
            this.textBoxL_BDA = new System.Windows.Forms.TextBox();
            this.textBoxK_BDA = new System.Windows.Forms.TextBox();
            this.labelNumStr_BDA = new System.Windows.Forms.Label();
            this.textBoxNumStr_BDA = new System.Windows.Forms.TextBox();
            this.labelRange_BDA = new System.Windows.Forms.Label();
            this.labelSize_BDA = new System.Windows.Forms.Label();
            this.textBoxN2_BDA = new System.Windows.Forms.TextBox();
            this.textBoxN1_BDA = new System.Windows.Forms.TextBox();
            this.textBoxColumns_BDA = new System.Windows.Forms.TextBox();
            this.textBoxRows_BDA = new System.Windows.Forms.TextBox();
            this.panelButtons_BDA = new System.Windows.Forms.Panel();
            this.groupBoxButtons_BDA = new System.Windows.Forms.GroupBox();
            this.labelResult_BDA = new System.Windows.Forms.Label();
            this.textBoxResult_BDA = new System.Windows.Forms.TextBox();
            this.buttonResult_BDA = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMtrx_BDA)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxTask_BDA.SuspendLayout();
            this.panelInput_BDA.SuspendLayout();
            this.groupBoxInput_BDA.SuspendLayout();
            this.panelButtons_BDA.SuspendLayout();
            this.groupBoxButtons_BDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate_BDA
            // 
            this.buttonGenerate_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate_BDA.Location = new System.Drawing.Point(34, 36);
            this.buttonGenerate_BDA.Name = "buttonGenerate_BDA";
            this.buttonGenerate_BDA.Size = new System.Drawing.Size(127, 80);
            this.buttonGenerate_BDA.TabIndex = 0;
            this.buttonGenerate_BDA.Text = "Сгенерировать матрицу\r\n";
            this.buttonGenerate_BDA.UseVisualStyleBackColor = true;
            this.buttonGenerate_BDA.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewMtrx_BDA
            // 
            this.dataGridViewMtrx_BDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMtrx_BDA.ColumnHeadersVisible = false;
            this.dataGridViewMtrx_BDA.Location = new System.Drawing.Point(440, 0);
            this.dataGridViewMtrx_BDA.Name = "dataGridViewMtrx_BDA";
            this.dataGridViewMtrx_BDA.RowHeadersVisible = false;
            this.dataGridViewMtrx_BDA.Size = new System.Drawing.Size(445, 327);
            this.dataGridViewMtrx_BDA.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTask_BDA);
            this.panel1.Controls.Add(this.dataGridViewMtrx_BDA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 327);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxTask_BDA
            // 
            this.groupBoxTask_BDA.Controls.Add(this.textBoxTaskInfo_BDA);
            this.groupBoxTask_BDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BDA.Name = "groupBoxTask_BDA";
            this.groupBoxTask_BDA.Size = new System.Drawing.Size(440, 327);
            this.groupBoxTask_BDA.TabIndex = 2;
            this.groupBoxTask_BDA.TabStop = false;
            this.groupBoxTask_BDA.Text = "Условие";
            // 
            // textBoxTaskInfo_BDA
            // 
            this.textBoxTaskInfo_BDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskInfo_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTaskInfo_BDA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTaskInfo_BDA.Multiline = true;
            this.textBoxTaskInfo_BDA.Name = "textBoxTaskInfo_BDA";
            this.textBoxTaskInfo_BDA.ReadOnly = true;
            this.textBoxTaskInfo_BDA.Size = new System.Drawing.Size(427, 211);
            this.textBoxTaskInfo_BDA.TabIndex = 0;
            this.textBoxTaskInfo_BDA.Text = resources.GetString("textBoxTaskInfo_BDA.Text");
            // 
            // panelInput_BDA
            // 
            this.panelInput_BDA.Controls.Add(this.groupBoxInput_BDA);
            this.panelInput_BDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_BDA.Location = new System.Drawing.Point(0, 327);
            this.panelInput_BDA.Name = "panelInput_BDA";
            this.panelInput_BDA.Size = new System.Drawing.Size(440, 147);
            this.panelInput_BDA.TabIndex = 2;
            // 
            // groupBoxInput_BDA
            // 
            this.groupBoxInput_BDA.Controls.Add(this.LabelRangeIDK_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxL_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxK_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.labelNumStr_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxNumStr_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.labelRange_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.labelSize_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxN2_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxN1_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxColumns_BDA);
            this.groupBoxInput_BDA.Controls.Add(this.textBoxRows_BDA);
            this.groupBoxInput_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_BDA.Name = "groupBoxInput_BDA";
            this.groupBoxInput_BDA.Size = new System.Drawing.Size(440, 147);
            this.groupBoxInput_BDA.TabIndex = 0;
            this.groupBoxInput_BDA.TabStop = false;
            this.groupBoxInput_BDA.Text = "Ввод данных";
            // 
            // LabelRangeIDK_BDA
            // 
            this.LabelRangeIDK_BDA.AutoSize = true;
            this.LabelRangeIDK_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRangeIDK_BDA.Location = new System.Drawing.Point(224, 85);
            this.LabelRangeIDK_BDA.Name = "LabelRangeIDK_BDA";
            this.LabelRangeIDK_BDA.Size = new System.Drawing.Size(199, 18);
            this.LabelRangeIDK_BDA.TabIndex = 10;
            this.LabelRangeIDK_BDA.Text = "Диапазон индексов строки\r\n";
            // 
            // textBoxL_BDA
            // 
            this.textBoxL_BDA.Location = new System.Drawing.Point(318, 106);
            this.textBoxL_BDA.Name = "textBoxL_BDA";
            this.textBoxL_BDA.Size = new System.Drawing.Size(31, 20);
            this.textBoxL_BDA.TabIndex = 9;
            // 
            // textBoxK_BDA
            // 
            this.textBoxK_BDA.Location = new System.Drawing.Point(283, 106);
            this.textBoxK_BDA.Name = "textBoxK_BDA";
            this.textBoxK_BDA.Size = new System.Drawing.Size(29, 20);
            this.textBoxK_BDA.TabIndex = 8;
            // 
            // labelNumStr_BDA
            // 
            this.labelNumStr_BDA.AutoSize = true;
            this.labelNumStr_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumStr_BDA.Location = new System.Drawing.Point(12, 85);
            this.labelNumStr_BDA.Name = "labelNumStr_BDA";
            this.labelNumStr_BDA.Size = new System.Drawing.Size(168, 18);
            this.labelNumStr_BDA.TabIndex = 7;
            this.labelNumStr_BDA.Text = "Укажите номер строки\r\n";
            // 
            // textBoxNumStr_BDA
            // 
            this.textBoxNumStr_BDA.Location = new System.Drawing.Point(54, 106);
            this.textBoxNumStr_BDA.Name = "textBoxNumStr_BDA";
            this.textBoxNumStr_BDA.Size = new System.Drawing.Size(66, 20);
            this.textBoxNumStr_BDA.TabIndex = 6;
            // 
            // labelRange_BDA
            // 
            this.labelRange_BDA.AutoSize = true;
            this.labelRange_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRange_BDA.Location = new System.Drawing.Point(239, 36);
            this.labelRange_BDA.Name = "labelRange_BDA";
            this.labelRange_BDA.Size = new System.Drawing.Size(145, 18);
            this.labelRange_BDA.TabIndex = 5;
            this.labelRange_BDA.Text = "Диапазон значений\r\n";
            // 
            // labelSize_BDA
            // 
            this.labelSize_BDA.AutoSize = true;
            this.labelSize_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize_BDA.Location = new System.Drawing.Point(35, 36);
            this.labelSize_BDA.Name = "labelSize_BDA";
            this.labelSize_BDA.Size = new System.Drawing.Size(126, 18);
            this.labelSize_BDA.TabIndex = 4;
            this.labelSize_BDA.Text = "Размер матрицы\r\n";
            // 
            // textBoxN2_BDA
            // 
            this.textBoxN2_BDA.Location = new System.Drawing.Point(318, 57);
            this.textBoxN2_BDA.Name = "textBoxN2_BDA";
            this.textBoxN2_BDA.Size = new System.Drawing.Size(31, 20);
            this.textBoxN2_BDA.TabIndex = 3;
            // 
            // textBoxN1_BDA
            // 
            this.textBoxN1_BDA.Location = new System.Drawing.Point(283, 57);
            this.textBoxN1_BDA.Name = "textBoxN1_BDA";
            this.textBoxN1_BDA.Size = new System.Drawing.Size(29, 20);
            this.textBoxN1_BDA.TabIndex = 2;
            // 
            // textBoxColumns_BDA
            // 
            this.textBoxColumns_BDA.Location = new System.Drawing.Point(100, 57);
            this.textBoxColumns_BDA.Name = "textBoxColumns_BDA";
            this.textBoxColumns_BDA.Size = new System.Drawing.Size(37, 20);
            this.textBoxColumns_BDA.TabIndex = 1;
            // 
            // textBoxRows_BDA
            // 
            this.textBoxRows_BDA.Location = new System.Drawing.Point(56, 57);
            this.textBoxRows_BDA.Name = "textBoxRows_BDA";
            this.textBoxRows_BDA.Size = new System.Drawing.Size(38, 20);
            this.textBoxRows_BDA.TabIndex = 0;
            // 
            // panelButtons_BDA
            // 
            this.panelButtons_BDA.Controls.Add(this.groupBoxButtons_BDA);
            this.panelButtons_BDA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons_BDA.Location = new System.Drawing.Point(440, 327);
            this.panelButtons_BDA.Name = "panelButtons_BDA";
            this.panelButtons_BDA.Size = new System.Drawing.Size(445, 147);
            this.panelButtons_BDA.TabIndex = 3;
            // 
            // groupBoxButtons_BDA
            // 
            this.groupBoxButtons_BDA.Controls.Add(this.labelResult_BDA);
            this.groupBoxButtons_BDA.Controls.Add(this.textBoxResult_BDA);
            this.groupBoxButtons_BDA.Controls.Add(this.buttonResult_BDA);
            this.groupBoxButtons_BDA.Controls.Add(this.buttonGenerate_BDA);
            this.groupBoxButtons_BDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxButtons_BDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_BDA.Name = "groupBoxButtons_BDA";
            this.groupBoxButtons_BDA.Size = new System.Drawing.Size(445, 147);
            this.groupBoxButtons_BDA.TabIndex = 0;
            this.groupBoxButtons_BDA.TabStop = false;
            this.groupBoxButtons_BDA.Text = "Кнопочки и вывод";
            // 
            // labelResult_BDA
            // 
            this.labelResult_BDA.AutoSize = true;
            this.labelResult_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_BDA.Location = new System.Drawing.Point(334, 47);
            this.labelResult_BDA.Name = "labelResult_BDA";
            this.labelResult_BDA.Size = new System.Drawing.Size(50, 18);
            this.labelResult_BDA.TabIndex = 3;
            this.labelResult_BDA.Text = "Ответ\r\n";
            // 
            // textBoxResult_BDA
            // 
            this.textBoxResult_BDA.Location = new System.Drawing.Point(307, 68);
            this.textBoxResult_BDA.Name = "textBoxResult_BDA";
            this.textBoxResult_BDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_BDA.TabIndex = 2;
            // 
            // buttonResult_BDA
            // 
            this.buttonResult_BDA.Enabled = false;
            this.buttonResult_BDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult_BDA.Location = new System.Drawing.Point(167, 36);
            this.buttonResult_BDA.Name = "buttonResult_BDA";
            this.buttonResult_BDA.Size = new System.Drawing.Size(124, 80);
            this.buttonResult_BDA.TabIndex = 1;
            this.buttonResult_BDA.Text = "Выполнить вычисление";
            this.buttonResult_BDA.UseVisualStyleBackColor = true;
            this.buttonResult_BDA.Click += new System.EventHandler(this.buttonResult_BDA_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(440, 327);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 147);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 474);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelButtons_BDA);
            this.Controls.Add(this.panelInput_BDA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Task Review | Брацун Д.А.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMtrx_BDA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxTask_BDA.ResumeLayout(false);
            this.groupBoxTask_BDA.PerformLayout();
            this.panelInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.ResumeLayout(false);
            this.groupBoxInput_BDA.PerformLayout();
            this.panelButtons_BDA.ResumeLayout(false);
            this.groupBoxButtons_BDA.ResumeLayout(false);
            this.groupBoxButtons_BDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate_BDA;
        private System.Windows.Forms.DataGridView dataGridViewMtrx_BDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInput_BDA;
        private System.Windows.Forms.GroupBox groupBoxInput_BDA;
        private System.Windows.Forms.Panel panelButtons_BDA;
        private System.Windows.Forms.GroupBox groupBoxButtons_BDA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxTask_BDA;
        private System.Windows.Forms.Label LabelRangeIDK_BDA;
        private System.Windows.Forms.TextBox textBoxL_BDA;
        private System.Windows.Forms.TextBox textBoxK_BDA;
        private System.Windows.Forms.Label labelNumStr_BDA;
        private System.Windows.Forms.TextBox textBoxNumStr_BDA;
        private System.Windows.Forms.Label labelRange_BDA;
        private System.Windows.Forms.Label labelSize_BDA;
        private System.Windows.Forms.TextBox textBoxN2_BDA;
        private System.Windows.Forms.TextBox textBoxN1_BDA;
        private System.Windows.Forms.TextBox textBoxColumns_BDA;
        private System.Windows.Forms.TextBox textBoxRows_BDA;
        private System.Windows.Forms.Label labelResult_BDA;
        private System.Windows.Forms.TextBox textBoxResult_BDA;
        private System.Windows.Forms.Button buttonResult_BDA;
        private System.Windows.Forms.TextBox textBoxTaskInfo_BDA;
    }
}

