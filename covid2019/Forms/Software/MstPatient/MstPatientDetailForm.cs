using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid2019.Forms.Software.MstPatient
{
    public partial class MstPatientDetailForm : Form
    {
        public static Database.covid2019dbDataContext db = new Database.covid2019dbDataContext(Modules.ModCovid2019DatabaseModule.GetConnectionString());

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
            comboBoxSex.DataSource = null;

            var sexes = from d in db.MstTables
                        where d.Category == "Sex"
                        select new Models.MstTableModel
                        {
                            Id = d.Id,
                            Category = d.Category,
                            Code = d.Code,
                            Value = d.Value
                        };

            if (sexes.Any())
            {
                comboBoxSex.DataSource = sexes.ToList();
                comboBoxSex.ValueMember = "Value";
                comboBoxSex.DisplayMember = "Value";
            }

            comboBoxCluster.DataSource = null;

            var clusters = from d in db.MstTables
                           where d.Category == "Cluster"
                           select new Models.MstTableModel
                           {
                               Id = d.Id,
                               Category = d.Category,
                               Code = d.Code,
                               Value = d.Value
                           };

            if (clusters.Any())
            {
                comboBoxCluster.DataSource = clusters.ToList();
                comboBoxCluster.ValueMember = "Value";
                comboBoxCluster.DisplayMember = "Value";
            }

            GetCountryData();
        }

        public void GetCountryData()
        {
            comboBoxCountry.DataSource = null;

            var countries = from d in db.MstCountries
                            select new Models.MstCountryModel
                            {
                                Id = d.Id,
                                Country = d.Country
                            };

            if (countries.Any())
            {
                comboBoxCountry.DataSource = countries.OrderBy(d => d.Country).ToList();
                comboBoxCountry.ValueMember = "Id";
                comboBoxCountry.DisplayMember = "Country";
            }

            GetProvinceData();
        }

        public void GetProvinceData()
        {
            comboBoxProvince.DataSource = null;

            var provinces = from d in db.MstProvinces
                            where d.CountryId == Convert.ToInt32(comboBoxCountry.SelectedValue)
                            select new Models.MstProvinceModel
                            {
                                Id = d.Id,
                                Province = d.Province
                            };

            if (provinces.Any())
            {
                comboBoxProvince.DataSource = provinces.OrderBy(d => d.Province).ToList();
                comboBoxProvince.ValueMember = "Id";
                comboBoxProvince.DisplayMember = "Province";
            }

            GetCityData();
        }

        public void GetCityData()
        {
            comboBoxCity.DataSource = null;

            var cities = from d in db.MstCities
                         where d.ProvinceId == Convert.ToInt32(comboBoxProvince.SelectedValue)
                         select new Models.MstCityModel
                         {
                             Id = d.Id,
                             City = d.City
                         };

            if (cities.Any())
            {
                comboBoxCity.DataSource = cities.OrderBy(d => d.City).ToList();
                comboBoxCity.ValueMember = "Id";
                comboBoxCity.DisplayMember = "City";
            }

            GetBarangayData();
        }

        public void GetBarangayData()
        {
            comboBoxBarangay.DataSource = null;

            var barangays = from d in db.MstBarangays
                            where d.CityId == Convert.ToInt32(comboBoxCity.SelectedValue)
                            select new Models.MstBarangayModel
                            {
                                Id = d.Id,
                                Barangay = d.Barangay
                            };

            if (barangays.Any())
            {
                comboBoxBarangay.DataSource = barangays.OrderBy(d => d.Barangay).ToList();
                comboBoxBarangay.ValueMember = "Id";
                comboBoxBarangay.DisplayMember = "Barangay";
            }
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

                    patientForm.GetPatientData();
                    Close();
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

                        patientForm.GetPatientData();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Patient not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void comboBoxBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
