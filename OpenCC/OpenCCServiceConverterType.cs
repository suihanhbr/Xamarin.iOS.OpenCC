using System;
using SuiHanOpenCC;
namespace OpenCC {

	using A = SuiHanOpenCC.OpenCCServiceConverterType;

	public enum OpenCCServiceConverterType : ulong {
		S2t = A.S2t,
		T2s = A.T2s,
		S2tw = A.S2tw,
		Tw2s = A.Tw2s,
		S2hk = A.S2hk,
		Hk2s = A.Hk2s,
		S2twp = A.S2twp,
		Tw2sp = A.Tw2sp,
		T2hk = A.T2hk,
		T2tw = A.T2tw
	}
}
