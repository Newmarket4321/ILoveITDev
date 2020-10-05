using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ADReport : Form
    {
        public ADReport()
        {
            InitializeComponent();

            try
            {
                Text = SQL.RunString("select description from programs where code=@CODE", Name);
            }
            catch
            {

            }
        }

        private void Visa_Load(object sender, EventArgs e)
        {
            // DirectoryEntry entry = new DirectoryEntry("LDAP://DC2012R2X3");
            DirectoryEntry entry = new DirectoryEntry("LDAP://DC16MLK01");
            DirectorySearcher dSearch = new DirectorySearcher(entry);
            dSearch.Filter = "(&(objectClass=user)(title=*))";
            
            DataTable dt = new DataTable();

            SearchResultCollection sResultSetCollection = dSearch.FindAll();

            string[] columns = { "accountExpires", "accountNameHistory", "aCSPolicyName", "adminCount", "adminDescription", "adminDisplayName", "allowedAttributes", "allowedAttributesEffective", "allowedChildClasses", "allowedChildClassesEffective", "altSecurityIdentities", "assistant", "badPasswordTime", "badPwdCount", "bridgeheadServerListBL", "c", "canonicalName", "cn", "co", "codePage", "comment", "company", "controlAccessRights", "countryCode", "createTimeStamp", "dBCSPwd", "defaultClassStore", "department", "description", "desktopProfile", "destinationIndicator", "directReports", "displayName", "displayNamePrintable", "distinguishedName", "division", "dSASignature", "dSCorePropagationData", "dynamicLDAPServer", "employeeID", "extensionName", "facsimileTelephoneNumber", "flags", "fromEntry", "frsComputerReferenceBL", "fRSMemberReferenceBL", "fSMORoleOwner", "garbageCollPeriod", "generationQualifier", "givenName", "groupMembershipSAM", "groupPriority", "groupsToIgnore", "homeDirectory", "homeDrive", "homePhone", "homePostalAddress", "info", "initials", "instanceType", "internationalISDNNumber", "ipPhone", "isCriticalSystemObject", "isDeleted", "isPrivilegeHolder", "l", "lastKnownParent", "lastLogoff", "lastLogon", "legacyExchangeDN", "lmPwdHistory", "localeID", "lockoutTime", "logonCount", "logonHours", "logonWorkstation", "mail", "managedObjects", "manager", "masteredBy", "maxStorage", "memberOf", "mhsORAddress", "middleName", "mobile", "modifyTimeStamp", "mS-DS-ConsistencyChildCount", "mS-DS-ConsistencyGuid", "mS-DS-CreatorSID", "mSMQDigests", "mSMQDigestsMig", "mSMQSignCertificates", "mSMQSignCertificatesMig", "msNPAllowDialin", "msNPCallingStationID", "msNPSavedCallingStationID", "msRADIUSCallbackNumber", "msRADIUSFramedIPAddress", "msRADIUSFramedRoute", "msRADIUSServiceType", "msRASSavedCallbackNumber", "msRASSavedFramedIPAddress", "msRASSavedFramedRoute", "name", "netbootSCPBL", "networkAddress", "nonSecurityMemberBL", "ntPwdHistory", "nTSecurityDescriptor", "o", "objectCategory", "objectClass", "objectGUID", "objectSid", "objectVersion", "operatorCount", "otherFacsimileTelephoneNumber", "otherHomePhone", "otherIpPhone", "otherLoginWorkstations", "otherMailbox", "otherMobile", "otherPager", "otherTelephone", "otherWellKnownObjects", "ou", "pager", "partialAttributeDeletionList", "partialAttributeSet", "personalTitle", "physicalDeliveryOfficeName", "possibleInferiors", "postalAddress", "postalCode", "postOfficeBox", "preferredDeliveryMethod", "preferredOU", "primaryGroupID", "primaryInternationalISDNNumber", "primaryTelexNumber", "profilePath", "proxiedObjectName", "proxyAddresses", "pwdLastSet", "queryPolicyBL", "registeredAddress", "replPropertyMetaData", "replUpToDateVector", "repsFrom", "repsTo", "revision", "rid", "sAMAccountName", "sAMAccountType", "scriptPath", "sDRightsEffective", "securityIdentifier", "seeAlso", "serverReferenceBL", "servicePrincipalName", "showInAddressBook", "showInAdvancedViewOnly", "sIDHistory", "siteObjectBL", "sn", "st", "street", "streetAddress", "subRefs", "subSchemaSubEntry", "supplementalCredentials", "systemFlags", "telephoneNumber", "teletexTerminalIdentifier", "telexNumber", "terminalServer", "textEncodedORAddress", "thumbnailLogo", "thumbnailPhoto", "title", "tokenGroups", "tokenGroupsGlobalAndUniversal", "tokenGroupsNoGCAcceptable", "unicodePwd", "url", "userAccountControl", "userCert", "userCertificate", "userParameters", "userPassword", "userPrincipalName", "userSharedFolder", "userSharedFolderOther", "userSMIMECertificate", "userWorkstations", "uSNChanged", "uSNCreated", "uSNDSALastObjRemoved", "USNIntersite", "uSNLastObjRem", "uSNSource", "wbemPath", "wellKnownObjects", "whenChanged", "whenCreated", "wWWHomePage", "x121Address" };

            //string[] columns = { "userPrincipalName",               "givenName",  "sn",        "displayname",  "homePostalAddress", "title",     "telephoneNumber", "mail",           "mailnickname",    "whenCreated",     "lastlogon",  "accountexpires" };
            //string[] aliases = { "Windows Username", "First Name", "Last Name", "Display Name", "Department",        "Job Title", "Phone Number",    "E-mail Address", "E-mail Nickname", "Account Created", "Last Logon", "Account Expires" };

            for (int i = 0; i < columns.Length; i++)
                dt.Columns.Add(columns[i]);

            string[] s = new string[columns.Length];

            // get all entries from the active directory.
            // Last Name, name, initial, homepostaladdress, title, company etc..
            foreach (SearchResult sResultSet in sResultSetCollection)
            {
                for (int c = 0; c < columns.Length; c++)
                {
                    s[c] = GetProperty(sResultSet, columns[c]);

                    try
                    {
                        if (columns[c] == "accountexpires" || columns[c] == "lastlogon")
                            s[c] = DateTime.FromFileTimeUtc(long.Parse(s[c])).ToString("MMMM dd, yyyy");
                    }
                    catch
                    {
                        
                    }
                }
                
                dt.Rows.Add(s);
            }

            Report r = new Report("Active Directory Test", dt);
            r.Show();

            Close();
        }

        public static string GetProperty(SearchResult searchResult, string PropertyName)
        {
            if (searchResult.Properties.Contains(PropertyName))
            {
                return searchResult.Properties[PropertyName][0].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
