using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DanceStudioBookingSystem
{
    public partial class frmBookClass : Form
    {
        public frmBookClass() {
            InitializeComponent();
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            UtilFunctions.PerformMenuProfile(this);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = true; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPayment.Visible = false;

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int isNumeric = 0, isNOTNumeric = 0;
            if (string.IsNullOrEmpty(txtCardNumber.Text) || txtCardNumber.Text.Length<10)
            {
                MessageBox.Show("Please enter a valid card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (char c in txtCardNumber.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Please enter a valid card number (only numeric digits are allowed)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }
            }
            UtilFunctions.PerformMenuProfile(this);
        }



        private void InsertDataIntoDataGridView()
        {
            dgvClasses.Rows.Clear();

            if (cboType.SelectedIndex == 0)
            {
                List<List<string>> kpopDataList = new List<List<string>>()
                {
                    new List<string> { "K-pop (Advance)", "2023-11-24", "10:00 AM", "Ji-min Lee", "$15" },
                    new List<string> { "K-pop (Intermidiate)", "2023-11-25", "02:30 PM", "Hyun-woo Park", "$15" },
                    new List<string> { "K-pop (Beginer)", "2023-11-27", "04:30 PM", "Soo-jin Kim", "$10" },
                    new List<string> { "K-pop (Beginer)", "2023-11-26", "06:30 PM", "Ji-min Lee", "$10" },
                    new List<string> { "K-pop (Intermidiate)", "2023-11-24", "12:30 AM", "Hyun-woo Park", "$10" },
                };

                foreach (var rowData in kpopDataList)
                {
                    dgvClasses.Rows.Add(rowData.ToArray());
                }
            }else if (cboType.SelectedIndex == 1)
            {
                List<List<string>> latinDataList = new List<List<string>>()
                {
                    new List<string> { "Latin (Advance)", "2023-11-24", "11:00 AM", "Rafael Lopez", "$25" },
                    new List<string> { "Latin (Intermidiate)", "2023-11-25", "02:30 PM", "Isabella Martinez", "$25" },
                    new List<string> { "Latin (Beginer)", "2023-11-27", "03:30 PM", "Rafael Lopez", "$20" },
                };

                foreach (var rowData in latinDataList)
                {
                    dgvClasses.Rows.Add(rowData.ToArray());
                }
            }else if(cboType.SelectedIndex == 2) 
            {
                List<List<string>> BalletDataList = new List<List<string>>()
                {
                    new List<string> { "Ballet (Advance)", "2024-01-24", "11:00 AM", "Olivia Smith", "$35" },

                };

                foreach (var rowData in BalletDataList)
                {
                    dgvClasses.Rows.Add(rowData.ToArray());
                }
            }else if (cboType.SelectedIndex == 3)
            {
                List<List<string>> HipHopDataList = new List<List<string>>()
                {
                    new List<string> { "HipHop (Advance)", "2023-11-24", "10:00 AM", "Xavier Ortiz", "$15" },
                    new List<string> { "HipHop (Advance)", "2023-11-25", "10:00 AM", "Jasmine Williams", "$15" },
                    new List<string> { "HipHop (Advance)", "2023-11-25", "11:00 AM", "Ji-min Lee", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-25", "02:30 PM", "Xavier Ortiz", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-25", "03:30 PM", "Jasmine Williams", "$15" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-26", "02:30 PM", "Malik Johnson", "$15" },
                    new List<string> { "HipHop (Beginer)", "2023-11-26", "04:30 PM", "Soo-jin Kim", "$10" },
                    new List<string> { "HipHop (Beginer)", "2023-11-26", "06:30 PM", "Xavier Ortiz", "$10" },
                    new List<string> { "HipHop (Beginer)", "2023-11-27", "01:30 PM", "Jasmine Williams", "$10" },
                    new List<string> { "HipHop (Beginer)", "2023-11-27", "02:30 PM", "Malik Johnson", "$10" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-28", "12:30 AM", "Hyun-woo Park", "$10" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-28", "11:30 AM", "Malik Johnson", "$10" },
                    new List<string> { "HipHop (Intermidiate)", "2023-11-28", "10:30 AM", "Xavier Ortiz", "$10" },

                };

                foreach (var rowData in HipHopDataList)
                {
                    dgvClasses.Rows.Add(rowData.ToArray());
                }
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertDataIntoDataGridView();
        }
    }
}
