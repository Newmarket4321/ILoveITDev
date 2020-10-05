using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class CityViewReports : Form
    {
        public CityViewReports()
        {
            InitializeComponent();

            dateTimePicker1.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Day != 1)
            {
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
                MessageBox.Show("Must start from first day of the month");
            }

            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report r = new Report("StatCan Export", CityView.Run(@"
SELECT
'35019048-1' as Indicator_No,
b.APPLICATION_NUMBER AS PermitNumber,
'' as PermitSection,
'' as PermitRevisionNumber,
at.DESCRIPTION AS PermitType,
'' as PermitIssueDate,
st.BUILDINGCLASS AS BldgTypeShort,
st.DESCRIPTION AS BldgTypeDesc,
at.DESCRIPTION AS WorkTypeDesc,

CASE WHEN NO_DWELLING_UNITS IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE NO_DWELLING_UNITS
END AS PermitNoUnits,

CASE WHEN b.SQUARE_FOOTAGE IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.SQUARE_FOOTAGE
END AS PermitGrossFlArea,

'F' AS UnitOfMeasure,

CASE WHEN b.ESTIMATED_COST IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.ESTIMATED_COST
END AS PermitConstValue,

CASE WHEN a.PLAN IS NULL
THEN ' '
ELSE 'PLAN ' || Trim(a.PLAN)
END AS qPermitRegdPlan,

CASE WHEN a.LOT IS NULL
THEN ' '
ELSE 'LOT  ' || Trim(a.LOT)
END AS qPermitRegPlanLotNo1,

CASE
WHEN STREET_NAME IS NULL
    THEN 'NO LOCATION'
WHEN a.STREET_NUMBER IS NULL or trim(a.STREET_NUMBER) = ''
    THEN 'NO LOCATION'
WHEN a.UNIT_NUMBER IS NULL
    THEN Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME))
ELSE Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME) || ' ' || Trim(a.UNIT_NUMBER))
END AS qLocation,

ao.OWNER_NAME,
st.BLDGTYPESTATCANBLDGCODE,
st.BUILDINGCLASS

FROM SYSADMIN.ASSESS a
RIGHT JOIN SYSADMIN.BUILDING_PERMITS b ON a.RECORDID = b.ASSESS_ID
RIGHT JOIN SYSADMIN.LookupStructureType st ON st.CODE = b.CONSTRUCTION_TYPE
RIGHT JOIN SYSADMIN.LookupApplicationType at ON at.CODE = b.APPLICATION_TYPE
LEFT JOIN
    (SELECT
        o.NAME AS OWNER_NAME,
        o.OCCUPANCY_STATUS,
        o.SEQ_NO,
        a1.RECORDID as ARID,
        o.RECORDID as ORID,
        b1.RECORDID as BRID
    FROM SYSADMIN.ASSESS a1
    INNER JOIN SYSADMIN.OWNER o ON a1.RECORDID = o.PARENTID
    INNER JOIN SYSADMIN.BUILDING_PERMITS b1 ON a1.RECORDID = b1.ASSESS_ID
    WHERE o.SEQ_NO = '001') ao ON b.RECORDID = ao.BRID

WHERE b.BUILDINGPERMIT_ISSUEDATE >= @DATEFROM
AND b.BUILDINGPERMIT_ISSUEDATE <= @DATETO
AND at.DESCRIPTION <> 'Bylaws'

GROUP BY
'35019048-1',
b.APPLICATION_NUMBER,
'',
'',
at.DESCRIPTION,
'',
st.BUILDINGCLASS,
st.DESCRIPTION,
at.DESCRIPTION,

CASE WHEN NO_DWELLING_UNITS IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE NO_DWELLING_UNITS
END,

CASE WHEN b.SQUARE_FOOTAGE IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.SQUARE_FOOTAGE
END,

'F',

CASE WHEN b.ESTIMATED_COST IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.ESTIMATED_COST
END,

CASE WHEN a.PLAN IS NULL
THEN ' '
ELSE 'PLAN ' || Trim(a.PLAN)
END,

CASE WHEN a.LOT IS NULL
THEN ' '
ELSE 'LOT  ' || Trim(a.LOT)
END,

CASE
WHEN STREET_NAME IS NULL
    THEN 'NO LOCATION'
