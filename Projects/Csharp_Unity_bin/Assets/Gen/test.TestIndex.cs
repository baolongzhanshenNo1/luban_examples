
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class TestIndex : Luban.BeanBase
{
    public TestIndex(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Eles = new System.Collections.Generic.List<test.DemoType1>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.DemoType1 _e0;  _e0 = test.DemoType1.DeserializeDemoType1(_buf); Eles.Add(_e0);}}
        foreach(var _v in Eles)
        { 
            Eles_Index.Add(_v.X1, _v);
        }
    }

    public static TestIndex DeserializeTestIndex(ByteBuf _buf)
    {
        return new test.TestIndex(_buf);
    }

    public readonly int Id;
    public readonly System.Collections.Generic.List<test.DemoType1> Eles;
    public readonly System.Collections.Generic.Dictionary<int, test.DemoType1> Eles_Index = new System.Collections.Generic.Dictionary<int, test.DemoType1>();
   
    public const int __ID__ = 1941154020;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        foreach (var _e in Eles) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "eles:" + Luban.StringUtil.CollectionToString(Eles) + ","
        + "}";
    }
}

}