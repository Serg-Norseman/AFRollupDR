﻿using System;

namespace AFBitmaskDR
{
	internal partial class BitmaskDRConfig
	{
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.ComponentModel.Container components;
		private System.Windows.Forms.Label lblAttribute;
		private System.Windows.Forms.TextBox txtAttribute;
		private BSLib.WinForms.Controls.EnumRadioBox rgbBits;

		private void InitializeComponent()
		{
		    this.btnOK = new System.Windows.Forms.Button();
		    this.btnCancel = new System.Windows.Forms.Button();
		    this.lblAttribute = new System.Windows.Forms.Label();
		    this.txtAttribute = new System.Windows.Forms.TextBox();
		    this.rgbBits = new BSLib.WinForms.Controls.EnumRadioBox();
		    this.SuspendLayout();
		    // 
		    // btnOK
		    // 
		    this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
		    this.btnOK.Location = new System.Drawing.Point(366, 259);
		    this.btnOK.Name = "btnOK";
		    this.btnOK.Size = new System.Drawing.Size(90, 27);
		    this.btnOK.TabIndex = 5;
		    this.btnOK.Text = "OK";
		    this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
		    // 
		    // btnCancel
		    // 
		    this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		    this.btnCancel.Location = new System.Drawing.Point(462, 259);
		    this.btnCancel.Name = "btnCancel";
		    this.btnCancel.Size = new System.Drawing.Size(90, 27);
		    this.btnCancel.TabIndex = 6;
		    this.btnCancel.Text = "Cancel";
		    // 
		    // lblAttribute
		    // 
		    this.lblAttribute.Location = new System.Drawing.Point(12, 9);
		    this.lblAttribute.Name = "lblAttribute";
		    this.lblAttribute.Size = new System.Drawing.Size(77, 19);
		    this.lblAttribute.TabIndex = 2;
		    this.lblAttribute.Text = "Attribute";
		    // 
		    // txtAttribute
		    // 
		    this.txtAttribute.Location = new System.Drawing.Point(95, 6);
		    this.txtAttribute.Name = "txtAttribute";
		    this.txtAttribute.Size = new System.Drawing.Size(349, 22);
		    this.txtAttribute.TabIndex = 7;
		    // 
		    // rgbBits
		    // 
		    this.rgbBits.EnumType = typeof(AFBitmaskDR.BitEnum);
		    this.rgbBits.Location = new System.Drawing.Point(12, 45);
		    this.rgbBits.Name = "rgbBits";
		    this.rgbBits.Size = new System.Drawing.Size(529, 193);
		    this.rgbBits.TabIndex = 10;
		    this.rgbBits.TabStop = false;
		    this.rgbBits.Text = "Bit selection";
		    this.rgbBits.Value = null;
		    // 
		    // BitmaskDRConfig
		    // 
		    this.AcceptButton = this.btnOK;
		    this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
		    this.CancelButton = this.btnCancel;
		    this.ClientSize = new System.Drawing.Size(564, 298);
		    this.Controls.Add(this.rgbBits);
		    this.Controls.Add(this.txtAttribute);
		    this.Controls.Add(this.lblAttribute);
		    this.Controls.Add(this.btnCancel);
		    this.Controls.Add(this.btnOK);
		    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		    this.MaximizeBox = false;
		    this.MinimizeBox = false;
		    this.Name = "BitmaskDRConfig";
		    this.ShowIcon = false;
		    this.ShowInTaskbar = false;
		    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		    this.Text = "Bitmask Data Reference";
		    this.ResumeLayout(false);
		    this.PerformLayout();

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
