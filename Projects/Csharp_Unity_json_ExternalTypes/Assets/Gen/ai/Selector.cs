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

public sealed partial class Selector :  ai.ComposeNode 
{
    public Selector(JSONNode _json)  : base(_json) 
    {
        { var __json0 = _json["children"]; if(!__json0.IsArray) { throw new SerializationException(); } Children = new System.Collections.Generic.List<ai.FlowNode>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ai.FlowNode __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.FlowNode.DeserializeFlowNode(__e0);  }  Children.Add(__v0); }   }
        PostInit();
    }

    public Selector(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, System.Collections.Generic.List<ai.FlowNode> children )  : base(id,node_name,decorators,services) 
    {
        this.Children = children;
        PostInit();
    }

    public static Selector DeserializeSelector(JSONNode _json)
    {
        return new ai.Selector(_json);
    }

    public System.Collections.Generic.List<ai.FlowNode> Children { get; private set; }

    public const int __ID__ = -1946981627;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Children) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Children) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "Children:" + Bright.Common.StringUtil.CollectionToString(Children) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
