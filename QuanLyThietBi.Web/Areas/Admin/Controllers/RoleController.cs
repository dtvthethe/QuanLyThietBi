using QuanLyThietBi.Model.Models;
using QuanLyThietBi.Service.IServices;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace QuanLyThietBi.Web.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {

        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: Admin/Role
        public ActionResult Index()
        {
            return View(_roleService.GetAll().ToList());
        }

        // GET: Admin/Role/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = _roleService.GetById(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // GET: Admin/Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Role/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Role role)
        {
            if (ModelState.IsValid)
            {
                _roleService.Add(new Role { Id = role.Id, Name = role.Name });
                _roleService.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(role);
        }

        // GET: Admin/Role/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = _roleService.GetById(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Admin/Role/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Role role)
        {
            if (ModelState.IsValid)
            {
                var rol = _roleService.GetById(role.Id);
                rol.Name = role.Name;
                _roleService.Update(rol);
                _roleService.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(role);
        }

        // GET: Admin/Role/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = _roleService.GetById(id);

            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Admin/Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var rol = _roleService.GetById(id);
            Role role = _roleService.Delete(rol);
            _roleService.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
