using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Shutdown.Host.Forms
{
    public partial class FormFeedback : Form
    {
        private const string From = "r0bari2@yandex.ru";
        private const string Subject = "Shutdown. Предложения";

        public FormFeedback()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отправка сообщения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            if (mailName.Text != string.Empty)
            {
                string body = "<h3>" + mailName.Text + "</h3><p>" + messageText.Text + "</p>";
                MailMessage message = new MailMessage(From, From, Subject, body)
                {
                    IsBodyHtml = true
                };

                //  Порт 587 - отправка email от email-пользователей (MUAs)
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587)
                {
                    Credentials = new NetworkCredential("r0bari2", "eviguf3579"),
                    EnableSsl = true,
                };

                try
                {
                    smtp.Send(message);
                    messageText.Text = string.Empty;
                    MessageBox.Show("Сообщение успешно отправлено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                message.Dispose();
                smtp.Dispose();
            }
            else
            {
                MessageBox.Show("Вы не ввели имя отправителя.");
            }
        }

        /// <summary>
        /// Подтверждение выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFeedback_FormClosing(object sender, FormClosingEventArgs e)
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