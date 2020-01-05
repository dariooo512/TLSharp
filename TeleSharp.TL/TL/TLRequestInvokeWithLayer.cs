using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(-627372787)]
    public class TLRequestInvokeWithLayer : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -627372787;
            }
        }

                public Type X {get;set;}
        public int Layer {get;set;}
        public TLObject Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            X = (Type)ObjectUtils.DeserializeObject(br);
Layer = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(X,bw);
bw.Write(Layer);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (TLObject)ObjectUtils.DeserializeObject(br);

		}
    }
}
