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
            this.resetFormControls();
        }

        private void resetFormControls()
        {
            this.searchBtn.Enabled = false;
            this.addBtn.Enabled = false;
            this.deleteBtn.Enabled = false;
            this.updateBtn.Enabled = false;

            searchTb.Clear();

            learnerIDTb.Clear();
            learnerNameTb.Clear();
            enrolledProgramTb.Clear();
            favSubTb.Clear();
            numLangTb.Clear();
            strongSkillTb.Clear();
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

                kevinTBBindingSource.DataSource = filteredResults.ToList();
                kevinTBBindingSource.MoveFirst();
                this.resetFormControls();
            }
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Enabled = !String.IsNullOrEmpty(searchTb.Text);
        }

        private void learnerDetailsTb_TextChanged(object sender, EventArgs e)
        {
            addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled
                = !String.IsNullOrEmpty(learnerIDTb.Text)
                && !String.IsNullOrEmpty(learnerNameTb.Text)
                && !String.IsNullOrEmpty(enrolledProgramTb.Text);
        }

        private void browseAllBtn_Click(object sender, EventArgs e)
        {
            this.loadUnfilteredResults();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (var dbContext = new KevinDBEntities())
            {
                //create an instance of the Entity object
                KevinTB learner = new KevinTB
                {
                    learnerID = int.Parse(learnerIDTb.Text),
                    learnerName = learnerNameTb.Text,
                    enrolledProgram = enrolledProgramTb.Text,
                    favoriteSubject = String.IsNullOrEmpty(favSubTb.Text) ? null : favSubTb.Text,
                    numberOfLanguages = String.IsNullOrEmpty(numLangTb.Text) ? 1 : int.Parse(numLangTb.Text),
                    strongestSkill = String.IsNullOrEmpty(strongSkillTb.Text) ? null : strongSkillTb.Text
                };

                //adds the given entity to the context underlying the set
                dbContext.KevinTBs.Add(learner);
                dbContext.Entry(learner).State = EntityState.Added;

                //save dbContext - also save data to the db
                dbContext.SaveChanges();
                MessageBox.Show($"Added new learner to the directory: {learner.learnerName}");
            }

            this.loadUnfilteredResults();
        }
    }
}
