﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SuperExtensions;

namespace Comments.Metadata2Xml
{
    public partial class Metadata2Xml : Form
    {
        public Metadata2Xml()
        {
            InitializeComponent();
        }

        private void ConvertMetadata2Xml()
        {
            string xml = "";

            var groups = Regex.Split(Regex.Replace(_rtbMetadata.Text, @" *\/\/ ?", "").Trim('\n'), @"\n\n(?=[A-Z])");

            foreach (var group in groups)
            {
                if (group.StartsWith("Summary"))
                {
                    var summary = group.Substring("Summary:".Length).Split('\n').Where(s => !s.IsNullOrWhiteSpace()).Select(s => s.Trim(' ')).Join(" ");
                    xml += "/// <summary>\n/// " + summary + "\n/// </summary>\n";
                }
                else if (group.StartsWith("Parameters"))
                {

                }
                else if (group.StartsWith("Returns"))
                {

                }
                else if (group.StartsWith("Exceptions"))
                {

                }
            }

            _rtbXML.Text = xml.Trim('\n');
        }

        private void _rtbMetadata_TextChanged(object sender, EventArgs e) => ConvertMetadata2Xml();
    }
}
