using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE
{
    public partial class Form1 : Form
    {
        private string conncetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\farah\\OneDrive\\المستندات\\ClothesData.accdb";
        private OleDbConnection con;
        public Form1()
        {
            con = new OleDbConnection(conncetionString);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            InsertStudent(txtStudentNo.Text, txtStudentFirstName.Text, txtStudentLastName.Text);
            ClearForm();
            UpdateStudentsGired();
            
        }
        private void UpdateStudentsGired()
        { }
        private void InsertStudent(string StudendNo, string StudentFirstName, string StudentLastName)
        {
            string insertCommand = $"Insert Into Student(StudentNo , StudentFirstName,StudentLastName) "
                + $"values('{StudendNo}','{StudentFirstName}','{StudentLastName}')";
            OleDbCommand command = new OleDbCommand(insertCommand, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

        }

     private void ClearForm()
        {
            txtStudentNo.Text = "";
            txtStudentFirstName.Text="";
            txtStudentLastName.Text=""; }

    }
}
