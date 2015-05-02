$dllPath = gi ".\NhaNhaNha\bin\Release\NhaNhaNha.dll";
$assembly = [System.Reflection.Assembly]::LoadFrom($dllPath);
$newVersion = $assembly.GetName().Version.ToString();
[xml]$nuspec = Get-Content .\NhaNhaNha\NhaNhaNha.nuspec;
$nuspec.package.metadata.version = $newVersion;
$file = gi ".\NhaNhaNha\NhaNhaNha.nuspec";
$nuspec.Save($file);