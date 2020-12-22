using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Threading;


namespace Project
{
    public partial class Form1 : Form
    {
        // Global variables
        const string KEY_PATH = "path";
        const string HTML_OUTPUT = "outputFormat";
        const string EXCEL_KEY_HEADER= "header";
        const string COMBOBOX_EXCEL = "Excel";
        const string COMBOBOX_XML = "XML";
        const string COMBOBOX_HTML = "HTML";
        const string COMBOBOX_REST_API = "Rest API";

        public Form1()
        {
            InitializeComponent();
            // on FORM start
            comboBoxInput.Items.Add(COMBOBOX_EXCEL);
            comboBoxInput.Items.Add(COMBOBOX_XML);
            comboBoxInput.Items.Add(COMBOBOX_REST_API);
            comboBoxInput.SelectedIndex = 0;

            comboBoxOutput.Items.Add(COMBOBOX_HTML);
            comboBoxOutput.Items.Add(COMBOBOX_REST_API);
            comboBoxOutput.SelectedIndex = 0;

            radioButtonDiv.Checked = true;

            // define position of columns in lisvView "Data Flow"
            listView1.Columns[0].DisplayIndex = 0;
            listView1.Columns[1].DisplayIndex = 1;
            listView1.Columns[2].DisplayIndex = 2;
            listView1.Columns[3].DisplayIndex = 3;
            listView1.Columns[4].DisplayIndex = 4;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void comboBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch (cb.SelectedIndex)
            {
                case 0:
                    textBoxOutputRestAPIUrl.Visible = false;
                    radioButtonDiv.Visible = true;
                    radioButtonTable.Visible = true;
                    labelInfoFiles.Visible = true;
                    break;
                case 1:
                    textBoxOutputRestAPIUrl.Visible = true;
                    radioButtonDiv.Visible = false;
                    radioButtonTable.Visible = false;
                    labelInfoFiles.Visible = false;
                    break;
                default:
                    break;
            }
            
        }

        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch (cb.SelectedIndex)
            {
                case 0:
                    excelFields(true);
                    buttonXml.Visible = false;
                    textBoxPathFile.Visible = true;
                    textBoxInputRestApi.Visible = false;
                    break;
                case 1:
                    excelFields(false);
                    textBoxPathFile.Visible = true;
                    buttonXml.Visible = true;
                    textBoxInputRestApi.Visible = false;
                    break;
                case 2:
                    excelFields(false);
                    textBoxPathFile.Visible = false;
                    buttonXml.Visible = false;
                    textBoxInputRestApi.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void excelFields(bool v)
        {
            buttonExcelOpen.Visible = v;
            //checkBoxcheckBoxExcelHeaderHorizontal.Visible = v;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate if list is empty 
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No presets found.");
                return;
            }
            progressBarLoading.Visible = true;
            buttonStop.Visible = true;

            if (buttonConvertNow.Text == "Exit")
            {
                this.Close();
            }

            if (buttonConvertNow.Text == "Pause")
            {
                buttonConvertNow.Text = "Contiunue";
                timer1.Stop();
            }
            else
            {
                buttonConvertNow.Text = "Pause";
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOutputRestAPI_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOutputRestApi_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcelOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Excel files (*.xlsx, *.xlsm, *.csv) | *.xlsx; *.xlsm; *.csv;";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPathFile.Text = openFileDialog1.FileName;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBoxExcelPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPathFile.Text = openFileDialog1.FileName;
            }
        }

