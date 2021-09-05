using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace alt_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Smoothly contoured & finely painted rocket with shaped fins, finely finished with no significant external protrusions, use Cd = 0.35" + Environment.NewLine + //
            "2. Smoothly contoured, painted rocket with shaped fins, with minor external protrusions such as lugs, fin brackets or screw heads, use Cd = 0.40" + Environment.NewLine + //
            "3. Basic rocket with sharp changes in contour and with external protrusions, use Cd = 0.45 to 0.50.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dead mass is the total mass of the rocket without propellant");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The average thrust can be calculated from total impulse divided by burn time");
        }

        private double g = 9.80665;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (totalimpulse.Text == String.Empty)
                {
                    MessageBox.Show("Please enter total impulse");
                }
                else if (averagethrust.Text == String.Empty)
                {
                    MessageBox.Show("Please enter average thrust");
                }
                else if (deadmass.Text == String.Empty)
                {
                    MessageBox.Show("Please enter dead mass");
                }
                else if (propmass.Text == String.Empty)
                {
                    MessageBox.Show("Please enter propellant mass");
                }
                else if (drag.Text == string.Empty && airresistance.Checked)
                {
                    MessageBox.Show("Please enter drag coefficient");
                }
                else if (diameter.Text == string.Empty && airresistance.Checked)
                {
                    MessageBox.Show("Please enter diameter");
                }
                else //if everything is valid, continue
                {
                    calculate_height();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }

        void calculate_height()
        {
            try
            {
                //maths
                double totalimpulse = double.Parse(this.totalimpulse.Text);
                double averagethrust = double.Parse(this.averagethrust.Text);
                double deadmass = double.Parse(this.deadmass.Text);
                double propmass = double.Parse(this.propmass.Text);
                double burntime = totalimpulse / averagethrust;
                double averagemass = deadmass + (0.5 * propmass);
                double burnoutalt = 0.5 * ((averagethrust / averagemass) - g) * Math.Pow(burntime, 2);
                double burnoutvelocity = Math.Sqrt((2 * (burnoutalt) / averagemass) * (averagethrust - (averagemass * g)));
                double peakaltitude = ((averagethrust * burnoutalt) / (averagemass * g));
                double timetoapogee = burntime + Math.Sqrt((2 / g) * (peakaltitude - burnoutalt));
                double averageacelleration = averagethrust / (averagemass * g);
                double maxacelleration = averagethrust / (deadmass * g);

                //MessageBox.Show(burnoutalt.ToString());
                //MessageBox.Show(burnoutvelocity.ToString());
                //MessageBox.Show(peakaltitude.ToString());
                //MessageBox.Show(timetoapogee.ToString());

                if (airresistance.Checked)
                {


                    try
                    {
                        
                        
                        double Cd = double.Parse(drag.Text);
                        double diameter = double.Parse(this.diameter.Text);

                        //MessageBox.Show(Cd.ToString());

                        double dragfactor = (Cd * (Math.Pow(diameter, 2)) * (Math.Pow(burnoutvelocity, 2))) / (1000 * deadmass);

                        //MessageBox.Show(((int)dragfactor).ToString());

                        //stolen from https://stackovrflow.com/questions/2705542/returning-the-nearest-multiple-value-of-a-number
                        int value = (int)dragfactor;
                        int factor = 20;
                        int nearestMultiple =
                            (int)Math.Round(
                           (value / (double)factor),
                                MidpointRounding.ToZero
                            ) * factor;

                        //stolen from https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
                        var path = "drag.csv"; // todo: interpolate in between values to increase resolution
                        using (TextFieldParser csvParser = new TextFieldParser(path))
                        {

                            csvParser.CommentTokens = new string[] { "#" };
                            csvParser.SetDelimiters(new string[] { "," });
                            csvParser.HasFieldsEnclosedInQuotes = false;

                            // Skip the row with the column names
                            csvParser.ReadLine();
                            List<string> drag = new List<string>();
                            List<string> burnoutCd = new List<string>();
                            List<string> velocityCd = new List<string>();
                            List<string> peaktimeCd = new List<string>();
                            List<string> peakaltCd = new List<string>();

                            while (!csvParser.EndOfData)
                            {
                                // Read current line fields, pointer moves to the next line.
                                string[] fields = csvParser.ReadFields();
                                drag.Add(fields[0]);
                                burnoutCd.Add(fields[1]);
                                velocityCd.Add(fields[2]);
                                peaktimeCd.Add(fields[3]);
                                peakaltCd.Add(fields[4]);
                            }


                            int index = drag.IndexOf(nearestMultiple.ToString());
                            //MessageBox.Show(index.ToString());
                            //drag.Find(x => x.Equals(nearestMultiple));
                            //MessageBox.Show(drag[2]);

                            //get and apply drag factors

                            //MessageBox.Show(burnoutCd[index]);

                            double burnoutf = burnoutalt * double.Parse(burnoutCd[index]); //there must be a better way to do this
                            double velocityf = burnoutvelocity * double.Parse(velocityCd[index]);
                            double peaktimef = timetoapogee * double.Parse(peaktimeCd[index]);
                            double peakaltf = peakaltitude * double.Parse(peakaltCd[index]);

                            this.peakaltitude.Text = peakaltf.ToString();
                            burnout.Text = burnoutf.ToString();
                            maxvelocity.Text = velocityf.ToString();
                            apogeetime.Text = peaktimef.ToString();

                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error with air resistance calculations");
                        MessageBox.Show(e.ToString());
                        //throw;
                    }

                }
                else
                {
                    this.peakaltitude.Text = peakaltitude.ToString();
                    burnout.Text = burnoutalt.ToString();
                    maxvelocity.Text = burnoutvelocity.ToString();
                    apogeetime.Text = timetoapogee.ToString();
                }
                thrusttime.Text = burntime.ToString();
                this.maxacelleration.Text = maxacelleration.ToString();
                this.averageacelleration.Text = averageacelleration.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if the link is clicked, open denneth.nl in the default browser and display it as visited
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://denneth.nl");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "denneth.nl"; // update to writeup when done with writeup
            MessageBox.Show("Made by Denneth Ahles, using visual studio 2019 with windows forms" + Environment.NewLine + //
                            "Calculations are from richard nakka's 'Simplified method for estimating the flight performance of a hobby rocket' Document" + Environment.NewLine + //
                            "Results are estimates and not garanteed to be correct, for more information, visit " + url);
        }
    }
}
/* code graveyard
 *                         MessageBox.Show(RoundUp((int)dragfactor).ToString());

                        //stolen from https://stackoverflow.com/questions/15154457/rounding-integers-to-nearest-multiple-of-10?noredirect=1&lq=1

                        public static int Round(int n)
                        {
                            // Smaller multiple 
                            int a = (n / 10) * 10;

                            // Larger multiple 
                            int b = a + 10;

                            // Return of closest of two 
                            return (n - a > b - n) ? b : a;
                        }

                        int RoundUp(int value)
                        {
                            return factor * ((value + 9) / factor);
                        }

                        int RoundDown(int value)
                        {
                            return factor * (value / factor);
                        }
                        MessageBox.Show((value / (double) factor).ToString());
                        MessageBox.Show(nearestMultiple.ToString());
*/