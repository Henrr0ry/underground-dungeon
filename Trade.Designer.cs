
namespace Underground_Dungeon
{
    partial class Trade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trade));
            this.buy4 = new System.Windows.Forms.Button();
            this.buy3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.poleBack = new System.Windows.Forms.Button();
            this.ZobrazeniCoinsInTrade = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buy2 = new System.Windows.Forms.Button();
            this.buy1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AudioBuy = new AxWMPLib.AxWindowsMediaPlayer();
            this.AudioFail = new AxWMPLib.AxWindowsMediaPlayer();
            this.StopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioFail)).BeginInit();
            this.SuspendLayout();
            // 
            // buy4
            // 
            this.buy4.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buy4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buy4.Location = new System.Drawing.Point(498, 307);
            this.buy4.Name = "buy4";
            this.buy4.Size = new System.Drawing.Size(127, 44);
            this.buy4.TabIndex = 20;
            this.buy4.TabStop = false;
            this.buy4.Text = "30 Coins";
            this.buy4.UseVisualStyleBackColor = true;
            this.buy4.Click += new System.EventHandler(this.buy4_Click);
            this.buy4.Enter += new System.EventHandler(this.Fokus_Enter);
            this.buy4.MouseEnter += new System.EventHandler(this.buy4_MouseEnter);
            this.buy4.MouseLeave += new System.EventHandler(this.buy4_MouseLeave);
            // 
            // buy3
            // 
            this.buy3.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buy3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buy3.Location = new System.Drawing.Point(341, 307);
            this.buy3.Name = "buy3";
            this.buy3.Size = new System.Drawing.Size(127, 44);
            this.buy3.TabIndex = 19;
            this.buy3.TabStop = false;
            this.buy3.Text = "5 Coins";
            this.buy3.UseVisualStyleBackColor = true;
            this.buy3.Click += new System.EventHandler(this.buy3_Click);
            this.buy3.Enter += new System.EventHandler(this.Fokus_Enter);
            this.buy3.MouseEnter += new System.EventHandler(this.buy3_MouseEnter);
            this.buy3.MouseLeave += new System.EventHandler(this.buy3_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Underground_Dungeon.Properties.Resources.slotSecret;
            this.pictureBox4.Location = new System.Drawing.Point(511, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // poleBack
            // 
            this.poleBack.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.poleBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poleBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poleBack.Location = new System.Drawing.Point(511, 21);
            this.poleBack.Name = "poleBack";
            this.poleBack.Size = new System.Drawing.Size(127, 44);
            this.poleBack.TabIndex = 17;
            this.poleBack.TabStop = false;
            this.poleBack.Text = "Back";
            this.poleBack.UseVisualStyleBackColor = true;
            this.poleBack.Click += new System.EventHandler(this.poleBack_Click);
            this.poleBack.Enter += new System.EventHandler(this.Fokus_Enter);
            this.poleBack.MouseEnter += new System.EventHandler(this.poleBack_MouseEnter);
            this.poleBack.MouseLeave += new System.EventHandler(this.poleBack_MouseLeave);
            // 
            // ZobrazeniCoinsInTrade
            // 
            this.ZobrazeniCoinsInTrade.AutoSize = true;
            this.ZobrazeniCoinsInTrade.BackColor = System.Drawing.Color.Silver;
            this.ZobrazeniCoinsInTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZobrazeniCoinsInTrade.Location = new System.Drawing.Point(75, 31);
            this.ZobrazeniCoinsInTrade.Name = "ZobrazeniCoinsInTrade";
            this.ZobrazeniCoinsInTrade.Size = new System.Drawing.Size(48, 25);
            this.ZobrazeniCoinsInTrade.TabIndex = 16;
            this.ZobrazeniCoinsInTrade.Text = "100";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Underground_Dungeon.Properties.Resources.slotEmpty;
            this.pictureBox3.Image = global::Underground_Dungeon.Properties.Resources.potionXPslot;
            this.pictureBox3.Location = new System.Drawing.Point(355, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Underground_Dungeon.Properties.Resources.slotEmpty;
            this.pictureBox2.Image = global::Underground_Dungeon.Properties.Resources.Chestplate1slot;
            this.pictureBox2.Location = new System.Drawing.Point(196, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // buy2
            // 
            this.buy2.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buy2.Location = new System.Drawing.Point(185, 307);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(127, 44);
            this.buy2.TabIndex = 13;
            this.buy2.TabStop = false;
            this.buy2.Text = "20 Coins";
            this.buy2.UseVisualStyleBackColor = true;
            this.buy2.Click += new System.EventHandler(this.buy2_Click);
            this.buy2.Enter += new System.EventHandler(this.Fokus_Enter);
            this.buy2.MouseEnter += new System.EventHandler(this.buy2_MouseEnter);
            this.buy2.MouseLeave += new System.EventHandler(this.buy2_MouseLeave);
            // 
            // buy1
            // 
            this.buy1.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buy1.Location = new System.Drawing.Point(26, 307);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(127, 44);
            this.buy1.TabIndex = 12;
            this.buy1.TabStop = false;
            this.buy1.Text = "10 Coins";
            this.buy1.UseVisualStyleBackColor = true;
            this.buy1.Click += new System.EventHandler(this.buy1_Click);
            this.buy1.Enter += new System.EventHandler(this.Fokus_Enter);
            this.buy1.MouseEnter += new System.EventHandler(this.buy1_MouseEnter);
            this.buy1.MouseLeave += new System.EventHandler(this.buy1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Underground_Dungeon.Properties.Resources.slotEmpty;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Underground_Dungeon.Properties.Resources.potionHeal1Slot;
            this.pictureBox1.Location = new System.Drawing.Point(39, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AudioBuy
            // 
            this.AudioBuy.Enabled = true;
            this.AudioBuy.Location = new System.Drawing.Point(241, 21);
            this.AudioBuy.Name = "AudioBuy";
            this.AudioBuy.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AudioBuy.OcxState")));
            this.AudioBuy.Size = new System.Drawing.Size(10, 10);
            this.AudioBuy.TabIndex = 21;
            this.AudioBuy.Visible = false;
            // 
            // AudioFail
            // 
            this.AudioFail.Enabled = true;
            this.AudioFail.Location = new System.Drawing.Point(257, 21);
            this.AudioFail.Name = "AudioFail";
            this.AudioFail.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AudioFail.OcxState")));
            this.AudioFail.Size = new System.Drawing.Size(10, 10);
            this.AudioFail.TabIndex = 22;
            this.AudioFail.Visible = false;
            // 
            // StopTimer
            // 
            this.StopTimer.Interval = 20;
            this.StopTimer.Tick += new System.EventHandler(this.StopTimer_Tick);
            // 
            // Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Underground_Dungeon.Properties.Resources.inventoryTrade;
            this.ClientSize = new System.Drawing.Size(662, 425);
            this.Controls.Add(this.AudioFail);
            this.Controls.Add(this.AudioBuy);
            this.Controls.Add(this.buy4);
            this.Controls.Add(this.buy3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.poleBack);
            this.Controls.Add(this.ZobrazeniCoinsInTrade);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buy2);
            this.Controls.Add(this.buy1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trade";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade";
            this.Load += new System.EventHandler(this.Trade_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Trade_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioFail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buy4;
        private System.Windows.Forms.Button buy3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button poleBack;
        private System.Windows.Forms.Label ZobrazeniCoinsInTrade;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buy2;
        private System.Windows.Forms.Button buy1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer AudioBuy;
        private AxWMPLib.AxWindowsMediaPlayer AudioFail;
        private System.Windows.Forms.Timer StopTimer;
    }
}