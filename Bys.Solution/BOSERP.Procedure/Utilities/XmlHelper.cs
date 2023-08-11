using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;



namespace HeiswayiNrird.Utility.Common
{

    public static class XmlHelper
    {
        public static string ObjectToXml(object obj)
        {
            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                Encoding = Encoding.GetEncoding("UTF-8")
            };

            var namespaces = new XmlSerializerNamespaces();
            //namespaces.Add("Invoices", "http://schemas.xmlsoap.org/soap/envelope/");
            //namespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");

            var serializer = new XmlSerializer(obj.GetType());

            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, obj, namespaces);
                }
                return stringWriter.ToString();
            }
        }

        public static T XmlToObject<T>(string xmlText) where T : new()
        {
            T xmlObject = new T();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            StringReader stringReader = new StringReader(xmlText);

            xmlObject = (T)xmlSerializer.Deserialize(stringReader);

            return xmlObject;
        }

        public static string StripXmlWhitespace(string xml)
        {
            Regex Parser = new Regex(@">\s*<");
            String singleLineXml = Parser.Replace(xml, "><");
            singleLineXml = singleLineXml.Replace("\r\n", " ");
            singleLineXml = singleLineXml.Replace("CInvoices", "Invoices");
            singleLineXml = singleLineXml.Replace("HashInv", "Invoices");
            singleLineXml = singleLineXml.Replace("PublicInv", "Invoices");
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            singleLineXml = regex.Replace(singleLineXml, " ");

            return singleLineXml.Trim();
        }



        /// <summary>

        /// Serialize a serializable object to XML string.

        /// </summary>

        /// <typeparam name="T">Type of object</typeparam>

        /// <param name="xmlObject">Type of object</param>

        /// <param name="useNamespaces">Use of XML namespaces</param>

        /// <returns>XML string</returns>

        public static string SerializeToXmlString<T>(T xmlObject, bool useNamespaces)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            MemoryStream memoryStream = new MemoryStream();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;


            xmlTextWriter.Settings.OmitXmlDeclaration = true;

            if (useNamespaces)
            {

                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add("Invoices", "http://schemas.xmlsoap.org/soap/envelope/");
                xmlSerializerNamespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");

                xmlSerializer.Serialize(xmlTextWriter, xmlObject, xmlSerializerNamespaces);

            }

            else

                xmlSerializer.Serialize(xmlTextWriter, xmlObject);



            string output = Encoding.UTF8.GetString(memoryStream.ToArray());

            string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());

            if (output.StartsWith(_byteOrderMarkUtf8))
            {

                output = output.Remove(0, _byteOrderMarkUtf8.Length);

            }



            return output;

        }

        /// <summary>

        /// Deserialize XML string to an object.

        /// </summary>

        /// <typeparam name="T">Type of object</typeparam>

        /// <param name="xml">XML string</param>

        /// <returns>XML-deserialized object</returns>

        public static T DeserializeFromXmlString<T>(string xml) where T : new()
        {

            T xmlObject = new T();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            StringReader stringReader = new StringReader(xml);

            xmlObject = (T)xmlSerializer.Deserialize(stringReader);

            return xmlObject;

        }



        /// <summary>

        /// Deserialize XML string from XML file to an object.

        /// </summary>

        /// <typeparam name="T">Type of object</typeparam>

        /// <param name="filename">XML filename with .XML extension</param>

        /// <returns>XML-deserialized object</returns>

        public static T DeserializeFromXmlFile<T>(string filename) where T : new()
        {

            if (!File.Exists(filename))
            {

                throw new FileNotFoundException();

            }



            return DeserializeFromXmlString<T>(File.ReadAllText(filename));

        }

    }

}