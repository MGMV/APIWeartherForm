
namespace APIWeartherForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Temptxt = new System.Windows.Forms.Label();
            this.feelsLikeTxt = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.feelsLikeTxt);
            this.groupBox1.Controls.Add(this.Temptxt);
            this.groupBox1.Location = new System.Drawing.Point(359, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Город";
            // 
            // Temptxt
            // 
            this.Temptxt.AutoSize = true;
            this.Temptxt.Location = new System.Drawing.Point(6, 28);
            this.Temptxt.Name = "Temptxt";
            this.Temptxt.Size = new System.Drawing.Size(80, 13);
            this.Temptxt.TabIndex = 0;
            this.Temptxt.Text = "Температура: ";
            // 
            // feelsLikeTxt
            // 
            this.feelsLikeTxt.AutoSize = true;
            this.feelsLikeTxt.Location = new System.Drawing.Point(6, 41);
            this.feelsLikeTxt.Name = "feelsLikeTxt";
            this.feelsLikeTxt.Size = new System.Drawing.Size(73, 13);
            this.feelsLikeTxt.TabIndex = 0;
            this.feelsLikeTxt.Text = "Ощущается: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(539, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label feelsLikeTxt;
        private System.Windows.Forms.Label Temptxt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

