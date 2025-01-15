

Console.WriteLine("While PRACTICE: ");
Console.WriteLine("---------- 1 ----------");


int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}


Console.WriteLine("--------- 2 ---------");   //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

i = 1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("---------3--------");  //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

i = 1;
while (i <= 20)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}


Console.WriteLine("----------4--------");  //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;
i = 50;

while (i <= 150)
{
    toplam = toplam + i;
    i++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı = " + toplam);

Console.WriteLine("----------5---------");  //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
{
    int tekToplam = 0;
    int ciftToplam = 0;

    i = 1;
    while (i <= 120)
    {

        if (i % 2 == 0)
        {
            ciftToplam += i;
        }
        else
        {
            tekToplam += i;
        }
        i++;
    }
    Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı = " + tekToplam);
    Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı = " + ciftToplam);
}


