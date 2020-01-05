using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Wallet
{
	[TLObject(1984136919)]
    public class TLLiteResponse : TLObject
    {
        public override int Constructor
        {
            get
            {
                return 1984136919;
            }
        }

             public byte[] Response {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Response = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            BytesUtil.Serialize(Response,bw);

        }
    }
}
