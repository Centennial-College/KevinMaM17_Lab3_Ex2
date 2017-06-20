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

        private void LearnersForm_Load(object sender, EventArgs e)
        {
            this.loadUnfilteredResults();
            this.searchBtn.Enabled = false;
        }

        /// <summary>
        /// Fills the kevinTBBindingSource with all rows, ordered by learnerID
        /// </summary>
        private void loadUnfilteredResults()
        {
            using (var dbContext = new KevinDBEntities())
            {

                //load kevintb table ordered by learnerid
                dbContext.KevinTBs
                    .OrderBy(learner => learner.learnerID)
                    .Load();

                //specify DataSource for kevinTBBindingSource
                kevinTBBindingSource.DataSource = dbContext.KevinTBs.Local;
                kevinTBBindingSource.MoveFirst(); // go to first result    
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (var dbContext = new KevinDBEntities())
            {
                var filteredResults = from learner in dbContext.KevinTBs
                                      where learner.enrolledProgram.Equals(searchTb.Text)
                                      select new
                                      {
                                          learner.learnerID,
                                          learner.learnerName,
                                          learner.enrolledProgram
                                      };

                searchTb.Clear();

                kevinTBBindingSource.DataSource = filteredResults.ToList();
                kevinTBBindingSource.MoveFirst();
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Enabled = !String.IsNullOrEmpty(searchTb.Text);
        }
    }
}
