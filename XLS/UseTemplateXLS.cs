﻿using AppMoneyTransferRS.Models;
using ClosedXML.Report;

namespace AppMoneyTransferRS.XLS;

public class UseTemplateXLS
{
    public byte[] Edition(Stream streamTemplate, WeatherForecast[] data)
    {
        var template = new XLTemplate(streamTemplate);

        template.AddVariable("WeatherForecasts", data);
        template.Generate();

        MemoryStream XLSStream = new();
        template.SaveAs(XLSStream);


        return XLSStream.ToArray();
    }
}
