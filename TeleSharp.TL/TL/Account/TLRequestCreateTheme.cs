using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL.Account
{
	[TLObject(729808255)]
    public class TLRequestCreateTheme : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return 729808255;
            }
        }

                public string Slug {get;set;}
        public string Title {get;set;}
        public TLAbsInputDocument Document {get;set;}
        public TLAbsTheme Response{ get; set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Slug = StringUtil.Deserialize(br);
Title = StringUtil.Deserialize(br);
Document = (TLAbsInputDocument)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(Slug,bw);
StringUtil.Serialize(Title,bw);
ObjectUtils.SerializeObject(Document,bw);

        }
		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (TLAbsTheme)ObjectUtils.DeserializeObject(br);

		}
    }
}
