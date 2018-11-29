﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyManagementSystem.Controller;
using KeyManagementSystem.Entity;

namespace KeyManagementSystem.Boundary
{
    public partial class UpdateKeyStatusForm : Form
    {
        private static Employee thisUser;
        public UpdateKeyStatusForm(Employee user)
        {
            thisUser = user;
            InitializeComponent();
        }

        private void UpdateKeyStatusForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KEY' table. You can move, or remove it, as needed.
            this.kEYTableAdapter.Fill(this.database1DataSet.KEY);

        }
    }
}
