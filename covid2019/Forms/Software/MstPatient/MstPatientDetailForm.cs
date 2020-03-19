using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid2019.Forms.Software.MstPatient
{
    public partial class MstPatientDetailForm : Form
    {
        public static Database.covid2019dbDataContext db = Modules.ModCovid2019DatabaseModule.GetCovid2019Database();

        public MstPatientForm patientForm;
        public Models.MstPatientModel patientModel;

        public MstPatientDetailForm(MstPatientForm mstPatientForm, Models.MstPatientModel mstPatientModel)
        {
            InitializeComponent();

            patientForm = mstPatientForm;
            patientModel = mstPatientModel;

            GetTablesData();
            SetPatientDetailData();
        }

        public void GetTablesData()
        {
            var sexes = from d in db.MstTables
                        where d.Category == "Sex"
                        select d;

            comboBoxSex.DataSource = sexes.ToList();
            comboBoxSex.ValueMember = "Value";
            comboBoxSex.DisplayMember = "Value";

            var clusters = from d in db.MstTables
                           where d.Category == "Cluster"
                           select d;

            comboBoxCluster.DataSource = clusters.ToList();
            comboBoxCluster.ValueMember = "Value";
            comboBoxCluster.DisplayMember = "Value";

            GetCountryData();
        }

        public void GetCountryData()
        {
            var countries = from d in db.MstCountries.OrderBy(d => d.Country) select d;

            comboBoxCountry.DataSource = countries.ToList();
            comboBoxCountry.ValueMember = "Id";
            comboBoxCountry.DisplayMember = "Country";

            GetProvinceData();
        }

        public void GetProvinceData()
        {
            var provinces = from d in db.MstProvinces.OrderBy(d => d.Province)
                            where d.CountryId == Convert.ToInt32(comboBoxCountry.SelectedValue)
                            select d;

            comboBoxProvince.DataSource = provinces.ToList();
            comboBoxProvince.ValueMember = "Id";
            comboBoxProvince.DisplayMember = "Province";

            GetCityData();
        }

        public void GetCityData()
        {
            var cities = from d in db.MstCities.OrderBy(d => d.City)
                         where d.ProvinceId == Convert.ToInt32(comboBoxProvince.SelectedValue)
                         select d;

            comboBoxCity.DataSource = cities.ToList();
            comboBoxCity.ValueMember = "Id";
            comboBoxCity.DisplayMember = "City";

            GetBarangayData();
        }

        public void GetBarangayData()
        {
            var barangays = from d in db.MstBarangays.OrderBy(d => d.Barangay)
                            where d.CityId == Convert.ToInt32(comboBoxCity.SelectedValue)
                            select d;

            comboBoxBarangay.DataSource = barangays.ToList();
            comboBoxBarangay.ValueMember = "Id";
            comboBoxBarangay.DisplayMember = "Barangay";
        }

        public void SetPatientDetailData()
        {
            textBoxPatientCode.Text = patientModel.PatientCode;
            textBoxPatient.Text = patientModel.Patient;
            dateTimePickerDateEncoded.Value = patientModel.DateEncoded;
            dateTimePickerDateOfArrival.Value = patientModel.DateOfArrival;
            dateTimePickerDateOfQuarantine.Value = patientModel.DateOfQuarantine;
            textBoxAge.Text = patientModel.Age.ToString();
            comboBoxSex.SelectedValue = patientModel.Sex;
            textBoxAddress.Text = patientModel.Address;
            textBoxContactNumber.Text = patientModel.ContactNumber;
            comboBoxCountry.SelectedValue = patientModel.CountryId;
            comboBoxProvince.SelectedValue = patientModel.ProvinceId;
            comboBoxCity.SelectedValue = patientModel.CityId;
            comboBoxBarangay.SelectedValue = patientModel.BarangayId;
            comboBoxCluster.SelectedValue = patientModel.Cluster;
            textBoxPassportNumber.Text = patientModel.PassportNumber;
            textBoxRemarks.Text = patientModel.Remarks;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (patientModel.Id == 0)
                {
                    String patientCode = "0000000001";
                    var lastPatient = from d in db.MstPatients.OrderByDescending(d => d.Id) select d;
                    if (lastPatient.Any())
                    {
                        Int32 newPatientCode = Convert.ToInt32(lastPatient.FirstOrDefault().PatientCode) + 1;
                        patientCode = FillLeadingZeroes(newPatientCode, 10);
                    }

                    Database.MstPatient newPatient = new Database.MstPatient()
                    {
                        PatientCode = patientCode,
                        Patient = textBoxPatient.Text,
                        DateEncoded = dateTimePickerDateEncoded.Value,
                        DateOfArrival = dateTimePickerDateOfArrival.Value,
                        DateOfQuarantine = dateTimePickerDateOfQuarantine.Value,
                        Age = Convert.ToInt32(textBoxAge.Text),
                        Sex = comboBoxSex.SelectedValue.ToString(),
                        Address = textBoxAddress.Text,
                        ContactNumber = textBoxContactNumber.Text,
                        BarangayId = Convert.ToInt32(comboBoxBarangay.SelectedValue),
                        CityId = Convert.ToInt32(comboBoxCity.SelectedValue),
                        ProvinceId = Convert.ToInt32(comboBoxProvince.SelectedValue),
                        CountryId = Convert.ToInt32(comboBoxCountry.SelectedValue),
                        Cluster = comboBoxCluster.SelectedValue.ToString(),
                        PassportNumber = textBoxPassportNumber.Text,
                        Remarks = textBoxRemarks.Text
                    };

                    db.MstPatients.InsertOnSubmit(newPatient);
                    db.SubmitChanges();
                }
                else
                {
                    var currentPatient = from d in db.MstPatients
                                         where d.Id == patientModel.Id
                                         select d;

                    if (currentPatient.Any())
                    {
                        var updateCurrentPatient = currentPatient.FirstOrDefault();
                        updateCurrentPatient.Patient = textBoxPatient.Text;
                        updateCurrentPatient.DateEncoded = dateTimePickerDateEncoded.Value;
                        updateCurrentPatient.DateOfArrival = dateTimePickerDateOfArrival.Value;
                        updateCurrentPatient.DateOfQuarantine = dateTimePickerDateOfQuarantine.Value;
                        updateCurrentPatient.Age = Convert.ToInt32(textBoxAge.Text);
                        updateCurrentPatient.Sex = comboBoxSex.SelectedValue.ToString();
                        updateCurrentPatient.Address = textBoxAddress.Text;
                        updateCurrentPatient.ContactNumber = textBoxContactNumber.Text;
                        updateCurrentPatient.BarangayId = Convert.ToInt32(comboBoxBarangay.SelectedValue);
                        updateCurrentPatient.CityId = Convert.ToInt32(comboBoxCity.SelectedValue);
                        updateCurrentPatient.ProvinceId = Convert.ToInt32(comboBoxProvince.SelectedValue);
                        updateCurrentPatient.CountryId = Convert.ToInt32(comboBoxCountry.SelectedValue);
                        updateCurrentPatient.Cluster = comboBoxCluster.SelectedValue.ToString();
                        updateCurrentPatient.PassportNumber = textBoxPassportNumber.Text;
                        updateCurrentPatient.Remarks = textBoxRemarks.Text;
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public String FillLeadingZeroes(Int32 number, Int32 length)
        {
            var result = number.ToString();
            var pad = length - result.Length;
            while (pad > 0)
            {
                result = '0' + result;
                pad--;
            }

            return result;
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProvinceData();
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCityData();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBarangayData();
        }
    }
}
