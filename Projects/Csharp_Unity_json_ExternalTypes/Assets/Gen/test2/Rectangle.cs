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



namespace cfg.test2
{

/// <summary>
/// 矩形
/// </summary>
public sealed partial class Rectangle :  test.Shape 
{
    public Rectangle(JSONNode _json)  : base(_json) 
    {
        { if(!_json["width"].IsNumber) { throw new SerializationException(); }  Width = _json["width"]; }
        { if(!_json["height"].IsNumber) { throw new SerializationException(); }  Height = _json["height"]; }
        PostInit();
    }

    public Rectangle(float width, float height )  : base() 
    {
        this.Width = width;
        this.Height = height;
        PostInit();
    }

    public static Rectangle DeserializeRectangle(JSONNode _json)
    {
        return new test2.Rectangle(_json);
    }

    /// <summary>
    /// 宽度
    /// </summary>
    public float Width { get; private set; }
    /// <summary>
    /// 高度
    /// </summary>
    public float Height { get; private set; }

    public const int __ID__ = 694982337;
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
        + "Width:" + Width + ","
        + "Height:" + Height + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
