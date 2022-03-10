using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NationalInstruments.NI4882;
using System.Threading;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;

namespace HP4395A_Screen_Grabber
{
    public partial class Form1 : Form
    {
        //===========================================================================================================================================
        // Member variables
        //===========================================================================================================================================
        private const string TEMPFILE_NO_T = "\"TEMP1234\"";
        private const string TEMPFILE = "\"TEMP1234_T\"";
        private Device device;

        private bool paletteReadBusy = false;

        ShanuDGVHelper objshanudgvHelper = new ShanuDGVHelper();
        DataTable dtName = new DataTable();

        const string UNKNOWN = "";
        String[] palatteName = {
            "Background",       // 0
            UNKNOWN,            // 1
            "IBASIC",           // 2
            "Grid",             // 3
            "Error message",    // 4
            "Overlay trace 1",  // 5
            "Overlay trace 2",  // 6
            "Data/Trace CH1",   // 7
            "Memory trace CH1", // 8
            "Data/Trace CH2",   // 9
            "Overlay trace 3",  // 10
            "Overlay trace 3",  // 11
            "Overlay trace 5",  // 12
            "Memory trace CH2", // 13
            "Overlay trace 6",  // 14
            "Marker",           // 15
            };


        //===========================================================================================================================================
        // Form1
        //===========================================================================================================================================
        public Form1()
        {
            InitializeComponent();

            //dgvColors.Columns.Add("Index", "Index");
            //dgvColors.Columns.Add("Name", "Name");
            //dgvColors.Columns.Add("Color", "Color");


            Log("Started");
            
        }


        //===========================================================================================================================================
        // Form1 Load
        //===========================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            secondaryAddressComboBox.Items.Add("None");
            for (int i = 96; i <= 126; i++)
            {
                secondaryAddressComboBox.Items.Add(i);
            }
            secondaryAddressComboBox.SelectedIndex = 0;

            cbColor.SelectedIndex = 1;

            // to generate DGV with your coding
            generatedgvColumns();

            openButton_Click(null, null);
        }


        //===========================================================================================================================================
        // generatedgvColumns
        //   to generate DGV with your coding
        //===========================================================================================================================================
        public void generatedgvColumns()
        {
            //First generate the grid Layout Design
            ShanuDGVHelper.Layouts(dgvColors, Color.Silver, Color.Red, Color.Red, false, Color.LightGray, false, false, false);

            ShanuDGVHelper.Templatecolumn(dgvColors, ShanuControlTypes.TextBox, "Index", "Index", "Index", true, 50, DataGridViewTriState.True, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft, Color.White, null, "", "", Color.Black);
            ShanuDGVHelper.Templatecolumn(dgvColors, ShanuControlTypes.TextBox, "Name", "Name", "Name", true, 120, DataGridViewTriState.True, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft, Color.White, null, "", "", Color.Black);
            ShanuDGVHelper.Templatecolumn(dgvColors, ShanuControlTypes.Button, "Color", "ButtonCol", "Button  Column", true, 65, DataGridViewTriState.True, DataGridViewContentAlignment.MiddleLeft, DataGridViewContentAlignment.MiddleLeft, Color.Transparent, null, "", "", Color.Black);

            // Add Color Dialog to Button Column
            objshanudgvHelper.colorDialogEvents(dgvColors, dgvColors.Columns["Color"].Index, ShanuEventTypes.cellContentClick);
        }


        //===========================================================================================================================================
        // SetupControlState
        //===========================================================================================================================================
        private void SetupControlState(bool isSessionOpen)
        {
            boardIdNumericUpDown.Enabled = !isSessionOpen;
            primaryAddressNumericUpDown.Enabled = !isSessionOpen;
            secondaryAddressComboBox.Enabled = !isSessionOpen;
            openButton.Enabled = !isSessionOpen;
            closeButton.Enabled = isSessionOpen;
        }

