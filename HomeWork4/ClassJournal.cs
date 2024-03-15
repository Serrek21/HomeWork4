using System;

// Клас "Журнал"
public class Journal
{
    // Властивість для зберігання кількості працівників
    public int NumberOfEmployees { get; private set; }

    // Конструктор класу
    public Journal(int numberOfEmployees)
    {
        NumberOfEmployees = numberOfEmployees;
    }

    // Метод для збільшення кількості працівників
    public void IncreaseEmployees(int amount)
    {
        NumberOfEmployees += amount;
    }

    // Метод для зменшення кількості працівників
    public void DecreaseEmployees(int amount)
    {
        NumberOfEmployees -= amount;
    }

    // Перевантаження операторів
    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.NumberOfEmployees == journal2.NumberOfEmployees;
    }

    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return !(journal1 == journal2);
    }

    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1.NumberOfEmployees < journal2.NumberOfEmployees;
    }

    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1.NumberOfEmployees > journal2.NumberOfEmployees;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Journal other = (Journal)obj;
        return this.NumberOfEmployees == other.NumberOfEmployees;
    }
}
