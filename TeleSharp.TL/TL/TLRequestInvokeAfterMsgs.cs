using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(1036301552)]
    public class TLRequestInvokeAfterMsgs : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 1036301552;
            }
        }

                public Type X {get;set;}
        public TLVector<long> MsgIds {get;set;}
        public TLObject Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            X = (Type)ObjectUtils.DeserializeObject(br);
MsgIds = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(X,bw);
ObjectUtils.SerializeObject(MsgIds,bw);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (TLObject)ObjectUtils.DeserializeObject(br);

		}
    }
}
