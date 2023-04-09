using NetLinqSetsApp;

List<Company> companies1 = new()
{
    new(){ Title = "Yandex" },
    new(){ Title = "Mail Group" },
    new(){ Title = "Ozon" },
    new(){ Title = "Avito" },
    new(){ Title = "Google" },
    new(){ Title = "Facebook" },
    new(){ Title = "TikTok" },
    new(){ Title = "Twitter" },
};

List<Company> companies2 = new()
{
    new(){ Title = "Facebook" },
    new(){ Title = "Amazon" },
    new(){ Title = "Mail Group" },
    new(){ Title = "HotMail" },
    new(){ Title = "Xiaomy" },
    new(){ Title = "Samsung" },
    new(){ Title = "Facebook" },
    new(){ Title = "Youtube" },
    new(){ Title = "Microsoft" },
};

foreach (var comp in companies1)
    Console.WriteLine(comp);
Console.WriteLine();

foreach (var comp in companies2.Distinct(new CompanyComparer()))
    Console.WriteLine(comp);
Console.WriteLine();


var compIntersect =  companies1.Intersect(companies2, new CompanyComparer());
foreach(var comp in compIntersect)
    Console.WriteLine(comp);
Console.WriteLine();

var compUnion = companies1.Union(companies2, new CompanyComparer());
foreach (var comp in compUnion)
    Console.WriteLine(comp);
Console.WriteLine();

var compExcept = companies1.Except(companies2, new CompanyComparer());
foreach (var comp in compExcept)
    Console.WriteLine(comp);
Console.WriteLine();

