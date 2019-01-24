using Bootcamp.CRUD.Context;
using Bootcamp.CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.CRUD
{
    public class ManageSupplier
    {
        public void MenuSupplier()
        {
            var result = 0;

            Supplier supplier = new Supplier();
            MyContext _context = new MyContext();
            Console.WriteLine("===================== Supplier Data ==================");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Retrieve");
            Console.WriteLine("======================================================");
            Console.Write("Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================================");
            switch (choice)
            {
                case 1:
                    // ini untuk memasukan nilai Name, JoinDate dan CreateDate di Supplier
                    Console.WriteLine("Insert Data Supplier");
                    Console.Write("Insert Name of Supplier : ");
                    supplier.Name = Console.ReadLine();
                    supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
                    supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;

                    _context.Suppliers.Add(supplier);
                    result = _context.SaveChanges();
                    if (result > 0)
                    {
                        Console.Write("Insert Successfully");
                        Console.Read();
                    }
                    else
                    {
                        Console.Write("Insert Failed");
                        Console.Read();
                    }
                    Console.Read();
                    break;
                case 2:
                    // input id untuk dicari
                    Console.WriteLine("Update Data Supplier");
                    Console.Write("Insert Id to update data : ");
                    int id = Convert.ToInt16(Console.ReadLine());

                    // mencari  data sesuai dengan isi di databae
                    var get = _context.Suppliers.Find(id);

                    //pengecekan data di database
                    if (get == null)
                    {
                        // jika tidak adan, maka akan menampilkan seperti berikut
                        Console.Write("Sorry your data is not found");
                    }
                    else
                    {
                        //jika ada, maka akan meminta inputan nama dan akan disimpan di database
                        Console.Write("Insert Name of Supplier : ");
                        get.Name = Console.ReadLine();
                        get.UpdateDate = DateTimeOffset.Now.LocalDateTime;
                        result = _context.SaveChanges();
                        if (result > 0)
                        {
                            Console.Write("Update Successfully");
                            Console.Read();
                        }
                        else
                        {
                            Console.Write("Update Failed ");
                            Console.Read();
                        }

                    }
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Delete Data Supplier");
                    // input id untuk dicari
                    Console.Write("Insert Id to Delete data : ");

                    // mencari  data sesuai dengan isi di databae
                    var getData = _context.Suppliers.Find(Convert.ToInt16(Console.ReadLine()));

                    //pengecekan data di database
                    if (getData == null)
                    {
                        // jika tidak adan, maka akan menampilkan seperti berikut
                        Console.Write("Sorry your data is not found");
                    }
                    else
                    {
                        //jika ada, maka akan meminta inputan nama dan akan disimpan di database
                        getData.IsDelete = true;
                        getData.DeleteDate = DateTimeOffset.Now.LocalDateTime;

                        result = _context.SaveChanges();
                        if (result > 0)
                        {
                            Console.Write("Delete Successfully");
                            Console.Read();
                        }
                        else
                        {
                            Console.Write("Delete Failed ");
                            Console.Read();
                        }

                    }
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("Retrieve Data Supplier");
                    var getDatatoDisplay = _context.Suppliers.Where(x => x.IsDelete == false).ToList();

                    if (getDatatoDisplay.Count == 0)
                    {
                        Console.Write("No Data in your database");
                    }
                    else
                    {
                        foreach (var tampilin in getDatatoDisplay)
                        {
                            Console.WriteLine("=========================================================");
                            Console.WriteLine("Name                 :" + tampilin.Name);
                            Console.WriteLine("Join Date            :" + tampilin.JoinDate);
                            Console.WriteLine("=========================================================");
                        }
                        Console.Write("Total Supplier " + getDatatoDisplay.Count);
                    }
                    Console.Read();
                    break;
                default:
                    Console.Write("Please try again");
                    Console.Read();
                    break;

            }
            Console.WriteLine("======================================================");
            Console.ReadLine();
        }
    }
    
}
