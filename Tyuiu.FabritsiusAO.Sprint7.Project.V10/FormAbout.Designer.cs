namespace Tyuiu.FabritsiusAO.Sprint7.Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_FAO = new Button();
            textBoxHelp_FAO = new TextBox();
            SuspendLayout();
            // 
            // buttonOK_FAO
            // 
            buttonOK_FAO.Cursor = Cursors.Hand;
            buttonOK_FAO.Location = new Point(354, 180);
            buttonOK_FAO.Name = "buttonOK_FAO";
            buttonOK_FAO.Size = new Size(75, 23);
            buttonOK_FAO.TabIndex = 4;
            buttonOK_FAO.Text = "Ок";
            buttonOK_FAO.UseVisualStyleBackColor = true;
            buttonOK_FAO.Click += buttonOK_FAO_Click;
            // 
            // textBoxHelp_FAO
            // 
            textBoxHelp_FAO.Location = new Point(12, 12);
            textBoxHelp_FAO.Multiline = true;
            textBoxHelp_FAO.Name = "textBoxHelp_FAO";
            textBoxHelp_FAO.ReadOnly = true;
            textBoxHelp_FAO.Size = new Size(430, 151);
            textBoxHelp_FAO.TabIndex = 3;
            textBoxHelp_FAO.TabStop = false;
            textBoxHelp_FAO.Text = resources.GetString("textBoxHelp_FAO.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 232);
            Controls.Add(buttonOK_FAO);
            Controls.Add(textBoxHelp_FAO);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(479, 271);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOK_FAO;
        private TextBox textBoxHelp_FAO;
    }
}