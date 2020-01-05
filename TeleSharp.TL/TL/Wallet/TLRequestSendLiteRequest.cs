using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Wallet
{
	[TLObject(-490089666)]
    public class TLRequestSendLiteRequest : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -490089666;
            }
        }

                public byte[] Body {get;set;}
        public Wallet.TLLiteResponse Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Body = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            BytesUtil.Serialize(Body,bw);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (Wallet.TLLiteResponse)ObjectUtils.DeserializeObject(br);

		}
    }
}
