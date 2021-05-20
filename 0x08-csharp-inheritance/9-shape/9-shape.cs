using System;

class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException ("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    { 
        get 
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            } else {
                width = value;
            }
        } 
    }

    public int Height
    { 
        get 
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            } else {
                height = value;
            }
        } 
    }

    public new int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        string msg = String.Format("[Rectangle] {0} / {1}", width, height);
        return msg;
    }
}


class Square : Rectangle
{
    private int size;
    public int Size
    { 
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            } else {
                size = value;
                Width = value;
                Height =  value;
            }
        }
    }

    public override string ToString()
    {
        string msg = String.Format("[Square] {0} / {1}", size, size);
        return msg;
    }    
}