using musahit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace musahit.Controllers
{
    public class HomeController : Controller
    {

        private tkh2022Entities db = new tkh2022Entities();
        public ActionResult Index()
        {
            return View();
        }
        [Route("tesekkurler")]
        public ActionResult tesekkurler()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult musahit(ContactForm model, string contact_form_typeID, string name, string lastname, string email, string phone, string city, string town,string okul)
        {

            ContactForm ContactForm = new ContactForm();

            ContactForm.contact_form_typeID = 5;
            ContactForm.name = name;
            ContactForm.phone = phone;
            ContactForm.email = email;
            ContactForm.address = city + "/" + town + "/" + okul;
            ContactForm.title = "Müşahit Başvuru";
            ContactForm.entry_date = DateTime.Now;
            db.ContactForm.Add(ContactForm);
            db.SaveChanges();

            string mailsubject = "Müşahit Başvuru";
            string mailcontent = "Ad Soyad: " + name + " " + lastname + "<br>" + "E-Posta Adresi: " + email + "<br>Telefon Numarası: " + phone + "<br>İl: " + city + "<br>İlçe: " + town + "<br>okul: " + okul;


            var _host = "smtp.yandex.com";
            var _port = 587;
            var _defaultCredentials = false;
            var _enableSsl = true;

            var _emailfrom = "sosyalmedya@tkh.org.tr";//Your yandex email adress
            var _password = "gvgwjebtbvlxpwtk";//Your yandex app password
            using (var smtpClient = new SmtpClient(_host, _port))
            {
                smtpClient.EnableSsl = _enableSsl;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = _defaultCredentials;

                if (_defaultCredentials == false)
                {
                    smtpClient.Credentials = new NetworkCredential(_emailfrom, _password);
                }

                smtpClient.Send(_emailfrom, "posta@tkh.org.tr", mailsubject, mailcontent);
            }


            return Redirect("/tesekkurler");
        }
    }
}