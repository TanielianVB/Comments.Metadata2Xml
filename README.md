# Comments.Metadata2Xml
A simple Windows Forms Application to transform metadata comments in xml comments.

### Transforms this:
```C#
// Summary:
//     In a specified input string, replaces all strings that match a specified regular
//     expression with a specified replacement string.
//
// Parameters:
//   input:
//     The string to search for a match.
//
//   pattern:
//     The regular expression pattern to match.
//
//   replacement:
//     The replacement string.
//
// Returns:
//     A new string that is identical to the input string, except that the replacement
//     string takes the place of each matched string. If pattern is not matched in the
//     current instance, the method returns the current instance unchanged.
//
// Exceptions:
//   T:System.ArgumentException:
//     A regular expression parsing error occurred.
//
//   T:System.ArgumentNullException:
//     input, pattern, or replacement is null.
//
//   T:System.Text.RegularExpressions.RegexMatchTimeoutException:
//     A time-out occurred. For more information about time-outs, see the Remarks section.
```

### Into this:
```C#
/// <summary>
/// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.
/// </summary>
/// <param name="input">The string to search for a match.</param>
/// <param name="pattern">The regular expression pattern to match.</param>
/// <param name="replacement">The replacement string.</param>
/// <returns>A new string that is identical to the input string, except that the replacement string takes the place of each matched string. If pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
/// <exception cref="System.ArgumentException">A regular expression parsing error occurred.</exception>
/// <exception cref="System.ArgumentNullException">input, pattern, or replacement is null.</exception>
/// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
```
