using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This will close the application when the File->Exit menu item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// This will show a box with the author information when the about menu item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Nathan for his education");
        }

        /// <summary>
        /// On click of this button the web control will display the page requested in the text box (by url)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        /// <summary>
        /// This function will cause the browser to navigate to the URL in the textBox1 control
        /// </summary>
        private void NavigateToPage()
        {
            toolStripStatusLabel1.Text = "Navigation has started";
            webBrowser1.Navigate(textBox1.Text);
            textBox1.Clear();
        }

       //This will Take you to the home page 

        private void GoHome()
        {
            webBrowser1.Navigate(textBox3.Text);
        }


        
        /// <summary>
        /// This function will start navigation by simulating a click on the navigate button when 'enter' is pressed when textbox1 is in focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the keystroke was enter then do something
            if( e.KeyChar == (char)ConsoleKey.Enter )
            {
                //NavigateToPage();
                button1_Click(null, null);
            }
        }

        /// <summary>
        /// When the webpage is finished loading this function will re-enable the disabled controls and indicate success
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Enable the controls that were disabled during navigation
            button1.Enabled = true;
            textBox1.Enabled = true;

            // Indicate loading is complete
            toolStripStatusLabel1.Text = "Navigation Complete";
            toolStripProgressBar1.ProgressBar.Value = 100;
        }

        /// <summary>
        /// This function will be called as the webpage loads multiple time to indicate the percentage complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            // Don't bother computing percentage if either variable is zero since it will cause a divide by zero error
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                // Calculate percentage
                int percentage =  (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                
                // If the percentage is > 100 it means additional processing was done on the page so we want to ignore it
                if( percentage <= 100)
                {
                    toolStripProgressBar1.ProgressBar.Value = percentage;
                }
            }
            else
            {
                // Set the percentage to zero if we can't compute it
                toolStripProgressBar1.ProgressBar.Value = 0;
            }
        }
        /// <summary>
        /// This code will run anytime the mouse enter's the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.BringToFront();
        }


        private void button3_Click_2(object sender, EventArgs e)
        {
            textBox2.SendToBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This programe was made by Nathan Beckett for his education and its in Version 0.0.200");
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the keystroke was ESC then do something
            if (e.KeyChar == (char)ConsoleKey.Escape)
            {
                //Send it back
                textBox2.SendToBack();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the keystroke was ESC then do something
            if (e.KeyChar == (char)ConsoleKey.Escape)
            {
                //Send it back
                textBox2.SendToBack();
            }
        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
         
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Downloading Simplicity, This version is 0.0.209 and if you would like to help the making of simplicity please send suggestions to beckett2002@hotmail.co.uk.  If you are looking to report bugs or need any help message SimplicityHelp@hotmail.com and report the problem");
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }


        }


    }


