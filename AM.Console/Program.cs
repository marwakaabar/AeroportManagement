// See https://aka.ms/new-console-template for more information

using AMApplicationCore.Domain;
using System.Security.Claims;

Console.WriteLine("Hello, World!");
Plane p1 = new Plane();
p1.Capacity = 300;


//polyporphisme test 
Passenger p = new (){
    FirstName ="marwa",
    LastName = "marwa",
    EmailAddress="marwa@gmail.com"

    };

Staff staff = new()
{
    FirstName = "mouna"
};

Traveller traveller = new()
{
    FirstName="dali"
};

Console.WriteLine("************** methode polymorphisme********************");
Console.WriteLine("*************** passenger ************************");
p.PassengerType();
Console.WriteLine("*************** staff ************************");
staff.PassengerType();
Console.WriteLine("*************** traveller ************************");
traveller.PassengerType();
Console.WriteLine(p.checkProfile2("marwa","kaabar"));



