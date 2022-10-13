//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace cfg.test
{
   
    public partial class TbCompositeJsonTable3
    {
        public static TbCompositeJsonTable3 Instance { get; private set; }

        private test.CompositeJsonTable3 _data;

        public TbCompositeJsonTable3 (ByteBuf _buf, string _tbName, System.Func<string, ByteBuf> _loader)
        {
            Instance = this;
            ByteBuf _dataBuf = _loader(_tbName);
            int n = _buf.ReadSize();
            int m = _dataBuf.ReadSize();
            if (n != 1 || m != 1) throw new SerializationException("table mode=one, but size != 1");
            _data = test.CompositeJsonTable3.DeserializeCompositeJsonTable3(_dataBuf);
        }


        public int A => _data.A;
        public int B => _data.B;

        
    
        public void CacheTables(Dictionary<string, object> _tables)
        {
            _data.Resolve(_tables);
        }
        partial void PostInit();
    }
} 