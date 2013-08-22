using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Utils {
	public partial class OptionsDiag : Form {
		public delegate void onApply(PermOptions op);
		public event onApply Apply;

		private PermOptions options = new PermOptions();

		private bool set = true;

		public OptionsDiag(PermOptions op = null) {
			InitializeComponent();


			if (op != null)
				options = op;
			else
				options = new PermOptions();

			chkStartup.Checked = options.startOnStartup;
			chkHideTaskbarIcon.Checked = options.hideTaskbarIcon;

			DefaultTab.SelectedIndex = (int)options.defaultTab;
			OverlayForeColor.BackColor = options.OverlayForeColor;
			OverlayBckCol.BackColor = options.OverlayBackColor;
			OptacySlider.Value = (int)(options.OverlayOptacy * 100);
			OptacyLabl.Text = string.Format("Optacy: {0}%", OptacySlider.Value);
		}

		private void Cancel_Click(object sender, EventArgs e) {
			this.Dispose();
		}

		private void ok_Click(object sender, EventArgs e) {
			if (Apply != null)
				Apply(options);

			this.Dispose();
		}

		private void Apply_Click(object sender, EventArgs e) {
			if (Apply != null)
				Apply(options);
			OverlayForeColor.BackColor = colorDialog1.Color;
		}

		private void chkStartup_CheckedChanged(object sender, EventArgs e) {
			options.startOnStartup = chkStartup.Checked;
		}

		private void chkHideTaskbarIcon_CheckedChanged(object sender, EventArgs e) {
			options.hideTaskbarIcon = chkHideTaskbarIcon.Checked;
		}

		private void DefaultTab_SelectedIndexChanged(object sender, EventArgs e) {
			options.defaultTab = (PermOptions.tabName)DefaultTab.SelectedIndex;
		}

		private void button1_Click(object sender, EventArgs e) {
			colorDialog1.Color = OverlayForeColor.BackColor;
			colorDialog1.ShowDialog();
			OverlayForeColor.BackColor = colorDialog1.Color;

			options.OverlayForeColor = OverlayForeColor.BackColor;
		}

		private void OverlayBackCol_Click(object sender, EventArgs e) {
			colorDialog1.Color = OverlayBckCol.BackColor;
			colorDialog1.ShowDialog();
			OverlayBckCol.BackColor = colorDialog1.Color;

			options.OverlayBackColor = OverlayBckCol.BackColor;
		}

		private void trackBar1_Scroll(object sender, EventArgs e) {
			OptacyLabl.Text = string.Format("Optacy: {0}%", OptacySlider.Value);
			options.OverlayOptacy = ((double)OptacySlider.Value)/100;
		}

		private void SetKey_KeyUp(object sender, KeyEventArgs e) {
			set = true;
			StartSW.Focus();
			SetKey.Enabled = false;
			
		}


		private void SetKey_KeyDown(object sender, KeyEventArgs e) {

			if (set) return;
			if (e.KeyCode == Keys.Escape) {
				SetKey.Text = "None";
				set = true;
				StartSW.Focus();
				SetKey.Enabled = false;
			} else
				SetKey.Text = e.Modifiers.ToString() + ", " + e.KeyCode.ToString();
		}

		private void StartSW_Click(object sender, EventArgs e) {
			set = false;
			SetKey.Enabled = true;
			SetKey.Focus();
		}
	}
}
