# DocuSign Rooms C# Client Changelog
See [DocuSign Support Center](https://support.docusign.com/en/releasenotes/) for Product Release Notes.

## [v2.0.0] - Rooms API v2-1.1.1 - 2024-07-30
### Changed
- Added support for version v2-1.1.1 of the DocuSign Rooms API.
- Updated the SDK release version.

## [v2.0.0-rc3] - Rooms API v2-1.1.1 - 2024-05-20
### Changed
- Updated C# SDK dependencies.
    - BouncyCastle.Cryptography: Version bumped from 2.3.0 to 2.3.1.
    - Microsoft.IdentityModel.JsonWebTokens: Version bumped from 7.5.1 to 7.5.2.
## [v2.0.0-rc2] - Rooms API v2-1.1.1 - 2024-04-29
### Breaking Changes
- Updated from System.IdentityModel.Tokens.Jwt to Microsoft.IdentityModel.JsonWebTokens for token handling.
## [v2.0.0-rc1] - Rooms API v2-1.1.1 - 2024-04-10
### Breaking Changes
- Updated C# SDK dependencies.
    - Microsoft.CSharp: Version bumped from 4.5.0 to 4.7.0.
    - Newtonsoft.Json: Version bumped from 13.0.1 to 13.0.3.
    - System.ComponentModel.Annotations: Version bumped from 4.5.0 to 5.0.0.
    - Microsoft.IdentityModel.Protocols: Version bumped from 5.4.0 to 7.3.1.
    - System.IdentityModel.Tokens.Jwt: Version bumped from 5.4.0 to 7.3.1.
    - BouncyCastle.Cryptography: Version bumped from 2.2.1 to 2.3.0.
### Changed
- Updated the SDK release version.

## [v1.4.2] - Rooms API v2-1.1.1 - 2023-12-15
### Changed
- Updated the SDK release version.
- Removed tracked files which are now present in .gitignore.

## [v1.4.1] - Rooms API v2-1.1.1 - 2023-05-10
### Changed
- Removed support for .NET Framework 4.5.2. Miminum requirement is now .NET Framework 4.6.2
- Removed [BouncyCastle.Crypto](https://www.nuget.org/packages/BouncyCastle) and [Portable.BouncyCastle](https://www.nuget.org/packages/Portable.BouncyCastle) dependencies as they've been deprecated and added [BouncyCastle.Cryptography](https://www.nuget.org/packages/BouncyCastle.Cryptography) which is the recommended replacement and is being maintained.
- Added support for version v2-1.1.1 of the DocuSign Rooms API.
- Updated the SDK release version.

## [v1.3.0] - Rooms API v2-1.1.0 - 2023-01-30
### Changed
- Added support for version v2-1.1.0 of the DocuSign Rooms API.
- Updated the SDK release version.

## [1.2.0-rc] - Rooms API v2-1.0.9 - 2021-10-06
### Changed
- Added support for version v2-1.0.9 of the DocuSign Rooms API.
- Updated the SDK release version.


## [v1.1.0] - DocuSign Rooms API v2 - 03/25/2021
### Changed
- Updated the SDK release version

## [v1.1.0-rc] - DocuSign Rooms API v2 - 12/14/2020
### Changed
- Added support for version v2-1.0.8 of the DocuSign eSignature API.
- Updated the SDK release version

## [v1.0.0] - DocuSign Rooms API v2 - 10/15/2020
### Changed
- First GA version of Rooms API.
