namespace WorkoutDiary
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBrand = new Material3.WinForms.Controls.MaterialRoundedPanel();
            this.materialLabel3 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel2 = new Material3.WinForms.Controls.MaterialLabel();
            this.lblFeature1 = new Material3.WinForms.Controls.MaterialLabel();
            this.lblDrandDescription = new Material3.WinForms.Controls.MaterialLabel();
            this.lblBrand = new Material3.WinForms.Controls.MaterialLabel();
            this.cardRegister = new Material3.WinForms.Controls.MaterialCard();
            this.lblRegisterMessage = new Material3.WinForms.Controls.MaterialLabel();
            this.btnBackToLogin = new Material3.WinForms.Controls.MaterialButton();
            this.btnRegister = new Material3.WinForms.Controls.MaterialButton();
            this.txtPassword = new Material3.WinForms.Controls.MaterialTextField();
            this.txtLogin = new Material3.WinForms.Controls.MaterialTextField();
            this.txtConfirmPassword = new Material3.WinForms.Controls.MaterialTextField();
            this.txtFullName = new Material3.WinForms.Controls.MaterialTextField();
            this.materialLabel4 = new Material3.WinForms.Controls.MaterialLabel();
            this.materialLabel1 = new Material3.WinForms.Controls.MaterialLabel();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workoutDiaryDBDataSet = new WorkoutDiary.WorkoutDiaryDBDataSet();
            this.usersTableAdapter = new WorkoutDiary.WorkoutDiaryDBDataSetTableAdapters.UsersTableAdapter();
            this.pnlBrand.SuspendLayout();
            this.cardRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.pnlBrand.Controls.Add(this.materialLabel3);
            this.pnlBrand.Controls.Add(this.materialLabel2);
            this.pnlBrand.Controls.Add(this.lblFeature1);
            this.pnlBrand.Controls.Add(this.lblDrandDescription);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.ForeColor = System.Drawing.Color.White;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(350, 700);
            this.pnlBrand.TabIndex = 1;
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
            this.materialLabel2.Text = "✓ История и результаты";
            // 
            // lblFeature1
            // 
            this.lblFeature1.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFeature1.Location = new System.Drawing.Point(35, 270);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(280, 35);
            this.lblFeature1.TabIndex = 2;
            this.lblFeature1.Text = "✓ Личный дневник тренировок";
            // 
            // lblDrandDescription
            // 
            this.lblDrandDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(35)))), ((int)(((byte)(83)))));
            this.lblDrandDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDrandDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(242)))));
            this.lblDrandDescription.Location = new System.Drawing.Point(35, 125);
            this.lblDrandDescription.Name = "lblDrandDescription";
            this.lblDrandDescription.Size = new System.Drawing.Size(280, 75);
            this.lblDrandDescription.TabIndex = 1;
            this.lblDrandDescription.Text = "Создай аккаунт и начни отслеживать свой прогресс";
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
            // cardRegister
            // 
            this.cardRegister.BackColor = System.Drawing.Color.White;
            this.cardRegister.Controls.Add(this.lblRegisterMessage);
            this.cardRegister.Controls.Add(this.btnBackToLogin);
            this.cardRegister.Controls.Add(this.btnRegister);
            this.cardRegister.Controls.Add(this.txtPassword);
            this.cardRegister.Controls.Add(this.txtLogin);
            this.cardRegister.Controls.Add(this.txtConfirmPassword);
            this.cardRegister.Controls.Add(this.txtFullName);
            this.cardRegister.Controls.Add(this.materialLabel4);
            this.cardRegister.Controls.Add(this.materialLabel1);
            this.cardRegister.CornerRadius = 12;
            this.cardRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cardRegister.Location = new System.Drawing.Point(448, 65);
            this.cardRegister.Name = "cardRegister";
            this.cardRegister.Padding = new System.Windows.Forms.Padding(16);
            this.cardRegister.Size = new System.Drawing.Size(490, 515);
            this.cardRegister.TabIndex = 2;
            // 
            // lblRegisterMessage
            // 
            this.lblRegisterMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegisterMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblRegisterMessage.Location = new System.Drawing.Point(30, 454);
            this.lblRegisterMessage.Name = "lblRegisterMessage";
            this.lblRegisterMessage.Size = new System.Drawing.Size(420, 45);
            this.lblRegisterMessage.TabIndex = 11;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin.CornerRadius = 12;
            this.btnBackToLogin.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnBackToLogin.Location = new System.Drawing.Point(257, 395);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(193, 48);
            this.btnBackToLogin.TabIndex = 10;
            this.btnBackToLogin.Text = "У меня уже есть аккаунт...\r\n\r\n";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.CornerRadius = 12;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(225)))), ((int)(((byte)(236)))));
            this.btnRegister.Location = new System.Drawing.Point(30, 395);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(203, 48);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Variant = Material3.WinForms.Controls.MaterialButtonVariant.Tonal;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.LabelText = "Пароль";
            this.txtPassword.Location = new System.Drawing.Point(30, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(420, 71);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.LabelText = "Логин";
            this.txtLogin.Location = new System.Drawing.Point(30, 175);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(420, 71);
            this.txtLogin.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfirmPassword.LabelText = "Подтверждение пароля";
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 315);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(420, 71);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.Click += new System.EventHandler(this.txtConfirmPassword_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFullName.LabelText = "Полное имя ";
            this.txtFullName.Location = new System.Drawing.Point(30, 105);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(420, 71);
            this.txtFullName.TabIndex = 2;
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(101)))), ((int)(((byte)(121)))));
            this.materialLabel4.Location = new System.Drawing.Point(33, 65);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(420, 25);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Заполни данные для регистрации ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel1.Location = new System.Drawing.Point(30, 22);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(420, 38);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Создать аккаунт";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.workoutDiaryDBDataSet;
            // 
            // workoutDiaryDBDataSet
            // 
            this.workoutDiaryDBDataSet.DataSetName = "WorkoutDiaryDBDataSet";
            this.workoutDiaryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.cardRegister);
            this.Controls.Add(this.pnlBrand);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник тренировок - Регистрация";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.pnlBrand.ResumeLayout(false);
            this.cardRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutDiaryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Material3.WinForms.Controls.MaterialRoundedPanel pnlBrand;
        private Material3.WinForms.Controls.MaterialLabel materialLabel3;
        private Material3.WinForms.Controls.MaterialLabel materialLabel2;
        private Material3.WinForms.Controls.MaterialLabel lblFeature1;
        private Material3.WinForms.Controls.MaterialLabel lblDrandDescription;
        private Material3.WinForms.Controls.MaterialLabel lblBrand;
        private Material3.WinForms.Controls.MaterialCard cardRegister;
        private Material3.WinForms.Controls.MaterialLabel materialLabel1;
        private Material3.WinForms.Controls.MaterialTextField txtFullName;
        private Material3.WinForms.Controls.MaterialLabel materialLabel4;
        private Material3.WinForms.Controls.MaterialButton btnRegister;
        private Material3.WinForms.Controls.MaterialTextField txtPassword;
        private Material3.WinForms.Controls.MaterialTextField txtLogin;
        private Material3.WinForms.Controls.MaterialTextField txtConfirmPassword;
        private Material3.WinForms.Controls.MaterialButton btnBackToLogin;
        private Material3.WinForms.Controls.MaterialLabel lblRegisterMessage;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WorkoutDiaryDBDataSet workoutDiaryDBDataSet;
        private WorkoutDiaryDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}