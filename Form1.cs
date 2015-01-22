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
        WebClient wc = new WebClient();
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
            MessageBox.Show("This program was made by Nathan Beckett for his education and its in Version 0.0.265");
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
            MessageBox.Show("Thanks for Downloading Simplicity, This version is 0.0.265 and if you would like to help the making of simplicity please send suggestions to SimplicityWebBrowser@hotmail.com  If you are looking to report bugs or need any help message SimplicityHelp@hotmail.com and report the problem");
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

        private void Theme1_Click(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button21.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();



            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button21.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();





            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();
            
        }

        private void Theme1_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button21.BringToFront();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();


            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
     
        }

       

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button21.BringToFront();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();


            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void Theme1_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button21.BringToFront();

            button16.BringToFront();

            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();

        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();

            button21.BringToFront();

            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();
      
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();

            button21.BringToFront();

            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();

        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();

            button21.BringToFront();

            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();

        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();

            button21.BringToFront();

            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();

        }

        private void button14_DragEnter(object sender, DragEventArgs e)
        {
            button12.BringToFront();

            button18.BringToFront();

            button17.BringToFront();

            button15.BringToFront();

            button14.BringToFront();

            button16.BringToFront();

            button21.BringToFront();

            button20.BringToFront();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();

        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
        
            button21.SendToBack();
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
    
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button21.SendToBack();

            button12.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        
        private void button12_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
            button3.BackColor = Color.DarkSlateGray;
            button4.BackColor = Color.DarkSlateGray;
            button5.BackColor = Color.DarkSlateGray;
            button6.BackColor = Color.DarkSlateGray;
            button7.BackColor = Color.DarkSlateGray;
            button8.BackColor = Color.DarkSlateGray;
            button9.BackColor = Color.DarkSlateGray;
            button10.BackColor = Color.DarkSlateGray;
            button12.BackColor = Color.DarkSlateGray;
            button13.BackColor = Color.DarkSlateGray;  // The Noted one's need to be un-noted when i make that button
            button14.BackColor = Color.DarkSlateGray;
            button15.BackColor = Color.DarkSlateGray;
            button16.BackColor = Color.DarkSlateGray;
            button17.BackColor = Color.DarkSlateGray;
            button18.BackColor = Color.DarkSlateGray;
           button19.BackColor = Color.DarkSlateGray;
            button20.BackColor = Color.DarkSlateGray;
            Theme1.BackColor = Color.DarkSlateGray;
            button21.BackColor = Color.DarkSlateGray;

            button1.BackColor = Color.DarkSlateGray;

            button1.BackColor = Color.DarkSlateGray;

            button20.BackColor = Color.DarkSlateGray;
            button13.BackColor = Color.DarkSlateGray;
            button11.BackColor = Color.DarkSlateGray;
            button22.BackColor = Color.DarkSlateGray;
            button23.BackColor = Color.DarkSlateGray;
            button24.BackColor = Color.DarkSlateGray;


            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Maroon;
            button3.BackColor = Color.Maroon;
            button4.BackColor = Color.Maroon;
            button5.BackColor = Color.Maroon;
            button6.BackColor = Color.Maroon;
            button7.BackColor = Color.Maroon;
            button8.BackColor = Color.Maroon;
            button9.BackColor = Color.Maroon;
            button10.BackColor = Color.Maroon;
            button12.BackColor = Color.Maroon;
            button13.BackColor = Color.Maroon;   //The Noted one's need to be un-noted when i make that button
            button14.BackColor = Color.Maroon;
            button15.BackColor = Color.Maroon;
            button16.BackColor = Color.Maroon;
            button17.BackColor = Color.Maroon;
            button18.BackColor = Color.Maroon;
             button19.BackColor = Color.Maroon;
             button20.BackColor = Color.Maroon;
            Theme1.BackColor = Color.Maroon;
            button21.BackColor = Color.Maroon;
            button21.BackColor = Color.Maroon;
            button20.BackColor = Color.Maroon;
            button13.BackColor = Color.Maroon;
            button11.BackColor = Color.Maroon;
            button22.BackColor = Color.Maroon;
            button23.BackColor = Color.Maroon;
            button24.BackColor = Color.Maroon;


            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
            button3.BackColor = Color.DarkGreen;
            button4.BackColor = Color.DarkGreen;
            button5.BackColor = Color.DarkGreen;
            button6.BackColor = Color.DarkGreen;
            button7.BackColor = Color.DarkGreen;
            button8.BackColor = Color.DarkGreen;
            button9.BackColor = Color.DarkGreen;
            button10.BackColor = Color.DarkGreen;
            button12.BackColor = Color.DarkGreen;
            button13.BackColor = Color.DarkGreen;   //The Noted one's need to be un-noted when i make that button
            button14.BackColor = Color.DarkGreen;
            button15.BackColor = Color.DarkGreen;
            button16.BackColor = Color.DarkGreen;
            button17.BackColor = Color.DarkGreen;
            button18.BackColor = Color.DarkGreen;
             button19.BackColor = Color.DarkGreen;
             button20.BackColor = Color.DarkGreen;
            Theme1.BackColor = Color.DarkGreen;
            button21.BackColor = Color.DarkGreen;
            button21.BackColor = Color.DarkGreen;
            button20.BackColor = Color.DarkGreen;
            button13.BackColor = Color.DarkGreen;
            button11.BackColor = Color.DarkGreen;
            button22.BackColor = Color.DarkGreen;
            button23.BackColor = Color.DarkGreen;
            button24.BackColor = Color.DarkGreen;


            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void Theme1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Theme1_MouseClick(object sender, MouseEventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
            button3.BackColor = Color.Purple;
            button4.BackColor = Color.Purple;
            button5.BackColor = Color.Purple;
            button6.BackColor = Color.Purple;
            button7.BackColor = Color.Purple;
            button8.BackColor = Color.Purple;
            button9.BackColor = Color.Purple;
            button10.BackColor = Color.Purple;
            button12.BackColor = Color.Purple;
            button13.BackColor = Color.Purple;   //The Noted one's need to be un-noted when i make that button
            button14.BackColor = Color.Purple;
            button15.BackColor = Color.Purple;
            button16.BackColor = Color.Purple;
            button17.BackColor = Color.Purple;
            button18.BackColor = Color.Purple;
            button19.BackColor = Color.Purple;
            button20.BackColor = Color.Purple;
            Theme1.BackColor = Color.Purple;
            button21.BackColor = Color.Purple;
            button21.BackColor = Color.Purple;
            button20.BackColor = Color.Purple;
            button13.BackColor = Color.Purple;
            button11.BackColor = Color.Purple;
            button22.BackColor = Color.Purple;
            button23.BackColor = Color.Purple;
            button24.BackColor = Color.Purple;


            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();


        }

        private void button15_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
            button4.BackColor = Color.Orange;
            button5.BackColor = Color.Orange;
            button6.BackColor = Color.Orange;
            button7.BackColor = Color.Orange;
            button8.BackColor = Color.Orange;
            button9.BackColor = Color.Orange;
            button10.BackColor = Color.Orange;
            button12.BackColor = Color.Orange;
            button13.BackColor = Color.Orange;  // The Noted one's need to be un-noted when i make that button
            button14.BackColor = Color.Orange;
            button15.BackColor = Color.Orange;
            button16.BackColor = Color.Orange;
            button17.BackColor = Color.Orange;
            button18.BackColor = Color.Orange;
            button20.BackColor = Color.Orange;
            Theme1.BackColor = Color.Orange;
            button19.BackColor = Color.Orange;
            button21.BackColor = Color.Orange;
            button21.BackColor = Color.Orange;
            button20.BackColor = Color.Orange;
            button13.BackColor = Color.Orange;
            button11.BackColor = Color.Orange;
            button22.BackColor = Color.Orange;
            button23.BackColor = Color.Orange;
            button24.BackColor = Color.Orange;




            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Teal;
            button3.BackColor = Color.Teal;
            button4.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;
            button6.BackColor = Color.Teal;
            button7.BackColor = Color.Teal;
            button8.BackColor = Color.Teal;
            button9.BackColor = Color.Teal;
            button10.BackColor = Color.Teal;
            button12.BackColor = Color.Teal;
            button13.BackColor = Color.Teal;   //The Noted one's need to be un-noted when i make that button
            button14.BackColor = Color.Teal;
            button15.BackColor = Color.Teal;
            button16.BackColor = Color.Teal;
            button17.BackColor = Color.Teal;
            button18.BackColor = Color.Teal;
            button19.BackColor = Color.Teal;
            button20.BackColor = Color.Teal;
            Theme1.BackColor = Color.Teal;
            button21.BackColor = Color.Teal;
            button20.BackColor = Color.Teal;
            button13.BackColor = Color.Teal;
            button11.BackColor = Color.Teal;
            button22.BackColor = Color.Teal;
            button23.BackColor = Color.Teal;
            button24.BackColor = Color.Teal;
   


            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();

            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
    
        }

        private void button19_Click(object sender, EventArgs e)
        {

            button20.SendToBack();
            button13.BringToFront();
            button11.BringToFront();
            button22.BringToFront();
            button23.BringToFront();
            button24.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

    ////    private void button11_Click_(object sender, EventArgs e)
    //    {
    //        this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
    //        button12.SendToBack();
    //        button20.SendToBack();
    //        button13.SendToBack();
    //        button11.SendToBack();
    //    button21.SendToBack();
    //    }

        private void button20_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://bing.com", System.UriKind.Absolute);
            button12.SendToBack();
            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button21.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
                    button12.SendToBack();
                    button20.SendToBack();
                    button13.SendToBack();
                    button11.SendToBack();
                button21.SendToBack();
                button22.SendToBack();
                button23.SendToBack();
                button24.SendToBack();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button18.SendToBack();

            button17.SendToBack();

            button15.SendToBack();

            button14.SendToBack();

            button16.SendToBack();

            button12.SendToBack();

            button21.SendToBack();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://twitter.com", System.UriKind.Absolute);
            button12.SendToBack();
            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button21.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://facebook.com", System.UriKind.Absolute);
            button12.SendToBack();
            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button21.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://youtube.com", System.UriKind.Absolute);
            button12.SendToBack();
            button20.SendToBack();
            button13.SendToBack();
            button11.SendToBack();
            button21.SendToBack();
            button22.SendToBack();
            button23.SendToBack();
            button24.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
           
        }

        private void button26_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            Uri imageurl = new Uri(textBox1_url.Text);
            wc.DownloadFileAsync(imageurl, ".png");
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        private void imageDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.BringToFront();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            groupBox1.SendToBack();
        }

        }


    }


