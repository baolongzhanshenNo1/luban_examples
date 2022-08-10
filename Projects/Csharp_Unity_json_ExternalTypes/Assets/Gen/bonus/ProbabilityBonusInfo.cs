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



namespace cfg.bonus
{

public sealed partial class ProbabilityBonusInfo :  Bright.Config.BeanBase 
{
    public ProbabilityBonusInfo(JSONNode _json) 
    {
        { if(!_json["bonus"].IsObject) { throw new SerializationException(); }  Bonus = bonus.Bonus.DeserializeBonus(_json["bonus"]);  }
        { if(!_json["probability"].IsNumber) { throw new SerializationException(); }  Probability = _json["probability"]; }
        PostInit();
    }

    public ProbabilityBonusInfo(bonus.Bonus bonus, float probability ) 
    {
        this.Bonus = bonus;
        this.Probability = probability;
        PostInit();
    }

    public static ProbabilityBonusInfo DeserializeProbabilityBonusInfo(JSONNode _json)
    {
        return new bonus.ProbabilityBonusInfo(_json);
    }

    public bonus.Bonus Bonus { get; private set; }
    public float Probability { get; private set; }

    public const int __ID__ = 46960455;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Bonus?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Bonus?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Bonus:" + Bonus + ","
        + "Probability:" + Probability + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
