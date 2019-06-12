#region

using System;
using Jayrock.Json;
using Jayrock.Json.Conversion;

#endregion

namespace VTigerApi
{

    #region enums

    public enum TaskStatus
    {
        Not_Started,
        In_Progress,
        Completed,
        Pending_Input,
        Deferred,
        Planned
    }

    public enum Eventstatus
    {
        Planned,
        Held,
        Not_Held
    }

    public enum Taskpriority
    {
        High,
        Medium,
        Low
    }

    public enum Activitytype
    {
        Call,
        Meeting
    }

    public enum Visibility
    {
        Private,
        Public
    }

    public enum Duration_minutes
    {
        _00,
        _15,
        _30,
        _45
    }

    public enum RecurringType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum Leadsource
    {
        None,
        Cold_Call,
        Existing_Customer,
        Self_Generated,
        Employee,
        Partner,
        Public_Relations,
        Direct_Mail,
        Conference,
        Trade_Show,
        Web_Site,
        Word_of_mouth,
        Other
    }

    public enum Industry
    {
        None,
        Apparel,
        Banking,
        Biotechnology,
        Chemicals,
        Communications,
        Construction,
        Consulting,
        Education,
        Electronics,
        Energy,
        Engineering,
        Entertainment,
        Environmental,
        Finance,
        Food_Beverage,
        Government,
        Healthcare,
        Hospitality,
        Insurance,
        Machinery,
        Manufacturing,
        Media,
        Not_For_Profit,
        Recreation,
        Retail,
        Shipping,
        Technology,
        Telecommunications,
        Transportation,
        Utilities,
        Other
    }

    public enum Leadstatus
    {
        None,
        Attempted_to_Contact,
        Cold,
        Contact_in_Future,
        Contacted,
        Hot,
        Junk_Lead,
        Lost_Lead,
        Not_Contacted,
        Pre_Qualified,
        Qualified,
        Warm
    }

    public enum Rating
    {
        None,
        Acquired,
        Active,
        Market_Failed,
        Project_Cancelled,
        Shutdown
    }

    public enum Accounttype
    {
        None,
        Analyst,
        Competitor,
        Customer,
        Integrator,
        Investor,
        Partner,
        Press,
        Prospect,
        Reseller,
        Other
    }

    public enum Opportunity_type
    {
        None,
        Existing_Business,
        New_Business
    }

    public enum Sales_stage
    {
        Prospecting,
        Qualification,
        Needs_Analysis,
        Value_Proposition,
        Id_Decision_Makers,
        Perception_Analysis,
        Proposal_Price_Quote,
        Negotiation_Review,
        Closed_Won,
        Closed_Lost
    }

    public enum Email_flag
    {
        SAVED,
        SENT
    }

    public enum Ticketpriorities
    {
        Low,
        Normal,
        High,
        Urgent
    }

    public enum Ticketseverities
    {
        Minor,
        Major,
        Feature,
        Critical
    }

    public enum Ticketstatus
    {
        Open,
        In_Progress,
        Wait_For_Response,
        Closed
    }

    public enum Ticketcategories
    {
        Big_Problem,
        Small_Problem,
        Other_Problem
    }

    public enum Faqcategories
    {
        General
    }

    public enum Faqstatus
    {
        Draft,
        Reviewed,
        Published,
        Obsolete
    }

    public enum Quotestage
    {
        Created,
        Delivered,
        Reviewed,
        Accepted,
        Rejected
    }

    public enum HdnTaxType
    {
        Individual,
        Group
    }

    public enum PoStatus
    {
        Created,
        Approved,
        Delivered,
        Cancelled,
        Received_Shipment
    }

    public enum SoStatus
    {
        Created,
        Approved,
        Delivered,
        Cancelled
    }

