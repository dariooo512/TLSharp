using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Wallet
{
	[TLObject(190313286)]
    public class TLRequestGetKeySecretSalt : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 190313286;
            }
        }

                public bool Revoke {get;set;}
        public KeySecretSalt Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Revoke = BoolUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            BoolUtil.Serialize(Revoke,bw);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (KeySecretSalt)ObjectUtils.DeserializeObject(br);

		}
    }
}
