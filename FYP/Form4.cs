using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace FYP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Control.SetIntial(this);
            AllHide();
            MangSdPan.Hide();
            MangProPan.Hide();
            MangTeachPan.Hide();
            StdGroupPan.Hide();
            EvalPan.Hide();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Control.DoMaximie(this, lbl);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Control.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundPictures2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            hide(1);
            AllHide();
        }

        private void roundPictures2_MouseEnter(object sender, EventArgs e)
        {
            roundPictures2.BackColor = Color.FromArgb(209, 208, 208);
        }

        private void roundPictures2_MouseLeave(object sender, EventArgs e)
        {
            roundPictures2.BackColor = Color.White;
        }

        private void roundPictures1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            hide(2);
            AllHide();
        }

        private void roundPictures1_MouseEnter(object sender, EventArgs e)
        {
            roundPictures1.BackColor = Color.FromArgb(209, 208, 208);
        }

        private void roundPictures1_MouseLeave(object sender, EventArgs e)
        {
            roundPictures1.BackColor = Color.White;
        }

        private void roundPictures3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            hide(3);
            AllHide();
        }

        private void roundPictures3_MouseEnter(object sender, EventArgs e)
        {
            roundPictures3.BackColor = Color.FromArgb(209, 208, 208);
        }

        private void roundPictures3_MouseLeave(object sender, EventArgs e)
        {
            roundPictures3.BackColor = Color.White;
        }

        private void roundPictures4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            hide(4);
            AllHide();
        }

        private void roundPictures4_MouseEnter(object sender, EventArgs e)
        {
            roundPictures4.BackColor = Color.FromArgb(209, 208, 208);
        }

        private void roundPictures4_MouseLeave(object sender, EventArgs e)
        {
            roundPictures4.BackColor = Color.White;
        }

        private void roundPictures5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            hide(5);
            AllHide();
        }






        private void roundPictures6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            hide(6);
            AllHide();
        }

        private void roundPictures7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            hide(7);
            AllHide();
        }

        private void roundPictures7_MouseEnter(object sender, EventArgs e)
        {
            roundPictures7.BackColor = Color.FromArgb(209, 208, 208);
        }

        private void roundPictures7_MouseLeave(object sender, EventArgs e)
        {
            roundPictures7.BackColor = Color.White;
        }

        internal void pictureBox11_Click(object p, EventArgs empty)
        {
            throw new NotImplementedException();
        }

        private void roundPictures8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
            hide(8);
            AllHide();
        }
        private void hide(int lb)
        {
            if (lb == 1)
            {
                MangSdPan.Show();
                MangProPan.Hide();
                MangTeachPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Hide();
            }
            else if (lb == 2)
            {
                MangProPan.Show();
                MangSdPan.Hide();
                MangTeachPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Hide();
            }
            else if (lb == 3)
            {
                MangTeachPan.Show();
                MangSdPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Hide();
                MangProPan.Hide();
            }
            else if (lb == 4)
            {
                MangTeachPan.Hide();
                MangSdPan.Hide();
                StdGroupPan.Show();
                EvalPan.Hide();
                MangProPan.Hide();
            }
            else if (lb == 5)
            {
                MangTeachPan.Hide();
                MangSdPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Hide();
                MangProPan.Hide();
            }
            else if (lb == 6)
            {
                MangTeachPan.Hide();
                MangSdPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Hide();
                MangProPan.Hide();
            }
            else if (lb == 7)
            {
                MangTeachPan.Hide();
                MangSdPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Show();
                MangProPan.Hide();
            }
            else
            {
                MangTeachPan.Hide();
                MangSdPan.Hide();
                StdGroupPan.Hide();
                EvalPan.Hide();
                MangProPan.Hide();
            }

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MangStdtab_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();

        }

        private void SearchLbl_Click(object sender, EventArgs e)
        {
            SearchBox.Show();
        }
        public void ShowTable()
        {
            var conn = Configuration.getInstance().getConnection();
            SqlCommand cmdd = new SqlCommand("SELECT S.Id,S.RegistrationNo,P.FirstName+' '+P.LastName as [Name]" +
                ",CAST(P.DateOfBirth as date) as DateOfBirth," +
                "P.Contact,P.Email,P.Gender FROM Person P JOIN Student S ON S.Id = P.Id ORDER BY S.RegistrationNo ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();              // to set fetched data in form of relation (table)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(Firstname.Text!="" && LastName.Text!="" && ContactNo.Text!="" && Email.Text!="")
            {
                var conn = Configuration.getInstance().getConnection();
                SqlCommand cmdd = new SqlCommand("INSERT INTO Person VALUES(@FirstName,@LastName,@Contact,@Email,@DOB,@Gender)", conn);
                cmdd.Parameters.AddWithValue("@FirstName", Firstname.Text);
                cmdd.Parameters.AddWithValue("@LastName", LastName.Text);
                cmdd.Parameters.AddWithValue("@Contact", ContactNo.Text);
                cmdd.Parameters.AddWithValue("@Email", Email.Text);
                string dob = DOB.Text;
                DateTime dt = Convert.ToDateTime(dob);
                cmdd.Parameters.AddWithValue("@DOB", dt);
                int gender;
                if (radioButton1.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }
                cmdd.Parameters.AddWithValue("@Gender", gender);
                String name = Firstname.Text + "" + LastName.Text;
                MessageBox.Show(name);
                cmdd.ExecuteNonQuery();
                SqlCommand sql = new SqlCommand("Select max(Id) From Person", conn);
                // SqlCommand sql = new SqlCommand("SELECT P.Id FROM Person P Where P.FirstName+' '+ P.LastName like '%"+name+"%'", conn);
                SqlDataReader sdt = sql.ExecuteReader();
                int id = 0;
                while (sdt.Read())
                {
                    id = int.Parse(sdt[0].ToString());
                }

                sdt.Close();
                SqlCommand s = new SqlCommand("INSERT INTO Student VALUES(@Id,@RegistrationNo)", conn);
                s.Parameters.AddWithValue("@Id", id);
                s.Parameters.AddWithValue("@RegistrationNo", RegNo.Text);
                s.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully!!");
                cmdd.ExecuteNonQuery();
                ShowTable();
            }
            else
            {
                MessageBox.Show("Plz first enter above enitities");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            //String regno = RegBox.Text;
            string SelC = dataGridView1.SelectedCells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName=@a1,LastName=@a2,Contact=@a3,Email=@a4,DateOfBirth=@a5,Gender=@a6 WHERE Id =@a7  ", con);
            cmd.Parameters.AddWithValue("@a1", Firstname.Text);
            cmd.Parameters.AddWithValue("@a2", LastName.Text);
            cmd.Parameters.AddWithValue("@a3", ContactNo.Text);
            cmd.Parameters.AddWithValue("@a4", Email.Text);
            cmd.Parameters.AddWithValue("@a5", Convert.ToDateTime(DOB.Text));
            cmd.Parameters.AddWithValue("@a7", SelC);
            int gender = 2;
            if (radioButton1.Checked == true)
            {
                gender = 1;
                cmd.Parameters.AddWithValue("@a6", gender);
            }
            else
            {
                cmd.Parameters.AddWithValue("@a6", gender);
            }
            SqlCommand sql = new SqlCommand("UPDATE Student SET RegistrationNo=@b1 WHERE Id =@b2", con);
            sql.Parameters.AddWithValue("@b1", RegNo.Text);
            sql.Parameters.AddWithValue("@b2", SelC);
            cmd.ExecuteNonQuery();
            sql.ExecuteNonQuery();
            ShowTable();
            Clear();
            AddBtn.Show();
            EditBtn.Hide();
        }

        private void Clear()
        {
            Firstname.Text = "";
            LastName.Text = "";
            RegNo.Text = "";
            DOB.Text = "";
            ContactNo.Text = "";
            Email.Text = "";
            radioButton1.Checked = false;
            Female.Checked = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string sel = dataGridView1.SelectedCells[0].Value.ToString();
            int groupid = 0;
            int stdCount = 0;
            SqlCommand sql = new SqlCommand("SELECT GS.GroupId FROM GroupStudent GS WHERE GS.StudentId = '" + sel + "'", con);
            SqlDataReader sdr = sql.ExecuteReader();
            while (sdr.Read())
            {
                groupid = int.Parse(sdr[0].ToString());
            }
            sdr.Close();
            //MessageBox.Show("Student enrolled in " + groupid.ToString() + " will also be deleted..");
            sql = new SqlCommand("SELECT Count(GS.StudentId) FROM GroupStudent GS GROUP BY GS.GroupId HAVING GS.GroupId='" + int.Parse(sel) + "'", con);
            SqlDataReader sd = sql.ExecuteReader();
            while (sd.Read())
            {
                stdCount = int.Parse(sd[0].ToString());

            }
            sd.Close();
            MessageBox.Show("No of Students in Groups" + stdCount);
            if (stdCount == 1)
            {
                RemoveStdFromGroup(groupid, int.Parse(sel), 1);
            }

            sql = new SqlCommand("DELETE FROM Student WHERE Id =@a1", con);
            sql.Parameters.AddWithValue("@a1", sel);
            SqlCommand cmd = new SqlCommand("Delete FROM Person WHERE Id=@b1", con);
            cmd.Parameters.AddWithValue("@b1", sel);
            sql.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            ShowTable();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string search = SearchBox.Text;
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT S.Id,S.RegistrationNo,P.FirstName+' '+P.LastName as [Name]" +
                ",CAST(P.DateOfBirth as date) as DateOfBirth," +
                "P.Contact,P.Email,P.Gender FROM Person P JOIN Student S ON S.Id = P.Id WHERE S.RegistrationNo Like " +
                "'" + search + "%' OR P.FirstName Like '" + search + "%' OR P.LastName Like '" + search + "%'" +
                "OR P.Contact Like '" + search + "%' OR P.Email Like '" + search + "%' OR P.Gender Like '" + search + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();              // to set fetched data in form of relation (table)
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DPLine.Hide();
            DelProject.Hide();
            Title.Hide();
            Title.Text = "";
            Descrip.Text = "";
            TLine.Hide();
            Descrip.Hide();
            
            DesLine.Hide();
            AddProj.Hide();
            UpdateProj.Hide();
            ProjectTable.DataSource = null;
            ProjectTable.Refresh();
            ProjectTable.Hide();
            On_off(TotProjIcon, AssProjIcon, PenProIcon, AddNewIcon, pictureBox12, 1);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(P.Id)as[Total Projects] From Project P", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TotalProjects.Text = dr[0].ToString() + "___ more--";
            }
            dr.Close();
            Tshow(TotalProjects, AssignedPros, PendingPros, 1);

        }

        // FUnction to on off icons under pictures
        private void On_off(PictureBox p1, PictureBox p2, PictureBox p3, PictureBox p4, PictureBox p5, int c)
        {
            p1.Hide();
            p2.Hide();
            p3.Hide();
            p4.Hide();
            p5.Hide();
            if (c == 1)
            {
                p1.Show();
            }
            else if (c == 2)
            {
                p2.Show();
            }
            else if (c == 3)
            {
                p3.Show();
            }
            else if (c == 4)
            {
                p4.Show();
            }
            else if (c == 5)
            {
                p5.Show();
            }
        }

        private void TotalProjects_Click(object sender, EventArgs e)
        {
            ViewProTable(ProjectTable);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Title.Hide();
            UpdateProj.Hide();
            TLine.Hide();
            Descrip.Hide();
            DesLine.Hide();
            AddProj.Hide();
            ProjectTable.DataSource = null;
            ProjectTable.Refresh();
            ProjectTable.Hide();
            DPLine.Hide();
            DelProject.Hide();
            Title.Text = "";
            Descrip.Text = "";
            On_off(TotProjIcon, AssProjIcon, PenProIcon, AddNewIcon, pictureBox12, 2);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(P.Id) From Project P JOIN GroupProject GP ON GP.ProjectId = P.Id", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AssignedPros.Text = dr[0].ToString() + "__ more--";
            }
            dr.Close();
            Tshow(TotalProjects, AssignedPros, PendingPros, 2);


        }

        // function to hide count of Projects
        private void Tshow(Label a1, Label a2, Label a3, int c)
        {
            a1.Hide();
            a2.Hide();
            a3.Hide();
            if (c == 1)
            {
                a1.Show();
            }
            else if (c == 2)
            {
                a2.Show();
            }
            else if (c == 3)
            {
                a3.Show();
            }
        }

        private void AssignedPros_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select P.Id,P.Title,P.Description,GP.GroupId,CAST(GP.AssignmentDate as Date)as [AssignmentDate] From Project P JOIN GroupProject GP ON P.Id =GP.ProjectId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ProjectTable.DataSource = dt;
            cmd.ExecuteNonQuery();
            ProjectTable.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Title.Hide();
            UpdateProj.Hide();
            TLine.Hide();
            Descrip.Hide();
            DesLine.Hide();
            AddProj.Hide();
            ProjectTable.DataSource = null;
            ProjectTable.Refresh();
            ProjectTable.Hide();
            DPLine.Hide();
            DelProject.Hide();
            Title.Text = "";
            Descrip.Text = "";
            On_off(TotProjIcon, AssProjIcon, PenProIcon, AddNewIcon, pictureBox12, 3);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Count(P.Id) From Project P LEFT OUTER JOIN GroupProject GP ON GP.ProjectId = P.Id WHERE GP.GroupId is NULL", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PendingPros.Text = dr[0].ToString() + "__ more--";
            }
            dr.Close();
            Tshow(TotalProjects, AssignedPros, PendingPros, 3);
        }

        private void PendingPros_Click(object sender, EventArgs e)
        {
            loadPendingProjects(ProjectTable);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProjectTable.DataSource = null;
            UpdateProj.Hide();
            ProjectTable.Refresh();
            ProjectTable.Hide();
            On_off(TotProjIcon, AssProjIcon, PenProIcon, AddNewIcon, pictureBox12, 4);
            Title.Show();
            TLine.Show();
            Descrip.Show();
            DesLine.Show();
            AddProj.Show();
            DPLine.Hide();
            Title.Text = "";
            Descrip.Text = "";
            DelProject.Hide();
            Tshow(TotalProjects, AssignedPros, PendingPros, 4);

        }
        // function to load all projects 
        private void ViewProTable(DataGridView dg)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select P.Id,P.Title,P.Description From Project P", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            cmd.ExecuteNonQuery();
            ProjectTable.Show();
        }

        private void AddProj_Click(object sender, EventArgs e)
        {
            if(Title.Text!="")
            {
                var con = Configuration.getInstance().getConnection();
                
                SqlCommand cmm = new SqlCommand("Select max(Id) from Project", con);
                SqlDataReader sr = cmm.ExecuteReader();
                int max = 0;
                while(sr.Read())
                {
                    max = int.Parse(sr[0].ToString());
                }
                sr.Close();
                cmm = new SqlCommand("", con);
                SqlCommand cmd = new SqlCommand("INSERT INTO Project VALUES(@Description,@Title)", con);
                cmd.Parameters.AddWithValue("@Title", Title.Text);
                cmd.Parameters.AddWithValue("@Description", Descrip.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully!!");
                Title.Text = "";
                Descrip.Text = "";
                ViewProTable(ProjectTable);
            }
            else
            {
                MessageBox.Show("Project Title box is Empty");
            }
            
        }

        private void ProjectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = ProjectTable.Rows[index];
            Title.Text = selectedRow.Cells[1].Value.ToString();
            Descrip.Text = selectedRow.Cells[2].Value.ToString();
            DPLine.Show();
            DelProject.Show();
            Title.Show();
            TLine.Show();
            Descrip.Show();
            DesLine.Show();
            UpdateProj.Show();
            AddProj.Hide();
        }

        private void UpdateProj_Click(object sender, EventArgs e)
        {
            string SelC = ProjectTable.SelectedCells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("UPDATE Project SET Title=@a1,Description=@a2 WHERE Id = @a3", con);
            cmm.Parameters.AddWithValue("@a1", Title.Text);
            cmm.Parameters.AddWithValue("@a2", Descrip.Text);
            cmm.Parameters.AddWithValue("@a3", SelC);
            cmm.ExecuteNonQuery();
            ViewProTable(ProjectTable);
        }

        private void DelProject_Click(object sender, EventArgs e)
        {
            string SelC = ProjectTable.SelectedCells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("DELETE FROM ProjectAdvisor WHERE ProjectId =@a3 AND ProjectId IN(Select Id FROM Project WHERE Id = ProjectId)", con);
            sql.Parameters.AddWithValue("@a3", SelC);
            sql.ExecuteNonQuery();
            sql = new SqlCommand("DELETE FROM GroupProject  WHERE ProjectId =@a3 AND ProjectId IN(Select Id FROM Project WHERE ProjectId = Id)", con);
            sql.Parameters.AddWithValue("@a3", SelC);
            sql.ExecuteNonQuery();
            sql = new SqlCommand("DELETE FROM Project  WHERE Id = @a3", con);
            sql.Parameters.AddWithValue("@a3", SelC);
            sql.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            ViewProTable(ProjectTable);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string entity = ProjectSearchBox.Text;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("SELECT Id,Title,Description FROM Project WHERE Id Like '" + entity + "%' OR Title Like '" + entity + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();              // to set fetched data in form of relation (table)
            da.Fill(dt);
            ProjectTable.DataSource = dt;
            cmm.ExecuteNonQuery();
            ProjectTable.Show();
        }

        private void AddAdvi_Click(object sender, EventArgs e)
        {
            if (Designation.Text != "Designation" && AdvisorID.Text != "")
            {
                string desig = Designation.SelectedItem.ToString();
                string[] arr = desig.Split(" ");
                int id = int.Parse(AdvisorID.Text);
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("INSERT INTO Advisor VALUES(@Id,@Designation,@Salary)", con);
                sql.Parameters.AddWithValue("@Id", id);
                sql.Parameters.AddWithValue("@Designation", arr[0]);
                sql.Parameters.AddWithValue("@Salary", int.Parse(AdSalary.Text));
                sql.ExecuteNonQuery();
                ViewAdvisorTable();
                AdvisorID.Text = "";
                Designation.Items.Add("");
                AdSalary.Text = "";
            }
            else
            {
                MessageBox.Show("Id and Desigantion Not Enterd");
            }
            

        }

        private void AdvisorID_MouseClick(object sender, MouseEventArgs e)
        {

        }

        // function to show advisor data
        private void ViewAdvisorTable()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("SELECT * FROM Advisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdvisorTable.DataSource = dt;
            cmm.ExecuteNonQuery();
        }

        private void Designation_MouseClick(object sender, MouseEventArgs e)
        {
            LoadDesigantion();
        }

        private void SearchAdvi_TextChanged(object sender, EventArgs e)
        {
            AdvisorID.Text = "";
            AdSalary.Text = "";
            Designation.Items.Clear();
            string s = SearchAdvi.Text;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("Select * FROM Advisor A WHERE A.Id Like '" + s + "%' OR A.Designation Like '" + s + "%' OR A.Salary Like '" + s + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdvisorTable.DataSource = dt;
            cmm.ExecuteNonQuery();

        }

        private void AdvisorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = AdvisorTable.Rows[index];
            AdvisorID.Text = selectedRow.Cells[0].Value.ToString();
            int advisorId = int.Parse(AdvisorID.Text);
            try
            {
                MessageBox.Show(AdvisorTable.Columns[1].Name);
                if (AdvisorTable.Columns[1].Name != "ProjectId")
                {
                    Designation.Text = selectedRow.Cells[1].Value.ToString();
                    AdSalary.Text = selectedRow.Cells[2].Value.ToString();
                    DeleteAdvi.Show();
                    AdDelLin.Show();
                    AddAdvi.Hide();
                    UpdateAdvi.Show();
                    Designation.Items.Clear();
                    AdvisorID.Show();
                    label29.Show();
                    Designation.Show();
                    AdSalary.Show();
                    label30.Show();
                    label31.Show();
                }
                else
                {
                    AssignForm af = new AssignForm();
                    UpdateAssignAd.Show();
                    label98.Show();
                    DeleteAdvi.Show();
                    AdDelLin.Show();
                    // int projectid = int.Parse(selectedRow.Cells[1].Value.ToString());
                    ProjectID.Text = selectedRow.Cells[1].Value.ToString();
                    label63.Text = selectedRow.Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {


            }



        }

        private void DeleteAdvi_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string col = AdvisorTable.Columns[1].Name;
            string Advisorid = AdvisorTable.SelectedCells[0].Value.ToString();
            if (col == "ProjectId")
            {
                string projid = AdvisorTable.SelectedCells[1].Value.ToString();
                SqlCommand cmm = new SqlCommand("DELETE FROM ProjectAdvisor WHERE AdvisorId ='" + Advisorid + "' AND ProjectId = '" + projid + "'", con);
                cmm.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmm = new SqlCommand("DELETE FROM ProjectAdvisor WHERE AdvisorId ='" + Advisorid + "'", con);
                cmm.ExecuteNonQuery();
                cmm = new SqlCommand("DELETE FROM Advisor  WHERE Id = @a3", con);
                cmm.Parameters.AddWithValue("@a3", Advisorid);
                cmm.ExecuteNonQuery();

                ViewAdvisorTable();
                DeleteAdvi.Hide();
                AdDelLin.Hide();
                //AddAdvi.Show();
                UpdateAdvi.Hide();
                Designation.Items.Clear();
            }
        }

        private void AdDelLin_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAdvi_Click(object sender, EventArgs e)
        {
            int desigg = 0;
            int d = 0;
            var con = Configuration.getInstance().getConnection();
            //if (AdviRole.Text!= "AdvisorRole")
            //{
            //    //try
            //    //{
            //    //    string desig = AdviRole.SelectedItem.ToString();
            //    //    string[] arr = desig.Split(" ");
            //    //    desigg = int.Parse(arr[0]);

            //    //}
            //    //catch (Exception ex)
            //    //{

            //    //}
            //   // string role = AdviRole.Text;
            //    string[] rr = role.Split(" ");
            //    desigg = int.Parse(rr[0]);
            //    int AdID = int.Parse(AdvisorID.Text);
            //    SqlCommand cmd = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorRole=@a1 WHERE AdvisorId = @a4", con);
            //    cmd.Parameters.AddWithValue("@a1", desigg);
            //    cmd.Parameters.AddWithValue("@a4", AdID);
            //    cmd.ExecuteNonQuery();
            //}
            //try
            //{
            //    string desig = Designation.SelectedItem.ToString();
            //    string[] arr = desig.Split(" ");
            //    d = int.Parse(arr[0]);

            //}
            //catch(Exception ex)
            //{

            // }
            string des = Designation.Text;
            string[] pp = des.Split(" ");
            d = int.Parse(pp[0]);
            SqlCommand cmm = new SqlCommand("UPDATE Advisor SET Id=@a1,Designation=@a2,Salary=@a3 WHERE Id = @a4", con);
            cmm.Parameters.AddWithValue("@a1", AdvisorID.Text);
            cmm.Parameters.AddWithValue("@a2", d);
            cmm.Parameters.AddWithValue("@a3", int.Parse(AdSalary.Text));
            cmm.Parameters.AddWithValue("@a4", AdvisorID.Text);
            cmm.ExecuteNonQuery();
            MessageBox.Show("Updated successfully");
            ViewAdvisorTable();
            AdvisorID.Text = "";
            AdSalary.Text = "";
            Designation.Items.Clear();
            UpdateAdvi.Hide();

            DeleteAdvi.Hide();
            AdDelLin.Hide();
            AddAdvi.Hide();
            AdvisorID.Hide();
            label29.Hide();
            Designation.Hide();
            AdSalary.Hide();
            label30.Hide();
            label31.Hide();



        }
        // Function to load designation into combo box
        private void LoadDesigantion()
        {
            Designation.Items.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("Select CAST(L.Id as varchar)+' '+L.Value  from Lookup L Where L.Category = 'DESIGNATION'", con);
            SqlDataReader sdr = cmm.ExecuteReader();
            while (sdr.Read())
            {
                Designation.Items.Add(sdr[0]);
            }
            sdr.Close();
        }

        private void AdvisorID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("SELECT Max(Id) FROM Advisor", con);
            SqlDataReader sdr = cmm.ExecuteReader();
            while (sdr.Read())
            {
                AdvisorID.Text = (int.Parse(sdr[0].ToString()) + 1).ToString();
            }
            sdr.Close();
        }

        private void StdGroups_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label52.Hide();
            GroupIds.Hide();
            RegNoList.Hide();
            Status.Hide();
            label53.Hide();
            label54.Hide();
            label55.Hide();
            GropStdAdd.Hide();
            StdGroupTable.DataSource = null;
            StdGroupTable.Refresh();
            StdGroupTable.Hide();

            Designation.Hide();
            On_off(TGroupIcon, NoOfStdIcons, AddStdGrp, AddGroup, pictureBox12, 1);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("SELECT Count(Id) From [Group]", con);
            SqlDataReader sdr = cmm.ExecuteReader();
            while (sdr.Read())
            {
                TGrpl.Text = sdr[0].ToString() + " __ more--";
            }
            sdr.Close();
            Tshow(TGrpl, label48, label49, 1);
        }

        private void TGrpl_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("SELECT * From [Group]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StdGroupTable.DataSource = dt;
            cmm.ExecuteNonQuery();
            StdGroupTable.Show();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Delstdgroup.Hide();
            label52.Hide();
            GroupIds.Hide();
            RegNoList.Hide();
            Status.Hide();
            label53.Hide();
            label54.Hide();
            label55.Hide();
            GropStdAdd.Hide();
            StdGroupTable.DataSource = null;
            StdGroupTable.Refresh();
            StdGroupTable.Hide();

            //DPLine.Hide();
            //DelProject.Hide();
            On_off(TGroupIcon, NoOfStdIcons, AddStdGrp, AddGroup, pictureBox12, 2);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select GroupId,Count(GroupId)as[No.of Students] FROM GroupStudent GS Group By GS.GroupId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StdGroupTable.DataSource = dt;
            cmd.ExecuteNonQuery();
            StdGroupTable.Show();
            Tshow(TGrpl, label48, label49, 2);
        }

        private void label48_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select GroupId,S.RegistrationNo,S.Id,P.FirstName+' '+P.LastName as [Name]  FROM GroupStudent GS JOIN Student S ON S.Id = GS.StudentId JOIN Person P ON P.Id = S.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StdGroupTable.DataSource = dt;
            cmd.ExecuteNonQuery();
            StdGroupTable.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Delstdgroup.Hide();
            label52.Hide();
            GroupIds.Hide();
            RegNoList.Hide();
            Status.Hide();
            label53.Hide();
            label54.Hide();
            label55.Hide();

            GropStdAdd.Hide();
            var con = Configuration.getInstance().getConnection();
            DateTime now = DateTime.Now;
            SqlCommand sql = new SqlCommand("INSERT INTO [Group] VALUES (@Created_On)", con);
            sql.Parameters.AddWithValue("@Created_On", now);
            sql.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            SqlCommand cmm = new SqlCommand("SELECT * From [Group]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StdGroupTable.DataSource = dt;
            cmm.ExecuteNonQuery();
            StdGroupTable.Show();


        }

        private void RegNoList_MouseClick(object sender, MouseEventArgs e)
        {
            RegNoList.Items.Clear();
            int count = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("Select Count(S.Id) FROM Student S LEFT OUTER JOIN GroupStudent GS  ON S.Id = GS.StudentId WHERE GS.GroupId is NULL", con);
            SqlDataReader sd = cmm.ExecuteReader();
            while (sd.Read())
            {
                count = int.Parse(sd[0].ToString());
            }
            sd.Close();
            if (RegNoList.Items.Count < count)
            {

                SqlCommand sql = new SqlCommand("Select S.RegistrationNo FROM Student S LEFT OUTER JOIN GroupStudent GS  ON S.Id = GS.StudentId WHERE GS.GroupId is NULL", con);
                SqlDataReader sdr = sql.ExecuteReader();
                while (sdr.Read())
                {
                    RegNoList.Items.Add(sdr[0]);
                }
                sdr.Close();
            }

        }

        private void GroupIds_MouseClick(object sender, MouseEventArgs e)
        {
            GroupIds.Items.Clear();
            int count = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT Distinct Count(Id) From [Group]", con);
            SqlDataReader sd = sql.ExecuteReader();
            while (sd.Read())
            {
                count = int.Parse(sd[0].ToString());
            }
            sd.Close();
            if (GroupIds.Items.Count < count)
            {
                SqlCommand cmm = new SqlCommand("SELECT Distinct Id From [Group]", con);
                SqlDataReader sdr = cmm.ExecuteReader();
                while (sdr.Read())
                {
                    GroupIds.Items.Add(sdr[0]);
                }
                sdr.Close();
            }

        }

        private void Status_MouseClick(object sender, MouseEventArgs e)
        {
            if (Status.Items.Count == 0)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmm = new SqlCommand("Select CAST(L.Id as varchar)+' '+L.Value FROM Lookup L WHERE L.Category = 'STATUS'", con);
                SqlDataReader sdr = cmm.ExecuteReader();
                while (sdr.Read())
                {
                    Status.Items.Add(sdr[0]);
                }
                sdr.Close();
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            StdGroupTable.DataSource = null;
            StdGroupTable.Refresh();
            StdGroupTable.Hide();
            Delstdgroup.Hide();
            On_off(TGroupIcon, NoOfStdIcons, AddStdGrp, AddGroup, pictureBox12, 3);
            Tshow(TGrpl, label48, label49, 5);
            label52.Show();
            GroupIds.Show();
            RegNoList.Show();
            Status.Show();
            label53.Show();
            label54.Show();
            label55.Show();
            GropStdAdd.Show();

        }

        private void GropStdAdd_Click(object sender, EventArgs e)
        {
            if(GroupIds.Text != "Group Id" && RegNoList.Text != "Std RegNos" && Status.Text !="Status")
            {
                DateTime t = DateTime.Now;
                int Id = int.Parse(GroupIds.SelectedItem.ToString());
                string regno = RegNoList.SelectedItem.ToString();
                int SId = 0;
                var con = Configuration.getInstance().getConnection();
                SqlCommand query = new SqlCommand("Select Id From Student Where RegistrationNo = '" + regno + "'", con);
                SqlDataReader sd = query.ExecuteReader();
                while (sd.Read())
                {
                    SId = int.Parse(sd[0].ToString());
                }
                sd.Close();

                string status = Status.SelectedItem.ToString();
                string[] arr = status.Split(" ");
                ;
                SqlCommand cmm = new SqlCommand("INSERT INTO GroupStudent VALUES(@GroupId,@StudentId,@Status,@AssignmentDate)", con);
                cmm.Parameters.AddWithValue("@GroupId", Id);
                cmm.Parameters.AddWithValue("@StudentId", SId);
                cmm.Parameters.AddWithValue("@Status", arr[0]);
                cmm.Parameters.AddWithValue("@AssignmentDate", t);
                cmm.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
                SqlCommand cmd = new SqlCommand("Select GroupId,S.RegistrationNo,P.FirstName+' '+P.LastName as [Name]  FROM GroupStudent GS JOIN Student S ON S.Id = GS.StudentId JOIN Person P ON P.Id = S.Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                StdGroupTable.DataSource = dt;
                cmd.ExecuteNonQuery();
                StdGroupTable.Show();
                GroupIds.Items.Clear();
                Status.Items.Clear();
                RegNoList.Items.Clear();
                GroupIds.Text = "Group Id";
                Status.Text = "Status";
                RegNoList.Text = "Std RegNo"; 
                
            }
            else
            {
                MessageBox.Show("GroupID & RegNo & Status not selected");
            }
            

        }
        int groupId = 0;
        int SId = 0;
        string temp = "";
        int control = 0;


        private void StdGroupTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Delstdgroup.Show();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = StdGroupTable.Rows[index];
            groupId = int.Parse(selectedRow.Cells[0].Value.ToString());
            temp = selectedRow.Cells[1].Value.ToString();
            if (temp.Contains("/"))
            {
                control = 1;
            }
            else if (temp.Contains("-"))
            {
                SId = int.Parse(selectedRow.Cells[2].Value.ToString());
                control = 2;
                //  RemoveStdFromGroup(groupId,SId);
            }
        }

        /// Function to delete std from group
        private void RemoveStdFromGroup(int id, int Sid, int c)
        {

            if (c == 2)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("DELETE FROM GroupStudent WHERE GroupId = '" + id + "' AND StudentId = '" + Sid + "'", con);
                sql.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully");
                SqlCommand cmd = new SqlCommand("Select GroupId,S.RegistrationNo,S.Id,P.FirstName+' '+P.LastName as [Name]  FROM GroupStudent GS JOIN Student S ON S.Id = GS.StudentId JOIN Person P ON P.Id = S.Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                StdGroupTable.DataSource = dt;
                cmd.ExecuteNonQuery();
                StdGroupTable.Show();
            }
            else if (c == 1)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("Delete FROM GroupStudent Where GroupId = '" + id + "'", con);
                sql.ExecuteNonQuery();
                SqlCommand bnn = new SqlCommand("DELETE FROM GroupEvaluation WHERE GroupId = '" + id + "'", con);
                bnn.ExecuteNonQuery();
                SqlCommand cnn = new SqlCommand("DELETE FROM GroupProject WHERE GroupId = '" + id + "'", con);
                cnn.ExecuteNonQuery();
                SqlCommand cmm = new SqlCommand("DELETE FROM [Group] WHERE Id = '" + id + "'", con);
                cmm.ExecuteNonQuery();
                MessageBox.Show("Group Deleted Successfully");
                SqlCommand cmd = new SqlCommand("SELECT * From [Group]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                StdGroupTable.DataSource = dt;
                cmd.ExecuteNonQuery();
                StdGroupTable.Show();
            }

        }

        private void DelStd_Click(object sender, EventArgs e)
        {

        }

        private void Delstdgroup_Click(object sender, EventArgs e)
        {
            RemoveStdFromGroup(groupId, SId, control);
            Delstdgroup.Hide();
        }

        private void StdGrpSearch_TextChanged(object sender, EventArgs e)
        {
            string search = StdGrpSearch.Text;
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT GS.GroupId, S.RegistrationNo, S.Id, P.FirstName + ' ' + P.LastName  FROM Student S JOIN GroupStudent GS ON S.Id = GS.StudentId JOIN Person P ON P.Id = S.Id WhERE S.RegistrationNo Like '" + search + "' OR GS.GroupId Like '" + search + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StdGroupTable.DataSource = dt;
            sql.ExecuteNonQuery();
            StdGroupTable.Show();
        }

        private void StdGrpSearch_MouseClick(object sender, MouseEventArgs e)
        {
            StdGroupTable.Hide();
            Delstdgroup.Hide();
        }

        // finction to laod pending projects
        private void loadPendingProjects(DataGridView dg)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select P.Id,P.Title,P.Description From Project P LEFT OUTER JOIN GroupProject GP ON P.Id = GP.ProjectId WHERE GP.GroupId is NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            cmd.ExecuteNonQuery();
            dg.Show();
        }
        // function to load pending groups
        private void loadPendingGroups(DataGridView g)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select G.Id,G.Created_On FROM [Group] G LEFT OUTER JOIN GroupProject GP ON G.Id = GP.GroupId WHERE GP.ProjectId is NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            g.DataSource = dt;
            cmd.ExecuteNonQuery();
            g.Show();
        }


        // Function to hide things at starts
        private void AllHide()
        {
            /////////// Hiding for Student Managemnet Tab ////////////////

            Delete.Hide();
            DelLine.Hide();
            Thread.Sleep(10);
            ShowTable();
            EditBtn.Hide();
            /////////////////////// Hiding for Project manage Tab //////////////
            On_off(TotProjIcon, AssProjIcon, PenProIcon, AddNewIcon, pictureBox12, 6);
            Title.Hide();
            Descrip.Hide();
            TLine.Hide();
            DesLine.Hide();
            AddProj.Hide();
            UpdateProj.Hide();
            ProjectTable.Hide();
            TotalProjects.Hide();
            AssignedPros.Hide();
            PendingPros.Hide();
            DPLine.Hide();
            DelProject.Hide();
            pictureBox12.Hide();
            Title.Text = "";
            Descrip.Text = "";


            ///////////////Hiding for manage advisor
            DeleteAdvi.Hide();
            AdDelLin.Hide();
            UpdateAdvi.Hide();
            AdvisorID.Hide();
            label29.Hide();
            Designation.Hide();
            AdSalary.Hide();
            label30.Hide();
            label31.Hide();
            AddAdvi.Hide();
            UpdateAdvi.Hide();
            On_off(TotalAdvsiorsIco, AssigAdIcon, OnPendingIcon, AddAdIcon, AssAdIcon, 6);
            Tshow(TotalAdCount, AssCount, OnPenCount, 6);
            AdvisorTable.Hide();

            UpdateAssignAd.Hide();
            label98.Hide();
            AdvisorID.Text = "";
            Designation.Text = "Designation";
            AdSalary.Text = "";


            /////// HIding for Std Groups
            TGroupIcon.Hide();
            NoOfStdIcons.Hide();
            AddStdGrp.Hide();
            StdGroupTable.Hide();
            On_off(TGroupIcon, NoOfStdIcons, AddStdGrp, AddGroup, pictureBox12, 6);
            TGrpl.Hide();
            label48.Hide();
            label49.Hide();

            // add std in group
            label52.Hide();
            GroupIds.Hide();
            RegNoList.Hide();
            Status.Hide();
            label53.Hide();
            label54.Hide();
            label55.Hide();
            GropStdAdd.Hide();
            Delstdgroup.Hide();

            // Hiding for Evaluation
            TotalEvaIcon.Hide();
            GrpEvalIcon.Hide();
            UnEvalGropIcon.Hide();
            AddNewEvaIcon.Hide();
            MarkEvalIcon.Hide();
            label97.Hide();
            label71.Hide();
            On_off(TotalEvaIcon, GrpEvalIcon, UnEvalGropIcon, AddNewEvaIcon, MarkEvalIcon, 6);
            Tshow(TotEvaIcon, TotlGrpEvalIcon, TotlUnevalIcon, 6);
            //add details

            textBox6.Hide();

            label72.Hide();
            TotalMarks.Hide();
            label73.Hide();
            Weightage.Hide();
            label74.Hide();
            AddEvalBtn.Hide();
            /// end
            UpdateEval.Hide();
            EvaluationTable.Hide();

            // del btn
            UpddateEval.Hide();
            DelEval.Hide();
            label100.Hide();

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            DeleteAdvi.Hide();
            AdDelLin.Hide();
            UpdateAdvi.Hide();
            AdvisorID.Hide();
            label29.Hide();
            Designation.Hide();
            AdSalary.Hide();
            label30.Hide();
            label31.Hide();
            AddAdvi.Hide();
            UpdateAdvi.Hide();
            AdvisorTable.DataSource = null;
            AdvisorTable.Refresh();
            AdvisorTable.Hide();
            UpdateAssignAd.Hide();
            label98.Hide();
            AdvisorID.Text = "";
            Designation.Text = "Designation";
            AdSalary.Text = "";
            On_off(TotalAdvsiorsIco, AssigAdIcon, OnPendingIcon, AddAdIcon, AssAdIcon, 1);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select  Count(Id) FROM Advisor", con);
            SqlDataReader sdr = sql.ExecuteReader();
            while (sdr.Read())
            {
                TotalAdCount.Text = sdr[0].ToString() + " __ more ---";
            }
            sdr.Close();
            Tshow(TotalAdCount, AssCount, OnPenCount, 1);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DeleteAdvi.Hide();
            AdDelLin.Hide();
            AdvisorID.Hide();
            label29.Hide();
            Designation.Hide();
            AdSalary.Hide();
            label30.Hide();
            label31.Hide();
            AddAdvi.Hide();
            UpdateAdvi.Hide();
            AdvisorTable.DataSource = null;
            AdvisorTable.Refresh();
            AdvisorTable.Hide();
            UpdateAssignAd.Hide();
            label98.Hide();
            AdvisorID.Text = "";
            Designation.Text = "Designation";
            AdSalary.Text = "";
            On_off(TotalAdvsiorsIco, AssigAdIcon, OnPendingIcon, AddAdIcon, AssAdIcon, 2);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select Count(A.Id) FROM Advisor A JOIN ProjectAdvisor PA ON A.Id = PA.AdvisorId", con);
            SqlDataReader sdr = sql.ExecuteReader();
            while (sdr.Read())
            {
                AssCount.Text = sdr[0].ToString() + " __ more__ Click---";
            }
            sdr.Close();
            Tshow(TotalAdCount, AssCount, OnPenCount, 2);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            DeleteAdvi.Hide();
            AdDelLin.Hide();
            AdvisorID.Hide();
            label29.Hide();
            Designation.Hide();
            AdSalary.Hide();
            label30.Hide();
            label31.Hide();
            AddAdvi.Hide();
            UpdateAdvi.Hide();
            AdvisorTable.DataSource = null;
            AdvisorTable.Refresh();
            AdvisorTable.Hide();
            UpdateAssignAd.Hide();
            label98.Hide();
            AdvisorID.Text = "";
            Designation.Text = "Designation";
            AdSalary.Text = "";
            On_off(TotalAdvsiorsIco, AssigAdIcon, OnPendingIcon, AddAdIcon, AssAdIcon, 3);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select Count(*) FROM Advisor A LEFT OUTER JOIN ProjectAdvisor PA ON A.Id = PA.AdvisorId WHERE PA.ProjectId is NULL", con);
            SqlDataReader sdr = sql.ExecuteReader();
            while (sdr.Read())
            {
                OnPenCount.Text = sdr[0].ToString() + " __ more__ Click---";
            }
            sdr.Close();
            Tshow(TotalAdCount, AssCount, OnPenCount, 3);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DeleteAdvi.Hide();
            AdDelLin.Hide();
            AdvisorID.Show();
            label29.Show();
            Designation.Show();
            AdSalary.Show();
            label30.Show();
            label31.Show();
            AddAdvi.Show();
            UpdateAdvi.Hide();
            AdvisorTable.DataSource = null;
            AdvisorTable.Refresh();
            AdvisorTable.Hide();
            UpdateAssignAd.Hide();
            label98.Hide();
            AdvisorID.Text = "";
            Designation.Text = "Designation";
            AdSalary.Text = "";
            On_off(TotalAdvsiorsIco, AssigAdIcon, OnPendingIcon, AddAdIcon, AssAdIcon, 4);
        }

        public void pictureBox21_Click(object sender, EventArgs e)
        {
            DeleteAdvi.Hide();
            AdDelLin.Hide();
            AdvisorID.Hide();
            label29.Hide();
            Designation.Hide();
            AdSalary.Hide();
            label30.Hide();
            label31.Hide();
            AddAdvi.Hide();
            UpdateAdvi.Hide();
            AdvisorTable.DataSource = null;
            AdvisorTable.Refresh();
            AdvisorTable.Hide();
            UpdateAssignAd.Hide();
            label98.Hide();
            AdvisorID.Text = "";
            Designation.Text = "Designation";
            AdSalary.Text = "";
            On_off(TotalAdvsiorsIco, AssigAdIcon, OnPendingIcon, AddAdIcon, AssAdIcon, 5);
            AssignForm Af = new AssignForm();
            Af.Show();
            Af.tabControl1.SelectTab(1);
            ViewProTable(Af.TotalProjects);
        }

        private void TotalAdCount_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select A.Id, CAST(A.Designation as varchar)+' '+L.Value as [Designation], A.Salary From Advisor A JOIN [Lookup] L ON A.Designation = L.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdvisorTable.DataSource = dt;
            sql.ExecuteNonQuery();
            AdvisorTable.Show();

        }

        private void AssCount_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select PA.AdvisorId,PA.ProjectId,CASt(PA.AdvisorRole as varchar)+' '+(Select L.Value FROM [Lookup]L Where L.Id = PA.AdvisorRole)as [AdvsiorRole],CAst(PA.AssignmentDate as date)as[Date] FROM ProjectAdvisor PA", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdvisorTable.DataSource = dt;
            sql.ExecuteNonQuery();
            AdvisorTable.Show();

        }

        private void OnPenCount_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select A.Id,CASt(A.Designation as varchar)+' '+L.Value as [Designation],A.Salary FROM Advisor A LEFT OUTER JOIN ProjectAdvisor PA ON A.Id = PA.AdvisorId JOIN [Lookup]L ON A.Designation = L.Id WHERE PA.ProjectId is NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdvisorTable.DataSource = dt;
            sql.ExecuteNonQuery();
            AdvisorTable.Show();
        }



        // Function to load Advisor Role


        private void AdvisorTable_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

            textBox6.Hide();

            label72.Hide();
            TotalMarks.Hide();
            label73.Hide();
            label74.Hide();
            AddEvalBtn.Hide();
            Weightage.Hide();
            label97.Hide();
            label71.Hide();
            // Delete Updte
            UpddateEval.Hide();
            DelEval.Hide();
            label100.Hide();
            /// end

            UpdateEval.Hide();
            EvaluationTable.DataSource = null;
            EvaluationTable.Refresh();
            EvaluationTable.Hide();
            On_off(TotalEvaIcon, GrpEvalIcon, UnEvalGropIcon, AddNewEvaIcon, MarkEvalIcon, 1);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT Count(Id) FROM Evaluation", con);
            SqlDataReader sdr = sql.ExecuteReader();
            while (sdr.Read())
            {
                TotEvaIcon.Text = sdr[0].ToString() + " __ more --";
            }
            sdr.Close();
            Tshow(TotEvaIcon, TotlGrpEvalIcon, TotlUnevalIcon, 1);

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

            textBox6.Hide();

            label72.Hide();
            TotalMarks.Hide();
            label73.Hide();
            label74.Hide();
            AddEvalBtn.Hide();
            Weightage.Hide();
            label97.Hide();
            label71.Hide();
            UpddateEval.Hide();
            DelEval.Hide();
            label100.Hide();
            /// end
            UpdateEval.Hide();
            EvaluationTable.DataSource = null;
            EvaluationTable.Refresh();
            EvaluationTable.Hide();
            On_off(TotalEvaIcon, GrpEvalIcon, UnEvalGropIcon, AddNewEvaIcon, MarkEvalIcon, 2);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT GroupId,Count(GE.EvaluationId)as[No of Evaluations] FROM GroupEvaluation GE GROUP BY GE.GroupId", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EvaluationTable.DataSource = dt;
            sql.ExecuteNonQuery();
            EvaluationTable.Show();
            TotlGrpEvalIcon.Text = "__ more Detail -- Click";
            Tshow(TotEvaIcon, TotlGrpEvalIcon, TotlUnevalIcon, 2);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

            textBox6.Hide();

            label72.Hide();
            TotalMarks.Hide();
            label73.Hide();
            label74.Hide();
            AddEvalBtn.Hide();
            Weightage.Hide();
            label97.Hide();
            label71.Hide();
            UpddateEval.Hide();
            DelEval.Hide();
            label100.Hide();

            /// end
            UpdateEval.Hide();
            EvaluationTable.DataSource = null;
            EvaluationTable.Refresh();
            EvaluationTable.Hide();
            On_off(TotalEvaIcon, GrpEvalIcon, UnEvalGropIcon, AddNewEvaIcon, MarkEvalIcon, 3);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select Count(GS.GroupId) FROM GroupStudent GS LEFT OUTER JOIN GroupEvaluation GE ON GS.GroupId = GE.GroupId WHERE GE.EvaluationId is NULL", con);
            SqlDataReader sdr = sql.ExecuteReader();
            while (sdr.Read())
            {
                TotlUnevalIcon.Text = sdr[0].ToString() + " __ Click to more --";
            }
            sdr.Close();
            Tshow(TotEvaIcon, TotlGrpEvalIcon, TotlUnevalIcon, 3);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

            textBox6.Show();

            label72.Show();
            TotalMarks.Show();
            label73.Show();
            label74.Show();
            AddEvalBtn.Show();
            Weightage.Show();
            label97.Show();
            label71.Show();
            UpddateEval.Hide();
            DelEval.Hide();
            label100.Hide();

            /// end
            UpdateEval.Hide();
            EvaluationTable.DataSource = null;
            EvaluationTable.Refresh();
            EvaluationTable.Hide();
            On_off(TotalEvaIcon, GrpEvalIcon, UnEvalGropIcon, AddNewEvaIcon, MarkEvalIcon, 4);
            Tshow(TotEvaIcon, TotlGrpEvalIcon, TotlUnevalIcon, 4);
        }

        public void pictureBox26_Click(object sender, EventArgs e)
        {

            textBox6.Hide();
            AssignForm af = new AssignForm();

            label72.Hide();
            TotalMarks.Hide();
            label73.Hide();
            label74.Hide();
            AddEvalBtn.Hide();
            Weightage.Hide();
            label97.Hide();
            label71.Hide();
            UpddateEval.Hide();
            DelEval.Hide();
            label100.Hide();
            /// end
            UpdateEval.Hide();
            EvaluationTable.DataSource = null;
            EvaluationTable.Refresh();
            EvaluationTable.Hide();
            On_off(TotalEvaIcon, GrpEvalIcon, UnEvalGropIcon, AddNewEvaIcon, MarkEvalIcon, 5);
            Tshow(TotEvaIcon, TotlGrpEvalIcon, TotlUnevalIcon, 5);
            af.Show();
            af.UpEvalBtn.Hide();
            af.button2.Show();
            af.tabControl1.SelectTab(2);
            LoadGroups(af.dataGridView3);
        }

        private void Weightage_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotEvaIcon_Click(object sender, EventArgs e)
        {
            LoadEvaluation(EvaluationTable);
        }

        // Functions to Load all Evaluation
        private void LoadEvaluation(DataGridView dg)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT * FROM Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            sql.ExecuteNonQuery();
            dg.Show();
        }

        private void TotlGrpEvalIcon_Click(object sender, EventArgs e)
        {
            EvaluationTable.DataSource = null;
            EvaluationTable.Refresh();
            //EvaluationTable.Hide();
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select E.Id,E.Name,E.TotalMarks,E.TotalWeightage,GE.GroupId,GE.ObtainedMarks,CAST(GE.EvaluationDate as date)as[Date] FROM Evaluation E JOIN GroupEvaluation GE on GE.EvaluationId = E.Id;", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EvaluationTable.DataSource = dt;
            sql.ExecuteNonQuery();
            EvaluationTable.Show();
        }

        private void TotlUnevalIcon_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select GS.GroupId,GS.StudentId FROM GroupStudent GS LEFT OUTER JOIN GroupEvaluation GE ON GS.GroupId = GE.GroupId WHERE GE.EvaluationId is NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EvaluationTable.DataSource = dt;
            sql.ExecuteNonQuery();
            EvaluationTable.Show();
        }

        private void AddEvalBtn_Click(object sender, EventArgs e)
        {
            if(textBox6.Text!="" && TotalMarks.Value!=0 && Weightage.Value!=0)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand sql = new SqlCommand("INSERT INTO Evaluation VALUES(@Name,@TotalMarks,@TotalWeightage)", con);
                sql.Parameters.AddWithValue("@Name", textBox6.Text);
                sql.Parameters.AddWithValue("@TotalMarks", TotalMarks.Value);
                sql.Parameters.AddWithValue("@TotalWeightage", Weightage.Value);
                sql.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
                LoadEvaluation(EvaluationTable);
            }
            else
            {
                MessageBox.Show("Above entities are compulsary to add");
            }
            
        }

        // Function to show all groups with assignd projects
        private void LoadGroups(DataGridView dg)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT DISTINCT GP.GroupId,GP.ProjectId,P.Title,CAST(GP.AssignmentDate as date)as[Assignment Date] FROM GroupProject GP JOIN Project P ON P.Id = GP.ProjectId LEFT JOIN GroupStudent GS ON GS.GroupId = GP.GroupId WHERE GS.GroupId is NOT NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            sql.ExecuteNonQuery();
            dg.Show();
        }

        private void EvaluationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //UpddateEval.Hide();

            DataGridViewRow selectedRow = EvaluationTable.Rows[index];
            EvaluationId.Text = selectedRow.Cells[0].Value.ToString();
            textBox6.Text = selectedRow.Cells[1].Value.ToString();
            if (EvaluationTable.Columns[1].HeaderText.ToString() != "Name")
            {

                MessageBox.Show("Connot Edit these Details Here");
            }
            else
            {
                TotalMarks.Value = int.Parse(selectedRow.Cells[2].Value.ToString());
                Weightage.Value = int.Parse(selectedRow.Cells[3].Value.ToString());
                try
                {
                    if (EvaluationTable.Columns[4].HeaderText.ToString() == "GroupId")
                    {

                        UpddateEval.Show();
                        DelEval.Show();
                        label100.Show();


                    }

                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Coloumn Not Exist ");
                    DelEval.Show();
                    label100.Show();
                    textBox6.Show();
                    label72.Show();
                    TotalMarks.Show();
                    label73.Show();
                    label74.Show();
                    AddEvalBtn.Hide();
                    Weightage.Show();
                    label97.Show();
                    label71.Show();
                    UpdateEval.Show();
                }

            }


        }

        private void UpdateEval_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(EvaluationId.Text);
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("UPDATE Evaluation SET Name = @a2,TotalMarks =@a3,TotalWeightage=@a4 WHERE Id = @a1", con);
            sql.Parameters.AddWithValue("@a1", Id);
            sql.Parameters.AddWithValue("@a2", textBox6.Text);
            sql.Parameters.AddWithValue("@a3", TotalMarks.Value);
            sql.Parameters.AddWithValue("@a4", Weightage.Value);
            sql.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            label72.Hide();
            TotalMarks.Hide();
            label73.Hide();
            label74.Hide();
            AddEvalBtn.Hide();
            Weightage.Hide();
            label97.Hide();
            label71.Hide();
            LoadEvaluation(EvaluationTable);

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            EditBtn.Show();
            AddBtn.Hide();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            RegNo.Text = selectedRow.Cells[1].Value.ToString();
            string fullname = selectedRow.Cells[2].Value.ToString();
            string[] ss = fullname.Split(' ');
            Firstname.Text = ss[0];
            LastName.Text = ss[1];
            DOB.Text = selectedRow.Cells[3].Value.ToString();
            ContactNo.Text = selectedRow.Cells[4].Value.ToString();
            Email.Text = selectedRow.Cells[5].Value.ToString();
            int gender = int.Parse(selectedRow.Cells[6].Value.ToString());
            if (gender == 1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }
            Delete.Show();
            DelLine.Show();
        }

        private void UpdateAssignAd_Click(object sender, EventArgs e)
        {
            int projectid = int.Parse(ProjectID.Text);
            int advisorId = int.Parse(AdvisorID.Text);
            AssignForm af = new AssignForm();
            af.Show();
            af.tabControl1.SelectTab(1);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmm = new SqlCommand("Select A.Id,Cast(A.Designation as varchar)+' '+(Select L.Value From [Lookup]L Where A.Designation = L.Id)as[Designation] FROM Advisor A WHERE A.Id = '" + advisorId + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            af.dataGridView1.DataSource = dt;
            cmm.ExecuteNonQuery();
            af.label8.Text = "Selected Advisor";
            af.label7.Text = "Update Advisor Assignment";
            af.label21.Show();

            cmm = new SqlCommand("Select P.Id,P.Title,P.Description FROM ProjectAdvisor PA JOIN Project P ON P.Id = PA.ProjectId WHERE PA.AdvisorId='" + advisorId + "' AND PA.ProjectId = '" + projectid + "'", con);
            SqlDataAdapter daa = new SqlDataAdapter(cmm);
            DataTable ddt = new DataTable();
            daa.Fill(ddt);
            af.TotalProjects.DataSource = ddt;
            cmm.ExecuteNonQuery();
            af.label9.Text = "Selected project Detail";
            af.textBox3.Text = projectid.ToString();
            af.textBox2.Text = advisorId.ToString();
            af.button1.Text = "Update";
            af.TableRole.Text = label63.Text;
            cmm = new SqlCommand("Select CAST(PA.AdvisorRole as varchar)+' '+(Select L.Value FROM [Lookup]L WHERE L.Id =PA.AdvisorRole ) FROM ProjectAdvisor PA WHERE PA.AdvisorId ='" + advisorId + "' AND PA.ProjectId='" + projectid + "'", con);
            SqlDataReader sdr = cmm.ExecuteReader();
            while (sdr.Read())
            {
                af.AdviRole.Text = sdr[0].ToString();
            }
            sdr.Close();
        }

        private void UpddateEval_Click(object sender, EventArgs e)
        {
            AssignForm af = new AssignForm();
            // UpddateEval.Show();
            af.Show();
            af.tabControl1.SelectTab(2);
            int groupId = int.Parse(EvaluationTable.SelectedCells[4].Value.ToString());
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("SELECT DISTINCT GP.GroupId,GP.ProjectId,P.Title,CAST(GP.AssignmentDate as date)as[Assignment Date] FROM GroupProject GP JOIN Project P ON P.Id = GP.ProjectId LEFT JOIN GroupStudent GS ON GS.GroupId = GP.GroupId WHERE GS.GroupId is NOT NULL AND GS.GroupId = '" + groupId + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            af.dataGridView3.DataSource = dt;
            sql.ExecuteNonQuery();
            af.dataGridView3.Show();

            sql = new SqlCommand("Select * FROM Evaluation E WHERE E.Id IN (SELECT GE.EvaluationId FROM GroupEvaluation GE WHERE GE.EvaluationId = E.Id AND GE.GroupId='" + groupId + "') ", con);
            SqlDataAdapter daa = new SqlDataAdapter(sql);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            af.dataGridView2.DataSource = dtt;
            sql.ExecuteNonQuery();

            af.textBox5.Text = groupId.ToString();
            af.textBox6.Text = EvaluationTable.SelectedCells[0].Value.ToString();
            af.numericUpDown1.Value = int.Parse(EvaluationTable.SelectedCells[5].Value.ToString());
            af.numericUpDown1.Maximum = int.Parse(EvaluationTable.SelectedCells[2].Value.ToString());
            af.label13.Text = "Update Evaluation";
            af.UpEvalBtn.Show();
            af.button2.Hide();
        }

        private void DelEval_Click(object sender, EventArgs e)
        {
            int evaluid = int.Parse(EvaluationTable.SelectedCells[0].Value.ToString());
            int  groupid = int.Parse(EvaluationTable.SelectedCells[4].Value.ToString());
            var con = Configuration.getInstance().getConnection();
            
            

            if (EvaluationTable.Columns[1].HeaderText.ToString() != "Name")
            {

                MessageBox.Show("Connot Edit these Details Here");
            }
            else
            {

                try
                {
                    if (EvaluationTable.Columns[4].HeaderText.ToString() == "GroupId")
                    {
                        SqlCommand sql = new SqlCommand("DELETE FROM GroupEvaluation WHERE EvaluationId = '" + evaluid + "' AND GroupId = '"+groupid+"'", con);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");



                    }

                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Coloumn Not Exist ");
                    SqlCommand sql = new SqlCommand("DELETE FROM Evaluation WHERE Id = '" + evaluid + "'", con);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");

                }

            }
        }

        public void pictureBox11_Click_1(object sender, EventArgs e)
        {
            TGroupIcon.Hide();
            AssignForm AF = new AssignForm();
            Title.Hide();
            UpdateProj.Hide();
            TLine.Hide();
            Descrip.Hide();
            DesLine.Hide();
            AddProj.Hide();
            ProjectTable.DataSource = null;
            ProjectTable.Refresh();
            ProjectTable.Hide();
            DPLine.Hide();
            DelProject.Hide();
            On_off(TGroupIcon, NoOfStdIcons, AddStdGrp, AddGroup, pictureBox12, 5);
            Tshow(TotalProjects, AssignedPros, PendingPros, 5);
            AF.Show();
            ViewProTable(AF.PenAssignProjectTable);
            loadPendingGroups(AF.PendingGrpsAssignTable);
        }

        private DataTable makingReport()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sql = new SqlCommand("Select Count(*) FROm Project", con);
            DataTable dt = new DataTable();

            dt.Columns.Add("Projects", typeof(string));
            dt.Columns.Add("Assigned_To", typeof(string));
            dt.Columns.Add("Assigned Advisors", typeof(string));
            dt.Columns.Add("Students", typeof(string));

            sql = new SqlCommand("Select Id FROm Project", con);
            SqlDataReader readId = sql.ExecuteReader();
            while(readId.Read())
            {
                int projectid = int.Parse(readId[0].ToString());
                sql = new SqlCommand("SELECT GP.GroupId FROM GroupProject GP WHERE GP.ProjectId = '" + projectid + "'", con);
                string groupid = "";
                SqlDataReader readGpid = sql.ExecuteReader();
                while(readGpid.Read())
                {
                    groupid = (readGpid[0].ToString());
                }
                readGpid.Close();
                string advisorId = "";
                sql = new SqlCommand("Select AdvisorId from ProjectAdvisor WHERE ProjectId = '"+projectid+"'", con);
                SqlDataReader readAdviosrId = sql.ExecuteReader();
                while(readAdviosrId.Read())
                {
                    int advid = int.Parse(readAdviosrId[0].ToString());
                    sql = new SqlCommand("Select 'AdvisorId : ' + Cast(A.Id as varchar)+'_'+(Select L.Value from [Lookup]L WHERE L.Id=A.Designation)+' ;  Role : '+(SELECt L.Value FROM [Lookup]L WHERE L.Id = PA.AdvisorRole) FROM Advisor A JOIN ProjectAdvisor PA ON A.Id = PA.AdvisorId WHERE A.Id = '"+advid+"'", con);
                    SqlDataReader readDesId = sql.ExecuteReader();
                    int i = 1;
                    advisorId = "";
                    while (readDesId.Read())
                    {
                        advisorId = advisorId + i+":  " +  readDesId[0].ToString() + "\n" ;
                        i++;
                    }
                    readDesId.Close();
                   
                }
                readAdviosrId.Close();

                string students = "";
                int k = 1;
                sql = new SqlCommand(" SELECt S.RegistrationNo FROM GroupStudent GS JOIN Student S ON S.Id = GS.StudentId WHERE GS.GroupId = '"+groupid+"'", con);
                SqlDataReader readStd = sql.ExecuteReader();
                while(readStd.Read())
                {
                    students = students + k + ":  " + readStd[0].ToString() + "\n";
                    k++;
                }
                readStd.Close();
                
                if(groupid=="")
                {
                    groupid = "N/A";
                }
                if(advisorId == "")
                {
                    advisorId = "N/A";
                }
                if(students == "")
                {
                    students = "N/A";
                }
                dt.Rows.Add(projectid, groupid, advisorId, students);
            }
            return dt;
        }

        private void generate_report(int control,string name)
        {
            DataTable tb = new DataTable();
            if (control == 1)
            {
                tb = makingReport();
            }
            else if(control==3)
            {
                tb = pendingStudentReports();
            }
            else if(control==2)
            {
                tb = getStudetsMarks();
            }
            else if (control ==4)
            {
                tb = getStudentAVGMARKS();
            }
            OpenFileDialog op = new OpenFileDialog();
            string folderPath = "";
            op.ValidateNames = false;
            op.CheckFileExists = false;
            op.CheckPathExists = true;
            op.FileName = "Folder Selection.";
            if (op.ShowDialog() == DialogResult.OK)
            {
                folderPath = Path.GetDirectoryName(op.FileName);
                FileStream fs = new FileStream(@"" + folderPath + @"\'"+name+"'.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                Document doc = new Document();
                doc.SetPageSize(iTextSharp.text.PageSize
                    .A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Report Header
                BaseFont bfothead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
                Font fnt1 = new Font(bfothead, 16, 1, BaseColor.BLACK);
                Font fnt3 = new Font(bfothead, 14, 1, BaseColor.BLACK);
                Paragraph prg = new Paragraph();
                prg.Alignment = Element.ALIGN_CENTER;
                prg.Add(new Chunk("University Of Engineering And Technolgy", fnt1));
                doc.Add(prg);
                prg = new Paragraph();
                prg.Alignment = Element.ALIGN_CENTER;
                Font fnt2 = new Font(bfothead, 12, 2, BaseColor.BLACK);
                prg.Add(new Chunk("'"+name+"'", fnt2));
                doc.Add(prg);
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                doc.Add(p);
                prg = new Paragraph();
                prg.Alignment = Element.ALIGN_LEFT;
                prg.Add(new Chunk("\nFYP Management System", fnt3));
                prg.Add(new Chunk("\nSemester:   ", fnt3));
                prg.Add(new Chunk("Fall 2022", fnt2));
                prg.Add(new Chunk("\nLecturer:   ", fnt3));
                prg.Add(new Chunk("Nazeef-ul-Haq \n", fnt2));

                doc.Add(prg);
                p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                doc.Add(p);


                prg = new Paragraph();
                prg.Alignment = Element.ALIGN_LEFT;
                prg.Add(new Chunk("\n'"+name+"' \n\n", fnt3));
                doc.Add(prg);

                // write second table
                PdfPTable table2 = new PdfPTable(tb.Columns.Count);
                //table header
                table2.WidthPercentage = 100;
                table2.TotalWidth = 500f;

                fnt1 = new Font(bfothead, 10, 1, BaseColor.WHITE);
                for (int i = 0; i < tb.Columns.Count; i++)
                {
                    PdfPCell cel = new PdfPCell();
                    cel.BackgroundColor = BaseColor.DARK_GRAY;
                    cel.HorizontalAlignment = Element.ALIGN_CENTER;
                    cel.AddElement(new Chunk(tb.Columns[i].ColumnName.ToUpper(), fnt1));
                    table2.AddCell(cel);
                }
                //table data
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    for (int j = 0; j < tb.Columns.Count; j++)
                    {
                        table2.AddCell(tb.Rows[i][j].ToString());
                    }
                }
                doc.Add(table2);
                doc.Close();
                writer.Close();
                fs.Close();
                MessageBox.Show("Report Generated!");
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            generate_report(1,"ProjectDetailReport");
        }


        /// function to generate pending students report
        private DataTable pendingStudentReports()
        {
            var con = Configuration.getInstance().getConnection();
            DataTable dt = new DataTable();

            dt.Columns.Add("RegistrationNo", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Contact", typeof(string));

           SqlCommand sql = new SqlCommand("SELECT S.RegistrationNo, P.FirstName+' '+p.LastName AS Name, P.Email, p.Contact FROM Student S LEFT JOIN [GroupStudent] GS ON GS.StudentId = S.Id JOIN Person P ON S.Id = P.Id  Where GS.StudentId is Null", con);
            SqlDataReader readId = sql.ExecuteReader();
            while (readId.Read())
            {
                
                dt.Rows.Add(readId[0].ToString(),readId[1].ToString(), readId[2].ToString(), readId[3].ToString());
            }
            return dt;
        }

        // function to generate students marks
        private DataTable getStudetsMarks()
        {
            var con = Configuration.getInstance().getConnection();
            DataTable dt = new DataTable();
            dt.Columns.Add("GroupId", typeof(String));
            dt.Columns.Add("ProjectID", typeof(String));
            dt.Columns.Add("ProjectTitle", typeof(String));
            dt.Columns.Add("RegNo", typeof(String));
            dt.Columns.Add("Obtained", typeof(String));
            dt.Columns.Add("TotalMarks", typeof(String));
            dt.Columns.Add("Evaluation", typeof(String));

            SqlCommand cmd = new SqlCommand("USE ProjectA Select Id from [Group]", con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int Pid = int.Parse(dataReader[0].ToString());
                SqlCommand sql = new SqlCommand("USE ProjectA SELECT  P.Id AS ProjectID, P.Title AS ProjectTitle, S.RegistrationNo, GE.ObtainedMarks, E.TotalMarks, E.Name AS Evalution From [Group] G JOIN GroupStudent GS on GS.GroupId = G.Id Join Student S ON GS.StudentId = S.id JOIN GroupEvaluation GE ON G.Id= ge.GroupId JOIN Evaluation E on E.id = GE.EvaluationId JOIN GroupProject GP ON G.Id = GP.GroupId JOIN Project P ON P.Id = GP.ProjectId Where g.id = " + Pid + "; ", con);
                SqlDataReader AdvisorData = sql.ExecuteReader();

                String Advisors = "";
                while (AdvisorData.Read())
                {

                    dt.Rows.Add(Pid, AdvisorData[0].ToString(), AdvisorData[1].ToString(), AdvisorData[2].ToString(), AdvisorData[3].ToString(), AdvisorData[4].ToString(), AdvisorData[5].ToString());

                }

                if (Advisors == "")
                {
                    Advisors = "N/A";
                }

            }
            return dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            generate_report(2, "MarksSheetOfStudents");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            generate_report(3, "PendingStudentsReport");
        }

        private DataTable getStudentAVGMARKS()
        {
            var con = Configuration.getInstance().getConnection();
            DataTable dt = new DataTable();
            dt.Columns.Add("Registration Number", typeof(String));
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Obtained Marks", typeof(String));

            SqlCommand cmd = new SqlCommand("SELECT S.RegistrationNo, P.FirstName+' '+P.LastName AS NAME, Sum(GE.ObtainedMarks) as [Obtained Marks] FROM GroupEvaluation GE JOIN GroupStudent GS ON GS.GroupId = GE.GroupId JOIN Person P ON GS.StudentId = P.Id JOIN Student S ON GS.StudentId = S.Id Group by S.RegistrationNo,  P.FirstName+' '+P.LastName Having Sum(GE.ObtainedMarks) < (SELECT AVG(A.[total Marks]) FROM (SELECT SUM(ObtainedMarks) as [total Marks] FROM GroupEvaluation ge GROUP BY GroupId ) as A)", con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                dt.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString());
            }
            return dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            generate_report(4,"StdsHavingBelowAVG_Marks");
        }
    }
}
