using System;

// Спільний інтерфейс або абстрактний клас для всіх типів графіків
abstract class Chart
{
    public abstract void Draw();
}

// Конкретні класи для кожного типу графіка
class LineChart : Chart
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Line Chart");
        // Логіка для візуалізації лінійного графіка
    }
}

class BarChart : Chart
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Bar Chart");
        // Логіка для візуалізації стовпчикового графіка
    }
}

class PieChart : Chart
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Pie Chart");
        // Логіка для візуалізації кругової діаграми
    }
}

// Фабричний метод
abstract class GraphFactory
{
    public abstract Chart CreateChart();
}

// Конкретні фабрики для кожного типу графіка
class LineChartFactory : GraphFactory
{
    public override Chart CreateChart()
    {
        return new LineChart();
    }
}

class BarChartFactory : GraphFactory
{
    public override Chart CreateChart()
    {
        return new BarChart();
    }
}

class PieChartFactory : GraphFactory
{
    public override Chart CreateChart()
    {
        return new PieChart();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the type of chart (Line/Bar/Pie):");
        string chartType = Console.ReadLine();

        // Вибір відповідної фабрики в залежності від введеного користувачем типу графіка
        GraphFactory factory;
        switch (chartType.ToLower())
        {
            case "line":
                factory = new LineChartFactory();
                break;
            case "bar":
                factory = new BarChartFactory();
                break;
            case "pie":
                factory = new PieChartFactory();
                break;
            default:
                Console.WriteLine("Invalid chart type.");
                return;
        }

        // Створення графіка за допомогою фабрики та візуалізація
        Chart chart = factory.CreateChart();
        chart.Draw();

        Console.ReadLine();
    }
}