
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.test
{

public sealed partial class Test3 : Luban.BeanBase
{
    public Test3(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        X = (int)_obj.GetValue("x");
        Y = (int)_obj.GetValue("y");
    }

    public static Test3 DeserializeTest3(JToken _buf)
    {
        return new test.Test3(_buf);
    }

    public readonly int X;
    public readonly int Y;


    public const int __ID__ = 638540133;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "x:" + X + ","
        + "y:" + Y + ","
        + "}";
    }
}
}
