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



namespace cfg.blueprint
{

public sealed partial class EnumClazz :  blueprint.Clazz 
{
    public EnumClazz(JSONNode _json)  : base(_json) 
    {
        { var __json0 = _json["enums"]; if(!__json0.IsArray) { throw new SerializationException(); } Enums = new System.Collections.Generic.List<blueprint.EnumField>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { blueprint.EnumField __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = blueprint.EnumField.DeserializeEnumField(__e0);  }  Enums.Add(__v0); }   }
        PostInit();
    }

    public EnumClazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods, System.Collections.Generic.List<blueprint.EnumField> enums )  : base(name,desc,parents,methods) 
    {
        this.Enums = enums;
        PostInit();
    }

    public static EnumClazz DeserializeEnumClazz(JSONNode _json)
    {
        return new blueprint.EnumClazz(_json);
    }

    public System.Collections.Generic.List<blueprint.EnumField> Enums { get; private set; }

    public const int __ID__ = 1827364892;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Enums) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Enums) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "Enums:" + Bright.Common.StringUtil.CollectionToString(Enums) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
