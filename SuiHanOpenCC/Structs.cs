using System;
using ObjCRuntime;

namespace SuiHanOpenCC
{
	[Native]
	public enum OpenCCServiceConverterType : ulong
	{
		S2t,
		T2s,
		S2tw,
		Tw2s,
		S2hk,
		Hk2s,
		S2twp,
		Tw2sp,
		T2hk,
		T2tw
	}
}
