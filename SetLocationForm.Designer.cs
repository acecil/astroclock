/*
 * This file is part of AstroClock.
 *
 * AstroClock is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * AstroClock is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with AstroClock. If not, see <http://www.gnu.org/licenses/>.
 */

namespace AstroClock
{
    partial class SetLocationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.textboxLocation = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioDD = new System.Windows.Forms.RadioButton();
            this.radioDMS = new System.Windows.Forms.RadioButton();
            this.radioRadians = new System.Windows.Forms.RadioButton();
            this.NUDDegrees = new System.Windows.Forms.NumericUpDown();
            this.NUDRadians = new System.Windows.Forms.NumericUpDown();
            this.NUDDMSDegrees = new System.Windows.Forms.NumericUpDown();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioW = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDDMSMinutes = new System.Windows.Forms.NumericUpDown();
            this.NUDDMSSeconds = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRadians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDMSDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDMSMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDMSSeconds)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 7;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutPanel.Controls.Add(this.lblLocation, 1, 0);
            this.layoutPanel.Controls.Add(this.lblLongitude, 1, 1);
            this.layoutPanel.Controls.Add(this.textboxLocation, 2, 0);
            this.layoutPanel.Controls.Add(this.btnCancel, 4, 5);
            this.layoutPanel.Controls.Add(this.btnOK, 2, 5);
            this.layoutPanel.Controls.Add(this.label1, 1, 2);
            this.layoutPanel.Controls.Add(this.label2, 1, 3);
            this.layoutPanel.Controls.Add(this.label3, 1, 4);
            this.layoutPanel.Controls.Add(this.NUDDegrees, 2, 2);
            this.layoutPanel.Controls.Add(this.NUDRadians, 2, 4);
            this.layoutPanel.Controls.Add(this.NUDDMSDegrees, 2, 3);
            this.layoutPanel.Controls.Add(this.label4, 6, 2);
            this.layoutPanel.Controls.Add(this.label5, 6, 3);
            this.layoutPanel.Controls.Add(this.NUDDMSMinutes, 3, 3);
            this.layoutPanel.Controls.Add(this.NUDDMSSeconds, 4, 3);
            this.layoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.layoutPanel.Controls.Add(this.tableLayoutPanel2, 5, 2);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 6;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(377, 128);
            this.layoutPanel.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Location = new System.Drawing.Point(23, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(139, 20);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location Name:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLongitude.Location = new System.Drawing.Point(23, 20);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(139, 20);
            this.lblLongitude.TabIndex = 0;
            this.lblLongitude.Text = "Longitude:";
            this.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxLocation
            // 
            this.layoutPanel.SetColumnSpan(this.textboxLocation, 5);
            this.textboxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxLocation.Location = new System.Drawing.Point(168, 3);
            this.textboxLocation.Name = "textboxLocation";
            this.textboxLocation.Size = new System.Drawing.Size(206, 20);
            this.textboxLocation.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.layoutPanel.SetColumnSpan(this.btnCancel, 3);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(268, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 22);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.layoutPanel.SetColumnSpan(this.btnOK, 2);
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(168, 103);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 22);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Decimal degrees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Degree, minutes, seconds";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(80, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decimal radians";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioDD
            // 
            this.radioDD.AutoSize = true;
            this.radioDD.Checked = true;
            this.radioDD.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioDD.Location = new System.Drawing.Point(3, 3);
            this.radioDD.Name = "radioDD";
            this.radioDD.Size = new System.Drawing.Size(14, 14);
            this.radioDD.TabIndex = 8;
            this.radioDD.TabStop = true;
            this.radioDD.Text = "radioButton1";
            this.radioDD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioDD.UseVisualStyleBackColor = true;
            this.radioDD.Click += new System.EventHandler(this.radioDD_Click);
            // 
            // radioDMS
            // 
            this.radioDMS.AutoSize = true;
            this.radioDMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioDMS.Location = new System.Drawing.Point(3, 23);
            this.radioDMS.Name = "radioDMS";
            this.radioDMS.Size = new System.Drawing.Size(14, 14);
            this.radioDMS.TabIndex = 9;
            this.radioDMS.TabStop = true;
            this.radioDMS.Text = "radioButton2";
            this.radioDMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioDMS.UseVisualStyleBackColor = true;
            this.radioDMS.Click += new System.EventHandler(this.radioDMS_Click);
            // 
            // radioRadians
            // 
            this.radioRadians.AutoSize = true;
            this.radioRadians.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioRadians.Location = new System.Drawing.Point(3, 43);
            this.radioRadians.Name = "radioRadians";
            this.radioRadians.Size = new System.Drawing.Size(14, 14);
            this.radioRadians.TabIndex = 10;
            this.radioRadians.TabStop = true;
            this.radioRadians.Text = "radioButton3";
            this.radioRadians.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioRadians.UseVisualStyleBackColor = true;
            this.radioRadians.Click += new System.EventHandler(this.radioRadians_Click);
            // 
            // NUDDegrees
            // 
            this.layoutPanel.SetColumnSpan(this.NUDDegrees, 3);
            this.NUDDegrees.DecimalPlaces = 4;
            this.NUDDegrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDDegrees.Location = new System.Drawing.Point(168, 43);
            this.NUDDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.NUDDegrees.Name = "NUDDegrees";
            this.NUDDegrees.Size = new System.Drawing.Size(144, 20);
            this.NUDDegrees.TabIndex = 11;
            this.NUDDegrees.ValueChanged += new System.EventHandler(this.NUDDegrees_ValueChanged);
            // 
            // NUDRadians
            // 
            this.layoutPanel.SetColumnSpan(this.NUDRadians, 3);
            this.NUDRadians.DecimalPlaces = 5;
            this.NUDRadians.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDRadians.Location = new System.Drawing.Point(168, 83);
            this.NUDRadians.Maximum = new decimal(new int[] {
            3142,
            0,
            0,
            196608});
            this.NUDRadians.Name = "NUDRadians";
            this.NUDRadians.Size = new System.Drawing.Size(144, 20);
            this.NUDRadians.TabIndex = 12;
            this.NUDRadians.ValueChanged += new System.EventHandler(this.NUDRadians_ValueChanged);
            // 
            // NUDDMSDegrees
            // 
            this.NUDDMSDegrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDDMSDegrees.Location = new System.Drawing.Point(168, 63);
            this.NUDDMSDegrees.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.NUDDMSDegrees.Name = "NUDDMSDegrees";
            this.NUDDMSDegrees.Size = new System.Drawing.Size(44, 20);
            this.NUDDMSDegrees.TabIndex = 13;
            this.NUDDMSDegrees.ValueChanged += new System.EventHandler(this.NUDDMSDegrees_ValueChanged);
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioE.Location = new System.Drawing.Point(3, 3);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(14, 14);
            this.radioE.TabIndex = 14;
            this.radioE.TabStop = true;
            this.radioE.Text = "radioButton4";
            this.radioE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioE.UseVisualStyleBackColor = true;
            this.radioE.CheckedChanged += new System.EventHandler(this.radioE_CheckedChanged);
            // 
            // radioW
            // 
            this.radioW.AutoSize = true;
            this.radioW.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioW.Location = new System.Drawing.Point(3, 23);
            this.radioW.Name = "radioW";
            this.radioW.Size = new System.Drawing.Size(14, 14);
            this.radioW.TabIndex = 15;
            this.radioW.TabStop = true;
            this.radioW.Text = "radioButton5";
            this.radioW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioW.UseVisualStyleBackColor = true;
            this.radioW.CheckedChanged += new System.EventHandler(this.radioW_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(338, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "East";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(338, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "West";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUDDMSMinutes
            // 
            this.NUDDMSMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDDMSMinutes.Location = new System.Drawing.Point(218, 63);
            this.NUDDMSMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDDMSMinutes.Name = "NUDDMSMinutes";
            this.NUDDMSMinutes.Size = new System.Drawing.Size(44, 20);
            this.NUDDMSMinutes.TabIndex = 18;
            this.NUDDMSMinutes.ValueChanged += new System.EventHandler(this.NUDDMSMinutes_ValueChanged);
            // 
            // NUDDMSSeconds
            // 
            this.NUDDMSSeconds.DecimalPlaces = 1;
            this.NUDDMSSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDDMSSeconds.Location = new System.Drawing.Point(268, 63);
            this.NUDDMSSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDDMSSeconds.Name = "NUDDMSSeconds";
            this.NUDDMSSeconds.Size = new System.Drawing.Size(44, 20);
            this.NUDDMSSeconds.TabIndex = 19;
            this.NUDDMSSeconds.ValueChanged += new System.EventHandler(this.NUDDMSSeconds_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioDD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioDMS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioRadians, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.layoutPanel.SetRowSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(20, 60);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioE, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioW, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(315, 40);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.layoutPanel.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(20, 40);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // SetLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 128);
            this.Controls.Add(this.layoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetLocationForm";
            this.ShowIcon = false;
            this.Text = "Set Location";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRadians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDMSDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDMSMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDMSSeconds)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox textboxLocation;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioDD;
        private System.Windows.Forms.RadioButton radioDMS;
        private System.Windows.Forms.RadioButton radioRadians;
        private System.Windows.Forms.NumericUpDown NUDDegrees;
        private System.Windows.Forms.NumericUpDown NUDRadians;
        private System.Windows.Forms.NumericUpDown NUDDMSDegrees;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDDMSMinutes;
        private System.Windows.Forms.NumericUpDown NUDDMSSeconds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}