        private void textBoxInputRestApi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAddPreset_Click(object sender, EventArgs e)
        {
            string errors = "";
            List<JSON> inputJson = new List<JSON>();
            List<JSON> outputJson = new List<JSON>();
            // Input Values
            switch (comboBoxInput.SelectedIndex)
            {
                case 0: // EXCEL 
                    if (textBoxPathFile.Text == "") errors+="Selecione um ficheiro.\n";
                    // file path
                    inputJson.Add(new JSON
                    {
                        Key = KEY_PATH,
                        Value = textBoxPathFile.Text
                    });
                    // header
                    inputJson.Add(new JSON
                    {
                        Key = EXCEL_KEY_HEADER,
                        Value = "0" //checkBoxcheckBoxExcelHeaderHorizontal.Checked.ToString()
                    });

                    break;
                case 1: // XML
                    inputJson.Add(new JSON
                    {
                        Key = KEY_PATH,
                        Value = textBoxPathFile.Text
                    });
                    break;
                case 2: // REST API
                    if (validInputRestAPi(textBoxInputRestApi.Text)) errors+="Url do input Inválido.\n";
                    
                    inputJson.Add(new JSON
                    {
                        Key = COMBOBOX_REST_API,
                        Value = textBoxInputRestApi.Text
                    });
                    break;
                default:
                    break;
            }
            // Output Values
            switch (comboBoxOutput.SelectedIndex)
            {
                case 0: // HTML 
                    String v = "0"; // default div
                    if (radioButtonTable.Checked)
                        v = "1";

                    outputJson.Add(new JSON
                    {
                        Key = HTML_OUTPUT,
                        Value = v
                    });
                    break;
                case 1:  // REST API
                    if (validInputRestAPi(textBoxOutputRestAPIUrl.Text)) errors += "Url do output Inválido.\n";

                    outputJson.Add(new JSON
                    {
                        Key = "url",
                        Value = textBoxOutputRestAPIUrl.Text
                    });
                    break;
                default:
                    break;
            }
            if (errors.Length != 0)
            {
                MessageBox.Show(errors);
                return;
            }


            // INPUT | OUTPUT | input Params | Output Params
            string[] row = { 
                listView1.Items.Count.ToString(),
                comboBoxInput.SelectedItem.ToString(),
                comboBoxOutput.SelectedItem.ToString(),
                JsonConvert.SerializeObject(inputJson),
                JsonConvert.SerializeObject(outputJson)
            };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            buttonCleanAll.Visible = true;
        }

        public bool validInputRestAPi(string url)
        {
            APICalls api = new APICalls();

            if (!api.isValidUrl(url))
            {
                return true;
            }

            return false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TestFunction_Click(object sender, EventArgs e)
        {
            APICalls api = new APICalls();
            
            MessageBox.Show(api.GetFromApi(textBoxPathFile.Text));

        }

        /*private void checkBoxcheckBoxExcelHeaderHorizontal_CheckedChanged(object sender, EventArgs e)
        {

        }*/

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBarLoading_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonImportReset_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "json files (*.json)|*.json";

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Error File");
                return;
            }

            string path = openFileDialog1.FileName;
            //get data json from file

            var json = File.ReadAllText(path);
            JArray jsonResponse = JArray.Parse(json);

            foreach (var item in jsonResponse)
            {
                string[] row1 = { item["Input"].Value<string>(),
                    item["Output"].Value<string>(),
                    item["Input_Params"].Value<string>(),
                    item["Output_Params"].Value<string>()
                };
                listView1.Items.Add(item["#"].Value<string>()).SubItems.AddRange(row1);
            }
        }

