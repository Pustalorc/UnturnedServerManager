using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class XMLEditor : Form
    {
        internal XmlDocument XmlDocument = new XmlDocument();
        
        public XMLEditor(string ServerPath)
        {
            InitializeComponent();

            // Get XML File
            OpenXMLFile.InitialDirectory = ServerPath;
            var result = OpenXMLFile.ShowDialog();
            if (result != DialogResult.OK)
                CloseAsync();
            else
                LoadXMLFile(OpenXMLFile.OpenFile());
        }

        public void LoadXMLFile(Stream File)
        {
            try
            {
                XmlDocument.Load(File);
                LoadPrimaryTags();
            }
            catch (Exception)
            {
                Close();
            }
        }
        public void LoadPrimaryTags()
        {
            foreach (XmlNode node in XmlDocument.ChildNodes)
            {
                if (!node.Name.Equals("xml", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (XmlNode cNode in node.ChildNodes)
                    {
                        comboBox1.Items.Add(cNode.Name);
                    }
                }
            }
        }
        public async void CloseAsync()
        {
            Hide();
            await Task.Delay(1000);
            Close();
        }
    }
}
