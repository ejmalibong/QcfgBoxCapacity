using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace QcfgBoxCapacity
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetForm();
            this.Text = this.Text + " " + Application.ProductVersion.ToString();
        }

         void ResetForm()
        {
            btnCheckModel.Text = "Check Model";
            btnCheckModel.ForeColor = Color.Black;

            btnChangeQty.Enabled = false;
            txtChangeQty.Enabled = false;
            txtChangeQty.Text = "";

            lblCurrentQty2.Text = "";

            txtModel.Enabled = true;
            this.ActiveControl = txtModel;
        }

        void ChangeMode()
        {
            btnCheckModel.Text = "Change Model";
            btnCheckModel.ForeColor = Color.Red;

            btnChangeQty.Enabled = true;

            txtModel.Enabled = false;

            txtChangeQty.Enabled = true;
            this.ActiveControl = txtChangeQty;
        }

        private void btnCheckModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCheckModel.Text == "Check Model")
                {
                    using (SqlConnection con = new SqlConnection())
                    {
                        con.ConnectionString = Properties.Settings.Default.conString;
                        con.Open();

                        SqlCommand cmd = new SqlCommand("SELECT COUNT(ITEM_ID) FROM TB_M_ITEM WHERE ITEM_ID = @itemId", con);
                        cmd.Parameters.Add(new SqlParameter("@itemId", txtModel.Text.Trim()));

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            ChangeMode();

                            SqlCommand cmdRdr = new SqlCommand("SELECT ISNULL(box_capacity,0) FROM TB_M_ITEM WHERE ITEM_ID = @itemId2", con);
                            cmdRdr.Parameters.Add(new SqlParameter("@itemId2", txtModel.Text.Trim()));

                            using (SqlDataReader rdr = cmdRdr.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    lblCurrentQty2.Text = rdr[0].ToString();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Model is not registered.");
                            ResetForm();
                        }
                    }
                }
                else
                {
                    ResetForm();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeQty_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtChangeQty.Text) && int.TryParse(txtChangeQty.Text, out int qty))
                {
                    using (SqlConnection con = new SqlConnection())
                    {
                        con.ConnectionString = Properties.Settings.Default.conString;
                        con.Open();

                        SqlCommand cmdUpd = new SqlCommand("UPDATE TB_M_ITEM SET box_capacity = @qty WHERE ITEM_ID = @itemId", con);
                        cmdUpd.Parameters.Add(new SqlParameter("@qty", txtChangeQty.Text));
                        cmdUpd.Parameters.Add(new SqlParameter("itemId", txtModel.Text.Trim()));
                        cmdUpd.ExecuteNonQuery();
                        ResetForm();
                    }
                }
                else
                {
                    MessageBox.Show("Value cannot be empty or zero.");
                    this.ActiveControl = txtChangeQty;
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtChangeQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
