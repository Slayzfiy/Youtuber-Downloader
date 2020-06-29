using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PlayerUI
{
    class Preferences
    {
        private string preference_path, user_path;
        public Preferences()
        {
            this.user_path = User_Path();
            this.preference_path = Preference_Path();  
           
        }

        public string User_Path()
        {
            string user_path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                user_path = Directory.GetParent(user_path).ToString();
            }
            return user_path;
        }
        public string Preference_Path()
        {
            string preference_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\muavi";
            string preference_path_xml = preference_path + @"\preferences.xml";

            if(Directory.Exists(preference_path) == false)
            {
                Directory.CreateDirectory(preference_path);
            }

            if (File.Exists(preference_path_xml) == false)
            {
                try
                {
                    new XDocument(new XElement("root", new XElement("download_path", user_path + @"\muavi"))).Save(preference_path_xml);
                }
                catch (UnauthorizedAccessException)
                {
                    throw;
                }
                
            }

            return preference_path_xml;        
        }

        public string Get_Download_Path()
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(preference_path);
                XmlNode node = xml.SelectSingleNode("root/download_path");
                return node.InnerText;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }         
        }

        public void Change_Download_Path(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(this.preference_path);
            XmlNode node = xml.SelectSingleNode("root/download_path");
            node.InnerText = path;
            xml.Save(preference_path);
        }
    }
}
