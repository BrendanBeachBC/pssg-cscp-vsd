// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// serviceendpoint
    /// </summary>
    public partial class MicrosoftDynamicsCRMserviceendpoint
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceendpoint class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceendpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMserviceendpoint class.
        /// </summary>
        public MicrosoftDynamicsCRMserviceendpoint(int? connectionmode = default(int?), bool? ismanaged = default(bool?), string solutionid = default(string), int? messageformat = default(int?), string introducedversion = default(string), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? issastokenset = default(bool?), string _modifiedonbehalfbyValue = default(string), bool? issaskeyset = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string sastoken = default(string), string serviceendpointidunique = default(string), int? componentstate = default(int?), string path = default(string), string description = default(string), string _modifiedbyValue = default(string), int? namespaceformat = default(int?), string _organizationidValue = default(string), int? contract = default(int?), string _createdbyValue = default(string), string serviceendpointid = default(string), int? authtype = default(int?), string solutionnamespace = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string namespaceaddress = default(string), int? userclaim = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string saskeyname = default(string), string name = default(string), string saskey = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> serviceendpointSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Connectionmode = connectionmode;
            Ismanaged = ismanaged;
            Solutionid = solutionid;
            Messageformat = messageformat;
            Introducedversion = introducedversion;
            Iscustomizable = iscustomizable;
            Issastokenset = issastokenset;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Issaskeyset = issaskeyset;
            Modifiedon = modifiedon;
            Sastoken = sastoken;
            Serviceendpointidunique = serviceendpointidunique;
            Componentstate = componentstate;
            Path = path;
            Description = description;
            this._modifiedbyValue = _modifiedbyValue;
            Namespaceformat = namespaceformat;
            this._organizationidValue = _organizationidValue;
            Contract = contract;
            this._createdbyValue = _createdbyValue;
            Serviceendpointid = serviceendpointid;
            Authtype = authtype;
            Solutionnamespace = solutionnamespace;
            Overwritetime = overwritetime;
            Namespaceaddress = namespaceaddress;
            Userclaim = userclaim;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Saskeyname = saskeyname;
            Name = name;
            Saskey = saskey;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            ServiceendpointSdkmessageprocessingstep = serviceendpointSdkmessageprocessingstep;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionmode")]
        public int? Connectionmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageformat")]
        public int? Messageformat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issastokenset")]
        public bool? Issastokenset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issaskeyset")]
        public bool? Issaskeyset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sastoken")]
        public string Sastoken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpointidunique")]
        public string Serviceendpointidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaceformat")]
        public int? Namespaceformat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract")]
        public int? Contract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpointid")]
        public string Serviceendpointid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authtype")]
        public int? Authtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionnamespace")]
        public string Solutionnamespace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaceaddress")]
        public string Namespaceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userclaim")]
        public int? Userclaim { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "saskeyname")]
        public string Saskeyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "saskey")]
        public string Saskey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceendpoint_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> ServiceendpointSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
