﻿
namespace SalonManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.dgvAppointmentDetail = new System.Windows.Forms.DataGridView();
            this.btnGoToAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointmentDetail
            // 
            this.dgvAppointmentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentDetail.Location = new System.Drawing.Point(339, 12);
            this.dgvAppointmentDetail.Name = "dgvAppointmentDetail";
            this.dgvAppointmentDetail.RowHeadersWidth = 51;
            this.dgvAppointmentDetail.RowTemplate.Height = 24;
            this.dgvAppointmentDetail.Size = new System.Drawing.Size(573, 335);
            this.dgvAppointmentDetail.TabIndex = 0;
            // 
            // btnGoToAppointment
            // 
            this.btnGoToAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAppointment.Location = new System.Drawing.Point(578, 353);
            this.btnGoToAppointment.Name = "btnGoToAppointment";
            this.btnGoToAppointment.Size = new System.Drawing.Size(100, 53);
            this.btnGoToAppointment.TabIndex = 1;
            this.btnGoToAppointment.Text = "Go To Appointment";
            this.btnGoToAppointment.UseVisualStyleBackColor = true;
            this.btnGoToAppointment.Click += new System.EventHandler(this.btnGoToAppointment_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SalonManagementSystem.Properties.Resources.WhatsApp_Image_2021_05_03_at_10_13_52_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(924, 685);
            this.Controls.Add(this.btnGoToAppointment);
            this.Controls.Add(this.dgvAppointmentDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointmentDetail;
        private System.Windows.Forms.Button btnGoToAppointment;
    }
}