#define MyAppName "Shadownaives"
#define MyAppVersion "0.0.0.2"
#define MyAppPublisher "Lightsail"
#define Copyright "Lightsail"
#define Version "0.0.0.2"

[Setup]
AppId={{CEB321CC-9ACE-4A10-8028-D88D90C824BE}
AppName={#MyAppName}

AppVerName={#MyAppName} {#MyAppVersion}

DefaultDirName=C:\Users\Default\{#MyAppName}
DisableDirPage=yes
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
OutputBaseFilename={#MyAppName}-Setup
Compression=zip
SolidCompression=yes
WizardStyle=modern
VersionInfoCompany={#MyAppPublisher}
VersionInfoVersion={#MyAppVersion}
VersionInfoCopyright={#MyAppPublisher} inc
VersionInfoProductVersion={#MyAppVersion}
PrivilegesRequired=admin
AppVersion={#Version}
AppPublisher={#Copyright} Inc.
AppCopyright=Copyright (C) 2022-2022 {#Copyright} Inc.


[Files]
Source: "D:\nnp\*" ; DestDir: "{app}\"; Flags: ignoreversion
Source: "D:\nnp\naive\*"; DestDir: "{app}\naive"; Flags: ignoreversion
Source: "D:\nnp\naive\logs\*"; DestDir: "{app}\naive\logs"; Flags: ignoreversion

[run]
Filename: "{app}\install.bat"; Flags: runhidden

[UninstallRun]
Filename: "{app}\uninstall.bat"; Flags: runhidden

[Messages]
SetupAppTitle={#MyAppName}
SetupWindowTitle={#MyAppName}BeveledLabel=Copyright (C) 2022-2022 {#Copyright}, Inc.

[icons]
Name: "{userdesktop}\Shadownaives";Filename: "{app}\shadownaives.exe"; WorkingDir: "{app}"