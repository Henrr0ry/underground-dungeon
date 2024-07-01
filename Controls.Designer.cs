
namespace Underground_Dungeon
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            this.poleTutorialBook = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.poleLeft = new System.Windows.Forms.Button();
            this.poleRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poleTutorialBook)).BeginInit();
            this.SuspendLayout();
            // 
            // poleTutorialBook
            // 
            this.poleTutorialBook.BackColor = System.Drawing.Color.DimGray;
            this.poleTutorialBook.Location = new System.Drawing.Point(461, 143);
            this.poleTutorialBook.Name = "poleTutorialBook";
            this.poleTutorialBook.Size = new System.Drawing.Size(1001, 601);
            this.poleTutorialBook.TabIndex = 21;
            this.poleTutorialBook.TabStop = false;
            this.poleTutorialBook.Paint += new System.Windows.Forms.PaintEventHandler(this.poleTutorialBook_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1765, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // poleLeft
            // 
            this.poleLeft.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.poleLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.poleLeft.Location = new System.Drawing.Point(461, 750);
            this.poleLeft.Name = "poleLeft";
            this.poleLeft.Size = new System.Drawing.Size(127, 44);
            this.poleLeft.TabIndex = 22;
            this.poleLeft.Text = "<";
            this.poleLeft.UseVisualStyleBackColor = true;
            this.poleLeft.Click += new System.EventHandler(this.poleLeft_Click);
            this.poleLeft.MouseEnter += new System.EventHandler(this.poleLeft_MouseEnter);
            this.poleLeft.MouseLeave += new System.EventHandler(this.poleLeft_MouseLeave);
            // 
            // poleRight
            // 
            this.poleRight.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.poleRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.poleRight.Location = new System.Drawing.Point(1335, 750);
            this.poleRight.Name = "poleRight";
            this.poleRight.Size = new System.Drawing.Size(127, 44);
            this.poleRight.TabIndex = 23;
            this.poleRight.Text = ">";
            this.poleRight.UseVisualStyleBackColor = true;
            this.poleRight.Click += new System.EventHandler(this.poleRight_Click);
            this.poleRight.MouseEnter += new System.EventHandler(this.poleRight_MouseEnter);
            this.poleRight.MouseLeave += new System.EventHandler(this.poleRight_MouseLeave);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.poleRight);
            this.Controls.Add(this.poleLeft);
            this.Controls.Add(this.poleTutorialBook);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controls";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Underground Dungeon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Controls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poleTutorialBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox poleTutorialBook;
        private System.Windows.Forms.Button poleLeft;
        private System.Windows.Forms.Button poleRight;
    }
}