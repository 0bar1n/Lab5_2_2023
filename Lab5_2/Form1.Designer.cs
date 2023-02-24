
namespace Lab5_2
{
    partial class Lab5_2
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
            this.components = new System.ComponentModel.Container();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.bthStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(78, 29);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(60, 20);
            this.txtMinutes.TabIndex = 0;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(187, 29);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(60, 20);
            this.txtSeconds.TabIndex = 1;
            // 
            // bthStart
            // 
            this.bthStart.Location = new System.Drawing.Point(153, 109);
            this.bthStart.Name = "bthStart";
            this.bthStart.Size = new System.Drawing.Size(88, 23);
            this.bthStart.TabIndex = 2;
            this.bthStart.Text = "Старт";
            this.bthStart.UseVisualStyleBackColor = true;
            this.bthStart.Click += new System.EventHandler(this.bthStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "сек.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "мин.";
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Текущее время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(256, 109);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Сброс";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текущее время";
            // 
            // Lab5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bthStart);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Name = "Lab5_2";
            this.Text = "Секундомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button bthStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrSecundomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

