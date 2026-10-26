namespace WorkoutDiary
{
    partial class FrmLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartLogin = new Material3.WinForms.Controls.MaterialCard();
            this.btnRegister = new Material3.WinForms.Controls.MaterialButton();
            this.btnLogin = new Material3.WinForms.Controls.MaterialButton();
            this.txtPassword = new Material3.WinForms.Controls.MaterialTextField();
            this.txtLogin = new Material3.WinForms.Controls.MaterialTextField();
            this.lblLoginTitle = new Material3.WinForms.Controls.MaterialLabel();
            this.lblLoginSubtitle = new Material3.WinForms.Controls.MaterialLabel();
            this.plnBrand = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.materialLabel3 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel2 = new Material3.WinForms.Controls.MaterialLabel();
            this.lblFeature1 = new Material3.WinForms.Controls.MaterialLabel();
            this.lblDrandDescription = new Material3.WinForms.Controls.MaterialLabel();
            this.lblBrand = new Material3.WinForms.Controls.MaterialLabel();
            this.workoutsTableAdapter1 = new WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.WorkoutsTableAdapter();
            this.usersTableAdapter1 = new WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.TableAdapterManager();
            this.workoutDiaryDBDataSet1 = new WorkoutDiary.WorkoutDiaryDBDataSet();
            this.cartLogin.SuspendLayout();
            this.plnBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cartLogin
            // 
            this.cartLogin.BackColor = System.Drawing.Color.White;
            this.cartLogin.Controls.Add(this.btnRegister);
            this.cartLogin.Controls.Add(this.btnLogin);
            this.cartLogin.Controls.Add(this.txtPassword);
            this.cartLogin.Controls.Add(this.txtLogin);
            this.cartLogin.Controls.Add(this.lblLoginTitle);
            this.cartLogin.Controls.Add(this.lblLoginSubtitle);
            this.cartLogin.CornerRadius = 16;
            this.cartLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cartLogin.Location = new System.Drawing.Point(476, 103);
            this.cartLogin.Margin = new System.Windows.Forms.Padding(4);
            this.cartLogin.Name = "cartLogin";
            this.cartLogin.Padding = new System.Windows.Forms.Padding(19, 21, 19, 21);
            this.cartLogin.Size = new System.Drawing.Size(440, 394);
            this.cartLogin.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnRegister.CornerRadius = 12;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnRegister.Glyph = "arrow_forward";
            this.btnRegister.Location = new System.Drawing.Point(228, 277);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(177, 50);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Создать аккаунт";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(70)))), ((int)(((byte)(165)))));
            this.btnLogin.CornerRadius = 12;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnLogin.Glyph = "check";
            this.btnLogin.Location = new System.Drawing.Point(35, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.LabelText = "Пароль";
            this.txtPassword.Location = new System.Drawing.Point(35, 202);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(370, 71);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.LabelText = "Логин";
            this.txtLogin.Location = new System.Drawing.Point(35, 140);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(370, 71);
            this.txtLogin.TabIndex = 0;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(35, 35);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(370, 38);
            this.lblLoginTitle.TabIndex = 2;
            this.lblLoginTitle.Text = "С возвращением!";
            // 
            // lblLoginSubtitle
            // 
            this.lblLoginSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.lblLoginSubtitle.Location = new System.Drawing.Point(38, 82);
            this.lblLoginSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginSubtitle.Name = "lblLoginSubtitle";
            this.lblLoginSubtitle.Size = new System.Drawing.Size(370, 25);
            this.lblLoginSubtitle.TabIndex = 0;
            this.lblLoginSubtitle.Text = "Войдите, чтобы продолжить тренировки\r\n";
            // 
            // plnBrand
            // 
            this.plnBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.plnBrand.Controls.Add(this.materialLabel3);
            this.plnBrand.Controls.Add(this.materialLabel2);
            this.plnBrand.Controls.Add(this.lblFeature1);
            this.plnBrand.Controls.Add(this.lblDrandDescription);
            this.plnBrand.Controls.Add(this.lblBrand);
            this.plnBrand.ForeColor = System.Drawing.Color.White;
            this.plnBrand.Location = new System.Drawing.Point(0, 0);
            this.plnBrand.Name = "plnBrand";
            this.plnBrand.Size = new System.Drawing.Size(350, 650);
            this.plnBrand.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel3.Location = new System.Drawing.Point(35, 380);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(280, 35);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "✓Персональные программы";
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel2.Location = new System.Drawing.Point(35, 325);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(280, 35);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "✓ Отслеживание прогресса";
            // 
            // lblFeature1
            // 
            this.lblFeature1.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFeature1.Location = new System.Drawing.Point(35, 270);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(280, 35);
            this.lblFeature1.TabIndex = 2;
            this.lblFeature1.Text = "✓ История тренировок ";
            // 
            // lblDrandDescription
            // 
            this.lblDrandDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.lblDrandDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDrandDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(242)))));
            this.lblDrandDescription.Location = new System.Drawing.Point(35, 120);
            this.lblDrandDescription.Name = "lblDrandDescription";
            this.lblDrandDescription.Size = new System.Drawing.Size(280, 75);
            this.lblDrandDescription.TabIndex = 1;
            this.lblDrandDescription.Text = "Твой путь к лучшей форме начинается здесь!";
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrand.Location = new System.Drawing.Point(35, 65);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(591, 81);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "WORKOUT DIARY";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workoutsTableAdapter1
            // 
            this.workoutsTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ExercisesTableAdapter = null;
            this.tableAdapterManager1.MuscleGroupsTableAdapter = null;
            this.tableAdapterManager1.ProgramExercisesTableAdapter = null;
            this.tableAdapterManager1.ProgramsTableAdapter = null;
            this.tableAdapterManager1.SetsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager1.WorkoutsTableAdapter = this.workoutsTableAdapter1;
            // 
            // workoutDiaryDBDataSet1
            // 
            this.workoutDiaryDBDataSet1.DataSetName = "WorkoutDiaryDBDataSet";
            this.workoutDiaryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.plnBrand);
            this.Controls.Add(this.cartLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник тренировок - Вход";

            this.cartLogin.ResumeLayout(false);
            this.plnBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Material3.WinForms.Controls.MaterialCard cartLogin;
        private Material3.WinForms.Controls.MaterialLabel lblLoginSubtitle;
        private Material3.WinForms.Controls.MaterialRoundedPanel plnBrand;
        private Material3.WinForms.Controls.MaterialLabel lblBrand;
        private Material3.WinForms.Controls.MaterialLabel lblDrandDescription;
        private Material3.WinForms.Controls.MaterialLabel materialLabel3;
        private Material3.WinForms.Controls.MaterialLabel materialLabel2;
        private Material3.WinForms.Controls.MaterialLabel lblFeature1;
        private Material3.WinForms.Controls.MaterialTextField txtLogin;
        private Material3.WinForms.Controls.MaterialLabel lblLoginTitle;
        private WorkoutDiaryDBDataSetTableAdapters.WorkoutsTableAdapter workoutsTableAdapter1;
        private WorkoutDiaryDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private WorkoutDiaryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private WorkoutDiaryDBDataSet workoutDiaryDBDataSet1;
        private Material3.WinForms.Controls.MaterialTextField txtPassword;
        private Material3.WinForms.Controls.MaterialButton btnLogin;
        private Material3.WinForms.Controls.MaterialButton btnRegister;
    }
}

