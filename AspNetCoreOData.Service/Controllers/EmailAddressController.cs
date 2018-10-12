﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using  AspNetCoreOData.Service.Database;
using Microsoft.AspNet.OData;

namespace  AspNetCoreOData.Service.Controllers
{
    public class EmailAddressController : ODataController
    {
        private AdventureWorks2016Context _db;

        public EmailAddressController(AdventureWorks2016Context AdventureWorks2016Context)
        {
            _db = AdventureWorks2016Context;
        }

        [EnableQuery(PageSize = 20)]
        public IActionResult Get()
        {
            return Ok(_db.EmailAddress.AsQueryable());
        }

        [EnableQuery(PageSize = 20)]
        public IActionResult Get([FromODataUri] int key)
        {
            return Ok(_db.EmailAddress.Find(key));
        }
    }
}