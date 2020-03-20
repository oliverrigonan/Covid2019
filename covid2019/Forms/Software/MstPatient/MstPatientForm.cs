using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid2019.Forms.Software.MstPatient
{
    public partial class MstPatientForm : Form
    {
        public static Database.covid2019dbDataContext db = new Database.covid2019dbDataContext(Modules.ModCovid2019DatabaseModule.GetConnectionString());
        private Tools.SysEncryptDecryptTool encryptDecryptTool = new Tools.SysEncryptDecryptTool();

        private static List<DataGridViewModels.MstPatientModel> patientData = new List<DataGridViewModels.MstPatientModel>();
        private static List<DataGridViewModels.MstPatientModel> filteredPatientData = new List<DataGridViewModels.MstPatientModel>();
        private static Int32 pageNumber = 1, pageSize = 50;
        private PagedList<DataGridViewModels.MstPatientModel> inventoryReportListPageList = new PagedList<DataGridViewModels.MstPatientModel>(patientData, pageNumber, pageSize);

        public MstPatientForm()
        {
            InitializeComponent();
            CreatePatientDataGridView();
        }

        public void CreatePatientDataGridView()
        {
            UpdatePatientDataSource();

            dataGridViewPatients.Columns[0].DefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridViewPatients.Columns[0].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewPatients.Columns[0].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewPatients.Columns[1].DefaultCellStyle.BackColor = Color.IndianRed;
            dataGridViewPatients.Columns[1].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dataGridViewPatients.Columns[1].DefaultCellStyle.ForeColor = Color.White;

            dataGridViewPatients.DataSource = bindingSourcePatients;
        }

        public void UpdatePatientDataSource()
        {
            String filter = textBoxSearchPatient.Text;
            SetPatientDataSourceAsync(filter);
        }

        public async void SetPatientDataSourceAsync(String filter)
        {
            List<DataGridViewModels.MstPatientModel> getPatientData = await GetPatientDataTask(filter);
            if (getPatientData.Any())
            {
                patientData = getPatientData;
                inventoryReportListPageList = new PagedList<DataGridViewModels.MstPatientModel>(patientData, pageNumber, pageSize);

                if (inventoryReportListPageList.PageCount == 1)
                {
                    buttonFirst.Enabled = false;
                    buttonPrevious.Enabled = false;
                    buttonNext.Enabled = false;
                    buttonLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonFirst.Enabled = false;
                    buttonPrevious.Enabled = false;
                    buttonNext.Enabled = true;
                    buttonLast.Enabled = true;
                }
                else if (pageNumber == inventoryReportListPageList.PageCount)
                {
                    buttonFirst.Enabled = true;
                    buttonPrevious.Enabled = true;
                    buttonNext.Enabled = false;
                    buttonLast.Enabled = false;
                }
                else
                {
                    buttonFirst.Enabled = true;
                    buttonPrevious.Enabled = true;
                    buttonNext.Enabled = true;
                    buttonLast.Enabled = true;
                }

                buttonPageNumber.Text = pageNumber + " / " + inventoryReportListPageList.PageCount;
                bindingSourcePatients.DataSource = inventoryReportListPageList;
            }
            else
            {
                buttonFirst.Enabled = false;
                buttonPrevious.Enabled = false;
                buttonNext.Enabled = false;
                buttonLast.Enabled = false;

                pageNumber = 1;

                patientData = new List<DataGridViewModels.MstPatientModel>();
                bindingSourcePatients.Clear();
                buttonPageNumber.Text = "1 / 1";
            }
        }

        private List<Models.MstPatientModel> GetPatientList()
        {
            var patients = from d in db.MstPatients
                           select new Models.MstPatientModel
                           {
                               Id = d.Id,
                               PatientCode = d.PatientCode,
                               Patient = encryptDecryptTool.DecryptString(d.Patient),
                               DateEncoded = d.DateEncoded,
                               DateOfArrival = d.DateOfArrival,
                               DateOfQuarantine = d.DateOfQuarantine,
                               Age = d.Age,
                               Sex = d.Sex,
                               Address = d.Address,
                               ContactNumber = d.ContactNumber,
                               BarangayId = d.BarangayId,
                               Barangay = d.MstBarangay.Barangay,
                               CityId = d.CityId,
                               City = d.MstCity.City,
                               ProvinceId = d.ProvinceId,
                               Province = d.MstProvince.Province,
                               CountryId = d.CountryId,
                               Country = d.MstCountry.Country,
                               Cluster = d.Cluster,
                               PassportNumber = d.PassportNumber,
                               Remarks = d.Remarks,
                           };

            if (patients.Any())
            {
                return patients.ToList();
            }
            else
            {
                return new List<Models.MstPatientModel>();
            }
        }

        private Task<List<DataGridViewModels.MstPatientModel>> GetPatientDataTask(String filter)
        {
            List<Models.MstPatientModel> listPatients = GetPatientList();
            if (listPatients.Any())
            {
                var patients = from d in listPatients
                               where d.PatientCode.Contains(filter) ||
                               d.Patient.Contains(filter) ||
                               d.Sex.Contains(filter) ||
                               d.Address.Contains(filter) ||
                               d.ContactNumber.Contains(filter) ||
                               d.Barangay.Contains(filter) ||
                               d.City.Contains(filter) ||
                               d.Province.Contains(filter) ||
                               d.Country.Contains(filter) ||
                               d.Cluster.Contains(filter) ||
                               d.PassportNumber.Contains(filter) ||
                               d.Remarks.Contains(filter)
                               select new DataGridViewModels.MstPatientModel
                               {
                                   ColumnButtonEdit = "Edit",
                                   ColumnButtonDelete = "Delete",
                                   ColumnId = d.Id,
                                   ColumnPatientCode = d.PatientCode,
                                   ColumnPatient = d.Patient,
                                   ColumnDateEncoded = d.DateEncoded.ToShortDateString(),
                                   ColumnDateOfArrival = d.DateOfArrival.ToShortDateString(),
                                   ColumnDateOfQuarantine = d.DateOfQuarantine.ToShortDateString(),
                                   ColumnAge = d.Age,
                                   ColumnSex = d.Sex,
                                   ColumnAddress = d.Address,
                                   ColumnContactNumber = d.ContactNumber,
                                   ColumnBarangayId = d.BarangayId,
                                   ColumnBarangay = d.Barangay,
                                   ColumnCityId = d.CityId,
                                   ColumnCity = d.City,
                                   ColumnProvinceId = d.ProvinceId,
                                   ColumnProvince = d.Province,
                                   ColumnCountryId = d.CountryId,
                                   ColumnCountry = d.Country,
                                   ColumnCluster = d.Cluster,
                                   ColumnPassportNumber = d.PassportNumber,
                                   ColumnRemarks = d.Remarks,
                                   ColumnSpace = ""
                               };

                filteredPatientData = patients.ToList();
                return Task.FromResult(patients.ToList());
            }
            else
            {
                filteredPatientData = new List<DataGridViewModels.MstPatientModel>();
                return Task.FromResult(new List<DataGridViewModels.MstPatientModel>());
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            inventoryReportListPageList = new PagedList<DataGridViewModels.MstPatientModel>(patientData, 1, pageSize);
            bindingSourcePatients.DataSource = inventoryReportListPageList;

            buttonFirst.Enabled = false;
            buttonPrevious.Enabled = false;
            buttonNext.Enabled = true;
            buttonLast.Enabled = true;

            pageNumber = 1;
            buttonPageNumber.Text = pageNumber + " / " + inventoryReportListPageList.PageCount;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (inventoryReportListPageList.HasPreviousPage == true)
            {
                inventoryReportListPageList = new PagedList<DataGridViewModels.MstPatientModel>(patientData, --pageNumber, pageSize);
                bindingSourcePatients.DataSource = inventoryReportListPageList;
            }

            buttonNext.Enabled = true;
            buttonLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonFirst.Enabled = false;
                buttonPrevious.Enabled = false;
            }

            buttonPageNumber.Text = pageNumber + " / " + inventoryReportListPageList.PageCount;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (inventoryReportListPageList.HasNextPage == true)
            {
                inventoryReportListPageList = new PagedList<DataGridViewModels.MstPatientModel>(patientData, ++pageNumber, pageSize);
                bindingSourcePatients.DataSource = inventoryReportListPageList;
            }

            buttonFirst.Enabled = true;
            buttonPrevious.Enabled = true;

            if (pageNumber == inventoryReportListPageList.PageCount)
            {
                buttonNext.Enabled = false;
                buttonLast.Enabled = false;
            }

            buttonPageNumber.Text = pageNumber + " / " + inventoryReportListPageList.PageCount;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            inventoryReportListPageList = new PagedList<DataGridViewModels.MstPatientModel>(patientData, inventoryReportListPageList.PageCount, pageSize);
            bindingSourcePatients.DataSource = inventoryReportListPageList;

            buttonFirst.Enabled = true;
            buttonPrevious.Enabled = true;
            buttonNext.Enabled = false;
            buttonLast.Enabled = false;

            pageNumber = inventoryReportListPageList.PageCount;
            buttonPageNumber.Text = pageNumber + " / " + inventoryReportListPageList.PageCount;
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialogGenerateCSV.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                StringBuilder csv = new StringBuilder();
                String[] header = {
                    "Patient Code",
                    "Date Encoded",
                    "Date of Arrival",
                    "Date of Quarantine",
                    "Age",
                    "Sex",
                    "Address",
                    "Contact Number",
                    "Barangay",
                    "City",
                    "Province",
                    "Country",
                    "Cluster",
                    "Passport Number",
                    "Remarks"
                };
                csv.AppendLine(String.Join(",", header));

                String filter = textBoxSearchPatient.Text;

                var patients = from d in filteredPatientData select d;
                if (patients.Any())
                {
                    foreach (var patient in patients)
                    {
                        String[] data = {
                               patient.ColumnPatientCode.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnDateEncoded.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnDateOfArrival.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnDateOfQuarantine.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnAge.ToString().Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnSex.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnAddress.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnContactNumber.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnBarangay.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnCity.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnProvince.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnCountry.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnCluster.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnPassportNumber.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                               patient.ColumnRemarks.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty)
                            };

                        csv.AppendLine(String.Join(",", data));
                    }
                }

                String executingUser = WindowsIdentity.GetCurrent().Name;

                DirectorySecurity securityRules = new DirectorySecurity();
                securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                File.WriteAllText(createDirectorySTCSV.FullName + "\\PatientReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("iso-8859-1"));

                MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Models.MstPatientModel mstPatientModel = new Models.MstPatientModel()
            {
                Id = 0,
                PatientCode = "",
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
            //Environment.Exit(0);
            Close();

            IndexForm indexForm = new IndexForm();
            indexForm.Show();
        }

        private void textBoxSearchPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdatePatientDataSource();
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

                        UpdatePatientDataSource();
                    }
                }
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            UpdatePatientDataSource();
        }

        private void MstPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IndexForm indexForm = new IndexForm();
            indexForm.Show();
        }
    }
}
