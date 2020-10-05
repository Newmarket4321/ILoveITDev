using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_IT
{
    class CVInfoUpdateCopy
    {
        public CVInfoUpdateCopy()
        {
            Vailtech vail = new Vailtech("select * from vailtech.tx_roll where roll_no like '%0000' order by roll_no");
            DataTable dt = vail.Run();

            //CityViewDev.Run("delete from sysadmin.owner");
            //CityViewDev.Run("delete from sysadmin.mailing");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Try to find it
                DataTable parentResult = CityView.Run("select recordid from sysadmin.assess where roll_num = @ROLLNO", "1948" + dt.Rows[i]["roll_no"].ToString());

                //If you don't find it, put it in
                if (parentResult.Rows.Count == 0)
                {
                    Data r = dt.Rows[i];

                    //Roll number not found in Assess
                    CityView temp = new CityView("insert into sysadmin.assess (ACCESS_CODE, CITY_PROV_COUNTRY, CON, DEPTH_ACREAGE, FRENCH_CATHOLIC_SCHOOL_CODE, FRENCH_PUBLIC_SCHOOL_CODE, FRONTAGE, HIGH_SCHOOL_CODE, IMPR_FEAT_CODE, LOT, NEIGHBOURHOOD_NUM, PARCEL, PLAN, POLL, POLL_SUFFIX, POSTAL_CODE, PREV_ROLL_NUM, PROP_CODE, PUBLIC_SCHOOL_CODE, QUALIFIER, ROLL_NUM, ROLL_COUNTY, ROLL_MAP, ROLL_MUN, ROLL_PARCEL, ROLL_PRI_SUB, SEPARATE_SCHOOL_CODE, SERVICES, SITE_AREA, SPECIAL_RATE_AREA, STREET_NAME, STREET_NUMBER, UNIT_MEASURE, UNIT_NUMBER, UPPER_STREET_NUMBER, WARD, ZONING_UFFI, RECORDID, TEMP, ZONE_1, ZONE_2, CV_INSERT_IDENTITY, TEMPSTREETNUM, BLAH, HERITAGEPROP) values (@ACCESS_CODE, @CITY_PROV_COUNTRY, @CON, @DEPTH_ACREAGE, @FRENCH_CATHOLIC_SCHOOL_CODE, @FRENCH_PUBLIC_SCHOOL_CODE, @FRONTAGE, @HIGH_SCHOOL_CODE, @IMPR_FEAT_CODE, @LOT, @NEIGHBOURHOOD_NUM, @PARCEL, @PLAN, @POLL, @POLL_SUFFIX, @POSTAL_CODE, @PREV_ROLL_NUM, @PROP_CODE, @PUBLIC_SCHOOL_CODE, @QUALIFIER, @ROLL_NUM, @ROLL_COUNTY, @ROLL_MAP, @ROLL_MUN, @ROLL_PARCEL, @ROLL_PRI_SUB, @SEPARATE_SCHOOL_CODE, @SERVICES, @SITE_AREA, @SPECIAL_RATE_AREA, @STREET_NAME, @STREET_NUMBER, @UNIT_MEASURE, @UNIT_NUMBER, @UPPER_STREET_NUMBER, @WARD, @ZONING_UFFI, @RECORDID, @TEMP, @ZONE_1, @ZONE_2, @CV_INSERT_IDENTITY, @TEMPSTREETNUM, @BLAH, @HERITAGEPROP)");
                    temp.AddParameter("@ACCESS_CODE", "Y");
                    temp.AddParameter("@CITY_PROV_COUNTRY", "");
                    temp.AddParameter("@CON", "");
                    temp.AddParameter("@DEPTH_ACREAGE", "");
                    temp.AddParameter("@FRENCH_CATHOLIC_SCHOOL_CODE", "");
                    temp.AddParameter("@FRENCH_PUBLIC_SCHOOL_CODE", "");
                    temp.AddParameter("@FRONTAGE", "");
                    temp.AddParameter("@HIGH_SCHOOL_CODE", "");
                    temp.AddParameter("@IMPR_FEAT_CODE", "");
                    temp.AddParameter("@LOT", "");
                    temp.AddParameter("@NEIGHBOURHOOD_NUM", "");
                    temp.AddParameter("@PARCEL", "");
                    temp.AddParameter("@PLAN", "");
                    temp.AddParameter("@POLL", "");
                    temp.AddParameter("@POLL_SUFFIX", "");
                    temp.AddParameter("@POSTAL_CODE", "");
                    temp.AddParameter("@PREV_ROLL_NUM", "");
                    temp.AddParameter("@PROP_CODE", "");
                    temp.AddParameter("@PUBLIC_SCHOOL_CODE", "");
                    temp.AddParameter("@QUALIFIER", "");
                    temp.AddParameter("@ROLL_NUM", "1948" + r["roll_no"]);
                    temp.AddParameter("@ROLL_COUNTY", "");
                    temp.AddParameter("@ROLL_MAP", "");
                    temp.AddParameter("@ROLL_MUN", "");
                    temp.AddParameter("@ROLL_PARCEL", "");
                    temp.AddParameter("@ROLL_PRI_SUB", "");
                    temp.AddParameter("@SEPARATE_SCHOOL_CODE", "");
                    temp.AddParameter("@SERVICES", "");
                    temp.AddParameter("@SITE_AREA", "");
                    temp.AddParameter("@SPECIAL_RATE_AREA", "");
                    temp.AddParameter("@STREET_NAME", r["street_name"]);
                    temp.AddParameter("@STREET_NUMBER", r["street_no"]);
                    temp.AddParameter("@UNIT_MEASURE", "");
                    temp.AddParameter("@UNIT_NUMBER", r["street_unit"]);
                    temp.AddParameter("@UPPER_STREET_NUMBER", "");
                    temp.AddParameter("@WARD", r["ward"]);
                    temp.AddParameter("@ZONING_UFFI", "");
                    temp.AddParameter("@RECORDID", CityView.RunString("select max(recordid)+1 from sysadmin.assess"));
                    temp.AddParameter("@TEMP", "");
                    temp.AddParameter("@ZONE_1", "");
                    temp.AddParameter("@ZONE_2", "");
                    temp.AddParameter("@CV_INSERT_IDENTITY", CityView.RunString("select max(cv_insert_identity)+1 from sysadmin.assess"));
                    temp.AddParameter("@TEMPSTREETNUM", "");
                    temp.AddParameter("@BLAH", "MGS");
                    temp.AddParameter("@HERITAGEPROP", "");
                    temp.Run();

                    Console.WriteLine("Inserted " + "1948" + r["roll_no"]);
                }
                else
                {
                    Data r = dt.Rows[i];

                    //Update existing
                    CityView temp = new CityView("update sysadmin.assess set STREET_NAME=@STREET_NAME, STREET_NUMBER=@STREET_NUMBER, UNIT_NUMBER=@UNIT_NUMBER where roll_num=@ROLL_NUM");
                    temp.AddParameter("@STREET_NAME", r["street_name"]);
                    temp.AddParameter("@STREET_NUMBER", r["street_no"]);
                    temp.AddParameter("@UNIT_NUMBER", r["street_unit"]);
                    temp.AddParameter("@ROLL_NUM", "1948" + r["roll_no"]);
                    temp.Run();

                    Console.WriteLine("Updated " + "1948" + r["roll_no"]);

                }

                //Now find it. It should be there for sure.
                parentResult = CityView.Run("select recordid from sysadmin.assess where roll_num = @ROLLNO", "1948" + dt.Rows[i]["roll_no"].ToString());

                int parentID = int.Parse(parentResult.Rows[0]["recordid"].ToString());

                //Owner
                for (int s = 1; s <= 3; s++)
                {
                    //Check if it exists
                    CityView temp = new CityView("select * from sysadmin.owner where seq_no = @SEQ and parentid = @PAR");
                    temp.AddParameter("@SEQ", s);
                    temp.AddParameter("@PAR", parentID);
                    bool exists = temp.Run().Rows.Count > 0;

                    //If not, make it exist
                    if (!exists)
                    {
                        CityView cv = new CityView("insert into sysadmin.owner (SEQ_NO, BIRTH_MONTH, BIRTH_YEAR, CITIZENSHIP, DESIGNATED_RATEPAYER_CODE, FRENCH_EDU_RIGHT, IDENTIFIER, NAME, OCCUPANCY_STATUS, RELIGION, RESIDENCY_CODE, SCHOOL_SUPPORT, PARENTID, PHONENUMBER, CV_INSERT_IDENTITY) values (@SEQNO, @BIRTHMONTH, @BIRTHYEAR, @CITIZENSHIP, @DESIGNATED_RATEPAYER_CODE, @FRENCH_EDU_RIGHT, @IDENTIFIER, @VARNAM, @OCCUPANCY_STATUS, @RELIGION, @RESIDENCY_CODE, @SCHOOL_SUPPORT, @PARENTID, @PHONENUMBER, @CVINSERT)");
                        cv.AddParameter("@SEQNO", s);
                        cv.AddParameter("@BIRTHMONTH", "");
                        cv.AddParameter("@BIRTHYEAR", "");
                        cv.AddParameter("@CITIZENSHIP", "");
                        cv.AddParameter("@DESIGNATED_RATEPAYER_CODE", "");
                        cv.AddParameter("@FRENCH_EDU_RIGHT", "");
                        cv.AddParameter("@IDENTIFIER", dt.Rows[i]["OWNER_ID" + s].ToString());
                        cv.AddParameter("@VARNAM", dt.Rows[i]["owner_" + s].ToString());
                        cv.AddParameter("@OCCUPANCY_STATUS", dt.Rows[i]["OWNER_CL" + s].ToString());
                        cv.AddParameter("@RELIGION", "");
                        cv.AddParameter("@RESIDENCY_CODE", "");
                        cv.AddParameter("@SCHOOL_SUPPORT", "");
                        cv.AddParameter("@PARENTID", parentID);
                        cv.AddParameter("@PHONENUMBER", "");
                        cv.AddParameter("@CVINSERT", "");
                        cv.Run();
                    }
                    else //If so, ensure it's updated
                    {
                        CityView cv = new CityView("update sysadmin.owner set name = @VALUE where seq_no = @SEQ and parentid = @PAR");
                        cv.AddParameter("@VALUE", dt.Rows[i]["owner_" + s].ToString());
                        cv.AddParameter("@SEQ", s);
                        cv.AddParameter("@PAR", parentID);
                        cv.Run();
                    }
                }

                //Mailing
                for (int s = 1; s <= 3; s++)
                {
                    CityView temp = new CityView("select * from sysadmin.mailing where seq_no = @SEQ and parentid = @PAR");
                    temp.AddParameter("@SEQ", s);
                    temp.AddParameter("@PAR", parentID);
                    bool exists = temp.Run().Rows.Count > 0;

                    if (!exists)
                    {
                        CityView cv = new CityView("insert into sysadmin.mailing (SEQ_NO, MAILING_ADDRESS, PARENTID, CV_INSERT_IDENTITY) values (@SEQ_NO, @MAILING_ADDRESS, @PARENTID, @CVINSERT)");
                        cv.AddParameter("@SEQ_NO", s);
                        cv.AddParameter("@MAILING_ADDRESS", dt.Rows[i]["mailing" + s].ToString());
                        cv.AddParameter("@PARENTID", parentID);
                        cv.AddParameter("@CVINSERT", "");
                        cv.Run();
                    }
                    else
                    {
                        CityView cv = new CityView("update sysadmin.mailing set mailing_address = @VALUE where seq_no = @SEQ and parentid = @PAR");
                        cv.AddParameter("@VALUE", dt.Rows[i]["mailing" + s].ToString());
                        cv.AddParameter("@SEQ", s);
                        cv.AddParameter("@PAR", parentID);
                        cv.Run();
                    }
                }

                CityView cv2 = new CityView("update sysadmin.assess set city_prov_country = @MAIL4, postal_code = @MAIL5 where recordid = @PAR");
                cv2.AddParameter("@MAIL4", dt.Rows[i]["mailing4"].ToString().Trim());
                cv2.AddParameter("@MAIL5", dt.Rows[i]["mailing5"].ToString().Trim());
                cv2.AddParameter("@PAR", parentID);
                cv2.Run();
            }

            //Core.sendMail("msquires@newmarket.ca", "CityView Update", "I'm done.");
        }
    }
}
