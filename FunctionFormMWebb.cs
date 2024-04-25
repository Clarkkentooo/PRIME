using PRIME_FINAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = ReaLTaiizor.Controls.CyberButton;

namespace PRIME3
{
    public partial class FunctionFormMWebb : Form
    {
        private Form currentBookingFormGD;
        private Dictionary<Button, string> buttonTextMap = new Dictionary<Button, string>();
        private HashSet<string> clickedButtonTexts = new HashSet<string>();
        public static FunctionFormMWebb instance2;
        public System.Windows.Forms.Panel paneldesk;
        public FunctionFormMWebb()
        {
            InitializeComponent();
            instance2 = this;

            goBack.ForeColor = Color.FromArgb(84, 84, 84);              //Color of the Go Back Button
            sidebarAccess2.ForeColor = Color.FromArgb(84, 84, 84);      //Color of the Upper Left Button
            sidebarAccess2.Click += sidebarAccess1_Click;
            ticketInfoPanel.Visible = false;
            breakDownList.Visible = false;
            panel44.Visible = false;
            receiptHeader.Visible = false;
            ReceiptPanel.Visible = false;
            paymentPanel.Visible = false;
            panel145.Visible = false;

            sidebarAccess2.MouseEnter += sidebarAccess1_MouseEnter;
            sidebarAccess2.MouseLeave += sidebarAccess1_MouseLeave;
            goBack.MouseEnter += goBack_MouseEnter;
            goBack.MouseLeave += goBack_MouseLeave;
            goBack.Click += label39_Click;

            add2CartText1.MouseEnter += label5_MouseEnter;
            add2CartText1.MouseLeave += label5_MouseLeave;
            add2CartText1.Click += add2CartText1_Click;
            starSign.Click += StarSign_Click;

            BookButton.Click += BookButton_Click;

            selectTheater.SelectedIndexChanged += selectTheater_SelectedIndexChanged;
            selectDate.SelectedIndexChanged += selectDate_SelectedIndexChanged;

            timeBttn1.Click += timeBttn1_Click;
            timeBttn2.Click += timeBttn2_Click;
            timeBttn3.Click += timeBttn3_Click;
            timeBttn4.Click += timeBttn4_Click;
            timeBttn5.Click += timeBttn5_Click;
            timeBttn6.Click += timeBttn6_Click;

            buttonTextMap.Add(a1Bttn, "A1");
            buttonTextMap.Add(a2Bttn, "A2");
            buttonTextMap.Add(a3Bttn, "A3");
            buttonTextMap.Add(a4Bttn, "A4");
            buttonTextMap.Add(a5Bttn, "A5");
            buttonTextMap.Add(a6Bttn, "A6");
            buttonTextMap.Add(a7Bttn, "A7");
            buttonTextMap.Add(a8Bttn, "A8");
            buttonTextMap.Add(a9Bttn, "A9");
            buttonTextMap.Add(a0Bttn, "A0");

            buttonTextMap.Add(b1Bttn, "B1");
            buttonTextMap.Add(b2Bttn, "B2");
            buttonTextMap.Add(b3Bttn, "B3");
            buttonTextMap.Add(b4Bttn, "B4");
            buttonTextMap.Add(b5Bttn, "B5");
            buttonTextMap.Add(b6Bttn, "B6");
            buttonTextMap.Add(b7Bttn, "B7");
            buttonTextMap.Add(b8Bttn, "B8");
            buttonTextMap.Add(b9Bttn, "B9");
            buttonTextMap.Add(b0Bttn, "B0");

            buttonTextMap.Add(c1Bttn, "C1");
            buttonTextMap.Add(c2Bttn, "C2");
            buttonTextMap.Add(c3Bttn, "C3");
            buttonTextMap.Add(c4Bttn, "C4");
            buttonTextMap.Add(c5Bttn, "C5");
            buttonTextMap.Add(c6Bttn, "C6");
            buttonTextMap.Add(c7Bttn, "C7");
            buttonTextMap.Add(c8Bttn, "C8");
            buttonTextMap.Add(c9Bttn, "C9");
            buttonTextMap.Add(c0Bttn, "C0");

            buttonTextMap.Add(d1Bttn, "D1");
            buttonTextMap.Add(d2Bttn, "D2");
            buttonTextMap.Add(d3Bttn, "D3");
            buttonTextMap.Add(d4Bttn, "D4");
            buttonTextMap.Add(d5Bttn, "D5");
            buttonTextMap.Add(d6Bttn, "D6");
            buttonTextMap.Add(d7Bttn, "D7");
            buttonTextMap.Add(d8Bttn, "D8");
            buttonTextMap.Add(d9Bttn, "D9");
            buttonTextMap.Add(d0Bttn, "D0");

            buttonTextMap.Add(e1Bttn, "E1");
            buttonTextMap.Add(e2Bttn, "E2");
            buttonTextMap.Add(e3Bttn, "E3");
            buttonTextMap.Add(e4Bttn, "E4");
            buttonTextMap.Add(e5Bttn, "E5");
            buttonTextMap.Add(e6Bttn, "E6");
            buttonTextMap.Add(e7Bttn, "E7");
            buttonTextMap.Add(e8Bttn, "E8");
            buttonTextMap.Add(e9Bttn, "E9");
            buttonTextMap.Add(e0Bttn, "E0");

            buttonTextMap.Add(f1Bttn, "F1");
            buttonTextMap.Add(f2Bttn, "F2");
            buttonTextMap.Add(f3Bttn, "F3");
            buttonTextMap.Add(f4Bttn, "F4");
            buttonTextMap.Add(f5Bttn, "F5");
            buttonTextMap.Add(f6Bttn, "F6");
            buttonTextMap.Add(f7Bttn, "F7");
            buttonTextMap.Add(f8Bttn, "F8");
            buttonTextMap.Add(f9Bttn, "F9");
            buttonTextMap.Add(f0Bttn, "F0");

            buttonTextMap.Add(g1Bttn, "G1");
            buttonTextMap.Add(g2Bttn, "G2");
            buttonTextMap.Add(g3Bttn, "G3");
            buttonTextMap.Add(g4Bttn, "G4");
            buttonTextMap.Add(g5Bttn, "G5");
            buttonTextMap.Add(g6Bttn, "G6");
            buttonTextMap.Add(g7Bttn, "G7");
            buttonTextMap.Add(g8Bttn, "G8");
            buttonTextMap.Add(g9Bttn, "G9");
            buttonTextMap.Add(g0Bttn, "G0");

            foreach (var button in buttonTextMap.Keys)
            {
                button.Click += Button_Click;
            }
            proceedPayBttn.Click += proceedPayBttn_Click;

            gCash1.Click += gCash_Click;
            BdoUnibank1.Click += BdoUnibank_Click;
            maya1.Click += maya_Click;
            payNowBttn.Click += payNowBttn_Click;
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            add2CartText1.Font = new Font(add2CartText1.Font, FontStyle.Underline);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            add2CartText1.Font = new Font(add2CartText1.Font, FontStyle.Regular);
        }