        //===========================================================================================================================================
        // openButton_Click
        //   open the GPIB device
        //===========================================================================================================================================
        private void openButton_Click(object sender, EventArgs e)
        {
            Log("Open...");

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Convert the Secondary Address Combo Text into a number.
                int currentSecondaryAddress = 0;
                if (secondaryAddressComboBox.SelectedIndex != 0)
                {
                    currentSecondaryAddress = (int)secondaryAddressComboBox.SelectedItem;
                }
                // Intialize the device
                device = new Device((int)boardIdNumericUpDown.Value, (byte)primaryAddressNumericUpDown.Value, (byte)currentSecondaryAddress);
                SetupControlState(true);
                Log("Success!");
            }
            catch (Exception ex)
            {
                Log("  Failed: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        //===========================================================================================================================================
        // Log
        //===========================================================================================================================================
        public void Log(String msg)
        {
            txtLog.AppendText(msg + "\r\n");
        }

        //===========================================================================================================================================
        // closeButton_Click
        //   Close the GPIB device
        //===========================================================================================================================================
        private void closeButton_Click(object sender, EventArgs e)
        {
            Log("Close...");
            try
            {
                device.Dispose();
                SetupControlState(false);
                Log("Success!");
            }
            catch (Exception ex)
            {
                Log("  Failed:" + ex.Message);
            }

        }

        //===========================================================================================================================================
        // CaptureGraphics
        //===========================================================================================================================================
        private void CaptureGraphics()
        {
            Log("Capture started...");

            // Get the id
            String id = SendQuery("*idn?"); 
            if ( id.Length > 0)
            {
                Log("  id:" + id);
            }
            else
            {
                Log("  Could not get ID");
                return;
            }

            //make sure that there is no temp TIF file on the memory disk
            Log("  Purge old temp file");
            SendCommand("PURG " + TEMPFILE + "; *WAI");
            Log("  status:" + device.LastStatus);
            Thread.Sleep(50);

            //KEY 18 = "Entry Off" removes any error message from screen"
            //SendCommand("KEY 18");

            switch(cbColor.SelectedIndex)
            {
                case 0:
                    // Color on White Background
                    SendCommand("PRIC;PRICFIXE");
                    break;
                case 1:
                    // Color on Black Background
                    SendCommand("PRIC;PRICVARI");
                    break;
                case 2:
                    // Black/white
                    SendCommand("PRIS");
                    break;
            }

            SendCommand("STODMEMO");

            // save screen image to a temporary TIF file and wait until done...
            Log("  Save graphics to temp file");
            SendCommand("SAVDTIF " + TEMPFILE_NO_T + "; *WAI");
            Log("  status:" + device.LastStatus);
            Thread.Sleep(1500); //For fast GPIB card

            // open the temporary TIF file for Read... 
            Log("  Open the temp file for read");
            SendCommand("ROPEN " + TEMPFILE + "; *WAI");

            Log("  Read the temp file ");

            List<byte> dataList = new List<byte>();
            bool stop = false;

            while(!stop)
            {
                byte[] data = QueryBinaryData();
                if ( data == null)
                {
                    Log("Capture failed");
                    stop = true;
                }
                else if (data.Length == 0)
                {
                    Log("  Data reading done");
                    stop = true;
                }
                else
                {
                    dataList.AddRange(data);
                }
            }

            rbView_CheckChanged(null, null);

            // 'Stream' the data to the PictureBox 
            byte[] imageData = dataList.ToArray();
            Log("  Data size:" + imageData.Length);

            Stream stream = new MemoryStream(imageData);
            pictureBox1.Image = Image.FromStream(stream);

            // Copy direct to clipboard
            Clipboard.SetImage(pictureBox1.Image);
            Log("  Image is copied to clipboard!");
            
            //read the palette from the image
            ReadColorPalette();

            // goto local
            device.GoToLocal();

            Log("Done!");
        }


        //===========================================================================================================================================
        // btnCapture_Click
        //===========================================================================================================================================
        private void btnCapture_Click(object sender, EventArgs e)
        {
            CaptureGraphics();
        }

        //===========================================================================================================================================
        // ByteArrayToString
        //===========================================================================================================================================
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }


        //===========================================================================================================================================
        // ReplaceCommonEscapeSequences
        //===========================================================================================================================================
        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }


