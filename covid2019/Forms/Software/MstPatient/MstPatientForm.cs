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
    public partial class MstPatientForm : Form
    {
        public static Database.covid2019dbDataContext db = Modules.ModCovid2019DatabaseModule.GetCovid2019Database();

        public MstPatientForm()
        {
            InitializeComponent();
            GetPatientData();
        }

        public void GetPatientData()
        {
            dataGridViewPatients.Rows.Clear();
            dataGridViewPatients.Refresh();

            dataGridViewPatients.Columns[0].DefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridViewPatients.Columns[0].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewPatients.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewPatients.Columns[1].DefaultCellStyle.BackColor = Color.IndianRed;
            dataGridViewPatients.Columns[1].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dataGridViewPatients.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            String filter = textBoxSearchPatient.Text;

            var patients = from d in db.MstPatients
                           where d.PatientCode.Contains(filter) ||
                           d.Patient.Contains(filter) ||
                           d.Sex.Contains(filter) ||
                           d.Address.Contains(filter) ||
                           d.ContactNumber.Contains(filter) ||
                           d.MstBarangay.Barangay.Contains(filter) ||
                           d.MstCity.City.Contains(filter) ||
                           d.MstProvince.Province.Contains(filter) ||
                           d.MstCountry.Country.Contains(filter) ||
                           d.Cluster.Contains(filter) ||
                           d.PassportNumber.Contains(filter) ||
                           d.Remarks.Contains(filter)
                           select d;

            if (patients.Any())
            {
                foreach (var patient in patients)
                {
                    dataGridViewPatients.Rows.Add(
                       "Edit",
                       "Delete",
                       patient.Id,
                       patient.PatientCode,
                       patient.Patient,
                       patient.DateEncoded.ToShortDateString(),
                       patient.DateOfArrival.ToShortDateString(),
                       patient.DateOfQuarantine.ToShortDateString(),
                       patient.Age,
                       patient.Sex,
                       patient.Address,
                       patient.ContactNumber,
                       patient.BarangayId,
                       patient.MstBarangay.Barangay,
                       patient.CityId,
                       patient.MstCity.City,
                       patient.ProvinceId,
                       patient.MstProvince.Province,
                       patient.CountryId,
                       patient.MstCountry.Country,
                       patient.Cluster,
                       patient.PassportNumber,
                       patient.Remarks,
                       ""
                    );
                }
            }
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.MstPatientModel mstPatientModel = new Models.MstPatientModel()
            {
                Id = 0,
                PatientCode = "0000000000",
                Patient = "",
                DateEncoded = DateTime.Today,
                DateOfArrival = DateTime.Today,
                DateOfQuarantine = DateTime.Today,
                Age = 0,
                Sex = "Male",
                Address = "",
                ContactNumber = "",
                BarangayId = 0,
                CityId = 453,
                ProvinceId = 25,
                CountryId = 139,
                Cluster = "North",
                PassportNumber = "",
                Remarks = ""
            };

            MstPatientDetailForm mstPatientDetailForm = new MstPatientDetailForm(this, mstPatientModel);
            mstPatientDetailForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxSearchPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetPatientData();
            }
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridViewPatients.CurrentCell.ColumnIndex == dataGridViewPatients.Columns["ColumnEdit"].Index)
            {
                Models.MstPatientModel mstPatientModel = new Models.MstPatientModel()
                {
                    Id = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnId"].Index].Value),
                    PatientCode = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnPatientCode"].Index].Value.ToString(),
                    Patient = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnPatient"].Index].Value.ToString(),
                    DateEncoded = Convert.ToDateTime(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnDateEncoded"].Index].Value),
                    DateOfArrival = Convert.ToDateTime(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnDateOfArrival"].Index].Value),
                    DateOfQuarantine = Convert.ToDateTime(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnDateOfQuarantine"].Index].Value),
                    Age = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnAge"].Index].Value),
                    Sex = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnSex"].Index].Value.ToString(),
                    Address = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnAddress"].Index].Value.ToString(),
                    ContactNumber = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnContactNumber"].Index].Value.ToString(),
                    BarangayId = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnBarangayId"].Index].Value),
                    CityId = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnCityId"].Index].Value),
                    ProvinceId = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnProvinceId"].Index].Value),
                    CountryId = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnCountryId"].Index].Value),
                    Cluster = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnCluster"].Index].Value.ToString(),
                    PassportNumber = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnPassportNumber"].Index].Value.ToString(),
                    Remarks = dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnRemarks"].Index].Value.ToString(),
                };

                MstPatientDetailForm mstPatientDetailForm = new MstPatientDetailForm(this, mstPatientModel);
                mstPatientDetailForm.ShowDialog();
            }

            if (e.RowIndex > -1 && dataGridViewPatients.CurrentCell.ColumnIndex == dataGridViewPatients.Columns["ColumnDelete"].Index)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Patient?", "Covid 2019", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    Int32 id = Convert.ToInt32(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[dataGridViewPatients.Columns["ColumnId"].Index].Value);

                    var currentPatient = from d in db.MstPatients
                                         where d.Id == id
                                         select d;

                    if (currentPatient.Any())
                    {
                        db.MstPatients.DeleteOnSubmit(currentPatient.FirstOrDefault());
                        db.SubmitChanges();

                        GetPatientData();
                    }
                }
            }
        }
    }
}