WHEN a.STREET_NUMBER IS NULL or trim(a.STREET_NUMBER) = ''
    THEN 'NO LOCATION'
WHEN a.UNIT_NUMBER IS NULL
    THEN Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME))
ELSE Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME) || ' ' || Trim(a.UNIT_NUMBER))
END,

ao.OWNER_NAME,
st.BLDGTYPESTATCANBLDGCODE,
st.BUILDINGCLASS

", dateTimePicker1.Value, dateTimePicker2.Value));

            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report r = new Report("Permit File", CityView.Run(@"
SELECT

CASE WHEN SUBSTR(ROLL_NUM,0,4) <> '1948' THEN '1948' || ROLL_NUM ELSE ROLL_NUM END as fPermitRollNo,
b.APPLICATION_YEAR AS PermitYear,
b.APPLICATION_NUMBER AS PermitNumber,
b.SECTION AS PermitSection,
b.REVISION AS PermitRevisionNumber,
at.DESCRIPTION AS PermitType,
b.APPLICATION_DATE,
b.BUILDINGPERMIT_ISSUEDATE AS PermitIssueDate,
b.OCCUPANCYPERMIT_ISSUEDATE AS OCCUPANCY_DATE,
st.BUILDINGCLASS AS BldgTypeShort,
st.DESCRIPTION AS BldgTypeDesc,
at.DESCRIPTION AS WorkTypeDesc,

CASE WHEN NO_DWELLING_UNITS IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE NO_DWELLING_UNITS
END AS PermitNoUnits,

CASE WHEN b.SQUARE_FOOTAGE IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.SQUARE_FOOTAGE
END AS PermitGrossFlArea,

'F' AS UnitOfMeasure,

CASE WHEN b.ESTIMATED_COST IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.ESTIMATED_COST
END AS PermitConstValue,

CASE WHEN a.PLAN IS NULL
THEN ' '
ELSE 'PLAN ' || Trim(a.PLAN)
END AS qPermitRegdPlan,

CASE WHEN a.LOT IS NULL
THEN ' '
ELSE 'LOT  ' || Trim(a.LOT)
END AS qPermitRegPlanLotNo1,

CASE
WHEN STREET_NAME IS NULL
    THEN 'NO LOCATION'
WHEN a.STREET_NUMBER IS NULL or trim(a.STREET_NUMBER) = ''
    THEN 'NO LOCATION'
WHEN a.UNIT_NUMBER IS NULL
    THEN Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME))
ELSE Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME) || ' ' || Trim(a.UNIT_NUMBER))
END AS qLocation,

a1.OWNER_NAME,
b.STATSCANCODE,
b.APPLICATION_TYPE

FROM SYSADMIN.ASSESS a
RIGHT JOIN SYSADMIN.BUILDING_PERMITS b ON a.RECORDID = b.ASSESS_ID
RIGHT JOIN SYSADMIN.LookupStructureType st ON st.CODE = b.CONSTRUCTION_TYPE
RIGHT JOIN SYSADMIN.LookupApplicationType at ON at.CODE = b.APPLICATION_TYPE
LEFT JOIN (SELECT
        o.NAME AS OWNER_NAME,
        o.OCCUPANCY_STATUS,
        o.SEQ_NO,
        a1.RECORDID as ARID,
        o.RECORDID as ORID,
        b1.RECORDID as BRID
    FROM SYSADMIN.ASSESS a1
    INNER JOIN SYSADMIN.OWNER o ON a1.RECORDID = o.PARENTID
    INNER JOIN SYSADMIN.BUILDING_PERMITS b1 ON a1.RECORDID = b1.ASSESS_ID
    WHERE o.SEQ_NO = '001') a1 ON b.RECORDID = a1.BRID

WHERE at.DESCRIPTION <> 'Bylaws'
AND b.BUILDINGPERMIT_ISSUEDATE >= @DATEFROM
AND b.BUILDINGPERMIT_ISSUEDATE <= @DATETO

