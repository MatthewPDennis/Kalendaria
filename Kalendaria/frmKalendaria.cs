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

        public frmKalendaria()
        {
            InitializeComponent();
            Converter = new DateConverter();
            PrefsForm = new frmPreferences();

            //Force selection of initial culture.
            if (Converter.CurrentCulture == null)
                PrefsForm.ShowDialog();
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
            PopulateCalendar(this.Converter);
        }


    }
}