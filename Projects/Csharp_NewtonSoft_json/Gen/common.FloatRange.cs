
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.common
{

public sealed partial class FloatRange : Luban.BeanBase
{
    public FloatRange(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        Min = (float)_obj.GetValue("min");
        Max = (float)_obj.GetValue("max");
    }

    public static FloatRange DeserializeFloatRange(JToken _buf)
    {
        return new common.FloatRange(_buf);
    }

    public readonly float Min;
    public readonly float Max;


    public const int __ID__ = 561922116;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "min:" + Min + ","
        + "max:" + Max + ","
        + "}";
    }
}
}
