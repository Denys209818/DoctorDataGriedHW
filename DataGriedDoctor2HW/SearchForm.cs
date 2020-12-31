using DataGriedDoctor2HW.Models;
using DoctorDataGried.DAL;
using DoctorDataGried.DAL.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGriedDoctor2HW
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            using (Context context = new Context())
            {
                List<Doctor> query = context.doctors.ToList();
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query = query.Where(x => x.FirstName == txtName.Text).ToList();
                }

                if (!string.IsNullOrEmpty(txtSurname.Text))
                {
                    query = query.Where(x => x.LastName == txtSurname.Text).ToList();
                }

                if (!string.IsNullOrEmpty(txtDepartmentName.Text))
                {
                    var el = context.departments.Where(x => x.Name == txtDepartmentName.Text).FirstOrDefault();
                    if (el != null) 
                    {
                        query = query.Where(x => el.Id == x.DepartmentId).ToList();
                    }
                }

                if (!string.IsNullOrEmpty(txtId.Text)) 
                {
                    try
                    {
                        int Id = int.Parse(txtId.Text);
                        query = query.Where(x => x.Id == Id).ToList();
                    }
                    catch
                    { }
                }
                SearchElement.doctors = query;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
