using EvolentContactInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolentContactInfo.Services
{
    public interface IContactService
    {
        List<Contact> GetAllContact();
        Contact GetContactById(int Id);
        int AddContact(Contact Contact);
        int UpdateContact(Contact Contact);
        void DeleteContact(int ContactId);
    }
}
