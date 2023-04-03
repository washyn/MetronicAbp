﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.Samples.Pages;

public class DemoTable : AbpPageModel
{
    public TEmpClass Modelo { get; set; }
    public void OnGet()
    {
        Alerts.Add(new AlertMessage(AlertType.Warning, "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged."));
    }
}

public class TEmpClass
{
    [DataType(DataType.Date)]
    public DateTime DateTimeSample { get; set; }
}