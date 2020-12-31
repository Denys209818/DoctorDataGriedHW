using DataGriedDoctor2HW.Models;
using DoctorDataGried.DAL.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGriedDoctor2HW
{
    public partial class MainForm : Form
    {
        public int PaginationIndex { get; set; }
        public int MaxLength { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblOut.Visible = false;
            doctorScrollBar.Visible = false;
            PaginationIndex = 0;
            doctorScrollBar.Value = 0;
            linkFirst.Text = "H";
            linkSecond.Text = (PaginationIndex+1).ToString();


            using (Context context = new Context()) 
            {
                doctorScrollBar.Maximum = ((context.doctors.Count() / 20) * 9);
                MaxLength = doctorScrollBar.Maximum / 9;
                foreach (var item in context.doctors.Include(doc => doc.Department).Skip(20 * PaginationIndex).Take(20))
                {
                    string[] arr =
                    {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Department.Name
                    };

                    doctorDataGried.Rows.Add(arr);
                }
            }
            if (MaxLength > 1) 
            {
                linkLast.Text = (PaginationIndex+2).ToString();
            }
        }

        private void doctorScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int count = doctorScrollBar.Value / 9;
            PaginationIndex = count;
            using (Context context = new Context())
            {
                doctorDataGried.Rows.Clear();
                foreach (var item in context.doctors.Include(doc => doc.Department).Skip(20 * PaginationIndex).Take(20))
                {
                    string[] arr =
                    {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Department.Name
                    };

                    doctorDataGried.Rows.Add(arr);
                }
            }
        }

        private void checkBoxIsScroll_CheckedChanged(object sender, EventArgs e)
        {
            bool isOk = checkBoxIsScroll.Checked;
            if (isOk)
            {
                lblMenu.Visible = false;
                linkFirst.Visible = false;
                linkSecond.Visible = false;
                linkLast.Visible = false;
                doctorScrollBar.Value = (int.Parse(linkSecond.Text) * 9)-9;
                doctorScrollBar.Visible = true;
            }
            else
            {
                lblMenu.Visible = true;
                linkFirst.Visible = true;
                linkSecond.Visible = true;
                linkLast.Visible = true;
                if (doctorScrollBar.Value / 9 != 0)
                {
                    linkFirst.Text = ((doctorScrollBar.Value / 9)).ToString();
                }
                else 
                {
                    linkFirst.Text = "H";
                }
                linkSecond.Text = ((doctorScrollBar.Value / 9)+1).ToString();
                if ((doctorScrollBar.Value / 9)+1 < MaxLength)
                {
                    linkLast.Text = ((doctorScrollBar.Value / 9) + 2).ToString();
                }
                else 
                {
                    linkLast.Text = "H";
                }
                doctorScrollBar.Visible = false;
            }
        }

        private void linkFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkFirst.Text != "H") 
            {
                linkLast.Text = linkSecond.Text;
                linkSecond.Text = linkFirst.Text;
                PaginationIndex--;
                using (Context context = new Context())
            {
                doctorDataGried.Rows.Clear();
                foreach (var item in context.doctors.Include(doc => doc.Department).Skip(20 * PaginationIndex).Take(20))
                {
                    string[] arr =
                    {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Department.Name
                    };

                    doctorDataGried.Rows.Add(arr);
                }
            }
                if (PaginationIndex == 0)
                {
                    linkFirst.Text = "H";
                }
                else 
                {
                    linkFirst.Text = PaginationIndex.ToString();
                }
            }
        }

        private void linkLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLast.Text != "H")
            {
                linkFirst.Text = linkSecond.Text;
                linkSecond.Text = linkLast.Text;
                PaginationIndex++;
                using (Context context = new Context())
                {
                    doctorDataGried.Rows.Clear();
                    foreach (var item in context.doctors.Include(doc => doc.Department).Skip(20 * PaginationIndex).Take(20))
                    {
                        string[] arr =
                        {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Department.Name
                    };

                        doctorDataGried.Rows.Add(arr);
                    }
                }
                if (PaginationIndex >= MaxLength-1)
                {
                    linkLast.Text = "H";
                }
                else 
                {
                    linkLast.Text = (PaginationIndex+2).ToString();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            DialogResult res = form.ShowDialog();
            switch (res) 
            {
                case DialogResult.OK: 
                    {
                        lblOut.Visible = true;
                        lblMenu.Visible = false;
                        linkFirst.Visible = false;
                        linkSecond.Visible = false;
                        linkLast.Visible = false;

                        doctorDataGried.Rows.Clear();
                        doctorScrollBar.Visible = false;
                        PaginationIndex = 0;
                        doctorScrollBar.Value = 0;
                        linkFirst.Text = "H";
                        linkSecond.Text = (PaginationIndex + 1).ToString();


                        using (Context context = new Context())
                        {
                            doctorScrollBar.Maximum = ((SearchElement.doctors.Count() / 20) * 9);
                            MaxLength = doctorScrollBar.Maximum / 9;
                            foreach (var item in SearchElement.doctors.Skip(20 * PaginationIndex).Take(20))
                            {
                                if (item != null) 
                                {
                                    string[] arr =
                                    {
                                item.Id.ToString(),
                                item.FirstName,
                                item.LastName,
                                context.departments.Where(x=> x.Id == item.DepartmentId).First().Name
                                };

                                    doctorDataGried.Rows.Add(arr);
                                }
                            }
                        }
                        if (MaxLength > 1)
                        {
                            linkLast.Text = (PaginationIndex + 2).ToString();
                        }
                        break;
                    }
            }
        }

        private void lblOut_Click(object sender, EventArgs e) 
        {
            lblMenu.Visible = true;
            linkFirst.Visible = true;
            linkSecond.Visible = true;
            linkLast.Visible = true;
            lblOut.Visible = false;

            doctorScrollBar.Visible = false;
            PaginationIndex = 0;
            doctorScrollBar.Value = 0;
            linkFirst.Text = "H";
            linkSecond.Text = (PaginationIndex + 1).ToString();


            using (Context context = new Context())
            {
                doctorScrollBar.Maximum = ((context.doctors.Count() / 20) * 9);
                MaxLength = doctorScrollBar.Maximum / 9;
                foreach (var item in context.doctors.Include(doc => doc.Department).Skip(20 * PaginationIndex).Take(20))
                {
                    string[] arr =
                    {
                    item.Id.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Department.Name
                    };

                    doctorDataGried.Rows.Add(arr);
                }
            }
            if (MaxLength > 1)
            {
                linkLast.Text = (PaginationIndex + 2).ToString();
            }
        }
    }
}
