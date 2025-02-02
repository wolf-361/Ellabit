﻿namespace Ellabit.Challenges
{
    public class Challenge072Amazingedabit : IChallenge
    {
        public string? Header { get; set; } = "Amazing ellabit!";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  string AmazingEllabit(string str) {
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AmazingEllabit(""ellabit is amazing."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""ellabit is amazing."",  $""returned: {sumResult}  expected: ellabit is amazing."");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AmazingEllabit(""Mubashir is amazing."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Mubashir is not amazing."",   $""returned: {sumResult}  expected: Mubashir is not amazing."");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AmazingEllabit(""Infinity is amazing."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Infinity is not amazing."",   $""returned: {sumResult}  expected: Infinity is not amazing."");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string and changes the word amazing to not amazing. Return the string without any change if the word edabit is part of the string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
AmazingEdabit(""ellabit is amazing."") ➞ ""ellabit is amazing.""

AmazingEdabit(""Mubashir is amazing."") ➞ ""Mubashir is not amazing.""

AmazingEdabit(""Infinity is amazing."") ➞ ""Infinity is not amazing.""
            </p>
        </code>
Notes
Ellabit is amazing :)";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
