using System;
using Foundation;

namespace SuiHanOpenCC {
	// @interface OpenCCService : NSObject
	[BaseType(typeof(NSObject))]
	interface OpenCCService {
		// -(instancetype)initWithConverterType:(OpenCCServiceConverterType)converterType;
		[Export("initWithConverterType:")]
		IntPtr Constructor(OpenCCServiceConverterType converterType);

		// -(NSString *)convert:(NSString *)str;
		[Export("convert:")]
		string Convert(string str);
	}
}
