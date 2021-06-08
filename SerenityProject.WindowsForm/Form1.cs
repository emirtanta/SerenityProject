using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerenityProject.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=SerenityDB;integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int Id = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        //List Button
        private void btnList_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        //Insert Button
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text!="" && txtSurname.Text!="" && dateTimePicker1.Text!="" && txtEmail.Text !="" && txtPassword.Text!="" && txtPhoneNumber.Text!="" && rchTxtAddress.Text!="")
            {
                cmd = new SqlCommand("insert into Members(Name,Surname,Birthdate,Email,Password,PhoneNumber,Adress) Values(@name,@surname,@birthdate,@email,@password,@phonenumber,@address) ", con);
                con.Open();

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                //cmd.Parameters.AddWithValue("@birthdate", DateTime.Parse(txtBirtdate.Text));
                cmd.Parameters.AddWithValue("@birthdate",DateTime.Parse(dateTimePicker1.Value.ToString()));
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@address", rchTxtAddress.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();

            }

            else
            {
                MessageBox.Show("Please Provide Details");
            }
        }

        

        //Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && dateTimePicker1.Text != "" && txtEmail.Text!="" && txtPassword.Text!="" && rchTxtAddress.Text!="")
            {
                cmd = new SqlCommand("update Members set Name=@name,Surname=@surname,Birthdate=@birthdate,Email=@email,Password=@password,PhoneNumber=@phonenumber,Adress=@adress where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtMemberId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                //cmd.Parameters.AddWithValue("@birthdate", txtBirtdate.Text);
                cmd.Parameters.AddWithValue("@birthdate",DateTime.Parse(dateTimePicker1.Value.ToString()));
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@adress", rchTxtAddress.Text);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                
                con.Close();

                DisplayData();

                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            cmd = new SqlCommand("Delete Members Where Id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txtMemberId.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");

            DisplayData();
            ClearData();
            
        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            //txtBirtdate.Text = "";
            dateTimePicker1.Text="";
            txtPassword.Text = "";
            txtPhoneNumber.Text = "";
            rchTxtAddress.Text = "";
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * From Members", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemberId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txtBirtdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            rchTxtAddress.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        
    }
}
