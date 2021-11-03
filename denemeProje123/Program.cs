using System;

namespace denemeProje123
{
    class Program
    {
        static void Main(string[] args)
        {
            Custumer custumer = new Custumer();
            custumer.ID = 1;
            custumer.Name = "Muhammet";
            custumer.LastName = "Yildirim";

            CustumerManager custumerManager = new CustumerManager();
            custumerManager.Add(custumer);
            custumerManager.Update(custumer);
            custumerManager.Delete(custumer);

        }
    }
}
