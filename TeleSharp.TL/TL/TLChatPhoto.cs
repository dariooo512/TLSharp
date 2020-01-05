using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(1197267925)]
    public class TLChatPhoto : TLAbsChatPhoto
    {
        public override int Constructor
        {
            get
            {
                return 1197267925;
            }
        }

             public FileLocation PhotoSmall {get;set;}
     public FileLocation PhotoBig {get;set;}
     public int DcId {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            PhotoSmall = (FileLocation)ObjectUtils.DeserializeObject(br);
PhotoBig = (FileLocation)ObjectUtils.DeserializeObject(br);
DcId = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ObjectUtils.SerializeObject(PhotoSmall,bw);
ObjectUtils.SerializeObject(PhotoBig,bw);
bw.Write(DcId);

        }
    }
}