ORDER BY b.BUILDINGPERMIT_ISSUEDATE

            ", dateTimePicker1.Value, dateTimePicker2.Value));

            r.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Report r = new Report("MPAC File", CityView.Run(@"
SELECT
Null AS FOLDERSSN,
'1948' || SUBSTR(SUBSTR(a.ROLL_NUM,-15,15),0,11) AS ROLL_NUM,
Null AS SUB_ROLL_NUM,
Null AS PROPHOUSE,
Null AS PROPSTREET,
Null AS PROPUNITTYPE,
Null AS PROPUNIT,
'NEWMARKET' AS PROPCITY,
'ON' AS PROPPROVINCE,
Null AS PROPPOSTAL,

CASE
WHEN STREET_NAME IS NULL
    THEN ' '
WHEN a.STREET_NUMBER IS NULL or trim(a.STREET_NUMBER) = ''
    THEN ' '
WHEN a.UNIT_NUMBER IS NULL
    THEN Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME))
ELSE Trim(to_number(a.STREET_NUMBER) || ' ' || Trim(a.STREET_NAME) || ' Unit ' || Trim(a.UNIT_NUMBER))
END AS MUNADDRESS,

CASE
WHEN a.PLAN IS NULL
    THEN ' '
ELSE
    CASE WHEN a.LOT IS NULL
        THEN 'PLAN ' || Trim(a.PLAN)
    ELSE
        'PLAN ' || Trim(a.PLAN) || ' LOT ' || Trim(a.LOT)
    END
END AS LEGALDESC,

Null AS ZONETYPE1,
Null AS ZONETYPE2,
Null AS ZONETYPE3,
Null AS ZONETYPE4,
Null AS ZONETYPE5,
b.APPLICATION_NUMBER AS PERNUMBER,
to_char(APPLICATION_DATE,'yyyymmdd') AS RECDDT,
to_char(BUILDINGPERMIT_ISSUEDATE,'yyyymmdd') AS ISSUEDT,
Null AS CANCELLEDDT,
Null AS OCCUPANCYDT,
Null AS FINALDT,

to_char(BUILDINGPERMIT_ISSUEDATE, 'MMYY') AS REPORTMONTHYEAR, 

Null AS GFASQFT,
Null AS GROSSAREAM2,
Null AS UNITSCREATED,

CASE WHEN b.ESTIMATED_COST IS NULL Or substr(APPLICATION_NUMBER,-1,1)='b' Or substr(APPLICATION_NUMBER,-1,1)='B'
THEN 0
ELSE b.ESTIMATED_COST
END AS PERMITVALUE,

st.BUILDINGCLASS AS SUBDESC,
b.STATSCANCODE AS STATCANBLDGDESC,
st.BUILDINGCLASS AS WORKDESC,

CASE WHEN at.CODE='999' THEN ' ' ELSE at.CODE END AS STATCANWORKDESC,

b.DESCRIPTION AS FOLDERDESC,
Null AS PERMITCOMMENTS,
a1.OWNER_NAME AS OWNER,
Null AS BUILDERNAME,
Null AS TARIONREGNO,
Null AS TARIONENROLNO,
Null AS STATUSDESC,
Null AS PIN

FROM SYSADMIN.ASSESS a
RIGHT JOIN SYSADMIN.BUILDING_PERMITS b ON a.RECORDID = b.ASSESS_ID
RIGHT JOIN SYSADMIN.LookupStructureType st ON st.CODE = b.CONSTRUCTION_TYPE
RIGHT JOIN SYSADMIN.LookupApplicationType at ON at.CODE = b.APPLICATION_TYPE
LEFT JOIN (SELECT
        o.NAME AS OWNER_NAME,
        o.OCCUPANCY_STATUS,
        o.SEQ_NO,
        a1.RECORDID as ARID,
        o.RECORDID as ORID,
        b1.RECORDID as BRID
    FROM SYSADMIN.ASSESS a1
    INNER JOIN SYSADMIN.OWNER o ON a1.RECORDID = o.PARENTID
    INNER JOIN SYSADMIN.BUILDING_PERMITS b1 ON a1.RECORDID = b1.ASSESS_ID
    WHERE o.SEQ_NO = '001') a1 ON b.RECORDID = a1.BRID

WHERE
b.ESTIMATED_COST IS NOT NULL
AND substr(APPLICATION_NUMBER,-1,1) <> 'b'
AND substr(APPLICATION_NUMBER,-1,1) <> 'B'
AND APPLICATION_TYPE <> '111'
AND b.BUILDINGPERMIT_ISSUEDATE >= @DATEFROM
AND b.BUILDINGPERMIT_ISSUEDATE <= @DATETO