    public enum Recurring_frequency
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Quarterly,
        Yearly
    }

    public enum Payment_duration
    {
        Net_30_days,
        Net_45_days,
        Net_60_days
    }

    public enum Invoicestatus
    {
        AutoCreated,
        Created,
        Approved,
        Sent,
        Credit_Invoice,
        Paid
    }

    public enum Campaigntype
    {
        None,
        Conference,
        Webinar,
        Trade_Show,
        Public_Relations,
        Partners,
        Referral_Program,
        Advertisement,
        Banner_Ads,
        Direct_Mail,
        Email,
        Telemarketing,
        Others
    }

    public enum Campaignstatus
    {
        None,
        Planning,
        Active,
        Inactive,
        Completed,
        Cancelled
    }

    public enum Expectedresponse
    {
        None,
        Excellent,
        Good,
        Average,
        Poor
    }

    public enum Activity_view
    {
        Today,
        This_Week,
        This_Month,
        This_Year
    }

    public enum Lead_view
    {
        Today,
        Last_2_Days,
        Last_Week
    }

    public enum Date_format
    {
        ddmmyyyy,
        mmddyyyy,
        yyyymmdd
    }

    public enum Reminder_interval
    {
        None,
        _1_Minute,
        _5_Minutes,
        _15_Minutes,
        _30_Minutes,
        _45_Minutes,
        _1_Hour,
        _1_Day
    }

    public enum Tracking_unit
    {
        None,
        Hours,
        Days,
        Incidents
    }

    public enum Contract_status
    {
        Undefined,
        In_Planning,
        In_Progress,
        On_Hold,
        Complete,
        Archived
    }

    public enum Contract_priority
    {
        Low,
        Normal,
        High
    }

    public enum Contract_type
    {
        Support,
        Services,
        Administrative
    }

    public enum Service_usageunit
    {
        Hours,
        Days,
        Incidents
    }

    public enum Servicecategory
    {
        None,
        Support,
        Installation,
        Migration,
        Customization,
        Training
    }

    public enum Assetstatus
    {
        In_Service,
        Outofservice
    }

    public enum Projectmilestonetype
    {
        none,
        administrative,
        operative,
        other
    }

    public enum Projecttasktype
    {
        none,
        administrative,
        operative,
        other
    }

    public enum Projecttaskpriority
    {
        none,
        low,
        normal,
        high
    }

    public enum Projecttaskprogress
    {
        none,
        _10_Percent,
        _20_Percent,
        _30_Percent,
        _40_Percent,
        _50_Percent,
        _60_Percent,
        _70_Percent,
        _80_Percent,
        _90_Percent,
        _100_Percent
    }

    public enum Projectstatus
    {
        none,
        Prospecting,
        Initiated,
        In_Progress,
        waiting_for_feedback,
        On_Hold,
        Completed,
        Delivered,
        Archived
    }

    public enum Projecttype
    {
        none,
        administrative,
        operative,
        other
    }

    public enum Projectpriority
    {
        none,
        low,
        normal,
        high
    }

    public enum Progress
    {
        none,
        _10_Percent,
        _20_Percent,
        _30_Percent,
        _40_Percent,
        _50_Percent,
        _60_Percent,
        _70_Percent,
        _80_Percent,
        _90_Percent,
        _100_Percent
    }

    #endregion

    public struct EmailAdresses
    {
        public string[] Adresses;
    }

    //====================================================================

    #region VTiger-Access-Classes

    public class VTigerResult<T>
    {
        public VTigerError error;
        public T result;
        public bool success;
    }

    public class VTigerError
    {
        public string code;
        public string message;
    }

    public class VTigerLogin
    {
        public string sessionName;
        public string userId;
        public string version;
        public string vtigerVersion;
    }

    public class VTigerToken
    {
        public int expireTime;
        public int serverTime;
        public string token;
    }

    public class VTigerTypes
    {
        public JsonObject information;
        public VTigerTypeInfo[] typeInfo;
        public string[] types;
    }

    public class VTigerTypeInfo
    {
        public string Name;
        public bool isEntity;
        public string label;
        public string singular;
    }

    //====================================================================

    /// <summary>
    ///     Containts the description of a VTiger-object
    /// </summary>
    public class VTigerObjectType
    {
        public bool createable;
        public bool deleteable;
        public VTigerObjectField[] fields;
        public string idPrefix;
        public string isEntity;
        public string label;
        public string labelFields;
        public string name;
        public bool retrieveable;
        public bool updateable;
    }

    /// <summary>
    ///     Part of VTigerObjectType
    /// </summary>
    public class VTigerObjectField
    {
        public bool editable;
        public string label;
        public bool mandatory;
        public string name;
        public bool nullable;
        public VTigerTypeDesc type;
    }

    /// <summary>
    ///     Part of VTigerObjectType
    /// </summary>
    public class VTigerTypeDesc
    {
        public string name;
        public VTigerPicklistItem[] picklistValues;
        public string[] refersTo;
    }

    /// <summary>
    ///     Part of VTigerObjectType
    /// </summary>
    public class VTigerPicklistItem
    {
        public string label;
        public string value;
    }

    #endregion

    public class VTigerEnumValues
    {
        public static string[] TaskstatusValues =
        {
            "Not Started", "In Progress", "Completed", "Pending Input",
            "Deferred", "Planned"
        };

        public static string[] EventstatusValues = {"Planned", "Held", "Not Held"};
        public static string[] TaskpriorityValues = {"High", "Medium", "Low"};
        public static string[] ActivitytypeValues = {"Call", "Meeting"};
        public static string[] VisibilityValues = {"Private", "Public"};
        public static string[] Duration_minutesValues = {"00", "15", "30", "45"};
        public static string[] RecurringtypeValues = {"--None--", "Daily", "Weekly", "Monthly", "Yearly"};

        public static string[] LeadsourceValues =
        {
            "--None--", "Cold Call", "Existing Customer", "Self Generated",
            "Employee", "Partner", "Public Relations", "Direct Mail", "Conference", "Trade Show", "Web Site",
            "Word of mouth", "Other"
        };

        public static string[] IndustryValues =
        {
            "--None--", "Apparel", "Banking", "Biotechnology", "Chemicals",
            "Communications", "Construction", "Consulting", "Education", "Electronics", "Energy", "Engineering",
            "Entertainment", "Environmental", "Finance", "Food & Beverage", "Government", "Healthcare", "Hospitality",
            "Insurance", "Machinery", "Manufacturing", "Media", "Not For Profit", "Recreation", "Retail", "Shipping",
            "Technology", "Telecommunications", "Transportation", "Utilities", "Other"
        };

        public static string[] LeadstatusValues =
        {
            "--None--", "Attempted to Contact", "Cold", "Contact in Future",
            "Contacted", "Hot", "Junk Lead", "Lost Lead", "Not Contacted", "Pre Qualified", "Qualified", "Warm"
        };

        public static string[] RatingValues =
        {
            "--None--", "Acquired", "Active", "Market Failed", "Project Cancelled",
            "Shutdown"
        };

        public static string[] AccounttypeValues =
        {
            "--None--", "Analyst", "Competitor", "Customer", "Integrator",
            "Investor", "Partner", "Press", "Prospect", "Reseller", "Other"
        };

        public static string[] Opportunity_typeValues = {"--None--", "Existing Business", "New Business"};

        public static string[] Sales_stageValues =
        {
            "Prospecting", "Qualification", "Needs Analysis",
            "Value Proposition", "Id. Decision Makers", "Perception Analysis", "Proposal/Price Quote",
            "Negotiation/Review", "Closed Won", "Closed Lost"
        };

        public static string[] Email_flagValues = {"SAVED", "SENT"};
        public static string[] TicketprioritiesValues = {"Low", "Normal", "High", "Urgent"};
        public static string[] TicketseveritiesValues = {"Minor", "Major", "Feature", "Critical"};
        public static string[] TicketstatusValues = {"Open", "In Progress", "Wait For Response", "Closed"};
        public static string[] TicketcategoriesValues = {"Big Problem", "Small Problem", "Other Problem"};
        public static string[] FaqcategoriesValues = {"General"};
        public static string[] FaqstatusValues = {"Draft", "Reviewed", "Published", "Obsolete"};
        public static string[] QuotestageValues = {"Created", "Delivered", "Reviewed", "Accepted", "Rejected"};
        public static string[] HdnTaxTypeValues = {"individual", "group"};
        public static string[] PostatusValues = {"Created", "Approved", "Delivered", "Cancelled", "Received Shipment"};
        public static string[] SostatusValues = {"Created", "Approved", "Delivered", "Cancelled"};

        public static string[] Recurring_frequencyValues =
        {
            "--None--", "Daily", "Weekly", "Monthly", "Quarterly",
            "Yearly"
        };

        public static string[] Payment_durationValues = {"Net 30 days", "Net 45 days", "Net 60 days"};

        public static string[] InvoicestatusValues =
        {
            "AutoCreated", "Created", "Approved", "Sent", "Credit Invoice",
            "Paid"
        };

        public static string[] CampaigntypeValues =
        {
            "--None--", "Conference", "Webinar", "Trade Show",
            "Public Relations", "Partners", "Referral Program", "Advertisement", "Banner Ads", "Direct Mail", "Email",
            "Telemarketing", "Others"
        };

        public static string[] CampaignstatusValues =
        {
            "--None--", "Planning", "Active", "Inactive", "Completed",
            "Cancelled"
        };

        public static string[] ExpectedresponseValues = {"--None--", "Excellent", "Good", "Average", "Poor"};
        public static string[] Activity_viewValues = {"Today", "This Week", "This Month", "This Year"};
        public static string[] Lead_viewValues = {"Today", "Last 2 Days", "Last Week"};
        public static string[] Date_formatValues = {"dd-mm-yyyy", "mm-dd-yyyy", "yyyy-mm-dd"};

        public static string[] Reminder_intervalValues =
        {
            "None", "1 Minute", "5 Minutes", "15 Minutes", "30 Minutes",
            "45 Minutes", "1 Hour", "1 Day"
        };

        public static string[] Tracking_unitValues = {"None", "Hours", "Days", "Incidents"};

        public static string[] Contract_statusValues =
        {
            "Undefined", "In Planning", "In Progress", "On Hold", "Complete",
            "Archived"
        };

        public static string[] Contract_priorityValues = {"Low", "Normal", "High"};
        public static string[] Contract_typeValues = {"Support", "Services", "Administrative"};
        public static string[] Service_usageunitValues = {"Hours", "Days", "Incidents"};

        public static string[] ServicecategoryValues =
        {
            "--None--", "Support", "Installation", "Migration",
            "Customization", "Training"
        };

        public static string[] AssetstatusValues = {"In Service", "Out-of-service"};
        public static string[] ProjectmilestonetypeValues = {"--none--", "administrative", "operative", "other"};
        public static string[] ProjecttasktypeValues = {"--none--", "administrative", "operative", "other"};
        public static string[] ProjecttaskpriorityValues = {"--none--", "low", "normal", "high"};

        public static string[] ProjecttaskprogressValues =
        {
            "--none--", "10%", "20%", "30%", "40%", "50%", "60%", "70%",
            "80%", "90%", "100%"
        };

        public static string[] ProjectstatusValues =
        {
            "--none--", "prospecting", "initiated", "in progress",
            "waiting for feedback", "on hold", "completed", "delivered", "archived"
        };

        public static string[] ProjecttypeValues = {"--none--", "administrative", "operative", "other"};
        public static string[] ProjectpriorityValues = {"--none--", "low", "normal", "high"};

        public static string[] ProgressValues =
        {
            "--none--", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%",
            "90%", "100%"
        };
    }

    public enum VTigerType
    {
        Undefined,
        Calendar,
        Leads,
        Accounts,
        Contacts,
        Potentials,
        Products,
        Documents,
        Emails,
        HelpDesk,
        Faq,
        Vendors,
        PriceBooks,
        Quotes,
        PurchaseOrder,
        SalesOrder,
        Invoice,
        Campaigns,
        Events,
        Users,
        PBXManager,
        ServiceContracts,
        Services,
        Assets,
        ModComments,
        ProjectMilestone,
        ProjectTask,
        Project,
        SMSNotifier,
        Groups,
        Currency,
        DocumentFolders
    }

    public partial class VTiger
    {
        public static Type[] VTigerTypeClasses =
        {
            typeof (VTigerEntity),
            typeof (VTigerCalendar), typeof (VTigerLead), typeof (VTigerAccount),
            typeof (VTigerContact), typeof (VTigerPotential), typeof (VTigerProduct),
            typeof (VTigerDocument), typeof (VTigerEmail), typeof (VTigerHelpDesk),
            typeof (VTigerFaq), typeof (VTigerVendor), typeof (VTigerPriceBook),
            typeof (VTigerQuote), typeof (VTigerPurchaseOrder), typeof (VTigerSalesOrder),
            typeof (VTigerInvoice), typeof (VTigerCampaign), typeof (VTigerEvent),
            typeof (VTigerUser), typeof (VTigerPBXManager), typeof (VTigerServiceContract),
            typeof (VTigerService), typeof (VTigerAsset), typeof (VTigerModComment),
            typeof (VTigerProjectMilestone), typeof (VTigerProjectTask),
            typeof (VTigerProject), typeof (VTigerSMSNotifier), typeof (VTigerGroup),
            typeof (VTigerCurrency), typeof (VTigerDocumentFolder)
        };
    }

    #region Element-Classes

    public class VTigerEntity
    {
        public string id;

        public VTigerType elementType
        {
            get { return GetElementType(); }
        }

        public virtual VTigerType GetElementType()
        {
            return VTigerType.Undefined;
        }
    }

    /// <summary>
    ///     VTiger-Calendar object
    /// </summary>
    public class VTigerCalendar : VTigerEntity
    {
        public Activitytype activitytype;
        public string assigned_user_id; //mandatory
        public string contact_id;
        public DateTime createdtime;
        public string date_start; //mandatory
        public string description;
        public string due_date; //mandatory
        public string duration_hours;
        public Duration_minutes duration_minutes;
        public Eventstatus eventstatus;
        public string location;
        public DateTime modifiedtime;
        public bool notime;
        public string parent_id;
        public RecurringType recurringtype;
        public int reminder_time;
        public bool sendnotification;
        public string subject; //mandatory
        public Taskpriority taskpriority;
        public TaskStatus taskstatus; //mandatory
        public string time_end;
        public string time_start;
        public Visibility visibility;

        public VTigerCalendar()
        {
        }

        public VTigerCalendar(string subject, string assigned_user_id, string date_start, string due_date,
            TaskStatus taskstatus)
        {
            this.subject = subject;
            this.assigned_user_id = assigned_user_id;
            this.date_start = date_start;
            this.due_date = due_date;
            this.taskstatus = taskstatus;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Calendar;
        }
    }

    /// <summary>
    ///     VTiger-Leads object
    /// </summary>
    public class VTigerLead : VTigerEntity
    {
        public int annualrevenue;
        public string assigned_user_id; //mandatory
        public string city;
        public string code;
        public string company; //mandatory
        public string country;
        public DateTime createdtime;
        public string description;
        public string designation;
        public string email;
        public string fax;
        public string firstname;
        public Industry industry;
        public string lane;
        public string lastname; //mandatory
        public string lead_no;
        public Leadsource leadsource;
        public Leadstatus leadstatus;
        public string mobile;
        public DateTime modifiedtime;
        public int noofemployees;
        public string phone;
        public string pobox;
        public Rating rating;
        public string salutationtype;
        public string state;
        public string website;
        public string yahooid;

        public VTigerLead()
        {
        }

        public VTigerLead(string lastname, string company, string assigned_user_id)
        {
            this.lastname = lastname;
            this.company = company;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Leads;
        }
    }

    /// <summary>
    ///     VTiger-Accounts object
    /// </summary>
    public class VTigerAccount : VTigerEntity
    {
        public string account_id;
        public string account_no;
        public string accountname; //mandatory
        public Accounttype accounttype;
        public int annual_revenue;
        public string assigned_user_id; //mandatory
        public string bill_city;
        public string bill_code;
        public string bill_country;
        public string bill_pobox;
        public string bill_state;
        public string bill_street;
        public DateTime createdtime;
        public string description;
        public string email1;
        public string email2;
        public bool emailoptout;
        public int employees;
        public string fax;
        public Industry industry;
        public DateTime modifiedtime;
        public bool notify_owner;
        public string otherphone;
        public string ownership;
        public string phone;
        public Rating rating;
        public string ship_city;
        public string ship_code;
        public string ship_country;
        public string ship_pobox;
        public string ship_state;
        public string ship_street;
        public string siccode;
        public string tickersymbol;
        public string website;

        public VTigerAccount()
        {
        }

        public VTigerAccount(string accountname, string assigned_user_id)
        {
            this.accountname = accountname;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Accounts;
        }
    }

    /// <summary>
    ///     VTiger-Contacts object
    /// </summary>
    public class VTigerContact : VTigerEntity
    {
        public string account_id;
        public string assigned_user_id; //mandatory
        public string assistant;
        public string assistantphone;
        public string birthday;
        public string contact_id;
        public string contact_no;
        public DateTime createdtime;
        public string department;
        public string description;
        public bool donotcall;
        public string email;
        public bool emailoptout;
        public string fax;
        public string firstname;
        public string homephone;
        public string lastname; //mandatory
        public Leadsource leadsource;
        public string mailingcity;
        public string mailingcountry;
        public string mailingpobox;
        public string mailingstate;
        public string mailingstreet;
        public string mailingzip;
        public string mobile;
        public DateTime modifiedtime;
        public bool notify_owner;
        public string othercity;
        public string othercountry;
        public string otherphone;
        public string otherpobox;
        public string otherstate;
        public string otherstreet;
        public string otherzip;
        public string phone;
        public bool portal;
        public bool reference;
        public string salutationtype;
        public string support_end_date;
        public string support_start_date;
        public string title;
        public string yahooid;

        public VTigerContact()
        {
        }

        public VTigerContact(string lastname, string assigned_user_id)
        {
            this.lastname = lastname;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Contacts;
        }
    }

    /// <summary>
    ///     VTiger-Potentials object
    /// </summary>
    public class VTigerPotential : VTigerEntity
    {
        public double amount;
        public string assigned_user_id; //mandatory
        public string campaignid;
        public string closingdate; //mandatory
        public DateTime createdtime;
        public string description;
        public Leadsource leadsource;
        public DateTime modifiedtime;
        public string nextstep;
        public Opportunity_type opportunity_type;
        public string potential_no;
        public string potentialname; //mandatory
        public double probability;
        public string related_to; //mandatory
        public Sales_stage sales_stage; //mandatory

        public VTigerPotential()
        {
        }

        public VTigerPotential(string potentialname, string related_to, string closingdate, Sales_stage sales_stage,
            string assigned_user_id)
        {
            this.potentialname = potentialname;
            this.related_to = related_to;
            this.closingdate = closingdate;
            this.sales_stage = sales_stage;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Potentials;
        }
    }

    /// <summary>
    ///     VTiger-Products object
    /// </summary>
    public class VTigerProduct : VTigerEntity
    {
        public string assigned_user_id;
        public double commissionrate;
        public DateTime createdtime;
        public string description;
        public bool discontinued;
        public string expiry_date;
        public string glacct;
        public string manufacturer;
        public string mfr_part_no;
        public DateTime modifiedtime;
        public string product_no;
        public string productcategory;
        public string productcode;
        public string productname; //mandatory
        public string productsheet;
        public double qty_per_unit;
        public int qtyindemand;
        public double qtyinstock;
        public int reorderlevel;
        public string sales_end_date;
        public string sales_start_date;
        public string serial_no;
        public string start_date;
        public string taxclass;
        public double unit_price;
        public string usageunit;
        public string vendor_id;
        public string vendor_part_no;
        public string website;

        public VTigerProduct()
        {
        }

        public VTigerProduct(string productname)
        {
            this.productname = productname;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Products;
        }
    }

    /// <summary>
    ///     VTiger-Documents object
    /// </summary>
    public class VTigerDocument : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public int filedownloadcount;
        public string filelocationtype;
        public string filename;
        public int filesize;
        public bool filestatus;
        public string filetype;
        public string fileversion;
        public string folderid;
        public DateTime modifiedtime;
        public string note_no;
        public string notecontent;
        public string notes_title; //mandatory

        public VTigerDocument()
        {
        }

        public VTigerDocument(string notes_title, string assigned_user_id)
        {
            this.notes_title = notes_title;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Documents;
        }
    }

    /// <summary>
    ///     VTiger-Emails object
    /// </summary>
    public class VTigerEmail : VTigerEntity
    {
        public string access_count;
        public string activitytype;
        public string assigned_user_id; //mandatory
        public EmailAdresses bccmail;
        public EmailAdresses ccmail;
        public DateTime createdtime;
        public string date_start; //mandatory
        public string description;
        public Email_flag email_flag;
        public string filename;
        public string from_email; //mandatory
        public DateTime modifiedtime;
        public string parent_id;
        [JsonExcludeExport] public string parent_type; //Read-only
        public EmailAdresses saved_toid; //mandatory
        public string subject; //mandatory
        public string time_start;

        public VTigerEmail()
        {
        }

        public VTigerEmail(string subject, DateTime date_start, string from_email, string[] saved_toid,
            string assigned_user_id)
        {
            this.date_start = VTiger.DateTimeToVtDate(date_start);
            this.assigned_user_id = assigned_user_id;
            this.subject = subject;
            this.from_email = from_email;
            //this.saved_toid = JsonConvert.ExportToString(saved_toid);
            this.saved_toid.Adresses = saved_toid;
            activitytype = "Emails";
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Emails;
        }
    }

    /// <summary>
    ///     VTiger-HelpDesk object
    /// </summary>
    public class VTigerHelpDesk : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public int days;
        public string description;
        public int hours;
        public DateTime modifiedtime;
        public string parent_id;
        public string product_id;
        public string solution;
        public string ticket_no;
        public string ticket_title; //mandatory
        public Ticketcategories ticketcategories;
        public Ticketpriorities ticketpriorities;
        public Ticketseverities ticketseverities;
        public Ticketstatus ticketstatus; //mandatory
        public string update_log;

        public VTigerHelpDesk()
        {
        }

        public VTigerHelpDesk(string assigned_user_id, Ticketstatus ticketstatus, string ticket_title)
        {
            this.assigned_user_id = assigned_user_id;
            this.ticketstatus = ticketstatus;
            this.ticket_title = ticket_title;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.HelpDesk;
        }
    }

    /// <summary>
    ///     VTiger-Faq object
    /// </summary>
    public class VTigerFaq : VTigerEntity
    {
        public DateTime createdtime;
        public string faq_answer; //mandatory
        public string faq_no;
        public Faqcategories faqcategories;
        public Faqstatus faqstatus; //mandatory
        public DateTime modifiedtime;
        public string product_id;
        public string question; //mandatory

        public VTigerFaq()
        {
        }

        public VTigerFaq(Faqstatus faqstatus, string question, string faq_answer)
        {
            this.faqstatus = faqstatus;
            this.question = question;
            this.faq_answer = faq_answer;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Faq;
        }
    }

    /// <summary>
    ///     VTiger-Vendors object
    /// </summary>
    public class VTigerVendor : VTigerEntity
    {
        public string category;
        public string city;
        public string country;
        public DateTime createdtime;
        public string description;
        public string email;
        public string glacct;
        public DateTime modifiedtime;
        public string phone;
        public string pobox;
        public string postalcode;
        public string state;
        public string street;
        public string vendor_no;
        public string vendorname; //mandatory
        public string website;

        public VTigerVendor()
        {
        }

        public VTigerVendor(string vendorname)
        {
            this.vendorname = vendorname;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Vendors;
        }
    }

    /// <summary>
    ///     VTiger-PriceBooks object
    /// </summary>
    public class VTigerPriceBook : VTigerEntity
    {
        public bool active;
        public string bookname; //mandatory
        public DateTime createdtime;
        public string currency_id; //mandatory
        public string description;
        public DateTime modifiedtime;
        public string pricebook_no;

        public VTigerPriceBook()
        {
        }

        public VTigerPriceBook(string bookname, string currency_id)
        {
            this.bookname = bookname;
            this.currency_id = currency_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.PriceBooks;
        }
    }

    /// <summary>
    ///     VTiger-Quotes object
    /// </summary>
    public class VTigerQuote : VTigerEntity
    {
        public string account_id; //mandatory
        public string assigned_user_id; //mandatory
        public string assigned_user_id1;
        public string bill_city;
        public string bill_code;
        public string bill_country;
        public string bill_pobox;
        public string bill_state;
        public string bill_street; //mandatory
        public string carrier;
        public string contact_id;
        public double conversion_rate;
        public DateTime createdtime;
        public string currency_id;
        public string description;
        public double hdnDiscountAmount;
        public double hdnDiscountPercent;
        public double hdnGrandTotal;
        public double hdnS_H_Amount;
        public double hdnSubTotal;
        public HdnTaxType hdnTaxType;
        public DateTime modifiedtime;
        public string potential_id;
        public string quote_no;
        public Quotestage quotestage; //mandatory
        public string ship_city;
        public string ship_code;
        public string ship_country;
        public string ship_pobox;
        public string ship_state;
        public string ship_street; //mandatory
        public string shipping;
        public string subject; //mandatory
        public string terms_conditions;
        public double txtAdjustment;
        public string validtill;

        public VTigerQuote()
        {
        }

        public VTigerQuote(string subject, Quotestage quotestage, string bill_street,
            string ship_street, string account_id, string assigned_user_id)
        {
            this.subject = subject;
            this.quotestage = quotestage;
            this.account_id = account_id;
            this.assigned_user_id = assigned_user_id;
            this.bill_street = bill_street;
            this.ship_street = ship_street;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Quotes;
        }
    }

    /// <summary>
    ///     VTiger-PurchaseOrder object
    /// </summary>
    public class VTigerPurchaseOrder : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public string bill_city;
        public string bill_code;
        public string bill_country;
        public string bill_pobox;
        public string bill_state;
        public string bill_street; //mandatory
        public string carrier;
        public string contact_id;
        public double conversion_rate;
        public DateTime createdtime;
        public string currency_id;
        public string description;
        public string duedate;
        public double exciseduty;
        public double hdnDiscountAmount;
        public double hdnDiscountPercent;
        public double hdnGrandTotal;
        public double hdnS_H_Amount;
        public double hdnSubTotal;
        public HdnTaxType hdnTaxType;
        public DateTime modifiedtime;
        public PoStatus postatus; //mandatory
        public string purchaseorder_no;
        public string requisition_no;
        public double salescommission;
        public string ship_city;
        public string ship_code;
        public string ship_country;
        public string ship_pobox;
        public string ship_state;
        public string ship_street; //mandatory
        public string subject; //mandatory
        public string terms_conditions;
        public string tracking_no;
        public double txtAdjustment;
        public string vendor_id; //mandatory

        public VTigerPurchaseOrder()
        {
        }

        public VTigerPurchaseOrder(string subject, string vendor_id, PoStatus postatus,
            string bill_street, string ship_street, string assigned_user_id)
        {
            this.subject = subject;
            this.vendor_id = vendor_id;
            this.postatus = postatus;
            this.assigned_user_id = assigned_user_id;
            this.bill_street = bill_street;
            this.ship_street = ship_street;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.PurchaseOrder;
        }
    }

    /// <summary>
    ///     VTiger-SalesOrder object
    /// </summary>
    public class VTigerSalesOrder : VTigerEntity
    {
        public string account_id; //mandatory
        public string assigned_user_id; //mandatory
        public string bill_city;
        public string bill_code;
        public string bill_country;
        public string bill_pobox;
        public string bill_state;
        public string bill_street; //mandatory
        public string carrier;
        public string contact_id;
        public double conversion_rate;
        public DateTime createdtime;
        public string currency_id;
        public string customerno;
        public string description;
        public string duedate;
        public bool enable_recurring;
        public string end_period;
        public double exciseduty;
        public double hdnDiscountAmount;
        public double hdnDiscountPercent;
        public double hdnGrandTotal;
        public double hdnS_H_Amount;
        public double hdnSubTotal;
        public HdnTaxType hdnTaxType;
        public Invoicestatus invoicestatus; //mandatory
        public DateTime modifiedtime;
        public Payment_duration payment_duration;
        public string pending;
        public string potential_id;
        public string quote_id;
        public Recurring_frequency recurring_frequency;
        public double salescommission;
        public string salesorder_no;
        public string ship_city;
        public string ship_code;
        public string ship_country;
        public string ship_pobox;
        public string ship_state;
        public string ship_street; //mandatory
        public SoStatus sostatus; //mandatory
        public string start_period;
        public string subject; //mandatory
        public string terms_conditions;
        public double txtAdjustment;
        public string vtiger_purchaseorder;

        public VTigerSalesOrder()
        {
        }

        public VTigerSalesOrder(string subject, SoStatus sostatus, string bill_street,
            string ship_street, Invoicestatus invoicestatus, string account_id, string assigned_user_id)
        {
            this.subject = subject;
            this.sostatus = sostatus;
            this.account_id = account_id;
            this.assigned_user_id = assigned_user_id;
            this.bill_street = bill_street;
            this.ship_street = ship_street;
            this.invoicestatus = invoicestatus;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.SalesOrder;
        }
    }

    /// <summary>
    ///     VTiger-Invoice object
    /// </summary>
    public class VTigerInvoice : VTigerEntity
    {
        public string account_id; //mandatory
        public string assigned_user_id; //mandatory
        public string bill_city;
        public string bill_code;
        public string bill_country;
        public string bill_pobox;
        public string bill_state;
        public string bill_street; //mandatory
        public string contact_id;
        public double conversion_rate;
        public DateTime createdtime;
        public string currency_id;
        public string customerno;
        public string description;
        public string duedate;
        public double exciseduty;
        public double hdnDiscountAmount;
        public double hdnDiscountPercent;
        public double hdnGrandTotal;
        public double hdnSubTotal;
        public HdnTaxType hdnTaxType;
        public string invoice_no;
        public string invoicedate;
        public Invoicestatus invoicestatus;
        public DateTime modifiedtime;
        public double salescommission;
        public string salesorder_id;
        public string ship_city;
        public string ship_code;
        public string ship_country;
        public string ship_pobox;
        public string ship_state;
        public string ship_street; //mandatory
        public string subject; //mandatory
        public string terms_conditions;
        public double txtAdjustment;
        public string vtiger_purchaseorder;

        public VTigerInvoice()
        {
        }

        public VTigerInvoice(string subject, string bill_street, string ship_street,
            string account_id, string assigned_user_id)
        {
            this.subject = subject;
            this.account_id = account_id;
            this.assigned_user_id = assigned_user_id;
            this.bill_street = bill_street;
            this.ship_street = ship_street;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Invoice;
        }
    }

    /// <summary>
    ///     VTiger-Campaigns object
    /// </summary>
    public class VTigerCampaign : VTigerEntity
    {
        public double actualcost;
        public int actualresponsecount;
        public double actualroi;
        public int actualsalescount;
        public string assigned_user_id; //mandatory
        public double budgetcost;
        public string campaign_no;
        public string campaignname; //mandatory
        public Campaignstatus campaignstatus;
        public Campaigntype campaigntype;
        public string closingdate; //mandatory
        public DateTime createdtime;
        public string description;
        public Expectedresponse expectedresponse;
        public int expectedresponsecount;
        public double expectedrevenue;
        public double expectedroi;
        public int expectedsalescount;
        public DateTime modifiedtime;
        public double numsent;
        public string product_id;
        public string sponsor;
        public string targetaudience;
        public int targetsize;

        public VTigerCampaign()
        {
        }

        public VTigerCampaign(string campaignname, DateTime closingDate, string assigned_user_id)
        {
            this.campaignname = campaignname;
            closingdate = VTiger.DateTimeToVtDate(closingDate);
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Campaigns;
        }
    }

    /// <summary>
    ///     VTiger-Events object
    /// </summary>
    public class VTigerEvent : VTigerEntity
    {
        public Activitytype activitytype; //mandatory
        public string assigned_user_id; //mandatory
        public string contact_id;
        public DateTime createdtime;
        public string date_start; //mandatory
        public string description;
        public string due_date; //mandatory
        public int duration_hours; //mandatory
        public Duration_minutes duration_minutes;
        public Eventstatus eventstatus; //mandatory
        public string location;
        public DateTime modifiedtime;
        public bool notime;
        public string parent_id;
        public RecurringType recurringtype;
        public int reminder_time;
        public bool sendnotification;
        public string subject; //mandatory
        public Taskpriority taskpriority;
        public string time_end; //mandatory
        public string time_start; //mandatory
        public Visibility visibility;

        public VTigerEvent()
        {
        }

        public VTigerEvent(string subject, string date_start, string time_start, string due_date,
            string time_end, int duration_hours, Eventstatus eventstatus,
            Activitytype activitytype, string assigned_user_id)
        {
            this.subject = subject;
            this.assigned_user_id = assigned_user_id;
            this.date_start = date_start;
            this.time_start = time_start;
            this.due_date = due_date;
            this.time_end = time_end;
            this.duration_hours = duration_hours;
            this.eventstatus = eventstatus;
            this.activitytype = activitytype;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Events;
        }
    }

    /// <summary>
    ///     VTiger-Users object
    /// </summary>
    public class VTigerUser : VTigerEntity
    {
        public string accesskey;
        public Activity_view activity_view;
        public string address_city;
        public string address_country;
        public string address_postalcode;
        public string address_state;
        public string address_street;
        public string asterisk_extension;
        public string confirm_password; //mandatory
        public string currency_id;
        public Date_format date_format;
        public string department;
        public string description;
        public string email1; //mandatory
        public string email2;
        public string end_hour;
        public string first_name;
        public string hour_format;
        public bool internal_mailer;
        public bool is_admin;
        public string last_name; //mandatory
        public Lead_view lead_view;
        public string phone_fax;
        public string phone_home;
        public string phone_mobile;
        public string phone_other;
        public string phone_work;
        public Reminder_interval reminder_interval;
        public string reports_to_id;
        public string roleid; //mandatory
        public string signature;
        public string start_hour;
        public string status;
        public string title;
        public bool use_asterisk;
        public string user_name; //mandatory
        public string user_password; //mandatory
        public string yahoo_id;

        public VTigerUser()
        {
        }

        public VTigerUser(string user_name, string user_password, string confirm_password, string last_name,
            string roleid, string email1)
        {
            this.user_name = user_name;
            this.user_password = user_password;
            this.confirm_password = confirm_password;
            this.last_name = last_name;
            this.roleid = roleid;
            this.email1 = email1;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Users;
        }
    }

    /// <summary>
    ///     VTiger-PBXManager object
    /// </summary>
    public class VTigerPBXManager : VTigerEntity
    {
        public string callfrom; //mandatory
        public string callto; //mandatory
        public string status;
        public string timeofcall;

        public VTigerPBXManager()
        {
        }

        public VTigerPBXManager(string callfrom, string callto)
        {
            this.callfrom = callfrom;
            this.callto = callto;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.PBXManager;
        }
    }

    /// <summary>
    ///     VTiger-ServiceContracts object
    /// </summary>
    public class VTigerServiceContract : VTigerEntity
    {
        public string actual_duration;
        public string assigned_user_id; //mandatory
        public string contract_no;
        public Contract_priority contract_priority;
        public Contract_status contract_status;
        public Contract_type contract_type;
        public string createdtime;
        public string due_date;
        public string end_date;
        public string modifiedtime;
        public string planned_duration;
        public double progress;
        public string sc_related_to;
        public string start_date;
        public string subject; //mandatory
        public string total_units;
        public Tracking_unit tracking_unit;
        public string used_units;

        public VTigerServiceContract()
        {
        }

        public VTigerServiceContract(string subject, string assigned_user_id)
        {
            this.assigned_user_id = assigned_user_id;
            this.subject = subject;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.ServiceContracts;
        }
    }

    /// <summary>
    ///     VTiger-Services object
    /// </summary>
    public class VTigerService : VTigerEntity
    {
        public string assigned_user_id;
        public double commissionrate;
        public DateTime createdtime;
        public string description;
        public bool discontinued;
        public string expiry_date;
        public DateTime modifiedtime;
        public double qty_per_unit;
        public string sales_end_date;
        public string sales_start_date;
        public string service_no;
        public Service_usageunit service_usageunit;
        public Servicecategory servicecategory;
        public string servicename; //mandatory
        public string start_date;
        public string taxclass;
        public double unit_price;
        public string website;

        public VTigerService()
        {
        }

        public VTigerService(string servicename)
        {
            this.servicename = servicename;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Services;
        }
    }

    /// <summary>
    ///     VTiger-Assets object
    /// </summary>
    public class VTigerAsset : VTigerEntity
    {
        public string account; //mandatory
        public string asset_no;
        public string assetname; //mandatory
        public Assetstatus assetstatus; //mandatory
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public string dateinservice; //mandatory
        public string datesold; //mandatory
        public string description;
        public string invoiceid;
        public DateTime modifiedtime;
        public string product; //mandatory
        public string serialnumber; //mandatory
        public string shippingmethod;
        public string shippingtrackingnumber;
        public string tagnumber;

        public VTigerAsset()
        {
        }

        public VTigerAsset(string product, string serialnumber, string datesold,
            string dateinservice, Assetstatus assetstatus, string assetname,
            string account, string assigned_user_id)
        {
            this.product = product;
            this.serialnumber = serialnumber;
            this.datesold = datesold;
            this.dateinservice = dateinservice;
            this.assetstatus = assetstatus;
            this.assigned_user_id = assigned_user_id;
            this.assetname = assetname;
            this.account = account;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Assets;
        }
    }

    /// <summary>
    ///     VTiger-ModComments object
    /// </summary>
    public class VTigerModComment : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public string commentcontent; //mandatory
        public DateTime createdtime;
        public string creator;
        public DateTime modifiedtime;
        public string parent_comments;
        public string related_to; //mandatory

        public VTigerModComment()
        {
        }

        public VTigerModComment(string commentcontent, string assigned_user_id, string related_to)
        {
            this.commentcontent = commentcontent;
            this.assigned_user_id = assigned_user_id;
            this.related_to = related_to;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.ModComments;
        }
    }

    /// <summary>
    ///     VTiger-ProjectMilestone object
    /// </summary>
    public class VTigerProjectMilestone : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public string description;
        public DateTime modifiedtime;
        public string projectid; //mandatory
        public string projectmilestone_no;
        public string projectmilestonedate;
        public string projectmilestonename; //mandatory
        public Projectmilestonetype projectmilestonetype;

        public VTigerProjectMilestone()
        {
        }

        public VTigerProjectMilestone(string projectmilestonename, string projectid, string assigned_user_id)
        {
            this.projectmilestonename = projectmilestonename;
            this.projectid = projectid;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.ProjectMilestone;
        }
    }

    /// <summary>
    ///     VTiger-ProjectTask object
    /// </summary>
    public class VTigerProjectTask : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public string description;
        public string enddate;
        public DateTime modifiedtime;
        public string projectid; //mandatory
        public string projecttask_no;
        public string projecttaskhours;
        public string projecttaskname; //mandatory
        public int projecttasknumber;
        public Projecttaskpriority projecttaskpriority;
        public Projecttaskprogress projecttaskprogress;
        public Projecttasktype projecttasktype;
        public string startdate;

        public VTigerProjectTask()
        {
        }

        public VTigerProjectTask(string projecttaskname, string projectid, string assigned_user_id)
        {
            this.projecttaskname = projecttaskname;
            this.projectid = projectid;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.ProjectTask;
        }
    }

    /// <summary>
    ///     VTiger-Project object
    /// </summary>
    public class VTigerProject : VTigerEntity
    {
        public string actualenddate;
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public string description;
        public string linktoaccountscontacts;
        public DateTime modifiedtime;
        public Progress progress;
        public string project_no;
        public string projectname; //mandatory
        public Projectpriority projectpriority;
        public Projectstatus projectstatus;
        public Projecttype projecttype;
        public string projecturl;
        public string startdate;
        public string targetbudget;
        public string targetenddate;

        public VTigerProject()
        {
        }

        public VTigerProject(string projectname, string assigned_user_id)
        {
            this.projectname = projectname;
            this.assigned_user_id = assigned_user_id;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Project;
        }
    }

    /// <summary>
    ///     VTiger-SMSNotifier object
    /// </summary>
    public class VTigerSMSNotifier : VTigerEntity
    {
        public string assigned_user_id; //mandatory
        public DateTime createdtime;
        public string message; //mandatory
        public DateTime modifiedtime;

        public VTigerSMSNotifier()
        {
        }

        public VTigerSMSNotifier(string assigned_user_id, string message)
        {
            this.assigned_user_id = assigned_user_id;
            this.message = message;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.SMSNotifier;
        }
    }

    /// <summary>
    ///     VTiger-Groups object
    /// </summary>
    public class VTigerGroup : VTigerEntity
    {
        public string description;
        public string groupname;

        public override VTigerType GetElementType()
        {
            return VTigerType.Groups;
        }
    }

    /// <summary>
    ///     VTiger-Currency object
    /// </summary>
    public class VTigerCurrency : VTigerEntity
    {
        public double conversion_rate;
        public string currency_code;
        public string currency_name;
        public string currency_status;
        public string currency_symbol;
        public string defaultid; //mandatory
        public int deleted; //mandatory

        public VTigerCurrency()
        {
        }

        public VTigerCurrency(string defaultid, int deleted)
        {
            this.defaultid = defaultid;
            this.deleted = deleted;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.Currency;
        }
    }

    /// <summary>
    ///     VTiger-DocumentFolders object
    /// </summary>
    public class VTigerDocumentFolder : VTigerEntity
    {
        public string createdby; //mandatory
        public string description;
        public string foldername; //mandatory
        public int sequence;

        public VTigerDocumentFolder()
        {
        }

        public VTigerDocumentFolder(string foldername, string createdby)
        {
            this.foldername = foldername;
            this.createdby = createdby;
        }

        public override VTigerType GetElementType()
        {
            return VTigerType.DocumentFolders;
        }
    }

    #endregion
}