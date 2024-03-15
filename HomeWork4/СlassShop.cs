// Клас "Магазин"
public class Shop
{
    // Властивість для зберігання площі магазину
    public double ShopArea { get; private set; }

    // Конструктор класу
    public Shop(double shopArea)
    {
        ShopArea = shopArea;
    }

    // Метод для збільшення площі магазину
    public void IncreaseArea(double amount)
    {
        ShopArea += amount;
    }

    // Метод для зменшення площі магазину
    public void DecreaseArea(double amount)
    {
        ShopArea -= amount;
    }

    // Перевантаження операторів
    public static bool operator ==(Shop shop1, Shop shop2)
    {
        return shop1.ShopArea == shop2.ShopArea;
    }

    public static bool operator !=(Shop shop1, Shop shop2)
    {
        return !(shop1 == shop2);
    }

    public static bool operator <(Shop shop1, Shop shop2)
    {
        return shop1.ShopArea < shop2.ShopArea;
    }

    public static bool operator >(Shop shop1, Shop shop2)
    {
        return shop1.ShopArea > shop2.ShopArea;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Shop other = (Shop)obj;
        return this.ShopArea == other.ShopArea;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Journal
        Journal journal1 = new Journal(10);
        Journal journal2 = new Journal(15);

        Console.WriteLine(journal1 == journal2); // Перевірка на рівність кількості працівників
        Console.WriteLine(journal1 != journal2);
        Console.WriteLine(journal1 < journal2); // Перевірка на меншу кількість працівників
        Console.WriteLine(journal1 > journal2); // Перевірка на більшу кількість працівників

        // Приклад використання класу Shop
        Shop shop1 = new Shop(1000);
        Shop shop2 = new Shop(1500);

        Console.WriteLine(shop1 == shop2); // Перевірка на рівність площі магазинів
        Console.WriteLine(shop1 != shop2);
        Console.WriteLine(shop1 < shop2); // Перевірка на менший магазин за площею
        Console.WriteLine(shop1 > shop2); // Перевірка на більший магазин за площею

        ReadingList myReadingList = new ReadingList();

        // Додавання книг до списку
        myReadingList.AddBook("Book1");
        myReadingList.AddBook("Book2");
        myReadingList.AddBook("Book3");

        // Видалення книги зі списку
        myReadingList.RemoveBook("Book2");

        // Перевірка чи є книга у списку
        Console.WriteLine(myReadingList.ContainsBook("Book1")); // Виведе true
        Console.WriteLine(myReadingList.ContainsBook("Book2")); // Виведе false

        // Використання індексатора
        Console.WriteLine(myReadingList[0]); // Виведе "Book1"

        // Перевірка за допомогою операторів
        Console.WriteLine(myReadingList == "Book1"); // Виведе true
        Console.WriteLine(myReadingList != "Book2"); // Виведе true
    }
}