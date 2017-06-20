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

        private bool currentlyEditing = false;

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
            this.learnerIDTb.Enabled = true;
            currentlyEditing = false;

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
            if (!currentlyEditing)
                addBtn.Enabled = !String.IsNullOrEmpty(learnerIDTb.Text)
                && !String.IsNullOrEmpty(learnerNameTb.Text)
                && !String.IsNullOrEmpty(enrolledProgramTb.Text)
                && !String.IsNullOrEmpty(favSubTb.Text)
                && !String.IsNullOrEmpty(numLangTb.Text)
                && !String.IsNullOrEmpty(strongSkillTb.Text);
            else
                updateBtn.Enabled = deleteBtn.Enabled
                    = !String.IsNullOrEmpty(learnerIDTb.Text)
                    && !String.IsNullOrEmpty(learnerNameTb.Text)
                    && !String.IsNullOrEmpty(enrolledProgramTb.Text)
                    && !String.IsNullOrEmpty(favSubTb.Text)
                    && !String.IsNullOrEmpty(numLangTb.Text)
                    && !String.IsNullOrEmpty(strongSkillTb.Text);
        }

        private void browseAllBtn_Click(object sender, EventArgs e)
        {
            this.loadUnfilteredResults();
            this.resetFormControls();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (var dbContext = new KevinDBEntities())
            {
                try
                {
                    //create an instance of the Entity object
                    KevinTB learner = new KevinTB
                    {
                        learnerID = int.Parse(learnerIDTb.Text),
                        learnerName = learnerNameTb.Text,
                        enrolledProgram = enrolledProgramTb.Text,
                        favoriteSubject = favSubTb.Text,
                        numberOfLanguages = int.Parse(numLangTb.Text),
                        strongestSkill = strongSkillTb.Text
                    };

                    //adds the given entity to the context underlying the set
                    dbContext.KevinTBs.Add(learner);
                    dbContext.Entry(learner).State = EntityState.Added;

                    //save dbContext - also save data to the db
                    dbContext.SaveChanges();
                    MessageBox.Show($"Added new learner to the directory: {learner.learnerName}");
                    this.loadUnfilteredResults();
                }
                catch (Exception)
                {
                    MessageBox.Show($"LearnerID and Number of Languages must be positive integer numbers!");
                }
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            KevinTB learner;

            //Get learner for the given learnerId
            using (var dbContext = new KevinDBEntities())
            {
                learner = dbContext.KevinTBs
                    .Where(l => l.learnerID == int.Parse(learnerIDTb.Text))
                    .FirstOrDefault<KevinTB>();
            }

            // Update learner info in disconnected mode (out of dbContext scope)
            if (learner != null)
            {
                try
                {
                    learner.learnerID = int.Parse(learnerIDTb.Text);
                    learner.learnerName = learnerNameTb.Text;
                    learner.enrolledProgram = enrolledProgramTb.Text;
                    learner.favoriteSubject = favSubTb.Text;
                    learner.numberOfLanguages = int.Parse(numLangTb.Text);
                    learner.strongestSkill = strongSkillTb.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show($"LearnerID and Number of Languages must be positive integer numbers!");
                }
            }

            // Save modified entity using new Context
            using (var dbContext = new KevinDBEntities())
            {
                // Mark entity as modified
                dbContext.Entry(learner).State = EntityState.Modified;

                // Save changes to database
                dbContext.SaveChanges();
            }
            MessageBox.Show($"{learner.learnerName} has been updated");
        }

        private void kevinTBDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KevinTB learner;
            int selectedId = int.Parse(kevinTBDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            //Get learner for the given learnerId
            using (var dbContext = new KevinDBEntities())
            {
                learner = dbContext.KevinTBs
                    .Where(l => l.learnerID == selectedId)
                    .FirstOrDefault<KevinTB>();
            }

            learnerIDTb.Text = learner.learnerID.ToString();
            learnerNameTb.Text = learner.learnerName;
            enrolledProgramTb.Text = learner.enrolledProgram;
            favSubTb.Text = learner.favoriteSubject;
            numLangTb.Text = learner.numberOfLanguages.ToString();
            strongSkillTb.Text = learner.strongestSkill.ToString();

            currentlyEditing = true;
            learnerIDTb.Enabled = false;
            addBtn.Enabled = false;
        }
    }
}
