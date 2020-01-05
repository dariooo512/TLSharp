using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(-1398145746)]
    public class TLRequestInvokeWithTakeout : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1398145746;
            }
        }

                public Type X {get;set;}
        public long TakeoutId {get;set;}
        public TLObject Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            X = (Type)ObjectUtils.DeserializeObject(br);
TakeoutId = br.ReadInt64();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(X,bw);
bw.Write(TakeoutId);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (TLObject)ObjectUtils.DeserializeObject(br);

		}
    }
}
