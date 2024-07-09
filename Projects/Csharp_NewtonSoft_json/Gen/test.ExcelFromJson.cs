
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

public sealed partial class ExcelFromJson : Luban.BeanBase
{
    public ExcelFromJson(JToken _buf) 
    {
        JObject _obj = _buf as JObject;
        X4 = (int)_obj.GetValue("x4");
        X1 = (bool)_obj.GetValue("x1");
        X5 = (long)_obj.GetValue("x5");
        X6 = (float)_obj.GetValue("x6");
        S1 = (string)_obj.GetValue("s1");
        S2 = (string)_obj.GetValue("s2");
        T1 = (long)_obj.GetValue("t1");
        X12 = test.DemoType1.DeserializeDemoType1(_obj.GetValue("x12"));
        X13 = (test.DemoEnum)(int)_obj.GetValue("x13");
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_obj.GetValue("x14"));
        { var __json0 = _obj.GetValue("k1"); int _n0 = (__json0 as JArray).Count; K1 = new int[_n0]; int __index0=0; foreach(JToken __e0 in __json0) { int __v0;  __v0 = (int)__e0;  K1[__index0++] = __v0; }   }
        { var __json0 = _obj.GetValue("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { int _k0;  _k0 = (int)__e0[0]; int _v0;  _v0 = (int)__e0[1];  K8.Add(_k0, _v0); }   }
        { var __json0 = _obj.GetValue("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { test.DemoE2 __v0;  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  K9.Add(__v0); }   }
        { var __json0 = _obj.GetValue("k15"); int _n0 = (__json0 as JArray).Count; K15 = new test.DemoDynamic[_n0]; int __index0=0; foreach(JToken __e0 in __json0) { test.DemoDynamic __v0;  __v0 = test.DemoDynamic.DeserializeDemoDynamic(__e0);  K15[__index0++] = __v0; }   }
    }

    public static ExcelFromJson DeserializeExcelFromJson(JToken _buf)
    {
        return new test.ExcelFromJson(_buf);
    }

    public readonly int X4;
    public readonly bool X1;
    public readonly long X5;
    public readonly float X6;
    public readonly string S1;
    public readonly string S2;
    public readonly long T1;
    public readonly test.DemoType1 X12;
    public readonly test.DemoEnum X13;
    public readonly test.DemoDynamic X14;
    public readonly int[] K1;
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    public readonly System.Collections.Generic.List<test.DemoE2> K9;
    public readonly test.DemoDynamic[] K15;


    public const int __ID__ = -1485706483;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X12?.ResolveRef(tables);
        X14?.ResolveRef(tables);
        foreach (var _e in K15) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "x4:" + X4 + ","
        + "x1:" + X1 + ","
        + "x5:" + X5 + ","
        + "x6:" + X6 + ","
        + "s1:" + S1 + ","
        + "s2:" + S2 + ","
        + "t1:" + T1 + ","
        + "x12:" + X12 + ","
        + "x13:" + X13 + ","
        + "x14:" + X14 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(K1) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(K8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(K9) + ","
        + "k15:" + Luban.StringUtil.CollectionToString(K15) + ","
        + "}";
    }
}
}
