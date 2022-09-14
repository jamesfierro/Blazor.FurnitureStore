Console.WriteLine("escribe el precio del producto: ");
double valor = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine("escribe tu forma de pago, efectivo o tarjeta: ");
String precio = (Console.ReadLine()).ToLower();


if (precio.Equals("tarjeta")){

    Console.WriteLine("Introduce el numero de tarjeta: ");
    int numero_tarjeta = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("el producto con precio " + precio + "se ha pagado " + "con el numero de cuenta " + numero_tarjeta );

}
else if (precio.Equals("efectivo"))
{
    Console.WriteLine("El producto con precio " + precio + "se ha pagado");
}
else
{
    Console.WriteLine("El valor ingresado no es correcto");
}
Console.ReadLine();







