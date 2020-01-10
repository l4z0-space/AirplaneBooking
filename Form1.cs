using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneBook                  /* name: Lazaron Shyta  */
{
    public partial class Form1 : Form
    {

        int refreshIterator = 0; // iterator for inserting new Cities for selections

        /* Containers of the objects */
        List<Flight> allFlights = new List<Flight>(); // list of all flights
        List<Booking> allBookings = new List<Booking>(); // all the bookings made
        List<Traveler> allTravelers = new List<Traveler>(); // all the travelers

        bool[,] availableSeat = new bool[100,100];    // array to check whether the seat will be available (true) or not (false)

        

        public Form1()
        {
            InitializeComponent();
            Book.Enabled = false;  // initially book button is disabled
        }

        #region  panelNavigation
        private void Button1_Click(object sender, EventArgs e)
        {
            this.panelPassengers.BringToFront();
            panelPassengers.Visible = true;
        }

       
        private void Button2_Click(object sender, EventArgs e)
        {
            this.panelFlight.BringToFront();
            panelFlight.Visible = true;

        }
        #endregion

        #region Add Flight (Flight Manager)
        private void Button4_Click(object sender, EventArgs e)
        {
            int aCapacity = 0, nRows = 0;
            bool meal;
            bool OK = true;
            /* make sure data is valid */
            try
            {
                nRows = Int32.Parse(numberOfRows.Text);
                aCapacity = Int32.Parse(capacity.Text);
            }
            catch (Exception)
            {
                feedback.Text = "invalid info";
                OK = false;
            }

            meal = mealProvided.Checked;
            /*  add the new flight in the list of flights  */
            if (OK == true) {

                Random randomizer = new Random();
                int hours = randomizer.Next(0, 23);
                var departHours = departingCalendar.SelectionStart.AddHours(hours).ToShortTimeString();
                //var arrivalHours = arrivalCalendar.SelectionStart.AddHours(hours + 2);
                allFlights.Add(new Flight(flightID.Text, departingAirport.Text, landingAirport.Text,
                                          transitCity.Text, departingCalendar.SelectionStart, arrivalCalendar.SelectionStart,
                                          airplaneType.Text, aCapacity, nRows, meal));
                // add the returning flight 
                allFlights.Add(new Flight(flightID.Text, landingAirport.Text, departingAirport.Text, 
                                          transitCity.Text, arrivalCalendar.SelectionEnd, departingCalendar.SelectionEnd ,
                                          airplaneType.Text, aCapacity, nRows, meal));
                
                /* export to file */

                string textToBeAppendedInFile = "";
                textToBeAppendedInFile += departHours.ToString()+" ";
                textToBeAppendedInFile += departingCalendar.SelectionStart.ToShortDateString() + " ";
                textToBeAppendedInFile += departingAirport.Text + " " + landingAirport.Text + " ";
                textToBeAppendedInFile += flightID.Text; 
             

                System.IO.File.WriteAllText(@"FlightInfo.txt", textToBeAppendedInFile);

                MessageBox.Show("Flight information successfully sent to the file");

            }
         
            
        }
        #endregion

        #region Book a Flight (Passenger)
        private void Book_Click(object sender, EventArgs e)
        {
            Traveler currentTraveler = null; 
            string fName = firstName.Text;
            string lName = lastName.Text;
            /* check whether the name is entered correctly  */
            if (fName.Length == 0 || lName.Length == 0)
            {
                MessageBox.Show("Plase make sure you enter a valid name!");
            }
            else   /* if correct, then continue with the booking */
            {
                try
                {
                    currentTraveler = new Traveler(firstName.Text, lastName.Text);
                    allTravelers.Add(currentTraveler);
                    /* grab the information from the listBoxes */

                    string depCity = departureCities.SelectedItem.ToString();
                    string lanCity = landingCities.SelectedItem.ToString();
                    bool tripFound = false;

                    Flight flightToBeFound = null; // the flight we are looking for 

                    foreach (Flight flight in allFlights)
                    {    /* check whether the flight exists in the allFlights list*/
                         // [DEBUG] MessageBox.Show(deptDate.Value.ToShortDateString() + " " + flight.getDepartingTime().ToShortDateString());
                        if (flight.getDeptartingCity() == depCity && flight.getLandingCity() == lanCity &&
                            deptDate.Value.ToShortDateString() == flight.getDepartingTime().ToShortDateString())
                        {
                            tripFound = true; // flight found
                            flightToBeFound = flight; // assign the flight
                            break;
                        }
                    }
                    if (tripFound == true)
                    {


                        /* file to write */
                        string textToAppendInFile = "";
                        textToAppendInFile += flightToBeFound.getFlightID() + " ";
                        textToAppendInFile += currentTraveler.getFullName() + " ";
                        textToAppendInFile += flightToBeFound.getDeptartingCity() + " ";
                        textToAppendInFile += flightToBeFound.getLandingCity();

                        System.IO.File.WriteAllText(@"bookingInfo.txt", textToAppendInFile);

                        /* success message */
                        MessageBox.Show("Booking information successfully sent to the file!");

                        /*  add the booking to the allBookings list and Traveler to allPassegners list */
                        allBookings.Add(new Booking(flightToBeFound, currentTraveler, returnTicket.Checked));
                        allPassengers.Items.Add(currentTraveler.getFullName());

                        /* success message */
                        MessageBox.Show("Successfully booked!");
                    }
                    else
                    {
                        MessageBox.Show("No flights avaialble for selected cities or dates!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please make sure you select cities!");
                }
            }
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            for(; refreshIterator < allFlights.Count; refreshIterator++)
            {
                Flight currFlight = allFlights[refreshIterator];
                departureCities.Items.Add(currFlight.getDeptartingCity());
                landingCities.Items.Add(currFlight.getLandingCity());
            }
            
        }

        private void CheckSeat_Click_1(object sender, EventArgs e)
        {

            /* using seat number and letter we now can refer to a particular seat as index of a 2D array of booleans*/
            int x, y;
            try
            {
                x = Int16.Parse(seatNumber.Text);
                y = (int)(char.Parse(seatLetter.Text)) % 32;
                if (availableSeat[x, y] != true)
                {
                    /* available */
                    availableSeat[x, y] = true;
                    MessageBox.Show("Seat available!");
                    /* enable the book button*/
                    Book.Enabled = true;

                }
                else MessageBox.Show("Seat not available!");
            }
            catch(Exception)
            {
                MessageBox.Show("Please select seats!");
            }
            

        }

        #endregion

        #region useless

        private void DepartingCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void Passengers_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("credits: Lazaron Shyta");
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelPassengers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void PanelFlight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        #endregion

       
    }
}
