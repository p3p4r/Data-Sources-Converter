
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Data;
using System.Xml.Linq;

namespace Project
{
    class AppFucntions
    {
        // div = 0 | table = 1 
        public string DataToHtml(int iteration, string json, int formatType)
        {
            //json = '[{"country":"China","population":1379510000},{"country":"India","population":1330780000},{"country":"United States","population":324788000}]';
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "/DataConverter";

            if (!Directory.Exists(path)) // if not exists
            {
                // Try to create the directory.
                Directory.CreateDirectory(path);
            }
            string content = @"<html>";
            if (formatType == 1)
            {

                content += "<style>th, td, p, input{font:14px Verdana;}table, th, td{border: solid 1px #DDD; border-collapse: collapse; padding: 2px 3px; text-align: center;}th{font-weight:bold;}</style>";
                content += "<body><p id='showData'></p>";
                content += @"<script>var json = [" + json + "];";
                content += "json = JSON.stringify(json);" +
                    "json = JSON.parse(json); var col=[]; " +
                    "for (var i=0; i < json.length; i++){" +
                    "for (var key in json[i]){if (col.indexOf(key)===-1){" +
                    "col.push(key);}}} var table=document.createElement('table');" +
                    " var tr=table.insertRow(-1); " +
                    "for (var i=0; i < col.length; i++){" +
                    "var th=document.createElement('th');  " +
                    "th.innerHTML=col[i]; tr.appendChild(th);} for (var i=0; i < json.length; i++){tr=table.insertRow(-1); for (var j=0; j < col.length; j++){var tabCell=tr.insertCell(-1); tabCell.innerHTML=json[i][col[j]];}} var divContainer=document.getElementById('showData'); divContainer.innerHTML=''; divContainer.appendChild(table); </script>";


                /*content += "<style> th, td, p, input{ font: 14px Verdana; } table, th, td{border: solid 1px #DDD; border-collapse: collapse; padding: 2px 3px; text-align: center;}th{font-weight:bold;}</style><body><p id='showData'></p><script>var json =";
                content += json;
                content += "json = JSON.stringify(json); json = JSON.parse(json); var col =[]; for (var i = 0; i < json.length; i++) {for (var key in json[i]) { if (col.indexOf(key) === -1) { col.push(key); } } }";
                content += "var table = document.createElement('table'); var tr = table.insertRow(-1); for (var i = 0; i < col.length; i++) { var th = document.createElement('th'); th.innerHTML = col[i]; tr.appendChild(th); }";
                content += "for (var i = 0; i < json.length; i++) { tr = table.insertRow(-1); for (var j = 0; j < col.length; j++) { var tabCell = tr.insertCell(-1); tabCell.innerHTML = json[i][col[j]]; } }";
                content += "var divContainer = document.getElementById('showData'); divContainer.innerHTML = ''; divContainer.appendChild(table); </ script >";
            */
            }
            else
            {
                var x = JsonConvert.SerializeObject(json, Formatting.Indented);

                content += "<body>";
                content += "<div>";
                content += "<pre id = 'json'></pre>";
                content += "</div>";
                content += @"<script> document.getElementById('json').innerHTML = JSON.stringify("+json+",null,'\t')</script>";


                //MessageBox.Show(x);

            } 
            content += " </body></html>";

            System.IO.File.WriteAllText(path + "/result_" + iteration +"_"+DateTime.Now.ToString(@"MM_dd_yyyy_h_mm") + ".htm", content);
            return path;
        }

    }
}
