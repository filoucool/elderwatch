namespace Logiciel_de_Surveillance
{
    partial class Form1
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
            this.Name_List = new System.Windows.Forms.ListBox();
            this.Status_List = new System.Windows.Forms.ListBox();
            this.Verify_Button = new System.Windows.Forms.Button();
            this.Call_Button = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Call_All_Button = new System.Windows.Forms.Button();
            this.PortButton = new System.Windows.Forms.Button();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Port_Box = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_List
            // 
            this.Name_List.FormattingEnabled = true;
            this.Name_List.Location = new System.Drawing.Point(12, 40);
            this.Name_List.Name = "Name_List";
            this.Name_List.Size = new System.Drawing.Size(149, 394);
            this.Name_List.TabIndex = 0;
            this.Name_List.DoubleClick += new System.EventHandler(this.Name_List_DoubleClick);
            // 
            // Status_List
            // 
            this.Status_List.FormattingEnabled = true;
            this.Status_List.Location = new System.Drawing.Point(168, 40);
            this.Status_List.Name = "Status_List";
            this.Status_List.Size = new System.Drawing.Size(37, 394);
            this.Status_List.TabIndex = 1;
            // 
            // Verify_Button
            // 
            this.Verify_Button.Location = new System.Drawing.Point(211, 40);
            this.Verify_Button.Name = "Verify_Button";
            this.Verify_Button.Size = new System.Drawing.Size(81, 23);
            this.Verify_Button.TabIndex = 4;
            this.Verify_Button.Text = "Vérifier";
            this.Verify_Button.UseVisualStyleBackColor = true;
            this.Verify_Button.Click += new System.EventHandler(this.Verify_Button_Click);
            // 
            // Call_Button
            // 
            this.Call_Button.Location = new System.Drawing.Point(211, 99);
            this.Call_Button.Name = "Call_Button";
            this.Call_Button.Size = new System.Drawing.Size(81, 23);
            this.Call_Button.TabIndex = 5;
            this.Call_Button.Text = "Appeler";
            this.Call_Button.UseVisualStyleBackColor = true;
            this.Call_Button.Click += new System.EventHandler(this.Call_Button_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Label.Location = new System.Drawing.Point(68, 22);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(34, 15);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Nom:";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status_Label.Location = new System.Drawing.Point(168, 22);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(37, 15);
            this.Status_Label.TabIndex = 7;
            this.Status_Label.Text = "Statut";
            // 
            // Call_All_Button
            // 
            this.Call_All_Button.Location = new System.Drawing.Point(211, 128);
            this.Call_All_Button.Name = "Call_All_Button";
            this.Call_All_Button.Size = new System.Drawing.Size(81, 23);
            this.Call_All_Button.TabIndex = 8;
            this.Call_All_Button.Text = "Appeler Tous";
            this.Call_All_Button.UseVisualStyleBackColor = true;
            this.Call_All_Button.Click += new System.EventHandler(this.Call_All_Button_Click);
            // 
            // PortButton
            // 
            this.PortButton.Location = new System.Drawing.Point(218, 300);
            this.PortButton.Name = "PortButton";
            this.PortButton.Size = new System.Drawing.Size(75, 23);
            this.PortButton.TabIndex = 15;
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(211, 382);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(81, 23);
            this.Disconnect_Button.TabIndex = 10;
            this.Disconnect_Button.Text = "Déconnecter";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(211, 411);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(80, 23);
            this.Save_Button.TabIndex = 11;
            this.Save_Button.Text = "Enregistrer";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Vérifier Tous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Verify_All_Button);
            // 
            // Port_Box
            // 
            this.Port_Box.Location = new System.Drawing.Point(214, 329);
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.Size = new System.Drawing.Size(79, 20);
            this.Port_Box.TabIndex = 13;
            this.Port_Box.Tag = "";
            this.Port_Box.Text = "COM14";
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(211, 236);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(78, 21);
            this.PortBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.Port_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.PortButton);
            this.Controls.Add(this.Call_All_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Call_Button);
            this.Controls.Add(this.Verify_Button);
            this.Controls.Add(this.Status_List);
            this.Controls.Add(this.Name_List);
            this.Name = "Form1";
            this.Text = "Logiciel de Surveillance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Name_List;
        private System.Windows.Forms.ListBox Status_List;
        private System.Windows.Forms.Button Verify_Button;
        private System.Windows.Forms.Button Call_Button;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Button Call_All_Button;
        private System.Windows.Forms.Button PortButton;
        private System.Windows.Forms.Button Disconnect_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Port_Box;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button button2;
    }
}

