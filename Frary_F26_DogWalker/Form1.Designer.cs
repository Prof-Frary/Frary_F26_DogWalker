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
            label2 = new Label();
            txtPetName = new TextBox();
            label3 = new Label();
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
            label1.Location = new Point(94, 72);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Dog Walker Weekly Calculation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 120);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Pet Name";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(110, 112);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(152, 23);
            txtPetName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 177);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Times Per Week";
            // 
            // txtNumPerWeek
            // 
            txtNumPerWeek.Location = new Point(136, 174);
            txtNumPerWeek.Name = "txtNumPerWeek";
            txtNumPerWeek.Size = new Size(100, 23);
            txtNumPerWeek.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(20, 219);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(288, 139);
            lstOut.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(20, 382);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 45);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate && &Display";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(132, 382);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 45);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(233, 382);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 45);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lstOut);
            Controls.Add(txtNumPerWeek);
            Controls.Add(label3);
            Controls.Add(txtPetName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frary Dog Walker Transaction Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPetName;
        private Label label3;
        private TextBox txtNumPerWeek;
        private ListBox lstOut;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnQuit;
    }
}
