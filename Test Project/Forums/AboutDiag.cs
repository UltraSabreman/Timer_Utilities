using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Utils {
	public partial class AboutDiag : Form {
		public AboutDiag() {
			InitializeComponent();

			Sourcelink.Links.Add(0, Sourcelink.Text.Length, "https://github.com/UltraSabreman/Timer_Utilities");
		}

		private void Ok_Click(object sender, EventArgs e) {
			this.Dispose();
		}

		private void Sourcelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			e.Link.Visited = true;

			System.Diagnostics.Process.Start(e.Link.LinkData as string);
		}

	}
}
