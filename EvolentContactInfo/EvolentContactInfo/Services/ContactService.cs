using EvolentContactInfo.Models;
using EvolentContactInfo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvolentContactInfo.Services
{
    public class ContactService : IContactService
    {
        private IContactRepository _iContactRepository;

        public ContactService(IContactRepository iContactRepository)  
        {
            _iContactRepository = iContactRepository;  
        }

        public List<Contact> GetAllContact()  
        {
            return _iContactRepository.GetAllContact();  
        }

        public Contact GetContactById(int contactId)
        {
            return _iContactRepository.GetContactById(contactId);
        }

        public int AddContact(Contact Contact)
        {
            return _iContactRepository.AddContact(Contact);
        }

        public int UpdateContact(Contact Contact)
        {
            return _iContactRepository.UpdateContact(Contact);
        }
        public void DeleteContact(int ContactId)
        {
            _iContactRepository.DeleteContact(ContactId);
        }
    }
}