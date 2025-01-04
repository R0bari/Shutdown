using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shutdown.Host.Forms
{
    public partial class FormMain : Form
    {
        private static readonly FormAbout FormAbout = new FormAbout();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Принять"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptShutdown(object sender, EventArgs e)
        {
            CancelPlannedShutdown();

            DateTime time = DateTime.Now.AddHours(Convert.ToDouble(numericTimerHour.Value))
                .AddMinutes(Convert.ToDouble(numericTimerMinute.Value))
                .AddSeconds(Convert.ToDouble(numericTimerSec.Value));

            int timeParam = Convert.ToInt32(numericTimerHour.Value * 60 * 60) +
                            Convert.ToInt32(numericTimerMinute.Value * 60) +
                            Convert.ToInt32(numericTimerSec.Value);

            string messageText = $"Компьютер будет {(radioButtonOff.Checked ? "выключен" : "перезагружен")} в " +
                                 (time.Hour > 9 ? time.Hour.ToString() : "0" + time.Hour) + ":" +
                                 (time.Minute > 9 ? time.Minute.ToString() : "0" + time.Minute) + ":" +
                                 (time.Second > 9 ? time.Second.ToString() : "0" + time.Second) + ".";
            statusText.Text = messageText;

            ProcessStartInfo command = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c shutdown "
                //  /k - not to close console after processing
                //  /c - close console after processing
            };

            command.Arguments += radioButtonOff.Checked ? "/s " : "/r ";

            if (IsScheduledTime())
                command.Arguments += " /t " + timeParam;

            if (ConfirmShutdown(timeParam))
                Process.Start(command);

            if (timeParam > 600)
                MessageBox.Show(messageText);
        }

        /// <summary>
        /// Отменить запланированное выключение/перезагрузку компьютера
        /// </summary>
        private void CancelPlannedShutdown()
        {
            ProcessStartInfo cancelCommand = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c shutdown -a"
            };
            Process.Start(cancelCommand);
        }

        /// <summary>
        /// Проверить, установлено ли время отключения
        /// </summary>
        /// <returns></returns>
        private bool IsScheduledTime() => numericTimerHour.Value + numericTimerMinute.Value + numericTimerSec.Value > 0;

        /// <summary>
        /// Подтверждение выключения/перезагрузки
        /// </summary>
        /// <param name="timeParam">Время, по истечении которого компьютер должен быть выключен/перезагружен</param>
        /// <returns></returns>
        private static bool ConfirmShutdown(int timeParam)
        {
            if (timeParam > 0)
                return true;

            return timeParam == 0 &&
                   MessageBox.Show(
                       "Вы действительно хотите выключить компьютер прямо сейчас?",
                       "Подтверждение",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }

        /// <summary>
        /// Отмена запланированного выключения/перезагрузки компьютера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelPlannedShutdown();
            numericTimerHour.Value = numericTimerMinute.Value = numericTimerSec.Value = 0;
            statusText.Text = "Запланированное выключение/перезагрузка отменено";
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Вы уверены, что хотите выйти?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Открытие информации об авторе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAbout(object sender, EventArgs e)
        {
            Hide();
            if (FormAbout.ShowDialog() == DialogResult.OK)
                Show();
        }

        /// <summary>
        /// Подтвреждение выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing
                && MessageBox.Show(
                    "Вы уверены, что хотите выйти?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}