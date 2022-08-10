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

public sealed partial class GetOwnerPlayer :  ai.Service 
{
    public GetOwnerPlayer(JSONNode _json)  : base(_json) 
    {
        { if(!_json["player_actor_key"].IsString) { throw new SerializationException(); }  PlayerActorKey = _json["player_actor_key"]; }
        PostInit();
    }

    public GetOwnerPlayer(int id, string node_name, string player_actor_key )  : base(id,node_name) 
    {
        this.PlayerActorKey = player_actor_key;
        PostInit();
    }

    public static GetOwnerPlayer DeserializeGetOwnerPlayer(JSONNode _json)
    {
        return new ai.GetOwnerPlayer(_json);
    }

    public string PlayerActorKey { get; private set; }

    public const int __ID__ = -999247644;
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
        + "NodeName:" + NodeName + ","
        + "PlayerActorKey:" + PlayerActorKey + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
