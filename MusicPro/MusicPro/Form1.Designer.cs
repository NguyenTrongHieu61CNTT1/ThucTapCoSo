
namespace MusicPro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.list_track = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_vol = new System.Windows.Forms.TrackBar();
            this.lab_vol = new System.Windows.Forms.Label();
            this.lab_head = new System.Windows.Forms.Label();
            this.lab_tail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_100 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_vol)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pause.Location = new System.Drawing.Point(257, 286);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(70, 57);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "Tạm Dừng";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_stop.Location = new System.Drawing.Point(333, 286);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(66, 57);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Dừng";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_video
            // 
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_video.Location = new System.Drawing.Point(405, 286);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(70, 57);
            this.btn_video.TabIndex = 3;
            this.btn_video.Text = "Xem Video";
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_open.Location = new System.Drawing.Point(481, 286);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(139, 57);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Thêm nhạc hoặc video";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(12, 270);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(608, 10);
            this.p_bar.TabIndex = 5;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // list_track
            // 
            this.list_track.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_track.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_track.ForeColor = System.Drawing.SystemColors.Info;
            this.list_track.FormattingEnabled = true;
            this.list_track.ItemHeight = 16;
            this.list_track.Location = new System.Drawing.Point(3, 2);
            this.list_track.Name = "list_track";
            this.list_track.Size = new System.Drawing.Size(434, 176);
            this.list_track.TabIndex = 6;
            this.list_track.SelectedIndexChanged += new System.EventHandler(this.list_track_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(490, 2);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(96, 104);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_art.TabIndex = 7;
            this.pic_art.TabStop = false;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(632, 65);
            this.player.TabIndex = 8;
            // 
            // track_vol
            // 
            this.track_vol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.track_vol.Location = new System.Drawing.Point(443, 122);
            this.track_vol.Maximum = 100;
            this.track_vol.Name = "track_vol";
            this.track_vol.Size = new System.Drawing.Size(177, 56);
            this.track_vol.TabIndex = 9;
            this.track_vol.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_vol.Scroll += new System.EventHandler(this.track_vol_Scroll);
            // 
            // lab_vol
            // 
            this.lab_vol.AutoSize = true;
            this.lab_vol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_vol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lab_vol.Location = new System.Drawing.Point(501, 161);
            this.lab_vol.Name = "lab_vol";
            this.lab_vol.Size = new System.Drawing.Size(72, 17);
            this.lab_vol.TabIndex = 10;
            this.lab_vol.Text = "Âm Lượng";
            // 
            // lab_head
            // 
            this.lab_head.AutoSize = true;
            this.lab_head.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lab_head.Location = new System.Drawing.Point(12, 18);
            this.lab_head.Name = "lab_head";
            this.lab_head.Size = new System.Drawing.Size(140, 46);
            this.lab_head.TabIndex = 12;
            this.lab_head.Text = "00:00";
            // 
            // lab_tail
            // 
            this.lab_tail.AutoSize = true;
            this.lab_tail.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lab_tail.Location = new System.Drawing.Point(473, 18);
            this.lab_tail.Name = "lab_tail";
            this.lab_tail.Size = new System.Drawing.Size(140, 46);
            this.lab_tail.TabIndex = 13;
            this.lab_tail.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.list_track);
            this.panel1.Controls.Add(this.lab_vol);
            this.panel1.Controls.Add(this.lab_100);
            this.panel1.Controls.Add(this.pic_art);
            this.panel1.Controls.Add(this.track_vol);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 182);
            this.panel1.TabIndex = 14;
            // 
            // lab_100
            // 
            this.lab_100.AutoSize = true;
            this.lab_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lab_100.Location = new System.Drawing.Point(521, 102);
            this.lab_100.Name = "lab_100";
            this.lab_100.Size = new System.Drawing.Size(44, 17);
            this.lab_100.TabIndex = 11;
            this.lab_100.Text = "100%";
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_next.Location = new System.Drawing.Point(94, 286);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 57);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Bài Trước";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pre.Location = new System.Drawing.Point(12, 286);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(76, 57);
            this.btn_pre.TabIndex = 16;
            this.btn_pre.Text = "Bài Sau";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_continue
            // 
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_continue.Location = new System.Drawing.Point(182, 286);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(69, 57);
            this.btn_continue.TabIndex = 17;
            this.btn_continue.Text = "Tiếp Tục";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(632, 355);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lab_tail);
            this.Controls.Add(this.lab_head);
            this.Controls.Add(this.player);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng nghe nhạc MusicPro";
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_vol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox list_track;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_vol;
        private System.Windows.Forms.Label lab_vol;
        private System.Windows.Forms.Label lab_head;
        private System.Windows.Forms.Label lab_tail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lab_100;
        private System.Windows.Forms.Button btn_continue;
    }
}

