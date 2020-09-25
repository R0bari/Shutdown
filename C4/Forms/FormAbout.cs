using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace C4
{
    public partial class FormAbout : Form
    {
        private static readonly FormFeedback _formFeedback = new FormFeedback();
        public FormAbout()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Переход в форму "Обратная связь"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Feedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_formFeedback.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
        /// <summary>
        /// Подтверждение выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                } else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
