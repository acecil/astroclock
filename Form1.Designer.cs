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
    partial class ClockForm
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
            this.components = new System.ComponentModel.Container();
            this.lblGrnPl = new System.Windows.Forms.Label();
            this.lblGrnMeanTime = new System.Windows.Forms.Label();
            this.lblGrnMeanTimeVal = new System.Windows.Forms.Label();
            this.lblGrnEqTime = new System.Windows.Forms.Label();
            this.lblGrnEqTimeVal = new System.Windows.Forms.Label();
            this.lblGrnSolTime = new System.Windows.Forms.Label();
            this.lblGrnSolTimeVal = new System.Windows.Forms.Label();
            this.lblGrnSidTimeVal = new System.Windows.Forms.Label();
            this.lblPl = new System.Windows.Forms.Label();
            this.lblPlMeanTime = new System.Windows.Forms.Label();
            this.lblPlEqTime = new System.Windows.Forms.Label();
            this.lblPlSolTime = new System.Windows.Forms.Label();
            this.lblPlMeanTimeVal = new System.Windows.Forms.Label();
            this.lblPlEqTimeVal = new System.Windows.Forms.Label();
            this.lblPlSolTimeVal = new System.Windows.Forms.Label();
            this.lblPlSidTimeVal = new System.Windows.Forms.Label();
            this.lblGrnSidTime = new System.Windows.Forms.Label();
            this.lblPlSidTime = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrnPl
            // 
            this.lblGrnPl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnPl.AutoSize = true;
            this.lblGrnPl.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnPl, 6);
            this.lblGrnPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnPl.Location = new System.Drawing.Point(0, 0);
            this.lblGrnPl.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnPl.Name = "lblGrnPl";
            this.lblGrnPl.Size = new System.Drawing.Size(1135, 59);
            this.lblGrnPl.TabIndex = 0;
            this.lblGrnPl.Text = "Greenwich";
            this.lblGrnPl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnMeanTime
            // 
            this.lblGrnMeanTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnMeanTime.AutoSize = true;
            this.lblGrnMeanTime.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnMeanTime, 2);
            this.lblGrnMeanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnMeanTime.Location = new System.Drawing.Point(0, 59);
            this.lblGrnMeanTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnMeanTime.Name = "lblGrnMeanTime";
            this.lblGrnMeanTime.Size = new System.Drawing.Size(378, 59);
            this.lblGrnMeanTime.TabIndex = 1;
            this.lblGrnMeanTime.Text = "Mean Time";
            this.lblGrnMeanTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnMeanTimeVal
            // 
            this.lblGrnMeanTimeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnMeanTimeVal.AutoSize = true;
            this.lblGrnMeanTimeVal.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnMeanTimeVal, 2);
            this.lblGrnMeanTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnMeanTimeVal.Location = new System.Drawing.Point(0, 118);
            this.lblGrnMeanTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnMeanTimeVal.Name = "lblGrnMeanTimeVal";
            this.lblGrnMeanTimeVal.Size = new System.Drawing.Size(378, 59);
            this.lblGrnMeanTimeVal.TabIndex = 2;
            this.lblGrnMeanTimeVal.Text = "00:00:00";
            this.lblGrnMeanTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnEqTime
            // 
            this.lblGrnEqTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnEqTime.AutoSize = true;
            this.lblGrnEqTime.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnEqTime, 2);
            this.lblGrnEqTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnEqTime.Location = new System.Drawing.Point(378, 59);
            this.lblGrnEqTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnEqTime.Name = "lblGrnEqTime";
            this.lblGrnEqTime.Size = new System.Drawing.Size(378, 59);
            this.lblGrnEqTime.TabIndex = 3;
            this.lblGrnEqTime.Text = "Equation of Time";
            this.lblGrnEqTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnEqTimeVal
            // 
            this.lblGrnEqTimeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnEqTimeVal.AutoSize = true;
            this.lblGrnEqTimeVal.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnEqTimeVal, 2);
            this.lblGrnEqTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnEqTimeVal.Location = new System.Drawing.Point(378, 118);
            this.lblGrnEqTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnEqTimeVal.Name = "lblGrnEqTimeVal";
            this.lblGrnEqTimeVal.Size = new System.Drawing.Size(378, 59);
            this.lblGrnEqTimeVal.TabIndex = 4;
            this.lblGrnEqTimeVal.Text = "00:00:00";
            this.lblGrnEqTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnSolTime
            // 
            this.lblGrnSolTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnSolTime.AutoSize = true;
            this.lblGrnSolTime.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnSolTime, 2);
            this.lblGrnSolTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnSolTime.Location = new System.Drawing.Point(756, 59);
            this.lblGrnSolTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnSolTime.Name = "lblGrnSolTime";
            this.lblGrnSolTime.Size = new System.Drawing.Size(379, 59);
            this.lblGrnSolTime.TabIndex = 5;
            this.lblGrnSolTime.Text = "Solar Time";
            this.lblGrnSolTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnSolTimeVal
            // 
            this.lblGrnSolTimeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnSolTimeVal.AutoSize = true;
            this.lblGrnSolTimeVal.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnSolTimeVal, 2);
            this.lblGrnSolTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnSolTimeVal.Location = new System.Drawing.Point(756, 118);
            this.lblGrnSolTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnSolTimeVal.Name = "lblGrnSolTimeVal";
            this.lblGrnSolTimeVal.Size = new System.Drawing.Size(379, 59);
            this.lblGrnSolTimeVal.TabIndex = 6;
            this.lblGrnSolTimeVal.Text = "00:00:00";
            this.lblGrnSolTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnSidTimeVal
            // 
            this.lblGrnSidTimeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrnSidTimeVal.AutoSize = true;
            this.lblGrnSidTimeVal.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnSidTimeVal, 2);
            this.lblGrnSidTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnSidTimeVal.Location = new System.Drawing.Point(567, 177);
            this.lblGrnSidTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnSidTimeVal.Name = "lblGrnSidTimeVal";
            this.lblGrnSidTimeVal.Size = new System.Drawing.Size(378, 59);
            this.lblGrnSidTimeVal.TabIndex = 7;
            this.lblGrnSidTimeVal.Text = "00:00:00";
            this.lblGrnSidTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPl
            // 
            this.lblPl.AutoSize = true;
            this.lblPl.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPl, 6);
            this.lblPl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPl.Location = new System.Drawing.Point(0, 236);
            this.lblPl.Margin = new System.Windows.Forms.Padding(0);
            this.lblPl.Name = "lblPl";
            this.lblPl.Size = new System.Drawing.Size(1135, 59);
            this.lblPl.TabIndex = 8;
            this.lblPl.Text = "KEGS, Chelmsford";
            this.lblPl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlMeanTime
            // 
            this.lblPlMeanTime.AutoSize = true;
            this.lblPlMeanTime.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlMeanTime, 2);
            this.lblPlMeanTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlMeanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlMeanTime.Location = new System.Drawing.Point(0, 295);
            this.lblPlMeanTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlMeanTime.Name = "lblPlMeanTime";
            this.lblPlMeanTime.Size = new System.Drawing.Size(378, 59);
            this.lblPlMeanTime.TabIndex = 9;
            this.lblPlMeanTime.Text = "Mean Time";
            this.lblPlMeanTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlEqTime
            // 
            this.lblPlEqTime.AutoSize = true;
            this.lblPlEqTime.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlEqTime, 2);
            this.lblPlEqTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlEqTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlEqTime.Location = new System.Drawing.Point(378, 295);
            this.lblPlEqTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlEqTime.Name = "lblPlEqTime";
            this.lblPlEqTime.Size = new System.Drawing.Size(378, 59);
            this.lblPlEqTime.TabIndex = 10;
            this.lblPlEqTime.Text = "Equation of Time";
            this.lblPlEqTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlSolTime
            // 
            this.lblPlSolTime.AutoSize = true;
            this.lblPlSolTime.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlSolTime, 2);
            this.lblPlSolTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlSolTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlSolTime.Location = new System.Drawing.Point(756, 295);
            this.lblPlSolTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlSolTime.Name = "lblPlSolTime";
            this.lblPlSolTime.Size = new System.Drawing.Size(379, 59);
            this.lblPlSolTime.TabIndex = 11;
            this.lblPlSolTime.Text = "Solar Time";
            this.lblPlSolTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlMeanTimeVal
            // 
            this.lblPlMeanTimeVal.AutoSize = true;
            this.lblPlMeanTimeVal.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlMeanTimeVal, 2);
            this.lblPlMeanTimeVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlMeanTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlMeanTimeVal.Location = new System.Drawing.Point(0, 354);
            this.lblPlMeanTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlMeanTimeVal.Name = "lblPlMeanTimeVal";
            this.lblPlMeanTimeVal.Size = new System.Drawing.Size(378, 59);
            this.lblPlMeanTimeVal.TabIndex = 12;
            this.lblPlMeanTimeVal.Text = "00:00:00";
            this.lblPlMeanTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlEqTimeVal
            // 
            this.lblPlEqTimeVal.AutoSize = true;
            this.lblPlEqTimeVal.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlEqTimeVal, 2);
            this.lblPlEqTimeVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlEqTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlEqTimeVal.Location = new System.Drawing.Point(378, 354);
            this.lblPlEqTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlEqTimeVal.Name = "lblPlEqTimeVal";
            this.lblPlEqTimeVal.Size = new System.Drawing.Size(378, 59);
            this.lblPlEqTimeVal.TabIndex = 13;
            this.lblPlEqTimeVal.Text = "00:00:00";
            this.lblPlEqTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlSolTimeVal
            // 
            this.lblPlSolTimeVal.AutoSize = true;
            this.lblPlSolTimeVal.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlSolTimeVal, 2);
            this.lblPlSolTimeVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlSolTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlSolTimeVal.Location = new System.Drawing.Point(756, 354);
            this.lblPlSolTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlSolTimeVal.Name = "lblPlSolTimeVal";
            this.lblPlSolTimeVal.Size = new System.Drawing.Size(379, 59);
            this.lblPlSolTimeVal.TabIndex = 14;
            this.lblPlSolTimeVal.Text = "00:00:00";
            this.lblPlSolTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlSidTimeVal
            // 
            this.lblPlSidTimeVal.AutoSize = true;
            this.lblPlSidTimeVal.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlSidTimeVal, 2);
            this.lblPlSidTimeVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlSidTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlSidTimeVal.Location = new System.Drawing.Point(567, 413);
            this.lblPlSidTimeVal.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlSidTimeVal.Name = "lblPlSidTimeVal";
            this.lblPlSidTimeVal.Size = new System.Drawing.Size(378, 65);
            this.lblPlSidTimeVal.TabIndex = 15;
            this.lblPlSidTimeVal.Text = "00:00:00";
            this.lblPlSidTimeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrnSidTime
            // 
            this.lblGrnSidTime.AutoSize = true;
            this.lblGrnSidTime.BackColor = System.Drawing.Color.Yellow;
            this.layoutPanel.SetColumnSpan(this.lblGrnSidTime, 2);
            this.lblGrnSidTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrnSidTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrnSidTime.Location = new System.Drawing.Point(189, 177);
            this.lblGrnSidTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrnSidTime.Name = "lblGrnSidTime";
            this.lblGrnSidTime.Size = new System.Drawing.Size(378, 59);
            this.lblGrnSidTime.TabIndex = 16;
            this.lblGrnSidTime.Text = "Sidereal Time";
            this.lblGrnSidTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlSidTime
            // 
            this.lblPlSidTime.AutoSize = true;
            this.lblPlSidTime.BackColor = System.Drawing.Color.Cyan;
            this.layoutPanel.SetColumnSpan(this.lblPlSidTime, 2);
            this.lblPlSidTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlSidTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlSidTime.Location = new System.Drawing.Point(189, 413);
            this.lblPlSidTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlSidTime.Name = "lblPlSidTime";
            this.lblPlSidTime.Size = new System.Drawing.Size(378, 65);
            this.lblPlSidTime.TabIndex = 17;
            this.lblPlSidTime.Text = "Sidereal Time";
            this.lblPlSidTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 6;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layoutPanel.Controls.Add(this.label7, 7, 7);
            this.layoutPanel.Controls.Add(this.label6, 0, 3);
            this.layoutPanel.Controls.Add(this.label5, 0, 7);
            this.layoutPanel.Controls.Add(this.lblGrnPl, 0, 0);
            this.layoutPanel.Controls.Add(this.lblPlSidTime, 1, 7);
            this.layoutPanel.Controls.Add(this.lblGrnSidTime, 1, 3);
            this.layoutPanel.Controls.Add(this.lblPlSidTimeVal, 3, 7);
            this.layoutPanel.Controls.Add(this.lblPlSolTimeVal, 4, 6);
            this.layoutPanel.Controls.Add(this.lblPlEqTimeVal, 2, 6);
            this.layoutPanel.Controls.Add(this.lblPlMeanTimeVal, 0, 6);
            this.layoutPanel.Controls.Add(this.lblPlSolTime, 4, 5);
            this.layoutPanel.Controls.Add(this.lblPlEqTime, 2, 5);
            this.layoutPanel.Controls.Add(this.lblPlMeanTime, 0, 5);
            this.layoutPanel.Controls.Add(this.lblPl, 0, 4);
            this.layoutPanel.Controls.Add(this.lblGrnSidTimeVal, 3, 3);
            this.layoutPanel.Controls.Add(this.lblGrnSolTimeVal, 4, 2);
            this.layoutPanel.Controls.Add(this.lblGrnSolTime, 4, 1);
            this.layoutPanel.Controls.Add(this.lblGrnEqTimeVal, 2, 2);
            this.layoutPanel.Controls.Add(this.lblGrnEqTime, 2, 1);
            this.layoutPanel.Controls.Add(this.lblGrnMeanTimeVal, 0, 2);
            this.layoutPanel.Controls.Add(this.lblGrnMeanTime, 0, 1);
            this.layoutPanel.Controls.Add(this.label1, 6, 3);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 8;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.layoutPanel.Size = new System.Drawing.Size(1135, 478);
            this.layoutPanel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(945, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 65);
            this.label7.TabIndex = 25;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 59);
            this.label6.TabIndex = 24;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 65);
            this.label5.TabIndex = 23;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(945, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 59);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLocationToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(174, 26);
            // 
            // changeLocationToolStripMenuItem
            // 
            this.changeLocationToolStripMenuItem.Name = "changeLocationToolStripMenuItem";
            this.changeLocationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.changeLocationToolStripMenuItem.Text = "Change Location...";
            this.changeLocationToolStripMenuItem.Click += new System.EventHandler(this.changeLocationToolStripMenuItem_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 478);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.layoutPanel);
            this.Name = "ClockForm";
            this.ShowIcon = false;
            this.Text = "Astro Clock";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGrnPl;
        private System.Windows.Forms.Label lblGrnMeanTime;
        private System.Windows.Forms.Label lblGrnMeanTimeVal;
        private System.Windows.Forms.Label lblGrnEqTime;
        private System.Windows.Forms.Label lblGrnEqTimeVal;
        private System.Windows.Forms.Label lblGrnSolTime;
        private System.Windows.Forms.Label lblGrnSolTimeVal;
        private System.Windows.Forms.Label lblGrnSidTimeVal;
        private System.Windows.Forms.Label lblPl;
        private System.Windows.Forms.Label lblPlMeanTime;
        private System.Windows.Forms.Label lblPlEqTime;
        private System.Windows.Forms.Label lblPlSolTime;
        private System.Windows.Forms.Label lblPlMeanTimeVal;
        private System.Windows.Forms.Label lblPlEqTimeVal;
        private System.Windows.Forms.Label lblPlSolTimeVal;
        private System.Windows.Forms.Label lblPlSidTimeVal;
        private System.Windows.Forms.Label lblGrnSidTime;
        private System.Windows.Forms.Label lblPlSidTime;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem changeLocationToolStripMenuItem;
    }
}

