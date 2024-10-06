using Npgsql;
using System.Data;
using System.Data.Common;

namespace TestTaskProject;

public partial class Form1 : Form
{
    public string connectionString = @"Host=localhost;Username=postgres;Port=5432;Database=postgres;Password=0932;";
    private NpgsqlConnection connection;
    private NpgsqlDataAdapter dataAdapter;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        RefreshDataGridView();
        AddTeacher();

    }
    void AddTeacher()
    {
        DataTable teacher = GetData("select t.id, concat(t.name , '-', t.salary) as name  from teachers t join subjects s on t.id = s.teachers_id ;");
        comboBox1.DisplayMember = "name";
        comboBox1.ValueMember = "id";
        comboBox1.DataSource = teacher;
        comboBox1.SelectedIndex = -1;
    }

    private void RefreshDataGridView()
    {
        ReadDataView.DataSource = GetData("select t.name as name, t.age, t.salary, string_agg(s.name, ', ')as subject from teachers t " +
            "join subjects s on t.id = s.teachers_id " +
            "where t.id = s.teachers_id " +
            "group by t.name, t.age, t.salary;");

        dataGridView1.DataSource = GetData("select name, age, salary from teachers;");
        dataGridView2.DataSource = GetData("select id, name, age, salary from teachers;");
        UpdateDGVT.DataSource = GetData("select id, name, age, salary from teachers;");
        dataGridView3.DataSource = GetData("select t.name,string_agg(s.name,'-') from subjects s join teachers t on t.id = s.teachers_id group by t.id,t.name;");
        dataGridView4.DataSource = GetData("select s.id, s.name as subject, t.name as name from subjects s join teachers t on s.teachers_id = t.id;");
    }

    private DataTable GetData(string sql)
    {
        DataTable dt = new DataTable();
        using (connection = new NpgsqlConnection(connectionString))
        {
            dataAdapter = new NpgsqlDataAdapter(sql, connectionString);
            dataAdapter.Fill(dt);
            return dt;
        }
    }

    private void CreateTeacherButton_Click(object sender, EventArgs e)
    {
        using (connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            var name = TeacherNameTB.Text;
            int age = Convert.ToInt32(TeacherAgeTB.Text);
            int salary = Convert.ToInt32(TeacherSalaryTB.Text);

            var sql = "insert into teachers (name, age, salary) values (@name, @age, @salary);";

            try
            {
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(TeacherAgeTB.Text) && !string.IsNullOrEmpty(TeacherSalaryTB.Text))
                {
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data added successfully!", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        RefreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("The data is not fully entered. Please re-enter!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }

    private void TeacherAgeTB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
        {
            e.Handled = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using (connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            var id = UpdateIDTeacherTB.Text;
            var name = UpdateNameTeacherTB.Text;
            var age = UpdateAgeTeacherTB.Text;
            var salary = UpdateSalaryTeacherTB.Text;

            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    var sql = "update teachers set ";
                    bool isEmpty = false;

                    if (!string.IsNullOrEmpty(name))
                    {
                        sql += $"name = @name ";
                        isEmpty = true;
                    }

                    if (!string.IsNullOrEmpty(age))
                    {
                        sql += (isEmpty ? ", " : " ") + $"age = {age} ";
                        isEmpty = true;
                    }

                    if (!string.IsNullOrEmpty(salary))
                    {
                        sql += (isEmpty ? ", " : " ") + $"salary = {salary} ";
                    }

                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@salary", salary);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data changed successfully.", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        RefreshDataGridView();

                        UpdateIDTeacherTB.Text = string.Empty;
                        UpdateNameTeacherTB.Text = string.Empty;
                        UpdateAgeTeacherTB.Text = string.Empty;
                        UpdateSalaryTeacherTB.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("ID number not entered or not found. Please try again!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }

    private void UpdateIDTeacherTB_TextChanged(object sender, EventArgs e)
    {
        if (UpdateIDTeacherTB.Text != "")
        {
            UpdateDGVT.DataSource = GetData($"select id, name, age, salary from teachers where id = {UpdateIDTeacherTB.Text};");
        }

        if (UpdateIDTeacherTB.Text == "")
        {
            UpdateDGVT.DataSource = GetData($"select id, name, age, salary from teachers;");
        }
    }

    private void DeleteTeacherButton_Click(object sender, EventArgs e)
    {
        using (connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            try
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    int selectedID = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    var sql = $"delete from teachers where id = {selectedID}";

                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        RefreshDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBox1.SelectedIndex != -1 && textBox1.Text != "")
            {
                var id = comboBox1.SelectedValue;
                var sql = $"insert into subjects (teachers_id, name) values ({comboBox1.SelectedValue},'{textBox1.Text}');";
                MessageBox.Show("Data added successfully!", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                GetData(sql);
                RefreshDataGridView();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

    }

    private void DeleteSubjectButton_Click(object sender, EventArgs e)
    {
        if(dataGridView4.SelectedRows.Count > 0)
        {
            DataGridViewRow selected = dataGridView4.SelectedRows[0];

            var id = selected.Cells["id"].Value;
            var sql = $"delete from subjects where id = {id}";
            GetData(sql);
            RefreshDataGridView();
        }
    }
}