using AddressBook;

AddressBooks Myaddressbook = new AddressBooks();
Myaddressbook.CreateContact();
Myaddressbook.EditInfo();
Myaddressbook.DeleteContact();
Myaddressbook.AddMultipleContacts();

AddressBookCollection addbooks = new AddressBookCollection();
addbooks.AddBook(Myaddressbook);
