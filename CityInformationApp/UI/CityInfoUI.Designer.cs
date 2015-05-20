namespace CityInformationApp.UI
{
    partial class CityInfoUi
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByDivisionRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByCityRadioButton = new System.Windows.Forms.RadioButton();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upazilaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.divisionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showResultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchByDistrictRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByPostCodeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchByUpazilaRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(27, 190);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(214, 22);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchByDivisionRadioButton
            // 
            this.searchByDivisionRadioButton.AutoSize = true;
            this.searchByDivisionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDivisionRadioButton.Location = new System.Drawing.Point(59, 54);
            this.searchByDivisionRadioButton.Name = "searchByDivisionRadioButton";
            this.searchByDivisionRadioButton.Size = new System.Drawing.Size(68, 19);
            this.searchByDivisionRadioButton.TabIndex = 3;
            this.searchByDivisionRadioButton.TabStop = true;
            this.searchByDivisionRadioButton.Text = "Division";
            this.searchByDivisionRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByCityRadioButton
            // 
            this.searchByCityRadioButton.AutoSize = true;
            this.searchByCityRadioButton.Checked = true;
            this.searchByCityRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCityRadioButton.Location = new System.Drawing.Point(59, 27);
            this.searchByCityRadioButton.Name = "searchByCityRadioButton";
            this.searchByCityRadioButton.Size = new System.Drawing.Size(81, 19);
            this.searchByCityRadioButton.TabIndex = 2;
            this.searchByCityRadioButton.TabStop = true;
            this.searchByCityRadioButton.Text = "City Name";
            this.searchByCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            this.countryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryTextBox.Location = new System.Drawing.Point(105, 159);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(271, 22);
            this.countryTextBox.TabIndex = 6;
            this.countryTextBox.Text = "Bangladesh";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityNameTextBox.Location = new System.Drawing.Point(105, 20);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(271, 22);
            this.cityNameTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(301, 190);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upazilaTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.postCodeTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.divisionComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.districtComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.cityNameTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(112, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Information";
            // 
            // upazilaTextBox
            // 
            this.upazilaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upazilaTextBox.Location = new System.Drawing.Point(105, 105);
            this.upazilaTextBox.Name = "upazilaTextBox";
            this.upazilaTextBox.Size = new System.Drawing.Size(271, 22);
            this.upazilaTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Upazila";
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postCodeTextBox.Location = new System.Drawing.Point(105, 132);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(271, 22);
            this.postCodeTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Post Code";
            // 
            // divisionComboBox
            // 
            this.divisionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.divisionComboBox.FormattingEnabled = true;
            this.divisionComboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet",
            "Rangpur",
            "Rajshahi",
            "Khulna",
            "Barisal"});
            this.divisionComboBox.Location = new System.Drawing.Point(105, 47);
            this.divisionComboBox.Name = "divisionComboBox";
            this.divisionComboBox.Size = new System.Drawing.Size(271, 24);
            this.divisionComboBox.TabIndex = 11;
            this.divisionComboBox.Text = "Select Division";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Division";
            // 
            // districtComboBox
            // 
            this.districtComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Items.AddRange(new object[] {
            "Bagerhat",
            "Bandarban",
            "Barguna",
            "Barisal",
            "Bhola",
            "Bogra",
            "Brahmanbaria ",
            "Chandpur",
            "Chittagong",
            "Chuadanga",
            "Comilla",
            "Cox\'s Bazar ",
            "Chapainababganj",
            "Dhaka",
            "Dinajpur ",
            "Faridpur",
            "Feni ",
            "Gaibandha",
            "Gazipur",
            "Gopalganj ",
            "Habiganj ",
            "Jaipurhat",
            "Jamalpur",
            "Jessore",
            "Jhalakati",
            "Jhenaidah ",
            "Khagrachari",
            "Khulna",
            "Kishoreganj",
            "Kurigram",
            "Kushtia ",
            "Lakshmipur",
            "Lalmonirhat ",
            "Madaripu",
            "Magura",
            "Manikganj",
            "Meherpur",
            "Moulvibazar",
            "Munshiganj",
            "Mymensingh",
            "Naogaon",
            "Narail",
            "Narayanganj",
            "Narsingdi",
            "Natore",
            "Netrokona",
            "Nilphamari",
            "Noakhali ",
            "Pabna",
            "Panchagarh",
            "Patuakhali",
            "Pirojpur",
            "Rajbari",
            "Rajshahi",
            "Rangamati",
            "Rangpur ",
            "Satkhira",
            "Shariatpur",
            "Sherpur",
            "Sirajganj",
            "Sunamganj",
            "Sylhet ",
            "Tangail",
            "Thakurgaon"});
            this.districtComboBox.Location = new System.Drawing.Point(105, 76);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(271, 24);
            this.districtComboBox.TabIndex = 9;
            this.districtComboBox.Text = "Select District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "District";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showResultListView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Data";
            // 
            // showResultListView
            // 
            this.showResultListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.showResultListView.FullRowSelect = true;
            this.showResultListView.GridLines = true;
            this.showResultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.showResultListView.Location = new System.Drawing.Point(6, 17);
            this.showResultListView.Name = "showResultListView";
            this.showResultListView.Size = new System.Drawing.Size(755, 236);
            this.showResultListView.TabIndex = 6;
            this.showResultListView.UseCompatibleStateImageBehavior = false;
            this.showResultListView.View = System.Windows.Forms.View.Details;
            this.showResultListView.DoubleClick += new System.EventHandler(this.showResultListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serial No.";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "City Name";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Division";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "District";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Upazila";
            this.columnHeader6.Width = 119;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Post Code";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Country";
            this.columnHeader8.Width = 104;
            // 
            // searchByDistrictRadioButton
            // 
            this.searchByDistrictRadioButton.AutoSize = true;
            this.searchByDistrictRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDistrictRadioButton.Location = new System.Drawing.Point(59, 81);
            this.searchByDistrictRadioButton.Name = "searchByDistrictRadioButton";
            this.searchByDistrictRadioButton.Size = new System.Drawing.Size(62, 19);
            this.searchByDistrictRadioButton.TabIndex = 8;
            this.searchByDistrictRadioButton.TabStop = true;
            this.searchByDistrictRadioButton.Text = "District";
            this.searchByDistrictRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByPostCodeRadioButton
            // 
            this.searchByPostCodeRadioButton.AutoSize = true;
            this.searchByPostCodeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByPostCodeRadioButton.Location = new System.Drawing.Point(59, 135);
            this.searchByPostCodeRadioButton.Name = "searchByPostCodeRadioButton";
            this.searchByPostCodeRadioButton.Size = new System.Drawing.Size(81, 19);
            this.searchByPostCodeRadioButton.TabIndex = 9;
            this.searchByPostCodeRadioButton.TabStop = true;
            this.searchByPostCodeRadioButton.Text = "Post Code";
            this.searchByPostCodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchByPostCodeRadioButton);
            this.groupBox3.Controls.Add(this.searchByUpazilaRadioButton);
            this.groupBox3.Controls.Add(this.searchTextBox);
            this.groupBox3.Controls.Add(this.searchByDivisionRadioButton);
            this.groupBox3.Controls.Add(this.searchByCityRadioButton);
            this.groupBox3.Controls.Add(this.searchByDistrictRadioButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(531, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 226);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By";
            // 
            // searchByUpazilaRadioButton
            // 
            this.searchByUpazilaRadioButton.AutoSize = true;
            this.searchByUpazilaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByUpazilaRadioButton.Location = new System.Drawing.Point(59, 108);
            this.searchByUpazilaRadioButton.Name = "searchByUpazilaRadioButton";
            this.searchByUpazilaRadioButton.Size = new System.Drawing.Size(67, 19);
            this.searchByUpazilaRadioButton.TabIndex = 10;
            this.searchByUpazilaRadioButton.TabStop = true;
            this.searchByUpazilaRadioButton.Text = "Upazila";
            this.searchByUpazilaRadioButton.UseVisualStyleBackColor = true;
            // 
            // CityInfoUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "CityInfoUi";
            this.ShowIcon = false;
            this.Text = "City Information App";
            this.Load += new System.EventHandler(this.CityInfoUi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton searchByDivisionRadioButton;
        private System.Windows.Forms.RadioButton searchByCityRadioButton;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.ComboBox divisionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView showResultListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.RadioButton searchByDistrictRadioButton;
        private System.Windows.Forms.RadioButton searchByPostCodeRadioButton;
        private System.Windows.Forms.TextBox upazilaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton searchByUpazilaRadioButton;
    }
}

