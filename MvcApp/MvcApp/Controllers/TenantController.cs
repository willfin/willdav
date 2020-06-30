using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class TenantController : Controller
    {
        // GET: Tenant
        public ActionResult Index()
        {
             return View();
        }

        [HttpGet]
        public ActionResult CreateTenantDatabase(string tenantDBName)
        {
            string CONNECTIONSTRING = @"server=database-1.ccdn4y5dueh8.us-west-2.rds.amazonaws.com;userid=root;password=iBox12345;database=iBoxSuite";

            try
            {
                using (var connection = new MySqlConnection(CONNECTIONSTRING))
                {
                    MySqlScript script = new MySqlScript(connection, "create database "+tenantDBName);
                    script.Delimiter = "$$";
                    script.Execute();

                    ExecuteTenantScripts(tenantDBName);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

            return View("Details");
        }


        // GET: Tenant/Details/5
        private void ExecuteTenantScripts(string tenantDBName)
        {
            string CONNECTIONSTRING = @"server=database-1.ccdn4y5dueh8.us-west-2.rds.amazonaws.com;userid=root;password=iBox12345;database=" + tenantDBName;

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DBScripts\TenantSetupScript.sql");

                using (var connection = new MySqlConnection(CONNECTIONSTRING))
                {
                    MySqlScript script = new MySqlScript(connection, System.IO.File.ReadAllText(path));
                    script.Delimiter = "$$";
                    script.Execute();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        // GET: Tenant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tenant/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tenant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tenant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tenant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tenant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
