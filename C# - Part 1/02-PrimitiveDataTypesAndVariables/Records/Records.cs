using System;

//A marketing firm wants to keep record of its employees. Each record would have 
//the following characteristics – first name, family name, age, gender (m or f), 
//ID number, unique employee number (27560000 to 27569999). Declare the variables 
//needed to keep the information for a single employee using appropriate data types 
//and descriptive names.

class Records
{
    static void Main()
    {
        string firstName;
        string lastName;
        byte age = 20;
        char gender;
        string ID; 
        //elements such as ID (EGN) or Credit Card number should be stored in string variables. 
        //We store variables in int/byte/etc. when we must do some matematical calculations with them.
        short employeeNumber; //later if we want to see his actual number, we may just add 2756000 to this variable
    }
}

