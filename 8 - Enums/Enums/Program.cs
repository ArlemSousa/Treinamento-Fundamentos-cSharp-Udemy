// See https://aka.ms/new-console-template for more information
using Enums.Entities;
using Enums.Entities.Enums;

Order order = new Order()
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.Delivered //instanciar o Enum

};

Console.WriteLine(order);
//imprimir a classe


string txt = OrderStatus.Processing.ToString();
Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
//imprimir o valor da enum pesquisando pelo nome
Console.WriteLine(os);
