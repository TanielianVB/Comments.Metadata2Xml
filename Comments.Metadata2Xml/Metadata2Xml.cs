using System;
using System.Linq;
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
            try
            {
                string xml = "";

                var groups = _rtbMetadata.Text.ReplacePattern(@" *\/\/ ?", "").Trim('\n').Split(@"\n\n(?=[A-Z])");

                foreach (var group in groups)
                {
                    if (group.StartsWith("Summary"))
                    {
                        var summary = group.Substring("Summary:".Length).Split('\n').Where(s => !s.IsNullOrWhiteSpace()).Select(s => s.Trim(' ')).Join(" ");
                        xml += "/// <summary>\n/// " + summary + "\n/// </summary>\n";
                    }
                    else if (group.StartsWith("Parameters"))
                    {
                        var parametersTexts = group.Substring("Parameters:\n".Length).Split("\n\n").Where(s => !s.IsNullOrWhiteSpace()).Select(s => s.Trim(' '));
                        var parameters = parametersTexts.Select(s => s.Split(":\n"))
                            .Select(p => new
                            {
                                Name = p[0].Trim(' ', ':'),
                                Description = p[1].Trim(' ').Split('\n').Select(t => t.Trim(' ')).Join(" ")
                            });
                        xml += parameters.Select(p => "/// <param name=\"" + p.Name + "\">" + p.Description + "</param>").Join("\n") + "\n";
                    }
                    else if (group.StartsWith("Returns"))
                    {
                        var returns = group.Substring("Returns:".Length).Split('\n').Where(s => !s.IsNullOrWhiteSpace()).Select(s => s.Trim(' ')).Join(" ");
                        xml += "/// <returns>" + returns + "</returns>\n";
                    }
                    else if (group.StartsWith("Exceptions"))
                    {
                        var exceptionsTexts = group.Substring("Exceptions:\n".Length).Split("\n\n").Where(s => !s.IsNullOrWhiteSpace()).Select(s => s.Trim(' '));
                        var exceptions = exceptionsTexts.Select(s => s.Split(":\n"))
                            .Select(p => new
                            {
                                Type = p[0].Trim(' ', ':').Substring(2),
                                Description = p[1].Trim(' ').Split('\n').Select(t => t.Trim(' ')).Join(" ").Trim(' ')
                            });
                        xml += exceptions.Select(p => "/// <exception cref=\"" + p.Type + "\">" + p.Description + "</exception>").Join("\n") + "\n";
                    }
                }

                _rtbXML.Text = xml.Trim('\n');
            }
            catch (Exception)
            {
                _rtbXML.Text = "Could not parse the text.";
            }
        }

        private void _rtbMetadata_TextChanged(object sender, EventArgs e) => ConvertMetadata2Xml();
    }
}
