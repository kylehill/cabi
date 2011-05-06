using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for Station
/// </summary>
public class Station
{
	public Station()
	{
	}

    public Station(XContainer xc)
    {
        name = xc.Element("name").Value;
        id = Convert.ToInt32(xc.Element("id").Value);
        lat = Convert.ToDouble(xc.Element("lat").Value);
        lng = Convert.ToDouble(xc.Element("long").Value);
        installed = Convert.ToBoolean(xc.Element("installed").Value);
        locked = Convert.ToBoolean(xc.Element("locked").Value);
        locked = Convert.ToBoolean(xc.Element("temporary").Value);
        bikeCount = Convert.ToInt32(xc.Element("nbBikes").Value);
        dockCount = Convert.ToInt32(xc.Element("nbEmptyDocks").Value);
    }

    public string name;
    public int id;
    public double lat;
    public double lng;
    public bool installed;
    public bool locked;
    public bool temporary;
    public int bikeCount;
    public int dockCount;
}