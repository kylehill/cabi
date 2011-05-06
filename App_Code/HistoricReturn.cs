using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HistoricReturn
/// </summary>
public class HistoricReturn
{
	public HistoricReturn()
	{
        isSuccessful = false;
	}

    public List<Reading> rList;
    public bool isWeekend;
    public bool isSuccessful;
    public string easyTime;
}