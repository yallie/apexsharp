namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class DmlTest
    {
        public static void UpsertTest()
        {
            Contact contactNew = new Contact();
            contactNew.LastName = "apexSharp";
            contactNew.Email = "abc@abc.com";
            //upsert contactNew;
            System.debug(contactNew.Id);
            List<Contact> contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
                c.Email = "new@new.com";
            }

            //upsert contacts;
            contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
            }
        }
    }
}
