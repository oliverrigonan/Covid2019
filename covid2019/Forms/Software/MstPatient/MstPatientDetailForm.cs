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
        private Tools.SysEncryptDecryptTool encryptDecryptTool = new Tools.SysEncryptDecryptTool();

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

        public void GetTablesData()
        {
            var sexes = from d in db.MstTables
                        where d.Category == "Sex"
                        select new Models.MstTableModel
                        {
                            Id = d.Id,
                            Category = d.Category,
                            Code = d.Code,
                            Value = d.Value
                        };

            comboBoxSex.DataSource = sexes.ToList();

            var clusters = from d in db.MstTables
                           where d.Category == "Cluster"
                           select new Models.MstTableModel
                           {
                               Id = d.Id,
                               Category = d.Category,
                               Code = d.Code,
                               Value = d.Value
                           };

            comboBoxCluster.DataSource = clusters.ToList();

            GetCountryData();
        }

        public void GetCountryData()
        {
            var countries = from d in db.MstCountries
                            select new Models.MstCountryModel
                            {
                                Id = d.Id,
                                Country = d.Country
                            };

            comboBoxCountry.DataSource = countries.OrderBy(d => d.Country).ToList();
            GetProvinceData();
        }

        public void GetProvinceData()
        {
            var provinces = from d in db.MstProvinces
                            where d.CountryId == Convert.ToInt32(comboBoxCountry.SelectedValue)
                            select new Models.MstProvinceModel
                            {
                                Id = d.Id,
                                Province = d.Province
                            };

            comboBoxProvince.DataSource = provinces.OrderBy(d => d.Province).ToList();
            GetCityData();
        }

        public void GetCityData()
        {
            var cities = from d in db.MstCities
                         where d.ProvinceId == Convert.ToInt32(comboBoxProvince.SelectedValue)
                         select new Models.MstCityModel
                         {
                             Id = d.Id,
                             City = d.City
                         };

            comboBoxCity.DataSource = cities.OrderBy(d => d.City).ToList();
            GetBarangayData();
        }

        public void GetBarangayData()
        {
            var barangays = from d in db.MstBarangays
                            where d.CityId == Convert.ToInt32(comboBoxCity.SelectedValue)
                            select new Models.MstBarangayModel
                            {
                                Id = d.Id,
                                Barangay = d.Barangay
                            };

            comboBoxBarangay.DataSource = barangays.OrderBy(d => d.Barangay).ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSex.SelectedIndex == -1)
                {
                    MessageBox.Show("Sex not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxCountry.SelectedIndex == -1)
                {
                    MessageBox.Show("Country not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxProvince.SelectedIndex == -1)
                {
                    MessageBox.Show("Province not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxCity.SelectedIndex == -1)
                {
                    MessageBox.Show("City not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxBarangay.SelectedIndex == -1)
                {
                    MessageBox.Show("Barangay not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxCluster.SelectedIndex == -1)
                {
                    MessageBox.Show("Cluster not found.", "Covid 2019", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                        Patient = encryptDecryptTool.EncryptString(textBoxPatient.Text),
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

                    patientForm.UpdatePatientDataSource();
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

                        patientForm.UpdatePatientDataSource();
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

            if (comboBoxProvince.SelectedIndex == -1)
            {
                comboBoxProvince.Text = "";
            }
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCityData();

            if (comboBoxCity.SelectedIndex == -1)
            {
                comboBoxCity.Text = "";
            }
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBarangayData();

            if (comboBoxBarangay.SelectedIndex == -1)
            {
                comboBoxBarangay.Text = "";
            }
        }

        private void comboBoxBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