        private void buttoneExportPreset_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("#", typeof(Int32));
            dt.Columns.Add("Input", typeof(string));
            dt.Columns.Add("Output", typeof(string));
            dt.Columns.Add("Input_Params", typeof(string));
            dt.Columns.Add("Output_Params", typeof(string));
            foreach (ListViewItem item in listView1.Items)
            {
                dt.Rows.Add(item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    item.SubItems[3].Text,
                    item.SubItems[4].Text);
            }
            string JSONString = JsonConvert.SerializeObject(dt);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            System.IO.File.WriteAllText(path + "/DataConverterExportedFlow.json", JSONString);
            MessageBox.Show("Exported successfully");
        }

        private void textBoxOutputRestAPIUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            progressBarLoading.Value = 0;
            buttonConvertNow.Text = "Convert Now";
            buttonCleanAll.Visible = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        int i, j = 0;
        int column_format_In = 1; // Type of Input
        int column_format_out = 2; // Type of Output
        int col_in_params = 3; // Which as Input Params
        int col_out_params = 4; // Which as Output Params
        string result = "";
        string resultOutput = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            /*int column_format_In = 1; // Type of Input
            int column_format_out = 2; // Type of Output
            int col_in_params = 3; // Which as Input Params
            int col_out_params = 4; // Which as Output Params
            string result = "";
            string resultOutput = "";
            int i;
            int j = 0;*/
            listView1.Invoke(new Action(() =>
            {
                int progressBarIncrementvalue = (100*j)/ listView1.Items.Count;
                ListViewItem item = listView1.Items[j];
                //foreach (ListViewItem item in listView1.Items)
                //{
                    string val_listView_input = item.SubItems[column_format_In].Text;
                    string val_listView_output = item.SubItems[column_format_out].Text;
                    string val_listView_input_params = item.SubItems[col_in_params].Text;
                    string val_listView_output_params = item.SubItems[col_out_params].Text;
                    var inputJson = JsonConvert.DeserializeObject<List<JSON>>(val_listView_input_params);
                    var outputJson = JsonConvert.DeserializeObject<List<JSON>>(val_listView_output_params);
                    i = listView2.Items.Count;
                    progressBarLoading.Value = 0;

                    // TODO - verify is empty value from KEY & VALUE
                    var inputURL = "";
                    var outputURL = "";
                    string path = "";
                    switch (val_listView_input)
                    {
                        case COMBOBOX_EXCEL:
                        // GET input values 

                        try
                        {
                            bool h = false;
                            if (inputJson.Find(x => x.Key == KEY_PATH) != null)
                                path = inputJson.Find(x => x.Key == KEY_PATH).Value;

                            if (inputJson.Find(x => x.Key == EXCEL_KEY_HEADER) != null)
                                h = true;

                            // CONVERT data to JSON
                            ExcelFunctions ex = new ExcelFunctions();
                            result = ex.ExcelToJson(@path, h);
                        }
                        catch (Exception) { result = "Error While getting Excel data."; }
                            
                            break;
                        case COMBOBOX_XML:
                            if (inputJson.Find(x => x.Key == KEY_PATH) != null)
                                path = inputJson.Find(x => x.Key == KEY_PATH).Value;

                            try
                            {
                            XmlDocument doc = new XmlDocument();
                            doc.Load(@path);

                            // Converting XML to JSON
                            //doc..FirstChild.NextSibling -- remove XML declaration from converted Json
                            string json = JsonConvert.SerializeXmlNode(doc.FirstChild.NextSibling);
                            result = Regex.Replace(json, "\"(\\d+)\"", "$1");
                             }catch(Exception){
                                result = "Directory not Found.";
                            }

                            break;
                        case COMBOBOX_REST_API:
                            try
                            {
                                using (WebDownload wc = new WebDownload())
                                {
                                    string url = "";
                                    if (inputJson.Find(x => x.Key == COMBOBOX_REST_API) != null)
                                        url = inputJson.Find(x => x.Key == COMBOBOX_REST_API).Value;
                                        //string url = item.SubItems[3] .Text.ToString();
                                    result = wc.DownloadString(url);
                                }
                            }
                            catch (Exception) { result = ""; }
                            break;
                        default:
                            break;
                    }
                    // Output Values
                    switch (val_listView_output)
                    {
                        case COMBOBOX_HTML:
                        try
                        {
                            var type_result = 0;
                            // Convert Data
                            if (outputJson.Find(x => x.Key == HTML_OUTPUT) != null)
                                type_result = Convert.ToInt32(outputJson.Find(x => x.Key == HTML_OUTPUT).Value);
                            AppFucntions p = new AppFucntions();
                            resultOutput = p.DataToHtml(i, result, type_result);
                        }
                        catch (Exception) { resultOutput = "Error while output to HTML."; }
                            break;
                        case COMBOBOX_REST_API:
                        try
                        {
                            APICalls apiCalls = new APICalls();
                            inputURL = inputJson[0].Value;
                            outputURL = outputJson[0].Value;
                            resultOutput = apiCalls.JsonToApi(outputURL, result);
                        }
                        catch (Exception) { resultOutput = "Error while sending data to Rest API."; }
                            break;
                        default:
                            break;
                    }

                    // Print data in the "results"  (Add to List View result)
                    // resultOutput
                    // # | Result
                    string[] row = {
                        i.ToString(),
                        resultOutput
                    };
                    var listViewItem = new ListViewItem(row);
                    listView2.Items.Add(listViewItem);

                    progressBarLoading.Increment(progressBarIncrementvalue += progressBarIncrementvalue);
                    i++;
                    j++;
                    
                //}
            }));
            if (j >= listView1.Items.Count)
            {
                reiniciar();
            }
        }

        private void reiniciar()
        {
            buttonConvertNow.Text = "Exit";
            timer1.Stop();
            /*******************************************/
            i = 0;
            j = 0;
            column_format_In = 1; // Type of Input
            column_format_out = 2; // Type of Output
            col_in_params = 3; // Which as Input Params
            col_out_params = 4; // Which as Output Params
            result = "";
            resultOutput = "";
            buttonStop.Visible = false;
        }
    }
}
