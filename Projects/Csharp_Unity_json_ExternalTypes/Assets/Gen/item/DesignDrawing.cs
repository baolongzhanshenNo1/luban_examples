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



namespace cfg.item
{

public sealed partial class DesignDrawing :  item.ItemExtra 
{
    public DesignDrawing(JSONNode _json)  : base(_json) 
    {
        { var __json0 = _json["learn_component_id"]; if(!__json0.IsArray) { throw new SerializationException(); } LearnComponentId = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  LearnComponentId.Add(__v0); }   }
        PostInit();
    }

    public DesignDrawing(int id, System.Collections.Generic.List<int> learn_component_id )  : base(id) 
    {
        this.LearnComponentId = learn_component_id;
        PostInit();
    }

    public static DesignDrawing DeserializeDesignDrawing(JSONNode _json)
    {
        return new item.DesignDrawing(_json);
    }

    public System.Collections.Generic.List<int> LearnComponentId { get; private set; }

    public const int __ID__ = -1679179579;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "LearnComponentId:" + Bright.Common.StringUtil.CollectionToString(LearnComponentId) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
