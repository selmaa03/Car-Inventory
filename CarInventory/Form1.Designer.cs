namespace CarInventory
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
            listBoxCars = new ListBox();
            buttonAdd = new Button();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // listBoxCars
            // 
            listBoxCars.FormattingEnabled = true;
            listBoxCars.ItemHeight = 15;
            listBoxCars.Location = new Point(25, 23);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(360, 199);
            listBoxCars.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(107, 256);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(230, 256);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 307);
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxCars);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCars;
        private Button buttonAdd;
        private Button buttonDel;
    }
}
