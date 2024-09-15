namespace QuoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnQuote = new Button();
            SuspendLayout();
            // 
            // btnQuote
            // 
            btnQuote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuote.Cursor = Cursors.Hand;
            btnQuote.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuote.Location = new Point(119, 81);
            btnQuote.Name = "btnQuote";
            btnQuote.Size = new Size(164, 57);
            btnQuote.TabIndex = 0;
            btnQuote.Text = "Quote Me";
            btnQuote.UseVisualStyleBackColor = true;
            btnQuote.Click += btnQuote_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(405, 232);
            Controls.Add(btnQuote);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QuoteApp";
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuote;
    }
}
