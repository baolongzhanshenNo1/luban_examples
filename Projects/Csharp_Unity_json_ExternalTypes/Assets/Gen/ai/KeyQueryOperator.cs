//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.ai
{

public abstract partial class KeyQueryOperator :  Bright.Config.BeanBase 
{
    public KeyQueryOperator(JSONNode _json) 
    {
        PostInit();
    }

    public KeyQueryOperator() 
    {
        PostInit();
    }

    public static KeyQueryOperator DeserializeKeyQueryOperator(JSONNode _json)
    {
        string type = _json["$type"];
        switch (type)
        {
            case "IsSet": return new ai.IsSet(_json);
            case "IsNotSet": return new ai.IsNotSet(_json);
            case "BinaryOperator": return new ai.BinaryOperator(_json);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
