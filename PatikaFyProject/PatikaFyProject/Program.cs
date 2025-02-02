

using PatikaFyProject;

List<Artist> artist = new List<Artist>
{
    new Artist {Name  = "Ajda Pekkan" , Genre = "Pop" , ReleaseYear = 1968, AlbumSales = 20000000 },

    new Artist {Name  = "Sezen Aksu " , Genre = "Türk Halk/Pop" , ReleaseYear = 1971, AlbumSales = 10000000 },

    new Artist {Name  = "Funda Arar" , Genre = "Pop" , ReleaseYear = 1999, AlbumSales = 20000000 },

    new Artist {Name  = "Sertab Erener" , Genre = "Pop" , ReleaseYear = 1994, AlbumSales = 3000000 },

    new Artist {Name  = "Hande Yener" , Genre = "Pop" , ReleaseYear = 1999, AlbumSales = 7000000 },

    new Artist {Name  = "Sıla Ergenç" , Genre = "Pop" , ReleaseYear = 2009, AlbumSales = 3000000 },

    new Artist {Name  = "Serdar Ortaç" , Genre = "Pop" , ReleaseYear = 1994, AlbumSales = 10000000 },

    new Artist {Name  = "Tarkan" , Genre = "Pop" , ReleaseYear = 1992, AlbumSales = 40000000 },

    new Artist {Name  = "Hadise" , Genre = "Pop" , ReleaseYear = 2005, AlbumSales = 5000000 },

    new Artist {Name  = "Gülben Ergen" , Genre = "Türk Halk/Pop" , ReleaseYear = 1997, AlbumSales = 10000000 },

    new Artist {Name  = "Neşet Ertaş" , Genre = "Türk Halk/Türk Sanat" , ReleaseYear = 1960, AlbumSales = 2000000 }






};
// 1. S harfi ile başlayan sanatçıları listeleyiniz.
var sArtist = artist.Where(artist => artist.Name.StartsWith  ("S"));
foreach (var item in sArtist)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("----------------------------------");

// Albüm satışları 10 milyon üzerindekileri sıralama.
var albumSales = artist.Where(artist => artist.AlbumSales > 10000000);

foreach (var item in albumSales)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("----------------------------------");

//2000 Öncesi çıkış yapan sanatçılar.
var relaseYear = artist.Where(artist => artist.ReleaseYear < 2000);

foreach (var item in relaseYear)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("----------------------------------");

//En çok albüm satışı yapan sanatçıyı bulma.
var bestSeller = artist.OrderByDescending(artist => artist.AlbumSales).First();

Console.WriteLine(bestSeller.Name);

Console.WriteLine("----------------------------------");


//En yeni çıkış yapan ve en eski çıkış yapan sanatçıyı bulma.
var releaseYearOrder = artist.OrderBy(artist => artist.ReleaseYear).First();
var releaseYearOrderDesc = artist.OrderByDescending(artist => artist.ReleaseYear).First();

Console.WriteLine($"En yeni çıkış yapan şarkıcı : {releaseYearOrderDesc.Name}\n\nEn eski çıkış yapan şarkıcı : {releaseYearOrder.Name}");