using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolentContactInfo.Models;

namespace EvolentContactInfo.Repository
{
    public interface IContactRepository
    {
        List<Contact> GetAllContact();
        Contact GetContactById(int Id);
        int AddContact(Contact Contact);
        int UpdateContact(Contact Contact);
        void DeleteContact(int ContactId);
    }
}
