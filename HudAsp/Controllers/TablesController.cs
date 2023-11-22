using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HudAsp.Models;

namespace HudAsp.Controllers;

public class TablesController : Controller
{
	public IActionResult TableSalary()
	{
		return View();
	}
    public IActionResult TableSalaryPlus()
    {
        return View();
    }

    public IActionResult TableIndustry()
    {
        return View();
    }
    public IActionResult TableIndustryPlus()
    {
        return View();
    }
    public IActionResult TableHeatMap()
    {
        return View();
    }

    public IActionResult TableHeatMapPlus()
    {
        return View();
    }



    public IActionResult TablePlugins()
	{
		return View();
	}

	public IActionResult Demo()
	{
		return View();
	}
}