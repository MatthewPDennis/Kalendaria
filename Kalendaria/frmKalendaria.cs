using System;
using System.Globalization;

namespace Kalendaria
{
    public partial class frmKalendaria : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private DateConverter Converter;

        private frmPreferences PrefsForm;

        private UserSettings Settings;

        public frmKalendaria()
        {
            InitializeComponent();

            PrefsForm = new frmPreferences();

            Settings = new UserSettings();

            var culture = Settings.SelectedCulture;
            if (culture == null)
            {
                Converter = new DateConverter();
                DialogResult result = MessageBox.Show("You do not have a culture or calendar selected. Do you want to choose one now?", "Select culture/calendar?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    PrefsForm.ShowDialog();
            }
            else
                Converter = new DateConverter(culture);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Populates the calendar panel based on the current user-selected calendar.
        /// </summary>
        /// <param name="calTrans"></param>
        private void PopulateCalendar(DateConverter calTrans)
        {
            
        }

        public void UpdateCulture(CultureInfo? ci)
        {
            if (ci == null) return;

            this.Converter.CurrentCulture = ci;
            Settings.SelectedCulture = ci;
            Settings.Save();
        }

        private void tsmPreferences_Click(object sender, EventArgs e)
        {
            PrefsForm.ShowDialog();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            if (Converter.CurrentCulture != null)
                Settings.SelectedCulture = Converter.CurrentCulture;
            Application.Exit();
        }
        


    }
}