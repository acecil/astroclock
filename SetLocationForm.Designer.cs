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
            this.lblLongitude = new System.Windows.Forms.Label();
            this.longitudeVal = new System.Windows.Forms.NumericUpDown();
            this.lblDegrees = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.textboxLocation = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeVal)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 3;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanel.Controls.Add(this.lblLocation, 0, 0);
            this.layoutPanel.Controls.Add(this.lblLongitude, 0, 1);
            this.layoutPanel.Controls.Add(this.longitudeVal, 1, 1);
            this.layoutPanel.Controls.Add(this.lblDegrees, 2, 1);
            this.layoutPanel.Controls.Add(this.textboxLocation, 1, 0);
            this.layoutPanel.Controls.Add(this.btnCancel, 2, 3);
            this.layoutPanel.Controls.Add(this.btnOK, 1, 3);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 4;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel.Size = new System.Drawing.Size(294, 108);
            this.layoutPanel.TabIndex = 0;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLongitude.Location = new System.Drawing.Point(3, 27);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(91, 27);
            this.lblLongitude.TabIndex = 0;
            this.lblLongitude.Text = "Longitude:";
            this.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // longitudeVal
            // 
            this.longitudeVal.DecimalPlaces = 6;
            this.longitudeVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitudeVal.Location = new System.Drawing.Point(100, 30);
            this.longitudeVal.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.longitudeVal.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.longitudeVal.Name = "longitudeVal";
            this.longitudeVal.Size = new System.Drawing.Size(91, 20);
            this.longitudeVal.TabIndex = 1;
            // 
            // lblDegrees
            // 
            this.lblDegrees.AutoSize = true;
            this.lblDegrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDegrees.Location = new System.Drawing.Point(197, 27);
            this.lblDegrees.Name = "lblDegrees";
            this.lblDegrees.Size = new System.Drawing.Size(94, 27);
            this.lblDegrees.TabIndex = 2;
            this.lblDegrees.Text = "degrees";
            this.lblDegrees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Location = new System.Drawing.Point(3, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(91, 27);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxLocation
            // 
            this.layoutPanel.SetColumnSpan(this.textboxLocation, 2);
            this.textboxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxLocation.Location = new System.Drawing.Point(100, 3);
            this.textboxLocation.Name = "textboxLocation";
            this.textboxLocation.Size = new System.Drawing.Size(191, 20);
            this.textboxLocation.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(197, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 21);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(100, 84);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 21);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // SetLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 108);
            this.Controls.Add(this.layoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetLocationForm";
            this.ShowIcon = false;
            this.Text = "Set Location";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longitudeVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.NumericUpDown longitudeVal;
        private System.Windows.Forms.Label lblDegrees;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox textboxLocation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}