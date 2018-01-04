# Xamarin.iOS.OpenCC
OpenCC项目的Xamarin.iOS封装库(this is the wrap library of OpenCC to Xamarin.iOS)
## 使用方法
- 1.在Xamarin.iOS项目中添加对OpenCC项目的引用；（add reference to OpenCC project in your Xamarin.iOS）
- 2.在代码中加入(add code like below)
```
using OpenCC;

....

OpenCCService p = new OpenCCService(OpenCCServiceConverterType.S2t);
p.Convert("岁寒输入法");
....

```
## Supported conversation types
- HK2S, Traditional Chinese (Hong Kong Standard) to Simplified Chinese 香港繁體（香港小學學習字詞表標準）到簡體
- S2HK, Simplified Chinese to Traditional Chinese (Hong Kong Standard) 簡體到香港繁體（香港小學學習字詞表標準）
- S2T, Simplified Chinese to Traditional Chinese 簡體到繁體
- S2TW, Simplified Chinese to Traditional Chinese (Taiwan Standard) 簡體到臺灣正體
- S2TWP, Simplified Chinese to Traditional Chinese (Taiwan Standard) with Taiwanese idiom 簡體到繁體（臺灣正體標準）並轉換爲臺灣常用詞彙
- T2HK, Traditional Chinese to Traditional Chinese (Hong Kong Standard) 繁體到香港繁體（香港小學學習字詞表標準）
- T2S, Traditional Chinese to Simplified Chinese 繁體到簡體
- T2TW, Traditional Chinese to Traditional Chinese (Taiwan Standard) 繁體臺灣正體
- TW2S, Traditional Chinese (Taiwan Standard) to Simplified Chinese 臺灣正體到簡體
- TW2SP, Traditional Chinese (Taiwan Standard) to Simplified Chinese with Mainland Chinese idiom 繁體（臺灣正體標準）到簡體並轉換爲中國大陸常用詞彙

# References
- https://github.com/BYVoid/OpenCC
- https://github.com/gelosie/OpenCC/tree/master/iOS
