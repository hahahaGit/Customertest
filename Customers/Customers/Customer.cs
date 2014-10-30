using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    class Customer
    {
        public int _customerID;
public int CustomerID
{
get { return this._customerID; }
set { this._customerID = value; }
}
public string _title;
public string Title
{
get { return this._title; }
set { this._title = value; }
}

public string _firstName;
public string FirstName
{
get { return this._firstName; }
set { this._firstName = value; }
}
public string _lastName;
public string LastName
{
get { return this._lastName; }
set { this._lastName = value; }
}
public string _emailAddress;
public string EmailAddress
{
get { return this._emailAddress; }
set { this._emailAddress = value; }
}
public string _phone;
public string Phone
{
get { return this._phone; }
set { this._phone = value; }
}
    }
}
