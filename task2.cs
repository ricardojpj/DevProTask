using System;
using System.Collections.Generic;
List<Dictionary<string, object>> products = new List<Dictionary<string, object>>
{
    new Dictionary<string, object> { { "name", "Product A" }, { "price", 100 }, { "stock", 5 } },
    new Dictionary<string, object> { { "name", "Product B" }, { "price", 200 }, { "stock", 3 } },
    new Dictionary<string, object> { { "name", "Product C" }, { "price", 50 }, { "stock", 10 } }
};

string sort_key = "price";
bool ascending = false;

products.Sort((a, b) =>
{
    if (sort_key == "name")
    {
        if (ascending)
        {
            return string.Compare((string)a[sort_key], (string)b[sort_key]);
        }
        else
        {
            return string.Compare((string)b[sort_key], (string)a[sort_key]);
        }
    }
    else
    {
        if (ascending)
        {
            return ((int)a[sort_key]).CompareTo((int)b[sort_key]);
        }
        else
        {
            return ((int)b[sort_key]).CompareTo((int)a[sort_key]);
        }
    }
});

Console.WriteLine("SORT LIST");
foreach (var product in products)
{
    Console.WriteLine($"Name: {product["name"]}, Price: {product["price"]}, Stock: {product["stock"]}");
}

