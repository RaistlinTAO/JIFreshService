﻿#region

using System;
using System.Data;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Jayrock.Json;
using Jayrock.Json.Conversion;

#endregion

namespace VTigerApi
{
    /// <summary>
    ///     Interface to the VTiger-Web-API
    /// </summary>
    public partial class VTiger
    {
        private readonly ExportContext jsonExporter;
        private readonly ImportContext jsonImporter;
        private string baseUrl;
        private string serviceUrl;

        private string sessionName;

        /// <summary>
        ///     Create an instance of the VTiger-API interface
        /// </summary>
        /// <param name="aServiceUrl">Address of the service (example: http://demo.vtiger.de)</param>
        public VTiger(string aServiceUrl)
        {
            ServiceUrl = aServiceUrl;

            #region Json-Converters

            jsonImporter = new ImportContext();
            //JsonConvert.CurrentImportContextFactory = delegate { return jsonImporter; };
            jsonImporter.Register(new BooleanImporterEx());
            jsonImporter.Register(new DateTimeImporterEx());
            jsonImporter.Register(new Int32ImporterEx());
            jsonImporter.Register(new EmailAdressesImporter());
            jsonImporter.Register(new EnumValueImporter(typeof (TaskStatus), VTigerEnumValues.TaskstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Eventstatus), VTigerEnumValues.EventstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Taskpriority), VTigerEnumValues.TaskpriorityValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Activitytype), VTigerEnumValues.ActivitytypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Visibility), VTigerEnumValues.VisibilityValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Duration_minutes),
                VTigerEnumValues.Duration_minutesValues));
            jsonImporter.Register(new EnumValueImporter(typeof (RecurringType), VTigerEnumValues.RecurringtypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Leadsource), VTigerEnumValues.LeadsourceValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Industry), VTigerEnumValues.IndustryValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Leadstatus), VTigerEnumValues.LeadstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Rating), VTigerEnumValues.RatingValues));
            jsonImporter.Register(new EnumValueImporter(typeof (TaskStatus), VTigerEnumValues.TaskstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Email_flag), VTigerEnumValues.Email_flagValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Ticketpriorities),
                VTigerEnumValues.TicketprioritiesValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Ticketseverities),
                VTigerEnumValues.TicketseveritiesValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Ticketstatus), VTigerEnumValues.TicketstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Ticketcategories),
                VTigerEnumValues.TicketcategoriesValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Faqcategories), VTigerEnumValues.FaqcategoriesValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Faqstatus), VTigerEnumValues.FaqstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Quotestage), VTigerEnumValues.QuotestageValues));
            jsonImporter.Register(new EnumValueImporter(typeof (HdnTaxType), VTigerEnumValues.HdnTaxTypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (PoStatus), VTigerEnumValues.PostatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (SoStatus), VTigerEnumValues.SostatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Recurring_frequency),
                VTigerEnumValues.Recurring_frequencyValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Payment_duration),
                VTigerEnumValues.Payment_durationValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Invoicestatus), VTigerEnumValues.InvoicestatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Campaigntype), VTigerEnumValues.CampaigntypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Campaignstatus), VTigerEnumValues.CampaignstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Expectedresponse),
                VTigerEnumValues.ExpectedresponseValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Activity_view), VTigerEnumValues.Activity_viewValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Lead_view), VTigerEnumValues.Lead_viewValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Date_format), VTigerEnumValues.Date_formatValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Reminder_interval),
                VTigerEnumValues.Reminder_intervalValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Tracking_unit), VTigerEnumValues.Tracking_unitValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Contract_status), VTigerEnumValues.Contract_statusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Contract_priority),
                VTigerEnumValues.Contract_priorityValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Contract_type), VTigerEnumValues.Contract_typeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Service_usageunit),
                VTigerEnumValues.Service_usageunitValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Servicecategory), VTigerEnumValues.ServicecategoryValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Assetstatus), VTigerEnumValues.AssetstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projectmilestonetype),
                VTigerEnumValues.ProjectmilestonetypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projecttasktype), VTigerEnumValues.ProjecttasktypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projecttaskpriority),
                VTigerEnumValues.ProjecttaskpriorityValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projecttaskprogress),
                VTigerEnumValues.ProjecttaskprogressValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projectstatus), VTigerEnumValues.ProjectstatusValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projecttype), VTigerEnumValues.ProjecttypeValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Projectpriority), VTigerEnumValues.ProjectpriorityValues));
            jsonImporter.Register(new EnumValueImporter(typeof (Progress), VTigerEnumValues.ProgressValues));

            jsonExporter = JsonConvert.DefaultExportContextFactory();
            jsonExporter.Register(new BooleanExporterEx());
            jsonExporter.Register(new DateTimeExporterEx());
            jsonExporter.Register(new EmailAdressesExporter());
            jsonExporter.Register(new EnumValueExporter(typeof (TaskStatus), VTigerEnumValues.TaskstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Eventstatus), VTigerEnumValues.EventstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Taskpriority), VTigerEnumValues.TaskpriorityValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Activitytype), VTigerEnumValues.ActivitytypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Visibility), VTigerEnumValues.VisibilityValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Duration_minutes),
                VTigerEnumValues.Duration_minutesValues));
            jsonExporter.Register(new EnumValueExporter(typeof (RecurringType), VTigerEnumValues.RecurringtypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Leadsource), VTigerEnumValues.LeadsourceValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Industry), VTigerEnumValues.IndustryValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Leadstatus), VTigerEnumValues.LeadstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Rating), VTigerEnumValues.RatingValues));
            jsonExporter.Register(new EnumValueExporter(typeof (TaskStatus), VTigerEnumValues.TaskstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Email_flag), VTigerEnumValues.Email_flagValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Ticketpriorities),
                VTigerEnumValues.TicketprioritiesValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Ticketseverities),
                VTigerEnumValues.TicketseveritiesValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Ticketstatus), VTigerEnumValues.TicketstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Ticketcategories),
                VTigerEnumValues.TicketcategoriesValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Faqcategories), VTigerEnumValues.FaqcategoriesValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Faqstatus), VTigerEnumValues.FaqstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Quotestage), VTigerEnumValues.QuotestageValues));
            jsonExporter.Register(new EnumValueExporter(typeof (HdnTaxType), VTigerEnumValues.HdnTaxTypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (PoStatus), VTigerEnumValues.PostatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (SoStatus), VTigerEnumValues.SostatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Recurring_frequency),
                VTigerEnumValues.Recurring_frequencyValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Payment_duration),
                VTigerEnumValues.Payment_durationValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Invoicestatus), VTigerEnumValues.InvoicestatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Campaigntype), VTigerEnumValues.CampaigntypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Campaignstatus), VTigerEnumValues.CampaignstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Expectedresponse),
                VTigerEnumValues.ExpectedresponseValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Activity_view), VTigerEnumValues.Activity_viewValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Lead_view), VTigerEnumValues.Lead_viewValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Date_format), VTigerEnumValues.Date_formatValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Reminder_interval),
                VTigerEnumValues.Reminder_intervalValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Tracking_unit), VTigerEnumValues.Tracking_unitValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Contract_status), VTigerEnumValues.Contract_statusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Contract_priority),
                VTigerEnumValues.Contract_priorityValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Contract_type), VTigerEnumValues.Contract_typeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Service_usageunit),
                VTigerEnumValues.Service_usageunitValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Servicecategory), VTigerEnumValues.ServicecategoryValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Assetstatus), VTigerEnumValues.AssetstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projectmilestonetype),
                VTigerEnumValues.ProjectmilestonetypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projecttasktype), VTigerEnumValues.ProjecttasktypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projecttaskpriority),
                VTigerEnumValues.ProjecttaskpriorityValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projecttaskprogress),
                VTigerEnumValues.ProjecttaskprogressValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projectstatus), VTigerEnumValues.ProjectstatusValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projecttype), VTigerEnumValues.ProjecttypeValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Projectpriority), VTigerEnumValues.ProjectpriorityValues));
            jsonExporter.Register(new EnumValueExporter(typeof (Progress), VTigerEnumValues.ProgressValues));

            #endregion
        }

        #region Basic Access

        #region Login & Info

        private VTigerToken GetChallenge(string username)
        {
            return VTigerGetJson<VTigerToken>("getchallenge",
                String.Format("username={0}", username), false);
        }

        /// <summary>
        ///     Login to the VTiger API.
        ///     Neccessary to access any data.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="accessKey">Personal authentication-key provided on the VTiger website</param>
        public void Login(string username, string accessKey)
        {
            string token = GetChallenge(username).token;

            string key = getMd5Hash(token + accessKey);

            VTigerLogin loginResult = VTigerGetJson<VTigerLogin>("login",
                String.Format("username={0}&accessKey={1}", username, key), true);

            sessionName = loginResult.sessionName;
        }

        /// <summary>
        ///     Terminates the current session
        /// </summary>
        public void Logout()
        {
            VTigerGetJson<JsonObject>("logout",
                String.Format("sessionName={0}", sessionName), false);
            sessionName = null;
        }

        /// <summary>
        ///     Retrieve a list of the different entity-types supported by VTiger (for development)
        /// </summary>
        /// <returns></returns>
        public VTigerTypeInfo[] Listtypes()
        {
            VTigerTypes typeList = VTigerGetJson<VTigerTypes>("listtypes",
                String.Format("sessionName={0}", sessionName), false);

            typeList.typeInfo = new VTigerTypeInfo[typeList.types.Length];
            for (int i = 0; i < typeList.types.Length; i++)
            {
                string typeName = typeList.types[i];
                if (typeList.information.Contains(typeName))
                {
                    typeList.typeInfo[i] = ImportJson<VTigerTypeInfo>(typeList.information[typeName].ToString());
                    typeList.typeInfo[i].Name = typeName;
                }
            }
            return typeList.typeInfo;
        }

        /// <summary>
        ///     Retrieve a list of the different entity-types supported by VTiger (for development)
        /// </summary>
        /// <returns></returns>
        public DataTable Listtypes_DataTable()
        {
            VTigerTypeInfo[] types = Listtypes();
            return JsonArrayToDataTable(ImportJson<JsonArray>(ExportJson(types)));
        }

        /// <summary>
        ///     Retrieves detailed information about a VTiger entity-type (for development)
        /// </summary>
        /// <param name="elementType"></param>
        /// <returns></returns>
        public VTigerObjectType Describe(VTigerType elementType)
        {
            return VTigerGetJson<VTigerObjectType>("describe",
                String.Format("sessionName={0}&elementType={1}", sessionName, elementType), false);
        }

        /// <summary>
        ///     Retrieves detailed information about a VTiger entity-type (for development)
        /// </summary>
        /// <param name="elementType"></param>
        /// <returns></returns>
        public DataTable Describe_DataTable(VTigerType elementType)
        {
            VTigerObjectType obj = Describe(elementType);
            return JsonArrayToDataTable(ImportJson<JsonArray>(ExportJson(obj.fields)));
        }

        #endregion

        #region Query & Retrieve

        /// <summary>
        ///     Retrieve a single element with the specified id
        /// </summary>
        /// <typeparam name="T">Expected result-type (derivate of VTigerEntity)</typeparam>
        /// <param name="id">VTiger-ID</param>
        /// <returns></returns>
        public T Retrieve<T>(string id) //where T : JsonObject, VTigerEntity
        {
            return VTigerGetJson<T>("retrieve",
                String.Format("sessionName={0}&id={1}", sessionName, id), false);
        }

        /// <summary>
        ///     Retrieve a single element with the specified id as a DataTable with a single row
        /// </summary>
        /// <param name="id">VTiger-ID</param>
        /// <returns></returns>
        public DataTable Retrieve(string id)
        {
            return JsonObjectToDataTable(Retrieve<JsonObject>(id));
        }

        /// <summary>
        ///     Performs a query on the VTiger database
        /// </summary>
        /// <typeparam name="T">Expected type</typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public T VTiger_Query<T>(string query)
        {
            return VTigerGetJson<T>("query",
                String.Format("sessionName={0}&query={1}", sessionName, HttpUtility.UrlEncode(query)), false);
        }

        /// <summary>
        ///     Performs a query on the VTiger database and converts the result to an array of the desired type
        /// </summary>
        /// <typeparam name="T">Expected entity-type</typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        /// <example>
        ///     This query will return the first 10 contacts whose firstname begins with an "M"
        ///     <code>Query&lt;VTigerContact&gt;("SELECT * FROM Contacts WHERE firstname LIKE 'M%' ORDER BY firstname LIMIT 0,10");</code>
        /// </example>
        public T[] Query<T>(string query) where T : VTigerEntity
        {
            //Query<VTigerContact>();  
            return VTiger_Query<T[]>(query);
        }

        /// <summary>
        ///     Performs a query on the VTiger database and converts the result into a DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable Query(string query)
        {
            return JsonArrayToDataTable(VTiger_Query<JsonArray>(query));
        }

        #endregion

        #region Create

        /// <summary>
        ///     Creates a new VTiger entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elementType"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public T VTiger_Create<T>(VTigerType elementType, string element)
        {
            return VTigerGetJson<T>("create",
                String.Format("sessionName={0}&elementType={1}&element={2}", sessionName, elementType,
                    HttpUtility.UrlEncode(element)), true);
        }

        /// <summary>
        ///     Creates a new VTiger entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        public T Create<T>(T element) where T : VTigerEntity
        {
            return VTiger_Create<T>(element.elementType, ExportJson(element));
        }

        /// <summary>
        ///     Creates a new VTiger entity and return the result as a DataTable
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public DataTable Create(VTigerEntity element)
        {
            return JsonObjectToDataTable(VTiger_Create<JsonObject>(element.elementType, ExportJson(element)));
        }

        /// <summary>
        ///     Creates a new VTiger entity and return the result as a DataTable
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public DataTable Create(VTigerType elementType, DataRow element)
        {
            return JsonObjectToDataTable(VTiger_Create<JsonObject>(elementType, ExportJson(element)));
        }

        /// <summary>
        ///     Creates a new empty, locally stored VTiger entity
        /// </summary>
        /// <param name="elementType"></param>
        /// <returns></returns>
        public DataTable NewElement(VTigerType elementType)
        {
            Type dataType = VTigerTypeClasses[(int) elementType];
            DataTable dt = new DataTable();
            foreach (FieldInfo inf in dataType.GetFields())
                dt.Columns.Add(inf.Name, inf.FieldType);
            dt.Rows.Add(dt.NewRow());
            return dt;
        }

        #endregion

        #region Update

        /// <summary>
        ///     Updates an existing entity in the VTiger database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        private T VTiger_Update<T>(string element)
        {
            return VTigerGetJson<T>("update",
                String.Format("sessionName={0}&element={1}", sessionName, HttpUtility.UrlEncode(element)), true);
        }

        /// <summary>
        ///     Updates an existing entity in the VTiger database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        public T Update<T>(T element) where T : VTigerEntity
        {
            return VTiger_Update<T>(ExportJson(element));
        }

        /// <summary>
        ///     Updates an existing entity in the VTiger database
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public DataTable Update(DataRow element)
        {
            return JsonObjectToDataTable(VTiger_Update<JsonObject>(ExportJson(element)));
        }

        /// <summary>
        ///     Fetches each entry from a DataTable and updates the corrosponding entities in the VTiger database
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public DataTable UpdateTable(DataTable elements)
        {
            if (elements.Rows.Count == 0)
                //return elements;
                throw new Exception("Could not perform update: Empty DataTable");

            DataTable result = elements.Clone();
            result.Clear();
            foreach (DataRow row in elements.Rows)
                result.ImportRow(Update(row).Rows[0]);
            return result;
        }

        #endregion

        #region Delete & Sync

        /// <summary>
        ///     Delete an element from the database
        /// </summary>
        /// <param name="id">VTiger-ID</param>
        public void Delete(string id)
        {
            VTigerGetJson<object>("delete",
                String.Format("sessionName={0}&id={1}", sessionName, id), true);
        }

        /// <summary>
        /// </summary>
        /// <param name="modifiedTime"></param>
        /// <returns></returns>
        public JsonObject Sync(DateTime modifiedTime)
        {
            const int time = 0;
            JsonObject result = VTigerGetJson<JsonObject>("sync",
                String.Format("sessionName={0}&modifiedTime={1}", sessionName, time), false);
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="modifiedTime"></param>
        /// <param name="elementType"></param>
        /// <returns></returns>
        public JsonObject Sync(DateTime modifiedTime, VTigerType elementType)
        {
            const int time = 0;
            JsonObject result = VTigerGetJson<JsonObject>("sync",
                String.Format("sessionName={0}&modifiedTime={1}&elementType={2}", sessionName, time, elementType), false);
            return result;
        }

        #endregion

        #region Json-Conversion

        /// <summary>
        ///     Exports an object with all accessible properties and fields as a Json-string
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public string ExportJson(object o)
        {
            using (JsonTextWriter writer = new JsonTextWriter())
            {
                jsonExporter.Export(o, writer);
                return writer.ToString();
            }
        }

        /// <summary>
        ///     Imports all possible properties and fields of a Json-string into a new instance of the desired class
        /// </summary>
        /// <typeparam name="T">Target type</typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public T ImportJson<T>(string json)
        {
            using (StringReader stringReader = new StringReader(json))
            {
                JsonTextReader reader = new JsonTextReader(stringReader);
                try
                {
                    return jsonImporter.Import<T>(reader);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + " (" + json + ")");
                }
            }
        }

        /// <summary>
        ///     Performs an operation with the VTiger webservice
        /// </summary>
        /// <param name="operation">operation-identifier</param>
        /// <param name="parameters">parameters for the operation</param>
        /// <param name="post">Specifies whether a HTTP-GET or HTTP-POST is used for the operation</param>
        /// <returns>VTiger response as string</returns>
        private string VTigerExecuteOperation(string operation, string parameters, bool post)
        {
            string response;
            response = post
                ? HttpPost(baseUrl + operation, parameters)
                : HttpGet(baseUrl + operation + "&" + parameters);
            if (response == null)
                throw new Exception("Unable to connect to VTiger-Service");
            return response;
        }

        /// <summary>
        ///     Performs an operation with the VTiger webservice and converts the result to the desired type
        /// </summary>
        /// <typeparam name="T">Expected type for the result</typeparam>
        /// <param name="operation">operation-identifier</param>
        /// <param name="parameters">parameters for the operation</param>
        /// <param name="post">Specifies whether a HTTP-GET or HTTP-POST is used for the operation</param>
        /// <returns></returns>
        private T VTigerGetJson<T>(string operation, string parameters, bool post)
        {
            string response = VTigerExecuteOperation(operation, parameters, post);
            VTigerResult<T> result = ImportJson<VTigerResult<T>>(response);
            if (!result.success)
                throw new Exception(result.error.message);
            return result.result;
        }

        /// <summary>
        ///     Adds a new row to the DataTable and converts special fields if needed
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="obj"></param>
        private void DtConvertAddRow(DataTable dt, JsonObject obj)
        {
            DataRow dr = dt.NewRow();
            int i = 0;
            foreach (JsonMember member in obj)
            {
                if ((member.Name == "saved_toid") || (member.Name == "ccmail") || (member.Name == "bccmail"))
                {
                    if ((string) member.Value == "")
                        dr[i] = "";
                    else
                    {
                        string[] values = ImportJson<string[]>((string) member.Value);
                        dr[i] = ListStrings(values);
                    }
                }
                else
                    dr[i] = member.Value;
                i++;
            }
            dt.Rows.Add(dr);
        }

        /// <summary>
        ///     Converts a JsonArray (from a query) into a DataTable
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public DataTable JsonArrayToDataTable(JsonArray array)
        {
            DataTable dt = new DataTable();
            if (array.Length == 0)
                return dt;

            object o = array[0];
            if (o is JsonObject)
            {
                JsonObject[] items = ImportJson<JsonObject[]>(array.ToString());

                foreach (JsonMember member in items[0])
                    dt.Columns.Add(new DataColumn(member.Name, typeof (string)));

                foreach (JsonObject item in items)
                    DtConvertAddRow(dt, item);

                if (dt.Columns.Contains("id"))
                    dt.Columns["id"].SetOrdinal(0);

                return dt;
            }
            throw new Exception("Only JsonArray of JsonObject can be deserialized to a DataTable");
        }

        /// <summary>
        ///     Converts a JsonObject into a DataTable with a single row
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public DataTable JsonObjectToDataTable(JsonObject o)
        {
            DataTable dt = new DataTable();

            foreach (JsonMember member in o)
                dt.Columns.Add(new DataColumn(member.Name, typeof (string)));
            DtConvertAddRow(dt, o);

            if (dt.Columns.Contains("id"))
                dt.Columns["id"].SetOrdinal(0);

            return dt;
        }

        #endregion

        //====================================================================

        //====================================================================

        //====================================================================

        //====================================================================

        //====================================================================

        //====================================================================

        #endregion

        #region Searches

        private const string SqlContains = " LIKE '%{0}%'";
        private static string SqlDateFrom = " >= '{0}'";
        private static string SqlDateTo = " <= '{0}'";

        /// <summary>
        ///     Creates a new VTigerQueryWriter and initializes it with default search-parameters.
        ///     Empty parameters are excluded from the search.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="PrimaryCol">Primary search-column-name</param>
        /// <param name="OptionalCols">Optional search-column-names</param>
        /// <param name="DateCol">Column for date-search</param>
        /// <param name="PrimaryText"></param>
        /// <param name="OptionalText"></param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns>Returns the initialized VTigerQueryWriter</returns>
        public VTigerQueryWriter DefaultSearchQuery(VTigerType table,
            string PrimaryCol, string PrimaryText,
            string[] OptionalCols, string OptionalText,
            string DateCol, DateTime FromDate, DateTime ToDate)
        {
            string optionalCmp = string.Format(" LIKE '%{0}%'", OptionalText.Replace(" ", "%"));
            string FromDateCmp = string.Format(" >= '{0}'", DateTimeToVtDate(FromDate));
            string ToDateCmp = string.Format(" <= '{0}'", DateTimeToVtDate(ToDate));

            VTigerQueryWriter queryWriter = new VTigerQueryWriter(table);

            if ((OptionalText != "") && (OptionalCols.Length != 0))
                foreach (string colName in OptionalCols)
                    queryWriter.AddOrCondition(colName + optionalCmp);

            if ((FromDate != DateTime.FromBinary(0)) && (DateCol != ""))
                queryWriter.AddAndCondition(DateCol + FromDateCmp);

            if ((ToDate != DateTime.FromBinary(0)) && (DateCol != ""))
                queryWriter.AddAndCondition(DateCol + ToDateCmp);

            if ((PrimaryText != "") && (PrimaryCol != ""))
                queryWriter.AddAndCondition(PrimaryCol + string.Format(SqlContains, PrimaryText));

            return queryWriter;
        }

        /// <summary>
        ///     Searches for an entity which matches the specified condition and retrives it's ID
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="field">The field of the entity which should match the specified value</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FindEntityID(VTigerType elementType, string field, string value)
        {
            VTigerEntity[] items = Query<VTigerEntity>(String.Format(
                "SELECT id,{1} FROM {0} WHERE {1}='{2}';", elementType, field, value));
            if (items.Length == 0)
                throw new Exception(String.Format(
                    "Could not find an element for the condition {0}='{1}'", field, value));
            if (items.Length != 1)
                throw new Exception(String.Format(
                    "Found multiple elements with the condition {0}='{1}'", field, value));
            return items[0].id;
        }

        /// <summary>
        ///     Searches for an entity which matches the specified condition and retrives it's data
        /// </summary>
        /// <param name="field">The field of the entity which should match the specified value</param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// public T Create
        /// <T />
        /// (T element) where T : VTigerEntity
        public T FindEntity<T>(string field, string value) where T : VTigerEntity, new()
        {
            T[] items = Query<T>(String.Format(
                "SELECT * FROM {0} WHERE {1}='{2}';", (new T()).elementType, field, value));
            if (items.Length == 0)
                return null;
            //throw new Exception(String.Format(
            //    "Could not find an element for the condition {0}='{1}'", field, value));
            if (items.Length != 1)
                throw new Exception(String.Format(
                    "Found multiple elements with the condition {0}='{1}'", field, value));
            return items[0];
        }

        #region Default GetID-functions

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetUserID(string name)
        {
            return FindEntityID(VTigerType.Users, "user_name", name);
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetAccountID(string name)
        {
            return FindEntityID(VTigerType.Accounts, "accountname", name);
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetProductID(string name)
        {
            return FindEntityID(VTigerType.Products, "productname", name);
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetCampaignID(string name)
        {
            return FindEntityID(VTigerType.Campaigns, "campaignname", name);
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetServiceID(string name)
        {
            return FindEntityID(VTigerType.Services, "servicename", name);
        }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetAssetID(string name)
        {
            return FindEntityID(VTigerType.Assets, "assetname", name);
        }

        public string GetProjectTaskID(string name)
        {
            return FindEntityID(VTigerType.ProjectTask, "projecttaskname", name);
        }

        public string GetProjectID(string name)
        {
            return FindEntityID(VTigerType.Project, "projectname", name);
        }

        public string GetGroupID(string name)
        {
            return FindEntityID(VTigerType.Products, "groupname", name);
        }

        public string GetCurrencyID(string name)
        {
            return FindEntityID(VTigerType.Products, "currency_name", name);
        }

        #endregion

        #region Default Searches

        /// <summary>
        ///     Returns a default search-query
        /// </summary>
        /// <remarks>
        ///     Default search-attributes:
        ///     Primary-Column: invoice_no
        ///     Optional-Columns: subject, hdnGrandTotal, hdnSubTotal, hdnDiscountAmount, txtAdjustment, terms_conditions
        ///     Date-Column: invoicedate
        /// </remarks>
        /// <param name="invoice_no"></param>
        /// <param name="searchText"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        /// <seealso cref="VTigerApi.VTiger.DefaultSearchQuery" />
        public VTigerQueryWriter DefaultSearchInvoices(string invoice_no, string searchText, DateTime fromDate,
            DateTime toDate)
        {
            return DefaultSearchQuery(VTigerType.Invoice, "invoice_no", invoice_no,
                new[]
                {"subject", "hdnGrandTotal", "hdnSubTotal", "hdnDiscountAmount", "txtAdjustment", "terms_conditions"},
                searchText,
                "invoicedate", fromDate, toDate);
        }

        #endregion

        #endregion

        #region Default Add-functions

        public VTigerCalendar AddCalendar(string user_id, string subject,
            DateTime date_start, DateTime due_date, TaskStatus taskStatus)
        {
            //Todo: For some kind of reason the server returns success, without creating a new element
            VTigerCalendar element = new VTigerCalendar(
                subject,
                user_id,
                DateTimeToVtDate(date_start),
                DateTimeToVtDate(due_date),
                taskStatus);
            return Create(element);
        }

        public VTigerLead AddLead(string lastname, string company, string assigned_user_id)
        {
            VTigerLead element = new VTigerLead(
                lastname,
                company,
                assigned_user_id);
            return Create(element);
        }

        public VTigerAccount AddAccount(string accountname, string assigned_user_id)
        {
            VTigerAccount element = new VTigerAccount(
                accountname,
                assigned_user_id);
            return Create(element);
        }

        public VTigerContact AddContact(string firstname, string lastname, string user_id)
        {
            VTigerContact element = new VTigerContact(
                lastname,
                user_id) {firstname = firstname};
            return Create(element);
        }

        public VTigerPotential AddPotential(string potentialname, string related_to,
            string closingdate, Sales_stage sales_stage, string assigned_user_id)
        {
            VTigerPotential element = new VTigerPotential(
                potentialname,
                related_to,
                closingdate,
                sales_stage,
                assigned_user_id);
            return Create(element);
        }

        public VTigerProduct AddProduct(string productname)
        {
            return Create(new VTigerProduct(productname));
        }

        public VTigerDocument AddDocument(string notes_title, string assigned_user_id)
        {
            VTigerDocument element = new VTigerDocument(
                notes_title,
                assigned_user_id);
            return Create(element);
        }

        public VTigerEmail AddEmail(string subject, DateTime date_start,
            string from_email, string[] saved_toid, string assigned_user_id)
        {
            VTigerEmail element = new VTigerEmail(
                subject,
                date_start,
                from_email,
                saved_toid,
                assigned_user_id);
            return Create(element);
        }

        public VTigerHelpDesk AddHelpDesk(string assigned_user_id, Ticketstatus ticketstatus, string ticket_title)
        {
            VTigerHelpDesk element = new VTigerHelpDesk(
                assigned_user_id,
                ticketstatus,
                ticket_title);
            return Create(element);
        }

        public VTigerFaq AddFaq(Faqstatus faqstatus, string question, string faq_answer)
        {
            VTigerFaq element = new VTigerFaq(
                faqstatus,
                question,
                faq_answer);
            return Create(element);
        }

        public VTigerVendor AddVendor(string vendorname)
        {
            return Create(new VTigerVendor(vendorname));
        }

        public VTigerPriceBook AddPriceBook(string bookname, string currency_id)
        {
            VTigerPriceBook element = new VTigerPriceBook(
                bookname,
                currency_id);
            return Create(element);
        }

        public VTigerQuote AddQuote(string subject, Quotestage quotestage, string bill_street,
            string ship_street, string account_id, string assigned_user_id)
        {
            VTigerQuote element = new VTigerQuote(
                subject,
                quotestage,
                bill_street,
                ship_street,
                account_id,
                assigned_user_id);
            return Create(element);
        }

        public VTigerPurchaseOrder AddPurchaseOrder(string subject, string vendor_id, PoStatus postatus,
            string bill_street, string ship_street, string assigned_user_id)
        {
            VTigerPurchaseOrder element = new VTigerPurchaseOrder(
                subject,
                vendor_id,
                postatus,
                bill_street,
                ship_street,
                assigned_user_id);
            return Create(element);
        }

        public VTigerSalesOrder AddSalesOrder(string subject, SoStatus sostatus, string bill_street,
            string ship_street, Invoicestatus invoicestatus, string account_id, string assigned_user_id)
        {
            VTigerSalesOrder element = new VTigerSalesOrder(
                subject,
                sostatus,
                bill_street,
                ship_street,
                invoicestatus,
                account_id,
                assigned_user_id);
            return Create(element);
        }

        public VTigerInvoice AddInvoice(string subject, string bill_street, string ship_street,
            string account_id, string assigned_user_id)
        {
            VTigerInvoice element = new VTigerInvoice(
                subject,
                bill_street,
                ship_street,
                account_id,
                assigned_user_id);
            return Create(element);
        }

        public VTigerCampaign AddCampaign(string campaignname, DateTime closingdate, string assigned_user_id)
        {
            VTigerCampaign element = new VTigerCampaign(
                campaignname,
                closingdate,
                assigned_user_id);
            return Create(element);
        }

        public VTigerEvent AddEvent(string subject, string date_start, string time_start, string due_date,
            string time_end, int duration_hours, Eventstatus eventstatus,
            Activitytype activitytype, string assigned_user_id)
        {
            VTigerEvent element = new VTigerEvent(
                subject,
                date_start,
                time_start,
                due_date,
                time_end,
                duration_hours,
                eventstatus,
                activitytype,
                assigned_user_id);
            return Create(element);
        }

        public VTigerPBXManager AddPBXManager(string callfrom, string callto)
        {
            VTigerPBXManager element = new VTigerPBXManager(
                callfrom,
                callto);
            return Create(element);
        }

        public VTigerServiceContract AddServiceContract(string subject, string assigned_user_id)
        {
            VTigerServiceContract element = new VTigerServiceContract(
                subject,
                assigned_user_id);
            return Create(element);
        }

        public VTigerService AddService(string servicename)
        {
            return Create(new VTigerService(servicename));
        }

        public VTigerAsset AddAsset(string product, string serialnumber, string datesold,
            string dateinservice, Assetstatus assetstatus, string assetname,
            string account, string assigned_user_id)
        {
            VTigerAsset element = new VTigerAsset(
                product,
                serialnumber,
                datesold,
                dateinservice,
                assetstatus,
                assetname,
                account,
                assigned_user_id);
            return Create(element);
        }

        //public VTigerDocument Add()
        //{
        //    VTigerDocument element = new VTigerDocument(
        //        account_id,
        //        assigned_user_id);
        //    return Create<VTigerDocument>(element);
        //}

        #endregion

        #region Helpers

        private static string getMd5Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            byte[] data;
            using (MD5 md5Hasher = MD5.Create())
                data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private static string HttpGet(string url)
        {
            HttpWebRequest webRequest = GetWebRequest(url);
            HttpWebResponse response = (HttpWebResponse) webRequest.GetResponse();
            string jsonResponse;
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                jsonResponse = sr.ReadToEnd();
            }
            return jsonResponse;
        }

        private static string HttpPost(string url, string parameters)
        {
            HttpWebRequest webRequest = GetWebRequest(url);
            webRequest.ContentType = "application/x-www-form-urlencoded";

            webRequest.Method = "POST";
            byte[] data = Encoding.ASCII.GetBytes(parameters);
            webRequest.ContentLength = data.Length;
            using (Stream stream = webRequest.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            // get the response
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }

        private static HttpWebRequest GetWebRequest(string formattedUri)
        {
            // Create the request’s URI.      
            Uri serviceUri = new Uri(formattedUri, UriKind.Absolute);
            // Return the HttpWebRequest.        
            return (HttpWebRequest) WebRequest.Create(serviceUri);
        }

        public static VTigerType VTigerTypeParse(string text)
        {
            return (VTigerType) Enum.Parse(typeof (VTigerType), text, true);
        }

        public static string DateTimeToVtDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static string DateTimeToVtTime(DateTime time)
        {
            return time.ToString("hh:mm:ss");
        }

        public string ListStrings(string[] strings)
        {
            if (strings.Length == 0)
                return "";
            if (strings.Length == 1)
                return strings[0];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strings.Length - 1; i++)
                sb.Append(strings[i] + ",");
            sb.Append(strings[strings.Length - 1]);
            return sb.ToString();
        }

        #endregion

        /// <summary>
        ///     The URL of the VTiger-CRM (eg: http://demo.vtiger.de/)
        /// </summary>
        public string ServiceUrl
        {
            get { return serviceUrl; }
            set
            {
                if (value[value.Length - 1] != '/')
                    value += "/";
                serviceUrl = value;
                baseUrl = value + "webservice.php?operation=";
            }
        }

        /// <summary>
        ///     The session-identifier which is used for authentication.
        ///     This value is automatically set by Login
        /// </summary>
        /// <seealso cref="VTigerApi.VTiger.Login" />
        public string SessionName
        {
            get { return sessionName; }
        }

        //====================================================================

        //====================================================================

        //====================================================================
    }

    public class VTigerQueryWriter
    {
        public string[] columns = {"*"};
        public string[][] conditions; // = new string[0][];
        public int limitCount = 100;
        public int limitStart = 0;
        public VTigerType table;

        public VTigerQueryWriter(VTigerType aTable)
        {
            table = aTable;
        }

        public string Query
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT ");
                if (columns.Length > 0)
                {
                    foreach (string item in columns)
                        sb.Append(item + ", ");
                    sb.Remove(sb.Length - 2, 2);
                    sb.AppendLine();
                }
                else
                    sb.AppendLine("*");

                sb.Append("FROM ");
                sb.AppendLine(table.ToString());

                if ((conditions != null) && (conditions.Length > 0))
                {
                    sb.Append("WHERE ");
                    foreach (string[] orCond in conditions)
                    {
                        foreach (string andCond in orCond)
                        {
                            sb.Append(andCond);
                            sb.Append(" AND ");
                        }
                        sb.Remove(sb.Length - 5, 5);
                        sb.Append(" OR ");
                    }
                    sb.Remove(sb.Length - 4, 4);
                    sb.AppendLine();
                }
                sb.Append("LIMIT ");
                sb.Append(limitStart.ToString());
                sb.Append(", ");
                sb.Append(limitCount.ToString());

                sb.Append(";");
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return Query;
        }

        public void AddAndCondition(string condition)
        {
            if ((conditions == null) || (conditions.Length == 0))
            {
                conditions = new string[1][];
                conditions[0] = new string[1];
                conditions[0][0] = condition;
            }
            else
            {
                for (int i = 0; i < conditions.Length; i++)
                {
                    string[] newList = new string[conditions[i].Length + 1];
                    for (int j = 0; j < conditions[i].Length; j++)
                        newList[j] = conditions[i][j];
                    newList[newList.Length - 1] = condition;
                    conditions[i] = newList;
                }
            }
        }

        public void AddOrCondition(string condition)
        {
            if ((conditions == null) || (conditions.Length == 0))
            {
                conditions = new string[1][];
                conditions[0] = new string[1];
                conditions[0][0] = condition;
            }
            else
            {
                string[][] newList = new string[conditions.Length + 1][];
                for (int i = 0; i < conditions.Length; i++)
                {
                    newList[i] = conditions[i];
                }
                newList[conditions.Length] = new string[1];
                newList[conditions.Length][0] = condition;
                conditions = newList;
            }
        }
    }
}