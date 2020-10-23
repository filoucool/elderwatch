namespace GUI
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
            this.Port_Button = new System.Windows.Forms.Button();
            this.Port_Box = new System.Windows.Forms.ComboBox();
            this.Check_Button = new System.Windows.Forms.Button();
            this.Check_All_Button = new System.Windows.Forms.Button();
            this.Call_Button = new System.Windows.Forms.Button();
            this.Call_All_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_List
            // 
            this.Name_List.FormattingEnabled = true;
            this.Name_List.Location = new System.Drawing.Point(12, 44);
            this.Name_List.Name = "Name_List";
            this.Name_List.Size = new System.Drawing.Size(165, 394);
            this.Name_List.TabIndex = 0;
            // 
            // Port_Button
            // 
            this.Port_Button.Location = new System.Drawing.Point(193, 387);
            this.Port_Button.Name = "Port_Button";
            this.Port_Button.Size = new System.Drawing.Size(114, 23);
            this.Port_Button.TabIndex = 1;
            this.Port_Button.Text = "Se Connecter";
            this.Port_Button.UseVisualStyleBackColor = true;
            this.Port_Button.Click += new System.EventHandler(this.Port_Button_Click);
            // 
            // Port_Box
            // 
            this.Port_Box.FormattingEnabled = true;
            this.Port_Box.Location = new System.Drawing.Point(193, 417);
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.Size = new System.Drawing.Size(114, 21);
            this.Port_Box.TabIndex = 2;
            // 
            // Check_Button
            // 
            this.Check_Button.Location = new System.Drawing.Point(183, 44);
            this.Check_Button.Name = "Check_Button";
            this.Check_Button.Size = new System.Drawing.Size(75, 23);
            this.Check_Button.TabIndex = 3;
            this.Check_Button.Text = "Verifier statut";
            this.Check_Button.UseVisualStyleBackColor = true;
            this.Check_Button.Click += new System.EventHandler(this.Check_Button_Click);
            // 
            // Check_All_Button
            // 
            this.Check_All_Button.Location = new System.Drawing.Point(184, 74);
            this.Check_All_Button.Name = "Check_All_Button";
            this.Check_All_Button.Size = new System.Drawing.Size(75, 23);
            this.Check_All_Button.TabIndex = 4;
            this.Check_All_Button.Text = "Verifier tous";
            this.Check_All_Button.UseVisualStyleBackColor = true;
            this.Check_All_Button.Click += new System.EventHandler(this.Check_All_Button_Click);
            // 
            // Call_Button
            // 
            this.Call_Button.Location = new System.Drawing.Point(184, 104);
            this.Call_Button.Name = "Call_Button";
            this.Call_Button.Size = new System.Drawing.Size(75, 23);
            this.Call_Button.TabIndex = 5;
            this.Call_Button.Text = "Appeler";
            this.Call_Button.UseVisualStyleBackColor = true;
            this.Call_Button.Click += new System.EventHandler(this.Call_Button_Click);
            // 
            // Call_All_Button
            // 
            this.Call_All_Button.Location = new System.Drawing.Point(184, 134);
            this.Call_All_Button.Name = "Call_All_Button";
            this.Call_All_Button.Size = new System.Drawing.Size(75, 23);
            this.Call_All_Button.TabIndex = 6;
            this.Call_All_Button.Text = "Appeler tous";
            this.Call_All_Button.UseVisualStyleBackColor = true;
            this.Call_All_Button.Click += new System.EventHandler(this.Call_All_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.Call_All_Button);
            this.Controls.Add(this.Call_Button);
            this.Controls.Add(this.Check_All_Button);
            this.Controls.Add(this.Check_Button);
            this.Controls.Add(this.Port_Box);
            this.Controls.Add(this.Port_Button);
            this.Controls.Add(this.Name_List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Name_List;
        private System.Windows.Forms.Button Port_Button;
        private System.Windows.Forms.ComboBox Port_Box;
        private System.Windows.Forms.Button Check_Button;
        private System.Windows.Forms.Button Check_All_Button;
        private System.Windows.Forms.Button Call_Button;
        private System.Windows.Forms.Button Call_All_Button;
    }
}

