using System;
using System.Windows.Forms;
using C4;

namespace Shutdown.Host.Forms
{
    public partial class FormAbout : Form
    {
        private static readonly FormFeedback FormFeedback = new FormFeedback();

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
            Hide();
            if (FormFeedback.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
        }

        /// <summary>
        /// Подтверждение выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show(
                        "Вы уверены, что хотите выйти?",
                        "Подтверждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}