// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split("-");

string type = "01";
string color = "MN";
string size = "L";
string[] numbers = { "01", "02", "03" };
string[] colors = { "BL", "MN", "W" };
string[] sizes = { "S", "M", "L" };

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < colors.Length; j++)
    {
        for (int k = 0; k < sizes.Length; k++)
        {
            if (type == numbers[i] && color == colors[j] && size == sizes[k])
            {
                Console.WriteLine("Product:" + type + "-" + color + "-" + size);
            }
        }

    }
}