
namespace WindowsFormsApp1
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
            this.v = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A_del = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(148, 35);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(100, 22);
            this.v.TabIndex = 1;
            this.v.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(148, 77);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(100, 22);
            this.t.TabIndex = 2;
            this.t.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Переменная v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Переменная t";
            // 
            // A_del
            // 
            this.A_del.Location = new System.Drawing.Point(148, 124);
            this.A_del.Name = "A_del";
            this.A_del.Size = new System.Drawing.Size(100, 22);
            this.A_del.TabIndex = 5;
            this.A_del.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Переменная a_del";
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(136, 319);
            this.U.Name = "U";
            this.U.ReadOnly = true;
            this.U.Size = new System.Drawing.Size(138, 22);
            this.U.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Переменная U";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.U);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.v);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox A_del;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox U;
        private System.Windows.Forms.Label label4;
    }
}

