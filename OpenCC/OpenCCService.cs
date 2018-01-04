using System;
using SuiHanOpenCC;
namespace OpenCC {
	public class OpenCCService {
		SuiHanOpenCC.OpenCCService p;
		public OpenCCService(OpenCCServiceConverterType t) {
			p = new SuiHanOpenCC.OpenCCService((SuiHanOpenCC.OpenCCServiceConverterType)t);
		}

		public String Convert(String str) {
			return p.Convert(str);
		}
	}
}
