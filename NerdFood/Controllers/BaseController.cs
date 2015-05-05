using NerdFood.Infra.CrossCutting.MvcFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerdFood.Controllers
{
    [UserDataCache]
    public class BaseController : Controller
    {

    }
}