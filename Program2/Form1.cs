/*
 * Grading ID: K3194
 * Program 2
 * Due Date: 3/10/2022
 * Course Section: CIS 199-01
 * Description: Calculates the total hotel stay cost based on number of guests, number of nights, and number of stars
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e) //event handler for calculateButton click
        {
            const int ONE_GUEST_FLAT_FEE = 100; //flat fee for 1 guest
            const int TWO_GUESTS_FLAT_FEE = 150; //flat fee for 2 guests
            const int THREE_GUESTS_FLAT_FEE = 250; //flat fee for 3 guests
            const int FOUR_TO_SEVEN_GUESTS_FLAT_FEE = 400; //flat fee for 4-7 guests

            const int DAILY_RATE = 100; //nightly rate for 1-6 nights
            const int WEEKLY_RATE = 75; //nightly rate for 7-30 nights
            const int MONTHLY_RATE = 25; //nightly rate for 31+ nights

            const double ONE_STAR_MULTIPLIER = 1.0; //rate multiplier for 1 star hotel
            const double TWO_STAR_MULTIPLIER = 1.5; //rate multiplier for 2 star hotel
            const double THREE_STAR_MULTIPLIER = 2.5; //rate multiplier for 3 star hotel
            const double FOUR_STAR_MULTIPLIER = 3.0; //rate multiplier for 4 star hotel
            const double FIVE_STAR_MULTIPLIER = 4.0; //rate multiplier for 5 star hotel

            bool invalidInput = false; //flag for tracking if any inputs were invalid
            int flatFee = 0; //int to hold flat fee based on numGuests
            int nightlyRate = 0; //int to hold nightly rate based on numNights
            double starMultiplier = 0; //double to hold star multiplier based on numStars

            if(int.TryParse(guestsInputTextBox.Text, out int numGuests)) //attempt to parse guests input and store in numGuests
            {
                if(numGuests < 1 || numGuests > 7) //check if value outside of valid numGuests range (1-7)
                {
                    guestsInputTextBox.Text = "INVALID INPUT"; //set text of guestsInputTextBox to INVALID INPUT
                    invalidInput = true; //set flag to true if invalid input detected
                }
                else //if numGuests is within valid range
                {
                    if(numGuests == 1)  //set flatFee to corresponding fee based on numGuests
                    {
                        flatFee = ONE_GUEST_FLAT_FEE; 
                    }
                    else if (numGuests == 2)
                    {
                        flatFee = TWO_GUESTS_FLAT_FEE;
                    }
                    else if (numGuests == 3)
                    {
                        flatFee = THREE_GUESTS_FLAT_FEE;
                    }
                    else
                    {
                        flatFee = FOUR_TO_SEVEN_GUESTS_FLAT_FEE;
                    }
                }
            } 
            else //if parsing guests input results in error
            {
                guestsInputTextBox.Text = "INVALID INPUT";
                invalidInput = true;
            }

            if(int.TryParse(nightsInputTextBox.Text, out int numNights)) //attempt to parse nights input and store in numNights
            {
                if(numNights < 1) //check if value outside of valid numNights range (1+)
                {
                    nightsInputTextBox.Text = "INVALID INPUT";
                    invalidInput = true;
                }
                else //if numNights is within valid range
                {
                    if(numNights <= 6) //set nightlyRate to corresponding rate based on numNights
                    {
                        nightlyRate = DAILY_RATE;
                    }
                    else if (numNights <= 30)
                    {
                        nightlyRate = WEEKLY_RATE;
                    }
                    else
                    {
                        nightlyRate = MONTHLY_RATE;
                    }
                }
            }
            else //if parsing nights input results in error
            {
                nightsInputTextBox.Text = "INVALID INPUT";
                invalidInput = true;
            }

            if(int.TryParse(starsInputComboBox.Text, out int numStars)) //attempt to parse stars input and store in numStars
            {
                if(numStars == 1) //set starMultiplier to corresponding multiplier based on numStars
                {
                    starMultiplier = ONE_STAR_MULTIPLIER;
                }
                else if (numStars == 2)
                {
                    starMultiplier = TWO_STAR_MULTIPLIER;
                }
                else if (numStars == 3)
                {
                    starMultiplier = THREE_STAR_MULTIPLIER;
                }
                else if (numStars == 4)
                {
                    starMultiplier = FOUR_STAR_MULTIPLIER;
                }
                else
                {
                    starMultiplier = FIVE_STAR_MULTIPLIER;
                }
            }
            else //if parsing stars input results in error (user left blank)
            {
                starsInputComboBox.Text = ""; //ensure starsInput is blank
                costOutputLabel.Text = "INVALID STARS"; //set costOutputLabel to display error (can't set text of exclusive list combo box)
                return; //end execution of function to avoid changing costOutputLabel from INVALID STARS
            }

            if (invalidInput) //if invalid input was detected on # of guests or # of nights
            {
                costOutputLabel.Text = "INVALID INPUT"; //set costOutputLabel to INVALID INPUT if any inputs were invalid
                return; //end execution of function to avoid changing costOutputLabel from INVALID INPUT
            }

            double hotelCost = (flatFee + (numNights * nightlyRate)) * starMultiplier; //perform hotel cost calculation
            costOutputLabel.Text = hotelCost.ToString("C"); //set costOutputLabel to hotelCost with currency formatting
        }
    }
}
