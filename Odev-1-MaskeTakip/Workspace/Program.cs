
using Business.Concrete;
using Entities.Concrete;



Person person1 = new Person();

person1.FirstName = "Ali";
person1.LastName = "Bey";
person1.NationalIdentity = 12345678910;
person1.DateOfBirthYear = 1999;

Console.WriteLine("First Name: \t" + person1.FirstName);
Console.WriteLine("Last Name: \t" + person1.LastName);
Console.WriteLine("Birth Year: \t" + person1.NationalIdentity);
Console.WriteLine("TC No: \t\t" + person1.DateOfBirthYear);


PersonManager personManager = new PersonManager();
personManager.ApplyForMask(person1);

Console.WriteLine("\n#####\n");

Person person2 = new Person();
person2.FirstName = "Veli";
person2.LastName = "Bey";
person2.NationalIdentity = 10987654321;
person2.DateOfBirthYear = 1999;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person2);