ORDER BY BUILDINGPERMIT_ISSUEDATE

", dateTimePicker1.Value, dateTimePicker2.Value));

            r.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report r = new Report("Tarion File", CityView.Run(@"
SELECT
Null AS Expr1,
APPLICATION_NUMBER,
to_char(BUILDINGPERMIT_ISSUEDATE, 'MM/DD/YYYY') AS BUILDINGPERMIT_ISSUEDATE,
Null AS Expr4,
Null AS Expr5,
Null AS Expr6,
BI_OWNERADDRESS,
Null AS Expr8,
Null AS Expr9,
SUBMITTED_TO,
Null AS Expr11,
Null AS Expr12,
Null AS Expr13,
Null AS Expr14,
Null AS Expr15,
APPLICANT_NAME,
Null AS Expr17,
CORP_PART,
APPLICANT_ADDRESS,
Null AS Exp20,
Null AS Exp21,
APPLICANT_CITY,
APPLICANT_POSTALCDE,
APPLICANT_PROV,
Null AS Exp25,
Null AS Exp26,
Null AS Exp27,
Null AS Exp28,
Null AS Exp29,
Null AS Exp30,
Null AS Exp31,
Null AS Exp32,
Null AS Exp33,
Null AS Exp34,
Null AS Exp35,
Null AS Exp36,
Null AS Exp37,
Null AS Exp38,
Null AS Exp39,
Null AS Exp40,
Null AS Exp41,
Null AS Exp42,
Null AS Exp43,
Null AS Exp44,
Null AS Exp45,
Null AS Exp46,
Null AS Exp47,
Null AS Exp48,
Null AS Exp49,
Null AS Exp50,
Null AS Exp51,
Null AS Exp52,
Null AS Exp53,
Null AS Exp54,
Null AS Exp55,
Null AS Exp56,
Null AS Exp57,
Null AS Exp58,
CASE WHEN ONHWPACT_CONST = 1 THEN 'YES' ELSE 'NO' END AS Expr59,
CASE WHEN ONWPACT_PERMIT = 1 THEN 'YES' ELSE 'NO' END AS Expr60,
ONHWPACT_REGNUM,
APPLICANT_NAME,
APPLICATION_DATE

FROM SYSADMIN.BUILDING_PERMITS

WHERE
BUILDINGPERMIT_ISSUEDATE >= @DATEFROM
AND BUILDINGPERMIT_ISSUEDATE <= @DATETO
AND ONHWPACT_CONST = 1
AND ONWPACT_PERMIT = 1
AND BUILDINGCLASSFICATION = '0003'
AND PERMIT_TYPE in ('A', 'A1', 'A2', 'A3')
AND FLAG_CONST = 1
AND CONSTRUCTION_TYPE in ('301', '302', '303', '304', '305', '309', '313')

ORDER BY APPLICATION_NUMBER

            ", dateTimePicker1.Value, dateTimePicker2.Value));

            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Report r = new Report("Occupancy Report", CityView.Run(@"
select application_number as ""Permit Number"",

lptc.description as ""Permit Type"",
lat.description as ""Building Type"",
case when unit_number is null then a.street_number || ' ' || a.street_name else a.street_number || ' ' || a.street_name || ' Unit ' || a.unit_number end as ""Address"",
buildingpermit_issuedate as ""Permit Issue Date"",
approved_date as ""Occupancy Permit Issuance Date"",
rollnumber as ""Roll Number"",
corp_part as ""Builder Name"",
b.description as ""Model Name"",
estimated_cost as ""Estimated Cost"",
other_loc_info as ""Other Location Information""

from sysadmin.building_permits b
left join sysadmin.lookuppermittypecode lptc on lptc.code = b.permit_type
left join sysadmin.lookupapplicationtype lat on lat.code = b.application_type
left join sysadmin.assess a on a.recordid = b.assess_id

where b.permit_type in ('A', 'A1')
and b.application_type = '01'
and approved_date between @STARTDATE and @ENDDATE

order by approved_date

            ", dateTimePicker1.Value, dateTimePicker2.Value));

            r.Show();
        }
    }
}
