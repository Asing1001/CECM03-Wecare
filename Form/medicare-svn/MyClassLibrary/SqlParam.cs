using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class SqlParam
    {
        public SqlDbType Type { get; set; }
        public string sValue { get; set; }
        public ParameterDirection Direction { get; set; }
        public string Param { get; set; }
        public int iValue { get; set; }
        public int Size { get; set; }
        public byte[] image { get; set; }

        public SqlParam() { }

        public SqlParam(string p, SqlDbType t)
        {
            this.Param = p;
            this.Type = t;
            this.Direction = ParameterDirection.Output;
        }

        public SqlParam(string p, SqlDbType t, string s)
        {
            this.Param = p;
            this.Type = t;
            this.Direction = ParameterDirection.Input;
            this.sValue = s;
            iValue = 0;
        }

        public SqlParam(string p, SqlDbType t, byte[] i)
        {
            this.Param = p;
            this.Type = t;
            this.Direction = ParameterDirection.Input;
            this.image = i;
            this.Size = 4096;
        }

        public SqlParam(string p, SqlDbType t, int i)
        {
            this.Param = p;
            this.Type = t;
            this.Direction = ParameterDirection.Input;
            this.iValue = i;
        }

        public SqlParam(string p, SqlDbType t, ParameterDirection d)
        {
            this.Param = p;
            this.Type = t;
            this.Direction = d;
        }

        public SqlParam(string p, SqlDbType t, int i, ParameterDirection d)
        {
            this.Param = p;
            this.Type = t;
            this.Direction = d;
            this.Size = i;
        }
    }
}
