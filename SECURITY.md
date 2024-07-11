# Security Policy
Starting with 1.3-beta-1, MSActivate has implemented an automatic security upgrade system.
In case of a security vunerability in MSActivate or in any of it's dependencies, MSActivate can release a security update at any time to remove features that have been compromised or affected.
We use a public [Pastebin](https://pastebin.com/4syXnW8w) to check for updates online. If the value is anything but "no", MSActivate will display an error message advising users to upgrade immediately.

## Security Updates Support
| Version  | Supported           |
| -------  | ------------------  |
| 1.3      | ✔️                 |
| 1.2      | Current Version     |
| > 1.2    | ❌                 |

## New Repository Pull Request Rules
- The security upgrade system can not be modified without explicit review and acceptance from multiple different reviewers.
- If modified, it can not download MSActivate from any other sources besides github.com (excluding githubusercontent.com)

## Dependencies
MSActivate has these dependencies:
- .NET Framework (@4.0)
- MSGuides.com KMS (website)
- PastebinAPI for C# (@1.1) **note: no longer in use**

In these cases. see below.

## Dependency Compromise Instructions
### .NET Framework
If .NET is compromised and a build has been released after the compromise date, MSActivate is to immediately delete itself after providing an error message. .NET supports the entire apps activation structure and if not safe to use, MSActivate can not even run.

### MSGuides.com KMS
In this case, MSActivate can implement a different activation system. There are many different ways to activate Windows for free excluding MSGuides.com.

### PastebinAPI for C#
The PastebinAPI is not being used anymore in favor of downloading raw data in C# itself. It can be safely ignored.