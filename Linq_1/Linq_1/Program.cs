var beers = new List<Beer>()
{
    new Beer() { Name = "Pikantus", Brand = "Ergind", Alcohol = 13.75m },
    new Beer() { Name = "Weissbier", Brand = "Erdinger", Alcohol = 5.3m },
    new Beer() { Name = "IPA", Brand = "Erdinger", Alcohol = 6.2m },
    new Beer() { Name = "Stout", Brand = "Guinness", Alcohol = 4.2m },
    new Beer() { Name = "Pale Ale", Brand = "Sierra Nevada", Alcohol = 5.6m }
};

var brands = new List<Brand>()
{
    new Brand() { Name = "Erdinger", Country = "Germany" },
    new Brand() { Name = "Guinness", Country = "Ireland" },
    new Brand() { Name = "Lagunitas", Country = "USA" },
    new Brand() { Name = "Sierra Nevada", Country = "USA" },
    new Brand() { Name = "Heineken", Country = "Netherlands" }
};


var beers2 = from b in beers
            select new { b.Name, b.Brand };


var beers3 = from b in beers
             where b.Brand == "Erdinger" || b.Alcohol >= 7
             select new { b.Name, b.Brand };


var beers4 = beers.Where(b => b.Brand == "Erdinger" || b.Alcohol >= 7)
                    .Select(b => new
                    {
                        b.Name,
                        b.Brand
                    });

// ORDER BY
var beers5 = from b in beers
             orderby b.Alcohol descending
             select new { b.Name, b.Brand, b.Alcohol };

var beers6 = from b in beers
             group b by b.Brand into groupBeers
             select new { 
                    Brand = groupBeers.Key,
                    Count = groupBeers.Count()
             };

//JOIN
var beers7 = from b in beers
             join br in brands on b.Brand equals br.Name
             select new { b.Name, b.Brand, br.Country };

foreach (var b in beers7)
{
    Console.WriteLine(b.Name + "" + b.Brand + "" + b.Country);
}

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public decimal Alcohol { get; set; }
}

public class Brand
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}