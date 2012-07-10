using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for Logs
/// </summary>
public class Logs
{
    private string sLogFormat;
    private string sErrorTime;

	public Logs()
	{
		
	}
    public  void CreateLogFiles(String sPathName,String sErrMsg)
    {
        sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + "==>";
        string sYear = DateTime.Now.Year.ToString();
        string sMonth = DateTime.Now.Month.ToString();
        string sDay = DateTime.Now.Day.ToString();

        sErrorTime = sYear + sMonth + sDay;

        StreamWriter sw = new StreamWriter(sPathName+sErrorTime,true);
        sw.WriteLine(sLogFormat + sErrMsg);
        sw.Flush();
        sw.Close();

    }
    
}
