using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
	[TLObject(-136770336)]
    public class TLTheme : TLAbsTheme
    {
        public override int Constructor
        {
            get
            {
                return -136770336;
            }
        }

             public int Flags {get;set;}
     public bool Creator {get;set;}
     public bool Default {get;set;}
     public long Id {get;set;}
     public long AccessHash {get;set;}
     public string Slug {get;set;}
     public string Title {get;set;}
     public TLAbsDocument Document {get;set;}
     public int InstallsCount {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
Creator = (Flags & 1) != 0;
Default = (Flags & 2) != 0;
Id = br.ReadInt64();
AccessHash = br.ReadInt64();
Slug = StringUtil.Deserialize(br);
Title = StringUtil.Deserialize(br);
if ((Flags & 4) != 0)
Document = (TLAbsDocument)ObjectUtils.DeserializeObject(br);
else
Document = null;

InstallsCount = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            bw.Write(Flags);


bw.Write(Id);
bw.Write(AccessHash);
StringUtil.Serialize(Slug,bw);
StringUtil.Serialize(Title,bw);
if ((Flags & 4) != 0)
ObjectUtils.SerializeObject(Document,bw);
bw.Write(InstallsCount);

        }
    }
}
