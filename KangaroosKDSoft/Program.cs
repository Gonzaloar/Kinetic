static string KangaroosMeet(int x1, int v1, int x2, int v2)
{
    if (v1 < v2) // Si la distancia de salto de v2 es mayor, v1 nunca lo alcanzará
        return "NO";
    else if (v1 - v2 == 1) // Si v1 es mayor a v2 por solo una unidad, tarde o temprano lo ancanzará
        return "SI";
    else // Ciclamos hasta que x1 alcance o pase a x2
    {
        while (x1 < x2)
        {
            x1 += v1;
            x2 += v2;
        }

        if (x1 == x2) // Si son iguales, coniciden en un punto
            return "SI";
        else
            return "NO"; // Si no son iguales, x1 sobrepasó a x2, por ende nunca concidirán
    }
}

Console.WriteLine(KangaroosMeet(0, 3, 4, 2)); // Lote de pruebas del ejemplo
Console.WriteLine(KangaroosMeet(0, 2, 4, 2)); // Lote de pruebas respuesta NO
Console.WriteLine(KangaroosMeet(0, 6, 6, 3)); // Lote de pruebas respuesta SI

