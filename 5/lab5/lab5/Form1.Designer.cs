
namespace lab5
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
            this.dvgRaw = new System.Windows.Forms.DataGridView();
            this.dvgSummary = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgRaw
            // 
            this.dvgRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRaw.Location = new System.Drawing.Point(12, 12);
            this.dvgRaw.Name = "dvgRaw";
            this.dvgRaw.RowHeadersWidth = 51;
            this.dvgRaw.RowTemplate.Height = 24;
            this.dvgRaw.Size = new System.Drawing.Size(457, 339);
            this.dvgRaw.TabIndex = 0;
            // 
            // dvgSummary
            // 
            this.dvgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSummary.Location = new System.Drawing.Point(475, 12);
            this.dvgSummary.Name = "dvgSummary";
            this.dvgSummary.RowHeadersWidth = 51;
            this.dvgSummary.RowTemplate.Height = 24;
            this.dvgSummary.Size = new System.Drawing.Size(364, 338);
            this.dvgSummary.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(150, 377);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(188, 36);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Загрузить данные";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 446);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dvgSummary);
            this.Controls.Add(this.dvgRaw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgRaw;
        private System.Windows.Forms.DataGridView dvgSummary;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}

