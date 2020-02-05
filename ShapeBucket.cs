using System;
using System.Collections.Generic;
using System.Linq;

#region Colour

public interface IColour {
    string GetColour();
}

public class Red : IColour {
    private string _colour = "Red";

    public string GetColour()
    {
        return _colour;
    }
}

public class Blue : IColour
{
    private string _colour = "Blue";

    public string GetColour()
    {
        return _colour;
    }
}

#endregion

#region Shape

public interface IShape<TColour> where TColour : IColour {
    int Edges { get; }
}

public class RedTriangle : IShape<Red>
{
    private int _edges = 3;
    public int Edges => _edges;
}

public class RedCircle : IShape<Red>
{
    private int _edges = 0;
    public int Edges => _edges;
}

public class BlueSquare : IShape<Blue>
{
    private int _edges = 4;
    public int Edges => _edges;
}

public class BluePentagon : IShape<Blue>
{
    private int _edges = 5;
    public int Edges => _edges;
}

#endregion

public class ShapeBucket<TColour> where TColour : IColour
{
    private IList<IShape<TColour>> _shapesList = new List<IShape<TColour>>();
    public ShapeBucket() 
    {
        
    }

    public void AddShape(IShape<TColour> shape){
        _shapesList.Add(shape);
    }

    public IEnumerable<IShape<TColour>> GetShapes() {
        return _shapesList;
    }

    public IEnumerable<IShape<TColour>> FindShapes(Func<IShape<TColour>, bool> predicate) {
        var result = _shapesList.Where(predicate);
        return result;
    }
}