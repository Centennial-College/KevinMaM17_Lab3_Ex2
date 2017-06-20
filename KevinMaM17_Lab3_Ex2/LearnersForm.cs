using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KevinDBModel;
using System.Data.Entity;

namespace KevinMaM17_Lab3_Ex2
{
    public partial class LearnersForm : Form
    {
        public LearnersForm()
        {
            InitializeComponent();
        }

        //Entity Framework DbContext
        private KevinDBEntities dbContext = null;

        private void LearnersForm_Load(object sender, EventArgs e)
        {
            this._refreshContacts();
        }

        /// <summary>
        /// Fills the kevinTBBindingSource with all rows, ordered by learnerID
        /// </summary>
        private void _refreshContacts()
        {
            //dispose of old dbContext, if any
            if (dbContext != null)
            {
                dbContext.Dispose();
            }

            // create new DbContext so we can reorder records based on edits
            dbContext = new KevinDBEntities();

            //load kevintb table ordered by learnerid
            dbContext.KevinTBs
                .OrderBy(learner => learner.learnerID)
                .Load();

            //specify DataSource for kevinTBBindingSource
            kevinTBBindingSource.DataSource = dbContext.KevinTBs.Local;
            kevinTBBindingSource.MoveFirst(); // go to first result    
        }

    }
}
