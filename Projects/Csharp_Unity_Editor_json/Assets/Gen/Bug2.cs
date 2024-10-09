
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

namespace cfg
{

public sealed class Bug2 :  Luban.EditorBeanBase 
{
    public Bug2()
    {
            City = "";
            State = "";
            ZipCode = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["ProjectLocationID"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  ProjectLocationID = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["City"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  City = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["State"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  State = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["ZipCode"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  ZipCode = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["TaxRate"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  TaxRate = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["MaterialCostIndex"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  MaterialCostIndex = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["CarpenterCostIndex"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  CarpenterCostIndex = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["ElectrianCostIndex"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  ElectrianCostIndex = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["MasonCostIndex"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  MasonCostIndex = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["PlumberCostIndex"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  PlumberCostIndex = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["ProjectLocationID"] = new JSONNumber(ProjectLocationID);
        }
        {

            if (City == null) { throw new System.ArgumentNullException(); }
            _json["City"] = new JSONString(City);
        }
        {

            if (State == null) { throw new System.ArgumentNullException(); }
            _json["State"] = new JSONString(State);
        }
        {

            if (ZipCode == null) { throw new System.ArgumentNullException(); }
            _json["ZipCode"] = new JSONString(ZipCode);
        }
        {
            _json["TaxRate"] = new JSONNumber(TaxRate);
        }
        {
            _json["MaterialCostIndex"] = new JSONNumber(MaterialCostIndex);
        }
        {
            _json["CarpenterCostIndex"] = new JSONNumber(CarpenterCostIndex);
        }
        {
            _json["ElectrianCostIndex"] = new JSONNumber(ElectrianCostIndex);
        }
        {
            _json["MasonCostIndex"] = new JSONNumber(MasonCostIndex);
        }
        {
            _json["PlumberCostIndex"] = new JSONNumber(PlumberCostIndex);
        }
    }

    public static Bug2 LoadJsonBug2(SimpleJSON.JSONNode _json)
    {
        Bug2 obj = new Bug2();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBug2(Bug2 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 地区ID
    /// </summary>
    public int ProjectLocationID;

    /// <summary>
    /// 城市
    /// </summary>
    public string City;

    /// <summary>
    /// 区域
    /// </summary>
    public string State;

    /// <summary>
    /// 邮政编码
    /// </summary>
    public string ZipCode;

    /// <summary>
    /// 税率
    /// </summary>
    public float TaxRate;

    public float MaterialCostIndex;

    public float CarpenterCostIndex;

    public float ElectrianCostIndex;

    public float MasonCostIndex;

    public float PlumberCostIndex;

}

}

