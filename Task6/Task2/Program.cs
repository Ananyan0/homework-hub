public class Vector
{
    public int X { get; }
    public int Y { get; }
    public int Z { get; }


    public Vector(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return ($"X: {X} Y: {Y} Z: {Z}");
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }
    public static Vector operator *(Vector v1, Vector v2)
    {
        return new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
    }
    public static Vector operator /(Vector v1, Vector v2)
    {
        if (v2.X == 0 || v2.Z == 0){
            Console.WriteLine("Can not be divisible to 0");
            return null;
        }
        return new Vector(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
    }
    public static bool operator ==(Vector v1, Vector v2)
    {
        if (v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Vector v1, Vector v2)
    {
        if (v1.X != v2.X && v1.Y != v2.Y && v1.Z != v2.Z)
        {
            Console.WriteLine("Vectors all elements are not equal");
            return true;
        }
        return false;
    }

    public static bool operator true(Vector v1)
    {
        return (v1.X != 0 && v1.Y != 0 && v1.Z != 0);
    }
    public static bool operator false(Vector v1)
    {
        return (v1.X == 0 && v1.Y == 0 && v1.Z == 0);
    }

    public double Magnutude(Vector v)
    {
        return Math.Sqrt(v.X * v.X + v.Y * v.Y + v.Z * v.Z);
    }

    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Magnutude(v1) > v2.Magnutude(v2);
    }
    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Magnutude(v1) < v2.Magnutude(v2);
    }
    public static bool operator >=(Vector v1, Vector v2)
    {
        return v1.Magnutude(v1) >= v2.Magnutude(v2);
    }
    public static bool operator <=(Vector v1, Vector v2)
    {
        return v1.Magnutude(v1) <= v2.Magnutude(v2);
    }
}


public class Program
{
    public static void Main()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(1, 2, 3);
        Console.WriteLine(v1.ToString());
        Console.WriteLine(v2.ToString());

        Console.WriteLine("Vectors add:" + (v1 + v2));
        Console.WriteLine("Vectors sub:" + (v1 - v2));
        Console.WriteLine("Vectors mul:" + (v1 * v2));
        Console.WriteLine("Vectors div:" + (v1 / v2));
        Console.WriteLine(v1 == v2);
        Console.WriteLine(v1 != v2);
        Console.WriteLine(v1 > v2);
        Console.WriteLine(v1 < v2);
        Console.WriteLine(v1 >= v2);
        Console.WriteLine(v1 <= v2);

        Console.ReadKey();
    }
}