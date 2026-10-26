// Shared bootstrap: #load this from any other script in this folder.
//
//     dotnet build src/Flexi.Yaml/Flexi.Yaml.fsproj
//     dotnet fsi examples/quickstart.fsx
//
// Rebuild the library after code changes so the scripts pick them up.

#r "../src/Flexi.Yaml/bin/Debug/net8.0/Flexi.Yaml.dll"

open Flexi.Yaml
open Flexi.Yaml.YamlExtensions
