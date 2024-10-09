
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;

namespace cfg.test
{

public sealed class AutoImport2 :  Luban.EditorBeanBase 
{
    public AutoImport2()
    {
            x10 = "";
            x13 = test.DemoEnum.NONE;
            x132 = test.DemoFlag.A;
            v2 = new vec2();
            t1 = "1970-01-01 00:00:00";
            k1 = System.Array.Empty<int>();
            k2 = System.Array.Empty<int>();
            k8 = new System.Collections.Generic.Dictionary<int,int>();
            k9 = new System.Collections.Generic.List<test.DemoE2>();
            k10 = new System.Collections.Generic.List<vec3>();
            k11 = new System.Collections.Generic.List<vec4>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  x1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x5 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x6"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x6 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x8"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x8 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x10"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  x10 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x13"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { x13 = (test.DemoEnum)System.Enum.Parse(typeof(test.DemoEnum), _fieldJson); } else if(_fieldJson.IsNumber) { x13 = (test.DemoEnum)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["x13_2"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { x132 = (test.DemoFlag)System.Enum.Parse(typeof(test.DemoFlag), _fieldJson); } else if(_fieldJson.IsNumber) { x132 = (test.DemoFlag)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["x14"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x14 = test.DemoDynamic.LoadJsonDemoDynamic(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["x15"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  x15 = test.Shape.LoadJsonShape(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["v2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v2 = vec2.LoadJsonvec2(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["t1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  t1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["k1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n0 = _fieldJson.Count; k1 = new int[_n0]; int _index0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  k1[_index0++] = __v0; }  
            }
        }
        
        { 
            var _fieldJson = _json["k2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n0 = _fieldJson.Count; k2 = new int[_n0]; int _index0=0; foreach(SimpleJSON.JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  k2[_index0++] = __v0; }  
            }
        }
        
        { 
            var _fieldJson = _json["k8"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k8 = new System.Collections.Generic.Dictionary<int, int>(); foreach(JSONNode __e0 in _fieldJson.Children) { int __k0;  if(!__e0[0].IsNumber) { throw new SerializationException(); }  __k0 = __e0[0]; int __v0;  if(!__e0[1].IsNumber) { throw new SerializationException(); }  __v0 = __e0[1];  k8.Add(__k0, __v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["k9"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k9 = new System.Collections.Generic.List<test.DemoE2>(); foreach(JSONNode __e0 in _fieldJson.Children) { test.DemoE2 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.DemoE2.LoadJsonDemoE2(__e0);  k9.Add(__v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["k10"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k10 = new System.Collections.Generic.List<vec3>(); foreach(JSONNode __e0 in _fieldJson.Children) { vec3 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = vec3.LoadJsonvec3(__e0);  k10.Add(__v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["k11"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } k11 = new System.Collections.Generic.List<vec4>(); foreach(JSONNode __e0 in _fieldJson.Children) { vec4 __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = vec4.LoadJsonvec4(__e0);  k11.Add(__v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["v11"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v11 = vec3.LoadJsonvec3(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            _json["x1"] = new JSONBool(x1);
        }
        {
            _json["x5"] = new JSONNumber(x5);
        }
        {
            _json["x6"] = new JSONNumber(x6);
        }
        {
            _json["x8"] = new JSONNumber(x8);
        }
        {

            if (x10 == null) { throw new System.ArgumentNullException(); }
            _json["x10"] = new JSONString(x10);
        }
        {
            _json["x13"] = new JSONNumber((int)x13);
        }
        {
            _json["x13_2"] = new JSONNumber((int)x132);
        }
        {

            if (x14 == null) { throw new System.ArgumentNullException(); }
            { var __bjson0 = new JSONObject(); _json["x14"] = __bjson0; test.DemoDynamic.SaveJsonDemoDynamic(x14, __bjson0); }
        }
        {

            if (x15 == null) { throw new System.ArgumentNullException(); }
            { var __bjson0 = new JSONObject(); _json["x15"] = __bjson0; test.Shape.SaveJsonShape(x15, __bjson0); }
        }
        {
            { var __bjson0 = new JSONObject(); _json["v2"] = __bjson0; vec2.SaveJsonvec2(v2, __bjson0); }
        }
        {
            _json["t1"] = new JSONString(t1);
        }
        {

            if (k1 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["k1"] = __cjson0; foreach(var _e0 in k1) { JSONNode __v0; __v0 = new JSONNumber(_e0); __cjson0.Add(__v0); } }
        }
        {

            if (k2 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["k2"] = __cjson0; foreach(var _e0 in k2) { JSONNode __v0; __v0 = new JSONNumber(_e0); __cjson0.Add(__v0); } }
        }
        {

            if (k8 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["k8"] = __cjson0; foreach(var _e0 in k8) { var __entry0 = new JSONArray(); __cjson0.Add(__entry0); JSONNode __k0; __k0 = new JSONNumber(_e0.Key); __entry0.Add(__k0); JSONNode __v0; __v0 = new JSONNumber(_e0.Value); __entry0.Add(__v0); }  }
        }
        {

            if (k9 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["k9"] = __cjson0; foreach(var _e0 in k9) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; test.DemoE2.SaveJsonDemoE2(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }
        {

            if (k10 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["k10"] = __cjson0; foreach(var _e0 in k10) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; vec3.SaveJsonvec3(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }
        {

            if (k11 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["k11"] = __cjson0; foreach(var _e0 in k11) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; vec4.SaveJsonvec4(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }

        if (v11 != null)
        {
            { var __bjson0 = new JSONObject(); _json["v11"] = __bjson0; vec3.SaveJsonvec3(v11, __bjson0); }
        }
    }

    public static AutoImport2 LoadJsonAutoImport2(SimpleJSON.JSONNode _json)
    {
        AutoImport2 obj = new test.AutoImport2();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonAutoImport2(AutoImport2 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public int id;

    /// <summary>
    /// 字段x1
    /// </summary>
    public bool x1;

    public long x5;

    public float x6;

    public int x8;

    public string x10;

    public test.DemoEnum x13;

    public test.DemoFlag x132;

    public test.DemoDynamic x14;

    public test.Shape x15;

    public vec2 v2;

    public string t1;

    public int[] k1;

    public int[] k2;

    public System.Collections.Generic.Dictionary<int, int> k8;

    public System.Collections.Generic.List<test.DemoE2> k9;

    public System.Collections.Generic.List<vec3> k10;

    public System.Collections.Generic.List<vec4> k11;

    public vec3? v11;

}

}

