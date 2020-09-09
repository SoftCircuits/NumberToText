<a href="https://www.buymeacoffee.com/jonathanwood" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/black_img.png" alt="Buy Me A Coffee" style="height: 37px !important;width: 170px !important;" ></a>

# NumberToText

[![NuGet version (SoftCircuits.NumberToText)](https://img.shields.io/nuget/v/SoftCircuits.NumberToText.svg?style=flat-square)](https://www.nuget.org/packages/SoftCircuits.NumberToText/)

```
Install-Package SoftCircuits.NumberToText
```

## Overview

Converts a number to text. For example, the library would convert `123.45` to `"One hundred twenty-three and 45/100"`. Useful for check printing or other cases where you want to display a number as text.

## Example

```cs
NumberToText converter = new NumberToText();
string s = converter.Transform(123.45);
```

Note that negative numbers are converted to positive numbers before transforming. Therefore, `123.45` would product the same result for as for `-123.45`. Depending on how you want negative numbers handled, you could prefix the result with `"Minus"` or something to that effect when the value is a negative number.

## Additional Information

For additional information, check the [Converting Numbers to Words](http://www.blackbeltcoder.com/Articles/strings/converting-numbers-to-words) article on Black Belt Coder.
