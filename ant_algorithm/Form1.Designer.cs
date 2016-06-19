namespace ant_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_map = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chrt_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_set_values = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_iteration_count = new System.Windows.Forms.TextBox();
            this.txt_ant_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_map)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_length)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_map
            // 
            this.dgv_map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_map.Location = new System.Drawing.Point(6, 19);
            this.dgv_map.Name = "dgv_map";
            this.dgv_map.Size = new System.Drawing.Size(373, 316);
            this.dgv_map.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_map);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание карты";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(406, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 508);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chrt_length);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Длина найденного пути";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chrt_length
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_length.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt_length.Legends.Add(legend1);
            this.chrt_length.Location = new System.Drawing.Point(6, 6);
            this.chrt_length.Name = "chrt_length";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Length";
            this.chrt_length.Series.Add(series1);
            this.chrt_length.Size = new System.Drawing.Size(497, 470);
            this.chrt_length.TabIndex = 0;
            this.chrt_length.Text = "chart1";
            // 
            // btn_set_values
            // 
            this.btn_set_values.Location = new System.Drawing.Point(18, 465);
            this.btn_set_values.Name = "btn_set_values";
            this.btn_set_values.Size = new System.Drawing.Size(373, 23);
            this.btn_set_values.TabIndex = 3;
            this.btn_set_values.Text = "Установить стандартные значения";
            this.btn_set_values.UseVisualStyleBackColor = true;
            this.btn_set_values.Click += new System.EventHandler(this.btn_set_values_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(18, 494);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(373, 23);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Рассчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_iteration_count);
            this.groupBox2.Controls.Add(this.txt_ant_count);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значения";
            // 
            // txt_iteration_count
            // 
            this.txt_iteration_count.Location = new System.Drawing.Point(130, 46);
            this.txt_iteration_count.Name = "txt_iteration_count";
            this.txt_iteration_count.Size = new System.Drawing.Size(237, 20);
            this.txt_iteration_count.TabIndex = 3;
            // 
            // txt_ant_count
            // 
            this.txt_ant_count.Location = new System.Drawing.Point(130, 19);
            this.txt_ant_count.Name = "txt_ant_count";
            this.txt_ant_count.Size = new System.Drawing.Size(237, 20);
            this.txt_ant_count.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество итераций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество муравьев";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_set_values);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Муравьиный алгоритм";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_map)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_length)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_length;
        private System.Windows.Forms.Button btn_set_values;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_iteration_count;
        private System.Windows.Forms.TextBox txt_ant_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