        //===========================================================================================================================================
        // InsertCommonEscapeSequences
        //===========================================================================================================================================
        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }


        //===========================================================================================================================================
        // SendCommand
        //===========================================================================================================================================
        private bool SendCommand(String msg)
        {
            bool result = false;
            try
            {
                device.Write(ReplaceCommonEscapeSequences(msg));
               
                result = true;
            }
            catch (Exception ex)
            {
                Log("SendCommand failed:" + ex.Message);
            }

            return result;
        }


        //===========================================================================================================================================
        // ReadResponse
        //===========================================================================================================================================
        private String ReadResponse()
        {
            String response = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                response = InsertCommonEscapeSequences(device.ReadString());
            }
            catch (Exception ex)
            {
                Log("ReadResponse failed:" + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return response;
        }


        //===========================================================================================================================================
        // QueryBinaryData
        //===========================================================================================================================================
        private byte[] QueryBinaryData()
        {
            if (!SendCommand("READ?"))
            {
                Log("ReadBinaryData: SenCommand READ? failed");
                return null;
            }

            byte[] data;
            try
            {
                data = device.ReadByteArray(8);

                if (data.Length != 8)
                {
                    Log("ReadBinaryData: read failed, " + data.Length + " bytes!");
                    return null;
                }

                // check header
                if ( data[0] != '#' || data[1] != '6')
                {
                    Log("ReadBinaryData: read failed, incorrect header!" );
                    return null;
                }

                // remaining 6bytes are the size
                byte[] sizeBytes = data.Skip(2).ToArray();
                string sizeString = System.Text.Encoding.Default.GetString(sizeBytes);
                Int32 size =  Convert.ToInt32(sizeString);

                if (size < 0)
                {
                    Log("ReadBinaryData: header contains invalid size");
                    return null;
                }

                if ( size==0)
                {
                    // ready
                    device.ReadByteArray(1); // there is still one /n to read!
                    return Array.Empty<byte>();
                }

                // read remaining data
                data = device.ReadByteArray(size + 1); //Read the trailing \n

                Array.Resize(ref data, size); // remove the last \n

                return data;

            }
            catch (Exception ex)
            {
                Log("ReadBinaryData: failed: " + ex.Message);
            }

            return null;
        }


        //===========================================================================================================================================
        // SendQuery
        //===========================================================================================================================================
        private String SendQuery(String msg)
        {
            String response = "";
            if ( SendCommand(msg) )
            {
                response = ReadResponse();
            }

            return response;
        }


        //===========================================================================================================================================
        // ReadColorPalette
        //   Reads the available colors from the Image and puts them in a DataGridView 
        //===========================================================================================================================================
        private void ReadColorPalette(bool NoNames = false)
        {
            paletteReadBusy = true;
            //Log("palette:");

            if (pictureBox1.Image == null)
            {
                Log("ReadColorPalette failed. No Image loaded");
                return;
            }

            dgvColors.Rows.Clear();
            int i = 0;
            foreach( Color color in pictureBox1.Image.Palette.Entries)
            {
               // Log("  " + color.ToString());

                int index = dgvColors.Rows.Add();

                dgvColors.Rows[index].Cells[0].Value = i.ToString();
                dgvColors.Rows[index].Cells[1].Value = NoNames ? "" : palatteName[i];
                dgvColors.Rows[index].Cells[2].Value = color.Name;

                dgvColors.Rows[index].Cells[2].Style.BackColor = color;

                i++;

            }
            paletteReadBusy = false;
        }


        //===========================================================================================================================================
        // dgvColors_CellValueChanged
        //   Update the Image if a color has changed by the user
        //===========================================================================================================================================
        private void dgvColors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!paletteReadBusy)
            {
                Log("Cell dgvColors_CellValueChanged:" + e.RowIndex);
                UpdateColorPalette();
                dgvColors.ClearSelection();
                if ( cbAutoCopy.Checked)
                {
                    btnCopyToClipboard_Click(null, null);
                }
            }
        }


        //===========================================================================================================================================
        // UpdateColorPalette
        //   Update the Image with the current colors
        //===========================================================================================================================================
        private void UpdateColorPalette()
        { 
            ColorPalette palet = pictureBox1.Image.Palette;
            foreach (DataGridViewRow row in dgvColors.Rows)
            {
                String indexString = row.Cells[0].Value.ToString();
                Int32 index = Convert.ToInt32(indexString);

                String color = row.Cells[2].Value.ToString();

                //int argb = Convert.ToInt32(color, 16);
                int argb = 0;
                Color c;
                if ( Int32.TryParse(color,System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out argb) )
                {
                    c = Color.FromArgb(argb);
                }
                else
                {
                    c = Color.FromName(color);
                }

                palet.Entries[index] = c;

            }

            pictureBox1.Image.Palette = palet;
            pictureBox1.Refresh();
        }


        //===========================================================================================================================================
        // rbView_CheckChanged
        //===========================================================================================================================================
        private void rbView_CheckChanged(object sender, EventArgs e)
        {
            if (rbFit.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (rbNormal.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }


        //===========================================================================================================================================
        // btnFileOpen_Click
        //  Open a file from disk
        //===========================================================================================================================================
        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            Log("Open file...");
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.TIF)|*.TIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            pictureBox1.Image = Image.FromStream(fs);
                            fs.Close();
                            ReadColorPalette();
                            Log("  File " + openFileDialog.FileName + " is opend successfull");
                        }

                    }
                    catch (Exception ex)
                    {
                        Log("  Open file failed: " + ex.Message);
                    }
                }
                else
                {
                    Log("  Open cancled");
                }
            }
            Log("Done.");
        }

        //===========================================================================================================================================
        // btnSave_Click
        //  Saves image to file on disk
        //===========================================================================================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            Log("Save file...");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "TIF (*.TIF)|*.TIF|BPM (*.BMP)|*.BMP|JPG (*.JPG)|*.JPG|PNG (*.PNG)|*.PNG";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Tiff;

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Tiff;
                        break;
                    case 2:
                        format = ImageFormat.Bmp;
                        break;
                    case 3:
                        format = ImageFormat.Jpeg;
                        break;
                    case 4:
                        format = ImageFormat.Png;
                        break;
                    default:
                        break;
                }
                try
                {
                    File.Delete(saveFileDialog1.FileName);
                    pictureBox1.Image.Save(saveFileDialog1.FileName, format);
                    Log("  File " + saveFileDialog1.FileName + " is saved successfull");
                }
                catch (Exception ex)
                {
                    Log("  Save file failed: " + ex.Message);
                }
            }
            else
            {
                Log("  Save cancled");
            }

            Log("Done.");
        }


        //===========================================================================================================================================
        // btnCopyToClipboard_Click
        //   Copies the Image to the Clipboard
        //===========================================================================================================================================
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetImage(pictureBox1.Image);
                Log("Image is copied to clipboard!");
            }
            catch (Exception ex)
            {
                Log("Clipboard copy failed: " + ex.Message);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = (Bitmap)Clipboard.GetImage();

                if (image != null)
                {
                    Rectangle cloneRect = new Rectangle(0, 0, image.Width, image.Height);
                    Bitmap clone = image.Clone(cloneRect, PixelFormat.Format4bppIndexed);

                    pictureBox1.Image = clone;

                    ReadColorPalette(true);
                    Log("Image is pasted from clipboard!");
                    Log("NOTE: Color index info is not pressend in pasted images!");
                }
                else
                {
                    Log("No Image data on clipboard to paste!");

                }
            }
            catch (Exception ex)
            {
                Log("Clipboard paste failed: " + ex.Message);
            }
        }
    }
}
