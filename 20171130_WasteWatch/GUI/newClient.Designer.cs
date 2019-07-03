namespace _20171130_WasteWatch
{
    partial class newClient
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtHousNo = new System.Windows.Forms.TextBox();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(233, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Bestätigen";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ansprechpartner";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(201, 28);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(163, 22);
            this.txtClientName.TabIndex = 5;
            // 
            // txtClientContact
            // 
            this.txtClientContact.Location = new System.Drawing.Point(201, 67);
            this.txtClientContact.Name = "txtClientContact";
            this.txtClientContact.Size = new System.Drawing.Size(163, 22);
            this.txtClientContact.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Straße";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hausnummer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "PLZ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ort";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(28, 146);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(172, 22);
            this.txtStreet.TabIndex = 12;
            // 
            // txtHousNo
            // 
            this.txtHousNo.Location = new System.Drawing.Point(215, 145);
            this.txtHousNo.Name = "txtHousNo";
            this.txtHousNo.Size = new System.Drawing.Size(100, 22);
            this.txtHousNo.TabIndex = 13;
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(31, 213);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(100, 22);
            this.txtZIP.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(218, 212);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 22);
            this.txtCity.TabIndex = 15;
            // 
            // newClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 374);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.txtHousNo);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientContact);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "newClient";
            this.Text = "newClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHousNo;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.TextBox txtCity;
    }
}