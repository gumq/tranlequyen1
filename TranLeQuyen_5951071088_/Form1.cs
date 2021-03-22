using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TranLeQuyen_5951071088_
{
    public partial class Form1 : Form
    {
       
  
        public int StudentID { get; private set; }

        public Form1()
        {
            InitializeComponent();
            GetStudensRecord();


        }

    
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9R3VIFH\SQLEXPRESS;Initial Catalog=DemoCRUD;Integrated Security=True");
          

        
        private void GetStudensRecord()
        {
            //Kết nối DB
          
            //Truy vấn DB

          SqlCommand cmd = new SqlCommand("SELECT * FROM StudentsTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
          //SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM StudentsTb", con);
           // adap.Fill(dt);
            dt.Load(sdr);
            con.Close();
            StudentsRecordData.DataSource = dt;
            
        }
        private bool IsValidData()
        {
            if (TxtHName.Text == string.Empty
                || TxtNName.Text == string.Empty
                || TxtAddress.Text == string.Empty
                || string.IsNullOrEmpty(TxtPhone.Text)
                || string.IsNullOrEmpty(TxtRoll.Text))
            {

                MessageBox.Show("Có chổ chưa nhập dữ liệu !!!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    
  
  


        private void Addbutton_Click(object sender, EventArgs e)
        {
           
           
            if (IsValidData())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTb VALUES" + 
                    "(@Name,@FartherName,@RollNumber,@Address,@Mobile)", con);
                cmd.CommandType = new CommandType();
                cmd.Parameters.AddWithValue("@Name", TxtNName.Text);
                cmd.Parameters.AddWithValue("@FartherName", TxtHName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", TxtRoll.Text);
                cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", TxtPhone.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudensRecord(); 

            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
          
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTb WHERE StudentID = @ID", con);
                cmd.CommandType = new CommandType();
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudensRecord();
                ResetText();
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi!!!", "Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
       
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UDATE StudentsTb SET" + "Name = @Name ,FartherName=@FatherName," + "RollNumber=@RollNumber,Address=@Address," + "Mobile=@Mobile WHERE StudentID=@ID", con);
                cmd.CommandType = new CommandType();
                cmd.Parameters.AddWithValue("@Name", TxtNName.Text);
                cmd.Parameters.AddWithValue("@FartherName", TxtHName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", TxtRoll.Text);
                cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", TxtPhone.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudensRecord();
                ResetText();
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi !!!", "Lỗi !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
    }

        private void TxtHName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentsRecordData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            StudentID = Convert.ToInt32(StudentsRecordData.Rows[0].Cells[0].Value);
            TxtHName.Text = StudentsRecordData.SelectedRows[0].Cells[1].Value.ToString();
            TxtNName.Text = StudentsRecordData.SelectedRows[0].Cells[2].Value.ToString();
            TxtRoll.Text = StudentsRecordData.SelectedRows[0].Cells[3].Value.ToString();
            TxtAddress.Text = StudentsRecordData.SelectedRows[0].Cells[4].Value.ToString();
            TxtPhone.Text = StudentsRecordData.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
