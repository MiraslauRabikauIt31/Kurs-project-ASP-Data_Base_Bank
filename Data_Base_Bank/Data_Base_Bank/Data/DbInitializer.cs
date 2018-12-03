using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Base_Bank.Models;

namespace Data_Base_Bank.Data
{
    public class DbInitializer
    {
        public static void Initialize(BankContext db)
        {
            db.Database.EnsureCreated();

            if (db.Typesdeposits.Any())
            {
                return;
            }

            int typesdeposit_number = 35;
            int currencies_number = 5;
            int depositors_number = 35;
            int employees_number = 100;
            int deposits_number = 10;
            string typedepositsType;
            string name;
            string surname;
            string middlename;
            string patronymic;
            string voc = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            string tel = "1234567890";
            string phone;
            string adres;
            decimal sum;
            decimal proc;
            DateTime date;

            Random randObj = new Random(1);

            string[] typedep_voc = { "Долг", "Налог", "Учёба" };
            string typedp_doc;
            int count_typedep_voc = typedep_voc.GetLength(0);
            for (int typedepID = 1; typedepID <= typesdeposit_number; typedepID++)
            {
                typedepositsType = typedep_voc[randObj.Next(count_typedep_voc)] + typedepID.ToString();
                DateTime today = DateTime.Now.Date;
                date = today.AddDays(-typedepID);
                sum = randObj.Next(1, 4);
                proc = randObj.Next(1, 4);
                typedp_doc = GenRandomString(voc, 10);
                db.Typesdeposits.Add(new Typedeposit { NameType = typedepositsType, Minimumtermofdeposit = date, Minimumdepositamount = sum, Interestrate = proc, Additionalconditions = typedp_doc });
            }
            db.SaveChanges();

            string[] currnecyname = { "JPY", "TRY", "CHF" };
            int count_currname_voc = currnecyname.GetLength(0);
            for (int currencyID = 1; currencyID <= currencies_number; currencyID++)
            {
                name = currnecyname[randObj.Next(count_currname_voc)] + currencyID.ToString();
                sum = randObj.Next(1, 6);
                DateTime today = DateTime.Now.Date;
                date = today.AddDays(-currencyID);
                db.Currencies.Add(new Currency { NameCurrency = name, Exchangerate = sum, date_ = date });
            }
            db.SaveChanges();

            string pasport;
            for (int depositorID = 1; depositorID <= depositors_number; depositorID++)
            {
                name = GenRandomString(voc, 10);
                surname = GenRandomString(voc, 10);
                middlename = GenRandomString(voc, 10);
                adres = GenRandomString(voc, 10);
                phone = GenRandomString(tel, 10);
                pasport = GenRandomString(voc, 10);
                db.Depositors.Add(new Depositor { NameDep = name, SurnameDep = surname, MiddlenameDep = middlename, Addres = adres, Phone = phone, Passportdata = pasport });
            }
            db.SaveChanges();

            for (int employeeID = 1; employeeID <= employees_number; employeeID++)
            {
                name = GenRandomString(voc, 10);
                surname = GenRandomString(voc, 10);
                middlename = GenRandomString(voc, 10);
                patronymic = GenRandomString(voc, 10);
                DateTime birht = new DateTime(randObj.Next(1990, 1996), randObj.Next(1, 12), randObj.Next(1, 31));
                date = birht.AddDays(-employeeID);
                db.Employees.Add(new Employee { NameEmpl = name, SurnameEmpl = surname, MiddlenameEmpl = middlename, Patronymic = patronymic, DateofBirth = date });
            }
            db.SaveChanges();

            for (int depositID = 1; depositID <= deposits_number; depositID++)
            {
                int currencyID = randObj.Next(1, currencies_number - 1);
                int depositorID = randObj.Next(1, depositors_number - 1);
                int typedepositID = randObj.Next(1, typesdeposit_number - 1);
                int employeeID = randObj.Next(1, employees_number - 1);
                decimal depositsum = randObj.Next(1, 10);
                DateTime datedeposit = new DateTime(randObj.Next(2000, 2020), randObj.Next(1, 12), randObj.Next(1, 31));
                DateTime datedep = datedeposit.AddDays(-depositID);
                decimal refundamount = randObj.Next(1, 10);
                DateTime datereturn = new DateTime(randObj.Next(2000, 2020), randObj.Next(1, 12), randObj.Next(1, 31));
                DateTime dateret = datereturn.AddDays(-depositID);
                db.Deposits.Add(new Deposit
                {
                    CurrencyID = currencyID,
                    DepositorID = depositorID,
                    TypedepositID = typedepositID,
                    EmployeeID = employeeID,
                    Depositsum = depositsum,
                    Datedeposit = datedep,
                    Refundamount = refundamount,
                    Datereturn = dateret
                });
            }

            db.SaveChanges();
        }

        private static string GenRandomString(string Alphabet, int Length)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(Length - 1);
            int Position = 0;
            string ret = "";
            for (int i = 0; i < Length; i++)
            {
                Position = rnd.Next(0, Alphabet.Length - 1);
                ret = ret + Alphabet[Position];
            }
            return ret;
        }
    }
}
