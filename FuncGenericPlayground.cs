using System;
using System.Collections.Generic;
using System.Linq;

public class FuncGenericPlayground<T> where T : class {
    private IEnumerable<T> _funcList;

    public FuncGenericPlayground(IEnumerable<T> _list)
    {
        _funcList = _list;
    }

    public IEnumerable<T> FuncList { get => _funcList; }

    public IEnumerable<T> ExecutePredicate(Func<T, bool> predicate){
        var result = _funcList.Where(predicate);

        return result;
    }
}