using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Reading
/// </summary>
public class Reading
{
	public Reading()
	{
	}

    public Reading(PullResult pr, DateTime date)
    {
        bikeCount = pr.Docked;
        dockCount = pr.Empty;
        active = ((pr.Installed == true) && (pr.Locked == false));
        this.date = date.ToString();
    }

    public string date;
    public int bikeCount;
    public int dockCount;
    public bool active;
}