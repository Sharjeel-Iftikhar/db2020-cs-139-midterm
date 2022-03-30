using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYP
{
    
    public partial class AssignForm : Form
    {
        

        public AssignForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //UpEvalBtn.Hide();
            button2.Hide();
            label21.Hide();


        }
        

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PenAssignProjectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = PenAssignProjectTable.Rows[index];
            ProjectSearchBox.Text = selectedRow.Cells[0].Value.ToString();

        }

        private void PendingGrpsAssignTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = PendingGrpsAssignTable.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            if (ProjectSearchBox.Text !="" && textBox1.Text !="")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("INSERT INTO GroupProject VALUES (@ProjectId,@GroupId,@AssignmentDate)", con);
                sql.Parameters.AddWithValue("@ProjectId", int.Parse(ProjectSearchBox.Text));
                sql.Parameters.AddWithValue("@GroupId", int.Parse(textBox1.Text));
                sql.Parameters.AddWithValue("@AssignmentDate", time);
                sql.ExecuteNonQuery();
                MessageBox.Show("Project Assigned Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("ProjectId or GroupId is Null ,Select it from above tables");
            }
        }

        private void TotalProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (label7.Text == "Assign Advisor")
            {
                int SelC = int.Parse(TotalProjects.SelectedCells[0].Value.ToString());
                textBox3.Text = TotalProjects.SelectedCells[0].Value.ToString();


                SqlCommand sql = new SqlCommand("Select CAST(L.Id as varchar)+'_'+(SELECT Lk.Value FROM [Lookup]Lk WHERE Lk.Id = L.Id)as[AdvisorRole] FROM [Lookup]L WHERE L.Id >'10'AND L.Id<'15' AND L.Id NOT IN (SELECT PA.AdvisorRole FROM ProjectAdvisor PA WHERE PA.ProjectId='" + SelC + "');", con);
                SqlDataReader sdr = sql.ExecuteReader();
                while (sdr.Read())
                {
                    AdviRole.Items.Add(sdr[0].ToString());
                }
                sdr.Close();
                textBox3.Text = SelC.ToString();
                sql = new SqlCommand("Select A.Id,CAST(A.Designation as varchar)+'_'+(SELECT L.Value FROM [Lookup]L WHERE L.Id=A.Designation)as[Desiganation] FROM Advisor A WHERE A.Id NOT IN (SELECT PA.AdvisorId FROM ProjectAdvisor PA WHERE PA.ProjectId='" + SelC + "')", con);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.ExecuteNonQuery();
                string role = AdviRole.Text;
                string[] arr = role.Split("_");
                textBox4.Text = arr[0].ToString();
            }
            else if(label7.Text != "Assign Advisor" && label9.Text == "Projects")
            {
                SqlCommand sql = new SqlCommand("", con);
                
            }
            else
            {

            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelC = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            textBox2.Text = SelC.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tt = DateTime.Now;
            var con = Configuration.getInstance().getConnection();
            
            if (label7.Text != "Assign Advisor" && label9.Text != "Projects")
            {
                string tr = TableRole.Text;
                string[] j = tr.Split(" ");
                MessageBox.Show(j[0]);
                int TRole = int.Parse(j[0]);
                int advisorid = 0;
                int projectid = int.Parse(textBox3.Text);
                string roel = AdviRole.Text;
                string[] ar = roel.Split(" ");
                
                // Query To Check 
                SqlCommand sqll = new SqlCommand("Select PA.AdvisorId FROm ProjectAdvisor PA WHERE PA.AdvisorRole='" + int.Parse(ar[0]) + "' AND PA.ProjectId ='" + projectid + "'", con);
                SqlDataReader sdr = sqll.ExecuteReader();
                while (sdr.Read())
                {
                    advisorid = int.Parse(sdr[0].ToString());
                    DialogResult dailog = MessageBox.Show("There Already Exist Advisor with ID _ " + advisorid.ToString() + "\n Do you want to delete it OR Swap it \n if 'Yes' It Will delete, If No 'Swap_roles' ", "Warning", MessageBoxButtons.YesNoCancel);
                    if (dailog == DialogResult.Yes)
                    {
                        MessageBox.Show("OverRiding");
                        sqll = new SqlCommand("DELETE FROM ProjectAdvisor WHERE AdvisorId ='" + advisorid + "' AND ProjectId = '" + projectid + "'", con);
                        sqll.ExecuteNonQuery();
                        MessageBox.Show("dEleded Ones");
                        sqll = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorRole=@a3,AssignmentDate=@a4 WHERE AdvisorId = @a1 AND ProjectId=@a2", con);
                        sqll.Parameters.AddWithValue("@a1", int.Parse(textBox2.Text));
                        sqll.Parameters.AddWithValue("@a2", projectid);
                        sqll.Parameters.AddWithValue("@a3", int.Parse(ar[0]));
                        sqll.Parameters.AddWithValue("@a4", tt);
                        sqll.ExecuteNonQuery();
                        this.Close();
                    }
                    else if (dailog == DialogResult.No)
                    {
                        MessageBox.Show("Swaping");
                        // assigning other one Table role
                        sqll = new SqlCommand("UPDATE  ProjectAdvisor SET AdvisorRole =@a1,AssignmentDate=@a2 WHERE AdvisorId = '" +advisorid + "' AND ProjectId = '" + projectid + "'", con);
                        sqll.Parameters.AddWithValue("@a1", TRole);
                        sqll.Parameters.AddWithValue("@a2", tt);
                        sqll.ExecuteNonQuery();

                        // assiging selected advisor role
                        SqlCommand cmm = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorRole =@a1, AssignmentDate=@a2 WHERE AdvisorId = '" + int.Parse(textBox2.Text) + "' AND ProjectId = '" + projectid + "' ", con);
                        cmm.Parameters.AddWithValue("@a1", int.Parse(ar[0]));
                        cmm.Parameters.AddWithValue("@a2", tt);
                        cmm.ExecuteNonQuery();
                        this.Close();

                    }
                    else if(dailog == DialogResult.Cancel)
                    {

                    }
                }
                sdr.Close();
                if(advisorid ==0)
                {
                    MessageBox.Show(textBox2.Text + "ProjectId" + projectid.ToString());
                    MessageBox.Show("Role"+ar[0].ToString());
                    
                    SqlCommand cmm = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorRole =@a1, AssignmentDate=@a2 WHERE AdvisorId = '" + int.Parse(textBox2.Text)+ "' AND ProjectId = '"+projectid+"' ", con);
                    cmm.Parameters.AddWithValue("@a1", int.Parse(ar[0]));
                    cmm.Parameters.AddWithValue("@a2",tt);
                    cmm.ExecuteNonQuery();
                    MessageBox.Show("Advisor Role Updated Successfully");
                    this.Close();
                }
               
            }
            else if(label7.Text == "Assign Advisor")
            {
                if(AdviRole.Text != "" && textBox3.Text !="" && textBox2.Text!="")
                {
                    DateTime time = DateTime.Now;
                    string role = AdviRole.Text;
                    string[] arr = role.Split("_");
                    SqlCommand sql = new SqlCommand("INSERT INTO ProjectAdvisor VALUES (@AdvisorId,@ProjectId,@AdvisorRole,@AssignmentDate)", con);
                    sql.Parameters.AddWithValue("@AdvisorId", int.Parse(textBox2.Text));
                    sql.Parameters.AddWithValue("@ProjectId", int.Parse(textBox3.Text));
                    sql.Parameters.AddWithValue("@AdvisorRole", int.Parse(arr[0]));
                    sql.Parameters.AddWithValue("@AssignmentDate", time);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Advisor Assigned Successfully");
                    this.Close();
                }
                else
                { MessageBox.Show("Not all entities are selected"); }
                
            }
            else if(label7.Text != "Assign Advisor" && label9.Text == "Projects")
            {
                string role = AdviRole.Text;
                string[] arr = role.Split("_");
                SqlCommand sc = new SqlCommand("DELETE FROM ProjectAdvisor WHERE AdvisorId ='" +int.Parse(textBox2.Text)+ "' AND ProjectId = '" + int.Parse(textBox3.Text) + "'", con);
                sc.ExecuteNonQuery();

                string rc = TotalProjects.SelectedCells[0].Value.ToString();
               // string abc = TotalProjects.SelectedCells[0].Value.ToString();
                SqlCommand sql = new SqlCommand("INSERT INTO ProjectAdvisor VALUES (@AdvisorId,@ProjectId,@AdvisorRole,@AssignmentDate)", con);
                sql.Parameters.AddWithValue("@AdvisorId", int.Parse(textBox2.Text));
                sql.Parameters.AddWithValue("@ProjectId", int.Parse(rc));
                sql.Parameters.AddWithValue("@AdvisorRole", int.Parse(arr[0]));
                sql.Parameters.AddWithValue("@AssignmentDate", tt);
                sql.ExecuteNonQuery();
                MessageBox.Show("Project Id Updated Successfully");
                this.Close();
            }
            

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(label13.Text == "Mark Evaluation")
            {
                int SelC = int.Parse(dataGridView3.SelectedCells[0].Value.ToString());
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("Select * FROM Evaluation E WHERE E.Id Not IN (SELECT GE.EvaluationId FROM GroupEvaluation GE WHERE GE.EvaluationId = E.Id AND GE.GroupId='" + SelC + "') ", con);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sql.ExecuteNonQuery();
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelC = int.Parse(dataGridView3.SelectedCells[0].Value.ToString());
            textBox5.Text = SelC.ToString();
            int totalmarks = int.Parse(dataGridView2.SelectedCells[2].Value.ToString());
            numericUpDown1.Maximum = totalmarks;
            textBox6.Text = dataGridView2.SelectedCells[0].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if(textBox5.Text!="" && textBox6.Text!="")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("INSERT INTO GroupEvaluation VALUES (@GroupId,@EvaluationId,@ObtainedMarks,@EvaluationDate)", con);
                sql.Parameters.AddWithValue("@GroupId", int.Parse(textBox5.Text));
                sql.Parameters.AddWithValue("@EvaluationId", int.Parse(textBox6.Text));
                sql.Parameters.AddWithValue("@ObtainedMarks", numericUpDown1.Value);
                sql.Parameters.AddWithValue("@EvaluationDate", dt);
                MessageBox.Show("Successfully Marked");
                sql.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                MessageBox.Show("INvalid Enitities");
            }
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Obtained Marks Should be in range of 0 to Total Marks \n I u enter marks greater than total it will add max marks \n and vice versa");
        }

        private void UpEvalBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("UPDATE GroupEvaluation SET GroupId=@a1,EvaluationId=@a2,ObtainedMarks=@a3,EvaluationDate=@a4 WHERE GroupId = @a5 AND EvaluationId = @a2", con);
                sql.Parameters.AddWithValue("@a1", int.Parse(textBox5.Text));
                sql.Parameters.AddWithValue("@a2", int.Parse(textBox6.Text));
                sql.Parameters.AddWithValue("@a3", numericUpDown1.Value);
                sql.Parameters.AddWithValue("@a4", dt);
                sql.Parameters.AddWithValue("@a5", int.Parse(textBox5.Text));
                sql.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("INvalid Enitities");
            }
        }

        private void AdviRole_MouseClick(object sender, MouseEventArgs e)
        {
            AdviRole.Items.Clear();
            var con = Configuration.getInstance().getConnection();
            if (label7.Text == "Assign Advisor" || (label7.Text == "Update Advisor Assignment" && label9.Text == "Projects") )
            {
                int SelC = int.Parse(textBox3.Text);
                
                int pp = int.Parse(TotalProjects.SelectedCells[0].Value.ToString());
                SqlCommand sql = new SqlCommand("Select CAST(L.Id as varchar)+'_'+(SELECT Lk.Value FROM [Lookup]Lk WHERE Lk.Id = L.Id)as[AdvisorRole] FROM [Lookup]L WHERE L.Id >'10'AND L.Id<'15' AND L.Id NOT IN (SELECT PA.AdvisorRole FROM ProjectAdvisor PA WHERE PA.ProjectId='" + pp + "');", con);
                SqlDataReader sdr = sql.ExecuteReader();
                while (sdr.Read())
                {
                    AdviRole.Items.Add(sdr[0].ToString());
                }
                sdr.Close();
            }
            else if(label7.Text != "Assign Advisor" && label9.Text!= "Projects")
            {
                SqlCommand sql = new SqlCommand("Select CAST(L.Id as varchar)+' '+L.Value FROM [Lookup]L WHERE L.Category='ADVISOR_ROLE'", con);
                SqlDataReader sdr = sql.ExecuteReader();
                while(sdr.Read())
                {
                    AdviRole.Items.Add(sdr[0]);
                }
            }
        }

        private void AdviRole_TabIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void AdviRole_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label21_Click(object sender, EventArgs e)
        {
            label9.Text = "Projects";
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select * FROM Project A WHERE A.Id NOT IN (SELECT PA.ProjectId FROM ProjectAdvisor PA WHERE PA.ProjectId=A.Id AND PA.AdvisorId='"+int.Parse(textBox2.Text)+"')", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TotalProjects.DataSource = dt;
            sql.ExecuteNonQuery();
        }
    }
}
