using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(-1080796745)]
    public class TLRequestInvokeWithoutUpdates : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1080796745;
            }
        }

                public Type X {get;set;}
        public TLObject Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            X = (Type)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(X,bw);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (TLObject)ObjectUtils.DeserializeObject(br);

		}
    }
}