        private void sidebarAccess1_MouseEnter(object sender, EventArgs e)
        {
            sidebarAccess2.ForeColor = Color.FromArgb(205, 205, 205);
        }

        private void sidebarAccess1_MouseLeave(object sender, EventArgs e)
        {
            sidebarAccess2.ForeColor = Color.FromArgb(84, 84, 84);
        }
        private void goBack_MouseEnter(object sender, EventArgs e)
        {
            goBack.ForeColor = Color.FromArgb(205, 205, 205);
        }

        private void goBack_MouseLeave(object sender, EventArgs e)
        {
            goBack.ForeColor = Color.FromArgb(84, 84, 84);
        }


        private void StarSign_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label; //Casting the Sender to a Label
            if (clickedLabel != null)
            {
                //Check the Text Star property of the clicked label.
                if (clickedLabel.Text == "☆")
                {
                    clickedLabel.Text = "★";
                    clickedLabel.ForeColor = Color.FromArgb(222, 156, 27);  //Color when clicked
                }
                else
                {
                    clickedLabel.Text = "☆";
                    clickedLabel.ForeColor = Color.FromArgb(205, 205, 205); //Default Color
                }
            }
        }
        private void sidebarAccess1_Click(object sender, EventArgs e)
        {
            Home.instance.paneldesk.Visible = false;

        }
        private void BookButton_Click(object sender, EventArgs e)
        {
            ticketInfoPanel.Visible = true;
            breakDownList.Visible = true;
        }
        private void selectTheater_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLocation.Text = selectTheater.SelectedItem.ToString();
            locationReceipt.Text = selectTheater.SelectedItem.ToString();
        }

        private void selectDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDate.Text = selectDate.SelectedItem.ToString();
            dateReceipt.Text = selectDate.SelectedItem.ToString();
        }

        private void timeBttn1_Click(object sender, EventArgs e)
        {
            labelTime.Text = "12:00 PM - 1:30 PM";
            timeReceipt.Text = "12:00 PM - 1:30 PM";
        }
        private void timeBttn2_Click(object sender, EventArgs e)
        {
            labelTime.Text = "2:00 PM - 3:30 PM";
            timeReceipt.Text = "2:00 PM - 3:30 PM";
        }
        private void timeBttn3_Click(object sender, EventArgs e)
        {
            labelTime.Text = "4:00 PM - 5:30 PM";
            timeReceipt.Text = "4:00 PM - 5:30 PM";
        }
        private void timeBttn4_Click(object sender, EventArgs e)
        {
            labelTime.Text = "6:00 PM - 7:30 PM";
            timeReceipt.Text = "6:00 PM - 7:30 PM";
        }
        private void timeBttn5_Click(object sender, EventArgs e)
        {
            labelTime.Text = "8:00 PM - 9:30 PM";
            timeReceipt.Text = "8:00 PM - 9:30 PM";
        }
        private void timeBttn6_Click(object sender, EventArgs e)
        {
            labelTime.Text = "10:00 PM - 11:30 PM";
            timeReceipt.Text = "10:00 PM - 11:30 PM";
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = buttonTextMap[clickedButton];

            // Toggle the visibility of the text
            if (clickedButtonTexts.Contains(buttonText))
            {
                clickedButtonTexts.Remove(buttonText);
            }
            else
            {
                clickedButtonTexts.Add(buttonText);
            }
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            // Update SeatNo label with the clicked button texts
            seatNumber.Text = string.Join(", ", clickedButtonTexts);
            SeatNo.Text = string.Join(", ", clickedButtonTexts);
            seatNoReceipt.Text = string.Join(", ", clickedButtonTexts);

            // Update ticketNum label with the count of clicked buttons
            ticketNum.Text = clickedButtonTexts.Count.ToString();
            totTicketsReceipt.Text = clickedButtonTexts.Count.ToString();
            totTicketsMOP.Text = clickedButtonTexts.Count.ToString();
            // Total Amount
            totalAmount.Text = (clickedButtonTexts.Count * 440).ToString();
            totAmountReceipt.Text = (clickedButtonTexts.Count * 440).ToString();
        }

        private void proceedPayBttn_Click(object sender, EventArgs e)
        {
            ticketInfoPanel.Visible = false;
            breakDownList.Visible = false;
            receiptHeader.Visible = true;
            paymentPanel.Visible = true;
            panel145.Visible = true;
        }
        private void proceedPayBttn_MouseEnter(object sender, EventArgs e)
        {
            proceedPayBttn.ForeColor = Color.FromArgb(205, 205, 205);
        }
        private void proceedPayBttn_MouseLeave(object sender, EventArgs e)
        {
            proceedPayBttn.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void payNowBttn_Click(object sender, EventArgs e)
        {
            panel44.Visible = true;
            ReceiptPanel.Visible = true;
            mainReceipt.Visible = true;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            paymentPanel.Visible = false;
            ticketInfoPanel.Visible = true;
            breakDownList.Visible = true;
        }

        private void gCash_Click(object sender, EventArgs e)
        {
            mopChoice.Image = gCash1.Image;
            mopReceipt.Image = gCash1.Image;

        }

        private void BdoUnibank_Click(object sender, EventArgs e)
        {
            mopChoice.Image = BdoUnibank1.Image;
            mopReceipt.Image = BdoUnibank1.Image;
        }

        private void maya_Click(object sender, EventArgs e)
        {
            mopChoice.Image = maya1.Image;
            mopReceipt.Image = maya1.Image;
        }

        private void add2CartText1_Click(object sender, EventArgs e)
        {
            if (Home.instance != null)
            {
                Home.instance.addtoCartImage.Image = Properties.Resources.cartMWeb;
                Home.instance.addtoCartImage.Visible = true;
            }
        }
    }
}
