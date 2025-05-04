using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOBase
    {
        public static readonly int Int_NullValue = -1;
        public static readonly float Float_NullValue = -1.0f;
        public static readonly decimal Decimal_NullValue = -1m;
        public static readonly string String_NullValue = null;
        public static readonly Guid Guid_NullValue = Guid.Empty;
        public static readonly DateTime DateTime_NullValue = DateTime.MinValue;
        public static readonly bool Boolean_NullValue = false;
    }
}
