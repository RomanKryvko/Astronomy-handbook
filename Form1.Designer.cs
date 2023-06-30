namespace Довідник_астронома
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabFindStar = new TabControl();
            tabPage1 = new TabPage();
            lblStarsCount = new Label();
            groupBox2 = new GroupBox();
            lblEmptyStarError = new Label();
            txtFindStar = new TextBox();
            btnFindStar = new Button();
            groupBox1 = new GroupBox();
            numBrightStars = new NumericUpDown();
            btnShowBrightStars = new Button();
            lblGrid = new Label();
            dataGridViewStars = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            starBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            lblVisibleObjectsCount = new Label();
            label3 = new Label();
            dataGridViewVisibleStars = new DataGridView();
            btnFindVisibleConstellations = new Button();
            btnFindVisibleStars = new Button();
            groupObservationPlace = new GroupBox();
            txtLongitude = new MaskedTextBox();
            txtLatitude = new MaskedTextBox();
            panel2 = new Panel();
            rbEastLongitude = new RadioButton();
            rbWestLongitude = new RadioButton();
            panel1 = new Panel();
            rbNorthLatitude = new RadioButton();
            rbSouthLatitude = new RadioButton();
            lblLongitude = new Label();
            lblLatitude = new Label();
            groupObservationDate = new GroupBox();
            dtObservationDate = new DateTimePicker();
            tabPage3 = new TabPage();
            lblObservationStarEmptyError = new Label();
            datagridObservationHours = new DataGridView();
            colStarName = new DataGridViewTextBoxColumn();
            colObservationDate = new DataGridViewTextBoxColumn();
            colStarRise = new DataGridViewTextBoxColumn();
            colStarSet = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            txtLongitudeStarObservation = new MaskedTextBox();
            txtLatitudeStarObservation = new MaskedTextBox();
            panel3 = new Panel();
            rbEastLongitudeStarObservation = new RadioButton();
            rbWestLongitudeStarObservation = new RadioButton();
            panel4 = new Panel();
            rbNorthLatitudeStarObservation = new RadioButton();
            rbSouthLatitudeStarObservation = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            btnFindHours = new Button();
            txtNameStarObservation = new TextBox();
            lblObserveStar = new Label();
            lblStarNotVisible = new Label();
            tabFindStar.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBrightStars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisibleStars).BeginInit();
            groupObservationPlace.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupObservationDate.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridObservationHours).BeginInit();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabFindStar
            // 
            tabFindStar.Controls.Add(tabPage1);
            tabFindStar.Controls.Add(tabPage2);
            tabFindStar.Controls.Add(tabPage3);
            resources.ApplyResources(tabFindStar, "tabFindStar");
            tabFindStar.Multiline = true;
            tabFindStar.Name = "tabFindStar";
            tabFindStar.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblStarsCount);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(lblGrid);
            tabPage1.Controls.Add(dataGridViewStars);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblStarsCount
            // 
            resources.ApplyResources(lblStarsCount, "lblStarsCount");
            lblStarsCount.Name = "lblStarsCount";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEmptyStarError);
            groupBox2.Controls.Add(txtFindStar);
            groupBox2.Controls.Add(btnFindStar);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // lblEmptyStarError
            // 
            resources.ApplyResources(lblEmptyStarError, "lblEmptyStarError");
            lblEmptyStarError.ForeColor = Color.Red;
            lblEmptyStarError.Name = "lblEmptyStarError";
            // 
            // txtFindStar
            // 
            resources.ApplyResources(txtFindStar, "txtFindStar");
            txtFindStar.Name = "txtFindStar";
            txtFindStar.TextChanged += txtFindStar_TextChanged;
            // 
            // btnFindStar
            // 
            resources.ApplyResources(btnFindStar, "btnFindStar");
            btnFindStar.Cursor = Cursors.Hand;
            btnFindStar.Name = "btnFindStar";
            btnFindStar.UseVisualStyleBackColor = true;
            btnFindStar.Click += btnFindStar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numBrightStars);
            groupBox1.Controls.Add(btnShowBrightStars);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // numBrightStars
            // 
            resources.ApplyResources(numBrightStars, "numBrightStars");
            numBrightStars.Name = "numBrightStars";
            // 
            // btnShowBrightStars
            // 
            resources.ApplyResources(btnShowBrightStars, "btnShowBrightStars");
            btnShowBrightStars.Cursor = Cursors.Hand;
            btnShowBrightStars.Name = "btnShowBrightStars";
            btnShowBrightStars.UseVisualStyleBackColor = true;
            btnShowBrightStars.Click += btnShowBrightStars_Click;
            // 
            // lblGrid
            // 
            resources.ApplyResources(lblGrid, "lblGrid");
            lblGrid.Name = "lblGrid";
            // 
            // dataGridViewStars
            // 
            dataGridViewStars.AllowUserToAddRows = false;
            dataGridViewStars.AllowUserToDeleteRows = false;
            dataGridViewStars.AllowUserToResizeRows = false;
            dataGridViewStars.AutoGenerateColumns = false;
            dataGridViewStars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewStars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStars.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewStars.DataSource = starBindingSource;
            resources.ApplyResources(dataGridViewStars, "dataGridViewStars");
            dataGridViewStars.Name = "dataGridViewStars";
            dataGridViewStars.ReadOnly = true;
            dataGridViewStars.RowTemplate.Height = 29;
            dataGridViewStars.Paint += dataGridViewStars_Paint;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Constellation";
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ApparentMagnitude";
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Distance";
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "RightAscension";
            resources.ApplyResources(dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "DeclinationFormatted";
            resources.ApplyResources(dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Star);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblVisibleObjectsCount);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridViewVisibleStars);
            tabPage2.Controls.Add(btnFindVisibleConstellations);
            tabPage2.Controls.Add(btnFindVisibleStars);
            tabPage2.Controls.Add(groupObservationPlace);
            tabPage2.Controls.Add(groupObservationDate);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVisibleObjectsCount
            // 
            resources.ApplyResources(lblVisibleObjectsCount, "lblVisibleObjectsCount");
            lblVisibleObjectsCount.Name = "lblVisibleObjectsCount";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // dataGridViewVisibleStars
            // 
            dataGridViewVisibleStars.AllowUserToAddRows = false;
            dataGridViewVisibleStars.AllowUserToDeleteRows = false;
            dataGridViewVisibleStars.AllowUserToResizeRows = false;
            dataGridViewVisibleStars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVisibleStars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewVisibleStars, "dataGridViewVisibleStars");
            dataGridViewVisibleStars.Name = "dataGridViewVisibleStars";
            dataGridViewVisibleStars.ReadOnly = true;
            dataGridViewVisibleStars.RowHeadersVisible = false;
            dataGridViewVisibleStars.RowTemplate.Height = 29;
            dataGridViewVisibleStars.Paint += dataGridViewVisibleStars_Paint;
            // 
            // btnFindVisibleConstellations
            // 
            resources.ApplyResources(btnFindVisibleConstellations, "btnFindVisibleConstellations");
            btnFindVisibleConstellations.Name = "btnFindVisibleConstellations";
            btnFindVisibleConstellations.UseVisualStyleBackColor = true;
            btnFindVisibleConstellations.Click += btnFindVisibleConstellations_Click;
            // 
            // btnFindVisibleStars
            // 
            resources.ApplyResources(btnFindVisibleStars, "btnFindVisibleStars");
            btnFindVisibleStars.Name = "btnFindVisibleStars";
            btnFindVisibleStars.UseVisualStyleBackColor = true;
            btnFindVisibleStars.Click += btnFindVisibleStars_Click;
            // 
            // groupObservationPlace
            // 
            groupObservationPlace.Controls.Add(txtLongitude);
            groupObservationPlace.Controls.Add(txtLatitude);
            groupObservationPlace.Controls.Add(panel2);
            groupObservationPlace.Controls.Add(panel1);
            groupObservationPlace.Controls.Add(lblLongitude);
            groupObservationPlace.Controls.Add(lblLatitude);
            resources.ApplyResources(groupObservationPlace, "groupObservationPlace");
            groupObservationPlace.Name = "groupObservationPlace";
            groupObservationPlace.TabStop = false;
            // 
            // txtLongitude
            // 
            resources.ApplyResources(txtLongitude, "txtLongitude");
            txtLongitude.Name = "txtLongitude";
            // 
            // txtLatitude
            // 
            resources.ApplyResources(txtLatitude, "txtLatitude");
            txtLatitude.Name = "txtLatitude";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbEastLongitude);
            panel2.Controls.Add(rbWestLongitude);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // rbEastLongitude
            // 
            resources.ApplyResources(rbEastLongitude, "rbEastLongitude");
            rbEastLongitude.Checked = true;
            rbEastLongitude.Name = "rbEastLongitude";
            rbEastLongitude.TabStop = true;
            rbEastLongitude.UseVisualStyleBackColor = true;
            // 
            // rbWestLongitude
            // 
            resources.ApplyResources(rbWestLongitude, "rbWestLongitude");
            rbWestLongitude.Name = "rbWestLongitude";
            rbWestLongitude.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbNorthLatitude);
            panel1.Controls.Add(rbSouthLatitude);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // rbNorthLatitude
            // 
            resources.ApplyResources(rbNorthLatitude, "rbNorthLatitude");
            rbNorthLatitude.Checked = true;
            rbNorthLatitude.Name = "rbNorthLatitude";
            rbNorthLatitude.TabStop = true;
            rbNorthLatitude.UseVisualStyleBackColor = true;
            // 
            // rbSouthLatitude
            // 
            resources.ApplyResources(rbSouthLatitude, "rbSouthLatitude");
            rbSouthLatitude.Name = "rbSouthLatitude";
            rbSouthLatitude.UseVisualStyleBackColor = true;
            // 
            // lblLongitude
            // 
            resources.ApplyResources(lblLongitude, "lblLongitude");
            lblLongitude.Name = "lblLongitude";
            // 
            // lblLatitude
            // 
            resources.ApplyResources(lblLatitude, "lblLatitude");
            lblLatitude.Name = "lblLatitude";
            // 
            // groupObservationDate
            // 
            groupObservationDate.Controls.Add(dtObservationDate);
            resources.ApplyResources(groupObservationDate, "groupObservationDate");
            groupObservationDate.Name = "groupObservationDate";
            groupObservationDate.TabStop = false;
            // 
            // dtObservationDate
            // 
            resources.ApplyResources(dtObservationDate, "dtObservationDate");
            dtObservationDate.Format = DateTimePickerFormat.Custom;
            dtObservationDate.Name = "dtObservationDate";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblStarNotVisible);
            tabPage3.Controls.Add(lblObservationStarEmptyError);
            tabPage3.Controls.Add(datagridObservationHours);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(btnFindHours);
            tabPage3.Controls.Add(txtNameStarObservation);
            tabPage3.Controls.Add(lblObserveStar);
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblObservationStarEmptyError
            // 
            resources.ApplyResources(lblObservationStarEmptyError, "lblObservationStarEmptyError");
            lblObservationStarEmptyError.ForeColor = Color.Red;
            lblObservationStarEmptyError.Name = "lblObservationStarEmptyError";
            // 
            // datagridObservationHours
            // 
            datagridObservationHours.AllowUserToAddRows = false;
            datagridObservationHours.AllowUserToDeleteRows = false;
            datagridObservationHours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridObservationHours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridObservationHours.Columns.AddRange(new DataGridViewColumn[] { colStarName, colObservationDate, colStarRise, colStarSet });
            resources.ApplyResources(datagridObservationHours, "datagridObservationHours");
            datagridObservationHours.Name = "datagridObservationHours";
            datagridObservationHours.ReadOnly = true;
            datagridObservationHours.RowTemplate.Height = 29;
            datagridObservationHours.Paint += datagridObservationHours_Paint;
            // 
            // colStarName
            // 
            resources.ApplyResources(colStarName, "colStarName");
            colStarName.Name = "colStarName";
            colStarName.ReadOnly = true;
            // 
            // colObservationDate
            // 
            resources.ApplyResources(colObservationDate, "colObservationDate");
            colObservationDate.Name = "colObservationDate";
            colObservationDate.ReadOnly = true;
            // 
            // colStarRise
            // 
            resources.ApplyResources(colStarRise, "colStarRise");
            colStarRise.Name = "colStarRise";
            colStarRise.ReadOnly = true;
            // 
            // colStarSet
            // 
            resources.ApplyResources(colStarSet, "colStarSet");
            colStarSet.Name = "colStarSet";
            colStarSet.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtLongitudeStarObservation);
            groupBox3.Controls.Add(txtLatitudeStarObservation);
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // txtLongitudeStarObservation
            // 
            resources.ApplyResources(txtLongitudeStarObservation, "txtLongitudeStarObservation");
            txtLongitudeStarObservation.Name = "txtLongitudeStarObservation";
            // 
            // txtLatitudeStarObservation
            // 
            resources.ApplyResources(txtLatitudeStarObservation, "txtLatitudeStarObservation");
            txtLatitudeStarObservation.Name = "txtLatitudeStarObservation";
            // 
            // panel3
            // 
            panel3.Controls.Add(rbEastLongitudeStarObservation);
            panel3.Controls.Add(rbWestLongitudeStarObservation);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // rbEastLongitudeStarObservation
            // 
            resources.ApplyResources(rbEastLongitudeStarObservation, "rbEastLongitudeStarObservation");
            rbEastLongitudeStarObservation.Checked = true;
            rbEastLongitudeStarObservation.Name = "rbEastLongitudeStarObservation";
            rbEastLongitudeStarObservation.TabStop = true;
            rbEastLongitudeStarObservation.UseVisualStyleBackColor = true;
            // 
            // rbWestLongitudeStarObservation
            // 
            resources.ApplyResources(rbWestLongitudeStarObservation, "rbWestLongitudeStarObservation");
            rbWestLongitudeStarObservation.Name = "rbWestLongitudeStarObservation";
            rbWestLongitudeStarObservation.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(rbNorthLatitudeStarObservation);
            panel4.Controls.Add(rbSouthLatitudeStarObservation);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // rbNorthLatitudeStarObservation
            // 
            resources.ApplyResources(rbNorthLatitudeStarObservation, "rbNorthLatitudeStarObservation");
            rbNorthLatitudeStarObservation.Checked = true;
            rbNorthLatitudeStarObservation.Name = "rbNorthLatitudeStarObservation";
            rbNorthLatitudeStarObservation.TabStop = true;
            rbNorthLatitudeStarObservation.UseVisualStyleBackColor = true;
            // 
            // rbSouthLatitudeStarObservation
            // 
            resources.ApplyResources(rbSouthLatitudeStarObservation, "rbSouthLatitudeStarObservation");
            rbSouthLatitudeStarObservation.Name = "rbSouthLatitudeStarObservation";
            rbSouthLatitudeStarObservation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // btnFindHours
            // 
            resources.ApplyResources(btnFindHours, "btnFindHours");
            btnFindHours.Name = "btnFindHours";
            btnFindHours.UseVisualStyleBackColor = true;
            btnFindHours.Click += btnFindHours_Click;
            // 
            // txtNameStarObservation
            // 
            resources.ApplyResources(txtNameStarObservation, "txtNameStarObservation");
            txtNameStarObservation.Name = "txtNameStarObservation";
            txtNameStarObservation.TextChanged += txtNameStarObservation_TextChanged;
            // 
            // lblObserveStar
            // 
            resources.ApplyResources(lblObserveStar, "lblObserveStar");
            lblObserveStar.Name = "lblObserveStar";
            // 
            // lblStarNotVisible
            // 
            resources.ApplyResources(lblStarNotVisible, "lblStarNotVisible");
            lblStarNotVisible.ForeColor = Color.Red;
            lblStarNotVisible.Name = "lblStarNotVisible";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabFindStar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            Name = "Form1";
            tabFindStar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBrightStars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStars).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisibleStars).EndInit();
            groupObservationPlace.ResumeLayout(false);
            groupObservationPlace.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupObservationDate.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridObservationHours).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabFindStar;
        private TabPage tabPage1;
        private TextBox txtFindStar;
        private Button btnFindStar;
        private TabPage tabPage2;
        private Button btnShowBrightStars;
        private DataGridView dataGridViewStars;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn constellationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apparentMagnitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightAscensionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn declinationDataGridViewTextBoxColumn;
        private Label lblGrid;
        private DateTimePicker dtObservationDate;
        private GroupBox groupObservationDate;
        private GroupBox groupObservationPlace;
        private Label lblLongitude;
        private Label lblLatitude;
        private RadioButton rbWestLongitude;
        private RadioButton rbEastLongitude;
        private RadioButton rbSouthLatitude;
        private RadioButton rbNorthLatitude;
        private Panel panel1;
        private Panel panel2;
        private Button btnFindVisibleStars;
        private Button btnFindVisibleConstellations;
        private DataGridView dataGridViewVisibleStars;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn constellationDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn apparentMagnitudeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rightAscensionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn declinationDataGridViewTextBoxColumn1;
        private TabPage tabPage3;
        private Label lblObserveStar;
        private Button btnFindHours;
        private TextBox txtNameStarObservation;
        private MaskedTextBox txtLatitude;
        private MaskedTextBox txtLongitude;
        private GroupBox groupBox1;
        private NumericUpDown numBrightStars;
        private BindingSource starBindingSource;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MaskedTextBox txtLongitudeStarObservation;
        private MaskedTextBox txtLatitudeStarObservation;
        private Panel panel3;
        private RadioButton rbEastLongitudeStarObservation;
        private RadioButton rbWestLongitudeStarObservation;
        private Panel panel4;
        private RadioButton rbNorthLatitudeStarObservation;
        private RadioButton rbSouthLatitudeStarObservation;
        private Label label1;
        private Label label2;
        private DataGridView datagridObservationHours;
        private DataGridViewTextBoxColumn colStarName;
        private DataGridViewTextBoxColumn colObservationDate;
        private DataGridViewTextBoxColumn colStarRise;
        private DataGridViewTextBoxColumn colStarSet;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblStarsCount;
        private Label lblVisibleObjectsCount;
        private Label label3;
        private Label lblEmptyStarError;
        private Label lblObservationStarEmptyError;
        private Label lblStarNotVisible;
    }
}

