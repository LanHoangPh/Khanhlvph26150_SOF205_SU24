using _1._DAL.Models;
using _2._BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class FormThucung : Form
    {
        public ThucungSerrvice service = new ThucungSerrvice();

        public FormThucung(ThucungSerrvice service)
        {
            this.service = service;
        }

        public FormThucung()
        {
            InitializeComponent();

            cbb_color.DataSource = service.GetMauLong();
            
            
        }

        public void LoadDataGridView(List<Thucung> thucungs)
        {
            dtg_thucung.DataSource = null;
            dtg_thucung.Rows.Clear();
            dtg_thucung.ColumnCount = 6;
            dtg_thucung.Columns[0].Name = "STT";
            dtg_thucung.Columns[1].Name = "Id";
            dtg_thucung.Columns[2].Name = "Tên";
            dtg_thucung.Columns[3].Name = "Loài";
            dtg_thucung.Columns[4].Name = "Màu lông";
            dtg_thucung.Columns[5].Name = "Tuổi";
            dtg_thucung.Columns[1].Visible = false;
            dtg_thucung.AllowUserToAddRows = false;
            int stt = 1;
            for (int i = 0; i < thucungs.Count; i++)
            {
                dtg_thucung.Rows.Add(stt++, thucungs[i].Id, thucungs[i].Ten, thucungs[i].Loai, thucungs[i].Maulong, thucungs[i].Tuoi);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            List<Thucung> thucungs = service.GetAllThucung();
            LoadDataGridView(thucungs);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Thucung thucung = new Thucung()
            {
                Ten = tbx_name.Text,
                Loai = tbx_breed.Text,
                Maulong = tbx_color.Text,
                Tuoi = Convert.ToInt32(tbx_age.Text)
            };
            var option = MessageBox.Show("Confirm?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(service.AddThucung(thucung));
            }
            else
            {
                return;
            }
            tbx_age.Clear();
            tbx_name.Clear();
            tbx_breed.Clear();
            tbx_color.Clear();
            List<Thucung> thucungs = service.GetAllThucung();
            LoadDataGridView(thucungs);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id = (int)dtg_thucung.CurrentRow.Cells[1].Value;
            Thucung thucung = new Thucung()
            {
                Id = id,
                Ten = tbx_name.Text,
                Loai = tbx_breed.Text,
                Maulong = tbx_color.Text,
                Tuoi = Convert.ToInt32(tbx_age.Text)
            };
            var option = MessageBox.Show("Confirm?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(service.EditThucung(thucung));
            }
            else
            {
                return;
            }
            tbx_age.Clear();
            tbx_name.Clear();
            tbx_breed.Clear();
            tbx_color.Clear();
            List<Thucung> thucungs = service.GetAllThucung();
            LoadDataGridView(thucungs);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dtg_thucung.CurrentRow.Cells[1].Value;
            var option = MessageBox.Show("Confirm?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(service.DeleteThucung(id));
            }
            else
            {
                return;
            }
            tbx_age.Clear();
            tbx_name.Clear();
            tbx_breed.Clear();
            tbx_color.Clear();
            List<Thucung> thucungs = service.GetAllThucung();
            LoadDataGridView(thucungs);
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            List<Thucung> thucungs = service.GetThucungByNameOrColor(tbx_search.Text);
            LoadDataGridView(thucungs);
        }

        private void dtg_thucung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_name.Text = dtg_thucung.CurrentRow.Cells[2].Value.ToString();
            tbx_breed.Text = dtg_thucung.CurrentRow.Cells[3].Value.ToString();
            tbx_color.Text = dtg_thucung.CurrentRow.Cells[4].Value.ToString();
            tbx_age.Text = dtg_thucung.CurrentRow.Cells[5].Value.ToString();
        }

        private void cbb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_search.Clear();
            List<Thucung> thucungs = service.GetThucungByNameOrColor(cbb_color.SelectedValue.ToString());
            LoadDataGridView(thucungs);
        }
    }
}