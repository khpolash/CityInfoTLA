using System.Collections.Generic;
using System.Windows.Forms;
using CityInformationApp.BLL;
using CityInformationApp.Model;

namespace CityInformationApp.UI
{
    public partial class CityInfoUi : Form
    {
        public CityInfoUi()
        {
            InitializeComponent();
        }

        private Manager manager = new Manager();
        private City aCity;

        private bool isUpdateMode = false;
        int cityId;

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            aCity = new City();
            aCity.CityName = cityNameTextBox.Text;
            aCity.Division = divisionComboBox.Text;
            aCity.Distric = districtComboBox.Text;
            aCity.Upazila = upazilaTextBox.Text;
            aCity.PostCode = int.Parse(postCodeTextBox.Text);
            aCity.Country = countryTextBox.Text;

            manager = new Manager();
            if (isUpdateMode)
            {
                MessageBox.Show(manager.Update(aCity, cityId));
                ShowAllInListView();
                isUpdateMode = false;
                saveButton.Text = "Save";
                cityId = 0;
                cityNameTextBox.Clear();
                upazilaTextBox.Clear();
                postCodeTextBox.Clear();
            }
            else
            {
                MessageBox.Show(manager.Save(aCity));
                ShowAllInListView();
            }
            
        }

        private void CityInfoUi_Load(object sender, System.EventArgs e)
        {
            ShowAllInListView();
        }
        public void ShowAllInListView()
        {
            List<City> cityList = manager.Show();
            LoadDataInListView(cityList);
        }

        public void LoadDataInListView(List<City> cityList)
        {
            int i = 0;
            showResultListView.Items.Clear();
            foreach (var city in cityList)
            {
                i++;
                ListViewItem item = new ListViewItem(city.Id.ToString());
                item.SubItems.Add(i.ToString());
                item.SubItems.Add(city.CityName);
                item.SubItems.Add(city.Division);
                item.SubItems.Add(city.Distric);
                item.SubItems.Add(city.Upazila);
                item.SubItems.Add(city.PostCode.ToString());
                item.SubItems.Add(city.Country);
                showResultListView.Items.Add(item);
            }
        }


        private void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (searchByDivisionRadioButton.Checked)
            {
                string division = "Division";
                string search = searchTextBox.Text;
                List<City> cityList = manager.Search(division, search);
                LoadDataInListView(cityList);
            }
            else if (searchByDistrictRadioButton.Checked)
            {
                string district = "District";
                string search = searchTextBox.Text;
                List<City> cityList = manager.Search(district, search);
                LoadDataInListView(cityList);
            }
            else if (searchByPostCodeRadioButton.Checked)
            {
                string postCode = "PostCode";
                string search = searchTextBox.Text;
                List<City> cityList = manager.Search(postCode, search);
                LoadDataInListView(cityList);
            }
            else if (searchByCityRadioButton.Checked)
            {
                string cityName = "CityName";
                string search = searchTextBox.Text;
                List<City> cityList = manager.Search(cityName, search);
                LoadDataInListView(cityList);
            }
            else if (searchByUpazilaRadioButton.Checked)
            {
                string upazila = "Upazila";
                string search = searchTextBox.Text;
                List<City> cityList = manager.Search(upazila, search);
                LoadDataInListView(cityList);
            }
            
        }

        private void showResultListView_DoubleClick(object sender, System.EventArgs e)
        {

            ListViewItem item = showResultListView.SelectedItems[0];
            int id = int.Parse(item.Text.ToString());
            City city = manager.GetCityById(id);
            if (city!=null)
            {
                isUpdateMode = true;
                saveButton.Text = "Update";
                cityId = city.Id;
                cityNameTextBox.ReadOnly = true;

                cityNameTextBox.Text = city.CityName;
                divisionComboBox.Text = city.Division;
                districtComboBox.Text = city.Distric;
                upazilaTextBox.Text = city.Upazila;
                postCodeTextBox.Text = city.PostCode.ToString();
                countryTextBox.Text = city.Country;
            }
        }
    }
}
