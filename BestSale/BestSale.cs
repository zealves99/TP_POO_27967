using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //Used to verify if a string meets certain criteria.
using Business_Layer;

namespace BestSale
{
    class BestSale
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Client clientTest = new Client("Jose Alves","962310421");
            //Client clientTest2 = new Client("Rui Jordao", "931250420");
            //Client clientTest1 = new Client();

            //Make benfica = new Make("Benfica");
            //Category futebol = new Category("Futebol");
            //Product product1 = new Product("1A34", 23.9m, new Warranty("1A34",3, "Nao gostar de batatas."), benfica, futebol );

            //Make braga = new Make("Braga");
            //Product product2 = new Product("2V45", 15.9m, new Warranty("2V45", 3, "Nao gostar de peixe."), braga, futebol);

            //Sale sale = new Sale();
            //sale.InsertProductOnSale(product1);
            //sale.InsertProductOnSale(product2);

            //Console.WriteLine(sale.ToString());

            //Clients clientes = new Clients();
            //clientes.AddClient(clientTest);
            //clientes.AddClient(clientTest2);

            //foreach (Client client in clientes.ClientList)
            //{
            //    Console.WriteLine(client.ToString());
            //}

            bool a = ClientManagement.CreateClientInStore("Jose Alves", "962310421");



        }
    }
}
