using System.Data;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace csharp
{
    public partial class Form1 : Form
    {
        private MyDB myDB = new MyDB();
        private int idCounter = 1;
        private string[]? selectedRowData;
        private int selectedID;

        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayRecords();

        }

        private void clearForm()
        {
            txtb_name.Clear();
            txtb_mobile.Clear();
            cmb_sex.SelectedIndex = -1;
            txtb_favorite.Clear();
        }

        private string errorHandler()
        {
            string errorMsg = "";

            if (txtb_name.Text.Trim().Length == 0)
                errorMsg += "Name is required.\n";
            if (txtb_mobile.Text.Trim().Length == 0)
                errorMsg += "Mobile is required.\n";
            if (cmb_sex.Text.Trim().Length == 0)
                errorMsg += "Sex is required.\n";
            if (txtb_favorite.Text.Trim().Length == 0)
                errorMsg += "Course is required.\n";
            if (myDB.RecExist("user", $"name='{txtb_name.Text.Replace("'", "\\'")}'"))
                errorMsg += "User name already exists.\n";

            return errorMsg;
        }



        private void buttons(string status)
        {
            btn_add.Enabled = status.Substring(0, 1).Equals("T") ? true : false;
            btn_save.Enabled = status.Substring(1, 1).Equals("T") ? true : false;
            btn_edit.Enabled = status.Substring(2, 1).Equals("T") ? true : false;
            btn_update.Enabled = status.Substring(3, 1).Equals("T") ? true : false;
            btn_delete.Enabled = status.Substring(4, 1).Equals("T") ? true : false;
            btn_cancel.Enabled = status.Substring(5, 1).Equals("T") ? true : false;
            txtb_search.Enabled = status.Substring(6, 1).Equals("T") ? true : false;

        }


        private void DisplayRecords()
        {
            string sql = "SELECT id, name, mobile, sex, favorite FROM user ORDER BY id DESC"; // Include 'id' in your query
            DataTable dataTable = myDB.ViewRecords(sql);

            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["name"].HeaderText = "FULLNAME";
            dataGridView1.Columns["mobile"].HeaderText = "MOBILE NO";
            dataGridView1.Columns["sex"].HeaderText = "SEX";
            dataGridView1.Columns["favorite"].HeaderText = "FAVORITE";

            // Hide the ID column
            dataGridView1.Columns["id"].Visible = false;

            buttons("TFFFFFT");
        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {

                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            buttons("FTFFFTF");
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            DisplayRecords();
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            clearForm();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (errorHandler().Length > 0)
            {
                MessageBox.Show("The following error occured:\n\n" + errorHandler(),
                                "Data Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                               );

            }
            else
            {
                string tableName = "user";
                string fields = "name, mobile, sex, favorite";
                string fieldValues = $"'{txtb_name.Text}', '{txtb_mobile.Text}', '{cmb_sex.Text}', '{txtb_favorite.Text}'";

                int result = myDB.AddRecord(tableName, fields, fieldValues);

                if (result > 0)
                {
                    MessageBox.Show("Record added successfully.");
                    clearForm();
                    DisplayRecords();
                    tabControl1.SelectedIndex = 0;
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);

                }
                else
                {
                    MessageBox.Show("Failed to add record.");
                }

            }



        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate input fields with data from the selected row
                txtb_name.Text = selectedRow.Cells["name"].Value.ToString();
                txtb_mobile.Text = selectedRow.Cells["mobile"].Value.ToString();
                cmb_sex.SelectedItem = selectedRow.Cells["sex"].Value.ToString();
                txtb_favorite.Text = selectedRow.Cells["favorite"].Value.ToString();

                tabControl1.SelectedIndex = 1;

                buttons("FFFTFTF");
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);

            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                buttons("FFTFTFF");

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    txtb_name.Text = selectedRow.Cells["name"].Value.ToString();
                    txtb_mobile.Text = selectedRow.Cells["mobile"].Value.ToString();
                    cmb_sex.SelectedItem = selectedRow.Cells["sex"].Value.ToString();
                    txtb_favorite.Text = selectedRow.Cells["favorite"].Value.ToString();
                }
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (errorHandler().Length > 0)
            {
                MessageBox.Show("The following error occured:\n\n" + errorHandler(),
                                "Data Entry",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                               );
                return;
            }
            else
            {
                string tableName = "user";
                string updateQuery = $"name = '{txtb_name.Text}', mobile = '{txtb_mobile.Text}',  sex = '{cmb_sex.Text}',  " +
                                 $"favorite = '{txtb_favorite.Text}' WHERE id = {selectedID}";

                int result = myDB.UpdateRecord(tableName, updateQuery);

                if (result > 0)
                {
                    MessageBox.Show("Record updated successfully!");
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    DisplayRecords();
                    clearForm();
                }
                else
                {
                    Console.WriteLine("Failed to update record!");
                }
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedID = Convert.ToInt32(selectedRow.Cells["id"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                              "Delete User",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int result = myDB.DeleteRecord("user", $"id = {selectedID}");

                    if (result > 0)
                    {
                        MessageBox.Show("Record deleted successfully!");
                        DisplayRecords();
                        clearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        private void txtb_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtb_search.Text.Trim();

            if (searchText.Length > 0)
            {
                char firstLetter = searchText[0];

                string sql = $"SELECT id, name, mobile, sex, favorite FROM user WHERE name LIKE '{firstLetter}%' AND name LIKE '{searchText}%' ORDER BY id DESC";
                DataTable dataTable = myDB.ViewRecords(sql);
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                DisplayRecords();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var showFrom2 = new Form2();
            showFrom2.Show();
        }
    }
}
