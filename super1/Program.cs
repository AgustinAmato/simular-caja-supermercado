/*
Hacer un programa que simule una caja de supermercado.

Debe:
cargar 5 productos.
uardar precios en vector.
calcular total.
mostrar ticket.*/

string[] producto = new string[5];
int [] precio = new int[5];
int acum = 0;
int total = 0;

for (int i = 0; i < producto.Length; i++)
{
    Console.WriteLine("ingrese nombre del producto ");
     producto[i] = Console.ReadLine();

    Console.WriteLine("ingrese precio del producto ");
    precio[i]=int.Parse(Console.ReadLine());

    acum += precio[i];
}

total = acum;

Console.WriteLine("*****TICKET DE COMPRA*****");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Producto: " + producto[i] + " Precio: " + precio[i]);
}

Console.WriteLine("TOTAL: $" + total);   
