using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace MailSender
{
    [DataContract]
    public class SystemConfiguration
    {
        //public string Name { get; set; }

        [DataMember]
        public List<SmtpInfo> Servers { get; set; }

        private static string ConfigurationFilePath
        {
            get { return Directory.GetCurrentDirectory() + @"\system.config"; }
        }

        public SystemConfiguration()
        {
            Servers = new List<SmtpInfo>();
        }

        public static SystemConfiguration LoadConfiguration()
        {
            var systemConfiguration = new SystemConfiguration();

            try
            {
                if (File.Exists(ConfigurationFilePath))
                {
                    using (var stream = new FileStream(ConfigurationFilePath, FileMode.Open, FileAccess.Read))
                    {
                        var serializer = new DataContractSerializer(typeof (SystemConfiguration),
                            new Type[] {typeof (List<SmtpInfo>), typeof (SmtpInfo)});

                        using(var xmlTextReader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
                        {
                            systemConfiguration = (SystemConfiguration) serializer.ReadObject(xmlTextReader, true);
                            xmlTextReader.Close();
                        }
                        
                        stream.Close();
                    }

                    foreach (var item in systemConfiguration.GetType().GetProperties())
                    {
                        string dateTimeFullName = new DateTime().GetType().FullName;

                        if (item.PropertyType.FullName == dateTimeFullName)
                        {
                            systemConfiguration.GetType().GetProperty(item.Name).SetValue(systemConfiguration, DateTime.Now, null);// = DateTime.Now;
                        }

                    }
                    if (systemConfiguration.Servers == null)
                    {
                        systemConfiguration.Servers = new List<SmtpInfo>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return systemConfiguration;
        }

        public static bool SaveConfiguration(SystemConfiguration configuration)
        {
            bool successfull = false;
            try
            {
                using (var stream = new FileStream(ConfigurationFilePath, FileMode.Create, FileAccess.Write))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof (SystemConfiguration),
                        new Type[] { typeof(List<SmtpInfo>), typeof(SmtpInfo) });

                    using (var xmlTextWriter = new XmlTextWriter(stream, Encoding.UTF8)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4
                    })
                    {
                        serializer.WriteObject(xmlTextWriter, configuration);
                        xmlTextWriter.Close();
                        successfull = true;
                    }
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                successfull = false;
            }
            return successfull;
        }
    }
}
