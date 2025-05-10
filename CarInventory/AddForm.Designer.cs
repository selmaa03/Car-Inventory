namespace CarInventory
{
    partial class AddForm
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
            textBoxMd = new TextBox();
            textBoxMf = new TextBox();
            textBoxSp = new TextBox();
            textBoxWg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxMd
            // 
            textBoxMd.Location = new Point(151, 28);
            textBoxMd.Name = "textBoxMd";
            textBoxMd.Size = new Size(254, 23);
            textBoxMd.TabIndex = 0;
            // 
            // textBoxMf
            // 
            textBoxMf.Location = new Point(151, 68);
            textBoxMf.Name = "textBoxMf";
            textBoxMf.Size = new Size(254, 23);
            textBoxMf.TabIndex = 1;
            // 
            // textBoxSp
            // 
            textBoxSp.Location = new Point(151, 107);
            textBoxSp.Name = "textBoxSp";
            textBoxSp.Size = new Size(254, 23);
            textBoxSp.TabIndex = 2;
            // 
            // textBoxWg
            // 
            textBoxWg.Location = new Point(151, 152);
            textBoxWg.Name = "textBoxWg";
            textBoxWg.Size = new Size(254, 23);
            textBoxWg.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 5;
            label2.Text = "Year of Manufacture";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 110);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Speed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 155);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Weight";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(406, 198);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 233);
            Controls.Add(buttonSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxWg);
            Controls.Add(textBoxSp);
            Controls.Add(textBoxMf);
            Controls.Add(textBoxMd);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMd;
        private TextBox textBoxMf;
        private TextBox textBoxSp;
        private TextBox textBoxWg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonSave;
    }
}