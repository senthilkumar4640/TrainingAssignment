using System;
namespace SingleInheritanceTwo;
class Program 
{
    public static void Main(string[] args)
    {
        //Creating object for AccountInfo
        AccountInfo accountHolder1 = new AccountInfo("Senthil","Ranga",8825816924,"Senthil@gmail.com","08/03/2002",Gender.Male,4640,"Kurinjipadi","CAN6452",20000);
        AccountInfo accountHolder2 = new AccountInfo("Bhuvana","Krishna",8903089312,"Bhuvana@gmail.com","16/07/2002",Gender.Female,4641,"Kurinjipadi","CAN6452",45000); 
        AccountInfo accountHolder3 = new AccountInfo("Meeena","Ranga",9578687750,"Rangameena@gmail.com","05/05/1976",Gender.Female,4640,"Kurinjipadi","CAN6452",25000);


        accountHolder1.ShowAccountInfo();
        accountHolder2.ShowAccountInfo();
        accountHolder3.ShowAccountInfo();

        accountHolder1.Deposit(1000);
        accountHolder2.Deposit(2000);
        accountHolder3.Deposit(3000);

        accountHolder1.Withdraw(200000);
        accountHolder2.Withdraw(2000);
        accountHolder3.Withdraw(400);

        accountHolder1.ShowBalance();
        accountHolder2.ShowBalance();
        accountHolder3.ShowBalance();

    }
}