//using System;
//using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Kalendaria
{
    public partial class frmPreferences : Form
    {
        /// <summary>
        /// Stored reference to the flow layout panel for ease of access.
        /// </summary>
        private FlowLayoutPanel PreferencePanel;

        /// <summary>
        /// Stores the currently selected culture to avoid a search for the checked checkbox on leaving the form.
        /// </summary>
        public CultureInfo? CurrentCulture;

        public frmPreferences()
        {
            InitializeComponent();
            PreferencePanel = (FlowLayoutPanel)this.Controls.Find("flpPreferences", true)[0];
            PopulatePreferences();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Auto-populates the preferences form with cultures available from CultureInfo.GetCultures().
        /// User choice will be used to determine calendar.
        /// </summary>
        public void PopulatePreferences()
        {
            CultureInfo[] cInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            var sorted = cInfos.OrderBy(c => c.DisplayName).ToArray();

            foreach (CultureInfo ci in sorted)
            {
                //Skip empty strings and anything with parentheses
                if ((String.IsNullOrEmpty(ci.DisplayName)) ||
                    (String.IsNullOrWhiteSpace(ci.DisplayName)) ||
                    (ci.DisplayName.Contains('(')))
                    continue;

                CheckBox cb = new CheckBox();
                cb.Click += Checkbox_Click;
                PreferencePanel.Controls.Add(cb);
                cb.Text = ci.DisplayName;
                cb.Tag = ci; //Store CultureInfo reference to pass back out of form later
                cb.Margin = new Padding(3, 20, 3, 20);

            }


        }

        /// <summary>
        /// Checkbox click enforces one and only one selection from available cultures.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Checkbox_Click(object? sender, EventArgs e)
        {
            if (sender == null) return;

            var cbSender = sender as CheckBox;
            if (cbSender == null) return;

            foreach (Control c in PreferencePanel.Controls)
            {
                var cb = c as CheckBox;
                if ((cb != null) && (cb != cbSender))
                    cb.Checked = false;
            }

            //Save current selection for later use.
            CurrentCulture = cbSender.Tag as CultureInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrefsDone_Click(object sender, EventArgs e)
        {
            if (CurrentCulture == null)
            {
                string message = "You have not selected a culture. Continue?";
                string caption = "No culture selected";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }

            this.Visible = false;
            var frmKal = this.Parent as frmKalendaria;
            if (frmKal != null)
                frmKal.UpdateCulture(CurrentCulture);
        }
    }
}
