
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class DefineFromExcel2 extends AbstractBean {
    public DefineFromExcel2(JsonObject _buf) { 
        id = _buf.get("id").getAsInt();
        x1 = _buf.get("x1").getAsBoolean();
        x5 = _buf.get("x5").getAsLong();
        x6 = _buf.get("x6").getAsFloat();
        x8 = _buf.get("x8").getAsInt();
        x10 = _buf.get("x10").getAsString();
        x13 = _buf.get("x13").getAsInt();
        x132 = _buf.get("x13_2").getAsInt();
        x14 = cfg.test.DemoDynamic.deserialize(_buf.get("x14").getAsJsonObject());
        x15 = cfg.test.Shape.deserialize(_buf.get("x15").getAsJsonObject());
        v2 = cfg.vector2.deserialize(_buf.get("v2").getAsJsonObject());
        t1 = _buf.get("t1").getAsLong();
        { com.google.gson.JsonArray _json0_ = _buf.get("k1").getAsJsonArray(); int __n0 = _json0_.size(); k1 = new int[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { int __v0;  __v0 = __e0.getAsInt();  k1[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("k2").getAsJsonArray(); int __n0 = _json0_.size(); k2 = new int[__n0]; int __index0=0; for(JsonElement __e0 : _json0_) { int __v0;  __v0 = __e0.getAsInt();  k2[__index0++] = __v0; }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("k8").getAsJsonArray(); k8 = new java.util.HashMap<Integer, Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _k0;  _k0 = _e0.getAsJsonArray().get(0).getAsInt(); int _v0;  _v0 = _e0.getAsJsonArray().get(1).getAsInt();  k8.put(_k0, _v0); }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("k9").getAsJsonArray(); k9 = new java.util.ArrayList<cfg.test.DemoE2>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.test.DemoE2 _v0;  _v0 = cfg.test.DemoE2.deserialize(_e0.getAsJsonObject());  k9.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("k10").getAsJsonArray(); k10 = new java.util.ArrayList<cfg.vector3>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.vector3 _v0;  _v0 = cfg.vector3.deserialize(_e0.getAsJsonObject());  k10.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("k11").getAsJsonArray(); k11 = new java.util.ArrayList<cfg.vector4>(_json0_.size()); for(JsonElement _e0 : _json0_) { cfg.vector4 _v0;  _v0 = cfg.vector4.deserialize(_e0.getAsJsonObject());  k11.add(_v0); }   }
    }

    public static DefineFromExcel2 deserialize(JsonObject _buf) {
            return new cfg.DefineFromExcel2(_buf);
    }

    /**
     * 这是id
     */
    public final int id;
    /**
     * 字段x1
     */
    public final boolean x1;
    public final long x5;
    public final float x6;
    public final int x8;
    public final String x10;
    public final int x13;
    public final int x132;
    public final cfg.test.DemoDynamic x14;
    public final cfg.test.Shape x15;
    public final cfg.vector2 v2;
    public final long t1;
    public final int[] k1;
    public final int[] k2;
    public final java.util.HashMap<Integer, Integer> k8;
    public final java.util.ArrayList<cfg.test.DemoE2> k9;
    public final java.util.ArrayList<cfg.vector3> k10;
    public final java.util.ArrayList<cfg.vector4> k11;

    public static final int __ID__ = 482045152;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + x1 + ","
        + "(format_field_name __code_style field.name):" + x5 + ","
        + "(format_field_name __code_style field.name):" + x6 + ","
        + "(format_field_name __code_style field.name):" + x8 + ","
        + "(format_field_name __code_style field.name):" + x10 + ","
        + "(format_field_name __code_style field.name):" + x13 + ","
        + "(format_field_name __code_style field.name):" + x132 + ","
        + "(format_field_name __code_style field.name):" + x14 + ","
        + "(format_field_name __code_style field.name):" + x15 + ","
        + "(format_field_name __code_style field.name):" + v2 + ","
        + "(format_field_name __code_style field.name):" + t1 + ","
        + "(format_field_name __code_style field.name):" + k1 + ","
        + "(format_field_name __code_style field.name):" + k2 + ","
        + "(format_field_name __code_style field.name):" + k8 + ","
        + "(format_field_name __code_style field.name):" + k9 + ","
        + "(format_field_name __code_style field.name):" + k10 + ","
        + "(format_field_name __code_style field.name):" + k11 + ","
        + "}";
    }
}
