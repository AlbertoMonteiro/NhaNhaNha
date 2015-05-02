$dllPath = gi ".\bin\Debug\NhaNhaNha.dll";
$assembly = [System.Reflection.Assembly]::LoadFrom($dllPath);
$newVersion = $assembly.GetName().Version.ToString();
[xml]$nuspec = Get-Content .\NhaNhaNha.nuspec;
$nuspec.package.metadata.version = $newVersion;
$file = gi ".\NhaNhaNha.nuspec";
$nuspec.Save($file);