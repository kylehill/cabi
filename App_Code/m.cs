using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using System.Threading;

/// <summary>
/// Summary description for m
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class m : System.Web.Services.WebService {

    public m () {
    }

    [WebMethod]
    public List<Station> get() 
    {
        try
        {
            XDocument feed = XDocument.Load("http://www.capitalbikeshare.com/stations/bikeStations.xml");
            List<Station> stationList = (from s in feed.Descendants("station")
                                         select new Station(s)).ToList<Station>();

            //Takes too goddamn long
            //CaBiData.AddPullData(feed, stationList);

            return stationList;
        }
        catch
        {
            return new List<Station>();
        }
    }

    [WebMethod]
    public void update()
    {
        try
        {
        XDocument feed = XDocument.Load("http://www.capitalbikeshare.com/stations/bikeStations.xml");
            List<Station> stationList = (from s in feed.Descendants("station")
                                         select new Station(s)).ToList<Station>();

            CaBiData.AddPullData(feed, stationList);
        }
        catch
        {}
    }

    [WebMethod]
    public List<Reading> historic(int id)
    {
        try
        {
            return CaBiData.GetGraphData(id);
        }
        catch
        {
            return new List<Reading>();
        }
    }

    [WebMethod]
    public HistoricReturn historicAll(int id, string dt)
    {
        try
        {
            DateTime x = Convert.ToDateTime(dt);
            return CaBiData.GetTimeData(id, x);
        }
        catch
        {
            return new HistoricReturn();
        }
    }
    
}
