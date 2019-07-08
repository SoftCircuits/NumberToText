# NumberToText

[![NuGet version (SoftCircuits.NumberToText)](https://img.shields.io/nuget/v/SoftCircuits.NumberToText.svg?style=flat-square)](https://www.nuget.org/packages/SoftCircuits.NumberToText/)

```
Install-Package SoftCircuits.NumberToText
```

## Overview

Converts a number to text. For example, converts 123.45 to "One hundred twenty-three and 45/100". Useful for check printing or other cases where you want to display a number as text.

## Example

```cs
NumberToText converter = new NumberToText();
string s = converter.Transform(123.45);
```

## Additional Information

For additional information, check the [Converting Numbers to Words](http://www.blackbeltcoder.com/Articles/strings/converting-numbers-to-words) article on Black Belt Coder.
