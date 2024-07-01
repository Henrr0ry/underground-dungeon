
namespace Underground_Dungeon
{
    partial class GameSetting
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
            this.LogoGameMenu = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SaveIcon = new System.Windows.Forms.PictureBox();
            this.PictureUser1 = new System.Windows.Forms.PictureBox();
            this.PictureUser2 = new System.Windows.Forms.PictureBox();
            this.PictureUser3 = new System.Windows.Forms.PictureBox();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.buttonDetele1 = new System.Windows.Forms.Button();
            this.SexBox1 = new System.Windows.Forms.ComboBox();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description1 = new System.Windows.Forms.RichTextBox();
            this.SaveAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonUser1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFullscreen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameBox2 = new System.Windows.Forms.TextBox();
            this.NameBox3 = new System.Windows.Forms.TextBox();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.buttonDetele2 = new System.Windows.Forms.Button();
            this.Description2 = new System.Windows.Forms.RichTextBox();
            this.SexBox2 = new System.Windows.Forms.ComboBox();
            this.buttonUser2 = new System.Windows.Forms.Button();
            this.buttonUser3 = new System.Windows.Forms.Button();
            this.buttonSave3 = new System.Windows.Forms.Button();
            this.buttonDetele3 = new System.Windows.Forms.Button();
            this.SexBox3 = new System.Windows.Forms.ComboBox();
            this.Description3 = new System.Windows.Forms.RichTextBox();
            this.TrackBarSounds = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarMusic = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoGameMenu
            // 
            this.LogoGameMenu.AutoSize = true;
            this.LogoGameMenu.BackColor = System.Drawing.Color.Silver;
            this.LogoGameMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoGameMenu.Location = new System.Drawing.Point(134, 24);
            this.LogoGameMenu.Name = "LogoGameMenu";
            this.LogoGameMenu.Size = new System.Drawing.Size(204, 37);
            this.LogoGameMenu.TabIndex = 1;
            this.LogoGameMenu.Text = "Setting Menu";
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(348, 24);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(128, 46);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // SaveIcon
            // 
            this.SaveIcon.BackColor = System.Drawing.Color.Transparent;
            this.SaveIcon.Image = global::Underground_Dungeon.Properties.Resources.SaveIcon0;
            this.SaveIcon.Location = new System.Drawing.Point(12, 12);
            this.SaveIcon.Name = "SaveIcon";
            this.SaveIcon.Size = new System.Drawing.Size(50, 50);
            this.SaveIcon.TabIndex = 4;
            this.SaveIcon.TabStop = false;
            this.SaveIcon.Visible = false;
            // 
            // PictureUser1
            // 
            this.PictureUser1.Image = global::Underground_Dungeon.Properties.Resources.slotEmpty;
            this.PictureUser1.Location = new System.Drawing.Point(8, 235);
            this.PictureUser1.Name = "PictureUser1";
            this.PictureUser1.Size = new System.Drawing.Size(100, 100);
            this.PictureUser1.TabIndex = 5;
            this.PictureUser1.TabStop = false;
            this.PictureUser1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureUser1_Paint);
            // 
            // PictureUser2
            // 
            this.PictureUser2.Image = global::Underground_Dungeon.Properties.Resources.slotEmpty;
            this.PictureUser2.Location = new System.Drawing.Point(8, 366);
            this.PictureUser2.Name = "PictureUser2";
            this.PictureUser2.Size = new System.Drawing.Size(100, 100);
            this.PictureUser2.TabIndex = 6;
            this.PictureUser2.TabStop = false;
            this.PictureUser2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureUser2_Paint);
            // 
            // PictureUser3
            // 
            this.PictureUser3.Image = global::Underground_Dungeon.Properties.Resources.slotEmpty;
            this.PictureUser3.Location = new System.Drawing.Point(8, 495);
            this.PictureUser3.Name = "PictureUser3";
            this.PictureUser3.Size = new System.Drawing.Size(100, 100);
            this.PictureUser3.TabIndex = 7;
            this.PictureUser3.TabStop = false;
            this.PictureUser3.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureUser3_Paint);
            // 
            // buttonSave1
            // 
            this.buttonSave1.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave1.Location = new System.Drawing.Point(344, 235);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(128, 46);
            this.buttonSave1.TabIndex = 8;
            this.buttonSave1.Text = "Save";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave1_Click);
            this.buttonSave1.MouseEnter += new System.EventHandler(this.buttonSave1_MouseEnter);
            this.buttonSave1.MouseLeave += new System.EventHandler(this.buttonSave1_MouseLeave);
            // 
            // buttonDetele1
            // 
            this.buttonDetele1.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonDetele1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDetele1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetele1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDetele1.Location = new System.Drawing.Point(344, 287);
            this.buttonDetele1.Name = "buttonDetele1";
            this.buttonDetele1.Size = new System.Drawing.Size(128, 46);
            this.buttonDetele1.TabIndex = 9;
            this.buttonDetele1.Text = "Detele";
            this.buttonDetele1.UseVisualStyleBackColor = true;
            this.buttonDetele1.Click += new System.EventHandler(this.buttonDetele1_Click);
            this.buttonDetele1.MouseEnter += new System.EventHandler(this.buttonDetele1_MouseEnter);
            this.buttonDetele1.MouseLeave += new System.EventHandler(this.buttonDetele1_MouseLeave);
            // 
            // SexBox1
            // 
            this.SexBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexBox1.Location = new System.Drawing.Point(177, 265);
            this.SexBox1.Name = "SexBox1";
            this.SexBox1.Size = new System.Drawing.Size(90, 21);
            this.SexBox1.TabIndex = 10;
            this.SexBox1.SelectedValueChanged += new System.EventHandler(this.SexBox_SelectedValueChanged);
            // 
            // NameBox1
            // 
            this.NameBox1.Location = new System.Drawing.Point(177, 239);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(90, 20);
            this.NameBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(114, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(129, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gender";
            // 
            // Description1
            // 
            this.Description1.BackColor = System.Drawing.Color.DarkGray;
            this.Description1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description1.Location = new System.Drawing.Point(114, 292);
            this.Description1.Name = "Description1";
            this.Description1.ReadOnly = true;
            this.Description1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Description1.Size = new System.Drawing.Size(224, 68);
            this.Description1.TabIndex = 14;
            this.Description1.Text = "";
            // 
            // SaveAnimationTimer
            // 
            this.SaveAnimationTimer.Interval = 3000;
            this.SaveAnimationTimer.Tick += new System.EventHandler(this.SaveAnimationTimer_Tick);
            // 
            // buttonUser1
            // 
            this.buttonUser1.BackgroundImage = global::Underground_Dungeon.Properties.Resources.buttonDeny;
            this.buttonUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUser1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser1.Location = new System.Drawing.Point(296, 239);
            this.buttonUser1.Name = "buttonUser1";
            this.buttonUser1.Size = new System.Drawing.Size(42, 42);
            this.buttonUser1.TabIndex = 15;
            this.buttonUser1.UseVisualStyleBackColor = true;
            this.buttonUser1.Click += new System.EventHandler(this.buttonUser1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(147, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fullscreen";
            // 
            // buttonFullscreen
            // 
            this.buttonFullscreen.BackgroundImage = global::Underground_Dungeon.Properties.Resources.buttonDeny;
            this.buttonFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullscreen.Location = new System.Drawing.Point(265, 164);
            this.buttonFullscreen.Name = "buttonFullscreen";
            this.buttonFullscreen.Size = new System.Drawing.Size(42, 42);
            this.buttonFullscreen.TabIndex = 17;
            this.buttonFullscreen.UseVisualStyleBackColor = true;
            this.buttonFullscreen.Click += new System.EventHandler(this.buttonFullscreen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(114, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(114, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(129, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(129, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Gender";
            // 
            // NameBox2
            // 
            this.NameBox2.Location = new System.Drawing.Point(177, 366);
            this.NameBox2.Name = "NameBox2";
            this.NameBox2.Size = new System.Drawing.Size(90, 20);
            this.NameBox2.TabIndex = 22;
            // 
            // NameBox3
            // 
            this.NameBox3.Location = new System.Drawing.Point(177, 495);
            this.NameBox3.Name = "NameBox3";
            this.NameBox3.Size = new System.Drawing.Size(90, 20);
            this.NameBox3.TabIndex = 23;
            // 
            // buttonSave2
            // 
            this.buttonSave2.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave2.Location = new System.Drawing.Point(344, 369);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(128, 46);
            this.buttonSave2.TabIndex = 24;
            this.buttonSave2.Text = "Save";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            this.buttonSave2.MouseEnter += new System.EventHandler(this.buttonSave2_MouseEnter);
            this.buttonSave2.MouseLeave += new System.EventHandler(this.buttonSave2_MouseLeave);
            // 
            // buttonDetele2
            // 
            this.buttonDetele2.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonDetele2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDetele2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetele2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDetele2.Location = new System.Drawing.Point(344, 421);
            this.buttonDetele2.Name = "buttonDetele2";
            this.buttonDetele2.Size = new System.Drawing.Size(128, 46);
            this.buttonDetele2.TabIndex = 25;
            this.buttonDetele2.Text = "Detele";
            this.buttonDetele2.UseVisualStyleBackColor = true;
            this.buttonDetele2.Click += new System.EventHandler(this.buttonDetele2_Click);
            this.buttonDetele2.MouseEnter += new System.EventHandler(this.buttonDetele2_MouseEnter);
            this.buttonDetele2.MouseLeave += new System.EventHandler(this.buttonDetele2_MouseLeave);
            // 
            // Description2
            // 
            this.Description2.BackColor = System.Drawing.Color.DarkGray;
            this.Description2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description2.Location = new System.Drawing.Point(114, 421);
            this.Description2.Name = "Description2";
            this.Description2.ReadOnly = true;
            this.Description2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Description2.Size = new System.Drawing.Size(224, 68);
            this.Description2.TabIndex = 26;
            this.Description2.Text = "";
            // 
            // SexBox2
            // 
            this.SexBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexBox2.Location = new System.Drawing.Point(177, 392);
            this.SexBox2.Name = "SexBox2";
            this.SexBox2.Size = new System.Drawing.Size(90, 21);
            this.SexBox2.TabIndex = 27;
            this.SexBox2.SelectedValueChanged += new System.EventHandler(this.SexBox_SelectedValueChanged);
            // 
            // buttonUser2
            // 
            this.buttonUser2.BackgroundImage = global::Underground_Dungeon.Properties.Resources.buttonDeny;
            this.buttonUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUser2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser2.Location = new System.Drawing.Point(296, 369);
            this.buttonUser2.Name = "buttonUser2";
            this.buttonUser2.Size = new System.Drawing.Size(42, 42);
            this.buttonUser2.TabIndex = 28;
            this.buttonUser2.UseVisualStyleBackColor = true;
            this.buttonUser2.Click += new System.EventHandler(this.buttonUser2_Click);
            // 
            // buttonUser3
            // 
            this.buttonUser3.BackgroundImage = global::Underground_Dungeon.Properties.Resources.buttonDeny;
            this.buttonUser3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUser3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser3.Location = new System.Drawing.Point(296, 495);
            this.buttonUser3.Name = "buttonUser3";
            this.buttonUser3.Size = new System.Drawing.Size(42, 42);
            this.buttonUser3.TabIndex = 29;
            this.buttonUser3.UseVisualStyleBackColor = true;
            this.buttonUser3.Click += new System.EventHandler(this.buttonUser3_Click);
            // 
            // buttonSave3
            // 
            this.buttonSave3.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonSave3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave3.Location = new System.Drawing.Point(344, 495);
            this.buttonSave3.Name = "buttonSave3";
            this.buttonSave3.Size = new System.Drawing.Size(128, 46);
            this.buttonSave3.TabIndex = 30;
            this.buttonSave3.Text = "Save";
            this.buttonSave3.UseVisualStyleBackColor = true;
            this.buttonSave3.Click += new System.EventHandler(this.buttonSave3_Click);
            this.buttonSave3.MouseEnter += new System.EventHandler(this.buttonSave3_MouseEnter);
            this.buttonSave3.MouseLeave += new System.EventHandler(this.buttonSave3_MouseLeave);
            // 
            // buttonDetele3
            // 
            this.buttonDetele3.BackgroundImage = global::Underground_Dungeon.Properties.Resources.button1;
            this.buttonDetele3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDetele3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetele3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDetele3.Location = new System.Drawing.Point(344, 547);
            this.buttonDetele3.Name = "buttonDetele3";
            this.buttonDetele3.Size = new System.Drawing.Size(128, 46);
            this.buttonDetele3.TabIndex = 31;
            this.buttonDetele3.Text = "Detele";
            this.buttonDetele3.UseVisualStyleBackColor = true;
            this.buttonDetele3.Click += new System.EventHandler(this.buttonDetele3_Click);
            this.buttonDetele3.MouseEnter += new System.EventHandler(this.buttonDetele3_MouseEnter);
            this.buttonDetele3.MouseLeave += new System.EventHandler(this.buttonDetele3_MouseLeave);
            // 
            // SexBox3
            // 
            this.SexBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexBox3.Location = new System.Drawing.Point(177, 521);
            this.SexBox3.Name = "SexBox3";
            this.SexBox3.Size = new System.Drawing.Size(90, 21);
            this.SexBox3.TabIndex = 32;
            this.SexBox3.SelectedValueChanged += new System.EventHandler(this.SexBox_SelectedValueChanged);
            // 
            // Description3
            // 
            this.Description3.BackColor = System.Drawing.Color.DarkGray;
            this.Description3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description3.Location = new System.Drawing.Point(114, 547);
            this.Description3.Name = "Description3";
            this.Description3.ReadOnly = true;
            this.Description3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Description3.Size = new System.Drawing.Size(224, 68);
            this.Description3.TabIndex = 33;
            this.Description3.Text = "";
            // 
            // TrackBarSounds
            // 
            this.TrackBarSounds.BackColor = System.Drawing.Color.Silver;
            this.TrackBarSounds.Location = new System.Drawing.Point(36, 76);
            this.TrackBarSounds.Maximum = 100;
            this.TrackBarSounds.Name = "TrackBarSounds";
            this.TrackBarSounds.Size = new System.Drawing.Size(141, 45);
            this.TrackBarSounds.TabIndex = 34;
            this.TrackBarSounds.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarSounds.Value = 100;
            this.TrackBarSounds.Scroll += new System.EventHandler(this.TrackBarSounds_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(31, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Sounds Volume";
            // 
            // trackBarMusic
            // 
            this.trackBarMusic.BackColor = System.Drawing.Color.Silver;
            this.trackBarMusic.Location = new System.Drawing.Point(296, 76);
            this.trackBarMusic.Maximum = 100;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(141, 45);
            this.trackBarMusic.TabIndex = 36;
            this.trackBarMusic.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMusic.Value = 100;
            this.trackBarMusic.Scroll += new System.EventHandler(this.trackBarMusic_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(291, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Music Volume";
            // 
            // GameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Underground_Dungeon.Properties.Resources.inventorySettingeMenu;
            this.ClientSize = new System.Drawing.Size(488, 646);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBarMusic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TrackBarSounds);
            this.Controls.Add(this.Description3);
            this.Controls.Add(this.SexBox3);
            this.Controls.Add(this.buttonDetele3);
            this.Controls.Add(this.buttonSave3);
            this.Controls.Add(this.buttonUser3);
            this.Controls.Add(this.buttonUser2);
            this.Controls.Add(this.SexBox2);
            this.Controls.Add(this.Description2);
            this.Controls.Add(this.buttonDetele2);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.NameBox3);
            this.Controls.Add(this.NameBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFullscreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUser1);
            this.Controls.Add(this.Description1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox1);
            this.Controls.Add(this.SexBox1);
            this.Controls.Add(this.buttonDetele1);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.PictureUser3);
            this.Controls.Add(this.PictureUser2);
            this.Controls.Add(this.PictureUser1);
            this.Controls.Add(this.SaveIcon);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.LogoGameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSetting";
            this.Load += new System.EventHandler(this.GameSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoGameMenu;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox SaveIcon;
        private System.Windows.Forms.PictureBox PictureUser1;
        private System.Windows.Forms.PictureBox PictureUser2;
        private System.Windows.Forms.PictureBox PictureUser3;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.Button buttonDetele1;
        private System.Windows.Forms.ComboBox SexBox1;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description1;
        private System.Windows.Forms.Timer SaveAnimationTimer;
        private System.Windows.Forms.Button buttonUser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFullscreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameBox2;
        private System.Windows.Forms.TextBox NameBox3;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Button buttonDetele2;
        private System.Windows.Forms.RichTextBox Description2;
        private System.Windows.Forms.ComboBox SexBox2;
        private System.Windows.Forms.Button buttonUser2;
        private System.Windows.Forms.Button buttonUser3;
        private System.Windows.Forms.Button buttonSave3;
        private System.Windows.Forms.Button buttonDetele3;
        private System.Windows.Forms.ComboBox SexBox3;
        private System.Windows.Forms.RichTextBox Description3;
        private System.Windows.Forms.TrackBar TrackBarSounds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarMusic;
        private System.Windows.Forms.Label label9;
    }
}