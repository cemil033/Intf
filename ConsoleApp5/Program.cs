using ConsoleApp5;
Flash flash = new()
{
    MediaName = "SAMSUNG",
    Model = "S-12",
    Size = 2340,
    Speed = 100,
    filescount = 1000,
    Data="salam"
};
DVD dVD = new() { 
    MediaName = "Disc1x",
    Model= "Disc1x",
    Size = 3900,
    Speed = 78,
    filescount = 1000

};
HDD dHDD = new() 
{
    MediaName = "Seagate",
    Model = "gt-390",
    Size = 390000,
    Speed = 78,
    filescount = 1000,
    Data="sagol"
};
DVD VD = new()
{
    MediaName = "Disc2x",
    Model = "Disc2x",
    Size = 7800,
    Speed = 78,
    filescount = 1000,
    Data ="Hakuna matata"
};

flash.Copy(dVD);
Console.WriteLine(dVD.Data); ;
Console.WriteLine("\n");

VD.Copy(dHDD);
Console.WriteLine(dHDD.Data);
Console.WriteLine("\n");



