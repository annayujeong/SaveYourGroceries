using OpenQA.Selenium.DevTools.V108.Debugger;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// This class represents the Toggle button created in a separate User Control Class file.
/// Functionality of the button includes the UI appearance when button is toggled on or off. 
/// Also has the public boolean value Check that is tied to any conditional statements that we attached
/// to it, specifically whether the user will receive search results from a grocery store of their choice. 
/// 
/// </summary>

namespace SaveYourGroceriesLib
{
 
    public partial class Toggle : UserControl
    {
        public Toggle()
        {
            InitializeComponent();
        }

        enum eAppearance { on, off, onSelect, offSelect}

        eAppearance appearance = eAppearance.off;

        eAppearance Appearance
        {
            get { return appearance; }
            set { appearance = value;
                onChangeAppearance();
            }

        }



        /// <summary>
        /// Boolean check that upon designation will set the appearance of the toggle button 
        /// </summary>
        bool check;

        public bool Check
        {
            get { return check; }
            set { check = value;
                setAppearance();
            }
                
        }

        /// <summary>
        /// Method that upon designation will set the appearance of the toggle button 
        /// </summary>
        public void ChangeValue()
        {
            Check = !check;
        }

        /// <summary>
        /// Method that references the Toggle Button Resources that lists the various states of the Toggle button 
        /// </summary>
        void onChangeAppearance()
        {
            switch (appearance)
            {
                case eAppearance.on:
                    this.BackgroundImage = Properties.Resources.ToggleButtonOn;                
                    this.BorderStyle = BorderStyle.None;
                    break;
                case eAppearance.off:
                    this.BackgroundImage = Properties.Resources.ToggleButtonOff;
                    this.BorderStyle = BorderStyle.None;
                    break;

                case eAppearance.onSelect:
                    this.BackgroundImage = Properties.Resources.ToggleButtonOn;
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case eAppearance.offSelect:
                    this.BackgroundImage = Properties.Resources.ToggleButtonOff;
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;

            }
        }

        /// <summary>
        /// Sets the appearance of the toggle buttton based on the condition 
        /// </summary>
        void setAppearance()
        {

        if (this.Focused)
        {
            if (check)
                Appearance = eAppearance.onSelect;
            else
                Appearance = eAppearance.offSelect;
        }
        else
        {
            if (check)
                Appearance = eAppearance.on;
            else
              Appearance = eAppearance.off;
        }

        }
        /// <summary>
        /// Toggle_Click is the main method that activates the conditions once a given Toggle button is 
        /// clicked. Changes the buttons value and activates the conditions that come with the toggle button state 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toggle_Click(Object sender, EventArgs e) 
        { 
            ChangeValue();
        }

        private void Toggle_KeysDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                ChangeValue();
        }
    }
}
























