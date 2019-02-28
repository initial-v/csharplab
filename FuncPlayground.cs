using System;
using System.Collections.Generic;
using System.Linq;

public class FuncPlayground {
    private IEnumerable<string> _funcList = new List<string>() {"Apple", "Orange", "Watermelon", "Mango", "Orange", "Banana"};

    public IEnumerable<string> FuncList { get => _funcList; set => _funcList = value; }

    public IEnumerable<string> ExecutePredicate(Func<string, bool> predicate){
        var result = _funcList.Where(predicate);

        return result;
    }
}