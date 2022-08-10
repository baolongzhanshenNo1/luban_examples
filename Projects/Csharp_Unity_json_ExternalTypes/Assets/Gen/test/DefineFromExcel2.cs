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



namespace cfg.test
{

public sealed partial class DefineFromExcel2 :  Bright.Config.BeanBase 
{
    public DefineFromExcel2(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["x1"].IsBoolean) { throw new SerializationException(); }  X1 = _json["x1"]; }
        { if(!_json["x5"].IsNumber) { throw new SerializationException(); }  X5 = _json["x5"]; }
        { if(!_json["x6"].IsNumber) { throw new SerializationException(); }  X6 = _json["x6"]; }
        { if(!_json["x8"].IsNumber) { throw new SerializationException(); }  X8 = _json["x8"]; }
        { if(!_json["x10"].IsString) { throw new SerializationException(); }  X10 = _json["x10"]; }
        { if(!_json["x13"].IsNumber) { throw new SerializationException(); }  X13 = (test.ETestQuality)_json["x13"].AsInt; }
        { if(!_json["x14"].IsObject) { throw new SerializationException(); }  X14 = test.DemoDynamic.DeserializeDemoDynamic(_json["x14"]);  }
        { if(!_json["x15"].IsObject) { throw new SerializationException(); }  X15 = test.Shape.DeserializeShape(_json["x15"]);  }
        { var _json2 = _json["v2"]; if(!_json2.IsObject) { throw new SerializationException(); }  float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } V2 = new System.Numerics.Vector2(__x, __y); }
        { if(!_json["t1"].IsNumber) { throw new SerializationException(); }  T1 = _json["t1"]; }
        { var __json0 = _json["k1"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K1 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K1[__index0++] = __v0; }   }
        { var __json0 = _json["k2"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; K2 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  K2[__index0++] = __v0; }   }
        { var __json0 = _json["k8"]; if(!__json0.IsArray) { throw new SerializationException(); } K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  K8.Add(_k0, _v0); }   }
        { var __json0 = _json["k9"]; if(!__json0.IsArray) { throw new SerializationException(); } K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.DemoE2 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  }  K9.Add(__v0); }   }
        PostInit();
    }

    public DefineFromExcel2(int id, bool x1, long x5, float x6, int x8, string x10, test.ETestQuality x13, test.DemoDynamic x14, test.Shape x15, System.Numerics.Vector2 v2, System.DateTime t1, int[] k1, int[] k2, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X5 = x5;
        this.X6 = x6;
        this.X8 = x8;
        this.X10 = x10;
        this.X13 = x13;
        this.X14 = x14;
        this.X15 = x15;
        this.V2 = v2;
        this.T1 = t1;
        this.K1 = k1;
        this.K2 = k2;
        this.K8 = k8;
        this.K9 = k9;
        PostInit();
    }

    public static DefineFromExcel2 DeserializeDefineFromExcel2(JSONNode _json)
    {
        return new test.DefineFromExcel2(_json);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 字段x1
    /// </summary>
    public bool X1 { get; private set; }
    public long X5 { get; private set; }
    public float X6 { get; private set; }
    public int X8 { get; private set; }
    public string X10 { get; private set; }
    public test.ETestQuality X13 { get; private set; }
    public test.DemoDynamic X14 { get; private set; }
    public test.Shape X15 { get; private set; }
    public System.Numerics.Vector2 V2 { get; private set; }
    public System.DateTime T1 { get; private set; }
    public int[] K1 { get; private set; }
    public int[] K2 { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> K8 { get; private set; }
    public System.Collections.Generic.List<test.DemoE2> K9 { get; private set; }

    public const int __ID__ = 688816828;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X14?.Resolve(_tables);
        X15?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X14?.TranslateText(translator);
        X15?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X8:" + X8 + ","
        + "X10:" + X10 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "X15:" + X15 + ","
        + "V2:" + V2 + ","
        + "T1:" + T1 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K2:" + Bright.Common.StringUtil.CollectionToString(K2) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
