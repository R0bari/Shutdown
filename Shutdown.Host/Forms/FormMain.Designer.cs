using System;
using System.Windows.Forms;

namespace Shutdown.Host.Forms
{
    partial class FormMain
    {
        private static Timer _timer;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonRe = new System.Windows.Forms.RadioButton();
            this.numericTimerHour = new System.Windows.Forms.NumericUpDown();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.numericTimerMinute = new System.Windows.Forms.NumericUpDown();
            this.numericTimerSec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerSec)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.ShowAbout);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.CloseForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите действие \"Выключение\" или \"Перезагрузка\",\r\nа затем установите время, чер" +
    "ез которое это действие \r\nдолжно произойти.\r\n";
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Checked = true;
            this.radioButtonOff.Location = new System.Drawing.Point(27, 157);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(89, 17);
            this.radioButtonOff.TabIndex = 4;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Выключение";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonRe
            // 
            this.radioButtonRe.AutoSize = true;
            this.radioButtonRe.Location = new System.Drawing.Point(27, 180);
            this.radioButtonRe.Name = "radioButtonRe";
            this.radioButtonRe.Size = new System.Drawing.Size(97, 17);
            this.radioButtonRe.TabIndex = 5;
            this.radioButtonRe.Text = "Перезагрузка";
            this.radioButtonRe.UseVisualStyleBackColor = true;
            // 
            // numericTimerHour
            // 
            this.numericTimerHour.Location = new System.Drawing.Point(27, 241);
            this.numericTimerHour.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericTimerHour.Name = "numericTimerHour";
            this.numericTimerHour.Size = new System.Drawing.Size(48, 20);
            this.numericTimerHour.TabIndex = 6;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(27, 279);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(120, 40);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.AcceptShutdown);
            // 
            // numericTimerMinute
            // 
            this.numericTimerMinute.Location = new System.Drawing.Point(139, 241);
            this.numericTimerMinute.Name = "numericTimerMinute";
            this.numericTimerMinute.Size = new System.Drawing.Size(48, 20);
            this.numericTimerMinute.TabIndex = 9;
            // 
            // numericTimerSec
            // 
            this.numericTimerSec.Location = new System.Drawing.Point(253, 241);
            this.numericTimerSec.Name = "numericTimerSec";
            this.numericTimerSec.Size = new System.Drawing.Size(48, 20);
            this.numericTimerSec.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "М";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "С";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTip.Location = new System.Drawing.Point(24, 331);
            this.labelTip.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(172, 26);
            this.labelTip.TabIndex = 14;
            this.labelTip.Text = "(если вы нажмете \"Принять\", то\r\nкомпьютер выключится в ...)";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.MistyRose;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(112, 17);
            this.statusText.Text = "Добро пожаловать";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip.Location = new System.Drawing.Point(0, 384);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(334, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(334, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericTimerSec);
            this.Controls.Add(this.numericTimerMinute);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.numericTimerHour);
            this.Controls.Add(this.radioButtonRe);
            this.Controls.Add(this.radioButtonOff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(350, 445);
            this.Name = "FormMain";
            this.Text = "Shutdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimerSec)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();


            //  Инициализация таймера
            _timer = new Timer
            {
                Interval = 1000
            };
            _timer.Tick += Timer_Tick;
            _timer.Enabled = true;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonRe;
        private System.Windows.Forms.NumericUpDown numericTimerHour;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.NumericUpDown numericTimerMinute;
        private System.Windows.Forms.NumericUpDown numericTimerSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// Изменение подсказки каждую секунду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            time = time.AddHours(Convert.ToDouble(numericTimerHour.Value))
                .AddMinutes(Convert.ToDouble(numericTimerMinute.Value))
                .AddSeconds(Convert.ToDouble(numericTimerSec.Value));
            string text = $"(если вы нажмете \"Принять\", то\nкомпьютер {(radioButtonOff.Checked ? "выключится" : "перезагрузится")} в " +
                        ((time.Hour > 9) ? time.Hour.ToString() : "0" + time.Hour) + ":" +
                        ((time.Minute > 9) ? time.Minute.ToString() : "0" + time.Minute) + ":" +
                        ((time.Second > 9) ? time.Second.ToString() : "0" + time.Second) + ")";
            labelTip.Text = text;
        }
    }
}

