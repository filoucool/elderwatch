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
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.Details_List = new System.Windows.Forms.ListBox();
            this.Verify_Button = new System.Windows.Forms.Button();
            this.Call_Button = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Call_All_Button = new System.Windows.Forms.Button();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Port_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_List
            // 
            this.Name_List.FormattingEnabled = true;
            this.Name_List.ItemHeight = 25;
            this.Name_List.Location = new System.Drawing.Point(24, 77);
            this.Name_List.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name_List.Name = "Name_List";
            this.Name_List.Size = new System.Drawing.Size(294, 754);
            this.Name_List.TabIndex = 0;
            this.Name_List.DoubleClick += new System.EventHandler(this.Name_List_DoubleClick);
            // 
            // Status_List
            // 
            this.Status_List.FormattingEnabled = true;
            this.Status_List.ItemHeight = 25;
            this.Status_List.Location = new System.Drawing.Point(336, 77);
            this.Status_List.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Status_List.Name = "Status_List";
            this.Status_List.Size = new System.Drawing.Size(70, 754);
            this.Status_List.TabIndex = 1;
            // 
            // Picture_Box
            // 
            this.Picture_Box.Location = new System.Drawing.Point(1216, 23);
            this.Picture_Box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(360, 423);
            this.Picture_Box.TabIndex = 2;
            this.Picture_Box.TabStop = false;
            // 
            // Details_List
            // 
            this.Details_List.FormattingEnabled = true;
            this.Details_List.ItemHeight = 25;
            this.Details_List.Location = new System.Drawing.Point(1216, 485);
            this.Details_List.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Details_List.Name = "Details_List";
            this.Details_List.Size = new System.Drawing.Size(356, 354);
            this.Details_List.TabIndex = 3;
            // 
            // Verify_Button
            // 
            this.Verify_Button.Location = new System.Drawing.Point(422, 77);
            this.Verify_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Verify_Button.Name = "Verify_Button";
            this.Verify_Button.Size = new System.Drawing.Size(162, 44);
            this.Verify_Button.TabIndex = 4;
            this.Verify_Button.Text = "Vérifier";
            this.Verify_Button.UseVisualStyleBackColor = true;
            this.Verify_Button.Click += new System.EventHandler(this.Verify_Button_Click);
            // 
            // Call_Button
            // 
            this.Call_Button.Location = new System.Drawing.Point(422, 190);
            this.Call_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Call_Button.Name = "Call_Button";
            this.Call_Button.Size = new System.Drawing.Size(162, 44);
            this.Call_Button.TabIndex = 5;
            this.Call_Button.Text = "Appeler";
            this.Call_Button.UseVisualStyleBackColor = true;
            this.Call_Button.Click += new System.EventHandler(this.Call_Button_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Label.Location = new System.Drawing.Point(136, 42);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(64, 27);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Nom:";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status_Label.Location = new System.Drawing.Point(336, 42);
            this.Status_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(70, 27);
            this.Status_Label.TabIndex = 7;
            this.Status_Label.Text = "Statut";
            // 
            // Call_All_Button
            // 
            this.Call_All_Button.Location = new System.Drawing.Point(422, 246);
            this.Call_All_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Call_All_Button.Name = "Call_All_Button";
            this.Call_All_Button.Size = new System.Drawing.Size(162, 44);
            this.Call_All_Button.TabIndex = 8;
            this.Call_All_Button.Text = "Appeler Tous";
            this.Call_All_Button.UseVisualStyleBackColor = true;
            this.Call_All_Button.Click += new System.EventHandler(this.Call_All_Button_Click);
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(422, 687);
            this.Connect_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(162, 44);
            this.Connect_Button.TabIndex = 9;
            this.Connect_Button.Text = "Connection";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(422, 742);
            this.Disconnect_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(162, 44);
            this.Disconnect_Button.TabIndex = 10;
            this.Disconnect_Button.Text = "Déconnecter";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(422, 798);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(160, 44);
            this.Save_Button.TabIndex = 11;
            this.Save_Button.Text = "Enregistrer";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Vérifier Tous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Verify_All_Button);
            // 
            // Port_Box
            // 
            this.Port_Box.Location = new System.Drawing.Point(598, 690);
            this.Port_Box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.Size = new System.Drawing.Size(196, 31);
            this.Port_Box.TabIndex = 13;
            this.Port_Box.Tag = "";
            this.Port_Box.Text = "Enter Port Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.Port_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Call_All_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Call_Button);
            this.Controls.Add(this.Verify_Button);
            this.Controls.Add(this.Details_List);
            this.Controls.Add(this.Picture_Box);
            this.Controls.Add(this.Status_List);
            this.Controls.Add(this.Name_List);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Logiciel de Surveillance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Name_List;
        private System.Windows.Forms.ListBox Status_List;
        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.ListBox Details_List;
        private System.Windows.Forms.Button Verify_Button;
        private System.Windows.Forms.Button Call_Button;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Button Call_All_Button;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Button Disconnect_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Port_Box;
    }
}

