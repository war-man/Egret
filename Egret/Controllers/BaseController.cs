﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using Egret.DataAccess;

namespace Egret.Controllers
{
    /// <summary>
    /// This controller is used as a base class for managing derived controllers, consistently setting up dbcontext access, and applying uniform authorization requirements.
    /// </summary>
    //[Authorize]
    public abstract class BaseController : Controller
    {
        private static Microsoft.Extensions.Logging.ILogger _logger;// = LogManager.GetCurrentClassLogger();

        public BaseController(EgretContext context)
        {
            Context = context;

            //_logger = logger;

           // _logger.LogInformation("Hello people");
            //_logger.Info("Hello World");
            //_logger.Error("Oops!");

        }

        /// <summary>
        /// Returns the dbcontext as generated by dependency injection and passed to this base class.
        /// </summary>
        protected EgretContext Context { get; }
    }
}