using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            track_vol.Value = 50;
            lab_100.Text = "50%";
        }
        //Khai báo:
        string[] paths, files;

        //Button thêm nhạc hoặc video:
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "mp3 files, mp4 files |*.mp*";
            ofd.Multiselect = true;
            ofd.Title = "Chọn bài hát";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Lấy tên file:
                files = ofd.SafeFileNames;
                //Lấy đường dẫn file:
                paths = ofd.FileNames;
                //Duyệt qua tất cả các file rồi thêm vào danh sách:
                for (int i = 0; i < files.Length; i++)
                {
                    list_track.Items.Add(files[i]);
                }
            }
        }

        //Danh sách phát: Khi nháy chuột vào bài hát sẽ phát:
        private void list_track_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[list_track.SelectedIndex];
            player.Ctlcontrols.play();
        }

        //Nút tạm dừng:
        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        //Nút dừng:
        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lab_head.Text = "00:00";
            p_bar.Value = 0;
        }

        //Nút xem video toàn màn hình:
        private void btn_video_Click(object sender, EventArgs e)
        {
            if (player.URL.Length > 0)
            {
                player.fullScreen = true;
            }
        }

        //Nút qua bài khác:
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (list_track.SelectedIndex > 0)
            {
                list_track.SelectedIndex = list_track.SelectedIndex - 1;
            }
        }

        //Bộ đếm thời gian:
        private void timer_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;

                lab_head.Text = player.Ctlcontrols.currentPositionString;
                lab_tail.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
        }

        //Tăng giảm âm lượng
        private void track_vol_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_vol.Value;
            lab_100.Text = track_vol.Value.ToString() + "%";
        }

        //Nút tiếp tục:
        private void btn_continue_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        //Thiết lập tua nhanh:
        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        //Nút quay lại bài trước:
        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (list_track.SelectedIndex > 0)
            {
                list_track.SelectedIndex = list_track.SelectedIndex + 1;
            }
        }
    }
}
