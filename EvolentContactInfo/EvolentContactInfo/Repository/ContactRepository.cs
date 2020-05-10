using EvolentContactInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvolentContactInfo.Repository
{
    public class ContactRepository : IContactRepository
    {
        public List<Contact> GetAllContact()
        {
            List<Contact> con = new List<Contact>();
            if (HttpContext.Current.Session["contactData"] != null)
                con = (List<Contact>)HttpContext.Current.Session["contactData"];

            return con;
        }

        public Contact GetContactById(int Id)
        {
            List<Contact> connList = new List<Contact>();
            Contact con = new Contact();
            connList = (List<Contact>)HttpContext.Current.Session["contactData"];

            con = connList.Where(x => x.Id == Id).SingleOrDefault();

            return con;
        }

        public int AddContact(Contact con)
        {
            int result = -1;
            List<Contact> connew = new List<Contact>();

            if (HttpContext.Current.Session["contactData"] != null)
            {
                connew = (List<Contact>)HttpContext.Current.Session["contactData"];
                if (connew.Count != 0)
                    con.Id = connew.LastOrDefault().Id + 1;
                else
                    con.Id = 1;

                connew.Add(con);
            }
            else
            {
                con.Id = 1;
                connew.Add(con);
                HttpContext.Current.Session["contactData"] = connew;
            }

            result = (int)con.Id;

            return result;

        }

        public int UpdateContact(Contact con)
        {
            int result = -1;

            List<Contact> connew = new List<Contact>();
            connew = (List<Contact>)HttpContext.Current.Session["contactData"];
            Contact Contemp = new Contact();
            Contemp = connew.Where(x => x.Id == con.Id).First();
            int index = connew.IndexOf(Contemp);
            connew[index] = con;

            HttpContext.Current.Session["contactData"] = connew;

            result = (int)con.Id;

            return result;
        }

        public void DeleteContact(int Id)
        {
            List<Contact> connew = new List<Contact>();
            connew = (List<Contact>)HttpContext.Current.Session["contactData"];
            Contact Contemp = new Contact();
            Contemp = connew.Where(x => x.Id == Id).First();
            int index = connew.IndexOf(Contemp);
            connew.RemoveAt(index);
            HttpContext.Current.Session["contactData"] = connew;
        }
    }
}