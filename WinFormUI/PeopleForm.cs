﻿using PersonDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            
            people = SqliteDataAccess.LoadPeople();  //loads the table data from the database

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "FullName";
        }

        private void refreshListButton_Click(object sender, EventArgs e) //refreshed the list of people 
        {
            LoadPeopleList();
        }

        private void addPersonButton_Click(object sender, EventArgs e) //click event that adds data in the text boxes to the corrosponding fields in the database
        {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;
            p.ImageNumber = imageNumberText.Text;
            p.School = schoolText.Text;

           
            SqliteDataAccess.SavePerson(p);

            firstNameText.Text = "";
            lastNameText.Text = "";
            imageNumberText.Text = "";
            schoolText.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();


            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;
            p.ImageNumber = imageNumberText.Text;
            p.School = schoolText.Text;



            firstNameText.Text = "";
            lastNameText.Text = "";
            imageNumberText.Text = "";
            schoolText.Text = "";

            SqliteDataAccess.SavePerson(p);
        }
    }
}
