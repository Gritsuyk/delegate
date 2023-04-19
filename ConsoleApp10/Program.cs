using System;
// Интерфейс GeometryOperation<T>
interface GeometryOperation<T>
{
    Func<T, T> Reverse { get; set; }
}
// Наследник GeometryOperation<Polygon>
class PolygonGeometryOperation : GeometryOperation<Polygon>
{
    public Func<Polygon, Polygon> Reverse { get; set; }
    // Конструктор, принимающий делегат для переворота полигона
    public PolygonGeometryOperation(Func<Polygon, Polygon> reverse)
    {
        Reverse = reverse;
    }
}
// Пример использования
class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр класса Polygon
        Polygon polygon = new Polygon();
        // Создаем экземпляр класса PolygonGeometryOperation, передавая в конструктор делегат для переворота полигона
        PolygonGeometryOperation operation = new PolygonGeometryOperation(ReversePolygon);
        // Вызываем делегат Reverse из объекта operation для переворота полигона
        Polygon reversedPolygon = operation.Reverse(polygon);
    }
    // Функция для переворота полигона
    static Polygon ReversePolygon(Polygon polygon)
    {
        // Реализация переворота полигона
        return polygon;
    }
}
// Класс Polygon, для примера
public class Polygon
{
    // Свойства полигона
    public int Id { get; set; }
    public string Name { get; set; }
    // Конструктор полигона
    public Polygon(int id, string name)
    {
        Id = id;
        Name = name;
    }
}