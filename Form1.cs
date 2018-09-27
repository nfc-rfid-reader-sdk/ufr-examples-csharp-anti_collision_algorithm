/*
 * uFR Nano Anti Collision
 *
 * library version: 4.3.14
 *
 * Created on:  2018-09-25
 * 
 * Author: Aleksandar Krstic (aleksandar.krstic@d-logic.rs)
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
using uFrAdvance;

namespace UFR
{
    using DL_STATUS = System.UInt32;

    public partial class Form1 : Form
    {
        DL_STATUS status;
        byte TempCardsNumber = 0;
        byte[] TempUid = new byte[10];
        byte[] TempData = new byte[16];
        byte TempUidSize = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        public static byte[] ToByteArray(String HexString)
        {
 
            int NumberChars = HexString.Length;
            byte[] bytes = new byte[NumberChars / 2];

            if (HexString.Length % 2 != 0)
            {
                return bytes;
            }

                for (int i = 0; i < NumberChars; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
                }

            return bytes;
        }

        //DLOGIC CARD TYPE
        const byte DL_MIFARE_ULTRALIGHT = 0x01,
                   DL_MIFARE_ULTRALIGHT_EV1_11 = 0x02,
                   DL_MIFARE_ULTRALIGHT_EV1_21 = 0x03,
                   DL_MIFARE_ULTRALIGHT_C = 0x04,
                   DL_NTAG_203 = 0x05,
                   DL_NTAG_210 = 0x06,
                   DL_NTAG_212 = 0x07,
                   DL_NTAG_213 = 0x08,
                   DL_NTAG_215 = 0x09,
                   DL_NTAG_216 = 0x0A,
                   DL_MIFARE_MINI = 0x20,
                   DL_MIFARE_CLASSIC_1K = 0x21,
                   DL_MIFARE_CLASSIC_4K = 0x22,
                   DL_MIFARE_PLUS_S_2K = 0x23,
                   DL_MIFARE_PLUS_S_4K = 0x24,
                   DL_MIFARE_PLUS_X_2K = 0x25,
                   DL_MIFARE_PLUS_X_4K = 0x26,
                   DL_MIFARE_DESFIRE = 0x27,
                   DL_MIFARE_DESFIRE_EV1_2K = 0x28,
                   DL_MIFARE_DESFIRE_EV1_4K = 0x29,
                   DL_MIFARE_DESFIRE_EV1_8K = 0x2A;

        String GetDlTypeName(byte dl_type_code)
        {
            String s;

            switch (dl_type_code)
            {
                case DL_MIFARE_ULTRALIGHT:
                    s = "DL_MIFARE_ULTRALIGHT";
                    break;
                case DL_MIFARE_ULTRALIGHT_EV1_11:
                    s = "DL_MIFARE_ULTRALIGHT_EV1_11";
                    break;
                case DL_MIFARE_ULTRALIGHT_EV1_21:
                    s = "DL_MIFARE_ULTRALIGHT_EV1_21";
                    break;
                case DL_MIFARE_ULTRALIGHT_C:
                    s = "DL_MIFARE_ULTRALIGHT_C";
                    break;
                case DL_NTAG_203:
                    s = "DL_NTAG_203";
                    break;
                case DL_NTAG_210:
                    s = "DL_NTAG_210";
                    break;
                case DL_NTAG_212:
                    s = "DL_NTAG_212";
                    break;
                case DL_NTAG_213:
                    s = "DL_NTAG_213";
                    break;
                case DL_NTAG_215:
                    s = "DL_NTAG_215";
                    break;
                case DL_NTAG_216:
                    s = "DL_NTAG_216";
                    break;

                case DL_MIFARE_MINI:
                    s = "DL_MIFARE_MINI";
                    break;
                case DL_MIFARE_CLASSIC_1K:
                    s = "DL_MIFARE_CLASSIC_1K";
                    break;
                case DL_MIFARE_CLASSIC_4K:
                    s = "DL_MIFARE_CLASSIC_4K";
                    break;

                case DL_MIFARE_DESFIRE:
                    s = "DL_MIFARE_DESFIRE";
                    break;
                case DL_MIFARE_DESFIRE_EV1_2K:
                    s = "DL_MIFARE_DESFIRE_EV1_2K";
                    break;
                case DL_MIFARE_DESFIRE_EV1_4K:
                    s = "DL_MIFARE_DESFIRE_EV1_4K";
                    break;
                case DL_MIFARE_DESFIRE_EV1_8K:
                    s = "DL_MIFARE_DESFIRE_EV1_8K";
                    break;


                default:
                    s = "UNSUPPORTED CARD";
                    break;
            }

            return s;
        }

        public static string ByteArrayToString(byte[] ba, byte start, byte end)
        {
            String hex = null;
        
            for (byte i = start; i < end; i++)
            {
                hex += ba[i].ToString("X2") + " ";
                
            }
            return hex;
        }

        private void bReaderOpen_Click(object sender, EventArgs e)
        {
            ReaderTextBox.Clear();
            byte[] SerialDescription = new byte[8];
            byte VerMajor = 0;
            byte VerMinor = 0;
            byte BuildNum = 0;
            ulong reader_type;

            status = uFCoder.ReaderOpen();

            if (status == 0)
            {
                uFCoder.ReaderUISignal(1, 1);
                ReaderTextBox.AppendText("===================================== READER INFO ======================================");
                ReaderTextBox.AppendText("\nSerial number : ");
                uFCoder.GetReaderSerialDescription(SerialDescription);
                ReaderTextBox.AppendText(System.Text.Encoding.ASCII.GetString(SerialDescription));

                unsafe
                {
                    uFCoder.GetReaderType(&reader_type);
                    ReaderTextBox.AppendText("\nReader type : " + string.Format("{0:X}", reader_type));
                    uFCoder.GetReaderFirmwareVersion(&VerMajor, &VerMinor);
                    uFCoder.GetBuildNumber(&BuildNum);
                    ReaderTextBox.AppendText("\nFirmware version : " + VerMajor.ToString() + '.' + VerMinor.ToString() + '.' + BuildNum.ToString());
                    uFCoder.GetReaderHardwareVersion(&VerMajor, &VerMinor);
                    ReaderTextBox.AppendText("\nHardware version : " + VerMajor.ToString() + '.' + VerMinor.ToString());
                    
                }

                ReaderTextBox.AppendText("\n========================================================================================");

            }
            else
            {
                MessageBox.Show("Error while opening reader!");
            }
        }

        private void bReaderReset_Click(object sender, EventArgs e)
        {
            status = uFCoder.ReaderReset();

            if(status > 0)
            {
                MessageBox.Show("Error while trying to reset reader!");
            }
        }

        private void bReaderClose_Click(object sender, EventArgs e)
        {
            status = uFCoder.ReaderClose();

            if (status > 0)
            {
                MessageBox.Show("Error while trying to close reader!");
            }
        }

        private void bEnableAntiColl_Click(object sender, EventArgs e)
        {
            status = uFCoder.EnableAntiCollision();

            if (status > 0)
            {
                MessageBox.Show("Anti collision not enabled!");
            }
        }

        private void bDisableAntiColl_Click(object sender, EventArgs e)
        {
            status = uFCoder.DisableAntiCollision();

            if (status > 0)
            {
                MessageBox.Show("Anti collision not disabled!");
            }
        }

        private void bEnumCards_Click(object sender, EventArgs e)
        {
            EnumTextBox.Clear();
            CardComboBox.Items.Clear();
            BlockDataTextBox.Clear();
            SelectedCardTextBox.Text = "Card not selected";
            TempCardsNumber = 0;
            byte CardsNumber = 0;
            byte ListSize = 0;
            byte index = 0;
            byte[] list = new byte[44];

            unsafe
            {

                status = uFCoder.EnumCards(&CardsNumber, &ListSize);

                TempCardsNumber = CardsNumber;

                if (status == 0)
                {
                    EnumTextBox.AppendText("There is " + CardsNumber.ToString() + " card(s) in the reader field.");

                if (CardsNumber > 0)
                {
                    status = uFCoder.ListCards(list, ListSize);

                    if (status != 0)
                    {
                        MessageBox.Show("Unable to enumerate cards!");

                    }
                    else
                    {

                        index = 0;
                        EnumTextBox.AppendText("\n\nUid list of the cards in the reader field:\n");


                        for (byte i = 0; i < CardsNumber; i++)
                        {
                           
                            EnumTextBox.AppendText("\n" + (i + 1).ToString() + ". ");

                            EnumTextBox.AppendText(ByteArrayToString(list, (byte)(index + 1), (byte)(list[index] + index + 1)));

                            index += 11;

                            CardComboBox.Items.Add((i + 1).ToString());

                        }

                        CardComboBox.SelectedIndex = CardComboBox.Items.IndexOf("1");
                    }

                    TempUid = list.ToArray();
                 }
                  

               }
               else
               {
                    MessageBox.Show("Error while trying to enumerate cards!");
               }
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            unsafe
            {
                byte CardType = 0;
                byte[] SelectedUid = new byte[10];
                String selected_str = null;
                byte selected = 0;

                try
                {

                     selected_str = CardComboBox.SelectedItem.ToString();

                }
                catch (Exception)
                {

                }

                try
                {

                     selected = byte.Parse(selected_str);

                }
                catch (System.ArgumentNullException)
                {
                    MessageBox.Show("Nothing to select!");
                }

                if(selected == 1)
                {
                    Array.Copy(TempUid, 1, SelectedUid, 0, TempUid[0]);
                    TempUidSize = TempUid[0];

                }else if(selected == 2)
                {
                    Array.Copy(TempUid, 12, SelectedUid, 0, TempUid[11]);
                    TempUidSize = TempUid[11];
                }
                else if (selected == 3)
                {
                    Array.Copy(TempUid, 23, SelectedUid, 0, TempUid[22]);
                    TempUidSize = TempUid[22];
                }
                else if (selected == 4)
                {
                    Array.Copy(TempUid, 34, SelectedUid, 0, TempUid[33]);
                    TempUidSize = TempUid[33];
                }

                byte[] Uid = new byte[TempUidSize];

                Array.Copy(SelectedUid, 0, Uid, 0, TempUidSize);

                status = uFCoder.SelectCard(Uid, TempUidSize, &CardType);

                if(status == 0)
                {
                    SelectedCardTextBox.Text = "Selected UID : [" + BitConverter.ToString(Uid).Replace("-",":") + "] " + ",uid size : [" + TempUidSize.ToString() + " bytes]\n" + "Card type : [" + GetDlTypeName(CardType) + "]";
                }
            }
            
        }

        private void bDeselect_Click(object sender, EventArgs e)
        {
            status = uFCoder.DeselectCard();

            if(status != 0)
            {
                MessageBox.Show("Error while trying to deselect card!");
            }
            else
            {
                SelectedCardTextBox.Text = "Card not selected";
            }
        }

        private void bReadBlock_Click(object sender, EventArgs e)
        {
            BlockDataTextBox.Clear();
            String address_str = blockAddressTextBox.Text;
            String key_str = Byte1TB.Text + Byte2TB.Text + Byte3TB.Text + Byte4TB.Text + Byte5TB.Text + Byte6TB.Text;
            byte auth_mode = 0;
            byte[] Data = new byte[16];
            byte[] key = new byte[6];

            UInt16 block_address = UInt16.Parse(address_str);

            if(radioButtonAKey.Checked == true)
            {
                 auth_mode = 0x60;

            }else if(radioButtonBKey.Checked == true)
            {
                 auth_mode = 0x61;
            }

            key = ToByteArray(key_str);

            status = uFCoder.BlockRead_PK(Data, block_address, auth_mode, key);

            Array.Copy(Data, 0, TempData, 0, 16);

            if (status == 0)
            {
                BlockDataTextBox.SelectionAlignment = HorizontalAlignment.Center;

                if (RBHexadecimal.Checked == true)
                {

                    BlockDataTextBox.Text = BitConverter.ToString(Data).Replace("-", ":");

                }else if(RBDecimal.Checked == true)
                {
                    String decimal_data = null;
                    for (int i = 0; i < 16; i++)
                    {
                        decimal_data += ((int)Data[i]).ToString() + ":";     
                    }
                    decimal_data = decimal_data.Substring(0, decimal_data.Length - 1);
                    BlockDataTextBox.Text = decimal_data;

                }else if(RBAscii.Checked == true)
                {
                    String ascii = null;
                    for (byte i = 0; i < 16; i++)
                    {
                        if (Data[i] < 20 || Data[i] > 128)
                        {
                            ascii += ".";
                        }
                        else
                        {
                            ascii += ((char)Data[i]).ToString();
                        }
                    }

                    BlockDataTextBox.Text = ascii;
                }
            }
            else
            {
                MessageBox.Show("Unable to read block " + address_str);
            }
        }

        private void RBHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            BlockDataTextBox.SelectionAlignment = HorizontalAlignment.Center;

            if (TempCardsNumber == 0)
            {
                BlockDataTextBox.Clear();
            }
            else
            {
                BlockDataTextBox.Text = BitConverter.ToString(TempData).Replace("-", ":");
            }
        }

        private void RBAscii_CheckedChanged(object sender, EventArgs e)
        {
            BlockDataTextBox.SelectionAlignment = HorizontalAlignment.Center;

            if (TempCardsNumber == 0)
            {
                BlockDataTextBox.Clear();
            }
            else
            {
                String ascii = null;
                for(byte i = 0; i < 16; i++)
                {
                    if (TempData[i] < 20 || TempData[i] > 128)
                    {
                        ascii += ".";
                    }
                    else
                    {
                        ascii += ((char)TempData[i]).ToString();
                    }
                }
               
                BlockDataTextBox.Text = ascii;
            }
        }

        private void RBDecimal_CheckedChanged(object sender, EventArgs e)
        {
            BlockDataTextBox.SelectionAlignment = HorizontalAlignment.Center;

            if (TempCardsNumber == 0)
            {
                BlockDataTextBox.Clear();
            }
            else
            {

                String decimal_data = null;
                for (int i = 0; i < 16; i++)
                {
                    decimal_data += ((int)TempData[i]).ToString() + ":";
                }
                decimal_data = decimal_data.Substring(0, decimal_data.Length - 1);
                BlockDataTextBox.Text = decimal_data;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.d-logic.net/nfc-rfid-reader-sdk/");
        }
    }
}
