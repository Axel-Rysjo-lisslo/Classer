SakEtt boll = new SakEtt();
SakTva furkant = new SakTva();


boll.hp -= 36;
furkant.hp += 78;

Console.WriteLine(boll.name);
Console.WriteLine(boll.hp);
boll.name = "bol";

Console.WriteLine(furkant.name);
Console.WriteLine(furkant.hp);
furkant.name = "fyrkant";




Console.ReadLine();
