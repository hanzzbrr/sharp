using System.Collections;

public class Program
{
    public static void Main(string [] args)
    {
        
    }
}

public class Box : IEquatable<Box>
{
    public Box(int h, int l, int w)
    {
        this.Height = h;
        this.Length = l;
        this.Width = w;
    }

    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }

    public bool Equals(Box other)
    {
        if(new BoxSameDimensions().Equals(this, other))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


public class BoxCollection : ICollection<Box>
{
    private List<Box> innerCol;

    public BoxCollection()
    {
        innerCol = new List<Box>();
    }

    public Box this[int index]
    {
        get { return (Box)innerCol[index]; }
        set { innerCol[index] = value; }
    }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(Box item)
    {
        if (!Contains(item))
        {
            innerCol.Add(item);
        }
        else
        {
            Console.WriteLine("A box with {0}x{1}x{2} dimensions was already added to the collection.",
                item.Height.ToString(), item.Length.ToString(), item.Width.ToString());
        }
    }
    public bool Remove(Box item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        innerCol.Clear();
    }

    public bool Contains(Box item)
    {
        bool found = false;

        foreach(Box bx in innerCol)
        {
            if(bx.Equals(item))
            {
                found = true;
            }
        }
        return found;
    }

    // Determines if an item is in the
    // collection by using a specified equality comparer.
    public bool Contains(Box item, EqualityComparer<Box> comp)
    {
        bool found = false;

        foreach (Box bx in innerCol)
        {
            if (comp.Equals(bx, item))
            {
                found = true;
            }
        }

        return found;
    }

    public void CopyTo(Box[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }



    public IEnumerator<Box> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class BoxEnumerator
{

}

public class BoxSameDimensions : EqualityComparer<Box>
{

    public override bool Equals(Box b1, Box b2)
    {
        if (b1.Height == b2.Height && b1.Length == b2.Length
                            && b1.Width == b2.Width)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode(Box bx)
    {
        int hCode = bx.Height ^ bx.Length ^ bx.Width;
        return hCode.GetHashCode();
    }
}

public class BoxSameVol : EqualityComparer<Box>
{

    public override bool Equals(Box b1, Box b2)
    {
        if ((b1.Height * b1.Length * b1.Width) ==
                (b2.Height * b2.Length * b2.Width))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode(Box bx)
    {
        int hCode = bx.Height ^ bx.Length ^ bx.Width;
        Console.WriteLine("HC: {0}", hCode.GetHashCode());
        return hCode.GetHashCode();
    }
}