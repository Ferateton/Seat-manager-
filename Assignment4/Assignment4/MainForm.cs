using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPILabb6
{
    public partial class MainForm : Form
    {
        private const int numOfSeats = 8;
        private string name = string.Empty;
        private double price = 0.0;
        private string toBeReplaced = string.Empty;

        private SeatManager seatMngr;

        /// <summary>
        /// This is the constructor for the MainForm.cs class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            seatMngr = new SeatManager(8);
            InitializeGUI();
        }

        ///<summary>
        ///Initializes the values of the GUI elements.
        ///</summary>
        private void InitializeGUI()
        {
            reserve.Checked = true;
            displayModeComobB.DataSource = Enum.GetValues(typeof(DisplayMode));
            displayModeComobB.SelectedIndex = 0;

            listReservations.Items.Clear();
            listReservations.Items.AddRange(seatMngr.GetSeatInfoStrings((DisplayMode)displayModeComobB.SelectedValue));
            
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;

            totalNumberOfSeatslb.Text = numOfSeats.ToString();
            numberOfReservedSeatslb.Text = seatMngr.GetNumReserved().ToString();
            numberOfVacantSeatslb.Text = seatMngr.GetNumVacant().ToString();
            totalRevenuelb.Text = seatMngr.GetRevenue().ToString();
        }
        ///<summary>
        ///Reads the name the user has put in the "txtName" textbox and handles it.
        ///</summary>
        private bool ReadAndValidateName()
        {
            name = txtName.Text;

            if (!InputUtility.ValidateString(name))
            {
                MessageBox.Show("Invalid input in the name field! Name cannot be empty," + Environment.NewLine +
                    "and must have at least one character (not blank)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.Text = " ";
                txtName.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Checks whether the user has highlighted an item in the "lstReservations" listbox.
        /// </summary>
        /// <returns></returns>
        private bool CheckSelectedIndex(int index)
        {
            if (index >= 0)
                return true;
            else
            {
                MessageBox.Show("Please select an item in the list!");
                return false;
            }
        }

        
        ///<summary>
        ///Reads the price the user has put in the "txtPrice" textbox and handles it.
        ///</summary>
        private bool ReadAndValidatePrice()
        {
            if (!InputUtility.GetPositiveDouble(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid input in the price field! Price cannot be empty," + Environment.NewLine +
                                "it must have at least one digit (not blank), and it has" + Environment.NewLine +
                                "to be a value above 0 and below 1000. ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.Text = "0.0";
                txtPrice.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }

        ///<summary>
        ///Runs methods "ReadAndValidateName()" and "ReadAndValidatePrice()", then returns if both are "true".
        ///</summary>
        private bool ReadAndValidateInput()
        {
            bool nameOk = ReadAndValidateName();
            bool priceOk = ReadAndValidatePrice();

            return nameOk && priceOk;
        }

        ///<summary>
        ///This is what happens when the user clicks the "Ok" button.
        ///</summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            ReserveOrCancelSeat();
        }

        /// <summary>
        /// Reserves or Cancels a seat.
        /// </summary>
        private void ReserveOrCancelSeat()
        {
            int index = listReservations.SelectedIndex;
            if (ReadAndValidateInput() && CheckSelectedIndex(index))
            {
                toBeReplaced = listReservations.SelectedItem.ToString();
                index = seatMngr.ExtractNumber(toBeReplaced) - 1;

                if (reserve.Checked == true)
                {
                    if (seatMngr.IsReserved(index) == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("This seat is already reserved. Do you still wish to continue?",
                                "Seat already Registered", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                            seatMngr.ReserveSeat(name, price, index);
                        else return;
                    }
                    seatMngr.ReserveSeat(name, price, index);
                }
                else
                {
                    if (seatMngr.IsReserved(index) == true)
                    {
                        DialogResult dialogResult2 = MessageBox.Show("Are you sure you wish to cancel this reservation?",
                            "Cancel Reservation", MessageBoxButtons.OKCancel);
                        if (dialogResult2 == DialogResult.OK)
                            seatMngr.CancelSeat(index);
                        else return;
                    }
                    else
                    {
                        MessageBox.Show("This seat is already vacant. Please choose one that is reserved!");
                        return;
                    }
                }
            }
            UpdateGUI();
        }

        ///<summary>
        ///Updates the GUI.
        ///</summary>
        private void UpdateGUI()
        {
            listReservations.Items.Clear();
            listReservations.Items.AddRange(seatMngr.GetSeatInfoStrings((DisplayMode)displayModeComobB.SelectedValue));
            
            numberOfReservedSeatslb.Text = seatMngr.GetNumReserved().ToString();
            numberOfVacantSeatslb.Text = seatMngr.GetNumVacant().ToString();
            totalNumberOfSeatslb.Text = numOfSeats.ToString();
            totalRevenuelb.Text = seatMngr.GetRevenue().ToString();
        }

        /// <summary>
        /// Automatically created. This shouldn't be messed with!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        ///<summary>
        ///If the "Cancel Reservation" radio button is checked, the txtName and txtPrice textboxes will be disabled.
        ///</summary>
        private void rbCancelReservation_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
        }

        ///<summary>
        ///If the "Reserve" radio button is checked, the txtName and txtPrice textboxes will be enabled.
        ///</summary>
        private void rbReserve_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
        }

    }
}
