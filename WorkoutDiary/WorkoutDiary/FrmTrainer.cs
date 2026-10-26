using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters;

namespace WorkoutDiary
{
    public partial class FrmTrainer : Form
    {
        private int userId;
        private int athleteId, workoutId;
        private WorkoutDiaryDBDataSet.WorkoutsDataTable wTable;
        private WorkoutDiaryDBDataSet.SetsDataTable sTable;
        public FrmTrainer(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private void FrmTrainer_Load(object sender, EventArgs e)
        {
            dgvAthletes.AutoGenerateColumns = false;
            dgvProgress.AutoGenerateColumns = false;
            dgvWorkouts.AutoGenerateColumns = false;
            dgvSets.AutoGenerateColumns = false;

            colExercise.DataSource = new ExercisesTableAdapter().GetData();
            colExercise.DisplayMember = "Name";
            colExercise.ValueMember = "Id";

            cmbProgram.DataSource = new ProgramsTableAdapter().GetDataByAuthor(userId);
            cmbProgram.DisplayMember = "Name";
            cmbProgram.ValueMember = "Id";

            dgvAthletes.DataSource = new UsersTableAdapter().GetDataByTrainer(userId);
        }

        private void btnLogout_Click_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (athleteId == 0 || cmbProgram.SelectedValue == null) return;
            var ap = new AssignedProgramsTableAdapter();
            ap.CloseActive(athleteId);
            ap.AssignProgram(athleteId, Convert.ToInt32(cmbProgram.SelectedValue));
            LoadAthlete();
        }

        private void btnSaveWorkouts_Click(object sender, EventArgs e)
        {
            dgvWorkouts.EndEdit();
            new WorkoutsTableAdapter().Update(wTable);
            ShowStats();
        }

        private void dgvAthletes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAthletes.CurrentRow == null)
                return;

            if (!dgvAthletes.Columns.Contains("colAId"))
                return;

            object value = dgvAthletes.CurrentRow.Cells["colAId"].Value;

            if (value == null || value == DBNull.Value)
                return;

            athleteId = Convert.ToInt32(value);

            LoadAthlete();
        }

        private void dgvWorkouts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorkouts.CurrentRow == null)
                return;

            if (dgvWorkouts.CurrentRow.Cells["colWId"].Value == null)
                return;

            workoutId = Convert.ToInt32(
                dgvWorkouts.CurrentRow.Cells["colWId"].Value);

            sTable = new SetsTableAdapter().GetDataByWorkout(workoutId);

            sTable.WorkoutIdColumn.DefaultValue = workoutId;

            dgvSets.DataSource = sTable;
        }

        private void btnSaveSets_Click(object sender, EventArgs e)
        {
            dgvSets.EndEdit();
            new SetsTableAdapter().Update(sTable);
            ShowStats();
        }

        private void ShowStats()
        {
            lblCntWorkouts.Text =
                Convert.ToString(
                    new WorkoutsTableAdapter()
                        .GetWorkoutCount(athleteId));

            lblCntVolume.Text =
                Convert.ToString(
                    new SetsTableAdapter()
                        .GetTotalVolume(athleteId));

            lblCntExercises.Text =
                Convert.ToString(
                    new SetsTableAdapter()
                        .GetExerciseCount(athleteId));

            dgvProgress.DataSource =
                new ExerciseProgressTableAdapter()
                    .GetProgress(athleteId);
        }

        private void LoadAthlete()
        {
            ShowStats();

            dgvSets.DataSource = null;

            var ap = new AssignedProgramsTableAdapter()
                .GetCurrent(athleteId);

            lblCurrent.Text = ap.Count == 0
                ? "Программа не назначена"
                : "Текущая: " + ap[0].ProgramName;

            wTable = new WorkoutsTableAdapter()
                .GetDataByUser(athleteId);

            dgvWorkouts.DataSource = wTable;
        }
    }
}
