namespace Frary_F26_DogWalker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblPetName = new Label();
            txtPetName = new TextBox();
            lblNumberTimesPerWeek = new Label();
            txtNumPerWeek = new TextBox();
            lstOut = new ListBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 0;
            label1.Text = "Dog Walker Weekly Calculation";
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Font = new Font("Segoe UI", 12F);
            lblPetName.Location = new Point(21, 120);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(77, 21);
            lblPetName.TabIndex = 1;
            lblPetName.Text = "Pet &Name";
            // 
            // txtPetName
            // 
            txtPetName.Font = new Font("Segoe UI", 12F);
            txtPetName.Location = new Point(156, 112);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(271, 29);
            txtPetName.TabIndex = 2;
            txtPetName.Enter += txtPetName_Enter;
            txtPetName.Leave += txtPetName_Leave;
            // 
            // lblNumberTimesPerWeek
            // 
            lblNumberTimesPerWeek.AutoSize = true;
            lblNumberTimesPerWeek.Font = new Font("Segoe UI", 12F);
            lblNumberTimesPerWeek.Location = new Point(24, 177);
            lblNumberTimesPerWeek.Name = "lblNumberTimesPerWeek";
            lblNumberTimesPerWeek.Size = new Size(119, 21);
            lblNumberTimesPerWeek.TabIndex = 3;
            lblNumberTimesPerWeek.Text = "&Times Per Week";
            // 
            // txtNumPerWeek
            // 
            txtNumPerWeek.Font = new Font("Segoe UI", 12F);
            txtNumPerWeek.Location = new Point(156, 177);
            txtNumPerWeek.Name = "txtNumPerWeek";
            txtNumPerWeek.Size = new Size(271, 29);
            txtNumPerWeek.TabIndex = 4;
            txtNumPerWeek.Enter += txtNumPerWeek_Enter;
            txtNumPerWeek.Leave += txtNumPerWeek_Leave;
            // 
            // lstOut
            // 
            lstOut.Font = new Font("Segoe UI", 12F);
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(24, 226);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(431, 130);
            lstOut.TabIndex = 5;
            lstOut.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(12, 373);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 65);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate && &Display";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(171, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 65);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 12F);
            btnQuit.Location = new Point(336, 373);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(119, 65);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lstOut);
            Controls.Add(txtNumPerWeek);
            Controls.Add(lblNumberTimesPerWeek);
            Controls.Add(txtPetName);
            Controls.Add(lblPetName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frary Dog Walker Transaction Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPetName;
        private TextBox txtPetName;
        private Label lblNumberTimesPerWeek;
        private TextBox txtNumPerWeek;
        private ListBox lstOut;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnQuit;
    }
}
