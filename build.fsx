#r "./packages/FAKE/tools/FakeLib.dll"
open Fake
 
let buildDir = "./bin/"
let targetSln = ["./MvvmCross.FSharp.sln"]
let pclFile = "./bin/Release/MvvmCross.FSharp.dll"
let pclDestination = "./build/lib/portable-net45+win+wpa81+wp80/"
 
// Targets
Target "Clean" (fun _ -> CleanDir buildDir)
Target "Build" (fun _ -> MSBuildRelease "" "" targetSln |> Log "Build: ")
Target "Copy" (fun _ -> 
  CreateDir pclDestination
  CopyFile pclDestination pclFile
)

// Dependencies
"Clean"
==> "Build"
==> "Copy"

RunTargetOrDefault "Build"