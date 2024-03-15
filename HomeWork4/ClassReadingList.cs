using System;

// Клас "Список книг до прочитання"
public class ReadingList
{
    // Максимальна кількість книг у списку
    private const int MaxBooks = 10;

    // Масив книг
    private string[] books = new string[MaxBooks];

    // Індексатор для доступу до книг за індексом
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < books.Length)
            {
                return books[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        set
        {
            if (index >= 0 && index < books.Length)
            {
                books[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    // Метод для додавання книги до списку
    public void AddBook(string book)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == null)
            {
                books[i] = book;
                return;
            }
        }
        Console.WriteLine("Список книг вже заповнений!");
    }

    // Метод для видалення книги зі списку
    public void RemoveBook(string book)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == book)
            {
                books[i] = null;
                return;
            }
        }
        Console.WriteLine("Книга не знайдена у списку!");
    }

    // Метод для перевірки чи є книга у списку
    public bool ContainsBook(string book)
    {
        foreach (string b in books)
        {
            if (b == book)
            {
                return true;
            }
        }
        return false;
    }

    // Перевантаження операторів
    public static bool operator ==(ReadingList readingList, string book)
    {
        return readingList.ContainsBook(book);
    }

    public static bool operator !=(ReadingList readingList, string book)
    {
        return !(readingList == book);
    }
}