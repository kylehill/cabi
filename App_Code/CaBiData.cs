using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

public static class CaBiData
{
    public static bool AddPullData(XContainer xc, List<Station> stationList)
    {
        try
        {
            string LastUpdate = xc.Element("stations").Attribute("lastUpdate").Value;
            CaBiDataContext dc = new CaBiDataContext();

            if ((from p in dc.Pulls where p.DateSignature == LastUpdate select p).Count<Pull>() == 0)
            {
                Pull p = new Pull();
                p.DateSignature = LastUpdate;
                p.PullDate = DateTime.Now;
                dc.Pulls.InsertOnSubmit(p);
                dc.SubmitChanges();

                int pullID = (from pid in dc.Pulls where pid.DateSignature == LastUpdate select pid.PullID).First<int>();

                foreach (Station s in stationList)
                {
                    if ((from ps in dc.PulledStations where ps.StationID == s.id select ps).Count<PulledStation>() == 0)
                    {
                        CaBiDataContext dcsub = new CaBiDataContext();
                        PulledStation ps = new PulledStation();
                        ps.StationID = s.id;
                        ps.StationName = s.name;
                        ps.Latitude = s.lat;
                        ps.Longitude = s.lng;
                        ps.Installed = s.installed;
                        ps.Locked = s.locked;
                        ps.Temporary = s.temporary;
                        dcsub.PulledStations.InsertOnSubmit(ps);
                        dcsub.SubmitChanges();
                    }

                    PullResult pr = new PullResult();
                    pr.PullID = pullID;
                    pr.StationID = s.id;
                    pr.Docked = s.bikeCount;
                    pr.Empty = s.dockCount;
                    pr.Installed = s.installed;
                    pr.Locked = s.locked;
                    pr.Temporary = s.temporary;
                    dc.PullResults.InsertOnSubmit(pr);                    
                }
                dc.SubmitChanges();
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static List<Reading> GetGraphData(int StationID)
    {
        try
        {
            CaBiDataContext dc = new CaBiDataContext();
            DateTime boundary = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));

            return (from pr in dc.PullResults
                    from p in dc.Pulls
                    where pr.StationID == StationID &&
                        pr.PullID == p.PullID && 
                        p.PullDate > boundary
                    select new Reading(pr, p.PullDate)).ToList<Reading>();
        }
        catch
        {
            return new List<Reading>();
        }
    }

    public static HistoricReturn GetTimeData(int StationID, DateTime PullDate)
    {
        try
        {
            DateTime dataCollectionStartDate = new DateTime(2011, 5, 4, 17, 0, 0);

            CaBiDataContext dc = new CaBiDataContext();
            DateTime targetDate = PullDate;
            List<Reading> returnList = new List<Reading>();

            bool IsWeekend = IsAWeekend(targetDate);
            while (targetDate > dataCollectionStartDate)
            {
                if (IsAWeekend(targetDate) == IsWeekend)
                {
                    try
                    {
                        Reading r = (from p in dc.Pulls
                                     from pr in dc.PullResults
                                     where pr.PullID == p.PullID &&
                                     pr.StationID == StationID &&
                                     p.PullDate >= targetDate
                                     select new Reading(pr, p.PullDate)).First<Reading>();

                        if ((r.active) && (r.bikeCount + r.dockCount > 0))
                        {
                            returnList.Add(r);
                        }
                    }
                    catch
                    {
                        break;
                    }                    
                }
                targetDate = targetDate.Subtract(new TimeSpan(1, 0, 0, 0));
            }

            HistoricReturn hr = new HistoricReturn();
            hr.rList = returnList;
            hr.isWeekend = IsWeekend;
            hr.isSuccessful = true;
            hr.easyTime = targetDate.AddHours(1).ToShortTimeString();
            return hr;
        }
        catch
        {
            return new HistoricReturn();
        }
    }

    private static bool IsAWeekend(DateTime dt)
    {
        switch (dt.DayOfWeek)
        {
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
                return false;
            case DayOfWeek.Friday:
                return (dt.TimeOfDay.Hours > 18);
            case DayOfWeek.Saturday:
                return true;
            case DayOfWeek.Sunday:
                return (dt.TimeOfDay.Hours < 18);
        }

        // VS is derping at me, so..
        return false;
    }
}