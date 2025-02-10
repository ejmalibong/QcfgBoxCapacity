
namespace QcfgBoxCapacity
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCheckModel = new System.Windows.Forms.Button();
            this.btnChangeQty = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtChangeQty = new System.Windows.Forms.TextBox();
            this.lblCurrentQty1 = new System.Windows.Forms.Label();
            this.lblCurrentQty2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckModel
            // 
            this.btnCheckModel.FlatAppearance.BorderSize = 0;
            this.btnCheckModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckModel.Location = new System.Drawing.Point(1, 1);
            this.btnCheckModel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCheckModel.Name = "btnCheckModel";
            this.btnCheckModel.Size = new System.Drawing.Size(200, 53);
            this.btnCheckModel.TabIndex = 0;
            this.btnCheckModel.Text = "Change Model";
            this.btnCheckModel.UseVisualStyleBackColor = true;
            this.btnCheckModel.Click += new System.EventHandler(this.btnCheckModel_Click);
            // 
            // btnChangeQty
            // 
            this.btnChangeQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeQty.Location = new System.Drawing.Point(1, 55);
            this.btnChangeQty.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnChangeQty.Name = "btnChangeQty";
            this.btnChangeQty.Size = new System.Drawing.Size(200, 53);
            this.btnChangeQty.TabIndex = 1;
            this.btnChangeQty.Text = "Change Qty:";
            this.btnChangeQty.UseVisualStyleBackColor = true;
            this.btnChangeQty.Click += new System.EventHandler(this.btnChangeQty_Click);
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(202, 1);
            this.txtModel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(566, 53);
            this.txtModel.TabIndex = 2;
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChangeQty
            // 
            this.txtChangeQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeQty.Location = new System.Drawing.Point(202, 55);
            this.txtChangeQty.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtChangeQty.Name = "txtChangeQty";
            this.txtChangeQty.Size = new System.Drawing.Size(194, 53);
            this.txtChangeQty.TabIndex = 3;
            this.txtChangeQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChangeQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeQty_KeyPress);
            // 
            // lblCurrentQty1
            // 
            this.lblCurrentQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentQty1.Location = new System.Drawing.Point(397, 55);
            this.lblCurrentQty1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCurrentQty1.Name = "lblCurrentQty1";
            this.lblCurrentQty1.Size = new System.Drawing.Size(200, 53);
            this.lblCurrentQty1.TabIndex = 4;
            this.lblCurrentQty1.Text = "Current Qty:";
            this.lblCurrentQty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentQty2
            // 
            this.lblCurrentQty2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCurrentQty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentQty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQty2.Location = new System.Drawing.Point(598, 55);
            this.lblCurrentQty2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCurrentQty2.Name = "lblCurrentQty2";
            this.lblCurrentQty2.Size = new System.Drawing.Size(170, 53);
            this.lblCurrentQty2.TabIndex = 5;
            this.lblCurrentQty2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnCheckModel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 109);
            this.Controls.Add(this.btnCheckModel);
            this.Controls.Add(this.lblCurrentQty2);
            this.Controls.Add(this.lblCurrentQty1);
            this.Controls.Add(this.txtChangeQty);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnChangeQty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box Quantity Changer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckModel;
        private System.Windows.Forms.Button btnChangeQty;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtChangeQty;
        private System.Windows.Forms.Label lblCurrentQty1;
        private System.Windows.Forms.Label lblCurrentQty2;
    }
}

