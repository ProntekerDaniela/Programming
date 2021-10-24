
namespace Lab3._1DB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.textFilterName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.MaxValueRate = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.buttonRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(624, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(663, 32);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(160, 43);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Сортування за курсом";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(846, 32);
            this.Max.Margin = new System.Windows.Forms.Padding(4);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(160, 43);
            this.Max.TabIndex = 2;
            this.Max.Text = "Знайти найбільше значення";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(725, 106);
            this.numCourse.Margin = new System.Windows.Forms.Padding(4);
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(160, 22);
            this.numCourse.TabIndex = 3;
            // 
            // textFilterName
            // 
            this.textFilterName.Location = new System.Drawing.Point(989, 106);
            this.textFilterName.Margin = new System.Windows.Forms.Padding(4);
            this.textFilterName.Name = "textFilterName";
            this.textFilterName.Size = new System.Drawing.Size(159, 22);
            this.textFilterName.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(663, 167);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 28);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Видалити найменше";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MaxValueRate
            // 
            this.MaxValueRate.Location = new System.Drawing.Point(1029, 32);
            this.MaxValueRate.Margin = new System.Windows.Forms.Padding(4);
            this.MaxValueRate.Name = "MaxValueRate";
            this.MaxValueRate.Size = new System.Drawing.Size(160, 43);
            this.MaxValueRate.TabIndex = 7;
            this.MaxValueRate.Text = "Макс значення";
            this.MaxValueRate.UseVisualStyleBackColor = true;
            this.MaxValueRate.Click += new System.EventHandler(this.MaxValueRate_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(846, 167);
            this.count.Margin = new System.Windows.Forms.Padding(4);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(160, 47);
            this.count.TabIndex = 8;
            this.count.Text = "Кількість студентів на курсі";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // buttonRate
            // 
            this.buttonRate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRate.Location = new System.Drawing.Point(1029, 167);
            this.buttonRate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(160, 47);
            this.buttonRate.TabIndex = 9;
            this.buttonRate.Text = "Середній бал більше 60";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 645);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.count);
            this.Controls.Add(this.MaxValueRate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textFilterName);
            this.Controls.Add(this.numCourse);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.TextBox textFilterName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button MaxValueRate;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button buttonRate;
    }
}

