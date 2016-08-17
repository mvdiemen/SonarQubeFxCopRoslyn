# SonarQubeFxCopRoslyn

Used versions:
 - SonarQube MSBuild runner 2.1
 - SonarQube 5.6.1
 - C# plugin 5.3.2
 - Visual Studio 2015 Update 3

Configuration of environment
 - Install SonarQube
 - Restore the quality profiles Default.xml and Extension.xml
 - The parent of the Extension(.xml) Quality Profile is the Default(.xml) Quality profile.
 - Install Visual Studio 2015 Update 3
 - Download the SonarQube MSBuild runner

Steps to reproduce
 - Download repro to local machine
 - Restore NuGet packages for this project in the repro
 - Open Visual Studio Developer Command Prompt and navigate to the directory where the .sln file is located.
 - Run the following command: <location of SonarQube MSBuild runner>\MSBuild.SonarQube.Runner.exe" /k:test /n:test /v:1.0
 - Run the following command: MsBuild /t:rebuild
 - You will receive the following error:
```
OverrideCodeAnalysisProperties:
  Running FxCop analysis using the SonarQube ruleset. Ruleset: C:\Users\AdminUser\Documents\Visual Studio 2015\Projects\ConsoleApplication\.sonarqube\conf\\SonarQubeFxCop-cs.ruleset
RunCodeAnalysis:
  Running Code Analysis...
  C:\Program Files (x86)\Microsoft Visual Studio 14.0\Team Tools\Static Analysis Tools\FxCop\FxCopCmd.exe  /outputCulture:1033 /out:"bin\Debug\ConsoleApplication.exe.CodeAnalysisLog.xml" /file:"bin\Debug\ConsoleApplication.exe" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\Microsoft.CSharp.dll" 
  /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Data.DataSetExtensions.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Data.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Net.Http.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Xml.dll" 
  /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Xml.Linq.dll" /directory:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1" /ruleSet:"=C:\Users\AdminUser\Documents\Visual Studio 2015\Projects\ConsoleApplication\.sonarqube\conf\\SonarQubeFxCop-cs.ruleset" 
  /rulesetdirectory:"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Team Tools\Static Analysis Tools\\Rule Sets" /rule:"-C:\Program Files (x86)\Microsoft Visual Studio 14.0\Team Tools\Static Analysis Tools\FxCop\\Rules" /ruleid:"-Microsoft.Interoperability#CA1401" /ruleid:"-Microsoft.Globalization#CA2101" /ruleid:"-Microsoft.Globalization#CA1304" 
  /ruleid:"-Microsoft.Globalization#CA1305" /ruleid:"-Microsoft.Globalization#CA1307" /ruleid:"-Microsoft.Globalization#CA1308" 
  /ruleid:"-Microsoft.Performance#CA1813" /ruleid:"-Microsoft.Performance#CA1820" /ruleid:"-Microsoft.Reliability#CA2002" /ruleid:"-Microsoft.Usage#CA1816
          -Microsoft.Usage#CA2208" /ruleid:"-Microsoft.Usage#CA2216" /ruleid:"-Microsoft.Usage#CA2241" /ruleid:"-Microsoft.Usage#CA2242" 
          /ruleid:"-Microsoft.Performance#CA1802" /ruleid:"-Microsoft.Performance#CA1814" /ruleid:"-Microsoft.Performance#CA1821" 
          /ruleid:"-Microsoft.Performance#CA1822" /ruleid:"-Microsoft.Usage#CA2214" /ruleid:"-Microsoft.Usage#CA2219" 
          /ruleid:"-Microsoft.Performance#CA1801" /ruleid:"-Microsoft.Performance#CA1806" /ruleid:"-Microsoft.Performance#CA1823" 
          /ruleid:"-Microsoft.Design#CA1000" /ruleid:"-Microsoft.Design#CA1008" /ruleid:"-Microsoft.Design#CA1010" 
          /ruleid:"-Microsoft.Design#CA1012" /ruleid:"-Microsoft.Design#CA1014" /ruleid:"-Microsoft.Design#CA1016" 
          /ruleid:"-Microsoft.Design#CA1017" /ruleid:"-Microsoft.Design#CA1018" /ruleid:"-Microsoft.Design#CA1024" 
          /ruleid:"-Microsoft.Design#CA1027" /ruleid:"-Microsoft.Design#CA1028" /ruleid:"-Microsoft.Design#CA1030" 
          /ruleid:"-Microsoft.Design#CA1033" /ruleid:"-Microsoft.Design#CA1034" /ruleid:"-Microsoft.Design#CA1036" 
          /ruleid:"-Microsoft.Design#CA1041" /ruleid:"-Microsoft.Design#CA1043" /ruleid:"-Microsoft.Design#CA1050" 
          /ruleid:"-Microsoft.Design#CA1051" /ruleid:"-Microsoft.Design#CA1052" /ruleid:"-Microsoft.Design#CA1054" 
          /ruleid:"-Microsoft.Design#CA1055" /ruleid:"-Microsoft.Design#CA1056" /ruleid:"-Microsoft.Design#CA1060" 
          /ruleid:"-Microsoft.Design#CA1063" /ruleid:"-Microsoft.Design#CA1064" /ruleid:"-Microsoft.Design#CA1065" 
          /ruleid:"-Microsoft.Naming#CA1707" /ruleid:"-Microsoft.Naming#CA1708" /ruleid:"-Microsoft.Naming#CA1710" 
          /ruleid:"-Microsoft.Naming#CA1714" /ruleid:"-Microsoft.Naming#CA1715" /ruleid:"-Microsoft.Naming#CA1716" 
          /ruleid:"-Microsoft.Naming#CA1717" /ruleid:"-Microsoft.Naming#CA1720" 
          /ruleid:"-Microsoft.Naming#CA1721" /ruleid:"-Microsoft.Naming#CA1724" /ruleid:"-Microsoft.Naming#CA1725" 
          /ruleid:"-Microsoft.Performance#CA1815" /ruleid:"-Microsoft.Performance#CA1819" /ruleid:"-Microsoft.Usage#CA2211" 
          /ruleid:"-Microsoft.Usage#CA2217" /ruleid:"-Microsoft.Usage#CA2222" /ruleid:"-Microsoft.Usage#CA2225" 
          /ruleid:"-Microsoft.Usage#CA2226" /ruleid:"-Microsoft.Usage#CA2227" 
          /ruleid:"-Microsoft.Usage#CA2231" /ruleid:"-Microsoft.Design#CA1058" /ruleid:"-Microsoft.Usage#CA2229" 
          /ruleid:"-Microsoft.Usage#CA2235" /ruleid:"-Microsoft.Usage#CA2237" /searchgac /ignoreinvalidtargets /forceoutput 
          /successfile /ignoregeneratedcode /saveMessagesToReport:Active,Excluded /timeout:120 /reportMissingIndirectAssemblies 
  Switch '/microsoft.usage#ca2208" /ruleid' is an unknown switch.
  
  Type 'FxCopCmd.exe /?' for help on command-line arguments.
MSBUILD : error : CA0059 : Invalid settings passed to CodeAnalysis task. See output window for details. [C:\Users\AdminUser\Documents\Visual Studio 2015\Projects\ConsoleApplication\ConsoleApplication\ConsoleApplication.csproj]
  Code Analysis Complete -- 1 error(s), 0 warning(s)
Done Building Project "C:\Users\AdminUser\Documents\Visual Studio 2015\Projects\ConsoleApplication\ConsoleApplication\ConsoleApplication.csproj" (Rebuild target(s)) -- FAILED.
Done Building Project "C:\Users\AdminUser\Documents\Visual Studio 2015\Projects\ConsoleApplication\ConsoleApplication.sln" (rebuild target(s)) -- FAILED.

Build FAILED.
``` 
