
namespace Underground_Dungeon
{
    partial class CodeLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeLine));
            this.CodeLineAdd = new System.Windows.Forms.TextBox();
            this.CodelineHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CodeLineAdd
            // 
            this.CodeLineAdd.BackColor = System.Drawing.Color.Black;
            this.CodeLineAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeLineAdd.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodeLineAdd.ForeColor = System.Drawing.Color.Green;
            this.CodeLineAdd.Location = new System.Drawing.Point(2, 220);
            this.CodeLineAdd.Name = "CodeLineAdd";
            this.CodeLineAdd.Size = new System.Drawing.Size(863, 13);
            this.CodeLineAdd.TabIndex = 0;
            this.CodeLineAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeLineAdd_KeyDown);
            // 
            // CodelineHistory
            // 
            this.CodelineHistory.BackColor = System.Drawing.Color.Black;
            this.CodelineHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodelineHistory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodelineHistory.ForeColor = System.Drawing.Color.Green;
            this.CodelineHistory.Location = new System.Drawing.Point(2, -1);
            this.CodelineHistory.Name = "CodelineHistory";
            this.CodelineHistory.ReadOnly = true;
            this.CodelineHistory.Size = new System.Drawing.Size(863, 215);
            this.CodelineHistory.TabIndex = 1;
            this.CodelineHistory.Text = resources.GetString("CodelineHistory.Text");
            // 
            // CodeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(868, 252);
            this.Controls.Add(this.CodelineHistory);
            this.Controls.Add(this.CodeLineAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeLine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CodeLine";
            this.Load += new System.EventHandler(this.CodeLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeLineAdd;
        private System.Windows.Forms.RichTextBox CodelineHistory;
    }
}